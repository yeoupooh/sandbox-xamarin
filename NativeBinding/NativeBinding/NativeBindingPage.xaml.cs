using System;
using Xamarin.Forms;

namespace NativeBinding
{
	public partial class NativeBindingPage : ContentPage
	{
		public NativeBindingPage()
		{
			InitializeComponent();
		}

		void CalculateClicked(object sender, System.EventArgs e)
		{
			int a = Int32.Parse(entryA.Text);
			int b = Int32.Parse(entryB.Text);
			DependencyService.Get<IAdder>().CSAdd(a, b);
		}
	}
}
