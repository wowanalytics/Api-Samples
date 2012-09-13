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

namespace ServerWithApiKey
{
    public partial class LatestLeads : Form
    {
        private string _baseUrl;

        public LatestLeads()
        {
            InitializeComponent();
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"];
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string ClientId
        {
            get { return txtId.Text; }
            set { txtId.Text = value; }
        }

        public string ClientName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string ApiKey { get; set; }

        private void btnGetLatestLeads_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMinutes.Text) || string.IsNullOrEmpty(txtNumToGet.Text))
            {
                MessageBox.Show("You must supply the last number of minutes and the number of leads to get");
                return;
            }

            var restClient = new WowClient(_baseUrl, ApiKey);

            var leads = restClient.GetLatestLeads(ClientId, int.Parse(txtMinutes.Text), int.Parse(txtNumToGet.Text));

            dgLeads.DataSource = leads;
            

        }

    }
}
