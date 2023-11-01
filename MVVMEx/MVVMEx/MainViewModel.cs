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
			FirstText= "Welcome to Xamarin Forms";
			MyColor = Color.Red;
			MyFontSize = 50;
		}
	}
}

