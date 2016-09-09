using Xamarin.Forms;

namespace Forms9Patch
{
	/// <summary>
	/// Forms9Patch ContentView.
	/// </summary>
	public class ContentView : Xamarin.Forms.ContentView, IBackgroundImage
	{

		#region Debug support
		static int _count = 0;
		int _id;

		/// <summary>
		/// Initializes a new instance of the <see cref="Forms9Patch.ContentView"/> class.
		/// </summary>
		public ContentView() {
			_id = _count++;
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that describes the current <see cref="Forms9Patch.Frame"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that describes the current <see cref="Forms9Patch.Frame"/>.</returns>
		public string Description () { return string.Format ("[{0}.{1}]",GetType(),_id); }
		#endregion

		#region Properties

		/// <summary>
		/// Backing store for the ContentView.BackgroundImage bindable property.
		/// </summary>
		public static BindableProperty BackgroundImageProperty = BindableProperty.Create ("BackgroundImage", typeof(Image), typeof(ContentView), null);
		/// <summary>
		/// Gets or sets the ContentView.background <see cref="Forms9Patch.Image"/>.
		/// </summary>
		/// <value>The background image.</value>
		public Image BackgroundImage {
			get { return (Image)GetValue (BackgroundImageProperty); }
			set { SetValue (BackgroundImageProperty, value); }
		}

		#endregion
	
		/// <param name="propertyName">The name of the property that changed.</param>
		/// <summary>
		/// Call this method from a child class to notify that a change happened on a property.
		/// </summary>
		protected override void OnPropertyChanged (string propertyName = null)
		{
			base.OnPropertyChanged (propertyName);
			if (propertyName == PaddingProperty.PropertyName)
				InvalidateLayout ();
			//else if (propertyName == "Binding")
			//	InvalidateMeasure ();
		}


	}
}