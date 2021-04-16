using CoronovirusTracker.Commands;
using CoronovirusTracker.Models;
using CoronovirusTracker.Models.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronovirusTracker.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public HomeViewModel HomeViewModel { get; set; }
        public StateViewModel StateViewModel { get; set; }

        private BaseViewModel _selectedViewModel;

        public BaseViewModel SelectedViewModel
        {
            get => _selectedViewModel;
            set
            { 
                _selectedViewModel = value;
                OnPropertyChanged();
            }
        }

        public ICommand ChangeViewCommand { get; set;}

        public MainViewModel()
        {
            HomeViewModel = new HomeViewModel();
            StateViewModel = new StateViewModel();
            SelectedViewModel = HomeViewModel;
            ChangeViewCommand = new SwitchViewCommand(this);
            FetchData();
        }

    }
}
