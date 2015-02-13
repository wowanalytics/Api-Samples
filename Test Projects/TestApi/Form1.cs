using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using wow.ApiLibrary;
using wow.ApiLibrary.Authentication;
using wow.ApiLibrary.Models;
using wow.ApiLibrary.ExtensionMethods;

namespace ServerWithApiKey
{
    public partial class Form1 : Form
    {
        private string _baseUrl;

        public Form1()
        {
            InitializeComponent();

            _baseUrl = ConfigurationManager.AppSettings["baseUrl"];
        }

        private async void btnGetClientDetails_Click(object sender, EventArgs e)
        {
            var auth = new BasicAuthentication(txtUserName.Text, txtPassword.Text);

            var restClient = new WowClient(_baseUrl, auth, 2, "Test Client");

            var clients = await restClient.ClientsAsync();


            var clientResult = clients;

            lstClients.DataSource = clientResult;
            lstClients.DisplayMember = "Name";


        }

        private void btnGetClientDetials_Click(object sender, EventArgs e)
        {
            // get the selected client
            var selectedClient = lstClients.SelectedItem as Client;

            if (selectedClient == null)
            {
                MessageBox.Show("Please select a client");
                btnTrackedLinks.Enabled = false;
                btnLeads.Enabled = false;
                return;
            }

            var auth = new BasicAuthentication(txtUserName.Text, txtPassword.Text);

            var restClient = new WowClient(_baseUrl, auth, 2, "Test Client");

            var client = restClient.GetClientDetails(selectedClient.Id.ToString());

            txtName.Text = client.Name;
            txtId.Text = client.Id;
            txtVisitsMonth.Text = client.CompanyVisitsThisMonth.ToString();
            txtVisitsToday.Text = client.CompanyVisitsToday.ToString();
            txtExpires.Text = client.AccountExpiry.ToString();

            btnTrackedLinks.Enabled = true;
            btnLeads.Enabled = true;
        }

        private void btnTrackedLinks_Click(object sender, EventArgs e)
        {
            using (var form = new TrackedLinks
                {
                    ClientId = txtId.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text
                })
            {
                form.ShowDialog(this);
            }
        }

        private void btnLeads_Click(object sender, EventArgs e)
        {
            using (var form = new Leads
            {
                ClientId = txtId.Text,
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            })
            {
                form.ShowDialog(this);
            }
        }


    }
}
