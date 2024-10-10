namespace TestGitGrupo1
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

 

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Introduccion());
        }

        private void Button_soccer(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Junior_Club_SA());
        }
    }

}
