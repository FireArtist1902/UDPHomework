using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPHomework
{
    public partial class Form1 : Form
    {
        Task receiver;
        IPAddress address = Dns.GetHostAddresses(Dns.GetHostName())[1];
        int port = 11000;

        bool[] products = new bool[6];

        Products product;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product = new Products(products);

            UdpClient udpClient = null;
            try
            {
                udpClient = new UdpClient();
                byte[] buff = Encoding.Default.GetBytes(product.GetRecipe());
                IPEndPoint remoteEP = new IPEndPoint(address, port);
                udpClient.Send(buff, buff.Length, remoteEP);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                udpClient.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (receiver != null)
            {
                return;
            }
            receiver = Task.Run(() =>
            {
                UdpClient listener = new UdpClient(new IPEndPoint(address, port));
                IPEndPoint remoteEP = null;
                UdpClient client = new UdpClient();
                while (true)
                {
                    byte[] buff = listener.Receive(ref remoteEP);
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"{buff.Length} bytes received {remoteEP}");
                    sb.AppendLine(Encoding.Default.GetString(buff));
                    textBox2.BeginInvoke(new Action<string>(AddText), sb.ToString());
                }
            });
            Text = "Working";
        }

        private void AddText(string obj)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(obj);
            textBox2.Text = sb.ToString();
        }

        private void BreadCB_CheckedChanged(object sender, EventArgs e)
        {
            products[0] = BreadCB.Checked;
        }

        private void EggCB_CheckedChanged(object sender, EventArgs e)
        {
            products[1] = EggCB.Checked;
        }

        private void MilkCB_CheckedChanged(object sender, EventArgs e)
        {
            products[2] = MilkCB.Checked;
        }

        private void CheeseCB_CheckedChanged(object sender, EventArgs e)
        {
            products[3] = CheeseCB.Checked;
        }

        private void SausageCB_CheckedChanged(object sender, EventArgs e)
        {
            products[4] = SausageCB.Checked;
        }

        private void FlourCB_CheckedChanged(object sender, EventArgs e)
        {
            products[5] = FlourCB.Checked;
        }
    }
}