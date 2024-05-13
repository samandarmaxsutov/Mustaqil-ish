using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Diagnostics.Metrics;
using System.Drawing.Imaging;

namespace Elektronika
{
    public partial class AddDataForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "GJnlZcdsnGodMMSSnhHbbu7azJDcziIiNNnn2ApQ",
            BasePath = "https://virtual-marketplace-eb306-default-rtdb.firebaseio.com/",

        };

        IFirebaseClient client;
        public AddDataForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private async void button1_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(textBoxFirmaNomi.Text) ||
                string.IsNullOrWhiteSpace(textBoxBatareyaQuvvati.Text) ||
                string.IsNullOrWhiteSpace(textBoxIshlabChiqSana.Text) ||
                string.IsNullOrWhiteSpace(textBoxXotiraXajmi.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBoxNomi.Text) ||
                pictureBox1.Image == null)
            {
                MessageBox.Show("Iltimos, barcha maydonlarni to'ldiring va rasm tanlanganligiga ishonch hosil qiling.");
                return;
            }

            // Firebase operations
            FirebaseResponse responce = await client.GetAsync("Counter/node");
            Counter_class counter = responce.ResultAs<Counter_class>();

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] a = ms.ToArray();
                string output = Convert.ToBase64String(a);

                var dataElectronika = new ElektronikaData
                {
                    Id = (Convert.ToInt32(counter.cnt) + 1).ToString(),
                    firma_nomi = textBoxFirmaNomi.Text,
                    batareya_quvvati = textBoxBatareyaQuvvati.Text,
                    ishlab_chiq_sana = textBoxIshlabChiqSana.Text,
                    xotira_xajmi = textBoxXotiraXajmi.Text,
                    turi = comboBox1.Text,
                    nomi = textBoxNomi.Text,
                    rasm = output
                };

                SetResponse resp = await client.SetAsync("ElektronikaData/" + dataElectronika.Id, dataElectronika);
                SetResponse response1 = await client.SetAsync("Counter/node", new Counter_class { cnt = dataElectronika.Id.ToString() });

                MessageBox.Show(dataElectronika.nomi + " qo'shildi");

                // Clear the form fields after successful insertion
                ClearFormData();
            }
        }


        private void AddDataForm_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Ma'lumotlar ba'zasiga ulanmagan");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Rasm tanlash";
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp; *.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = new Bitmap(ofd.FileName);
                pictureBox1.Image = image.GetThumbnailImage(100, 100, null, new IntPtr());
            }
        }


        private void ClearFormData()
        {
            // Clear text boxes
            textBoxFirmaNomi.Clear();
            textBoxBatareyaQuvvati.Clear();
            textBoxIshlabChiqSana.Clear();
            textBoxXotiraXajmi.Clear();
            textBoxNomi.Clear();

            // Reset the comboBox to its default state or blank
            comboBox1.SelectedIndex = -1; // Assuming -1 sets it to no selection
            comboBox1.Text="";
            // Clear the image from pictureBox
            pictureBox1.Image = null;
        }


        private void textBoxNomi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
