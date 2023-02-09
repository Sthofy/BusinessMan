namespace BusinessMan
{
    enum PageState { Loading, Error, Success }
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string _title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool _isBusy;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotVisible))]
        bool _isVisible;


        [ObservableProperty]
        string _pageState;

        public bool IsNotBusy => !_isBusy;
        public bool IsNotVisible => !_isVisible;

        public BaseViewModel() { }
    }
}
