using CommunityToolkit.Mvvm.ComponentModel;


namespace mauiIsNullBindingProblem
{
    public partial class MyDto : ObservableObject
    {

        [ObservableProperty]
        private bool _isValid;

        [ObservableProperty]
        private int _count;

        [ObservableProperty]
        private MySubDto? _subDto;
    }
}
