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
using wow.ApiLibrary.Models;

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
            var restClient = new WowClient(_baseUrl, txtApiKey.Text);

            var clients = restClient.GetClients();

            lstClients.DataSource = clients.Data;
            lstClients.DisplayMember = "Name";
            

        }

        private void btnGetClientDetials_Click(object sender, EventArgs e)
        {
            // get the selected client
            var selectedClient = lstClients.SelectedItem as Client;

            if (selectedClient == null)
            {
                MessageBox.Show("Please select a client");
                return;
            }

            var restClient = new WowClient(_baseUrl, txtApiKey.Text);

            var client = restClient.GetClientDetails(selectedClient.Id);

            txtName.Text = client.Data.Name;
            txtId.Text = client.Data.Id;
            txtVisitsMonth.Text = client.Data.CompanyVisitsThisMonth.ToString();
            txtVisitsToday.Text = client.Data.CompanyVisitsToday.ToString();
            txtExpires.Text = client.Data.AccountExpiry.ToString();

        }

        private void btnGetLatestLeads_Click(object sender, EventArgs e)
        {
             var selectedClient = lstClients.SelectedItem as Client;

            if (selectedClient == null)
            {
                MessageBox.Show("Please select a client");
                return;
            }

            var frm = new LatestLeads();
            frm.ClientId = selectedClient.Id;
            frm.ClientName = selectedClient.Name;
            frm.ApiKey = txtApiKey.Text;
            frm.Show(this);

        }

    }
}
