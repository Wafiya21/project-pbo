using project.Model;
using System.Collections.Generic;

namespace project.Controller
{
    public class MenuController
    {
        public static List<MenuModel> GetAllMenu()
        {
            return MenuModel.GetAll();
        }

        public static MenuModel? GetMenuById(int id)
        {
            return MenuModel.FindById(id);
        }

        public static bool AddMenu(MenuModel menu)
        {
            return menu.Insert();
        }

        public static bool UpdateMenu(MenuModel menu)
        {
            return menu.Update();
        }

        public static bool DeleteMenu(int idMenu)
        {
            var menu = MenuModel.FindById(idMenu);
            if (menu != null)
            {
                List<MenuModel> cekMenu = new List<MenuModel>();
                if (cekMenu.Count > 0)
                {
                    MessageBox.Show("Menu tidak bisa dihapus karena digunakan dalam transaksi!");
                    return false;
                }
                return menu.Delete();
            }
            return false;
        }
    }
}
