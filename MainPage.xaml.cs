namespace ScrollConflicts;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        Content = new CarouselView
        {
            ItemTemplate = new TabTemplateSelector
            {
                Tab1 = new DataTemplate(() => new Tab1()),
                Tab2 = new DataTemplate(() => new Tab2()),
                Tab3 = new DataTemplate(() => new Tab3())
            },
            ItemsSource = new List<int> { 1, 2, 3 }
        };
	}

    public class TabTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Tab1 { get; set; }
        public DataTemplate Tab2 { get; set; }
        public DataTemplate Tab3 { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            int index = ((int)item);

            switch (index)
            {
                case 1:
                    return Tab1;
                case 2:
                    return Tab2;
                default:
                    return Tab3;
            }
        }
    }
}


