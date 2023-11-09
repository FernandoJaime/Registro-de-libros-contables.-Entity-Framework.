using Controladora;
using Entidades;
using Microsoft.VisualBasic;

namespace Vista
{
    public partial class FormLibros : Form
    {
        public FormLibros()
        {
            InitializeComponent();
        }

        private void ActualizarGrilla()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = ControladoraLibros.Instancia.ListarLibros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var open = new FormLibro();
            open.ShowDialog();
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                var Select = (LibroContable)dgvLibros.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el objeto seleccionado de la base de datos?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = ControladoraLibros.Instancia.EliminarLibro(Select);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un objeto para poder utilizar esta funcion.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                var select = (LibroContable)dgvLibros.CurrentRow.DataBoundItem;
                var open = new FormLibro(select);
                open.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un objeto para poder utilizar esta funcion.");
            }
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var select = (LibroContable)dgvLibros.CurrentRow.DataBoundItem;
            var open = new FormAsientos(select);
            open.ShowDialog();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var open = new FormAsiento();
            open.ShowDialog();
            ActualizarGrilla();
        }
    }
}