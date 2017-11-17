# XAML Standard Samples

XAML Standard is set of principles that drive XAML dialect alignment and not a product or product feature. For more information see the [official repo](https://github.com/Microsoft/xaml-standard).

This repository has Xamarin.Forms samples using XAML Standard Preview.

# XAML Standard Preview

To **experiment** with XAML Standard in Xamarin.Forms you should follow the following steps:

1. Download de [NuGet package](https://aka.ms/xf-xamlstandard-nuget).
2. Add **Xamarin.Forms.Alias** to all Xamarin.Forms solution project.
3. Initialize `Alias.Init()`.
4. In XAML, use `xmlns:alias="clr-namespace:Xamarin.Forms.Alias;assembly=Xamarin.Forms.Alias"`.
5. Ready!

## Copyright and license

Code released under the [MIT license](https://opensource.org/licenses/MIT).