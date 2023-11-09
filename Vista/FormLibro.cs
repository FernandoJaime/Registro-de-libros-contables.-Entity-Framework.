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
    public partial class FormLibro : Form
    {
        private LibroContable libro;
        private bool modifica = false;

        // Constructor para agregar un producto.
        public FormLibro()
        {
            InitializeComponent();
        }

        // Constructor para modificar un producto.
        public FormLibro(LibroContable seleccionado)
        {
            InitializeComponent();
            this.libro = seleccionado;
            modifica = true;
        }

        // Validaciones simples de campos.
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.numCapital.Text) || string.IsNullOrEmpty(this.dateTimePicker1.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                if (modifica)
                {
                    libro.MesYear = dateTimePicker1.Value.Date;
                    libro.CapitalActual = Convert.ToInt32(numCapital.Text);

                    var mensaje = ControladoraLibros.Instancia.ModificarLibro(libro);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var libro1 = new LibroContable()
                    {
                        MesYear = dateTimePicker1.Value.Date,
                        CapitalActual = Convert.ToInt32(numCapital.Text)
                    };

                    var mensaje = ControladoraLibros.Instancia.AgregarLibro(libro1);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLibro_Load(object sender, EventArgs e)
        {
            if (modifica)
            {
                this.Text = "Modificar Libro";
                dateTimePicker1.Enabled = false;
                dateTimePicker1.Value = libro.MesYear;
                numCapital.Text = libro.CapitalActual.ToString();
            }
            else
            {
                this.Text = "Agregar Libro";
            }
        }
    }
}