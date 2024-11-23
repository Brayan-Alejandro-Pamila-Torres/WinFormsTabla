using System.Data;
using WinFormsTabla.Data;
using WinFormsTabla.Modelo;

namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            Grilla.DataSource = tabla;
        }
        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel()
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text)
            };
            dato.Guardar(modelo);

        }
        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
           this.Close();

        }
    }
}
