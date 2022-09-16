using CommunityToolkit.Mvvm.ComponentModel;


namespace mauiIsNullBindingProblem
{
    public partial class MySubDto : ObservableObject
    {
        [ObservableProperty]
        private bool _isValid;

        [ObservableProperty]
        private int _count;
    }
}
