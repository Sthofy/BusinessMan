namespace BusinessMan.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        string _username;

        [ObservableProperty]
        bool _isBtnVisible = false;

        private readonly SqlDatabase _database;

        public Task Init { get; }

        public MainViewModel(SqlDatabase database)
        {
            _database = database;
            Init = Initailize();
        }

        public async Task Initailize()
        {
            await GetUser();
        }

        async Task GetUser()
        {
            var result = await _database.GetUserAsync();

            if (result == null)
            {
                IsVisible = true;
            }
            else
            {
                IsVisible = false;
            }
        }

        [RelayCommand]
        async Task AddUserAsync()
        {
            var user = new User
            {
                Name = Username,
            };

            var result = await _database.SavetUserAsync(user);

            IsVisible = false;
        }

        [RelayCommand]
        async Task DeleteUserAsync()
        {
            var user = await _database.GetUserAsync();

            var result = await _database.RemoveUserAsync(user);

            IsVisible = !IsVisible;
        }

        [RelayCommand]
        void ChangeBtnToVisible()
        {
            IsBtnVisible = !IsBtnVisible;
        }
    }
}
