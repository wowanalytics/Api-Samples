using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using wow.ApiLibrary;
using wow.ApiLibrary.Authentication;
using wow.ApiLibrary.ExtensionMethods;
using wow.ApiLibrary.Models;

namespace ServerWithApiKey
{
    public partial class Leads : Form
    {
        public string ClientId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        private string _baseUrl;

        public Leads()
        {
            InitializeComponent();
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"];



        }

        private async void Leads_Load(object sender, EventArgs e)
        {
            var auth = new BasicAuthentication(UserName, Password);
            var restClient = new WowClient(_baseUrl, auth, 2, "Test Client");
            await restClient.GetLeadTypesAsync()
                .ContinueWith(t =>
                {
                    //cbLeadTypes.Items.AddRange(t.Result.ToArray()) 
                    BeginInvoke((Action)(() =>
                    {
                        var data = t.Result.ToArray();
                        cbLeadTypes.Items.AddRange(data);
                    }));
                });
        }

        private async void btnGetLeads_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbLeadTypes.Text))
            {
                return;
            }

            var auth = new BasicAuthentication(UserName, Password);
            var restClient = new WowClient(_baseUrl, auth, 2, "Test Client");

            await restClient.GetLeadsAsync(ClientId, cbLeadTypes.Text, DateTime.Now.AddDays(-1), DateTime.Now, 1, 100)
                .ContinueWith(t =>
                {
                    //cbLeadTypes.Items.AddRange(t.Result.ToArray()) 
                    BeginInvoke((Action)(() =>
                    {
                        txtLeads.Text = Newtonsoft.Json.JsonConvert.SerializeObject(t.Result, Formatting.Indented);
                    }));
                });
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var auth = new BasicAuthentication(UserName, Password);
            var restClient = new WowClient(_baseUrl, auth, 2, "Test Client");

            var searchData = new LeadSearchModel
            {
                Search = txtSearch.Text,
                SearchType = cbSearch.Text,
                Utm = new UtmValues
                {
                    UtmContent = txtContent.Text,
                    UtmMedium = txtMedium.Text,
                    UtmName = txtCampaign.Text,
                    UtmSource = txtSource.Text,
                    UtmTerm = txtTerm.Text
                }
            };


            await restClient.GetLeadsSearchAsync(ClientId, cbLeadTypes.Text, DateTime.Now.AddDays(-1), DateTime.Now, 1, 100, searchData)
                .ContinueWith(t =>
                {
                    //cbLeadTypes.Items.AddRange(t.Result.ToArray()) 
                    BeginInvoke((Action)(() =>
                    {
                        txtLeads.Text = Newtonsoft.Json.JsonConvert.SerializeObject(t.Result, Formatting.Indented);
                    }));
                });
        }
    }
}
