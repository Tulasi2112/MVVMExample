using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMEx
{
	public class MainViewModel : BaseViewModel
	{
		private string _welComeText = "hello";
		public string WelcomeText
		{
			get { return _welComeText; }
			set
			{
				_welComeText = value;
				OnPropertyChanged(WelcomeText);
			}
		}
		public ICommand ChangeTextCommand { get; private set; }

		public MainViewModel()
		{
			ChangeTextCommand = new Command(async => ChangeText());
		}
		private async Task ChangeText()
		{
			WelcomeText= "Welcome to Xamarin Forms";
		}
	}
}

