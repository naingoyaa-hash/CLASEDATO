namespace CLASEDATO
{
    partial class frmPersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApllidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpfechaNacimineto = new System.Windows.Forms.DateTimePicker();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btnActualizarPersona = new System.Windows.Forms.Button();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(36, 40);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "CEDULA";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(129, 33);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(121, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // txtApllidos
            // 
            this.txtApllidos.Location = new System.Drawing.Point(129, 61);
            this.txtApllidos.Name = "txtApllidos";
            this.txtApllidos.Size = new System.Drawing.Size(121, 20);
            this.txtApllidos.TabIndex = 2;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(37, 65);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(66, 13);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "APELLIDOS";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(36, 96);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(61, 13);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "NOMBRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "FECHA_NAC";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(36, 124);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(36, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "SEXO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TELEFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "EMAIL";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(129, 89);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(121, 20);
            this.txtNombres.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(129, 180);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(129, 119);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 14;
            // 
            // dtpfechaNacimineto
            // 
            this.dtpfechaNacimineto.Location = new System.Drawing.Point(129, 150);
            this.dtpfechaNacimineto.Name = "dtpfechaNacimineto";
            this.dtpfechaNacimineto.Size = new System.Drawing.Size(197, 20);
            this.dtpfechaNacimineto.TabIndex = 15;
            this.dtpfechaNacimineto.Value = new System.DateTime(2026, 8, 26, 23, 26, 46, 0);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(358, 61);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(589, 311);
            this.dgvPersonas.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "BUSCAR PERSONAS";
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.Location = new System.Drawing.Point(474, 30);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(234, 20);
            this.txtBuscarPersona.TabIndex = 18;
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Location = new System.Drawing.Point(474, 402);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(86, 36);
            this.btnGuardarPersona.TabIndex = 19;
            this.btnGuardarPersona.Text = "GUARDAR";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPersona
            // 
            this.btnActualizarPersona.Location = new System.Drawing.Point(587, 401);
            this.btnActualizarPersona.Name = "btnActualizarPersona";
            this.btnActualizarPersona.Size = new System.Drawing.Size(112, 37);
            this.btnActualizarPersona.TabIndex = 20;
            this.btnActualizarPersona.Text = "ACTUALIZAR";
            this.btnActualizarPersona.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.Location = new System.Drawing.Point(727, 401);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(87, 37);
            this.btnEliminarPersona.TabIndex = 21;
            this.btnEliminarPersona.Text = "ELIMINAR";
            this.btnEliminarPersona.UseVisualStyleBackColor = true;
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.btnEliminarPersona);
            this.Controls.Add(this.btnActualizarPersona);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.txtBuscarPersona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.dtpfechaNacimineto);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtApllidos);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Name = "frmPersonas";
            this.Text = "frmPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApllidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtpfechaNacimineto;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Button btnActualizarPersona;
        private System.Windows.Forms.Button btnEliminarPersona;
    }
}