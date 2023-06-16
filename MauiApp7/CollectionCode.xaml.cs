namespace MauiApp7;

public partial class CollectionCode : ContentPage
{
    Testing previous = null;
    Button prevbut = null;

    public class Testing
    {
        public string test { get; set; }
    }

    public CollectionCode()
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
                (prevbut.Parent as Grid).RowDefinitions = new RowDefinitionCollection(new RowDefinition[] { new RowDefinition(30), new RowDefinition(60), new RowDefinition(0), new RowDefinition(0), new RowDefinition(0) });
            }
            previous = (sender as Button).BindingContext as Testing;
            prevbut = sender as Button;
            ((sender as Button).Parent as Grid).RowDefinitions = new RowDefinitionCollection(new RowDefinition[] { new RowDefinition(30), new RowDefinition(60), new RowDefinition(50), new RowDefinition(50), new RowDefinition(50) });
            //((sender as Button).Parent.Parent as ViewCell).ForceUpdateSize();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

