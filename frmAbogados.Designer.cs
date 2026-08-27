namespace CLASEDATO
{
    partial class frmAbogados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumLicencia = new System.Windows.Forms.TextBox();
            this.dtvVigenteDesde = new System.Windows.Forms.DateTimePicker();
            this.chkActivoAbogado = new System.Windows.Forms.CheckBox();
            this.dgvAbogados = new System.Windows.Forms.DataGridView();
            this.txtBuscarAbogado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.btnActualizarPersona = new System.Windows.Forms.Button();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btbNuevoAbogado = new System.Windows.Forms.Button();
            this.txtCedulaAbogado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbogados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUM_LICENCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VIGENTE_DESDE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ACTIVO";
            // 
            // txtNumLicencia
            // 
            this.txtNumLicencia.Location = new System.Drawing.Point(184, 33);
            this.txtNumLicencia.Name = "txtNumLicencia";
            this.txtNumLicencia.Size = new System.Drawing.Size(100, 20);
            this.txtNumLicencia.TabIndex = 4;
            // 
            // dtvVigenteDesde
            // 
            this.dtvVigenteDesde.Location = new System.Drawing.Point(184, 98);
            this.dtvVigenteDesde.Name = "dtvVigenteDesde";
            this.dtvVigenteDesde.Size = new System.Drawing.Size(200, 20);
            this.dtvVigenteDesde.TabIndex = 6;
            // 
            // chkActivoAbogado
            // 
            this.chkActivoAbogado.AutoSize = true;
            this.chkActivoAbogado.Location = new System.Drawing.Point(184, 134);
            this.chkActivoAbogado.Name = "chkActivoAbogado";
            this.chkActivoAbogado.Size = new System.Drawing.Size(80, 17);
            this.chkActivoAbogado.TabIndex = 7;
            this.chkActivoAbogado.Text = "checkBox1";
            this.chkActivoAbogado.UseVisualStyleBackColor = true;
            // 
            // dgvAbogados
            // 
            this.dgvAbogados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbogados.Location = new System.Drawing.Point(415, 64);
            this.dgvAbogados.Name = "dgvAbogados";
            this.dgvAbogados.Size = new System.Drawing.Size(524, 234);
            this.dgvAbogados.TabIndex = 8;
            // 
            // txtBuscarAbogado
            // 
            this.txtBuscarAbogado.Location = new System.Drawing.Point(531, 37);
            this.txtBuscarAbogado.Name = "txtBuscarAbogado";
            this.txtBuscarAbogado.Size = new System.Drawing.Size(234, 20);
            this.txtBuscarAbogado.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "BUSCAR ABOGADOS";
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.Location = new System.Drawing.Point(807, 344);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(87, 37);
            this.btnEliminarPersona.TabIndex = 24;
            this.btnEliminarPersona.Text = "ELIMINAR";
            this.btnEliminarPersona.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPersona
            // 
            this.btnActualizarPersona.Location = new System.Drawing.Point(667, 344);
            this.btnActualizarPersona.Name = "btnActualizarPersona";
            this.btnActualizarPersona.Size = new System.Drawing.Size(112, 37);
            this.btnActualizarPersona.TabIndex = 23;
            this.btnActualizarPersona.Text = "ACTUALIZAR";
            this.btnActualizarPersona.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Location = new System.Drawing.Point(554, 345);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(86, 36);
            this.btnGuardarPersona.TabIndex = 22;
            this.btnGuardarPersona.Text = "GUARDAR";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            // 
            // btbNuevoAbogado
            // 
            this.btbNuevoAbogado.Location = new System.Drawing.Point(440, 345);
            this.btbNuevoAbogado.Name = "btbNuevoAbogado";
            this.btbNuevoAbogado.Size = new System.Drawing.Size(86, 36);
            this.btbNuevoAbogado.TabIndex = 25;
            this.btbNuevoAbogado.Text = "NUEVO";
            this.btbNuevoAbogado.UseVisualStyleBackColor = true;
            // 
            // txtCedulaAbogado
            // 
            this.txtCedulaAbogado.Location = new System.Drawing.Point(184, 63);
            this.txtCedulaAbogado.Name = "txtCedulaAbogado";
            this.txtCedulaAbogado.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaAbogado.TabIndex = 26;
            // 
            // frmAbogados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.txtCedulaAbogado);
            this.Controls.Add(this.btbNuevoAbogado);
            this.Controls.Add(this.btnEliminarPersona);
            this.Controls.Add(this.btnActualizarPersona);
            this.Controls.Add(this.btnGuardarPersona);
            this.Controls.Add(this.txtBuscarAbogado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAbogados);
            this.Controls.Add(this.chkActivoAbogado);
            this.Controls.Add(this.dtvVigenteDesde);
            this.Controls.Add(this.txtNumLicencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAbogados";
            this.Text = "frmAbogados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbogados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumLicencia;
        private System.Windows.Forms.DateTimePicker dtvVigenteDesde;
        private System.Windows.Forms.CheckBox chkActivoAbogado;
        private System.Windows.Forms.DataGridView dgvAbogados;
        private System.Windows.Forms.TextBox txtBuscarAbogado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.Button btnActualizarPersona;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Button btbNuevoAbogado;
        private System.Windows.Forms.TextBox txtCedulaAbogado;
    }
}