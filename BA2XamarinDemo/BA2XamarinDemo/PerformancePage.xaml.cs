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
        private bool scrollToBottom = true;
        private Stopwatch stopWatch;

        public PerformancePage()
        {
            InitializeComponent();
            int dataLength = 10000;
            performanceData = new String[dataLength];
            Random random = new Random();
            for (int i = 0; i < dataLength; i++)
            {
                String data = "Test String " + random.Next(0, dataLength + 1);
                performanceData[i] = data;
            }
            this.listView.ItemAppearing += endPerformanceTestOnLastItem;

        }

        private void endPerformanceTestOnLastItem(object sender, ItemVisibilityEventArgs e)
        {
            if (e.Item.ToString().Equals(this.performanceData.Last()))
            {

                this.stopWatch.Stop();
                this.Time.Text += this.stopWatch.ElapsedMilliseconds + " ms";
            }
            else if (scrollToBottom)
            {
                scrollToBottom = false;
                System.Diagnostics.Debug.WriteLine("SCROLL TO BOTTOM");
                int indexToScrollTo = Array.IndexOf(performanceData, performanceData.Last());
                listView.ScrollTo(performanceData[indexToScrollTo], ScrollToPosition.MakeVisible, true);
            }
        }

        public void StartPerformanceTest_Clicked(object sender, EventArgs e)
        {
            this.stopWatch = new Stopwatch();
            this.stopWatch.Start();
            this.listView.ItemsSource = this.performanceData;
        }

    }


}