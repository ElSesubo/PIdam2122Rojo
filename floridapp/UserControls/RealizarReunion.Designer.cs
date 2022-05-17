
namespace floridapp.UserControls
{
    partial class RealizarReunion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCiclo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));

            this.label1.Location = new System.Drawing.Point(204, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.label1.Location = new System.Drawing.Point(125, 185);

            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(987, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona tu módulo";
            // 
            // cmbCiclo
            // 

            this.cmbCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCiclo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiclo.FormattingEnabled = true;
            this.cmbCiclo.Location = new System.Drawing.Point(457, 421);
            this.cmbCiclo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCiclo.Name = "cmbCiclo";
            this.cmbCiclo.Size = new System.Drawing.Size(511, 31);
            this.cmbCiclo.TabIndex = 2;
            this.cmbCiclo.Text = "SELECIONE UNA OPCIÓN";
            this.cmbCiclo.SelectedIndexChanged += new System.EventHandler(this.cmbCiclo_SelectedIndexChanged);


            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label2.Location = new System.Drawing.Point(448, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.label2.Location = new System.Drawing.Point(308, 250);

            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para acceder a la disponibilidad de los docentes\r\n";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.btnContinuar.Location = new System.Drawing.Point(453, 560);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);

            this.btnContinuar.Location = new System.Drawing.Point(295, 456);

            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(520, 50);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // RealizarReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCiclo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RealizarReunion";
            this.Size = new System.Drawing.Size(1477, 990);
            this.Load += new System.EventHandler(this.RealizarReunion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCiclo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContinuar;
    }
}
