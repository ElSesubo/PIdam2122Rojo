﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPedidos
            // 
            resources.ApplyResources(this.dtgvPedidos, "dtgvPedidos");
            this.dtgvPedidos.AllowUserToAddRows = false;
            this.dtgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_de_mesa,
            this.Ocupado});
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
            resources.ApplyResources(this.dgvPedidoMenu, "dgvPedidoMenu");
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
            resources.ApplyResources(this.button5, "button5");
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::floridapp.Properties.Resources.SALIDA;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // accesoCocina
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ControlBox = false;
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
    }
}