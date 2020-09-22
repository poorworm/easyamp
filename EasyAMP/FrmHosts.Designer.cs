namespace EasyAMP
{
    partial class FrmHosts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(24, 57);
            this.lvList.MultiSelect = false;
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(506, 343);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HostName";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 200;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(567, 22);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 29);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "新增";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(567, 57);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(94, 29);
            this.btRemove.TabIndex = 1;
            this.btRemove.Text = "移除";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(567, 115);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 29);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "儲存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(24, 24);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.PlaceholderText = "輸入 Host Name";
            this.txtHostName.Size = new System.Drawing.Size(300, 27);
            this.txtHostName.TabIndex = 3;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(330, 24);
            this.txtIP.Name = "txtIP";
            this.txtIP.PlaceholderText = "輸入 IP";
            this.txtIP.Size = new System.Drawing.Size(200, 27);
            this.txtIP.TabIndex = 4;
            this.txtIP.Text = "127.0.0.1";
            // 
            // FrmHosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 415);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lvList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHosts";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "對應伺服器名稱";
            this.Load += new System.EventHandler(this.FrmHosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtIP;
    }
}