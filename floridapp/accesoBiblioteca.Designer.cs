
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtgvReservas = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDevuelto = new System.Windows.Forms.Button();
            this.btnInserta = new System.Windows.Forms.Button();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_portatil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.dtpHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservas)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(73, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 19);
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
            this.dtgvReservas.Location = new System.Drawing.Point(77, 63);
            this.dtgvReservas.Name = "dtgvReservas";
            this.dtgvReservas.RowHeadersWidth = 51;
            this.dtgvReservas.Size = new System.Drawing.Size(674, 361);
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
            this.button5.Location = new System.Drawing.Point(12, 446);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(247, 79);
            this.button5.TabIndex = 25;
            this.button5.Text = "   Salida";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDevuelto
            // 
            this.btnDevuelto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevuelto.Location = new System.Drawing.Point(1194, 288);
            this.btnDevuelto.Name = "btnDevuelto";
            this.btnDevuelto.Size = new System.Drawing.Size(90, 36);
            this.btnDevuelto.TabIndex = 33;
            this.btnDevuelto.Text = "Devuelto";
            this.btnDevuelto.UseVisualStyleBackColor = true;
            this.btnDevuelto.Click += new System.EventHandler(this.btnDevuelto_Click);
            // 
            // btnInserta
            // 
            this.btnInserta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserta.Location = new System.Drawing.Point(1098, 288);
            this.btnInserta.Name = "btnInserta";
            this.btnInserta.Size = new System.Drawing.Size(90, 36);
            this.btnInserta.TabIndex = 34;
            this.btnInserta.Text = "Insertar";
            this.btnInserta.UseVisualStyleBackColor = true;
            this.btnInserta.Click += new System.EventHandler(this.btnInserta_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id Portatil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "NIF Usuario:";
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(232, 83);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(190, 27);
            this.txtNIF.TabIndex = 24;
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.CalendarFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraReserva.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraReserva.Location = new System.Drawing.Point(232, 116);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.Size = new System.Drawing.Size(200, 26);
            this.dtpHoraReserva.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hora de reserva:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
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
            this.pnlUsuario.Location = new System.Drawing.Point(794, 85);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(490, 197);
            this.pnlUsuario.TabIndex = 27;
            // 
            // accesoBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1370, 528);
            this.Controls.Add(this.btnInserta);
            this.Controls.Add(this.btnDevuelto);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtgvReservas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "accesoBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accesoBiblioteca";
            this.Load += new System.EventHandler(this.accesoBiblioteca_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservas)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
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
    }
}