namespace BusinessMan
{
    enum PageState { Loading, Error, Success }
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool _isBusy;

        [ObservableProperty]
        private bool _isEnabled;

        [ObservableProperty]
        private string _pageState;

        public bool IsNotBusy => !IsBusy;

        public BaseViewModel() { }
    }
}
