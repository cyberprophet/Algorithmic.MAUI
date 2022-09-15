using CommunityToolkit.Mvvm.ComponentModel;

namespace ShareInvest.ViewModel
{
    public partial class BaseViewModel : ObservableObject /* INotifyPropertyChanged */
    {
        /*
        public bool IsBusy
        {
            set
            {
                if (isBusy == value)
                    return;

                isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
            get => isBusy;
        }
        public string Title
        {
            set
            {
                if (title == value)
                    return;

                title = value;
                OnPropertyChanged();
            }
            get => title;
        }
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        */
        public bool IsNotBusy => isBusy is false;

        [ObservableProperty,
         NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;
    }
}