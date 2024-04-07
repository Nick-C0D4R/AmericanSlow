using AmericanSlow.Infrastrucutre;
using AmericanSlow.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AmericanSlow.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private UserControl _content = new LoginView();
        public UserControl Content
        {
            get => _content;
            set
            {
                _content = value;
                OnNotifyPropertyChanged(nameof(Content));
            }
        }

    }
}
