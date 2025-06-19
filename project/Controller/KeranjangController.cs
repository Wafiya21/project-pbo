using project.Helpers;
using project.Model;
using System.Collections.Generic;

namespace project.Controller
{
    public class KeranjangController
    {
        public static List<KeranjangModel> GetKeranjangByUserId(int idUser)
        {
            return KeranjangModel.GetByAkunCustId(idUser);
        }

        public static bool AddToKeranjang(KeranjangModel keranjang)
        {
            return keranjang.Insert();
        }

        public static bool DeleteFromKeranjang(int idKeranjang)
        {
            var item = new KeranjangModel { IdKeranjang = idKeranjang };
            return item.Delete();
        }

        public static bool Checkout(int idCustomer)
        {
            var keranjang = KeranjangModel.GetByAkunCustId(idCustomer);
            if (keranjang.Count == 0) return false;

            // Gabungkan qty untuk menu yang sama
            var grouped = keranjang
                .GroupBy(k => k.IdMenu)
                .Select(g => new
                {
                    IdMenu = g.Key,
                    TotalQty = g.Sum(k => k.Qty),
                    HargaSatuan = g.First().HargaSatuan
                }).ToList();

            // Verifikasi stok
            foreach (var item in grouped)
            {
                var menu = MenuModel.FindById(item.IdMenu);
                if (menu == null || menu.Stok < item.TotalQty)
                {
                    throw new Exception($"Stok tidak mencukupi untuk menu: {menu?.Nama ?? "Unknown"}");
                }
            }

            // Hitung total bayar
            decimal total = grouped.Sum(i => i.TotalQty * i.HargaSatuan);
            if (CustomerSession.IsMember)
            {
                total = total * 0.95m;
            }

            // Tambahkan kode unik 3 digit acak (misal antara 1 - 999)
            Random rnd = new Random();
            int kodeUnik = rnd.Next(1, 999);
            decimal totalFinal = total + kodeUnik;

            var transaksi = new TransaksiModel
            {
                IdAkunCustomer = idCustomer,
                TotalBayar = totalFinal,
                KodeUnik = kodeUnik,
                TanggalTransaksi = DateTime.Now
            };

            if (!transaksi.Insert()) return false;

            foreach (var item in grouped)
            {
                var detail = new DetailTransaksiModel
                {
                    IdTransaksi = transaksi.IdTransaksi,
                    IdMenu = item.IdMenu,
                    Qty = item.TotalQty,
                    HargaSatuan = item.HargaSatuan
                };
                detail.Insert();

                var menu = MenuModel.FindById(item.IdMenu);
                menu.Stok -= item.TotalQty;
                menu.Update();
            }

            // Kosongkan keranjang
            var keranjangToDelete = new KeranjangModel();
            keranjangToDelete.DeleteByAkunCustId(idCustomer);
            return true;
        }
    }
}
