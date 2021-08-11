using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comtele.Sdk.Services;



//using TextmagicRest;
//using TextmagicRest.Model;

namespace prjEnvioSMS_v0._1
{
    public partial class Form1 : Form
    {
        private static string API_KEY = "77036d95-4db8-4c4a-a5c2-e1731b8f444f";

        public Form1()
        {
            InitializeComponent();
        }

        private void EnviarSMS()
        {
            
            var textMessageService = new TextMessageService(API_KEY);
            var result = textMessageService.Send("", "Hello CSharp", new string[] { "15988281252", "15988146648", "15988330673" });

            if (result.Success)
            {
                Console.WriteLine("A mensagem foi enviada com sucesso!");
            }
            else
            {
                Console.WriteLine("A mensagem não pode ser enviada. Detalhes: " + result.Message);
            }
            
            
            
            /*var client = new Client("test","my-api-key");
            var link = client.SendMessage("Hello from TextMagic API", "+5515988281252");
            if (link.Success)
            {
                Console.WriteLine("Message ID {0} has been successfully sent", link.Id);
            }
            else
            {
                Console.WriteLine("Message was not sent due to following exception: {0}.", link.ClientException.Message);
            }*/
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarSMS();
        }
    }

}
