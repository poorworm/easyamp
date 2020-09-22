using EasyAMP.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace EasyAMP
{
    public partial class FrmHosts : Form
    {
        public ConfigObject configObject { get; set; }

        public FrmHosts()
        {
            InitializeComponent();
        }

        private void FrmHosts_Load(object sender, EventArgs e)
        {
            foreach(var host in this.configObject.hosts)
            {
                string host_name = host.host;
                string ip = host.ip;

                var lvi = this.lvList.Items.Add(host_name);
                lvi.SubItems.Add(ip);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string host_name = this.txtHostName.Text;
            string ip = this.txtIP.Text;

            var lvi = this.lvList.Items.Add(host_name);
            lvi.SubItems.Add(ip);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if(this.lvList.SelectedItems.Count == 1)
            {
                var lvi = this.lvList.SelectedItems[0];

                if(lvi.Text != "localhost")
                {
                    this.lvList.Items.Remove(lvi);

                    if (this.lvList.Items.Count > 0)
                    {
                        this.lvList.Items[0].Selected = true;
                        this.lvList.Items[0].Focused = true;
                    }

                }
                else
                {
                    MessageBox.Show("localhost 不能刪");
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this.configObject.hosts.Clear();

                foreach (ListViewItem lvi in this.lvList.Items)
                {
                    string host = lvi.Text;
                    string ip = lvi.SubItems[1].Text;

                    this.configObject.hosts.Add(new Host { host = host, ip = ip });
                }

                Settings.saveSettings(this.configObject);
                Settings.saveHosts(this.configObject);
                Settings.saveVHostConfig(this.configObject);

                Servers.Stop("Apache2.4");
                Thread.Sleep(5000);
                Servers.Start("Apache2.4");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


    }
}
