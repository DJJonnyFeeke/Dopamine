﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace Dopamine.ControlsModule.Views
{
    public partial class CoverPlayerWindowControls : UserControl
    {
        #region Properties
        public double ButtonWidth
        {
            get { return Convert.ToDouble(GetValue(ButtonWidthProperty)); }

            set { SetValue(ButtonWidthProperty, value); }
        }

        public double ButtonHeight
        {
            get { return Convert.ToDouble(GetValue(ButtonHeightProperty)); }

            set { SetValue(ButtonHeightProperty, value); }
        }
        #endregion

        #region Dependency Properties
        public static readonly DependencyProperty ButtonWidthProperty = DependencyProperty.Register("ButtonWidth", typeof(double), typeof(CoverPlayerWindowControls), new PropertyMetadata(null));
        public static readonly DependencyProperty ButtonHeightProperty = DependencyProperty.Register("ButtonHeight", typeof(double), typeof(CoverPlayerWindowControls), new PropertyMetadata(null));
        #endregion

        #region Construction
        public CoverPlayerWindowControls()
        {
            InitializeComponent();
        }
        #endregion
    }
}
