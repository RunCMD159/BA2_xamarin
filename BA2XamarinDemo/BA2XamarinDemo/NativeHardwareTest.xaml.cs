using Plugin.Media;
using Plugin.Media.Abstractions;
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
    public partial class NativeHardwareTest : ContentPage
    {
        private String filePath;

        //public NativeHardwareTest()
        //{
        //    CameraButton.Clicked += CameraButton_Clicked;
        //}

        private async void Kamera_Button_Clicked(object sender, EventArgs e)
        {

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Pictures",
                Name = DateTime.Now + "_demo.jpg"
            });

            if (file == null)
                return;
            this.filePath = file.Path;
            OnAppearing();
        }

        async protected override void OnAppearing()
        {
            //show picture
            image.Source = ImageSource.FromFile(filePath);
        }
    }
}