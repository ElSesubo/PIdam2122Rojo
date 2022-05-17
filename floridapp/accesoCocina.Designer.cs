
namespace floridapp
{
    partial class accesoCocina
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
            this.dtgvPedidos = new System.Windows.Forms.DataGridView();
            this.Numero_de_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvPedidoMenu = new System.Windows.Forms.DataGridView();
            this.id_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llevar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recogido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPedidoMenu = new System.Windows.Forms.Label();
            this.btnPreparado = new System.Windows.Forms.Button();
            this.btnEliminarMenu = new System.Windows.Forms.Button();
            this.btnBuscarMenu = new System.Windows.Forms.Button();
            this.lblNifMenu = new System.Windows.Forms.Label();
            this.txtBuscarMenu = new System.Windows.Forms.TextBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPedidos
            // 
            this.dtgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_mesa,
            this.Ocupado});
            this.dtgvPedidos.Location = new System.Drawing.Point(111, 78);
            this.dtgvPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPedidos.Name = "dtgvPedidos";
            this.dtgvPedidos.RowHeadersWidth = 51;
            this.dtgvPedidos.Size = new System.Drawing.Size(930, 183);
            this.dtgvPedidos.TabIndex = 15;
            this.dtgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPedidos_CellContentClick);
            // 
            // Numero_de_mesa
            // 
            this.Numero_de_mesa.HeaderText = "Numero de mesa";
            this.Numero_de_mesa.MinimumWidth = 6;
            this.Numero_de_mesa.Name = "Numero_de_mesa";
            this.Numero_de_mesa.Width = 125;
            // 
            // Ocupado
            // 
            this.Ocupado.HeaderText = "Ocupado";
            this.Ocupado.MinimumWidth = 6;
            this.Ocupado.Name = "Ocupado";
            this.Ocupado.Width = 125;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(105, 48);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(146, 23);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Pedidos Mesa";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(1604, 361);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(116, 44);
            this.btnMostrar.TabIndex = 23;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1476, 361);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 44);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1368, 361);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 44);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1259, 361);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 44);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(1143, 361);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(108, 44);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.checkBox3);
            this.pnlUsuario.Controls.Add(this.dateTimePicker1);
            this.pnlUsuario.Controls.Add(this.label5);
            this.pnlUsuario.Controls.Add(this.textBox2);
            this.pnlUsuario.Controls.Add(this.label2);
            this.pnlUsuario.Controls.Add(this.textBox1);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Controls.Add(this.checkBox1);
            this.pnlUsuario.Controls.Add(this.txtNombre);
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.pnlUsuario.Location = new System.Drawing.Point(1067, 78);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(653, 276);
            this.pnlUsuario.TabIndex = 18;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(192, 233);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(126, 27);
            this.checkBox3.TabIndex = 31;
            this.checkBox3.Text = "Recogido";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 192);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 32);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Hora Reserva:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(192, 151);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 32);
            this.textBox2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mesa:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(192, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(147, 32);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(192, 113);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 27);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Para llevar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(192, 73);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 32);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(131, 75);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NIF:";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::floridapp.Properties.Resources.SALIDA;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(28, 542);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(329, 97);
            this.button5.TabIndex = 16;
            this.button5.Text = "   Salida";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvPedidoMenu
            // 
            this.dgvPedidoMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_menu,
            this.llevar,
            this.nif,
            this.hora,
            this.recogido,
            this.preparado,
            this.menu});
            this.dgvPedidoMenu.Location = new System.Drawing.Point(111, 320);
            this.dgvPedidoMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidoMenu.Name = "dgvPedidoMenu";
            this.dgvPedidoMenu.RowHeadersWidth = 51;
            this.dgvPedidoMenu.Size = new System.Drawing.Size(930, 183);
            this.dgvPedidoMenu.TabIndex = 24;
            this.dgvPedidoMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidoMenu_CellContentClick);
            // 
            // id_menu
            // 
            this.id_menu.HeaderText = "ID menu";
            this.id_menu.MinimumWidth = 6;
            this.id_menu.Name = "id_menu";
            this.id_menu.Width = 125;
            // 
            // llevar
            // 
            this.llevar.HeaderText = "Llevar";
            this.llevar.MinimumWidth = 6;
            this.llevar.Name = "llevar";
            this.llevar.Width = 125;
            // 
            // nif
            // 
            this.nif.HeaderText = "Nif";
            this.nif.MinimumWidth = 6;
            this.nif.Name = "nif";
            this.nif.Width = 125;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.MinimumWidth = 6;
            this.hora.Name = "hora";
            this.hora.Width = 125;
            // 
            // recogido
            // 
            this.recogido.HeaderText = "Recogido";
            this.recogido.MinimumWidth = 6;
            this.recogido.Name = "recogido";
            this.recogido.Width = 125;
            // 
            // preparado
            // 
            this.preparado.HeaderText = "Preparado";
            this.preparado.MinimumWidth = 6;
            this.preparado.Name = "preparado";
            this.preparado.Width = 125;
            // 
            // menu
            // 
            this.menu.HeaderText = "Menu";
            this.menu.MinimumWidth = 6;
            this.menu.Name = "menu";
            this.menu.Width = 125;
            // 
            // lblPedidoMenu
            // 
            this.lblPedidoMenu.AutoSize = true;
            this.lblPedidoMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoMenu.Location = new System.Drawing.Point(107, 293);
            this.lblPedidoMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedidoMenu.Name = "lblPedidoMenu";
            this.lblPedidoMenu.Size = new System.Drawing.Size(148, 23);
            this.lblPedidoMenu.TabIndex = 25;
            this.lblPedidoMenu.Text = "Pedidos Menu";
            // 
            // btnPreparado
            // 
            this.btnPreparado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreparado.Location = new System.Drawing.Point(1132, 425);
            this.btnPreparado.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreparado.Name = "btnPreparado";
            this.btnPreparado.Size = new System.Drawing.Size(142, 44);
            this.btnPreparado.TabIndex = 26;
            this.btnPreparado.Text = "Preparado";
            this.btnPreparado.UseVisualStyleBackColor = true;
            this.btnPreparado.Click += new System.EventHandler(this.btnPreparado_Click);
            // 
            // btnEliminarMenu
            // 
            this.btnEliminarMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMenu.Location = new System.Drawing.Point(1286, 425);
            this.btnEliminarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMenu.Name = "btnEliminarMenu";
            this.btnEliminarMenu.Size = new System.Drawing.Size(144, 44);
            this.btnEliminarMenu.TabIndex = 27;
            this.btnEliminarMenu.Text = "Recogido";
            this.btnEliminarMenu.UseVisualStyleBackColor = true;
            this.btnEliminarMenu.Click += new System.EventHandler(this.btnEliminarMenu_Click);
            // 
            // btnBuscarMenu
            // 
            this.btnBuscarMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMenu.Location = new System.Drawing.Point(1299, 485);
            this.btnBuscarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarMenu.Name = "btnBuscarMenu";
            this.btnBuscarMenu.Size = new System.Drawing.Size(100, 44);
            this.btnBuscarMenu.TabIndex = 29;
            this.btnBuscarMenu.Text = "Buscar";
            this.btnBuscarMenu.UseVisualStyleBackColor = true;
            this.btnBuscarMenu.Click += new System.EventHandler(this.btnBuscarMenu_Click);
            // 
            // lblNifMenu
            // 
            this.lblNifMenu.AutoSize = true;
            this.lblNifMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNifMenu.Location = new System.Drawing.Point(1079, 496);
            this.lblNifMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNifMenu.Name = "lblNifMenu";
            this.lblNifMenu.Size = new System.Drawing.Size(45, 23);
            this.lblNifMenu.TabIndex = 30;
            this.lblNifMenu.Text = "NIF:";
            // 
            // txtBuscarMenu
            // 
            this.txtBuscarMenu.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMenu.Location = new System.Drawing.Point(1132, 493);
            this.txtBuscarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarMenu.Name = "txtBuscarMenu";
            this.txtBuscarMenu.Size = new System.Drawing.Size(159, 32);
            this.txtBuscarMenu.TabIndex = 31;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(1417, 485);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(179, 44);
            this.btnRestaurar.TabIndex = 32;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // accesoCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1827, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.txtBuscarMenu);
            this.Controls.Add(this.lblNifMenu);
            this.Controls.Add(this.btnBuscarMenu);
            this.Controls.Add(this.btnEliminarMenu);
            this.Controls.Add(this.btnPreparado);
            this.Controls.Add(this.lblPedidoMenu);
            this.Controls.Add(this.dgvPedidoMenu);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "accesoCocina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accesoCocina";
            this.Load += new System.EventHandler(this.accesoCocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dtgvPedidos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_de_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocupado;
        private System.Windows.Forms.DataGridView dgvPedidoMenu;
        private System.Windows.Forms.Label lblPedidoMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn llevar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn recogido;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparado;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.Button btnPreparado;
        private System.Windows.Forms.Button btnEliminarMenu;
        private System.Windows.Forms.Button btnBuscarMenu;
        private System.Windows.Forms.Label lblNifMenu;
        private System.Windows.Forms.TextBox txtBuscarMenu;
        private System.Windows.Forms.Button btnRestaurar;
    }
}