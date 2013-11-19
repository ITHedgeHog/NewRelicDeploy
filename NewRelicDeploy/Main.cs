using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace NewRelicDeploy
{
    public partial class frmDeployment : Form
    {
        public frmDeployment()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Clicked Reset");
        }

        private async void BtnPing_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(@"Clicked Ping");
            lblOutput.Text = "";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-key", this.txtApiKey.Text);
            // Create the HttpContent for the form to be posted.
            var requestContent = new FormUrlEncodedContent(new[] {
                     new KeyValuePair<string, string>("deployment[app_name]", txtAppName.Text),
                     ////new KeyValuePair<string, string>("deployment[application_id]", txtAppId.Text), 
                     new KeyValuePair<string, string>("deployment[description]", txtDesc.Text), 
                     new KeyValuePair<string, string>("deployment[revision]", txtRevision.Text), 
                     new KeyValuePair<string, string>("deployment[changelog]", txtChangeLog.Text), 
                     new KeyValuePair<string, string>("deployment[user]", txtUser.Text), 
            });

            // Get the response.
            HttpResponseMessage response = await client.PostAsync(
                "https://rpm.newrelic.com/deployments.xml",
                requestContent);

            // Get the response content.
            HttpContent responseContent = response.Content;

            // Get the stream of the content.
            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
            {
                var txt = await reader.ReadToEndAsync();
                // Write the output.
                // Console.WriteLine(txt);
                lblOutput.Text = txt;
            }
        }

        private void frmDeployment_Load(object sender, EventArgs e)
        {

        }
    }
}
