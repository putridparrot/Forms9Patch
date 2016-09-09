﻿using System;
using Xamarin.Forms;

namespace Forms9Patch
{
	/// <summary>
	/// Forms9Patch Image element.
	/// </summary>
	public class Image : Xamarin.Forms.Image
	{
		#region Bindable Properties

		/// <summary>
		/// UNSUPPORTED INHERITED PROPERTY. See <see cref="Forms9Patch.Fill"/>.
		/// </summary>
		public new static readonly BindableProperty AspectProperty = BindableProperty.Create("Aspect",typeof(Aspect),typeof(Image),Aspect.Fill,BindingMode.OneWay,null, null, null, null, null);
		/// <summary>
		/// UNSUPPORTED INHERITED PROPERTY. See <see cref="Forms9Patch.Fill"/>.
		/// </summary>
		/// <value>The scaling method</value>
		public new Aspect Aspect {
			get { throw new NotImplementedException ("[Forms9Patch.Image]Aspect property is not supported"); }
			set { throw new NotImplementedException ("[Forms9Patch.Image]Aspect property is not supported"); }
		}


		/// <summary>
		/// Backing store for the Fill bindable property.
		/// </summary>
		public static readonly BindableProperty FillProperty = BindableProperty.Create("Fill",typeof(Fill),typeof(Image),Fill.AspectFit);
		/// <summary>
		/// Fill behavior for nonscalable (not NinePatch or CapInsets not set) image. 
		/// </summary>
		/// <value>The fill method (AspectFill, AspectFit, Fill, Tile)</value>
		public Fill Fill {
			get { return (Fill)GetValue (FillProperty); }
			set { SetValue (FillProperty, value); }
		}

		/// <summary>
		/// Backing store for the CapsInset bindable property.
		/// </summary>
		/// <remarks>
		/// End caps specify the portion of an image that should not be resized when an image is stretched. This technique is used to implement buttons and other resizable image-based interface elements. 
		/// When a button with end caps is resized, the resizing occurs only in the middle of the button, in the region between the end caps. The end caps themselves keep their original size and appearance.
		/// </remarks>
		/// <value>The end-cap insets (double or int)</value>
		public static readonly BindableProperty CapInsetsProperty = BindableProperty.Create( "CapInsets", typeof(Thickness), typeof(Image), new Thickness(-1)); 
		/// <summary>
		/// Gets or sets the end-cap insets.  This is a bindable property.
		/// </summary>
		/// <value>The end-cap insets.</value>
		public Thickness CapInsets {
			get { 
				return (Thickness)GetValue (CapInsetsProperty); 
			}
			set { 
				SetValue (CapInsetsProperty, value); 
			}
		}

		/// <summary>
		/// Backing store for the ContentPadding bindable property.
		/// </summary>
		public static readonly BindableProperty ContentPaddingProperty = BindableProperty.Create( "ContentPadding", typeof(Thickness), typeof(Image), new Thickness(-1)); 
		/// <summary>
		/// Gets content padding if Source is NinePatch image.
		/// </summary>
		/// <value>The content padding.</value>
		public Thickness ContentPadding {
			get { return (Thickness)GetValue (ContentPaddingProperty); }
			// set { SetValue (ContentPaddingProperty, value); }
		}

		/// <summary>
		/// The tint property.
		/// </summary>
		public static readonly BindableProperty TintColorProperty = BindableProperty.Create("TintColor", typeof(Color), typeof(Image), Color.Default);
		/// <summary>
		/// Gets or sets the image's tint.
		/// </summary>
		/// <value>The tint.  Default is not to tint the image</value>
		public Color TintColor {
			get { return (Color)GetValue (TintColorProperty); }
			set { SetValue (TintColorProperty, value); }
		}

		internal static readonly BindableProperty BaseImageSizeProperty = BindableProperty.Create("BaseImageSize", typeof(Size), typeof(Image), default(Size));
		internal Size BaseImageSize
		{
			get { return (Size)GetValue(BaseImageSizeProperty); }
			set { SetValue(BaseImageSizeProperty, value); }
		}

		#endregion


		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Image"/> class.
		/// </summary>
		public Image () {
			//base.Fill = Xamarin.Forms.Aspect.Fill;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Image"/> class.
		/// </summary>
		/// <param name="image">Image.</param>
		public Image(Xamarin.Forms.Image image) {
			Fill = image.Aspect.ToF9pFill ();
			IsOpaque = image.IsOpaque;
			HorizontalOptions = image.HorizontalOptions;
			VerticalOptions = image.VerticalOptions;
			AnchorX = image.AnchorX;
			AnchorY = image.AnchorY;
			BackgroundColor = image.BackgroundColor;
			HeightRequest = image.HeightRequest;
			InputTransparent = image.InputTransparent;
			IsEnabled = image.IsEnabled;
			IsVisible = image.IsVisible;
			MinimumHeightRequest = image.MinimumHeightRequest;
			MinimumWidthRequest = image.MinimumWidthRequest;
			Opacity = image.Opacity;
			Resources = image.Resources;
			Rotation = image.Rotation;
			RotationX = image.RotationX;
			RotationY = image.RotationY;
			Scale = image.Scale;
			Style = image.Style;
			TranslationX = image.TranslationX;
			TranslationY = image.TranslationY;
			WidthRequest = image.WidthRequest;
			Source = image.Source;
		}
		#endregion


		#region Change management

		/// <summary>
		/// Addresses a size request
		/// </summary>
		/// <returns>The size request.</returns>
		/// <param name="widthConstraint">Width constraint.</param>
		/// <param name="heightConstraint">Height constraint.</param>
		[Obsolete("Use OnMeasure")]
		protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
		{
			SizeRequest sizeRequest = base.OnSizeRequest(double.PositiveInfinity, double.PositiveInfinity);
			double requestAspectRatio = sizeRequest.Request.Width / sizeRequest.Request.Height;
			double constraintAspectRatio = widthConstraint / heightConstraint;
			double width = sizeRequest.Request.Width;
			double height = sizeRequest.Request.Height;
			if (Math.Abs(width) < float.Epsilon*5 || Math.Abs(height) < float.Epsilon*5)
				//return new SizeRequest(new Size(40.0, 40.0));
				return new SizeRequest(BaseImageSize);
			if (constraintAspectRatio > requestAspectRatio)
			{
				switch (Fill)
				{
					case Fill.AspectFit:
					case Fill.AspectFill:
						height = Math.Min(height, heightConstraint);
						width = width * (height / height);
						break;
					case Fill.Fill:
					case Fill.Tile:
						width = Math.Min(width, widthConstraint);
						height = height * (width / width);
						break;
				}
			}
			else if (constraintAspectRatio < requestAspectRatio)
			{
				switch (Fill)
				{
					case Fill.AspectFit:
					case Fill.AspectFill:
						width = Math.Min(width, widthConstraint);
						height = height * (width / width);
						break;
					case Fill.Fill:
					case Fill.Tile:
						height = Math.Min(height, heightConstraint);
						width = width * (height / height);
						break;
				}
			}
			else {
				width = Math.Min(width, widthConstraint);
				height = height * (width / width);
			}
			return new SizeRequest(new Size(width, height));
		}

		#endregion

	}
}
