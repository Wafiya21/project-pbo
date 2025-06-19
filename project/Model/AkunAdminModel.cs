using ADP_Bakery;
using Npgsql;
using System;
using System.Collections.Generic;

namespace project.Model
{
    public class AkunAdminModel
    {
        private int _idAkunAdmin;
        private string _username = string.Empty;
        private string _password = string.Empty;

        public AkunAdminModel() { }

        public AkunAdminModel(int idAkunAdmin, string username, string password)
        {
            IdAkunAdmin = idAkunAdmin;
            Username = username;
            Password = password;
        }

        public int IdAkunAdmin
        {
            get => _idAkunAdmin;
            set => _idAkunAdmin = value;
        }

        public string Username
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Username tidak boleh kosong!", nameof(value));
                _username = value.Trim();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Password tidak boleh kosong!", nameof(value));
                _password = value;
            }
        }

        public static AkunAdminModel? Auth(string username, string password)
        {
            AkunAdminModel? akun = null;
            using var conn = DbContext.GetConnection();
            conn.Open();

            string query = "SELECT id_akun_admin, username, password FROM akun_admin WHERE username = @username AND password = @password";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                akun = new AkunAdminModel(
                    reader.GetInt32(0),  // id_akun
                    reader.GetString(1), // username
                    reader.GetString(2)  // password
                );
            }

            return akun;
        }


        public static List<AkunAdminModel> GetAll()
        {
            var list = new List<AkunAdminModel>();
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_akun_admin, username, password FROM akun_admin ORDER BY id_akun_admin ASC";
            using var cmd = new NpgsqlCommand(q, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new AkunAdminModel(
                    rd.GetInt32(0),
                    rd.GetString(1),
                    rd.GetString(2)
                ));
            }
            return list;
        }

        public static AkunAdminModel? FindById(int id)
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_akun_admin, username, password FROM akun_admin WHERE id_akun_admin = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", id);
            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new AkunAdminModel(rd.GetInt32(0), rd.GetString(1), rd.GetString(2))
                : null;
        }

        public static AkunAdminModel? FindByUsername(string username)
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_akun_admin, username, password FROM akun_admin WHERE username = @Username";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Username", username);
            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new AkunAdminModel(rd.GetInt32(0), rd.GetString(1), rd.GetString(2))
                : null;
        }

        public bool Insert()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"INSERT INTO akun_admin (username, password) VALUES (@Username, @Password) RETURNING id_akun_admin";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("Password", Password);
            var result = cmd.ExecuteScalar();
            if (result is int newId)
            {
                _idAkunAdmin = newId;
                return true;
            }
            return false;
        }

        public bool Update()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"UPDATE akun_admin SET username = @Username, password = @Password WHERE id_akun_admin = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", _idAkunAdmin);
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("Password", Password);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = "DELETE FROM akun_admin WHERE id_akun_admin = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", _idAkunAdmin);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
