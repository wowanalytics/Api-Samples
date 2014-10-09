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
using wow.ApiLibrary.ExtensionMethods;

namespace ServerWithApiKey
{
    public partial class TrackedLinks : Form
    {
        public string ClientId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        private string _baseUrl;

        public TrackedLinks()
        {
            InitializeComponent();
            _baseUrl = ConfigurationManager.AppSettings["baseUrl"];

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetTrackedLinks_Click(object sender, EventArgs e)
        {
            var take = int.Parse(valueTake.Text);
            var auth = new BasicAuthentication(UserName, Password);

            var restClient = new WowClient(_baseUrl, auth);

            var trackedLinks = restClient.GetTrackedLinks(ClientId, take);

            txtProcessId.Text = trackedLinks.ProcessId.ToString();

            dataTrackedLinks.DataSource = trackedLinks.TrackedLinks;
            dataTrackedLinks.Refresh();
            
        }

        private void btnMarkProcessed_Click(object sender, EventArgs e)
        {
            var take = int.Parse(valueTake.Text);
            var auth = new BasicAuthentication(UserName, Password);
            Guid processId = Guid.Parse(txtProcessId.Text);

            var restClient = new WowClient(_baseUrl, auth);

            var trackedLinks = restClient.MarkTrackedLinksProcessed(ClientId, processId);
            
            dataTrackedLinks.DataSource = null;
            dataTrackedLinks.Refresh();
        }
    }
}
