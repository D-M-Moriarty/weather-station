using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
namespace WeatherAppModels
{
    public class WeatherModels : INotifyPropertyChanged
    {
        const float seaLevelPressure = 1022.00f;
        public event PropertyChangedEventHandler PropertyChanged;
        
        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private int _humidity;
        public int Humidity
        {
            get { return _humidity; }
            set
            {
                if (_humidity != value)
                {
                    _humidity = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private int _pressure;
        public int Pressure
        {
            get { return _pressure; }
            set
            {
                if (_pressure != value)
                {
                    _pressure = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
