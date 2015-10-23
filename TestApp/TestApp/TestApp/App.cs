using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace TestApp
{
    public class App : Application
    {
        public App()
        {
            var layoutWBDDO = new StackLayout
            {
                Spacing = 0,
                Padding = new Thickness(15, 5, 0, 5),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    new Label
                    {
                        Text = "WBDBO (min)",
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.StartAndExpand
                    },
                    new ButtonGroup
                    {
                        IsNumber = true,
                        Rounded = true,
                        ViewBackgroundColor = Color.Blue,
                        BorderColor = Color.FromRgb(76, 217, 100),
                        OutlineColor = Color.Red,
                        BackgroundColor = Device.OnPlatform(Color.Yellow, Color.White, Color.White),
                        TextColor = Device.OnPlatform(Color.FromRgb(76, 217, 100), Color.Green, Color.Green),
                        SelectedTextColor = Device.OnPlatform(Color.White, Color.White, Color.White),
                        SelectedBackgroundColor = Device.OnPlatform(Color.FromRgb(76, 217, 100), Color.Black, Color.Black),
                        SelectedBorderColor = Device.OnPlatform(Color.White, Color.Silver, Color.Silver),
                        SelectedFrameBackgroundColor = Device.OnPlatform(Color.White, Color.Black, Color.Black),
                        SelectedIndex = 0,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        VerticalOptions = LayoutOptions.Center,
                        Spacing = 2,
                        ButtonHeightRequest = 31,
                        SelectedItemHasShadow = false,
                        Font = Font.SystemFontOfSize(NamedSize.Default, FontAttributes.Bold),
                        Items = new List<string> {
                           "30","45","60","90","120"
                        }
                    },
                }
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = layoutWBDDO
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
