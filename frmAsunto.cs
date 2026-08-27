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
    public partial class frmAsunto : Form
    {

        private readonly CADAsunto cadAsunto = new CADAsunto();

        private long expedienteOriginal = 0;

        private bool asuntoSeleccionado = false;

        public frmAsunto()
        {
            InitializeComponent();

            this.Load += frmAsunto_Load;

            btbNuevoNexpediente.Click += btbNuevoNexpediente_Click;
            btnGuardarNexpediente.Click += btnGuardarNexpediente_Click;
            btnActualizarNexpediente.Click += btnActualizarNexpediente_Click;
            btnEliminarNexpediente.Click += btnEliminarNexpediente_Click;

            txtBuscarAsunto.TextChanged += txtBuscarAsunto_TextChanged;

            dgvAsunto.CellClick += dgvAsunto_CellClick;

            txtNExpediente.KeyPress += SoloNumeros_KeyPress;
            txtBuscarAsunto.KeyPress += SoloNumeros_KeyPress;
        }

        private void frmAsunto_Load(object sender, EventArgs e)
        {
            ConfigurarFormulario();
            CargarAsuntos();
            LimpiarCampos();
        }

        private void ConfigurarFormulario()
        {
            txtNExpediente.MaxLength = 19;
            txtBuscarAsunto.MaxLength = 19;

            txtCedulaAsunto.MaxLength = 15;

            dtpInicioAsunto.Format = DateTimePickerFormat.Short;
            dtpInicioAsunto.MaxDate = DateTime.Today;

            dgvAsunto.ReadOnly = true;

            dgvAsunto.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAsunto.MultiSelect = false;

            dgvAsunto.AllowUserToAddRows = false;

            dgvAsunto.AllowUserToDeleteRows = false;

            dgvAsunto.RowHeadersVisible = false;

            dgvAsunto.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarAsuntos()
        {
            try
            {
                DataTable tabla = cadAsunto.Seleccionar();

                dgvAsunto.DataSource = tabla;

                if (dgvAsunto.Rows.Count > 0)
                {
                    dgvAsunto.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los asuntos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btbNuevoNexpediente_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();

            txtBuscarAsunto.Clear();

            CargarAsuntos();

            txtNExpediente.Focus();
        }

        private void btnGuardarNexpediente_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            long numeroExpediente;

            if (!long.TryParse(
                    txtNExpediente.Text.Trim(),
                    out numeroExpediente))
            {
                MessageBox.Show(
                    "El número de expediente no es válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNExpediente.Focus();
                return;
            }

            try
            {
                ResultadoCRUD resultado =
                    cadAsunto.Insertar(
                        numeroExpediente,
                        txtCedulaAsunto.Text.Trim(),
                        dtpInicioAsunto.Value.Date,
                        txtResumenAsunto.Text.Trim()
                    );

                if (resultado.Codigo == 1)
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "INSERCIÓN EXITOSA"
                        ),
                        "Asunto registrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarAsuntos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "No se pudo registrar el asunto."
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
                    "Error al guardar el asunto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnActualizarNexpediente_Click(
            object sender,
            EventArgs e)
        {
            if (!asuntoSeleccionado)
            {
                MessageBox.Show(
                    "Seleccione primero un asunto de la tabla.",
                    "Actualizar asunto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            long nuevoExpediente;

            if (!long.TryParse(
                    txtNExpediente.Text.Trim(),
                    out nuevoExpediente))
            {
                MessageBox.Show(
                    "El número de expediente no es válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNExpediente.Focus();
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea actualizar este asunto?",
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
                    cadAsunto.Actualizar(
                        expedienteOriginal,
                        nuevoExpediente,
                        txtCedulaAsunto.Text.Trim(),
                        dtpInicioAsunto.Value.Date,
                        txtResumenAsunto.Text.Trim()
                    );

                if (resultado.Codigo == 2)
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "ACTUALIZACIÓN EXITOSA"
                        ),
                        "Asunto actualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarAsuntos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "No se pudo actualizar el asunto."
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
                    "Error al actualizar el asunto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminarNexpediente_Click(
            object sender,
            EventArgs e)
        {
            if (!asuntoSeleccionado)
            {
                MessageBox.Show(
                    "Seleccione primero un asunto de la tabla.",
                    "Eliminar asunto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea eliminar el expediente " +
                expedienteOriginal + "?",
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
                    cadAsunto.Eliminar(expedienteOriginal);

                if (resultado.Codigo == 3)
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "ELIMINACIÓN EXITOSA"
                        ),
                        "Asunto eliminado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarAsuntos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        ObtenerMensaje(
                            resultado,
                            "No se pudo eliminar el asunto."
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
                    "Error al eliminar el asunto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtBuscarAsunto_TextChanged(
            object sender,
            EventArgs e)
        {
            string texto = txtBuscarAsunto.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                CargarAsuntos();
                return;
            }

            long numeroExpediente;

            if (!long.TryParse(texto, out numeroExpediente))
            {
                dgvAsunto.DataSource = null;
                return;
            }

            try
            {
                DataTable tabla = cadAsunto.Buscar(numeroExpediente);

                if (tabla.Columns.Contains("NEXPEDIENTE"))
                {
                    dgvAsunto.DataSource = tabla;
                }
                else
                {
                    dgvAsunto.DataSource = null;
                }

                if (dgvAsunto.Rows.Count > 0)
                {
                    dgvAsunto.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el asunto.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dgvAsunto_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvAsunto.Rows.Count == 0)
            {
                return;
            }

            try
            {
                DataGridViewRow fila = dgvAsunto.Rows[e.RowIndex];

                if (fila.Cells["NEXPEDIENTE"].Value == null ||
                    fila.Cells["NEXPEDIENTE"].Value == DBNull.Value)
                {
                    return;
                }

                expedienteOriginal =
                    Convert.ToInt64(
                        fila.Cells["NEXPEDIENTE"].Value
                    );

                asuntoSeleccionado = true;

                txtNExpediente.Text =
                    expedienteOriginal.ToString();

                txtCedulaAsunto.Text =
                    ObtenerValorCelda(
                        fila,
                        "CEDULA"
                    );

                if (fila.Cells["INICIO"].Value != null &&
                    fila.Cells["INICIO"].Value != DBNull.Value)
                {
                    DateTime fecha =
                        Convert.ToDateTime(
                            fila.Cells["INICIO"].Value
                        );

                    if (fecha.Date <= dtpInicioAsunto.MaxDate)
                    {
                        dtpInicioAsunto.Value =
                            fecha.Date;
                    }
                }

                txtResumenAsunto.Text =
                    ObtenerValorCelda(
                        fila,
                        "RESUMEN"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos del asunto.\n\n" +
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
                    txtNExpediente.Text))
            {
                MessageBox.Show(
                    "Ingrese el número de expediente.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNExpediente.Focus();
                return false;
            }

            long numeroExpediente;

            if (!long.TryParse(
                    txtNExpediente.Text.Trim(),
                    out numeroExpediente))
            {
                MessageBox.Show(
                    "El número de expediente debe contener únicamente números.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNExpediente.Focus();
                return false;
            }

            if (numeroExpediente <= 0)
            {
                MessageBox.Show(
                    "El número de expediente debe ser mayor que cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNExpediente.Focus();
                return false;
            }

            if (txtCedulaAsunto.Text.Trim().Length > 15)
            {
                MessageBox.Show(
                    "La cédula no puede superar los 15 caracteres.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCedulaAsunto.Focus();
                return false;
            }

            if (dtpInicioAsunto.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "La fecha de inicio no puede ser futura.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                dtpInicioAsunto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(
                    txtResumenAsunto.Text))
            {
                MessageBox.Show(
                    "Ingrese el resumen del asunto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtResumenAsunto.Focus();
                return false;
            }

            return true;
        }

        private void SoloNumeros_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
            txtNExpediente.Clear();
            txtCedulaAsunto.Clear();
            txtResumenAsunto.Clear();

            dtpInicioAsunto.Value =
                DateTime.Today;

            expedienteOriginal = 0;
            asuntoSeleccionado = false;

            if (dgvAsunto.Rows.Count > 0)
            {
                dgvAsunto.ClearSelection();
            }

            txtNExpediente.Focus();
        }
    }
}
