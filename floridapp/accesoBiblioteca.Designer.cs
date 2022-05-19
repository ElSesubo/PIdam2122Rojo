
namespace floridapp
{
    partial class accesoBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accesoBiblioteca));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.dtpReserva = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdPecera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPortatil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtgvReservas = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_portatil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(1045, 408);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(116, 44);
            this.btnMostrar.TabIndex = 32;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1045, 460);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 44);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1360, 393);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 44);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1251, 393);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 44);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.dtpReserva);
            this.pnlUsuario.Controls.Add(this.dtpDevolucion);
            this.pnlUsuario.Controls.Add(this.label6);
            this.pnlUsuario.Controls.Add(this.txtNIF);
            this.pnlUsuario.Controls.Add(this.label5);
            this.pnlUsuario.Controls.Add(this.txtIdPecera);
            this.pnlUsuario.Controls.Add(this.label4);
            this.pnlUsuario.Controls.Add(this.txtIdPortatil);
            this.pnlUsuario.Controls.Add(this.label3);
            this.pnlUsuario.Controls.Add(this.label2);
            this.pnlUsuario.Controls.Add(this.txtId);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Location = new System.Drawing.Point(1059, 78);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(653, 299);
            this.pnlUsuario.TabIndex = 27;
            // 
            // dtpReserva
            // 
            this.dtpReserva.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserva.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReserva.Location = new System.Drawing.Point(313, 75);
            this.dtpReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReserva.Name = "dtpReserva";
            this.dtpReserva.Size = new System.Drawing.Size(265, 30);
            this.dtpReserva.TabIndex = 27;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucion.Location = new System.Drawing.Point(313, 242);
            this.dtpDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(265, 30);
            this.dtpDevolucion.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hora y día de devolución:";
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(313, 198);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.ReadOnly = true;
            this.txtNIF.Size = new System.Drawing.Size(252, 32);
            this.txtNIF.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "NIF Usuario:";
            // 
            // txtIdPecera
            // 
            this.txtIdPecera.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPecera.Location = new System.Drawing.Point(313, 158);
            this.txtIdPecera.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPecera.Name = "txtIdPecera";
            this.txtIdPecera.ReadOnly = true;
            this.txtIdPecera.Size = new System.Drawing.Size(147, 32);
            this.txtIdPecera.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id Pecera:";
            // 
            // txtIdPortatil
            // 
            this.txtIdPortatil.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPortatil.Location = new System.Drawing.Point(313, 117);
            this.txtIdPortatil.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPortatil.Name = "txtIdPortatil";
            this.txtIdPortatil.ReadOnly = true;
            this.txtIdPortatil.Size = new System.Drawing.Size(147, 32);
            this.txtIdPortatil.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id Portatil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hora y día de reserva:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(313, 32);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(147, 32);
            this.txtId.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(97, 48);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(96, 23);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Reservas";
            // 
            // dtgvReservas
            // 
            this.dtgvReservas.AllowUserToAddRows = false;
            this.dtgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.hora_reserva,
            this.id_portatil,
            this.id_user,
            this.dia_reserva});
            this.dtgvReservas.Location = new System.Drawing.Point(103, 78);
            this.dtgvReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvReservas.Name = "dtgvReservas";
            this.dtgvReservas.RowHeadersWidth = 51;
            this.dtgvReservas.Size = new System.Drawing.Size(899, 444);
            this.dtgvReservas.TabIndex = 24;
            this.dtgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReservas_CellContentClick);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(16, 549);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(329, 97);
            this.button5.TabIndex = 25;
            this.button5.Text = "   Salida";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "id pedido";
            this.id_pedido.MinimumWidth = 6;
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.Width = 125;
            // 
            // hora_reserva
            // 
            this.hora_reserva.HeaderText = "hora reserva";
            this.hora_reserva.MinimumWidth = 6;
            this.hora_reserva.Name = "hora_reserva";
            this.hora_reserva.Width = 125;
            // 
            // id_portatil
            // 
            this.id_portatil.HeaderText = "id portatil";
            this.id_portatil.MinimumWidth = 6;
            this.id_portatil.Name = "id_portatil";
            this.id_portatil.Width = 125;
            // 
            // id_user
            // 
            this.id_user.HeaderText = "Id user";
            this.id_user.MinimumWidth = 6;
            this.id_user.Name = "id_user";
            this.id_user.Width = 125;
            // 
            // dia_reserva
            // 
            this.dia_reserva.HeaderText = "Dia reserva";
            this.dia_reserva.MinimumWidth = 6;
            this.dia_reserva.Name = "dia_reserva";
            this.dia_reserva.Width = 125;
            // 
            // accesoBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1827, 650);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtgvReservas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "accesoBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accesoBiblioteca";
            this.Load += new System.EventHandler(this.accesoBiblioteca_Load_1);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dtgvReservas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPortatil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdPecera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpReserva;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_portatil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_reserva;
    }
}