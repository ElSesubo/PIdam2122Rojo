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

namespace floridapp
{
    internal class EnviarGmail
    {
        const string mailAddress = "floridapprojo@gmail.com";
        const string password = "ghidm6rojo";

        /// <summary>
        /// Método para enviar correos
        /// </summary>
        /// <param name="Mensaje">Mensaje del correo</param>
        /// <param name="para">Destinatario del correo</param>
        /// <param name="asunto">Cuerpo del correo</param>
        /// <param name="Error">Mensaje de error si se produce un error</param>
        public static void EnviarMensaje(StringBuilder Mensaje, string para, string asunto, string Error)
        {
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(String.Format("Este correo ha sido enviado el dia {0:yyyy/MM/dd} a las {0:HH:mm:ss} h \n\n",DateTime.Now));
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

            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);
                return;
            }
        }

        
    }
}
