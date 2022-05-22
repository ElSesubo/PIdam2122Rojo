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
            this.components = new System.ComponentModel.Container();
            this.dtgvUsuarios1 = new System.Windows.Forms.DataGridView();
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
            this.rbnAlumno = new System.Windows.Forms.RadioButton();
            this.rbnBiblioteca = new System.Windows.Forms.RadioButton();
            this.rbnCocina = new System.Windows.Forms.RadioButton();
            this.rbnAdmin = new System.Windows.Forms.RadioButton();
            this.rbnProfesor = new System.Windows.Forms.RadioButton();
            this.gbCiclo = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbprensencia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbhorario = new System.Windows.Forms.ComboBox();
            this.cmbclase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbmodulo = new System.Windows.Forms.ComboBox();
            this.cmbciclo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblmodulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios1)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.gbCiclo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvUsuarios1
            // 
            this.dtgvUsuarios1.AllowUserToAddRows = false;
            this.dtgvUsuarios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dtgvUsuarios1.Location = new System.Drawing.Point(29, 85);
            this.dtgvUsuarios1.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvUsuarios1.Name = "dtgvUsuarios1";
            this.dtgvUsuarios1.RowHeadersWidth = 51;
            this.dtgvUsuarios1.Size = new System.Drawing.Size(802, 446);
            this.dtgvUsuarios1.TabIndex = 0;
            this.dtgvUsuarios1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellContentClick);
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
            this.label2.Location = new System.Drawing.Point(59, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Usuarios";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(1361, 574);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnEliminar.Location = new System.Drawing.Point(1233, 574);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnEditar.Location = new System.Drawing.Point(1125, 574);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnBuscar.Location = new System.Drawing.Point(1017, 574);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnInsertar.Location = new System.Drawing.Point(900, 574);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblNombre.Location = new System.Drawing.Point(113, 33);
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
            this.txtNif.Location = new System.Drawing.Point(166, 30);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(239, 32);
            this.txtNif.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(166, 70);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(437, 32);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(166, 111);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtNombre.Location = new System.Drawing.Point(166, 151);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(437, 32);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(166, 194);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtTel.Location = new System.Drawing.Point(166, 238);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(437, 32);
            this.txtTel.TabIndex = 14;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.rbnAlumno);
            this.pnlUsuario.Controls.Add(this.rbnBiblioteca);
            this.pnlUsuario.Controls.Add(this.rbnCocina);
            this.pnlUsuario.Controls.Add(this.rbnAdmin);
            this.pnlUsuario.Controls.Add(this.rbnProfesor);
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
            this.pnlUsuario.Location = new System.Drawing.Point(900, 85);
            this.pnlUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(634, 481);
            this.pnlUsuario.TabIndex = 8;
            // 
            // rbnAlumno
            // 
            this.rbnAlumno.AutoSize = true;
            this.rbnAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAlumno.Location = new System.Drawing.Point(177, 302);
            this.rbnAlumno.Name = "rbnAlumno";
            this.rbnAlumno.Size = new System.Drawing.Size(107, 27);
            this.rbnAlumno.TabIndex = 24;
            this.rbnAlumno.TabStop = true;
            this.rbnAlumno.Text = "Alumno";
            this.rbnAlumno.UseVisualStyleBackColor = true;
            this.rbnAlumno.CheckedChanged += new System.EventHandler(this.rbnAlumno_CheckedChanged);
            // 
            // rbnBiblioteca
            // 
            this.rbnBiblioteca.AutoSize = true;
            this.rbnBiblioteca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnBiblioteca.Location = new System.Drawing.Point(177, 401);
            this.rbnBiblioteca.Name = "rbnBiblioteca";
            this.rbnBiblioteca.Size = new System.Drawing.Size(127, 27);
            this.rbnBiblioteca.TabIndex = 23;
            this.rbnBiblioteca.TabStop = true;
            this.rbnBiblioteca.Text = "Biblioteca";
            this.rbnBiblioteca.UseVisualStyleBackColor = true;
            this.rbnBiblioteca.CheckedChanged += new System.EventHandler(this.rbnBiblioteca_CheckedChanged);
            // 
            // rbnCocina
            // 
            this.rbnCocina.AutoSize = true;
            this.rbnCocina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnCocina.Location = new System.Drawing.Point(177, 368);
            this.rbnCocina.Name = "rbnCocina";
            this.rbnCocina.Size = new System.Drawing.Size(102, 27);
            this.rbnCocina.TabIndex = 22;
            this.rbnCocina.TabStop = true;
            this.rbnCocina.Text = "Cocina";
            this.rbnCocina.UseVisualStyleBackColor = true;
            this.rbnCocina.CheckedChanged += new System.EventHandler(this.rbnCocina_CheckedChanged);
            // 
            // rbnAdmin
            // 
            this.rbnAdmin.AutoSize = true;
            this.rbnAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAdmin.Location = new System.Drawing.Point(177, 434);
            this.rbnAdmin.Name = "rbnAdmin";
            this.rbnAdmin.Size = new System.Drawing.Size(165, 27);
            this.rbnAdmin.TabIndex = 21;
            this.rbnAdmin.TabStop = true;
            this.rbnAdmin.Text = "Administrador";
            this.rbnAdmin.UseVisualStyleBackColor = true;
            this.rbnAdmin.CheckedChanged += new System.EventHandler(this.rbnAdmin_CheckedChanged);
            // 
            // rbnProfesor
            // 
            this.rbnProfesor.AutoSize = true;
            this.rbnProfesor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnProfesor.Location = new System.Drawing.Point(177, 335);
            this.rbnProfesor.Name = "rbnProfesor";
            this.rbnProfesor.Size = new System.Drawing.Size(108, 27);
            this.rbnProfesor.TabIndex = 20;
            this.rbnProfesor.TabStop = true;
            this.rbnProfesor.Text = "Profesor";
            this.rbnProfesor.UseVisualStyleBackColor = true;
            this.rbnProfesor.CheckedChanged += new System.EventHandler(this.rbnProfesor_CheckedChanged);
            this.rbnProfesor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbnProfesor_MouseClick);
            // 
            // gbCiclo
            // 
            this.gbCiclo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbCiclo.Controls.Add(this.button2);
            this.gbCiclo.Controls.Add(this.cmbprensencia);
            this.gbCiclo.Controls.Add(this.label7);
            this.gbCiclo.Controls.Add(this.cmbhorario);
            this.gbCiclo.Controls.Add(this.cmbclase);
            this.gbCiclo.Controls.Add(this.label6);
            this.gbCiclo.Controls.Add(this.label4);
            this.gbCiclo.Controls.Add(this.button1);
            this.gbCiclo.Controls.Add(this.cmbmodulo);
            this.gbCiclo.Controls.Add(this.cmbciclo);
            this.gbCiclo.Controls.Add(this.label5);
            this.gbCiclo.Controls.Add(this.lblmodulo);
            this.gbCiclo.Controls.Add(this.label3);
            this.gbCiclo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCiclo.Location = new System.Drawing.Point(143, 12);
            this.gbCiclo.Name = "gbCiclo";
            this.gbCiclo.Size = new System.Drawing.Size(650, 533);
            this.gbCiclo.TabIndex = 29;
            this.gbCiclo.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 61);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbprensencia
            // 
            this.cmbprensencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprensencia.FormattingEnabled = true;
            this.cmbprensencia.Location = new System.Drawing.Point(215, 247);
            this.cmbprensencia.Name = "cmbprensencia";
            this.cmbprensencia.Size = new System.Drawing.Size(230, 35);
            this.cmbprensencia.TabIndex = 11;
            this.cmbprensencia.SelectedIndexChanged += new System.EventHandler(this.cmbprensencia_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Presencialidad: ";
            // 
            // cmbhorario
            // 
            this.cmbhorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhorario.FormattingEnabled = true;
            this.cmbhorario.Location = new System.Drawing.Point(215, 302);
            this.cmbhorario.Name = "cmbhorario";
            this.cmbhorario.Size = new System.Drawing.Size(230, 35);
            this.cmbhorario.TabIndex = 9;
            this.cmbhorario.SelectedIndexChanged += new System.EventHandler(this.cmbhorario_SelectedIndexChanged);
            // 
            // cmbclase
            // 
            this.cmbclase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbclase.FormattingEnabled = true;
            this.cmbclase.Location = new System.Drawing.Point(215, 193);
            this.cmbclase.Name = "cmbclase";
            this.cmbclase.Size = new System.Drawing.Size(230, 35);
            this.cmbclase.TabIndex = 8;
            this.cmbclase.SelectedIndexChanged += new System.EventHandler(this.cmbclase_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Horario: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clase: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbmodulo
            // 
            this.cmbmodulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmodulo.FormattingEnabled = true;
            this.cmbmodulo.Location = new System.Drawing.Point(215, 358);
            this.cmbmodulo.Name = "cmbmodulo";
            this.cmbmodulo.Size = new System.Drawing.Size(230, 35);
            this.cmbmodulo.TabIndex = 4;
            // 
            // cmbciclo
            // 
            this.cmbciclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbciclo.FormattingEnabled = true;
            this.cmbciclo.Location = new System.Drawing.Point(215, 146);
            this.cmbciclo.Name = "cmbciclo";
            this.cmbciclo.Size = new System.Drawing.Size(230, 35);
            this.cmbciclo.TabIndex = 3;
            this.cmbciclo.SelectedIndexChanged += new System.EventHandler(this.cmbciclo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(597, 68);
            this.label5.TabIndex = 2;
            this.label5.Text = "Selecione el ciclo y modulo al que quieres\r\nque pertenezca";
            // 
            // lblmodulo
            // 
            this.lblmodulo.AutoSize = true;
            this.lblmodulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodulo.Location = new System.Drawing.Point(33, 368);
            this.lblmodulo.Name = "lblmodulo";
            this.lblmodulo.Size = new System.Drawing.Size(110, 27);
            this.lblmodulo.TabIndex = 1;
            this.lblmodulo.Text = "Módulo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ciclo: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NIF";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Correo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contraseña";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Apellido";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tel";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Alumno";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Profesor";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cocina";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Biblioteca";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Admi";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column11.Width = 125;
            // 
            // accesoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1608, 650);
            this.Controls.Add(this.gbCiclo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.dtgvUsuarios1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "accesoAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "accesoAdministrador";
            this.Load += new System.EventHandler(this.accesoAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios1)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.gbCiclo.ResumeLayout(false);
            this.gbCiclo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUsuarios1;
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
        private System.Windows.Forms.RadioButton rbnProfesor;
        private System.Windows.Forms.RadioButton rbnAlumno;
        private System.Windows.Forms.RadioButton rbnBiblioteca;
        private System.Windows.Forms.RadioButton rbnCocina;
        private System.Windows.Forms.RadioButton rbnAdmin;
        private System.Windows.Forms.GroupBox gbCiclo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmodulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmodulo;
        private System.Windows.Forms.ComboBox cmbciclo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbprensencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbhorario;
        private System.Windows.Forms.ComboBox cmbclase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
    }
}