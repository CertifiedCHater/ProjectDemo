namespace ProjectDemo.View

{
    public partial class MainPage : ContentPage
    {

        public MainPage(ViewModel.ArtsViewModel artsViewModel)
        {
            InitializeComponent();
            BindingContext = artsViewModel;

        }
    }

}
