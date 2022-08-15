namespace ShareInvest
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();
        void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        int count = 0;
    }
}