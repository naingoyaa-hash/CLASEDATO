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
    public partial class frmAbogados : Form
    {
        
        private readonly CADAbogado cadAbogado = new CADAbogado();

        private string licenciaOriginal = "";

        private bool abogadoSeleccionado = false;

        public frmAbogados()
        {
            InitializeComponent();

            this.Load += frmAbogados_Load;

            btbNuevoAbogado.Click += btbNuevoAbogado_Click;
            btnGuardarPersona.Click += btnGuardarPersona_Click;
            btnActualizarPersona.Click += btnActualizarPersona_Click;
            btnEliminarPersona.Click += btnEliminarPersona_Click;

            txtBuscarAbogado.TextChanged += txtBuscarAbogado_TextChanged;

            dgvAbogados.CellClick += dgvAbogados_CellClick;
        }

        private void frmAbogados_Load(object sender, EventArgs e)
        {
            ConfigurarFormulario();
            CargarAbogados();
            LimpiarCampos();
        }

        private void ConfigurarFormulario()
        {
            txtNumLicencia.MaxLength = 20;
            txtCedulaAbogado.MaxLength = 15;
            txtBuscarAbogado.MaxLength = 20;

            dtvVigenteDesde.Format = DateTimePickerFormat.Short;

            dtvVigenteDesde.MaxDate = DateTime.Today;

            chkActivoAbogado.Text = "Activo";

            dgvAbogados.ReadOnly = true;

            dgvAbogados.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAbogados.MultiSelect = false;

            dgvAbogados.AllowUserToAddRows = false;

            dgvAbogados.AllowUserToDeleteRows = false;

            dgvAbogados.RowHeadersVisible = false;

            dgvAbogados.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarAbogados()
        {
            try
            {
                DataTable tabla =
                    cadAbogado.Seleccionar();

                dgvAbogados.DataSource = tabla;

                if (dgvAbogados.Rows.Count > 0)
                {
                    dgvAbogados.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los abogados.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btbNuevoAbogado_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();

            txtBuscarAbogado.Clear();

            CargarAbogados();

            txtNumLicencia.Focus();
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
                    cadAbogado.Insertar(
                        txtNumLicencia.Text.Trim(),
                        txtCedulaAbogado.Text.Trim(),
                        dtvVigenteDesde.Value.Date,
                        chkActivoAbogado.Checked
                    );

                if (resultado.Codigo == 1)
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "INSERCIÓN EXITOSA"
                        ),
                        "Abogado registrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarAbogados();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "No se pudo registrar el abogado."
                        ),
                        "No se pudo guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el abogado.\n\n" +
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
            if (!abogadoSeleccionado)
            {
                MessageBox.Show(
                    "Seleccione primero un abogado de la tabla.",
                    "Actualizar abogado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Está seguro que desea actualizar los datos del abogado?",
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
                    cadAbogado.Actualizar(
                        licenciaOriginal,
                        txtNumLicencia.Text.Trim(),
                        txtCedulaAbogado.Text.Trim(),
                        dtvVigenteDesde.Value.Date,
                        chkActivoAbogado.Checked
                    );

                if (resultado.Codigo == 2)
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "ACTUALIZACIÓN EXITOSA"
                        ),
                        "Abogado actualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarAbogados();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "No se pudo actualizar el abogado."
                        ),
                        "No se pudo actualizar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el abogado.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminarPersona_Click(
            object sender,
            EventArgs e)
        {
            if (!abogadoSeleccionado)
            {
                MessageBox.Show(
                    "Seleccione primero un abogado de la tabla.",
                    "Eliminar abogado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Está seguro que desea eliminar al abogado con licencia " +
                    licenciaOriginal + "?",
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
                ResultadoCRUD resultado =
                    cadAbogado.Eliminar(
                        licenciaOriginal
                    );

                if (resultado.Codigo == 3)
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "ELIMINACIÓN EXITOSA"
                        ),
                        "Abogado eliminado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarAbogados();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "No se pudo eliminar el abogado."
                        ),
                        "No se pudo eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el abogado.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtBuscarAbogado_TextChanged(
            object sender,
            EventArgs e)
        {
            string licencia = txtBuscarAbogado.Text.Trim();

            if (string.IsNullOrWhiteSpace(licencia))
            {
                CargarAbogados();
                return;
            }

            try
            {
                DataTable tabla = cadAbogado.Buscar(licencia);

                if (tabla.Columns.Contains("NUM_LICENCIA"))
                {
                    dgvAbogados.DataSource = tabla;
                }
                else
                {
                    dgvAbogados.DataSource = null;
                }

                if (dgvAbogados.Rows.Count > 0)
                {
                    dgvAbogados.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el abogado.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvAbogados_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvAbogados.Rows.Count == 0)
            {
                return;
            }

            try
            {
                DataGridViewRow fila = dgvAbogados.Rows[e.RowIndex];

                licenciaOriginal =
                    ObtenerValorCelda(
                        fila,
                        "NUM_LICENCIA"
                    );

                if (string.IsNullOrWhiteSpace(
                        licenciaOriginal))
                {
                    return;
                }

                abogadoSeleccionado = true;

                txtNumLicencia.Text =
                    licenciaOriginal;

                txtCedulaAbogado.Text = ObtenerValorCelda( fila, "CEDULA");

                if (fila.Cells["VIGENTE_DESDE"].Value != null &&
                    fila.Cells["VIGENTE_DESDE"].Value != DBNull.Value)
                {
                    DateTime fecha = Convert.ToDateTime(
                            fila.Cells["VIGENTE_DESDE"].Value);

                    if (fecha.Date <=
                        dtvVigenteDesde.MaxDate)
                    {
                        dtvVigenteDesde.Value =
                            fecha.Date;
                    }
                    else
                    {
                        dtvVigenteDesde.Value =
                            DateTime.Today;
                    }
                }

                if (fila.Cells["ACTIVO"].Value != null &&
                    fila.Cells["ACTIVO"].Value != DBNull.Value)
                {
                    chkActivoAbogado.Checked =
                        Convert.ToBoolean(
                            fila.Cells["ACTIVO"].Value
                        );
                }
                else
                {
                    chkActivoAbogado.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos del abogado.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(
                    txtNumLicencia.Text))
            {
                MessageBox.Show(
                    "Ingrese el número de licencia.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNumLicencia.Focus();
                return false;
            }

            if (txtNumLicencia.Text.Trim().Length > 20)
            {
                MessageBox.Show(
                    "El número de licencia no puede superar los 20 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNumLicencia.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(
                    txtCedulaAbogado.Text))
            {
                MessageBox.Show(
                    "Ingrese la cédula de la persona asociada al abogado.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCedulaAbogado.Focus();
                return false;
            }

            if (txtCedulaAbogado.Text.Trim().Length > 15)
            {
                MessageBox.Show(
                    "La cédula no puede superar los 15 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCedulaAbogado.Focus();
                return false;
            }

            if (dtvVigenteDesde.Value.Date >
                DateTime.Today)
            {
                MessageBox.Show(
                    "La fecha de vigencia no puede ser futura.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                dtvVigenteDesde.Focus();
                return false;
            }

            return true;
        }

        private string ObtenerValorCelda(
            DataGridViewRow fila,
            string nombreColumna)
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

        private string ObtenerMensaje(
            ResultadoCRUD resultado,
            string mensajePredeterminado)
        {
            if (resultado == null)
            {
                return mensajePredeterminado;
            }

            if (string.IsNullOrWhiteSpace(
                    resultado.Mensaje))
            {
                return mensajePredeterminado;
            }

            return resultado.Mensaje;
        }

        private void LimpiarCampos()
        {
            txtNumLicencia.Clear();
            txtCedulaAbogado.Clear();

            dtvVigenteDesde.Value =
                DateTime.Today;

            chkActivoAbogado.Checked = true;

            licenciaOriginal = "";
            abogadoSeleccionado = false;

            if (dgvAbogados.Rows.Count > 0)
            {
                dgvAbogados.ClearSelection();
            }

            txtNumLicencia.Focus();
        }
    }
}
