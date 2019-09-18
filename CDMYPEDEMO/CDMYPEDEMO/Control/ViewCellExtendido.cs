using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CDMYPEDEMO.Control
{
    public class ViewCellExtendido : ViewCell
    {
        public static readonly BindableProperty SeleccionBackGroundColorProperty = BindableProperty.Create(
            "SeleccionBackGroundColorProperty", typeof(Color), typeof(ViewCellExtendido), Color.Default);

        public Color SeleccionBackGroundColor
        {
            get { return (Color)GetValue(SeleccionBackGroundColorProperty); }
            set { SetValue(SeleccionBackGroundColorProperty, value); }
        }
    }
}
