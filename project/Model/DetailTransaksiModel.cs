using ADP_Bakery;
using Npgsql;
using System;
using System.Collections.Generic;

namespace project.Model
{
    public class DetailTransaksiModel
    {
        private int _idDetailTransaksi;
        private int _idTransaksi;
        private int _idMenu;
        private int _qty;
        private decimal _hargaSatuan;
        private string _namaMenu = string.Empty;

        public int IdDetailTransaksi
        {
            get => _idDetailTransaksi;
            set => _idDetailTransaksi = value;
        }
        public int IdTransaksi
        {
            get => _idTransaksi;
            set => _idTransaksi = value;
        }
        public int IdMenu
        {
            get => _idMenu;
            set => _idMenu = value;
        }
        public int Qty
        {
            get => _qty;
            set => _qty = value;
        }
        public decimal HargaSatuan
        {
            get => _hargaSatuan;
            set => _hargaSatuan = value;
        }
        public string NamaMenu
        {
            get => _namaMenu;
            set => _namaMenu = value;
        }
        public decimal SubTotal => Qty * HargaSatuan;

        public DetailTransaksiModel() { }
        public DetailTransaksiModel(int idDetailTransaksi, int idTransaksi, int idMenu, int qty, decimal hargaSatuan, string namaMenu = "")
        {
            IdDetailTransaksi = idDetailTransaksi;
            IdTransaksi = idTransaksi;
            IdMenu = idMenu;
            Qty = qty;
            HargaSatuan = hargaSatuan;
            NamaMenu = namaMenu;
        }

        public bool Insert()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"
            INSERT INTO detail_transaksi (id_transaksi, id_menu, qty, harga_satuan)
            VALUES (@IdTransaksi, @IdMenu, @Qty, @HargaSatuan)
            RETURNING id_detail_transaksi";

            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("IdTransaksi", IdTransaksi);
            cmd.Parameters.AddWithValue("IdMenu", IdMenu);
            cmd.Parameters.AddWithValue("Qty", Qty);
            cmd.Parameters.AddWithValue("HargaSatuan", HargaSatuan);

            var result = cmd.ExecuteScalar();
            if (result is int newId)
            {
                IdDetailTransaksi = newId;
                return true;
            }

            return false;
        }

        public static List<DetailTransaksiModel> GetByIdTransaksi(int idTransaksi)
        {
            var list = new List<DetailTransaksiModel>();
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"
            SELECT d.id_detail_transaksi, d.id_transaksi, d.id_menu, d.qty, d.harga_satuan, m.nama
            FROM detail_transaksi d
            JOIN menu m ON d.id_menu = m.id_menu
            WHERE d.id_transaksi = @IdTransaksi
            ORDER BY d.id_detail_transaksi ASC";

            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("IdTransaksi", idTransaksi);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new DetailTransaksiModel(
                    rd.GetInt32(0),
                    rd.GetInt32(1),
                    rd.GetInt32(2),
                    rd.GetInt32(3),
                    rd.GetDecimal(4),
                    rd.GetString(5)
                ));
            }
            return list;
        }

        public static List<DetailTransaksiModel> GetByIdMenu(int idMenu)
        {
            var list = new List<DetailTransaksiModel>();
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"
                SELECT id_detail_transaksi, id_transaksi, id_menu, qty, harga_satuan
                FROM detail_transaksi
                WHERE id_menu = @IdMenu";

            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("IdMenu", idMenu);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new DetailTransaksiModel(
                    rd.GetInt32(0),
                    rd.GetInt32(1),
                    rd.GetInt32(2),
                    rd.GetInt32(3),
                    rd.GetDecimal(4)
                ));
            }
            return list;
        }
    }
}