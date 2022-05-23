
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accesoBiblioteca));
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtgvReservas = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_portatil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDevuelto = new System.Windows.Forms.Button();
            this.btnInserta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.dtpHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.dtgvPortatiles = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.devuelto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservas)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPortatiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(81, 22);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(96, 23);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Reservas";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
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
            this.dtgvReservas.Location = new System.Drawing.Point(87, 49);
            this.dtgvReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvReservas.Name = "dtgvReservas";
            this.dtgvReservas.ReadOnly = true;
            this.dtgvReservas.RowHeadersWidth = 51;
            this.dtgvReservas.Size = new System.Drawing.Size(897, 242);
            this.dtgvReservas.TabIndex = 24;
            this.dtgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReservas_CellContentClick);
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "id pedido";
            this.id_pedido.MinimumWidth = 6;
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.ReadOnly = true;
            this.id_pedido.Width = 125;
            // 
            // hora_reserva
            // 
            this.hora_reserva.HeaderText = "hora reserva";
            this.hora_reserva.MinimumWidth = 6;
            this.hora_reserva.Name = "hora_reserva";
            this.hora_reserva.ReadOnly = true;
            this.hora_reserva.Width = 125;
            // 
            // id_portatil
            // 
            this.id_portatil.HeaderText = "id portatil";
            this.id_portatil.MinimumWidth = 6;
            this.id_portatil.Name = "id_portatil";
            this.id_portatil.ReadOnly = true;
            this.id_portatil.Width = 125;
            // 
            // id_user
            // 
            this.id_user.HeaderText = "Id user";
            this.id_user.MinimumWidth = 6;
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            this.id_user.Width = 125;
            // 
            // dia_reserva
            // 
            this.dia_reserva.HeaderText = "Dia reserva";
            this.dia_reserva.MinimumWidth = 6;
            this.dia_reserva.Name = "dia_reserva";
            this.dia_reserva.ReadOnly = true;
            this.dia_reserva.Width = 125;
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
            // btnDevuelto
            // 
            this.btnDevuelto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevuelto.Location = new System.Drawing.Point(1576, 299);
            this.btnDevuelto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDevuelto.Name = "btnDevuelto";
            this.btnDevuelto.Size = new System.Drawing.Size(120, 44);
            this.btnDevuelto.TabIndex = 33;
            this.btnDevuelto.Text = "Devuelto";
            this.btnDevuelto.UseVisualStyleBackColor = true;
            this.btnDevuelto.Click += new System.EventHandler(this.btnDevuelto_Click);
            // 
            // btnInserta
            // 
            this.btnInserta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserta.Location = new System.Drawing.Point(1448, 299);
            this.btnInserta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserta.Name = "btnInserta";
            this.btnInserta.Size = new System.Drawing.Size(120, 44);
            this.btnInserta.TabIndex = 34;
            this.btnInserta.Text = "Insertar";
            this.btnInserta.UseVisualStyleBackColor = true;
            this.btnInserta.Click += new System.EventHandler(this.btnInserta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id Portatil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "NIF Usuario:";
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(309, 102);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(252, 32);
            this.txtNIF.TabIndex = 24;
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraReserva.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraReserva.Location = new System.Drawing.Point(309, 143);
            this.dtpHoraReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.Size = new System.Drawing.Size(265, 30);
            this.dtpHoraReserva.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hora de reserva:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(309, 64);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 31);
            this.comboBox1.TabIndex = 30;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.comboBox1);
            this.pnlUsuario.Controls.Add(this.label4);
            this.pnlUsuario.Controls.Add(this.dtpHoraReserva);
            this.pnlUsuario.Controls.Add(this.txtNIF);
            this.pnlUsuario.Controls.Add(this.label5);
            this.pnlUsuario.Controls.Add(this.label3);
            this.pnlUsuario.Location = new System.Drawing.Point(1043, 49);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(653, 242);
            this.pnlUsuario.TabIndex = 27;
            // 
            // dtgvPortatiles
            // 
            this.dtgvPortatiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPortatiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.reservado,
            this.devuelto});
            this.dtgvPortatiles.Location = new System.Drawing.Point(87, 329);
            this.dtgvPortatiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvPortatiles.Name = "dtgvPortatiles";
            this.dtgvPortatiles.ReadOnly = true;
            this.dtgvPortatiles.RowHeadersWidth = 51;
            this.dtgvPortatiles.Size = new System.Drawing.Size(897, 212);
            this.dtgvPortatiles.TabIndex = 35;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // reservado
            // 
            this.reservado.HeaderText = "Reservado";
            this.reservado.MinimumWidth = 6;
            this.reservado.Name = "reservado";
            this.reservado.ReadOnly = true;
            this.reservado.Width = 125;
            // 
            // devuelto
            // 
            this.devuelto.HeaderText = "Devuelto";
            this.devuelto.MinimumWidth = 6;
            this.devuelto.Name = "devuelto";
            this.devuelto.ReadOnly = true;
            this.devuelto.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Portatiles";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1164, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 44);
            this.button1.TabIndex = 37;
            this.button1.Text = "Añadir portatil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // accesoBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1827, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvPortatiles);
            this.Controls.Add(this.btnInserta);
            this.Controls.Add(this.btnDevuelto);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtgvReservas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "accesoBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accesoBiblioteca";
            this.Load += new System.EventHandler(this.accesoBiblioteca_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservas)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPortatiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dtgvReservas;
        private System.Windows.Forms.Button btnDevuelto;
        private System.Windows.Forms.Button btnInserta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_portatil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_reserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.DateTimePicker dtpHoraReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.DataGridView dtgvPortatiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reservado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn devuelto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}