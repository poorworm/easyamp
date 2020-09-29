namespace EasyAMP
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtApacheDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSelApacheDir = new System.Windows.Forms.Button();
            this.fbApacheDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btStartStop = new System.Windows.Forms.Button();
            this.tmAll = new System.Windows.Forms.Timer(this.components);
            this.lbIsApacheAlive = new System.Windows.Forms.Label();
            this.btEditHosts = new System.Windows.Forms.Button();
            this.lvHosts = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btExit = new System.Windows.Forms.Button();
            this.btStartStopMySql = new System.Windows.Forms.Button();
            this.lbIsMysqlAlive = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btToHtdocs = new System.Windows.Forms.Button();
            this.btSetMySqlSettings = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btSelSqlFile = new System.Windows.Forms.Button();
            this.btExecute = new System.Windows.Forms.Button();
            this.txtSqlFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofSelSqlFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApacheDir
            // 
            this.txtApacheDir.Location = new System.Drawing.Point(113, 12);
            this.txtApacheDir.Name = "txtApacheDir";
            this.txtApacheDir.ReadOnly = true;
            this.txtApacheDir.Size = new System.Drawing.Size(525, 27);
            this.txtApacheDir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "XAMPP Dir:";
            // 
            // btSelApacheDir
            // 
            this.btSelApacheDir.Location = new System.Drawing.Point(650, 12);
            this.btSelApacheDir.Name = "btSelApacheDir";
            this.btSelApacheDir.Size = new System.Drawing.Size(94, 29);
            this.btSelApacheDir.TabIndex = 2;
            this.btSelApacheDir.Text = "...";
            this.btSelApacheDir.UseVisualStyleBackColor = true;
            this.btSelApacheDir.Click += new System.EventHandler(this.btSelApacheDir_Click);
            // 
            // btStartStop
            // 
            this.btStartStop.Location = new System.Drawing.Point(21, 45);
            this.btStartStop.Name = "btStartStop";
            this.btStartStop.Size = new System.Drawing.Size(94, 29);
            this.btStartStop.TabIndex = 3;
            this.btStartStop.Text = "啟動";
            this.btStartStop.UseVisualStyleBackColor = true;
            this.btStartStop.Click += new System.EventHandler(this.btStartStop_Click);
            // 
            // tmAll
            // 
            this.tmAll.Enabled = true;
            this.tmAll.Interval = 5000;
            this.tmAll.Tick += new System.EventHandler(this.tmAll_Tick);
            // 
            // lbIsApacheAlive
            // 
            this.lbIsApacheAlive.AutoSize = true;
            this.lbIsApacheAlive.Location = new System.Drawing.Point(140, 50);
            this.lbIsApacheAlive.Name = "lbIsApacheAlive";
            this.lbIsApacheAlive.Size = new System.Drawing.Size(49, 19);
            this.lbIsApacheAlive.TabIndex = 4;
            this.lbIsApacheAlive.Text = "####";
            // 
            // btEditHosts
            // 
            this.btEditHosts.Location = new System.Drawing.Point(544, 69);
            this.btEditHosts.Name = "btEditHosts";
            this.btEditHosts.Size = new System.Drawing.Size(94, 29);
            this.btEditHosts.TabIndex = 5;
            this.btEditHosts.Text = "編輯 Hosts 檔";
            this.btEditHosts.UseVisualStyleBackColor = true;
            this.btEditHosts.Click += new System.EventHandler(this.btEditHosts_Click);
            // 
            // lvHosts
            // 
            this.lvHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvHosts.FullRowSelect = true;
            this.lvHosts.GridLines = true;
            this.lvHosts.HideSelection = false;
            this.lvHosts.Location = new System.Drawing.Point(25, 69);
            this.lvHosts.Name = "lvHosts";
            this.lvHosts.Size = new System.Drawing.Size(492, 324);
            this.lvHosts.TabIndex = 7;
            this.lvHosts.UseCompatibleStateImageBehavior = false;
            this.lvHosts.View = System.Windows.Forms.View.Details;
            this.lvHosts.SelectedIndexChanged += new System.EventHandler(this.lvHosts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Host";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Copy Lavavel";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Show Home";
            this.columnHeader3.Width = 150;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExit.Location = new System.Drawing.Point(843, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(292, 98);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "關閉";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btStartStopMySql
            // 
            this.btStartStopMySql.Location = new System.Drawing.Point(21, 33);
            this.btStartStopMySql.Name = "btStartStopMySql";
            this.btStartStopMySql.Size = new System.Drawing.Size(94, 29);
            this.btStartStopMySql.TabIndex = 9;
            this.btStartStopMySql.Text = "啟動";
            this.btStartStopMySql.UseVisualStyleBackColor = true;
            this.btStartStopMySql.Click += new System.EventHandler(this.btStartStopMySql_Click);
            // 
            // lbIsMysqlAlive
            // 
            this.lbIsMysqlAlive.AutoSize = true;
            this.lbIsMysqlAlive.Location = new System.Drawing.Point(134, 38);
            this.lbIsMysqlAlive.Name = "lbIsMysqlAlive";
            this.lbIsMysqlAlive.Size = new System.Drawing.Size(49, 19);
            this.lbIsMysqlAlive.TabIndex = 4;
            this.lbIsMysqlAlive.Text = "####";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btStartStop);
            this.groupBox1.Controls.Add(this.lbIsApacheAlive);
            this.groupBox1.Location = new System.Drawing.Point(544, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 109);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apache Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btStartStopMySql);
            this.groupBox2.Controls.Add(this.lbIsMysqlAlive);
            this.groupBox2.Location = new System.Drawing.Point(544, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 97);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MySQL";
            // 
            // btToHtdocs
            // 
            this.btToHtdocs.Location = new System.Drawing.Point(700, 69);
            this.btToHtdocs.Name = "btToHtdocs";
            this.btToHtdocs.Size = new System.Drawing.Size(94, 29);
            this.btToHtdocs.TabIndex = 12;
            this.btToHtdocs.Text = "到 Htdocs";
            this.btToHtdocs.UseVisualStyleBackColor = true;
            this.btToHtdocs.Click += new System.EventHandler(this.btToHtdocs_Click);
            // 
            // btSetMySqlSettings
            // 
            this.btSetMySqlSettings.Location = new System.Drawing.Point(149, 191);
            this.btSetMySqlSettings.Name = "btSetMySqlSettings";
            this.btSetMySqlSettings.Size = new System.Drawing.Size(111, 29);
            this.btSetMySqlSettings.TabIndex = 13;
            this.btSetMySqlSettings.Text = "設定";
            this.btSetMySqlSettings.UseVisualStyleBackColor = true;
            this.btSetMySqlSettings.Click += new System.EventHandler(this.btSetMySqlSettings_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(110, 44);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(167, 27);
            this.txtAccount.TabIndex = 14;
            this.txtAccount.Text = "root";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btSelSqlFile);
            this.groupBox3.Controls.Add(this.btExecute);
            this.groupBox3.Controls.Add(this.txtSqlFile);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDb);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btSetMySqlSettings);
            this.groupBox3.Controls.Add(this.txtAccount);
            this.groupBox3.Location = new System.Drawing.Point(25, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 241);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MySQL 設定";
            // 
            // btSelSqlFile
            // 
            this.btSelSqlFile.Location = new System.Drawing.Point(732, 39);
            this.btSelSqlFile.Name = "btSelSqlFile";
            this.btSelSqlFile.Size = new System.Drawing.Size(59, 29);
            this.btSelSqlFile.TabIndex = 21;
            this.btSelSqlFile.Text = "...";
            this.btSelSqlFile.UseVisualStyleBackColor = true;
            this.btSelSqlFile.Click += new System.EventHandler(this.btSelSqlFile_Click);
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(797, 39);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(85, 29);
            this.btExecute.TabIndex = 20;
            this.btExecute.Text = "執行";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // txtSqlFile
            // 
            this.txtSqlFile.Location = new System.Drawing.Point(384, 41);
            this.txtSqlFile.Name = "txtSqlFile";
            this.txtSqlFile.Size = new System.Drawing.Size(342, 27);
            this.txtSqlFile.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = ".sql 檔";
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(110, 144);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(167, 27);
            this.txtDb.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "資料庫：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 27);
            this.txtPassword.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "密碼：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "帳號：";
            // 
            // ofSelSqlFile
            // 
            this.ofSelSqlFile.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 675);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btToHtdocs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lvHosts);
            this.Controls.Add(this.btEditHosts);
            this.Controls.Add(this.btSelApacheDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApacheDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyAMP";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApacheDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelApacheDir;
        private System.Windows.Forms.FolderBrowserDialog fbApacheDir;
        private System.Windows.Forms.Button btStartStop;
        private System.Windows.Forms.Timer tmAll;
        private System.Windows.Forms.Label lbIsApacheAlive;
        private System.Windows.Forms.Button btEditHosts;        
        private System.Windows.Forms.ListView lvHosts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btStartStopMySql;
        private System.Windows.Forms.Label lbIsMysqlAlive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btToHtdocs;
        private System.Windows.Forms.Button btSetMySqlSettings;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSqlFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Button btSelSqlFile;
        private System.Windows.Forms.OpenFileDialog ofSelSqlFile;
    }
}

