using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMEx
{
	public class MainViewModel : BaseViewModel
	{
		private string firsttext = "Hello";
		public static Color firstcolor= Color.White;
		public int fontsize = 20;
		public TextAlignment alignment = TextAlignment.Start;
		public TextAlignment MyAlignment
		{
			get { return alignment; }
			set
			{
				alignment= value;
				OnPropertyChanged("MyAlignment");
			}
		}
		public string FirstText
		{
			get { return firsttext; }
			set
			{
				firsttext = value;
				OnPropertyChanged("FirstText");
			}
		}
		public Color MyColor
		{
			get { return firstcolor; }
			set
			{
				firstcolor = value;
				OnPropertyChanged("MyColor");
			}
		}
		
		public int MyFontSize
		{
			get { return fontsize; }
			set
			{
				fontsize = value;
				OnPropertyChanged("MyFontSize");
			}
		}
		public ICommand ChangeTextCommand { get;}

		public MainViewModel()
		{
			ChangeTextCommand = new Command(async => ChangeText());
		}
		private async Task ChangeText()
		{
			//if (Device.RuntimePlatform == Device.iOS)
			//{
			//	FirstText = "Welcome to Xamarin Forms to iOS Simulator";
			//	MyColor = Color.Red;
			//	MyFontSize = 50;
			//}
			//else if (Device.RuntimePlatform == Device.Android)
			//{
			//	FirstText = "Welcome to Xamarin Forms to Android";

			//}
			//else
			//{
			//	FirstText = "Welcome to Xamarin Forms";

			//}

            if (Device.Idiom == TargetIdiom.Phone)
            {
                FirstText = "Welcome to Xamarin Forms to mac";
				MyColor = Color.Bisque;
				MyFontSize = 50;
				MyAlignment = TextAlignment.End;
			

            }
            else if(Device.Idiom==TargetIdiom.Tablet)
            {
                FirstText = "Welcome to Xamarin Forms to tablet";
				MyColor = Color.Red;
				MyFontSize = 50;
				MyAlignment = TextAlignment.Center;

            }
			else
			{
                FirstText = "Welcome to Xamarin Forms";

            }
        }
	}
}

