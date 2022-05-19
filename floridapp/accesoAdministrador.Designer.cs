namespace floridapp
{
    partial class accesoAdministrador
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
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.cbAlumno = new System.Windows.Forms.CheckBox();
            this.cbBiblioteca = new System.Windows.Forms.CheckBox();
            this.cbCocina = new System.Windows.Forms.CheckBox();
            this.cbAdministrador = new System.Windows.Forms.CheckBox();
            this.cbProfesor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(112, 76);
            this.dtgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 51;
            this.dtgvUsuarios.Size = new System.Drawing.Size(904, 446);
            this.dtgvUsuarios.TabIndex = 0;
            this.dtgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellContentClick);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::floridapp.Properties.Resources.SALIDA;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(29, 540);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(329, 97);
            this.button5.TabIndex = 14;
            this.button5.Text = "   Salida";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Usuarios";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(1600, 565);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(116, 44);
            this.btnMostrar.TabIndex = 28;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1472, 565);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 44);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1364, 565);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 44);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1255, 565);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 44);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(1139, 565);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(108, 44);
            this.btnInsertar.TabIndex = 24;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(116, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NIF:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(76, 70);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(82, 23);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Correo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(23, 111);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Contraseña:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(53, 197);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(105, 23);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Apellidos:";
            // 
            // txtNif
            // 
            this.txtNif.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(177, 25);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(239, 32);
            this.txtNif.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(177, 68);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(437, 32);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(177, 111);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(437, 32);
            this.txtContra.TabIndex = 8;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(63, 154);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(95, 23);
            this.lblFechaNac.TabIndex = 10;
            this.lblFechaNac.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(177, 156);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(437, 32);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(177, 197);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(437, 32);
            this.txtApellido.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefono:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(177, 238);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(437, 32);
            this.txtTel.TabIndex = 14;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.cbAlumno);
            this.pnlUsuario.Controls.Add(this.cbBiblioteca);
            this.pnlUsuario.Controls.Add(this.cbCocina);
            this.pnlUsuario.Controls.Add(this.cbAdministrador);
            this.pnlUsuario.Controls.Add(this.cbProfesor);
            this.pnlUsuario.Controls.Add(this.txtTel);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Controls.Add(this.txtApellido);
            this.pnlUsuario.Controls.Add(this.txtNombre);
            this.pnlUsuario.Controls.Add(this.lblFechaNac);
            this.pnlUsuario.Controls.Add(this.txtContra);
            this.pnlUsuario.Controls.Add(this.txtCorreo);
            this.pnlUsuario.Controls.Add(this.txtNif);
            this.pnlUsuario.Controls.Add(this.lblEdad);
            this.pnlUsuario.Controls.Add(this.lblEmail);
            this.pnlUsuario.Controls.Add(this.lblApellidos);
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.pnlUsuario.Location = new System.Drawing.Point(1059, 76);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(653, 481);
            this.pnlUsuario.TabIndex = 8;
            // 
            // cbAlumno
            // 
            this.cbAlumno.AutoSize = true;
            this.cbAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlumno.Location = new System.Drawing.Point(177, 434);
            this.cbAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAlumno.Name = "cbAlumno";
            this.cbAlumno.Size = new System.Drawing.Size(108, 27);
            this.cbAlumno.TabIndex = 19;
            this.cbAlumno.Text = "Alumno";
            this.cbAlumno.UseVisualStyleBackColor = true;
            // 
            // cbBiblioteca
            // 
            this.cbBiblioteca.AutoSize = true;
            this.cbBiblioteca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBiblioteca.Location = new System.Drawing.Point(177, 396);
            this.cbBiblioteca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBiblioteca.Name = "cbBiblioteca";
            this.cbBiblioteca.Size = new System.Drawing.Size(128, 27);
            this.cbBiblioteca.TabIndex = 18;
            this.cbBiblioteca.Text = "Biblioteca";
            this.cbBiblioteca.UseVisualStyleBackColor = true;
            // 
            // cbCocina
            // 
            this.cbCocina.AutoSize = true;
            this.cbCocina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCocina.Location = new System.Drawing.Point(177, 358);
            this.cbCocina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCocina.Name = "cbCocina";
            this.cbCocina.Size = new System.Drawing.Size(103, 27);
            this.cbCocina.TabIndex = 17;
            this.cbCocina.Text = "Cocina";
            this.cbCocina.UseVisualStyleBackColor = true;
            // 
            // cbAdministrador
            // 
            this.cbAdministrador.AutoSize = true;
            this.cbAdministrador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdministrador.Location = new System.Drawing.Point(177, 320);
            this.cbAdministrador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAdministrador.Name = "cbAdministrador";
            this.cbAdministrador.Size = new System.Drawing.Size(166, 27);
            this.cbAdministrador.TabIndex = 16;
            this.cbAdministrador.Text = "Administrador";
            this.cbAdministrador.UseVisualStyleBackColor = true;
            // 
            // cbProfesor
            // 
            this.cbProfesor.AutoSize = true;
            this.cbProfesor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfesor.Location = new System.Drawing.Point(177, 282);
            this.cbProfesor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(109, 27);
            this.cbProfesor.TabIndex = 15;
            this.cbProfesor.Text = "Profesor";
            this.cbProfesor.UseVisualStyleBackColor = true;
            this.cbProfesor.CheckedChanged += new System.EventHandler(this.cbProfesor_CheckedChanged);
            // 
            // accesoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1827, 650);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.dtgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "accesoAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accesoAdministrador";
            this.Load += new System.EventHandler(this.accesoAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.CheckBox cbAlumno;
        private System.Windows.Forms.CheckBox cbBiblioteca;
        private System.Windows.Forms.CheckBox cbCocina;
        private System.Windows.Forms.CheckBox cbAdministrador;
        private System.Windows.Forms.CheckBox cbProfesor;
    }
}