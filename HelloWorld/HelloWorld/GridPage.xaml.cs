using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();
            var grid = new Grid()
            {
                RowSpacing = 20,
                ColumnSpacing = 40
            };
            var label1 = new Label() { Text = "Label 1" };
            grid.Children.Add(label1, 0, 0);
            Grid.SetRowSpan(label1, 2);
            Grid.SetColumnSpan(label1, 2);
            Grid.SetRow(label1, 0);
            Grid.SetColumn(label1, 0);

            grid.RowDefinitions.Add(new RowDefinition()
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            });
            grid.RowDefinitions.Add(new RowDefinition()
            {
                Height = new GridLength(2, GridUnitType.Star)
            });
            grid.RowDefinitions.Add(new RowDefinition()
            {
                Height = new GridLength(1, GridUnitType.Auto)
            });


        }
    }
}
