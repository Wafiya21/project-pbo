using project.Model;

namespace project.Helpers
{
    public static class CustomerSession
    {
        private static AkunCustomerModel? _currentUserCustomer;

        public static AkunCustomerModel? CurrentUser
        {
            get { return _currentUserCustomer; }
            set { _currentUserCustomer = value; }
        }

        public static bool IsLoggedIn
        {
            get { return _currentUserCustomer != null; }
        }

        public static int IdAkunCustomer
        {
            get { return _currentUserCustomer?.IdAkunCustomer ?? 0; }
        }

        public static string Username
        {
            get { return _currentUserCustomer?.Username ?? string.Empty; }
        }

        public static bool IsMember
        {
            get { return _currentUserCustomer?.IsMember ?? false; }
        }

        public static void Logout()
        {
            _currentUserCustomer = null;
        }
    }
}