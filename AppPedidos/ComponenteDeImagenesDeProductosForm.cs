using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppPedidos
{
    public partial class ComponenteDeImagenesDeProductosForm : Form
    {

        decimal precioGlobal;
        int idproducto;
        //Atributo de notificacion
        private NotifyIcon notifyIcon;
        public ComponenteDeImagenesDeProductosForm(String rutaImg, string nombre, decimal precio, int IdProducto)
        {
            InitializeComponent();
            // Configura el PictureBox con la imagen seleccionada
            this.idproducto = IdProducto;
            labelNombre.Text = nombre;
            label2.Text=Convert.ToString(precio);
            precioGlobal = precio;
            pictureBoxImage.Image = Image.FromFile(rutaImg);
            botonCarrito.Click += (sender, e) => MostrarNotificacion();

            #region 
            //se crea una notificaicon
            SeCreaUnElementoNotificacion();
            #endregion
        }
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
            MonitoresStandarsForm padre = Owner as MonitoresStandarsForm;
            padre.ponerDatos(idproducto, Convert.ToInt32(cantidad.Value));
            this.Close();
        }

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
    }
}
