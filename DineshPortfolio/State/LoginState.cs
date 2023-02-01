using DineshPortfolio.ViewModel;

namespace DineshPortfolio.State
{
    public static class LoginState
    {
        public static LoginViewModel loginViewModel = new LoginViewModel();
        public static bool IsLoggedIn()
        {
            if (loginViewModel.Password != null)
            {
                return true;
            }
            return false;
        }

        public static bool Login(LoginViewModel model)
        {
            if (model.Username == "admin" && model.Password == "admin")
            {
                loginViewModel = model;

                return true;
            }
            return false;
        }

        public static void Logout()
        {
            loginViewModel=new LoginViewModel();
        }
    }
}
