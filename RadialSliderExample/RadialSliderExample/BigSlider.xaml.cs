﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace RadialSliderExample
{
	public partial class BigSlider : PhoneApplicationPage
	{
		public BigSlider()
		{
			InitializeComponent();
		}

		private void isEnabledToggle_Checked(object sender, RoutedEventArgs e)
		{
			isEnabledToggle.Content = "True";
			bigSlider.IsEnabled = true;
		}

		private void isEnabledToggle_Unchecked(object sender, RoutedEventArgs e)
		{
			isEnabledToggle.Content = "False";
			bigSlider.IsEnabled = false;
		}
	}
}