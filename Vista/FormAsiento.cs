using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAsiento : Form
    {
        public FormAsiento()
        {
            InitializeComponent();
        }

        private void ActualizarAsientos()
        {
            dgvAsientos.DataSource = null;
            dgvAsientos.DataSource = ControladoraLibros.Instancia.ListarAsientos();

            comboConceptos.Items.Clear();
            comboConceptos.Items.AddRange(ControladoraLibros.Instancia.ListarConceptos().ToArray());

            comboLibros.Items.Clear();
            comboLibros.Items.AddRange(ControladoraLibros.Instancia.ListarLibros().ToArray());
        }
        // Validaciones simples de campos.
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.comboBox1.Text) || string.IsNullOrEmpty(this.comboConceptos.Text) || string.IsNullOrEmpty(this.numCodigo.Text) || string.IsNullOrEmpty(this.numMonto.Text) || string.IsNullOrEmpty(this.dateTimePicker1.Text) || string.IsNullOrEmpty(this.comboLibros.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var asiento = new Asiento()
                {
                    Codigo = Convert.ToInt32(numCodigo.Text),
                    Fecha = dateTimePicker1.Value.Date,
                    Concepto = (Concepto)comboConceptos.SelectedItem,
                    Monto = Convert.ToInt32(numMonto.Text),
                    TipoAsiento = (Asiento.Tipo)Enum.Parse(typeof(Asiento.Tipo), comboBox1.Text),
                    LibroContable = (LibroContable)comboLibros.SelectedItem
                };

                var libro = (LibroContable)comboLibros.SelectedItem;
                if (libro.MesYear.Month != asiento.Fecha.Month || libro.MesYear.Year != asiento.Fecha.Year)
                {
                    MessageBox.Show("El asiento debe estar dentro del mes y año que es el libro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var mensaje = ControladoraLibros.Instancia.AgregarAsiento(asiento);
                    if (mensaje == "Agregado correctamente.")
                    {
                        asiento.LibroContable.AgregarAsiento(asiento);
                        ControladoraLibros.Instancia.ModificarLibro(asiento.LibroContable);
                    }
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAsientos.CurrentRow != null)
            {
                var Select = (Asiento)dgvAsientos.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show("¿Confima que desea eliminar el objeto seleccionado de la base de datos?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    var mensaje = ControladoraLibros.Instancia.EliminarAsiento(Select);
                    if (mensaje == "Eliminado correctamente.")
                    {
                        Select.LibroContable.EliminarAsiento(Select);
                        ControladoraLibros.Instancia.ModificarLibro(Select.LibroContable);
                    }
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarAsientos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un objeto para poder utilizar esta funcion.");
            }
        }

        private void FormAsiento_Load(object sender, EventArgs e)
        {
            this.Text = "Administracion de asientos";
            ActualizarAsientos();
        }
    }
}
