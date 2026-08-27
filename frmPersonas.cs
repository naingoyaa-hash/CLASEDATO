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
    public partial class frmPersonas : Form
    {

        private readonly CADPersona cadPersona = new CADPersona();

        private string cedulaOriginal = "";

        public frmPersonas()
        {
            InitializeComponent();

            this.Load += frmPersonas_Load;

            btnGuardarPersona.Click += btnGuardarPersona_Click;
            btnActualizarPersona.Click += btnActualizarPersona_Click;
            btnEliminarPersona.Click += btnEliminarPersona_Click;
            txtBuscarPersona.TextChanged += txtBuscarPersona_TextChanged;
            dgvPersonas.CellClick += dgvPersonas_CellClick;
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            ConfigurarFormulario();
            CargarPersonas();
            LimpiarCampos();
        }

        private void ConfigurarFormulario()
        {

            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");

            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.SelectedIndex = -1;

            dtpfechaNacimineto.Format =
                DateTimePickerFormat.Short;

            dtpfechaNacimineto.MaxDate = DateTime.Today;

            dgvPersonas.ReadOnly = true;

            dgvPersonas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPersonas.MultiSelect = false;

            dgvPersonas.AllowUserToAddRows = false;

            dgvPersonas.AllowUserToDeleteRows = false;

            dgvPersonas.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPersonas.RowHeadersVisible = false;

            txtCedula.MaxLength = 15;
            txtApllidos.MaxLength = 25;
            txtNombres.MaxLength = 25;
            txtTelefono.MaxLength = 15;
            txtEmail.MaxLength = 35;

            txtBuscarPersona.MaxLength = 15;
        }

        private void CargarPersonas()
        {
            try
            {
                DataTable tabla = cadPersona.Seleccionar();

                dgvPersonas.DataSource = tabla;

                dgvPersonas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las personas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnGuardarPersona_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                ResultadoCRUD resultado =
                    cadPersona.Insertar(
                        txtCedula.Text.Trim(),
                        txtApllidos.Text.Trim(),
                        txtNombres.Text.Trim(),
                        ObtenerSexo(),
                        dtpfechaNacimineto.Value.Date,
                        txtEmail.Text.Trim(),
                        txtTelefono.Text.Trim()
                    );

                if (resultado.Codigo == 1)
                {
                    MessageBox.Show(
                        resultado.Mensaje,
                        "Persona registrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarPersonas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        resultado.Mensaje,
                        "No se pudo registrar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la persona.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnActualizarPersona_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cedulaOriginal))
            {
                MessageBox.Show(
                    "Seleccione primero una persona de la tabla.",
                    "Actualizar persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea actualizar esta persona?",
                "Confirmar actualización",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                ResultadoCRUD resultado =
                    cadPersona.Actualizar(
                        cedulaOriginal,
                        txtCedula.Text.Trim(),
                        txtApllidos.Text.Trim(),
                        txtNombres.Text.Trim(),
                        ObtenerSexo(),
                        dtpfechaNacimineto.Value.Date,
                        txtEmail.Text.Trim(),
                        txtTelefono.Text.Trim()
                    );

                if (resultado.Codigo == 2)
                {
                    MessageBox.Show(
                        resultado.Mensaje,
                        "Persona actualizada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarPersonas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        resultado.Mensaje,
                        "No se pudo actualizar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar la persona.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cedulaOriginal))
            {
                MessageBox.Show(
                    "Seleccione primero una persona de la tabla.",
                    "Eliminar persona",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar la persona con cédula " +
                cedulaOriginal + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                ResultadoCRUD resultado = cadPersona.Eliminar(cedulaOriginal);

                if (resultado.Codigo == 3)
                {
                    MessageBox.Show(
                        resultado.Mensaje,
                        "Persona eliminada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }
                else
                {
                    MessageBox.Show(
                        resultado.Mensaje,
                        "No se pudo eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la persona.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            CargarPersonas();
            LimpiarCampos();
        }

        private void txtBuscarPersona_TextChanged(
            object sender,
            EventArgs e)
        {
            string cedula = txtBuscarPersona.Text.Trim();

            if (string.IsNullOrWhiteSpace(cedula))
            {
                CargarPersonas();
                return;
            }

            try
            {
                DataTable tabla = cadPersona.Buscar(cedula);

                if (tabla.Columns.Contains("CEDULA"))
                {
                    dgvPersonas.DataSource = tabla;
                }
                else
                {
                    dgvPersonas.DataSource = null;
                }

                dgvPersonas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar la persona.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvPersonas.Rows.Count == 0)
            {
                return;
            }

            try
            {
                DataGridViewRow fila = dgvPersonas.Rows[e.RowIndex];

                cedulaOriginal =
                    ObtenerValorCelda(fila, "CEDULA");

                txtCedula.Text =
                    cedulaOriginal;

                txtApllidos.Text =
                    ObtenerValorCelda(fila, "APELLIDOS");

                txtNombres.Text =
                    ObtenerValorCelda(fila, "NOMBRES");

                txtTelefono.Text =
                    ObtenerValorCelda(fila, "TELEFONO");

                txtEmail.Text =
                    ObtenerValorCelda(fila, "EMAIL");

                if (fila.Cells["FECHA_NAC"].Value != null &&
                    fila.Cells["FECHA_NAC"].Value != DBNull.Value)
                {
                    dtpfechaNacimineto.Value =
                        Convert.ToDateTime(
                            fila.Cells["FECHA_NAC"].Value
                        );
                }

                if (fila.Cells["SEXO"].Value != null &&
                    fila.Cells["SEXO"].Value != DBNull.Value)
                {
                    bool sexo =
                        Convert.ToBoolean(
                            fila.Cells["SEXO"].Value
                        );

                    if (sexo)
                    {
                        cmbSexo.SelectedItem =
                            "Masculino";
                    }
                    else
                    {
                        cmbSexo.SelectedItem =
                            "Femenino";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos de la persona.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show(
                    "Ingrese la cédula de la persona.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCedula.Focus();
                return false;
            }

            if (txtCedula.Text.Trim().Length > 15)
            {
                MessageBox.Show(
                    "La cédula no puede tener más de 15 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCedula.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApllidos.Text))
            {
                MessageBox.Show(
                    "Ingrese los apellidos de la persona.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtApllidos.Focus();
                return false;
            }

            if (txtApllidos.Text.Trim().Length > 25)
            {
                MessageBox.Show(
                    "Los apellidos no pueden superar los 25 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtApllidos.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MessageBox.Show(
                    "Ingrese los nombres de la persona.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombres.Focus();
                return false;
            }

            if (txtNombres.Text.Trim().Length > 25)
            {
                MessageBox.Show(
                    "Los nombres no pueden superar los 25 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombres.Focus();
                return false;
            }

            if (cmbSexo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el sexo.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbSexo.Focus();
                return false;
            }

            if (dtpfechaNacimineto.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "La fecha de nacimiento no puede ser futura.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                dtpfechaNacimineto.Focus();
                return false;
            }

            if (txtTelefono.Text.Trim().Length > 15)
            {
                MessageBox.Show(
                    "El teléfono no puede superar los 15 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTelefono.Focus();
                return false;
            }

            if (txtEmail.Text.Trim().Length > 35)
            {
                MessageBox.Show(
                    "El correo electrónico no puede superar los 35 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool ObtenerSexo()
        {
            return cmbSexo.SelectedItem.ToString() ==
                   "Masculino";
        }

        private string ObtenerValorCelda(DataGridViewRow fila, string nombreColumna)
        {
            if (fila.Cells[nombreColumna].Value == null ||
                fila.Cells[nombreColumna].Value == DBNull.Value)
            {
                return "";
            }

            return fila.Cells[nombreColumna]
                .Value
                .ToString()
                .Trim();
        }

        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtApllidos.Clear();
            txtNombres.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            cmbSexo.SelectedIndex = -1;

            dtpfechaNacimineto.Value = DateTime.Today;

            cedulaOriginal = "";

            if (dgvPersonas.Rows.Count > 0)
            {
                dgvPersonas.ClearSelection();
            }

            txtCedula.Focus();
        }
    }
}
