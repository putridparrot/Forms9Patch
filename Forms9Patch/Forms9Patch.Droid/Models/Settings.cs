using Android.App;
using System;
//using Xamarin.Forms;
using Dalvik.SystemInterop;

[assembly: Xamarin.Forms.Dependency (typeof(Forms9Patch.Droid.Settings))]
namespace Forms9Patch.Droid
{
	/// <summary>
	/// Forms9Patch Settings.
	/// </summary>
	public class Settings : INativeSettings
	{
		static bool _valid = false;
		/// <summary>
		/// Gets a value indicating whether Forms9Patch is licensed.
		/// </summary>
		/// <value>true</value>
		/// <c>false</c>
		public bool IsLicensed {
			get { return _valid; }
		}
		internal static bool IsLicenseValid {
			get { return _valid; }
		}

		static string _licenseKey;
		/// <summary>
		/// Sets the Forms9Patch license key.
		/// </summary>
		/// <value>The license key.</value>
		public static string LicenseKey
		{
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					_licenseKey = value;
					var licenseChecker = new LicenseChecker();
					_valid = licenseChecker.CheckLicenseKey(Settings._licenseKey, ((Activity) Xamarin.Forms.Forms.Context).Title);
					if (!_valid) {
						Console.WriteLine (string.Format ("[Forms9Patch] The LicenseKey '{0}' is not for the app '{1}'.", Settings._licenseKey, ((Activity) Xamarin.Forms.Forms.Context).Title));
						Console.WriteLine ("[Forms9Patch] You are in trial mode and will be able to render 1 scaleable image and 5 formatted strings");
					}
					FormsGestures.Droid.Settings.Init ();
					PCL.Utils.AppDomainWrapper.Instance = new PCL.Utils.Droid.AppDomainWrapperInstance();
				}
				DetectDisplay ();

			}
		}

		static void DetectDisplay() {
			var displayMetrics = global::Android.App.Application.Context.Resources.DisplayMetrics;
			//Display.Density = (displayMetrics.Xdpi + displayMetrics.Ydpi)/2.0;
			Display.Scale = displayMetrics.Density;
			Display.Density = Display.Scale * 160;
			Display.Width = Math.Min(displayMetrics.WidthPixels,displayMetrics.HeightPixels);
			Display.Height = Math.Max(displayMetrics.WidthPixels,displayMetrics.HeightPixels);
		}
	}
}