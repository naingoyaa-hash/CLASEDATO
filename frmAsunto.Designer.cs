namespace CLASEDATO
{
    partial class frmAsunto
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
            this.txtNExpediente = new System.Windows.Forms.TextBox();
            this.txtCedulaAsunto = new System.Windows.Forms.TextBox();
            this.dtpInicioAsunto = new System.Windows.Forms.DateTimePicker();
            this.txtResumenAsunto = new System.Windows.Forms.TextBox();
            this.dgvAsunto = new System.Windows.Forms.DataGridView();
            this.txtBuscarAsunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btbNuevoNexpediente = new System.Windows.Forms.Button();
            this.btnEliminarNexpediente = new System.Windows.Forms.Button();
            this.btnActualizarNexpediente = new System.Windows.Forms.Button();
            this.btnGuardarNexpediente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsunto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEXPEDIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(36, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "INICIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(36, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RESUMEN";
            // 
            // txtNExpediente
            // 
            this.txtNExpediente.Location = new System.Drawing.Point(148, 36);
            this.txtNExpediente.Name = "txtNExpediente";
            this.txtNExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtNExpediente.TabIndex = 4;
            // 
            // txtCedulaAsunto
            // 
            this.txtCedulaAsunto.Location = new System.Drawing.Point(148, 74);
            this.txtCedulaAsunto.Name = "txtCedulaAsunto";
            this.txtCedulaAsunto.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaAsunto.TabIndex = 5;
            // 
            // dtpInicioAsunto
            // 
            this.dtpInicioAsunto.Location = new System.Drawing.Point(148, 119);
            this.dtpInicioAsunto.Name = "dtpInicioAsunto";
            this.dtpInicioAsunto.Size = new System.Drawing.Size(200, 20);
            this.dtpInicioAsunto.TabIndex = 6;
            // 
            // txtResumenAsunto
            // 
            this.txtResumenAsunto.Location = new System.Drawing.Point(148, 159);
            this.txtResumenAsunto.Multiline = true;
            this.txtResumenAsunto.Name = "txtResumenAsunto";
            this.txtResumenAsunto.Size = new System.Drawing.Size(200, 98);
            this.txtResumenAsunto.TabIndex = 7;
            // 
            // dgvAsunto
            // 
            this.dgvAsunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsunto.Location = new System.Drawing.Point(379, 100);
            this.dgvAsunto.Name = "dgvAsunto";
            this.dgvAsunto.Size = new System.Drawing.Size(559, 229);
            this.dgvAsunto.TabIndex = 8;
            // 
            // txtBuscarAsunto
            // 
            this.txtBuscarAsunto.Location = new System.Drawing.Point(504, 74);
            this.txtBuscarAsunto.Name = "txtBuscarAsunto";
            this.txtBuscarAsunto.Size = new System.Drawing.Size(234, 20);
            this.txtBuscarAsunto.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(376, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "BUSCAR EXPEDIENTE";
            // 
            // btbNuevoNexpediente
            // 
            this.btbNuevoNexpediente.Location = new System.Drawing.Point(420, 361);
            this.btbNuevoNexpediente.Name = "btbNuevoNexpediente";
            this.btbNuevoNexpediente.Size = new System.Drawing.Size(86, 36);
            this.btbNuevoNexpediente.TabIndex = 29;
            this.btbNuevoNexpediente.Text = "NUEVO";
            this.btbNuevoNexpediente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarNexpediente
            // 
            this.btnEliminarNexpediente.Location = new System.Drawing.Point(787, 360);
            this.btnEliminarNexpediente.Name = "btnEliminarNexpediente";
            this.btnEliminarNexpediente.Size = new System.Drawing.Size(87, 37);
            this.btnEliminarNexpediente.TabIndex = 28;
            this.btnEliminarNexpediente.Text = "ELIMINAR";
            this.btnEliminarNexpediente.UseVisualStyleBackColor = true;
            // 
            // btnActualizarNexpediente
            // 
            this.btnActualizarNexpediente.Location = new System.Drawing.Point(647, 360);
            this.btnActualizarNexpediente.Name = "btnActualizarNexpediente";
            this.btnActualizarNexpediente.Size = new System.Drawing.Size(112, 37);
            this.btnActualizarNexpediente.TabIndex = 27;
            this.btnActualizarNexpediente.Text = "ACTUALIZAR";
            this.btnActualizarNexpediente.UseVisualStyleBackColor = true;
            // 
            // btnGuardarNexpediente
            // 
            this.btnGuardarNexpediente.Location = new System.Drawing.Point(534, 361);
            this.btnGuardarNexpediente.Name = "btnGuardarNexpediente";
            this.btnGuardarNexpediente.Size = new System.Drawing.Size(86, 36);
            this.btnGuardarNexpediente.TabIndex = 26;
            this.btnGuardarNexpediente.Text = "GUARDAR";
            this.btnGuardarNexpediente.UseVisualStyleBackColor = true;
            // 
            // frmAsunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.btbNuevoNexpediente);
            this.Controls.Add(this.btnEliminarNexpediente);
            this.Controls.Add(this.btnActualizarNexpediente);
            this.Controls.Add(this.btnGuardarNexpediente);
            this.Controls.Add(this.txtBuscarAsunto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAsunto);
            this.Controls.Add(this.txtResumenAsunto);
            this.Controls.Add(this.dtpInicioAsunto);
            this.Controls.Add(this.txtCedulaAsunto);
            this.Controls.Add(this.txtNExpediente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAsunto";
            this.Text = "frmAsunto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNExpediente;
        private System.Windows.Forms.TextBox txtCedulaAsunto;
        private System.Windows.Forms.DateTimePicker dtpInicioAsunto;
        private System.Windows.Forms.TextBox txtResumenAsunto;
        private System.Windows.Forms.DataGridView dgvAsunto;
        private System.Windows.Forms.TextBox txtBuscarAsunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btbNuevoNexpediente;
        private System.Windows.Forms.Button btnEliminarNexpediente;
        private System.Windows.Forms.Button btnActualizarNexpediente;
        private System.Windows.Forms.Button btnGuardarNexpediente;
    }
}