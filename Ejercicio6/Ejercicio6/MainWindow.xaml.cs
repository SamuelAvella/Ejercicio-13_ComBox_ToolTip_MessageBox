using System.Windows;
using System.Windows.Media;

namespace SelecciónTema
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Evento que maneja el cambio de selección en el ComboBox
        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Obtenemos el ComboBoxItem seleccionado
            var seleccionado = cbTemas.SelectedItem as System.Windows.Controls.ComboBoxItem;
            if (seleccionado != null)
            {
                string temaSeleccionado = seleccionado.Content.ToString();

                // Cambiar el fondo y el color del texto según el tema seleccionado
                switch (temaSeleccionado)
                {
                    case "Claro":
                        this.Background = Brushes.White;
                        tbTexto.Foreground = Brushes.Black;
                        tbTexto.FontSize = 16; // Tamaño de texto para el tema Claro
                        break;
                    case "Oscuro":
                        this.Background = Brushes.Black;
                        tbTexto.Foreground = Brushes.White;
                        tbTexto.FontSize = 20; // Tamaño de texto mayor para el tema Oscuro
                        break;
                    case "Azul":
                        this.Background = Brushes.Blue;
                        tbTexto.Foreground = Brushes.White;
                        tbTexto.FontSize = 18; // Tamaño de texto para el tema Azul
                        break;
                }
            }
        }
    }
}
