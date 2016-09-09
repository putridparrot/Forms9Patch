﻿using System;

using Xamarin.Forms;

namespace TestProject
{
	public class ImageBenchmarkPage : ContentPage
	{
		public ImageBenchmarkPage ()
		{
			var label1 = new Xamarin.Forms.Label {
				Text = "Gesture Label",
				BackgroundColor = Color.Blue,
				HeightRequest = 50,
			};

			#region Images
			var si50 = new Image {
				//var image = new Xamarin.Forms.Image() {
				WidthRequest = 100,
				HeightRequest = 100,
				Source = ImageSource.FromResource("TestProject.Resources.50x50.png"),
			};


			var si100 = new Image {
				//var image = new Xamarin.Forms.Image() {
				WidthRequest = 100,
				HeightRequest = 100,
				Source = ImageSource.FromResource("TestProject.Resources.100x100.png"),
			};

			var si200 = new Image {
				//var image = new Xamarin.Forms.Image() {
				WidthRequest = 100,
				HeightRequest = 100,
				Source = ImageSource.FromResource("TestProject.Resources.200x200.png"),
			};

			var i50 = new Image {
				//WidthRequest = 50,
				//HeightRequest = 100,
				//Aspect = Aspect.,
				Source = ImageSource.FromResource("TestProject.Resources.50x50.png"),
			};
			var i100 = new Image {
				//WidthRequest = 50,
				//HeightRequest = 100,
				//Aspect = Aspect.,
				Source = ImageSource.FromResource("TestProject.Resources.100x100.png"),
			};
			var i200 = new Image {
				//WidthRequest = 50,
				//HeightRequest = 100,
				//Aspect = Aspect.,
				Source = ImageSource.FromResource("TestProject.Resources.200x200.png"),
			};


			var siPU = new Image {
				HeightRequest = 150,
				Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.PopupDM.png"),
			};

			var iPU = new Image {
				Source = ImageSource.FromResource("TestProject.Resources.PopupDM.png"),
			};

			var b1 = new Button {
				Text = "pizza cheese, smile, lkj, asdlfkjdslk",
				//Image = "five.png",
				BackgroundColor = Color.Red,
			};
			b1.Image = "five.png";
			#endregion


			#region ImageButtons
			var b2 = new Image {
						Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.button"),
			};

			var b3 = new Image {
						Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.button"),
			};

			var b4 = new Image {
						Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.button"),
			};
			#endregion


			#region RelativeLayout
			var heading = new Xamarin.Forms.Label {
				Text = "RelativeLayout Example",
				TextColor = Color.Red,
			};

			var relativelyPositioned = new Xamarin.Forms.Label {
				Text = "Positioned relative to my parent."
			};

			var relativeLayout = new Image {
					Source = Forms9Patch.ImageSource.FromMultiResource("TestProject.Resources.blackrocks"),
				Aspect = Aspect.AspectFit,
				HeightRequest = 100,
			};
			#endregion

			var sourceMode = "resource"; // "file", "uri", or "resource"
			Xamarin.Forms.ImageSource source;
			switch (sourceMode) {
			case "resource":
				source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redGridBox");
				break;
			case "uri":
				source = ImageSource.FromUri(new Uri ("https://raw.githubusercontent.com/baskren/TestProject/master/TestProject/Resources/redGridBox.png"));
				break;
			default:
				source = ImageSource.FromFile("redGridBox.png");
				break;
			}

			var infoIcon =  FileImageSource.FromFile("Info");
			var arrowIcon = FileImageSource.FromFile("ArrowR");


			#region Material Buttons
			var grid = new Xamarin.Forms.Grid {
				RowDefinitions = {
					new RowDefinition { Height = GridLength.Auto },
				},
				ColumnDefinitions = {
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
				},

			};

			var mb1 = new Button {
				Text = "",
				Image = (FileImageSource)arrowIcon,
			};

			var mb2 = new Button {
				Text = "sticky",
				Image = (FileImageSource)infoIcon,
			};
			var mb3 = new Button {
				Text = "disabled",
				IsEnabled = false,
				Image = (FileImageSource)arrowIcon,
			};
			var mb4 = new Button {
				Text = "selected disabled",
				IsEnabled = false,
				Image = (FileImageSource)infoIcon,
			};


			grid.Children.Add (new Xamarin.Forms.StackLayout {
				BackgroundColor = Color.FromHex("#33FF33"),
				Padding = new Thickness(10),
				Children = {

					new Xamarin.Forms.Label {
						Text = "Default, Light",
						TextColor = Color.Black,
					},
					mb1,mb2, mb3, mb4,

					new Xamarin.Forms.Label {
						Text = "Outline, Light",
						TextColor = Color.Black,
					},
					new Button {
						Text = "",
						Image = (FileImageSource)arrowIcon,
					},
					new Button {
						Text = "sticky",
					},
					new Button {
						Text = "disabled",
						IsEnabled = false,
					},
					new Button {
						Text = "selected disabled",
						IsEnabled = false,
					},

					new Xamarin.Forms.Label {
						Text = "Background Color, Light Theme",
						TextColor = Color.Black,
					},
					new Button {
						Text = "default",
						BackgroundColor = Color.FromHex("#E0E0E0"),
						Image = (FileImageSource)arrowIcon,
					},
					new Button {
						Text = "sticky",
						BackgroundColor = Color.FromHex("#E0E0E0"),
						Image = (FileImageSource)infoIcon,
					},
					new Button {
						Text = "disabled",
						IsEnabled = false,
						BackgroundColor = Color.FromHex("#E0E0E0"),
						Image = (FileImageSource)arrowIcon,
					},
					new Button {
						Text = "selected disabled",
						IsEnabled = false,
						BackgroundColor = Color.FromHex("#E0E0E0"),
						Image = (FileImageSource)infoIcon,
					},	

					new Xamarin.Forms.Label {
						Text = "Shadow, Light Theme",
						TextColor = Color.Black,
					},
					new Button {
						Text = "default",
						Image = (FileImageSource)infoIcon,
					},
					new Button {
						Text = "sticky",
						Image = (FileImageSource)arrowIcon,
					},
					new Button {
						Text = "disabled",
						IsEnabled = false,
						Image = (FileImageSource)infoIcon,
					},
					new Button {
						Text = "selected disabled",
						IsEnabled = false,
						Image = (FileImageSource)arrowIcon,
					},

					new Xamarin.Forms.Label {
						Text = "Shadow Background Color, Light Theme",
						TextColor = Color.Black,
					},
					new Button {
						Text = "default",
						BackgroundColor = Color.FromHex("#E0E0E0"),
						Image = (FileImageSource)infoIcon,
					},
					new Button {
						Text = "sticky",
						BackgroundColor = Color.FromHex("#E0E0E0"),
						Image = (FileImageSource)arrowIcon,
					},
					new Button {
						Text = "disabled",
						IsEnabled = false,
						BackgroundColor = Color.FromHex("#E0E0E0"),
						Image = (FileImageSource)infoIcon,
					},
					new Button {
						Text = "selected disabled",
						IsEnabled = false,
						BackgroundColor = Color.FromHex("#E0E0E0"),
						Image = (FileImageSource)arrowIcon,
					},	

				},
			}, 0, 0);


			grid.Children.Add(new Xamarin.Forms.StackLayout {
				Padding = new Thickness(10),
				BackgroundColor = Color.FromHex("#003"),
				Children = {
					new Xamarin.Forms.Label {
						Text = "Default, Dark Theme",
						TextColor = Color.White,
					},
					new Forms9Patch.MaterialButton {
						Text = "default",
						DarkTheme = true,
					},
					new Forms9Patch.MaterialButton {
						Text = "sticky",
						StickyBehavior = true,
						DarkTheme = true,
					},
					new Forms9Patch.MaterialButton {
						Text = "disabled",
						StickyBehavior = true,
						IsEnabled = false,
						DarkTheme = true,
					},
					new Forms9Patch.MaterialButton {
						Text = "selected disabled",
						IsEnabled = false,
						IsSelected = true,
						DarkTheme = true,
					},

					new Xamarin.Forms.Label {
						Text = "Outline, Dark Theme",
						TextColor = Color.White,
					},
					new Forms9Patch.MaterialButton {
						Text = "default",
						DarkTheme = true,
						OutlineWidth = 0,
					},
					new Forms9Patch.MaterialButton {
						Text = "sticky",
						StickyBehavior = true,
						DarkTheme = true,
						OutlineWidth = 0,
					},
					new Forms9Patch.MaterialButton {
						Text = "disabled",
						StickyBehavior = true,
						IsEnabled = false,
						DarkTheme = true,
						OutlineWidth = 0,
					},
					new Forms9Patch.MaterialButton {
						Text = "selected disabled",
						IsEnabled = false,
						IsSelected = true,
						DarkTheme = true,
						OutlineWidth = 0,
					},

					new Xamarin.Forms.Label {
						Text = "Background Color, Dark Theme",
						TextColor = Color.White,
					},
					new Forms9Patch.MaterialButton {
						Text = "default",
						BackgroundColor = Color.FromHex("#1194F6"),
						DarkTheme = true,
						ImageSource = arrowIcon,
						Orientation = StackOrientation.Vertical,
					},
					new Forms9Patch.MaterialButton {
						Text = "sticky",
						StickyBehavior = true,
						BackgroundColor = Color.FromHex("#1194F6"),
						DarkTheme = true,
					},

					new Forms9Patch.MaterialButton {
						Text = "disabled",
						StickyBehavior = true,
						IsEnabled = false,
						BackgroundColor = Color.FromHex("#1194F6"),
						DarkTheme = true,
					},

					new Forms9Patch.MaterialButton {
						Text = "selected disabled",
						IsEnabled = false,
						IsSelected = true,
						BackgroundColor = Color.FromHex("#1194F6"),
						DarkTheme = true,
					},
					new Xamarin.Forms.Label {
						Text = "Shadow, Dark Theme",
						TextColor = Color.White,
					},
					new Forms9Patch.MaterialButton {
						Text = "default",
						DarkTheme = true,
						HasShadow = true,
					},
					new Forms9Patch.MaterialButton {
						Text = "sticky",
						StickyBehavior = true,
						DarkTheme = true,
						HasShadow = true,
					},
					new Forms9Patch.MaterialButton {
						Text = "disabled",
						StickyBehavior = true,
						IsEnabled = false,
						DarkTheme = true,
						HasShadow = true,
					},
					new Forms9Patch.MaterialButton {
						Text = "selected disabled",
						IsEnabled = false,
						IsSelected = true,
						DarkTheme = true,
						HasShadow = true,
					},
					new Xamarin.Forms.Label {
						Text = "Shadow Background Color, Dark Theme",
						TextColor = Color.White,
					},
					new Forms9Patch.MaterialButton {
						Text = "default",
						BackgroundColor = Color.FromHex("#1194F6"),
						DarkTheme = true,
						HasShadow = true,
					},
					new Forms9Patch.MaterialButton {
						Text = "sticky",
						StickyBehavior = true,
						BackgroundColor = Color.FromHex("#1194F6"),
						DarkTheme = true,
						HasShadow = true,
					},

					new Forms9Patch.MaterialButton {
						Text = "disabled",
						StickyBehavior = true,
						IsEnabled = false,
						BackgroundColor = Color.FromHex("#1194F6"),
						DarkTheme = true,
						HasShadow = true,
					},

					new Forms9Patch.MaterialButton {
						Text = "selected disabled",
						IsEnabled = false,
						IsSelected = true,
						BackgroundColor = Color.FromHex("#1194F6"),
						DarkTheme = true,
						HasShadow = true,
					},
				},
			},1,0);
			#endregion



			Padding = new Thickness (5, Xamarin.Forms.Device.OnPlatform (20, 0, 0), 5, 0);
			BackgroundColor = Color.White;
			Content = new ScrollView { 
				Content = new StackLayout {
					Children = {
						label1,
						si50, si100, si200, i50, i100,i200,



						#region Image
						new Xamarin.Forms.Label {
							Text = "Forms9Patch.Image",
						},
						new Image {
							Source = Xamarin.Forms.ImageSource.FromResource("TestProject.Resources.water.gif"),
							//TintColor = Color.White,
							BackgroundColor = Color.Black,
						},
						new Image {
							Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redGridBox"),
							Aspect = Aspect.AspectFill,
						},
						new Image {
							Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redGridBox"),
							Aspect = Aspect.AspectFit,
						},
						new Image {
							Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redGridBox"),
							Aspect = Aspect.Fill,
						},
						new Image {
							Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redGridBox"),
						},
						new Image {
							Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redGridBox"),
							Aspect = Aspect.AspectFill,
						},
						#endregion

						#region ContentView
						new Xamarin.Forms.Label {
							Text = "Forms9Patch.ContentView",
						},
						new Image {
								Source = source,
							Aspect = Aspect.AspectFill,
							BackgroundColor = Color.Gray,
						},
						new Image {
							Source = source,
							Aspect = Aspect.AspectFit,
							BackgroundColor = Color.Gray,
						},
						new Image {
								Source = source,
							Aspect = Aspect.Fill,
							BackgroundColor = Color.Gray,
						},
						new Image {
								Source = source,
							BackgroundColor = Color.Gray,
						},
						new Image {
								Source = source,
							BackgroundColor = Color.Gray,
						},
						new Xamarin.Forms.Label { 
							Text = "Forms9Patch.ImageSource.FromMultiSource >> Forms9Patch.ContentView", 
							FontSize = 10,
							HorizontalOptions = LayoutOptions.Center,
						},

						#endregion


						#region Frame
						new Xamarin.Forms.Label {
							Text = "Forms9Patch.Frame",
						},
						new Forms9Patch.Frame {
							Content = new Xamarin.Forms.Label {
								Text = "Frame OutlineRadius & Shadow",
								TextColor = Color.Black,
								FontSize = 12,
							},
							Padding = new Thickness(10),
							BackgroundColor = Color.FromHex("#FAFAFA"),
							//OutlineColor = Color.Blue,
							//OutlineWidth = 1,
							OutlineRadius = 2,
							HasShadow = true,
						},
						new Image {
								Source = source,
							Aspect = Aspect.AspectFill,
							BackgroundColor = Color.Gray,
						},
						new Image {
								Source = source,
							Aspect = Aspect.AspectFit,
						},
						new Image {
								Source = source,
							Aspect = Aspect.Fill,
						},
						new Image {
								Source = source,
						},

						#endregion

						#region CapsInset ContentView
						new Xamarin.Forms.Image { 
							Source = Forms9Patch.ImageSource.FromMultiResource("TestProject.Resources.redribbon"), 
							//HeightRequest = 80,
						},
						new Xamarin.Forms.Label { Text = "Forms9Patch.ImageSource.FromMultiSource >> Xamarin.Forms.Image", 
							FontSize = 12,
							HorizontalOptions = LayoutOptions.Center,

						},

						new Image {
							Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redribbon"),
						},

						new Image {
								Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redribbon"),
							//HeightRequest = 80,
						},

						new Image {
								Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redribbon"),
							HeightRequest = 80,
						},

						new Image {
								Source = Forms9Patch.ImageSource.FromMultiResource ("TestProject.Resources.redribbon"),
							//HeightRequest = 80,
						},
						new Xamarin.Forms.Label { Text = "Forms9atch.ImageSource.FromMultiSource >> Forms9Patch.ContentView", 
							FontSize = 12,
							HorizontalOptions = LayoutOptions.Center,
						},
						#endregion

						#region RelativeLayout
						relativeLayout,
						#endregion


						#region MaterialSegmentControl

						new Xamarin.Forms.StackLayout {
							Orientation = StackOrientation.Horizontal,
							Children = {

								#region Light
								new Xamarin.Forms.StackLayout {
									BackgroundColor = Color.Lime,
									HorizontalOptions = LayoutOptions.FillAndExpand,
									Padding = new Thickness(10),
									Children = {
										new Xamarin.Forms.Label {
											Text = "Default, Light",
											TextColor = Color.Black,
										},

										//sc1, sc2, sc3, sc4, sc5, sc6,

									},
								},
								#endregion


								#region Dark
								new Xamarin.Forms.StackLayout {
									BackgroundColor = Color.FromHex("#003"),
									HorizontalOptions = LayoutOptions.FillAndExpand,
									Padding = new Thickness(10),
									Children = {
										new Xamarin.Forms.Label {
											Text = "Default, Dark",
											TextColor = Color.White,
										},

										new Forms9Patch.MaterialSegmentedControl {
											//OutlineColor = Color.Transparent,
											DarkTheme = true,
											Segments = {

												new Forms9Patch.Segment {
													Text = "A",
												},
												new Forms9Patch.Segment {
													//Text = "B",
													IsSelected = true,
													ImageSource = arrowIcon,
												},
												new Forms9Patch.Segment {
													Text = "C",
												},

												new Forms9Patch.Segment {
													Text = "D",
													IsEnabled = false,
												},
											},
										},

										new Forms9Patch.MaterialSegmentedControl {
											DarkTheme = true,
											OutlineWidth = 0,
											Segments = {

												new Forms9Patch.Segment {
													//Text = "A",
													ImageSource = arrowIcon,
												},
												new Forms9Patch.Segment {
													Text = "B",
													IsSelected = true,
												},
												new Forms9Patch.Segment {
													Text = "C",
												},

												new Forms9Patch.Segment {
													Text = "D",
													IsEnabled = false,
												},
											},
										},

										new Forms9Patch.MaterialSegmentedControl {
											DarkTheme = true,
											BackgroundColor = Color.FromHex("#1194F6"),
											Segments = {
												new Forms9Patch.Segment {
													Text = "A",
												},
												new Forms9Patch.Segment {
													Text = "B",
													IsSelected = true,
												},
												new Forms9Patch.Segment {
													Text = "C",
												},
												new Forms9Patch.Segment {
													//Text = "D",
													IsEnabled = false,
													ImageSource = arrowIcon,
												},
											},
										},

										new Forms9Patch.MaterialSegmentedControl {
											DarkTheme = true,
											BackgroundColor = Color.FromHex("#1194F6"),
											OutlineWidth = 0,
											Segments = {
												new Forms9Patch.Segment {
													Text = "A",
													ImageSource = arrowIcon,
													Orientation = StackOrientation.Vertical,
												},
												new Forms9Patch.Segment {
													Text = "B",
													IsSelected = true,
													ImageSource = infoIcon,
													Orientation = StackOrientation.Vertical,
												},

												new Forms9Patch.Segment {
													Text = "C",
													ImageSource = arrowIcon,
												},
												new Forms9Patch.Segment {
													Text = "D",
													IsEnabled = false,
													ImageSource = infoIcon,
													Orientation = StackOrientation.Vertical,
												},

											},
										},

										new Forms9Patch.MaterialSegmentedControl {
											DarkTheme = true,
											BackgroundColor = Color.FromHex("#1194F6"),
											HasShadow = true,
											//OutlineRadius = 0,
											//OutlineWidth = 0,
											Orientation = StackOrientation.Vertical,
											StickyBehavior = Forms9Patch.SegmentControlStickyBehavior.Multiselect,
											Segments = {

												new Forms9Patch.Segment {
													Text = "A",
													ImageSource = arrowIcon,
												},

												new Forms9Patch.Segment {
													Text = "B",
													IsSelected = true,
												},
												new Forms9Patch.Segment {
													Text = "C",
												},
												new Forms9Patch.Segment {
													Text = "D",
													IsEnabled = false,
												},

											},
										},

										new Forms9Patch.MaterialSegmentedControl {
											DarkTheme = true,
											BackgroundColor = Color.FromHex("#1194F6"),
											HasShadow = true,
											//OutlineRadius = 0,
											OutlineWidth = 0,
											SeparatorWidth = 1,
											Orientation = StackOrientation.Vertical,
											StickyBehavior = Forms9Patch.SegmentControlStickyBehavior.Multiselect,
											Segments = {

												new Forms9Patch.Segment {
													Text = "A",
												},

												new Forms9Patch.Segment {
													Text = "B",
													IsSelected = true,
													ImageSource = arrowIcon,
												},
												new Forms9Patch.Segment {
													Text = "C",
												},
												new Forms9Patch.Segment {
													Text = "D",
													IsEnabled = false,
												},

											},
										},
									},
								},
								#endregion

							},
						},

						#endregion

						grid,

						new Label { Text = "Hello ContentPage" }
					},
				}
			};
		}
	}
}

