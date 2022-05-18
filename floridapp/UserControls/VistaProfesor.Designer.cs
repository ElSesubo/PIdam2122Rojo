namespace floridapp.UserControls
{
    partial class VistaProfesor
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
            this.dgvTutoria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.C_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_anular = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTutoria
            // 
            this.dgvTutoria.AllowUserToAddRows = false;
            this.dgvTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_nombre,
            this.C_nif,
            this.C_ciclo,
            this.C_dia,
            this.C_hora,
            this.C_anular});
            this.dgvTutoria.Location = new System.Drawing.Point(111, 154);
            this.dgvTutoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTutoria.Name = "dgvTutoria";
            this.dgvTutoria.RowHeadersWidth = 51;
            this.dgvTutoria.RowTemplate.Height = 24;
            this.dgvTutoria.Size = new System.Drawing.Size(1062, 423);
            this.dgvTutoria.TabIndex = 0;
            this.dgvTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutoria_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de tutoria privadas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1413, 288);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1413, 390);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1413, 506);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 24);
            this.comboBox3.TabIndex = 4;
            // 
            // C_nombre
            // 
            this.C_nombre.HeaderText = "Alumno";
            this.C_nombre.MinimumWidth = 6;
            this.C_nombre.Name = "C_nombre";
            this.C_nombre.Width = 125;
            // 
            // C_nif
            // 
            this.C_nif.HeaderText = "NIF";
            this.C_nif.MinimumWidth = 6;
            this.C_nif.Name = "C_nif";
            this.C_nif.Width = 125;
            // 
            // C_ciclo
            // 
            this.C_ciclo.HeaderText = "Ciclo";
            this.C_ciclo.MinimumWidth = 6;
            this.C_ciclo.Name = "C_ciclo";
            this.C_ciclo.Width = 125;
            // 
            // C_dia
            // 
            this.C_dia.HeaderText = "Dia";
            this.C_dia.MinimumWidth = 6;
            this.C_dia.Name = "C_dia";
            this.C_dia.Width = 125;
            // 
            // C_hora
            // 
            this.C_hora.HeaderText = "Hora";
            this.C_hora.MinimumWidth = 6;
            this.C_hora.Name = "C_hora";
            this.C_hora.Width = 125;
            // 
            // C_anular
            // 
            this.C_anular.FillWeight = 50F;
            this.C_anular.HeaderText = "Anular tutoria";
            this.C_anular.MinimumWidth = 6;
            this.C_anular.Name = "C_anular";
            this.C_anular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.C_anular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.C_anular.Text = "ANULAR";
            this.C_anular.Width = 125;
            // 
            // VistaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTutoria);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VistaProfesor";
            this.Size = new System.Drawing.Size(1289, 683);
            this.Load += new System.EventHandler(this.VistaProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTutoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_hora;
        private System.Windows.Forms.DataGridViewButtonColumn C_anular;
    }
}
