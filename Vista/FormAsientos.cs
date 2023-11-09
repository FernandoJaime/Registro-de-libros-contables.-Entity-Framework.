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
    public partial class FormAsientos : Form
    {
        private LibroContable libro;
        public FormAsientos(LibroContable seleccionado)
        {
            InitializeComponent();
            this.libro = seleccionado;
        }

        private void Actualizar()
        {
            dgvAsientoss.DataSource = null;
            dgvAsientoss.DataSource = libro.Asientos.ToList();

            dateTimePicker1.Value = libro.MesYear;
            numCapital.Value = libro.CapitalActual;
            dateTimePicker1.Enabled = false;
            numCapital.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAsientos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

    }
}