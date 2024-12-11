using System.Windows;
using System.Windows.Controls;

namespace FormularioInteractivo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento de clic para los botones
        private void btnAccion_Click(object sender, RoutedEventArgs e)
        {
            // Verificar la categoría seleccionada
            string categoriaSeleccionada = (cbCategoria.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Determinar qué acción fue seleccionada
            string accion = (sender as Button)?.Content.ToString();

            // Mostrar un MessageBox con la acción y la categoría seleccionada
            MessageBox.Show($"Has realizado {accion} en la {categoriaSeleccionada}", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
