using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace mauiIsNullBindingProblem
{
    public partial class MainPageViewModel : ObservableObject
    {
        public static MainPageViewModel mainPageViewModel = new MainPageViewModel();
        public static MainPageViewModel Instance { get { return mainPageViewModel; } }

        public MainPageViewModel()
        {
            ToggleNullCommand = new RelayCommand(ToggleNull);
            _dto1.IsValid = true;
            _dto1.Count = 3;

        }

        public IRelayCommand ToggleNullCommand { get; private set; }

        private void ToggleNull()
        {
            _dto1.Count++;
            if (Dto2 == null)
            {
                Dto2 = new MyDto();
                Dto2.IsValid = true;
                Dto2.Count = _dto1.Count + 1;
                Dto2.SubDto = new MySubDto();
            } else
            {
                Dto2 = null;
            }
        }


        [ObservableProperty]
        private MyDto _dto1 = new MyDto();

        [ObservableProperty]
        private MyDto? _dto2;
    }
}
