using project.Model;
using System.Collections.Generic;

namespace project.Controller
{
    public class AkunAdminController
    {
        public static AkunAdminModel? Login(string username, string password)
        {
            return AkunAdminModel.Auth(username, password);
        }
        public static List<AkunAdminModel> GetAllAkunAdmin()
        {
            return AkunAdminModel.GetAll();
        }

        public static AkunAdminModel? GetAkunAdminById(int id)
        {
            return AkunAdminModel.FindById(id);
        }

        public static AkunAdminModel? GetAkunAdminByUsername(string username)
        {
            return AkunAdminModel.FindByUsername(username);
        }

        public static bool AddAkunAdmin(AkunAdminModel akunAdmin)
        {
            return akunAdmin.Insert();
        }

        public static bool UpdateAkunAdmin(AkunAdminModel akunAdmin)
        {
            return akunAdmin.Update();
        }

        public static bool DeleteAkunAdmin(int idAkunAdmin)
        {
            var akun = AkunAdminModel.FindById(idAkunAdmin);
            if (akun != null)
            {
                return akun.Delete();
            }
            return false;
        }
    }
}
