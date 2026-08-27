namespace CLASEDATO
{
    partial class Form1
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(698, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "SALIR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CLASEDATO.Properties.Resources.asustos_32;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Location = new System.Drawing.Point(496, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 42);
            this.button3.TabIndex = 6;
            this.button3.Text = "ASUNTOS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CLASEDATO.Properties.Resources.abogado_32;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(311, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "ABOGADOS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CLASEDATO.Properties.Resources.personas_32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(118, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "PERSONAS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLASEDATO.Properties.Resources.ChatGPT_Image_26_ago_2026__09_44_15_p_m_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

