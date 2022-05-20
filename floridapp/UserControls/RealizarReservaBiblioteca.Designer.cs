
namespace floridapp.UserControls
{
    partial class RealizarReservaBiblioteca
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSala = new System.Windows.Forms.CheckBox();
            this.cbPortatil = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSalas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 33);
            this.label3.TabIndex = 34;
            this.label3.Text = "Salas disponibles:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 579);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(492, 50);
            this.button1.TabIndex = 33;
            this.button1.Text = "Realizar Reserva";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSala
            // 
            this.cbSala.AutoSize = true;
            this.cbSala.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSala.Location = new System.Drawing.Point(159, 378);
            this.cbSala.Margin = new System.Windows.Forms.Padding(4);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(108, 37);
            this.cbSala.TabIndex = 32;
            this.cbSala.Text = "Sala?";
            this.cbSala.UseVisualStyleBackColor = true;
            this.cbSala.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbPortatil
            // 
            this.cbPortatil.AutoSize = true;
            this.cbPortatil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPortatil.Location = new System.Drawing.Point(159, 414);
            this.cbPortatil.Margin = new System.Windows.Forms.Padding(4);
            this.cbPortatil.Name = "cbPortatil";
            this.cbPortatil.Size = new System.Drawing.Size(145, 37);
            this.cbPortatil.TabIndex = 40;
            this.cbPortatil.Text = "Portatil?";
            this.cbPortatil.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::floridapp.Properties.Resources.estudiantes_214533102;
            this.pictureBox1.Location = new System.Drawing.Point(733, 308);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 810);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // cbSalas
            // 
            this.cbSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSalas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalas.FormattingEnabled = true;
            this.cbSalas.Location = new System.Drawing.Point(404, 452);
            this.cbSalas.Margin = new System.Windows.Forms.Padding(4);
            this.cbSalas.Name = "cbSalas";
            this.cbSalas.Size = new System.Drawing.Size(321, 31);
            this.cbSalas.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Reserva tanto de portatiles como de salas de estudio";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.lbl1.Location = new System.Drawing.Point(143, 225);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(791, 91);
            this.lbl1.TabIndex = 47;
            this.lbl1.Text = "Realizar Reserva";
            // 
            // dtpHora
            // 
            this.dtpHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(363, 505);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpHora.Size = new System.Drawing.Size(265, 32);
            this.dtpHora.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 33);
            this.label4.TabIndex = 49;
            this.label4.Text = "Hora Reserva:";
            // 
            // RealizarReservaBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSalas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.cbPortatil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSala);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RealizarReservaBiblioteca";
            this.Size = new System.Drawing.Size(1477, 990);
            this.Load += new System.EventHandler(this.RealizarReservaBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbSala;
        private System.Windows.Forms.CheckBox cbPortatil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSalas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label4;
    }
}
