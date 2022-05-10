using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrado
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        public static void enviarCorreo (StringBuilder Mensaje,DateTime fechaEnvio,string de,string para,string asunto,out string error){
            error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(String.Format("Este correo se ha enviado el dia {0:yyyy/MM/dd} a las {0:HH:mm:ss} hrs:\n\n",fechaEnvio));
                Mensaje.Append(Environment.NewLine);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
