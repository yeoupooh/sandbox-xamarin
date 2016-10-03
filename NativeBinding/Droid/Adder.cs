using System;
using System.Runtime.InteropServices;
using NativeBinding.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(NativeBinding.Droid.Adder))]
namespace NativeBinding.Droid
{
	public class Adder: IAdder
	{
		[DllImport("adder")]
		public static extern int Add(int a, int b);

		public int CSAdd(int a, int b)
		{
			System.Diagnostics.Debug.WriteLine("adder service: ");
			//return MainActivity.Add(a, b);
			return Add(a, b);
		}
	}
}
