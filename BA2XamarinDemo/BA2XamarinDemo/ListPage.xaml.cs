using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BA2XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {

        public ListPage(String[] performanceData)
        {
            InitializeComponent();
            this.listView.ItemsSource = performanceData;
        }

        protected override void OnAppearing()
        {
            System.Diagnostics.Debug.WriteLine("LIST APPEARED");

        }
    }
}