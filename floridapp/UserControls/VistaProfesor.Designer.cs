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
            this.C_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_anular = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.C_nombre,
            this.C_nif,
            this.C_ciclo,
            this.C_dia,
            this.C_hora,
            this.C_anular});
            this.dgvTutoria.Location = new System.Drawing.Point(110, 147);
            this.dgvTutoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTutoria.Name = "dgvTutoria";
            this.dgvTutoria.RowHeadersWidth = 51;
            this.dgvTutoria.RowTemplate.Height = 24;
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
            // VistaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCalendario);
            this.Controls.Add(this.btnDiaOcupado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTutoria);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_hora;
        private System.Windows.Forms.DataGridViewButtonColumn C_anular;
        private System.Windows.Forms.Button btnDiaOcupado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCalendario;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}
