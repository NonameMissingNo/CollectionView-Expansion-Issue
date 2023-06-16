using System.ComponentModel;

namespace MauiApp7;

public partial class ListDesign : ContentPage
{
    Testing previous = null;
    Button prevbut = null;

    public ListDesign()
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

    public class Testing : INotifyPropertyChanged
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
                previous.Selected = false;
            }
            ((sender as Button).BindingContext as Testing).Selected = true;
            previous = ((sender as Button).BindingContext as Testing);
            ((sender as Button).Parent.Parent as ViewCell).ForceUpdateSize();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

