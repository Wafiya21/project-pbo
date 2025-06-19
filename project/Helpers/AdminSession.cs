using project.Model;

namespace project.Helpers
{
    public static class AdminSession
    {
        private static AkunAdminModel? _currentUserAdmin;

        public static AkunAdminModel? CurrentUser
        {
            get { return _currentUserAdmin; }
            set { _currentUserAdmin = value; }
        }

        public static bool IsLoggedIn
        {
            get { return _currentUserAdmin != null; }
        }

        public static int IdAkunAdmin
        {
            get { return _currentUserAdmin?.IdAkunAdmin ?? 0; }
        }

        public static string Username
        {
            get { return _currentUserAdmin?.Username ?? string.Empty; }
        }

        public static void Logout()
        {
            _currentUserAdmin = null;
        }
    }
}