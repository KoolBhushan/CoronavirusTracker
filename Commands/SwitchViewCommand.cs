using CoronovirusTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoronovirusTracker.Commands
{
    public class SwitchViewCommand : ICommand
    {
        private readonly MainViewModel _mainViewModel;

        public SwitchViewCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string viewName = parameter as string;

            switch (viewName)
            {
                case "Home":
                    _mainViewModel.SelectedViewModel = _mainViewModel.HomeViewModel;
                    break;
                case "States":
                    _mainViewModel.SelectedViewModel = _mainViewModel.StateViewModel;
                    _mainViewModel.SortStates();
                    break;
                default:
                    break;
            }
        }
    }
}
