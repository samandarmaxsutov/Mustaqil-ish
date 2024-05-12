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
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Elektronika
{
    public partial class Login : Form
    {
        List<UserData> userList = new List<UserData>();


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "GJnlZcdsnGodMMSSnhHbbu7azJDcziIiNNnn2ApQ",
            BasePath = "https://virtual-marketplace-eb306-default-rtdb.firebaseio.com/",

        };

        IFirebaseClient client;

        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Firebase connection failed.");
                return;
            }

            getAllUsers();
        }

        private async void getAllUsers()
        {
            try
            {
                FirebaseResponse response = await client.GetTaskAsync("Users/");
                if (response.Body != "null")
                {

                    List<UserData> listData = JsonConvert.DeserializeObject<List<UserData>>(response.Body);

                    userList.Clear();
                    foreach(var item in listData)
                    {
                      if(item != null)
                        {
                            userList.Add(item);
                        }
                    }


                }
                else
                {
                    Debug.WriteLine("No users found.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception occurred: " + ex.Message);
            }
        }






        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void formFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            String login = textBox1.Text;
            String parol = textBox2.Text;

         
              
             foreach (var item in userList)
            {
             
                if (login==item.login&& parol == item.parol)
                {
                    AddDataForm form = new AddDataForm();
                    form.FormClosed += new FormClosedEventHandler(formFormClosed);
                    this.Hide();
                    form.Show();
                    return;
                }
               
            }

            MessageBox.Show("Login yoki parol xato");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
