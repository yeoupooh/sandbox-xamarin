using System;
[assembly: Xamarin.Forms.Dependency(typeof(NativeBinding.iOS.Adder))]
namespace NativeBinding.iOS
{
	public class Adder:IAdder
	{
		public int CSAdd(int a, int b)
		{
			throw new NotImplementedException();
		}
	}
}
