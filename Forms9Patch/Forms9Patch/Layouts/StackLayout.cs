﻿using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace Forms9Patch
{
	/// <summary>
	/// Forms9Patch StackLayout.
	/// </summary>
	public class StackLayout : Xamarin.Forms.StackLayout, IRoundedBox, IBackgroundImage
	{

		#region debug support
		static int _count = 0;
		int _id;

		/// <summary>
		/// Initializes a new instance of the <see cref="Forms9Patch.StackLayout"/> class.
		/// </summary>
		public StackLayout ()
		{
			_id = _count++;
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Forms9Patch.StackLayout"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="Forms9Patch.StackLayout"/>.</returns>
		public string Description () { return string.Format ("[{0}.{1}]",GetType(),_id); }
		#endregion

		#region Properties
		/// <summary>
		/// Backing store for the BackgroundImage bindable property.
		/// </summary>
		public static BindableProperty BackgroundImageProperty = BindableProperty.Create ("BackgroundImage", typeof(Image), typeof(StackLayout), null);
		/// <summary>
		/// Gets or sets the background image.
		/// </summary>
		/// <value>The background image.</value>
		public Image BackgroundImage {
			get { return (Image)GetValue (BackgroundImageProperty); }
			set { SetValue (BackgroundImageProperty, value); }
		}

		/// <summary>
		/// Backing store for the HasShadow bindable property.
		/// </summary>
		/// <remarks></remarks>
		public static readonly BindableProperty HasShadowProperty = RoundedBoxBase.HasShadowProperty;
		/// <summary>
		/// Gets or sets a flag indicating if the StackLayout has a shadow displayed. This is a bindable property.
		/// </summary>
		/// <value><c>true</c> if this instance has shadow; otherwise, <c>false</c>.</value>
		public bool HasShadow {
			get { return (bool)GetValue (HasShadowProperty); }
			set { SetValue (HasShadowProperty, value); }
		}

		/// <summary>
		/// Backing store for the ShadowInverted bindable property.
		/// </summary>
		/// <remarks></remarks>
		public static readonly BindableProperty ShadowInvertedProperty = RoundedBoxBase.ShadowInvertedProperty;
		/// <summary>
		/// Gets or sets a flag indicating if the StackLayout has a shadow inverted. This is a bindable property.
		/// </summary>
		/// <value><c>true</c> if this instance's shadow is inverted; otherwise, <c>false</c>.</value>
		public bool ShadowInverted {
			get { return (bool)GetValue (ShadowInvertedProperty); }
			set { SetValue (ShadowInvertedProperty, value); }
		}

		/// <summary>
		/// Backing store for the OutlineColor bindable property.
		/// </summary>
		/// <remarks></remarks>
		public static readonly BindableProperty OutlineColorProperty = RoundedBoxBase.OutlineColorProperty;
		/// <summary>
		/// Gets or sets the color of the border of the AbsoluteLayout. This is a bindable property.
		/// </summary>
		/// <value>The color of the outline.</value>
		public Color OutlineColor {
			get { return (Color)GetValue (OutlineColorProperty); }
			set { SetValue (OutlineColorProperty, value); }
		}

		/// <summary>
		/// Backing store for the OutlineRadius bindable property.
		/// </summary>
		public static readonly BindableProperty OutlineRadiusProperty = RoundedBoxBase.OutlineRadiusProperty;
		/// <summary>
		/// Gets or sets the outline radius.
		/// </summary>
		/// <value>The outline radius.</value>
		public float OutlineRadius {
			get { return (float) GetValue (OutlineRadiusProperty); }
			set { SetValue (OutlineRadiusProperty, value); }
		}

		/// <summary>
		/// Backing store for the OutlineWidth bindable property.
		/// </summary>
		public static readonly BindableProperty OutlineWidthProperty = RoundedBoxBase.OutlineWidthProperty;
		/// <summary>
		/// Gets or sets the width of the outline.
		/// </summary>
		/// <value>The width of the outline.</value>
		public float OutlineWidth {
			get { return (float) GetValue (OutlineWidthProperty); }
			set { SetValue (OutlineWidthProperty, value); }
		}

		/// <summary>
		/// Identifies the Padding bindable property.
		/// </summary>
		/// <remarks></remarks>
		public static new readonly BindableProperty PaddingProperty = RoundedBoxBase.PaddingProperty;
		/// <summary>
		/// Gets or sets the inner padding of the Layout.
		/// </summary>
		/// <value>The Thickness values for the layout. The default value is a Thickness with all values set to 0.</value>
		public new Thickness Padding {
			get { return (Thickness)GetValue (PaddingProperty); }
			set { SetValue (PaddingProperty, value); }
		}


		#endregion

		/// <param name="propertyName">The name of the property that changed.</param>
		/// <summary>
		/// Call this method from a child class to notify that a change happened on a property.
		/// </summary>
		protected override void OnPropertyChanged (string propertyName = null)
		{
			base.OnPropertyChanged (propertyName);
			if (propertyName == PaddingProperty.PropertyName ||
				propertyName == HasShadowProperty.PropertyName)
				InvalidateLayout ();
		}

		/// <summary>
		/// Ons the child measure invalidated.
		/// </summary>
		protected override void OnChildMeasureInvalidated()
		{
			System.Diagnostics.Debug.WriteLine("StackLayout.OnChildMeasureInvalidated()");
			base.OnChildMeasureInvalidated();
		}
		/// <summary>
		/// Ons the size request.
		/// </summary>
		/// <returns>The size request.</returns>
		/// <param name="widthConstraint">Width constraint.</param>
		/// <param name="heightConstraint">Height constraint.</param>
		protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
		{
			System.Diagnostics.Debug.WriteLine("StackLayout.OnSizeRequest("+widthConstraint+", "+heightConstraint+")");
			return base.OnSizeRequest(widthConstraint, heightConstraint);
		}
		/// <summary>
		/// Invalidates the layout.
		/// </summary>
		protected override void InvalidateLayout()
		{
			System.Diagnostics.Debug.WriteLine("StackLayout.InvalidateLayout()");
			base.InvalidateLayout();
		}
		/// <summary>
		/// Invalidates the measure.
		/// </summary>
		protected override void InvalidateMeasure()
		{
			System.Diagnostics.Debug.WriteLine("StackLayout.InvalidateMeasure()");
			base.InvalidateMeasure();
		}
		/// <summary>
		/// Layouts the children.
		/// </summary>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <param name="width">Width.</param>
		/// <param name="height">Height.</param>
		protected override void LayoutChildren(double x, double y, double width, double height)
		{
			System.Diagnostics.Debug.WriteLine("StackLayout.LayoutChildren("+x+","+y+","+width+","+height+")");
			base.LayoutChildren(x, y, width, height);
		}

		/*
		/// <summary>
		/// Ons the measure.
		/// </summary>
		/// <returns>The measure.</returns>
		/// <param name="widthConstraint">Width constraint.</param>
		/// <param name="heightConstraint">Height constraint.</param>
		protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
		{
			System.Diagnostics.Debug.WriteLine("StackLayout.OnMeasure(" + widthConstraint + ", " + heightConstraint + ")");
			return base.OnMeasure(widthConstraint, heightConstraint);
		}
		*/
		/// <summary>
		/// Ons the property changing.
		/// </summary>
		/// <param name="propertyName">Property name.</param>
		protected override void OnPropertyChanging(string propertyName = null)
		{
			System.Diagnostics.Debug.WriteLine("StackLayout.OnPropertyChanging(" + propertyName + ")");
			base.OnPropertyChanging(propertyName);
		}
	}
}
