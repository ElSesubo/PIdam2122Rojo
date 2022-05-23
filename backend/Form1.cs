using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
namespace ProyectoIntegrado


{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.CerrarConexion();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        const string mailAddress = "floridapprojo@gmail.com";
        const string password = "ghidm6rojo";
        public static void EnviarMensaje(StringBuilder Mensaje,DateTime fec, string para, string asunto, out string Error)
        {
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(String.Format("Este correo ha sido enviado el dia {0:yyyy/MM/dd} a las {0:HH:mm:ss} h \n\n",fec));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(mailAddress);
                mail.To.Add(para);
                mail.Subject = asunto;
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(mailAddress, password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Exito";
                MessageBox.Show(Error);

            }
            catch (Exception ex)
            {
                Error="Error: "+ex.Message;
                MessageBox.Show(Error);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string error = "";
            StringBuilder sb=new StringBuilder();
            sb.Append(txtMensaje.Text.Trim());
            Form1.EnviarMensaje(sb, DateTime.Now, txtPara.Text.Trim(), txtAsunto.Text.Trim(),out error);
        }
    }
}
