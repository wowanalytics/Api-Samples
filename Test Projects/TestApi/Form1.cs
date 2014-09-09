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

        private void btnGetClientDetails_Click(object sender, EventArgs e)
        {
            var auth = new BasicAuthentication(txtUserName.Text, txtPassword.Text);

            var restClient = new WowClient(_baseUrl, auth);

            var trackedLinks = restClient.GetTrackedLinks("ee915d54-7536-47a6-a089-3a22318a40a3", 100);

            if (trackedLinks == null)
            {
                
            }

            var clients = restClient.Clients();

            lstClients.DataSource = clients;
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
                return;
            }

            var auth = new BasicAuthentication(txtUserName.Text, txtPassword.Text);

            var restClient = new WowClient(_baseUrl, auth);

            var client = restClient.GetClientDetails(selectedClient.Id.ToString());

            txtName.Text = client.Name;
            txtId.Text = client.Id;
            txtVisitsMonth.Text = client.CompanyVisitsThisMonth.ToString();
            txtVisitsToday.Text = client.CompanyVisitsToday.ToString();
            txtExpires.Text = client.AccountExpiry.ToString();

            btnTrackedLinks.Enabled = true;
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

    }
}
