﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Patoda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedMastePage : TabbedPage
    {
        public TabbedMastePage()
        {
            InitializeComponent();
        }
    }
}