using CoronovirusTracker.Models;
using CoronovirusTracker.Models.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoronovirusTracker.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Covid _covidData;

        public Covid CovidData
        {
            get => _covidData;
            set
            {
                _covidData = value;
                OnPropertyChanged();
            }
        }
        private List<Regional> _topStates;

        public List<Regional> TopStates
        {
            get => _topStates;
            set
            { 
                _topStates = value;
                OnPropertyChanged();
            }
        }

        public async void FetchData()
        {
            CovidData = await CovidHelper.GetCovidDataAsync();
        }

        public void SortStates()
        {
            TopStates = CovidData?.Data.Regional.OrderByDescending(i => i.TotalConfirmed).Take(5).ToList();
        }

    }
}
