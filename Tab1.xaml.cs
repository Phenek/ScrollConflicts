using System;
using System.Collections.Generic;



namespace ScrollConflicts
{
    public partial class Tab1 : ContentView
    {
        public Tab1()
        {
            InitializeComponent();

            var itemsSource = new List<Color>();

            for(var i =0; i < 10; ++i)
            {
                itemsSource.Add(GetRandomColor());
            }

            _verticalCollectionView.ItemsSource = itemsSource;
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
