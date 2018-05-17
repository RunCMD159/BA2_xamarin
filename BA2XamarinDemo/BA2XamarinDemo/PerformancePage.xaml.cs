using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BA2XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerformancePage : ContentPage
    {
        private String[] performanceData;
        private Stopwatch stopWatch;
        private static int DATA_LENGTH = 10000;

        public PerformancePage()
        {
            InitializeComponent();
            this.initPerformanceData();
        }

        private void endPerformanceTestOnLastItem(object sender, ItemVisibilityEventArgs e)
        {
            this.Time.Text = "Running Time: " + this.stopWatch.ElapsedMilliseconds + " ms";
        }

        public void StartPerformanceTest_Clicked(object sender, EventArgs e)
        {
            this.stopWatch = new Stopwatch();
            this.stopWatch.Start();
            this.listView.ItemsSource = this.performanceData;
        }

        public void ResetTest_Clicked(object sender, EventArgs e)
        {
            this.listView.ItemsSource = null;
            this.listView.ItemAppearing += null;
            this.Time.Text = "Running Time: 0 ms";
            this.initPerformanceData();

        }

        private void initPerformanceData()
        {
            performanceData = new String[DATA_LENGTH];
            Random random = new Random();
            for (int i = 0; i < DATA_LENGTH; i++)
            {
                String data = "Test String " + random.Next(0, DATA_LENGTH + 1);
                performanceData[i] = data;
            }
            this.listView.ItemAppearing += endPerformanceTestOnLastItem;
        }
    }


}