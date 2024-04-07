using AmericanSlow.Infrastrucutre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AmericanSlow.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
		private string _login;

		public string Login
		{
			get => _login;
			set
			{
				_login = value;
				OnNotifyPropertyChanged(nameof(Login));
			}
		}

		private string _password;

		public string Password
		{
			get => _password;
			set
			{
				_password = value;
				OnNotifyPropertyChanged(nameof(Password));
			}
		}


        public ICommand LoginCommand = new RelayCommand(x => SignIn());
        public ICommand PasswordCommand = new RelayCommand(x => ChangePassword());
		public ICommand SignUpCommand = new RelayCommand(x => SignUp());

		private static void SignIn()
		{

		}

		private static void ChangePassword()
		{

		}

		private static void SignUp()
		{

		}
	}
}
