
using System;
using System.Windows;


namespace Adivinar_Numero
{
    public partial class MainWindow : Window
    {
        Random numero = new Random();
        int num;

        public MainWindow()
        { 
            InitializeComponent();
            num = numero.Next(0, 100);
        }

        private void Reiniciar_button(object sender, RoutedEventArgs e)
        {
            num = numero.Next(0, 100);
        }

        private void Comprobar_button(object sender, RoutedEventArgs e)
        {
            int numAComp = int.Parse(NombreTextBox.Text);
            if(numAComp > num)
            {
                Comprobacion.Text="Te has alejado";
            }
            else if(numAComp < num)
            {
                Comprobacion.Text = "Te has quedado corto";
            }
            else
            {
                Comprobacion.Text = "Has acertado";
            }
        }
    }
}
