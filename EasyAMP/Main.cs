using EasyAMP.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace EasyAMP
{
    public partial class Main : Form
    {
        public ConfigObject configObject = new ConfigObject();

        private Button btn_show = new Button();
        private Button btn_copy_laravel = new Button();

        public Main()
        {
            InitializeComponent();
        }

        private void btSelApacheDir_Click(object sender, EventArgs e)
        {
            if (this.fbApacheDir.ShowDialog() == DialogResult.OK)
            {
                this.txtApacheDir.Text = this.fbApacheDir.SelectedPath;
                this.configObject.xamppPath = this.fbApacheDir.SelectedPath;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Settings.loadSettings(out this.configObject);

            this.setUIText();


            this.ReloadHosts();

            btn_show.Visible = false;
            btn_show.Text = "顯示";
            btn_show.Click += this.buttonShow_Click;
            this.lvHosts.Controls.Add(btn_show);
            this.btn_show.Size = new Size(this.lvHosts.Items[0].SubItems[2].Bounds.Width,
            this.lvHosts.Items[0].SubItems[2].Bounds.Height);

            btn_copy_laravel.Visible = false;
            btn_copy_laravel.Text = "Copy";
            btn_copy_laravel.Click += this.buttonCopyLaravel_Click;
            this.lvHosts.Controls.Add(btn_copy_laravel);
            this.btn_copy_laravel.Size = new Size(this.lvHosts.Items[0].SubItems[1].Bounds.Width,
            this.lvHosts.Items[0].SubItems[1].Bounds.Height);
        }

        private void setUIText()
        {
            this.txtApacheDir.Text = this.configObject.xamppPath;
        }

        private async void tmAll_Tick(object sender, EventArgs e)
        {
            string apache_state;

            try
            {
                apache_state = Servers.GetServiceState("Apache2.4");
                this.lbIsApacheAlive.Text = apache_state;

                if (apache_state == "Running")
                {
                    this.btStartStop.Text = "停止";
                }
                else
                {
                    this.btStartStop.Text = "啟動";
                }
            }
            catch (Exception ex)
            {
                this.lbIsApacheAlive.Text = "錯誤";
                this.btStartStop.Text = "啟動";
            }

            //////////////////////////
            string mysql_state;

            try
            {
                mysql_state = Servers.GetServiceState("mysql");
                this.lbIsMysqlAlive.Text = mysql_state;

                if (mysql_state == "Running")
                {
                    this.btStartStopMySql.Text = "停止";
                }
                else
                {
                    this.btStartStopMySql.Text = "啟動";
                }
            }
            catch (Exception ex)
            {
                this.lbIsMysqlAlive.Text = "錯誤";
                this.btStartStopMySql.Text = "啟動";
            }

        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Button bt = (Button)sender;
                if (bt.Text == "啟動")
                {
                    Servers.Start("Apache2.4");
                }
                else
                {

                    Servers.Stop("Apache2.4");
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btEditHosts_Click(object sender, EventArgs e)
        {
            FrmHosts frm = new FrmHosts();
            frm.configObject = this.configObject;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.ReloadHosts();

                lvHosts.Items[0].Selected = true;
                lvHosts.Select();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("ok");
        }

        private void lvHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem[] lvs = new ListViewItem[this.configObject.hosts.Count];

            if (this.lvHosts.SelectedItems.Count > 0)
            {
                this.txtDb.Text = this.lvHosts.SelectedItems[0].Text;

                this.btn_show.Location = new Point(this.lvHosts.SelectedItems[0].SubItems[2].Bounds.Left, this.lvHosts.SelectedItems[0].SubItems[2].Bounds.Top);
                this.btn_show.Visible = true;

                this.btn_copy_laravel.Location = new Point(this.lvHosts.SelectedItems[0].SubItems[1].Bounds.Left, this.lvHosts.SelectedItems[0].SubItems[1].Bounds.Top);
                this.btn_copy_laravel.Visible = true;
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string host = this.lvHosts.SelectedItems[0].SubItems[0].Text;


            string url = "http://" + host;


            Process myProcess = new Process();

            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = url;
                myProcess.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonCopyLaravel_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string host = this.lvHosts.SelectedItems[0].SubItems[0].Text;

                Directory.Move(this.configObject.xamppPath + "\\htdocs\\" + host, configObject.xamppPath + "\\htdocs\\" + host + "_bak_" + DateTime.Now.Ticks.ToString());
                
                Process process = new Process();
                process.StartInfo.FileName = @"7za.exe";
                process.StartInfo.Arguments = @"x -o" + this.configObject.xamppPath + "\\htdocs\\" + host + " demo.zip";
                process.Start();

                process.WaitForExit();
                // PhpStorm
                Settings.SetPhpStormPrjFile(this.configObject, host);

                MessageBox.Show("複製完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

                
            } 
        }

        private void ReloadHosts()
        {
            this.lvHosts.Items.Clear();

            ListViewItem[] lvs = new ListViewItem[this.configObject.hosts.Count];

            int i = 0;
            foreach (var host in this.configObject.hosts)
            {
                lvs[i] = new ListViewItem(new string[] { host.host, "", "" });

                i++;
            }

            this.lvHosts.Items.AddRange(lvs);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Settings.saveSettings(this.configObject);
            Settings.saveHosts(this.configObject);
            Settings.saveVHostConfig(this.configObject);

            this.Close();
        }

        private void btStartStopMySql_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Button bt = (Button)sender;
                if (bt.Text == "啟動")
                {
                    Servers.Start("mysql");
                }
                else
                {
                    Servers.Stop("mysql");
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btToHtdocs_Click(object sender, EventArgs e)
        {
            string htdocs_path = this.configObject.xamppPath + @"\htdocs";
            
            System.Diagnostics.Process.Start("explorer.exe", htdocs_path);
        }

        private void btSetMySqlSettings_Click(object sender, EventArgs e)
        {

            string ret_str = SqlDb.SetSql(this.txtAccount.Text, this.txtPassword.Text, this.txtDb.Text);
            SqlDb.UpdateEnvFileDb(this.configObject, Utils.DbType.mysql, this.txtDb.Text);            
            MessageBox.Show(ret_str);
        }

        private void btSelSqlFile_Click(object sender, EventArgs e)
        {
            if(this.ofSelSqlFile.ShowDialog() == DialogResult.OK)
            {
                this.txtSqlFile.Text = this.ofSelSqlFile.FileName;
            }
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDb.ExecuteSqlFile(this.txtAccount.Text, this.txtPassword.Text, this.txtDb.Text, this.txtSqlFile.Text);
                MessageBox.Show("執行 sql 檔完成。");
            }
            catch(Exception)
            {
                MessageBox.Show("執行 sql 檔過程發生錯誤。");
            }
        }
    }
}
