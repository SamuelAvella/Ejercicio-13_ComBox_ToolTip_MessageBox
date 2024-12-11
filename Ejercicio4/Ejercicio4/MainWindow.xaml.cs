using System.Windows;
using System.Windows.Controls;

namespace ConfirmacionAvanzada
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento del botón de confirmación
        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            // Verificar que se haya seleccionado una fruta
            var seleccionFruta = cbFrutas.SelectedItem as ComboBoxItem;
            if (seleccionFruta != null)
            {
                string fruta = seleccionFruta.Content.ToString();

                // Mostrar el MessageBox con opciones Yes, No, Cancel
                MessageBoxResult resultado = MessageBox.Show($"¿Quieres confirmar tu selección de {fruta}?",
                                                             "Confirmación",
                                                             MessageBoxButton.YesNoCancel,
                                                             MessageBoxImage.Question);

                // Según la respuesta del usuario, mostrar el mensaje correspondiente
                switch (resultado)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show($"Has confirmado {fruta}.");
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show($"Has rechazado {fruta}.");
                        break;
                    case MessageBoxResult.Cancel:
                        MessageBox.Show("No se realizó ninguna acción.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fruta.");
            }
        }
    }
}
