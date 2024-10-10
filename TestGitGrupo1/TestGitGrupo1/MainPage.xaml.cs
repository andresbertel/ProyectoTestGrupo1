namespace TestGitGrupo1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

      

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Flamengo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Flamengo());


        }
         
           
    }

}
