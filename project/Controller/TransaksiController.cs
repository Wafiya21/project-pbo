using project.Model;
using System;
using System.Collections.Generic;

namespace project.Controller
{
    public class TransaksiController
    {
        public static bool CreateTransaksi(int idAkunCustomer, decimal totalBayar, int kodeUnik)
        {
            var transaksi = new TransaksiModel
            {
                IdAkunCustomer = idAkunCustomer,
                TanggalTransaksi = DateTime.Now,
                TotalBayar = totalBayar,
                KodeUnik = kodeUnik,
                Status = "Menunggu Pembayaran"
            };
            return transaksi.Insert();
        }
        public static bool UpdateStatusTransaksi(int idTransaksi, string statusBaru)
        {
            var transaksi = new TransaksiModel { IdTransaksi = idTransaksi };
            return transaksi.UpdateStatus(statusBaru);
        }

        public static TransaksiModel? GetTransaksiById(int id)
        {
            return TransaksiModel.FindById(id);
        }

        public static List<TransaksiModel> GetTransaksiByAkunCust(int idAkunCustomer)
        {
            return TransaksiModel.GetByIdAkunCust(idAkunCustomer);
        }

        public static List<TransaksiModel> GetAllTransaksi()
        {
            return TransaksiModel.GetAll();
        }

        // Batalkan transaksi + kembalikan stok
        public static bool BatalkanTransaksi(int idTransaksi)
        {
            // Ambil detail transaksi
            var details = DetailTransaksiModel.GetByIdTransaksi(idTransaksi);
            bool stokOk = true;
            foreach (var d in details)
            {
                var menu = MenuModel.FindById(d.IdMenu);
                if (menu != null)
                {
                    menu.Stok += d.Qty;
                    stokOk &= menu.Update();
                }
            }
            // Update status transaksi
            return stokOk && UpdateStatusTransaksi(idTransaksi, "Dibatalkan");
        }

        // Konfirmasi sudah bayar
        public static bool KonfirmasiSudahBayar(int idTransaksi)
        {
            return UpdateStatusTransaksi(idTransaksi, "Menunggu Verifikasi");
        }

        // Batalkan transaksi oleh admin + kembalikan stok
        public static bool BatalkanTransaksiAdmin(int idTransaksi)
        {
            // Ambil detail transaksi
            var details = DetailTransaksiModel.GetByIdTransaksi(idTransaksi);
            bool stokOk = true;
            foreach (var d in details)
            {
                var menu = MenuModel.FindById(d.IdMenu);
                if (menu != null)
                {
                    menu.Stok += d.Qty;
                    stokOk &= menu.Update();
                }
            }
            // Update status transaksi
            return stokOk && UpdateStatusTransaksi(idTransaksi, "Dibatalkan Admin");
        }
    }
}