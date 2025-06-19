using ADP_Bakery;
using Npgsql;
using System;
using System.Collections.Generic;

namespace project.Model
{
    public class TransaksiModel
    {
        public int IdTransaksi { get; set; }
        public int IdAkunCustomer { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public decimal TotalBayar { get; set; }
        public int KodeUnik { get; set; }
        public string Status { get; set; } = "Menunggu Pembayaran";

        public bool Insert()
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"INSERT INTO transaksi 
            (id_akun_customer, tanggal_transaksi, total_bayar, kode_unik, status)
            VALUES (@IdAkunCustomer, @Tanggal, @Total, @KodeUnik, @Status)
            RETURNING id_transaksi";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("IdAkunCustomer", IdAkunCustomer);
            cmd.Parameters.AddWithValue("Tanggal", TanggalTransaksi);
            cmd.Parameters.AddWithValue("Total", TotalBayar);
            cmd.Parameters.AddWithValue("KodeUnik", KodeUnik);
            cmd.Parameters.AddWithValue("Status", Status);
            var result = cmd.ExecuteScalar();
            if (result is int newId)
            {
                IdTransaksi = newId;
                return true;
            }
            return false;
        }

        public bool UpdateStatus(string statusBaru)
        {
            if (IdTransaksi == 0)
                throw new InvalidOperationException("IdTransaksi belum diset.");
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"UPDATE transaksi SET status = @Status WHERE id_transaksi = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Status", statusBaru);
            cmd.Parameters.AddWithValue("Id", IdTransaksi);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static TransaksiModel? FindById(int id)
        {
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_transaksi, id_akun_customer, tanggal_transaksi, total_bayar, kode_unik, status 
                           FROM transaksi WHERE id_transaksi = @Id";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", id);
            using var rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                return new TransaksiModel
                {
                    IdTransaksi = rd.GetInt32(0),
                    IdAkunCustomer = rd.GetInt32(1),
                    TanggalTransaksi = rd.GetDateTime(2),
                    TotalBayar = rd.GetDecimal(3),
                    KodeUnik = rd.GetInt32(4),
                    Status = rd.GetString(5)
                };
            }
            return null;
        }

        public static List<TransaksiModel> GetByIdAkunCust(int idAkunCustomer)
        {
            var list = new List<TransaksiModel>();
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_transaksi, id_akun_customer, tanggal_transaksi, total_bayar, kode_unik, status 
                           FROM transaksi WHERE id_akun_customer = @Id ORDER BY id_transaksi DESC";
            using var cmd = new NpgsqlCommand(q, conn);
            cmd.Parameters.AddWithValue("Id", idAkunCustomer);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new TransaksiModel
                {
                    IdTransaksi = rd.GetInt32(0),
                    IdAkunCustomer = rd.GetInt32(1),
                    TanggalTransaksi = rd.GetDateTime(2),
                    TotalBayar = rd.GetDecimal(3),
                    KodeUnik = rd.GetInt32(4),
                    Status = rd.GetString(5)
                });
            }
            return list;
        }

        public static List<TransaksiModel> GetAll()
        {
            var list = new List<TransaksiModel>();
            using var conn = DbContext.GetConnection();
            conn.Open();
            const string q = @"SELECT id_transaksi, id_akun_customer, tanggal_transaksi, total_bayar, kode_unik, status 
                           FROM transaksi ORDER BY id_transaksi DESC";
            using var cmd = new NpgsqlCommand(q, conn);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new TransaksiModel
                {
                    IdTransaksi = rd.GetInt32(0),
                    IdAkunCustomer = rd.GetInt32(1),
                    TanggalTransaksi = rd.GetDateTime(2),
                    TotalBayar = rd.GetDecimal(3),
                    KodeUnik = rd.GetInt32(4),
                    Status = rd.GetString(5)
                });
            }
            return list;
        }
    }
}