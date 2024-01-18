
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CScourseUdemy.Presentacion.Crud
{
    public partial class frmCrud : Form
    {
        public frmCrud()
        {
            InitializeComponent();
        }
        int idcliente;
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
        //private void datalist_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    
        //}
        private void MostrarClientes()
        {
            Dclientes funcion = new Dclientes();
            DataTable dt = new DataTable();
            funcion.MostrarClientes(ref dt);
            datalist.DataSource = dt;
        }


        private void Actualizar()
        {
            Dclientes funcion = new Dclientes();
            Lclientes parametros = new Lclientes();
            parametros.Idclientes = idcliente;
            parametros.Nombres = txtNombres.Text;
            parametros.Edad = Convert.ToInt32(txtEdad.Text);
            funcion.EditarClientes(parametros);
            MostrarClientes();
        }

        private void datalist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idcliente = Convert.ToInt32(datalist.SelectedCells[0].Value);
            txtCodigo.Text = datalist.SelectedCells[1].Value.ToString();
            txtNombres.Text = datalist.SelectedCells[2].Value.ToString();
            txtEdad.Text = datalist.SelectedCells[3].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }

}
