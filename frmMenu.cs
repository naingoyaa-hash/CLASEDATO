using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASEDATO
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            btnPersonas.Click += btnPersonas_Click;
            btnAbogados.Click += btnAbogados_Click;
            btnAsuntos.Click += btnAsuntos_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            frmPersonas formulario = new frmPersonas();
            formulario.ShowDialog();
        }

        private void btnAbogados_Click(object sender, EventArgs e)
        {
            frmAbogados formulario = new frmAbogados();
            formulario.ShowDialog();
        }

        private void btnAsuntos_Click(object sender, EventArgs e)
        {
            frmAsunto formulario = new frmAsunto();
            formulario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir del programa?",
                "Gabinete de Abogados",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

