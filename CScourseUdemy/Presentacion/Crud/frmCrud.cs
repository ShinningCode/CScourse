
using System.Data;
using System.Windows.Forms;

namespace CScourseUdemy.Presentacion.Crud
{
    public partial class frmCrud : Form
    {
        public frmCrud()
        {
            InitializeComponent();
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            MostrarClientes();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarClientes();
        }
        private void InsertarClientes()
        {
            Dclientes funcion = new Dclientes();
            Lclientes parametros = new Lclientes();
            parametros.Codigo = Convert.ToInt32(txtCodigo.Text);
            parametros.Nombres = txtNombres.Text;
            parametros.Edad = Convert.ToInt32(txtEdad.Text);

            funcion.InsertarClientes(parametros);
            MostrarClientes();
        }

        private void datalist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MostrarClientes()
        {
            Dclientes funcion = new Dclientes();
            DataTable dt = new DataTable();
            funcion.MostrarClientes(ref dt);
            datalist.DataSource = dt;
        }
    }
}
