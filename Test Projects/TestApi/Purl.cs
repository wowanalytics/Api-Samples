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
    public partial class Purl : Form
    {
        public string ClientId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        private string _baseUrl;

        public Purl()
        {
            InitializeComponent();
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"];
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var auth = new BasicAuthentication(UserName, Password);
            var restClient = new WowClient(_baseUrl, auth, 2, "Test Client");

            var purlDetails = new PurlDetails
            {
                Alert = chkAlert.Checked,
                Campaign = txtCampaign.Text,
                EmailAddress = txtEmailAddress.Text,
                Url = txtUrl.Text
            };

            btnCreate.Enabled = false;

            await restClient.CreatePurlAsync(ClientId, purlDetails)
                .ContinueWith(t =>
                {
                    //cbLeadTypes.Items.AddRange(t.Result.ToArray()) 
                    if (!t.IsFaulted)
                    {
                        BeginInvoke((Action)(() =>
                        {
                            btnCreate.Enabled = true;
                            txtShortCode.Text = t.Result.ShortCode;
                            txtShortUrl.Text = t.Result.Url;
                            txtMessage.Text = t.Result.Message;
                            chkFrameOptionsDeny.Checked = t.Result.FrameOptionsDeny;
                        }));
                    }
                });
        }
    }
}
