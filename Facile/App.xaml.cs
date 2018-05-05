﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Facile.Models;
using LinkOS.Plugin;
using LinkOS.Plugin.Abstractions;
using Newtonsoft.Json;
using PCLStorage;
using Xamarin.Forms;

namespace Facile
{
    public partial class App : Application
    {
		public IDiscoveredPrinter printer;
		public Ditte facile_db_impo;

        public App()
        {
			printer = null;
			facile_db_impo = null;
			InitializeComponent();
			MainPage = new NavigationPage(new FacilePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
