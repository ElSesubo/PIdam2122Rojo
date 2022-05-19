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
<<<<<<< HEAD
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
=======
            this.C_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_anular = new System.Windows.Forms.DataGridViewButtonColumn();
>>>>>>> 9a0ae76523b3a0712d38bf88277cda2359c77682
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiaOcupado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCalendario = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutoria)).BeginInit();
            this.gbCalendario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTutoria
            // 
            this.dgvTutoria.AllowUserToAddRows = false;
            this.dgvTutoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
<<<<<<< HEAD
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvTutoria.Location = new System.Drawing.Point(111, 154);
=======
            this.C_nombre,
            this.C_nif,
            this.C_ciclo,
            this.C_dia,
            this.C_hora,
            this.C_anular});
            this.dgvTutoria.Location = new System.Drawing.Point(110, 147);
>>>>>>> 9a0ae76523b3a0712d38bf88277cda2359c77682
            this.dgvTutoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTutoria.Name = "dgvTutoria";
            this.dgvTutoria.RowHeadersWidth = 51;
            this.dgvTutoria.RowTemplate.Height = 24;
<<<<<<< HEAD
            this.dgvTutoria.Size = new System.Drawing.Size(1072, 423);
            this.dgvTutoria.TabIndex = 0;
            this.dgvTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutoria_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Alumno";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ciclo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dia";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Aceptado";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "Anular";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de tutoria privadas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1413, 288);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1413, 390);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1413, 506);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 24);
            this.comboBox3.TabIndex = 4;
            // 
=======
            this.dgvTutoria.Size = new System.Drawing.Size(1062, 423);
            this.dgvTutoria.TabIndex = 0;
            this.dgvTutoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutoria_CellContentClick);
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
            // btnDiaOcupado
            // 
            this.btnDiaOcupado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiaOcupado.Location = new System.Drawing.Point(110, 605);
            this.btnDiaOcupado.Name = "btnDiaOcupado";
            this.btnDiaOcupado.Size = new System.Drawing.Size(206, 60);
            this.btnDiaOcupado.TabIndex = 5;
            this.btnDiaOcupado.Text = "Dia ocupado";
            this.btnDiaOcupado.UseVisualStyleBackColor = true;
            this.btnDiaOcupado.Click += new System.EventHandler(this.btnDiaOcupado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecione el dia que no vas a \r\ndejar reservar.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbCalendario
            // 
            this.gbCalendario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCalendario.Controls.Add(this.dtpFecha);
            this.gbCalendario.Controls.Add(this.btnConfirmar);
            this.gbCalendario.Controls.Add(this.label3);
            this.gbCalendario.Location = new System.Drawing.Point(395, 147);
            this.gbCalendario.Name = "gbCalendario";
            this.gbCalendario.Size = new System.Drawing.Size(461, 423);
            this.gbCalendario.TabIndex = 7;
            this.gbCalendario.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(27, 218);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(179, 37);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(27, 136);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(319, 36);
            this.dtpFecha.TabIndex = 9;
            // 
>>>>>>> 9a0ae76523b3a0712d38bf88277cda2359c77682
            // VistaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCalendario);
            this.Controls.Add(this.btnDiaOcupado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTutoria);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 9a0ae76523b3a0712d38bf88277cda2359c77682
            this.Name = "VistaProfesor";
            this.Size = new System.Drawing.Size(1289, 683);
            this.Load += new System.EventHandler(this.VistaProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutoria)).EndInit();
            this.gbCalendario.ResumeLayout(false);
            this.gbCalendario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTutoria;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
=======
<<<<<<< HEAD

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
=======
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
>>>>>>> 9233e1f7bf5539a13378398fef1ec9e805b12992
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_hora;
        private System.Windows.Forms.DataGridViewButtonColumn C_anular;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnDiaOcupado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCalendario;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
=======
>>>>>>> 9a0ae76523b3a0712d38bf88277cda2359c77682
>>>>>>> 9233e1f7bf5539a13378398fef1ec9e805b12992
    }
}
