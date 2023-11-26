using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppPedidos
{
    public partial class AuricularesGamersForm : Form
    {
        public AuricularesGamersForm()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AuricularesGamersForm_Load(object sender, EventArgs e)
        {

        }
        private void CargarImagenes()
        {   // Directorio donde se encuentran las imágenes
            String directorioImagenes = @".\imagenes";


            // Obtiene la lista de archivos de imagen en el directorio
            string[] archivosImagen = Directory.GetFiles(directorioImagenes, "*.JPG");// o la extensión de tus imágenes esto dependera del tipo de formato


            // Verifica que el FlowLayoutPanel existente no sea nulo
            if (flowLayoutPanel1 != null)
            {

                // Recorre la lista de archivos y agrega un Panel para cada imagen con un nombre de producto
                foreach (string archivoImagen in archivosImagen)
                {
                    Panel panel = new Panel();
                    panel.Padding = new Padding(3, 30, 3, 10);
                    panel.Width = 180; //ajustamos el size
                    panel.Height = 197;
                    panel.BorderStyle = BorderStyle.FixedSingle;


                    //Creamos un picture box dentro del panel
                    PictureBox pictureBox = new PictureBox();

                    pictureBox.Dock = DockStyle.Top;
                    pictureBox.Height = 120;
                    pictureBox.Image = Image.FromFile(archivoImagen);

                    //Ajusta la imagen al size de la picture box
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    // Crea un Label con el nombre del producto
                    Label labelNombreProducto = new Label();
                    labelNombreProducto.Text = ObtenerNombreProductoDesdeArchivo(archivoImagen);
                    labelNombreProducto.Dock = DockStyle.Bottom; // El Label ocupa la parte inferior del Panel

                    // Agrega la PictureBox y el Label al Panel
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(labelNombreProducto);

                    // Agrega el Panel al FlowLayoutPanel existente
                    flowLayoutPanel1.Controls.Add(panel);
                    pictureBox.Click += (sender, e) => MostrarFormularioImagen(archivoImagen);




                }



            }
        }
        private void MostrarFormularioImagen(string rutaImagen)
        {
            // Crea un nuevo formulario hijo para mostrar la imagen y el botón
            ComponenteDeImagenesDeProductosForm formularioImagen = new ComponenteDeImagenesDeProductosForm(rutaImagen);

            // Abre el formulario hijo
            formularioImagen.Show();
        }
        private string ObtenerNombreProductoDesdeArchivo(string rutaArchivo)
        {
            // Puedes implementar lógica para obtener el nombre del producto desde el nombre del archivo
            // Por ejemplo, podrías extraer el nombre del archivo sin la extensión
            string nombreArchivo = Path.GetFileNameWithoutExtension(rutaArchivo);
            // Retorna el nombre del producto (puedes ajustar esto según tu lógica específica)
            return nombreArchivo;
        }
    }
}
