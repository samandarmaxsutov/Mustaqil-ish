

using System.Data;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using ClosedXML.Excel;

namespace Elektronika
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "GJnlZcdsnGodMMSSnhHbbu7azJDcziIiNNnn2ApQ",
            BasePath = "https://virtual-marketplace-eb306-default-rtdb.firebaseio.com/",

        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

           
            Login login = new Login();
            login.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            this.Hide();
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                label1.Text = "Ulangan";
                label1.ForeColor = Color.Green;
                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Rasmi", typeof(Image));
               
                dataTable.Columns.Add("Nomi");
                dataTable.Columns.Add("Firma nomi");
                dataTable.Columns.Add("Batareya quvvati");
                dataTable.Columns.Add("Ishlab chiqarilgan sana");
                dataTable.Columns.Add("Xotira xajmi");
                dataTable.Columns.Add("Elektronika turi");

                dataGridView1.DataSource = dataTable;

                dataGridView1.RowTemplate.Height = 100;

                dataGridView1.Columns["Rasmi"].Width = 100;

                dataGridView1.Columns["Id"].Width = 50;
                dataGridView1.Columns["Nomi"].Width = 150;
                dataGridView1.Columns["Firma nomi"].Width = 150;
                dataGridView1.Columns["Batareya quvvati"].Width = 120;
                dataGridView1.Columns["Ishlab chiqarilgan sana"].Width = 120;
                dataGridView1.Columns["Xotira xajmi"].Width = 100;
                dataGridView1.Columns["Elektronika turi"].Width = 150;

                

                export();
            }

            else
            {
                label1.Text = "Ulanmagan";
                label1.ForeColor = Color.Red;
            }

        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); 
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void export()
        {

            dataTable.Rows.Clear();

            FirebaseResponse response = await client.GetTaskAsync("Counter/node");
            Counter_class obj1 = response.ResultAs<Counter_class>();

            int cnt = Convert.ToInt32(obj1.cnt);



            for (int i = 1; i <= cnt; i++)
            {
                try
                {
                    FirebaseResponse response1 = await client.GetTaskAsync("ElektronikaData/" + i);
                    ElektronikaData obj2 = response1.ResultAs<ElektronikaData>();

                    DataRow dataRow = dataTable.NewRow();

                    dataRow["Id"] = obj2.Id;
                    dataRow["Firma nomi"] = obj2.firma_nomi;
                    dataRow["Batareya quvvati"] = obj2.batareya_quvvati;
                    dataRow["Ishlab chiqarilgan sana"] = obj2.ishlab_chiq_sana;
                    dataRow["Xotira xajmi"] = obj2.xotira_xajmi;
                    dataRow["Elektronika turi"] = obj2.turi;
                    dataRow["Nomi"] = obj2.nomi;


                    byte[] b = Convert.FromBase64String(obj2.rasm);

                    MemoryStream memoryStream = new MemoryStream();

                    memoryStream.Write(b, 0, Convert.ToInt32(b.Length));


                    Bitmap bitmap = new Bitmap(memoryStream, false);


                    dataRow["Rasmi"] = bitmap;
                    dataTable.Rows.Add(dataRow);

                }
                catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            export();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveDataGridViewToExcel();
        }

        private void SaveDataGridViewToExcel()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Data");
                            for (int i = 1; i < dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i).Value = dataGridView1.Columns[i - 1].HeaderText;
                            }
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                }
                            }
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Export Successful.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
