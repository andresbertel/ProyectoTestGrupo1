namespace TestGitGrupo1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_ClickedDan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gatosiames());

        }
    }

}
