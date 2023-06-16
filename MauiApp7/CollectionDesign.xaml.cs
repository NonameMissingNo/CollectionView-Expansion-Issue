using System.ComponentModel;

namespace MauiApp7;

public partial class CollectionDesign : ContentPage
{
    Testing previous = null;
    Button prevbut = null;
    int count = 0;
    public class Testing : INotifyPropertyChanged
    {
        public string test { get; set; }
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
    }

    public CollectionDesign()
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
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

