using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppPedidos
{
    public partial class ComponenteDeImagenesDeProductosForm : Form
    {
        //Atributos globlales
        decimal precioGlobal;
        int idproducto;
        //Atributo de notificacion
        private NotifyIcon notifyIcon;



        /// <summary>
        /// Constructor de la clase ComponenteDeImagenesDeProductosForm
        /// </summary>
        /// <param name="rutaImg"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="IdProducto"></param>
        /// <param name="descripcion"></param>
        public ComponenteDeImagenesDeProductosForm(String rutaImg, string nombre, decimal precio, int IdProducto, string descripcion)
        {
            // Inicialización de la interfaz de usuario (posiblemente generado por el diseñador de formularios)
            InitializeComponent();

            // Configuración de diversos elementos de la interfaz de usuario con los parámetros proporcionados
            this.idproducto = IdProducto;  // Asignación del IdProducto a la propiedad idproducto de la instancia
            labelNombre.Text = nombre;  // Configuración del texto del control labelNombre con el nombre del producto
            label2.Text = Convert.ToString(precio);  // Configuración del texto del control label2 con el precio convertido a cadena
            precioGlobal = precio;  // Asignación del precio a la propiedad precioGlobal de la instancia
            pictureBoxImage.Image = Image.FromFile(rutaImg);  // Configuración de la imagen del PictureBox con la imagen cargada desde el archivo en la ruta especificada
            botonCarrito.Click += (sender, e) => MostrarNotificacion();  // Asociación de un manejador de eventos al clic del botónCarrito, que llama al método MostrarNotificacion()
            descripcionProducto.Text = descripcion;  // Configuración del texto del control descripcionProducto con la descripción del producto

            // Región (puede contener código relacionado)
            #region
            // Se crea un elemento de notificación
            SeCreaUnElementoNotificacion();
            #endregion
        }

        //Se crea una notificacion del sistema que avisa que se añadio un pedido
        private void SeCreaUnElementoNotificacion()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;

            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Has Añadido un pedido");
            menuItem.Click += (sender, e) => MostrarNotificacion();
            contextMenuStrip.Items.Add(menuItem);

            notifyIcon.ContextMenuStrip = contextMenuStrip;

        }
        /// <summary>
        /// Se Muestra una notificacion con un texto predeterminado
        /// </summary>
        private void MostrarNotificacion()
        {
            // Crea una notificación de Windows
            notifyIcon1.ShowBalloonTip(1000, "Pedido Agregado", "Realizaste un pedido", ToolTipIcon.Info);
        }

        private void ComponenteDeImagenesDeProductosForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CargarProductosForm padre = Owner as CargarProductosForm;
            padre.ponerDatos(idproducto, Convert.ToInt32(cantidad.Value));
            this.Close();
        }

       //Cambia en tiempo real el precio de un prodcuto mientras nosotros incrementamos o disminuimos un numero en un elemento numerico.
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
          decimal precio=precioGlobal;
         
            precio = precio * cantidad.Value;

        label2.Text=Convert.ToString(precio);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void botonCarrito_Click(object sender, EventArgs e)
        {
            CargarProductosForm padre = Owner as CargarProductosForm;
            padre.ponerDatos(idproducto, Convert.ToInt32(cantidad.Value));
            this.Close();
        }
    }
}
