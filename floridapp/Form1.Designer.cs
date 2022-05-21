
namespace floridapp
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAlumno = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.btnListaMod = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnCafeteria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReunion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLenguas = new System.Windows.Forms.ComboBox();
            this.lblinicio = new System.Windows.Forms.Label();
            this.panelVista = new System.Windows.Forms.Panel();
            this.btnListaModAlu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.btnListaModAlu);
            this.panel1.Controls.Add(this.pbAlumno);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pbUsuario);
            this.panel1.Controls.Add(this.btnListaMod);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnBiblioteca);
            this.panel1.Controls.Add(this.btnCafeteria);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnReunion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 804);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbAlumno
            // 
            this.pbAlumno.Image = global::floridapp.Properties.Resources.AlumnoUser;
            this.pbAlumno.Location = new System.Drawing.Point(31, 27);
            this.pbAlumno.Name = "pbAlumno";
            this.pbAlumno.Size = new System.Drawing.Size(28, 28);
            this.pbAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlumno.TabIndex = 11;
            this.pbAlumno.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(71, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 22);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "FLORIDAPP";
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::floridapp.Properties.Resources.ProfesorUser;
            this.pbUsuario.Location = new System.Drawing.Point(31, 28);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(28, 40);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 9;
            this.pbUsuario.TabStop = false;
            // 
            // btnListaMod
            // 
            this.btnListaMod.FlatAppearance.BorderSize = 0;
            this.btnListaMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaMod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaMod.ForeColor = System.Drawing.Color.White;
            this.btnListaMod.Image = global::floridapp.Properties.Resources.News__1___1_;
            this.btnListaMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaMod.Location = new System.Drawing.Point(34, 561);
            this.btnListaMod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaMod.Name = "btnListaMod";
            this.btnListaMod.Size = new System.Drawing.Size(247, 79);
            this.btnListaMod.TabIndex = 7;
            this.btnListaMod.Text = "   Lista grados";
            this.btnListaMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaMod.UseVisualStyleBackColor = true;
            this.btnListaMod.Click += new System.EventHandler(this.btnListaMod_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Image = global::floridapp.Properties.Resources.SALIDA;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(31, 722);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(247, 79);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "   Salida";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(71, 263);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 23);
            this.lblTitulo.TabIndex = 1;
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.FlatAppearance.BorderSize = 0;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.ForeColor = System.Drawing.Color.White;
            this.btnBiblioteca.Image = global::floridapp.Properties.Resources.Biblioteca__1_;
            this.btnBiblioteca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiblioteca.Location = new System.Drawing.Point(34, 488);
            this.btnBiblioteca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(247, 79);
            this.btnBiblioteca.TabIndex = 3;
            this.btnBiblioteca.Text = "   Biblioteca";
            this.btnBiblioteca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBiblioteca.UseVisualStyleBackColor = true;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // btnCafeteria
            // 
            this.btnCafeteria.FlatAppearance.BorderSize = 0;
            this.btnCafeteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCafeteria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafeteria.ForeColor = System.Drawing.Color.White;
            this.btnCafeteria.Image = global::floridapp.Properties.Resources.Cafeteria__1_;
            this.btnCafeteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCafeteria.Location = new System.Drawing.Point(34, 407);
            this.btnCafeteria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCafeteria.Name = "btnCafeteria";
            this.btnCafeteria.Size = new System.Drawing.Size(247, 79);
            this.btnCafeteria.TabIndex = 2;
            this.btnCafeteria.Text = "   Cafetería";
            this.btnCafeteria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCafeteria.UseVisualStyleBackColor = true;
            this.btnCafeteria.Click += new System.EventHandler(this.btnCafeteria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::floridapp.Properties.Resources.floridapng;
            this.pictureBox1.Location = new System.Drawing.Point(66, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnReunion
            // 
            this.btnReunion.FlatAppearance.BorderSize = 0;
            this.btnReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReunion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReunion.ForeColor = System.Drawing.Color.White;
            this.btnReunion.Image = global::floridapp.Properties.Resources.CALENDIARUI;
            this.btnReunion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReunion.Location = new System.Drawing.Point(34, 325);
            this.btnReunion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReunion.Name = "btnReunion";
            this.btnReunion.Size = new System.Drawing.Size(247, 79);
            this.btnReunion.TabIndex = 1;
            this.btnReunion.Text = "   Reunion";
            this.btnReunion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReunion.UseVisualStyleBackColor = true;
            this.btnReunion.Click += new System.EventHandler(this.btnReunion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.cbLenguas);
            this.panel2.Controls.Add(this.lblinicio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 123);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbLenguas
            // 
            this.cbLenguas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLenguas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLenguas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLenguas.FormattingEnabled = true;
            this.cbLenguas.Items.AddRange(new object[] {
            "Castellano",
            "English"});
            this.cbLenguas.Location = new System.Drawing.Point(898, 40);
            this.cbLenguas.Name = "cbLenguas";
            this.cbLenguas.Size = new System.Drawing.Size(155, 27);
            this.cbLenguas.TabIndex = 1;
            this.cbLenguas.SelectedIndexChanged += new System.EventHandler(this.cbxIdiomas_SelectedIndexChanged);
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.ForeColor = System.Drawing.Color.Black;
            this.lblinicio.Location = new System.Drawing.Point(469, 32);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(176, 56);
            this.lblinicio.TabIndex = 0;
            this.lblinicio.Text = "INICIO";
            // 
            // panelVista
            // 
            this.panelVista.BackColor = System.Drawing.SystemColors.Control;
            this.panelVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVista.ForeColor = System.Drawing.Color.Black;
            this.panelVista.Location = new System.Drawing.Point(278, 0);
            this.panelVista.Name = "panelVista";
            this.panelVista.Size = new System.Drawing.Size(1108, 804);
            this.panelVista.TabIndex = 5;
            this.panelVista.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVista_Paint);
            // 
            // btnListaModAlu
            // 
            this.btnListaModAlu.FlatAppearance.BorderSize = 0;
            this.btnListaModAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaModAlu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaModAlu.ForeColor = System.Drawing.Color.White;
            this.btnListaModAlu.Image = global::floridapp.Properties.Resources.News__1___1_;
            this.btnListaModAlu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaModAlu.Location = new System.Drawing.Point(34, 561);
            this.btnListaModAlu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaModAlu.Name = "btnListaModAlu";
            this.btnListaModAlu.Size = new System.Drawing.Size(247, 79);
            this.btnListaModAlu.TabIndex = 12;
            this.btnListaModAlu.Text = "   Lista grados";
            this.btnListaModAlu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaModAlu.UseVisualStyleBackColor = true;
            this.btnListaModAlu.Click += new System.EventHandler(this.btnListaModAlu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 804);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelVista);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReunion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.Button btnCafeteria;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Panel panelVista;
        private System.Windows.Forms.Button btnListaMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbAlumno;
        private System.Windows.Forms.ComboBox cbLenguas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnListaModAlu;
    }
}

