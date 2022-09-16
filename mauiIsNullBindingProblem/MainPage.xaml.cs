namespace mauiIsNullBindingProblem;


public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        BindingContext = MainPageViewModel.Instance;
	}

    
}

