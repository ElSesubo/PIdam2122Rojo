
namespace floridapp.UserControls
{
    partial class listaAlumnos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbCiclo = new System.Windows.Forms.ComboBox();
            this.dtgvAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Seleccionar ciclo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Consulta la información de tus alumnos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(265, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 72);
            this.label1.TabIndex = 52;
            this.label1.Text = "Buscar ciclo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(630, 547);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(229, 30);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbCiclo
            // 
            this.cbCiclo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiclo.FormattingEnabled = true;
            this.cbCiclo.Location = new System.Drawing.Point(630, 298);
            this.cbCiclo.Name = "cbCiclo";
            this.cbCiclo.Size = new System.Drawing.Size(229, 28);
            this.cbCiclo.TabIndex = 50;
            // 
            // dtgvAlumnos
            // 
            this.dtgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlumnos.Location = new System.Drawing.Point(40, 253);
            this.dtgvAlumnos.Name = "dtgvAlumnos";
            this.dtgvAlumnos.RowHeadersWidth = 51;
            this.dtgvAlumnos.Size = new System.Drawing.Size(531, 324);
            this.dtgvAlumnos.TabIndex = 49;
            // 
            // listaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbCiclo);
            this.Controls.Add(this.dtgvAlumnos);
            this.Name = "listaAlumnos";
            this.Size = new System.Drawing.Size(1108, 581);
            this.Load += new System.EventHandler(this.listaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbCiclo;
        private System.Windows.Forms.DataGridView dtgvAlumnos;
    }
}
