using System.ComponentModel;

namespace MauiApp7;

public partial class ListCode : ContentPage
{
    Testing previous = null;
    Button prevbut = null;

    public ListCode()
    {
        try
        {
            InitializeComponent();
            //levelcollection.ItemSelected += Levelcollection_ItemSelected;
            List<Testing> testings = new List<Testing>();
            testings.Add(new Testing());
            testings.Add(new Testing());
            testings.Add(new Testing());
            testings.Add(new Testing());
            levelcollection.ItemsSource = testings;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public class Testing
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool selected = false;
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Selected)));
            }
        }
        public string test { get; set; }
    }

    private void Levelcollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try
        {
            previous = (sender as CollectionView).SelectedItem as Testing;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (previous != null)
            {
                (prevbut.Parent as Grid).HeightRequest = 90;
                (prevbut.Parent as Grid).RowDefinitions = new RowDefinitionCollection(new RowDefinition[] { new RowDefinition(30), new RowDefinition(60), new RowDefinition(0), new RowDefinition(0), new RowDefinition(0) });
            }
            previous = (sender as Button).BindingContext as Testing;
            prevbut = sender as Button;
            ((sender as Button).Parent as Grid).HeightRequest = 240;
            ((sender as Button).Parent as Grid).RowDefinitions = new RowDefinitionCollection(new RowDefinition[] { new RowDefinition(30), new RowDefinition(60), new RowDefinition(50), new RowDefinition(50), new RowDefinition(50) });
            ((sender as Button).Parent.Parent as ViewCell).ForceUpdateSize();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

