using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n;
        public MainWindow()
        {
            InitializeComponent();
            n = GenerarAleatorio();
        }
        public int GenerarAleatorio()
        {
            Random rnd = new Random();
            return rnd.Next(100 + 1);
        }
        
        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int nIntroducido = int.Parse(numeroIntroducidoTextBox.Text);

            if (nIntroducido == n)
            {
                resultadoTextBlock.Text = "¡Has acertado!";
            }
            else if (nIntroducido < n)
            {
                resultadoTextBlock.Text = "Te has quedado corto";
            }
            else
            {
                resultadoTextBlock.Text = "Te has pasado";
            }
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Text = "";
            numeroIntroducidoTextBox.Text = "";
            n = GenerarAleatorio();
        }
    }
}
