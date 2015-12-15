using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CIA___CarInfoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            addTheBlurb();
        }

        private void addTheBlurb()
        {
            tblVW.Text = "Volkswagen is a German car manufacturer headquartered in Wolfsburg, Germany. Established in 1946. Volkswagen is the top-selling and namesake marque of the Volkswagen Group, the holding company created in 1975 for the growing company, and is now the second-largest automaker in the world. Volkswagen has three cars in top 10 list of best-selling cars of all time: Volkswagen Golf, Beetle and Passat. Volkswagen is the founding and namesake member of the Volkswagen Group, a large international corporation in charge of multiple car and truck brands, including Audi, Seat, Lamborgini,Bentley, Bugatti, Scania and Skoda. Volkswagen translates as 'People's Automobile' in German. The company's current international slogan is 'Das Auto'(The Car) \n\nVolkswagen engines are either petrol or diesel. Petrol engines come as the following: 1.0, 1.2, 1.4, 1.6, 1.8, 2.0 with the 1.0, 1.2, 1.4 and 1.6 being the most popular in use. \n\nVolkswagens Diesel engines are offered in 1.6, 1.9, 2.0, 2.5 litre.";
            tblAudi.Text = "Audi is a German automobile manufacturer that designs, engineers, produces, markets and distrubtes luxury cars. Audi oversees worldwide operations from its headquarters in Ingolstadt, Bavaria, Germany. Audi-branded vehicles are produced in nine production facilities worldwide. Audi is a subsidary of Volkswagen Group since 1966.\n\n Audi offers the following models \n - A1 \n - A2 \n - A3 \n - A4 \n - A5 \n - A6 \n - A7 \n\n These cars nowadays come in Diesel engines from 1.6 up to 2.0 litres. However some sports models can be offered in 3.0 litre petrol. \n These models are also offered in an s-Line model which is a sport model is fancier interior. \n Quattro is a higher spec for all Audi Models where it includes more BHP and torque, higher interior spec and extra added features.";
            tblFord.Text = "Ford is an American multinational company based in Dearborn, Michigan, a suburb of detroit. It was founded by Henry Ford. The company sells automobiles and commercial vehicles such as Lincoln and Motorcraft. Ford also owns Brazilian SUV manufacturer, Troller, and Australian compnay FPV. Ford owns a 2.1% stake in Mazda in Japan, an 8% stake in Aston Martin, and a 49% stake in Jiangling of China. \n\n Ford is the fifth most popular car brand in the world with popular cars such as the \n - Ford Mondeo \n - Ford Focus \n - Ford Fiesta \n - Ford Transit \n - Ford Transit Connect \n - Ford Escort \n - Ford KA \n";
            tblSeat.Text = "SEAT is a Spanish car company with its HQ in Martorell, Spain it was founded on May 9, 2015 by INI, a state-owned industrial holding company. It is currently a wholly owned subsidiary of the German Volkswagen Group, as a member of the now-defunct Audi Brand Group(2002-2007), together with Audi and Lamborgini, and marketed as a car maker with a youthful sporty profile. \n\n Seat models come in the following: \n - Seat Leon \n - Seat Toledo \n - Seat Ibiza \n - Seat Cordoba \n \n Seat engines are offered the same as Volkswagen engines as they are both made by the same company \n They offer petrol engines from 1.0 litre to 1.6 litre with horsepower of 68 up as far as 150 depending on engine capacity \n Seat diesel engines are offered in 1.4 litre, 1.6 litre, 1.9 litre and 2.0 litre engines with horsepower reaching from 105 up as far as 290 depending on engine capacity";
        }


        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image mySmallMap = (Image)sender;
            imgBigMap.Source = mySmallMap.Source;
            imgBigMap.Width = Window.Current.Bounds.Width;
            imgBigMap.Height = Window.Current.Bounds.Height;
            imgBigMap.Visibility = Visibility.Visible;
        }

        private void imgBigMap_Tapped(object sender, TappedRoutedEventArgs e)
        {
            imgBigMap.Source = null;
            imgBigMap.Visibility = Visibility.Collapsed;
        }



    }
}
