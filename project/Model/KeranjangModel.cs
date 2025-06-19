using ADP_Bakery;
using Npgsql;
using System;
using System.Collections.Generic;

namespace project.Model
{
    public class KeranjangModel
    {
        private int _idKeranjang;
        private int _idAkunCustomer;
        private int _idMenu;
        private int _qty;
        private string _namaMenu = string.Empty;
        private decimal _harga;
        private decimal _hargaSatuan;
        private int _stok;

        public KeranjangModel() { }

        public KeranjangModel(int idKeranjang, int idAkunCustomer, int idMenu, int qty, string namaMenu, decimal hargaSatuan, int stok)
        {
            IdKeranjang = idKeranjang;
            IdAkunCustomer = idAkunCustomer;
            IdMenu = idMenu;
            Qty = qty;
            NamaMenu = namaMenu;
            HargaSatuan = hargaSatuan;
            Stok = stok;
        }

        public int IdKeranjang
        {
            get => _idKeranjang;
            set => _idKeranjang = value;
        }

        public int IdAkunCustomer
        {
            get => _idAkunCustomer;
            set => _idAkunCustomer = value;
        }

        public int IdMenu
        {
            get => _idMenu;
            set => _idMenu = value;
        }

        public int Qty
        {
            get => _qty;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Qty harus lebih dari 0");
                _qty = value;
            }
        }

        public decimal HargaSatuan
        {
            get => _hargaSatuan;
            set => _hargaSatuan = value;
        }

        public decimal HargaTotal => Qty * HargaSatuan;

        public string NamaMenu
        {
            get => _namaMenu;
            set => _namaMenu = value;
        }

        public decimal Harga
        {
            get => _harga;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Harga tidak boleh negatif");
                _harga = value;
            }
        }

        public int Stok
        {
            get => _stok;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stok tidak boleh negatif");
                _stok = value;
            }
        }

        public static List<KeranjangModel> GetByAkunCustId(int idAkunCustomer)
        {
            var list = new List<KeranjangModel>();
            using var conn = DbContext.GetConnection();
            conn.Open();

            const string q = @"
            SELECT 
                k.id_keranjang,
                k.id_akun_customer,
                k.id_menu,
                k.qty,
                m.nama,
                m.harga,
                m.stok
            FROM keranjang k
            JOIN menu m ON m.id_menu = k.id_menu
            WHERE k.id_akun_customer = @IdAkunCustomer
            ORDER BY k.id_keranjang ASC";

            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("IdAkunCustomer", idAkunCustomer);

            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new KeranjangModel(
                    rd.GetInt32(0),  // id_keranjang
                    rd.GetInt32(1),  // id_akun_customer
                    rd.GetInt32(2),  // id_menu
                    rd.GetInt32(3),  // qty
                    rd.GetString(4), // nama
                    rd.GetDecimal(5),// harga
                    rd.GetInt32(6)   // stok
                ));
            }

            return list;
        }

        public bool Insert()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();

            const string q = @"
            INSERT INTO keranjang (id_akun_customer, id_menu, qty)
            VALUES (@IdAkunCustomer, @IdMenu, @Qty)
            RETURNING id_keranjang";

            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("IdAkunCustomer", IdAkunCustomer);
            cmd.Parameters.AddWithValue("IdMenu", IdMenu);
            cmd.Parameters.AddWithValue("Qty", Qty);

            var result = cmd.ExecuteScalar();
            if (result is int newId)
            {
                _idKeranjang = newId;
                return true;
            }
            return false;
        }

        public bool Delete()
        {
            if (_idKeranjang == 0)
                throw new InvalidOperationException("IdKeranjang belum diset.");

            using var conn = DbContext.GetConnection();
            conn.Open();

            const string q = @"DELETE FROM keranjang WHERE id_keranjang = @Id";

            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", _idKeranjang);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool DeleteByAkunCustId(int idAkunCustomer)
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"DELETE FROM keranjang WHERE id_akun_customer = @IdAkunCustomer";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("IdAkunCustomer", idAkunCustomer);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

}
