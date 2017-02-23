namespace Xamarin.Forms
{
	interface IFontElement
	{
		//note to implementor: implement the properties publicly
		FontAttributes FontAttributes { get; }
		string FontFamily { get; }
		double FontSize { get; }

		//note to implementor: but implement the methods explicitly
		void OnFontFamilyChanged(string oldValue, string newValue);
		void OnFontSizeChanged(double oldValue, double newValue);
		double FontSizeDefaultValueCreator();
		void OnFontAttributesChanged(FontAttributes oldValue, FontAttributes newValue);
	}
}