using System;
using System.Collections.ObjectModel;
using ArtPlantMall.Local.Models;
using ArtPlantMall.Local.Services;
using Xamarin.Forms;

namespace ArtPlantMall.Local.ViewModels
{
    public class ArtPlantMallViewModel : BindableObject
    {
        public ArtPlantMallViewModel()
        {
            LoadData();
        }

        private ObservableCollection<Plant> _plants;
        public ObservableCollection<Plant> Plants
        {
            get { return _plants; }
            set
            {
                _plants = value;
                OnPropertyChanged();
            }
        }

        private void LoadData()
        {
            Plants = new ObservableCollection<Plant>(FakePlantService.Instance.GetPlants());
        }
    }
}
