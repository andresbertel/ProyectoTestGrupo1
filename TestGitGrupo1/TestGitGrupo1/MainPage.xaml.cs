﻿namespace TestGitGrupo1
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
        private void Button_ClickedDan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gatosiames());
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Aguilas());
        }

        private void Button_Millonarios(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Millonarios());
        }
    }

}
