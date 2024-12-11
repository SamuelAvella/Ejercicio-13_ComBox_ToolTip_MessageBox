using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Ejercicio1
{
    public partial class MainWindow : Window
    {
        // Clase que representa a un animal
        public class Animal
        {
            public string Nombre { get; set; }
            public string Imagen { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();

            // Lista de animales con sus respectivas imágenes
            List<Animal> animales = new List<Animal>
            {
                new Animal { Nombre = "Perro", Imagen = "Resource/dog.png" },
                new Animal { Nombre = "Gato", Imagen = "Resource/cat.jpg" },
                new Animal { Nombre = "Pájaro", Imagen = "Resource/bird.png" }
            };

            // Asignamos la lista al ComboBox
            cbAnimales.ItemsSource = animales;
        }

        // Evento de selección en el ComboBox
        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Verificamos que haya un ítem seleccionado
            if (cbAnimales.SelectedItem is Animal seleccionado)
            {
                // Mostrar el nombre del animal seleccionado en un MessageBox
                MessageBox.Show($"Animal seleccionado: {seleccionado.Nombre}");
            }
        }
    }
}
