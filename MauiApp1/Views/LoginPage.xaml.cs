namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void btnIngresar_Clicked(object sender, EventArgs e)
    {
        if (Usuario.Text == "ites" && Contrase�a.Text == "1234")
        {
            Contrase�a.Text = string.Empty;
            Usuario.Text = string.Empty;
            Navigation.PushAsync(new PrincipalPage());
        }
        else
        {
            Contrase�a.Text = string.Empty;
            Usuario.Text = string.Empty;
            DisplayAlert("Atenci�n", "las credenciales ingresadas no son v�lidas", "OK");
        }
    }
}