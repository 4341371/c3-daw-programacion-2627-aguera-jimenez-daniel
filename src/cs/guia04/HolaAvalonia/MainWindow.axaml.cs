using Avalonia.Controls;
using Avalonia.Interactivity;

namespace HolaAvalonia;

public partial class MainWindow : Window
{

    private void Saludar_Click(object? sender, RoutedEventArgs e)
    {
        string nombre = txtNombre.Text ?? "";
        txtResultado.Text = $"¡Hola, {nombre}!";
    }

    public MainWindow()
    {
        InitializeComponent();
    }
}