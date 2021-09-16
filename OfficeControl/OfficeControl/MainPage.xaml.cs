using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OfficeControl
{
    public partial class MainPage : ContentPage
    {
        string turnOnUrl = $"https://maker.ifttt.com/trigger/turn_on_office_light/with/key/{Constants.APIKey}";
        string turnOffUrl = $"https://maker.ifttt.com/trigger/turn_off_office_light/with/key/{Constants.APIKey}";
        string changeColorUrl = $"https://maker.ifttt.com/trigger/change_office_color/with/key/{Constants.APIKey}";
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
