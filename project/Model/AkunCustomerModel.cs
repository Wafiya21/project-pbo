using ADP_Bakery;
using Npgsql;
using System;
using System.Collections.Generic;

namespace project.Model
{
    public class AkunCustomerModel
    {
        private int _idAkunCustomer;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _noHp = string.Empty;
        private bool _isMember;

        public AkunCustomerModel() { }

        public AkunCustomerModel(int idAkunCustomer, string username, string password, string noHp, bool isMember)
        {
            IdAkunCustomer = idAkunCustomer;
            Username = username;
            Password = password;
            NoHp = noHp;
            IsMember = isMember;
        }

        public int IdAkunCustomer
        {
            get => _idAkunCustomer;
            set => _idAkunCustomer = value;
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

        public string NoHp
        {
            get => _noHp;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nomor HP tidak boleh kosong!", nameof(value));
                _noHp = value.Trim();
            }
        }

        public bool IsMember
        {
            get => _isMember;
            set => _isMember = value;
        }

        public string MemberStatus => IsMember ? "Ya" : "Tidak";

        public static AkunCustomerModel? Auth(string username, string password)
        {
            AkunCustomerModel? akun = null;
            using var conn = DbContext.GetConnection();
            conn.Open();

            string query = "SELECT id_akun_customer, username, password, no_hp, is_member FROM akun_customer WHERE username = @username AND password = @password";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                akun = new AkunCustomerModel(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetBoolean(4)
                );
            }

            return akun;
        }

        public static List<AkunCustomerModel> GetAll()
        {
            var list = new List<AkunCustomerModel>();
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_akun_customer, username, password, no_hp, is_member FROM akun_customer ORDER BY id_akun_customer ASC";
            using var cmd = new NpgsqlCommand(q, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new AkunCustomerModel(
                    rd.GetInt32(0),
                    rd.GetString(1),
                    rd.GetString(2),
                    rd.GetString(3),
                    rd.GetBoolean(4)
                ));
            }
            return list;
        }

        public static AkunCustomerModel? FindById(int id)
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_akun_customer, username, password, no_hp, is_member FROM akun_customer WHERE id_akun_customer = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", id);
            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new AkunCustomerModel(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetBoolean(4))
                : null;
        }

        public static AkunCustomerModel? FindByUsername(string username)
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_akun_customer, username, password, no_hp, is_member FROM akun_customer WHERE username = @Username";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Username", username);
            using var rd = cmd.ExecuteReader();
            return rd.Read()
                ? new AkunCustomerModel(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetBoolean(4))
                : null;
        }
        public bool Insert()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"INSERT INTO akun_customer (username, password, no_hp, is_member) 
                               VALUES (@Username, @Password, @NoHp, @IsMember) 
                               RETURNING id_akun_customer";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("Password", Password);
            cmd.Parameters.AddWithValue("NoHp", NoHp);
            cmd.Parameters.AddWithValue("IsMember", IsMember);
            var result = cmd.ExecuteScalar();
            if (result is int newId)
            {
                _idAkunCustomer = newId;
                return true;
            }
            return false;
        }

        public bool Update()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"UPDATE akun_customer 
                               SET username = @Username, password = @Password, no_hp = @NoHp, is_member = @IsMember 
                               WHERE id_akun_customer = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", _idAkunCustomer);
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("Password", Password);
            cmd.Parameters.AddWithValue("NoHp", NoHp);
            cmd.Parameters.AddWithValue("IsMember", IsMember);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = "DELETE FROM akun_customer WHERE id_akun_customer = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", _idAkunCustomer);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
