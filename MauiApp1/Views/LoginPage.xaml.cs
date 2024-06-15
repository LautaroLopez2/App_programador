namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void btnIngresar_Clicked(object sender, EventArgs e)
    {
        if (Usuario.Text == "ites" && Contraseña.Text == "1234")
        {
            Contraseña.Text = string.Empty;
            Usuario.Text = string.Empty;
            Navigation.PushAsync(new PrincipalPage());
        }
        else
        {
            Contraseña.Text = string.Empty;
            Usuario.Text = string.Empty;
            DisplayAlert("Atención", "las credenciales ingresadas no son válidas", "OK");
        }
    }
}