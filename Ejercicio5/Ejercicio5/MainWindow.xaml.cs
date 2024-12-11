using System;
using System.Windows;

namespace ToolTipFormulario
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtEdad.TextChanged += TxtEdad_TextChanged; // Evento para verificar el cambio
        }

        // Evento que se dispara cuando cambia el contenido del TextBox
        private void TxtEdad_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Intentar convertir el texto a un número
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                // Si es un número, mostramos el mensaje de éxito
                MessageBox.Show("Edad válida.");
            }
            else if (txtEdad.Text != "")
            {
                // Si no es un número, mostramos el mensaje de error
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }
    }
}
