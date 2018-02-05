using System;

using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using BuildAzure.IoT.Adafruit.BME280;
using WeatherAppBusinessLayer;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
// link for instructions
// https://www.hackster.io/windows-iot/weather-station-v-2-0-8abe16
// link to github repository
// https://github.com/BuildAzure/BuildAzure.IoT.Adafruit.BME280
/*****************************************************
*    Title:  BuildAzure.IoT.Adafruit.BME280
*    Author: 
*    Site owner/sponsor:  github.com
*    Availability:  https://github.com/BuildAzure/BuildAzure.IoT.Adafruit.BME280
(Accessed 05 October 2017)
*    Modified:  Code refactored (Identifiers renamed) 
*****************************************************/
// Branch

namespace WeatherApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        DispatcherTimer _timer;
        BME280Sensor _bme280;
        const float seaLevelPressure = 1022.00f;
        public event PropertyChangedEventHandler PropertyChanged;

        public WeatherModel Model;
        
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = this;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            _bme280 = new BME280Sensor();
            await _bme280.Initialize();

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += _timer_Tick;

            _timer.Start();
        }
        

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void _timer_Tick(object sender, object e)
        {
            
            Model.Temperature = (int) await _bme280.ReadTemperature();
            Model.Humidity = (int) await _bme280.ReadHumidity();
            Model.Pressure = (int) await _bme280.ReadPressure();
            //var altitude = await _bme280.ReadAltitude(seaLevelPressure);
            Debug.WriteLine("Temp: {0} deg C", args: Model.Temperature);
            Debug.WriteLine("Humidity: {0} %", args: Model.Humidity);
            Debug.WriteLine("Pressure: {0} Pa", args: Model.Pressure);
            //Debug.WriteLine("Altitude: {0} m", altitude);
        }
    }
}
