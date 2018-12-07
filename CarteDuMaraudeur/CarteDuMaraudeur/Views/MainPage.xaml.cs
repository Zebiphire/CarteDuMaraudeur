using CarteDuMaraudeur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace CarteDuMaraudeur.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();


            // France Section
            var pinSt = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(48.6123819, 7.709377000000018),
                Label = "T&S Strasbourg",
                Address = "4 Rue de Dublin, 67300 Schiltigheim, FRANCE",
                Id = "ST",
                Url = "http://technologyandstrategy.group/fr/group/france#"
            };

            var pinPa = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(48.8931142, 2.2843725999999833),
                Label = "T&S Paris",
                Address = "86 Rue Anatole France, 92300 Levallois Perret, FRANCE",
                Id = "PA",
                Url = "http://technologyandstrategy.group/fr/group/france#"
            };

            var pinLy = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(45.7360395, 4.836092300000018),
                Label = "T&S Lyon",
                Address = "200 Avenue Jean Jaures, 69007 Lyon, FRANCE",
                Id = "LY",
                Url = "http://technologyandstrategy.group/fr/group/france#"
            };

            var pinBo = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(44.8674209, -0.5753124000000298),
                Label = "T&S Bordeaux",
                Address = "Immeuble Lumine & Sens, 32 Allée De Boutaut, 33000 Bordeaux, FRANCE",
                Id = "BO",
                Url = "http://technologyandstrategy.group/fr/group/france#"
            };

            var pinTo = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(43.6305962, 1.3778568999999834),
                Label = "T&S Toulouse",
                Address = "Résidence Socrate, 17 Avenue Didier Daurat, 31700 Blagnac, FRANCE",
                Id = "TO",
                Url = "http://technologyandstrategy.group/fr/group/france#"
            };

            // England Section
            var pinBi = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(52.4785744, -1.9129672999999912),
                Label = "T&S Birmingham",
                Address = "3 Brindley PL. Birmingham, B1 2JB , ANGLETERRE",
                Id = "BI",
                Url = "http://technologyandstrategy.group/fr/group/england"
            };

            // Belgium Section
            var pinBr = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(50.8399478, 4.346675300000015),
                Label = "T&S Bruxelles",
                Address = "60A, Rue des tanneurs 1000 Bruxelles, Belgique",
                Id = "BI",
                Url = "http://technologyandstrategy.group/fr/group/belgium"
            };
            // Germany Section
            var pinStu = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(48.79367049999999, 8.998472499999934),
                Label = "T&S Stuttgart",
                Address = "6 HeindenheimerStrasse 71229 Leonberg, Germany",
                Id = "STU",
                Url = "http://technologyandstrategy.group/fr/group/germany"
            };

            var pinMu = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(48.1347921, 11.55475690000003),
                Label = "T&S Munich",
                Address = "Pettenkoferstrasse 29 80336 Munich, Germany",
                Id = "MU",
                Url = "http://technologyandstrategy.group/fr/group/germany"
            };

            var pinHa = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(52.37545679999999, 9.740422899999999),
                Label = "T&S Hannover",
                Address = "Bahnhofstraße 8 30159 Hannover, Germany",
                Id = "MU",
                Url = "http://technologyandstrategy.group/fr/group/germany"
            };

            //Switzerland Section
            var pinGe = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(46.19123800000001, 6.111203400000022),
                Label = "Antaes Geneve",
                Address = "Geneva Business Center, 12 Avenue des Morgines, 1213 Petit Lancy ",
                Id = "GE",
                Url = "http://technologyandstrategy.group/fr/group/swiss"
            };

            var pinLa = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(46.51728809999999, 6.63997930000005),
                Label = "Antaes Lausanne",
                Address = "18 Rue Belle-Fontaine, 1003 Lausanne",
                Id = "LA",
                Url = "http://technologyandstrategy.group/fr/group/swiss"
            };

            var pinZu = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(47.3679516, 8.534270600000013),
                Label = "Antaes Zurich",
                Address = "Stockerstraẞe 43 8002 Zurich",
                Id = "ZU",
                Url = "http://technologyandstrategy.group/fr/group/swiss"
            };

            // Singapour Section
            var pinSi = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(1.2798824, 103.8482219),
                Label = "Antaes Zurich",
                Address = "156 Cecil St. Far Eastern Bank Bldg #06-02 Singapore 069544 SINGAPORE",
                Id = "SI",
                Url = "http://technologyandstrategy.group/fr/group/singapour"
            };



            customMap.CustomPins = new List<CustomPin> { pinSt, pinPa, pinLy, pinBo, pinTo, pinBi, pinBr, pinStu, pinMu, pinHa, pinGe, pinLa, pinZu, pinSi };
            customMap.Pins.Add(pinSt);
            customMap.Pins.Add(pinPa);
            customMap.Pins.Add(pinLy);
            customMap.Pins.Add(pinBo);
            customMap.Pins.Add(pinTo);
            customMap.Pins.Add(pinBi);
            customMap.Pins.Add(pinBr);
            customMap.Pins.Add(pinStu);
            customMap.Pins.Add(pinMu);
            customMap.Pins.Add(pinHa);
            customMap.Pins.Add(pinGe);
            customMap.Pins.Add(pinLa);
            customMap.Pins.Add(pinZu);
            customMap.Pins.Add(pinSi);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(48.57340529999999, 7.752111300000024), Distance.FromMiles(1000.0)));
        }

        private void Street_Button_Clicked(object sender, EventArgs e)
        {
            customMap.MapType = MapType.Street;
        }

        private void Hybrid_Button_Clicked(object sender, EventArgs e)
        {
            customMap.MapType = MapType.Hybrid;
        }

        private void Satellite_Button_Clicked(object sender, EventArgs e)
        {
            customMap.MapType = MapType.Satellite;
        }
    }
}
