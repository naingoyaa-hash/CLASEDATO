namespace CLASEDATO
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAsuntos = new System.Windows.Forms.Button();
            this.btnAbogados = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(931, 512);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 38);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAsuntos
            // 
            this.btnAsuntos.BackgroundImage = global::CLASEDATO.Properties.Resources.asustos_32;
            this.btnAsuntos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAsuntos.Location = new System.Drawing.Point(661, 361);
            this.btnAsuntos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsuntos.Name = "btnAsuntos";
            this.btnAsuntos.Size = new System.Drawing.Size(213, 52);
            this.btnAsuntos.TabIndex = 6;
            this.btnAsuntos.Text = "ASUNTOS";
            this.btnAsuntos.UseVisualStyleBackColor = true;
            // 
            // btnAbogados
            // 
            this.btnAbogados.BackgroundImage = global::CLASEDATO.Properties.Resources.abogado_32;
            this.btnAbogados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAbogados.Location = new System.Drawing.Point(415, 361);
            this.btnAbogados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbogados.Name = "btnAbogados";
            this.btnAbogados.Size = new System.Drawing.Size(216, 52);
            this.btnAbogados.TabIndex = 5;
            this.btnAbogados.Text = "ABOGADOS";
            this.btnAbogados.UseVisualStyleBackColor = true;
            // 
            // btnPersonas
            // 
            this.btnPersonas.BackgroundImage = global::CLASEDATO.Properties.Resources.personas_32;
            this.btnPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonas.Location = new System.Drawing.Point(157, 361);
            this.btnPersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(219, 52);
            this.btnPersonas.TabIndex = 4;
            this.btnPersonas.Text = "PERSONAS";
            this.btnPersonas.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLASEDATO.Properties.Resources.ChatGPT_Image_26_ago_2026__09_44_15_p_m_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsuntos);
            this.Controls.Add(this.btnAbogados);
            this.Controls.Add(this.btnPersonas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAsuntos;
        private System.Windows.Forms.Button btnAbogados;
        private System.Windows.Forms.Button btnPersonas;
    }
}

