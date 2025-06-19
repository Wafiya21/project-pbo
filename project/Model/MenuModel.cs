using ADP_Bakery;
using Npgsql;
using System;
using System.Collections.Generic;

namespace project.Model
{
    public class MenuModel
    {
        private int _idMenu;
        private string _nama = string.Empty;
        private decimal _harga;
        private int _stok;

        public MenuModel() { }

        public MenuModel(int idMenu, string nama, decimal harga, int stok)
        {
            IdMenu = idMenu;
            Nama = nama;
            Harga = harga;
            Stok = stok;
        }

        public int IdMenu
        {
            get => _idMenu;
            set => _idMenu = value;
        }

        public string Nama
        {
            get => _nama;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nama menu tidak boleh kosong!", nameof(value));
                _nama = value.Trim();
            }
        }

        public decimal Harga
        {
            get => _harga;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Harga tidak boleh negatif!", nameof(value));
                _harga = value;
            }
        }

        public int Stok
        {
            get => _stok;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stok tidak boleh negatif!", nameof(value));
                _stok = value;
            }
        }

        public static List<MenuModel> GetAll()
        {
            var list = new List<MenuModel>();
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_menu, nama, harga, stok FROM menu ORDER BY id_menu ASC";
            using var cmd = new NpgsqlCommand(q, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new MenuModel(
                    rd.GetInt32(0),
                    rd.GetString(1),
                    rd.GetDecimal(2),
                    rd.GetInt32(3)
                ));
            }
            return list;
        }

        public static MenuModel? FindById(int id)
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_menu, nama, harga, stok FROM menu WHERE id_menu = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", id);
            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new MenuModel(rd.GetInt32(0), rd.GetString(1), rd.GetDecimal(2), rd.GetInt32(3))
                : null;
        }

        public bool Insert()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"INSERT INTO menu (nama, harga, stok) VALUES (@Nama, @Harga, @Stok) RETURNING id_menu";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Nama", Nama);
            cmd.Parameters.AddWithValue("Harga", Harga);
            cmd.Parameters.AddWithValue("Stok", Stok);
            var result = cmd.ExecuteScalar();
            if (result is int newId)
            {
                _idMenu = newId;
                return true;
            }
            return false;
        }

        public bool Update()
        {
            if (_idMenu == 0)
                throw new InvalidOperationException("IdMenu belum diset.");
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"UPDATE menu SET nama = @Nama, harga = @Harga, stok = @Stok WHERE id_menu = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", _idMenu);
            cmd.Parameters.AddWithValue("Nama", Nama);
            cmd.Parameters.AddWithValue("Harga", Harga);
            cmd.Parameters.AddWithValue("Stok", Stok);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete()
        {
            if (_idMenu == 0)
                throw new InvalidOperationException("IdMenu belum diset.");
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = "DELETE FROM menu WHERE id_menu = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", _idMenu);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
