using System;
using System.Collections.Generic;


namespace ScrollConflicts
{
    public partial class Header : ContentView
    {
        public Header()
        {
            InitializeComponent();
            var itemsSource = new List<Color>();

            for (var i = 0; i < 10; ++i)
            {
                itemsSource.Add(GetRandomColor());
            }

            _HorizontalCollection.ItemsSource = itemsSource;
        }

        public Color GetRandomColor()
        {
            Random randonGen = new Random();
            Color randomColor =
                Color.FromRgba(
                randonGen.Next(255),
                randonGen.Next(255),
                randonGen.Next(255),
                100);
            return randomColor;
        }
    }
}
