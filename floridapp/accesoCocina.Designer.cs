
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accesoCocina));
            this.dtgvPedidos = new System.Windows.Forms.DataGridView();
            this.Numero_de_mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocupado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntSalir = new System.Windows.Forms.Button();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntEditarMenu = new System.Windows.Forms.Button();
            this.btnEditarMesas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregarmesa = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMenu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvPedidos
            // 
            this.dtgvPedidos.AllowUserToAddRows = false;
            this.dtgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_mesa,
            this.Ocupado});
            resources.ApplyResources(this.dtgvPedidos, "dtgvPedidos");
            this.dtgvPedidos.Name = "dtgvPedidos";
            this.dtgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPedidos_CellContentClick);
            // 
            // Numero_de_mesa
            // 
            resources.ApplyResources(this.Numero_de_mesa, "Numero_de_mesa");
            this.Numero_de_mesa.Name = "Numero_de_mesa";
            // 
            // Ocupado
            // 
            resources.ApplyResources(this.Ocupado, "Ocupado");
            this.Ocupado.Name = "Ocupado";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // btnEliminar
            // 
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvPedidoMenu
            // 
            this.dgvPedidoMenu.AllowUserToAddRows = false;
            this.dgvPedidoMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_menu,
            this.llevar,
            this.nif,
            this.hora,
            this.recogido,
            this.preparado,
            this.menu});
            resources.ApplyResources(this.dgvPedidoMenu, "dgvPedidoMenu");
            this.dgvPedidoMenu.Name = "dgvPedidoMenu";
            this.dgvPedidoMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidoMenu_CellContentClick);
            // 
            // id_menu
            // 
            resources.ApplyResources(this.id_menu, "id_menu");
            this.id_menu.Name = "id_menu";
            // 
            // llevar
            // 
            resources.ApplyResources(this.llevar, "llevar");
            this.llevar.Name = "llevar";
            // 
            // nif
            // 
            resources.ApplyResources(this.nif, "nif");
            this.nif.Name = "nif";
            // 
            // hora
            // 
            resources.ApplyResources(this.hora, "hora");
            this.hora.Name = "hora";
            // 
            // recogido
            // 
            resources.ApplyResources(this.recogido, "recogido");
            this.recogido.Name = "recogido";
            // 
            // preparado
            // 
            resources.ApplyResources(this.preparado, "preparado");
            this.preparado.Name = "preparado";
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // lblPedidoMenu
            // 
            resources.ApplyResources(this.lblPedidoMenu, "lblPedidoMenu");
            this.lblPedidoMenu.Name = "lblPedidoMenu";
            // 
            // btnPreparado
            // 
            resources.ApplyResources(this.btnPreparado, "btnPreparado");
            this.btnPreparado.Name = "btnPreparado";
            this.btnPreparado.UseVisualStyleBackColor = true;
            this.btnPreparado.Click += new System.EventHandler(this.btnPreparado_Click);
            // 
            // btnEliminarMenu
            // 
            resources.ApplyResources(this.btnEliminarMenu, "btnEliminarMenu");
            this.btnEliminarMenu.Name = "btnEliminarMenu";
            this.btnEliminarMenu.UseVisualStyleBackColor = true;
            this.btnEliminarMenu.Click += new System.EventHandler(this.btnEliminarMenu_Click);
            // 
            // btnBuscarMenu
            // 
            resources.ApplyResources(this.btnBuscarMenu, "btnBuscarMenu");
            this.btnBuscarMenu.Name = "btnBuscarMenu";
            this.btnBuscarMenu.UseVisualStyleBackColor = true;
            this.btnBuscarMenu.Click += new System.EventHandler(this.btnBuscarMenu_Click);
            // 
            // lblNifMenu
            // 
            resources.ApplyResources(this.lblNifMenu, "lblNifMenu");
            this.lblNifMenu.Name = "lblNifMenu";
            // 
            // txtBuscarMenu
            // 
            resources.ApplyResources(this.txtBuscarMenu, "txtBuscarMenu");
            this.txtBuscarMenu.Name = "txtBuscarMenu";
            // 
            // btnRestaurar
            // 
            resources.ApplyResources(this.btnRestaurar, "btnRestaurar");
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::floridapp.Properties.Resources.SALIDA;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.bntSalir);
            this.groupBox1.Controls.Add(this.nudPrecio);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMenu);
            this.groupBox1.Controls.Add(this.dgvMenu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // bntSalir
            // 
            resources.ApplyResources(this.bntSalir, "bntSalir");
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.UseVisualStyleBackColor = true;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            resources.ApplyResources(this.nudPrecio, "nudPrecio");
            this.nudPrecio.Name = "nudPrecio";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMenu
            // 
            resources.ApplyResources(this.txtMenu, "txtMenu");
            this.txtMenu.Name = "txtMenu";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            resources.ApplyResources(this.dgvMenu, "dgvMenu");
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bntEditarMenu
            // 
            resources.ApplyResources(this.bntEditarMenu, "bntEditarMenu");
            this.bntEditarMenu.Name = "bntEditarMenu";
            this.bntEditarMenu.UseVisualStyleBackColor = true;
            this.bntEditarMenu.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEditarMesas
            // 
            resources.ApplyResources(this.btnEditarMesas, "btnEditarMesas");
            this.btnEditarMesas.Name = "btnEditarMesas";
            this.btnEditarMesas.UseVisualStyleBackColor = true;
            this.btnEditarMesas.Click += new System.EventHandler(this.btnEditarMesas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.lblnum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btnagregarmesa);
            this.groupBox2.Controls.Add(this.label4);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnagregarmesa
            // 
            resources.ApplyResources(this.btnagregarmesa, "btnagregarmesa");
            this.btnagregarmesa.Name = "btnagregarmesa";
            this.btnagregarmesa.UseVisualStyleBackColor = true;
            this.btnagregarmesa.Click += new System.EventHandler(this.btnagregarmesa_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblnum
            // 
            resources.ApplyResources(this.lblnum, "lblnum");
            this.lblnum.Name = "lblnum";
            this.lblnum.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // accesoCocina
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEditarMesas);
            this.Controls.Add(this.bntEditarMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.txtBuscarMenu);
            this.Controls.Add(this.lblNifMenu);
            this.Controls.Add(this.btnBuscarMenu);
            this.Controls.Add(this.btnEliminarMenu);
            this.Controls.Add(this.btnPreparado);
            this.Controls.Add(this.lblPedidoMenu);
            this.Controls.Add(this.dgvPedidoMenu);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtgvPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "accesoCocina";
            this.Load += new System.EventHandler(this.accesoCocina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMenu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dtgvPedidos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEliminar;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Button bntEditarMenu;
        private System.Windows.Forms.Button bntSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnEditarMesas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnagregarmesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
    }
}