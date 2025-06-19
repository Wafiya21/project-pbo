using project.Model;
using System.Collections.Generic;

namespace project.Controller
{
    public class AkunCustomerController
    {
        public static AkunCustomerModel? Login(string username, string password)
        {
            return AkunCustomerModel.Auth(username, password);
        }

        public static List<AkunCustomerModel> GetAllAkunCustomer()
        {
            return AkunCustomerModel.GetAll();
        }

        public static AkunCustomerModel? GetAkunCustomerById(int id)
        {
            return AkunCustomerModel.FindById(id);
        }

        public static AkunCustomerModel? GetAkunCustomerByUsername(string username)
        {
            return AkunCustomerModel.FindByUsername(username);
        }

        public static bool AddAkunCustomer(AkunCustomerModel akunCustomer)
        {
            return akunCustomer.Insert();
        }

        public static bool UpdateAkunCustomer(AkunCustomerModel akunCustomer)
        {
            return akunCustomer.Update();
        }

        public static bool DeleteAkunCustomer(int idAkunCustomer)
        {
            var akun = AkunCustomerModel.FindById(idAkunCustomer);

            if (akun != null)
            {
                List<TransaksiModel> cekTransaksi = new List<TransaksiModel>();
                cekTransaksi = TransaksiModel.GetByIdAkunCust(idAkunCustomer);

                if (cekTransaksi.Count > 0)
                {
                    return false;
                }

                return akun.Delete();
            }
            return false;
        }
    }
}
