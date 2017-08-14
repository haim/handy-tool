namespace HandyTool
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.btnStartHub = new System.Windows.Forms.Button();
            this.btnStopHub = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartNode = new System.Windows.Forms.Button();
            this.btnStopNode = new System.Windows.Forms.Button();
            this.grpSelenium = new System.Windows.Forms.GroupBox();
            this.grpAndroid = new System.Windows.Forms.GroupBox();
            this.txtAdbDevices = new System.Windows.Forms.TextBox();
            this.btnADBDevices = new System.Windows.Forms.Button();
            this.grpWindows = new System.Windows.Forms.GroupBox();
            this.btnHostsFile = new System.Windows.Forms.Button();
            this.btnAddRemovePrograms = new System.Windows.Forms.Button();
            this.btnEventViewer = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.grpSelenium.SuspendLayout();
            this.grpAndroid.SuspendLayout();
            this.grpWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartHub
            // 
            this.btnStartHub.Location = new System.Drawing.Point(17, 19);
            this.btnStartHub.Name = "btnStartHub";
            this.btnStartHub.Size = new System.Drawing.Size(75, 23);
            this.btnStartHub.TabIndex = 0;
            this.btnStartHub.Text = "Start Hub";
            this.btnStartHub.UseVisualStyleBackColor = true;
            this.btnStartHub.Click += new System.EventHandler(this.btnStartHub_Click);
            // 
            // btnStopHub
            // 
            this.btnStopHub.Enabled = false;
            this.btnStopHub.Location = new System.Drawing.Point(164, 19);
            this.btnStopHub.Name = "btnStopHub";
            this.btnStopHub.Size = new System.Drawing.Size(75, 23);
            this.btnStopHub.TabIndex = 1;
            this.btnStopHub.Text = "Stop Hub";
            this.btnStopHub.UseVisualStyleBackColor = true;
            this.btnStopHub.Click += new System.EventHandler(this.btnStopHub_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(284, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnStartNode
            // 
            this.btnStartNode.Enabled = false;
            this.btnStartNode.Location = new System.Drawing.Point(17, 59);
            this.btnStartNode.Name = "btnStartNode";
            this.btnStartNode.Size = new System.Drawing.Size(75, 23);
            this.btnStartNode.TabIndex = 3;
            this.btnStartNode.Text = "Start Node";
            this.btnStartNode.UseVisualStyleBackColor = true;
            this.btnStartNode.Click += new System.EventHandler(this.btnStartNode_Click);
            // 
            // btnStopNode
            // 
            this.btnStopNode.Enabled = false;
            this.btnStopNode.Location = new System.Drawing.Point(164, 59);
            this.btnStopNode.Name = "btnStopNode";
            this.btnStopNode.Size = new System.Drawing.Size(75, 23);
            this.btnStopNode.TabIndex = 4;
            this.btnStopNode.Text = "Stop Node";
            this.btnStopNode.UseVisualStyleBackColor = true;
            this.btnStopNode.Click += new System.EventHandler(this.btnStopNode_Click);
            // 
            // grpSelenium
            // 
            this.grpSelenium.Controls.Add(this.btnStartHub);
            this.grpSelenium.Controls.Add(this.btnStopNode);
            this.grpSelenium.Controls.Add(this.btnStopHub);
            this.grpSelenium.Controls.Add(this.btnStartNode);
            this.grpSelenium.Location = new System.Drawing.Point(12, 32);
            this.grpSelenium.Name = "grpSelenium";
            this.grpSelenium.Size = new System.Drawing.Size(260, 92);
            this.grpSelenium.TabIndex = 5;
            this.grpSelenium.TabStop = false;
            this.grpSelenium.Text = "Selenium";
            // 
            // grpAndroid
            // 
            this.grpAndroid.Controls.Add(this.txtAdbDevices);
            this.grpAndroid.Controls.Add(this.btnADBDevices);
            this.grpAndroid.Location = new System.Drawing.Point(20, 143);
            this.grpAndroid.Name = "grpAndroid";
            this.grpAndroid.Size = new System.Drawing.Size(252, 118);
            this.grpAndroid.TabIndex = 6;
            this.grpAndroid.TabStop = false;
            this.grpAndroid.Text = "Android";
            // 
            // txtAdbDevices
            // 
            this.txtAdbDevices.Location = new System.Drawing.Point(9, 48);
            this.txtAdbDevices.Multiline = true;
            this.txtAdbDevices.Name = "txtAdbDevices";
            this.txtAdbDevices.ReadOnly = true;
            this.txtAdbDevices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdbDevices.Size = new System.Drawing.Size(237, 64);
            this.txtAdbDevices.TabIndex = 2;
            // 
            // btnADBDevices
            // 
            this.btnADBDevices.Location = new System.Drawing.Point(83, 19);
            this.btnADBDevices.Name = "btnADBDevices";
            this.btnADBDevices.Size = new System.Drawing.Size(75, 23);
            this.btnADBDevices.TabIndex = 0;
            this.btnADBDevices.Text = "adb devices";
            this.btnADBDevices.UseVisualStyleBackColor = true;
            this.btnADBDevices.Click += new System.EventHandler(this.btnADBDevices_Click);
            // 
            // grpWindows
            // 
            this.grpWindows.Controls.Add(this.btnEventViewer);
            this.grpWindows.Controls.Add(this.btnHostsFile);
            this.grpWindows.Controls.Add(this.btnAddRemovePrograms);
            this.grpWindows.Location = new System.Drawing.Point(20, 278);
            this.grpWindows.Name = "grpWindows";
            this.grpWindows.Size = new System.Drawing.Size(252, 138);
            this.grpWindows.TabIndex = 7;
            this.grpWindows.TabStop = false;
            this.grpWindows.Text = "Windows";
            // 
            // btnHostsFile
            // 
            this.btnHostsFile.Location = new System.Drawing.Point(44, 59);
            this.btnHostsFile.Name = "btnHostsFile";
            this.btnHostsFile.Size = new System.Drawing.Size(168, 23);
            this.btnHostsFile.TabIndex = 1;
            this.btnHostsFile.Text = "Open hosts file";
            this.btnHostsFile.UseVisualStyleBackColor = true;
            this.btnHostsFile.Click += new System.EventHandler(this.btnHostsFile_Click);
            // 
            // btnAddRemovePrograms
            // 
            this.btnAddRemovePrograms.Location = new System.Drawing.Point(44, 30);
            this.btnAddRemovePrograms.Name = "btnAddRemovePrograms";
            this.btnAddRemovePrograms.Size = new System.Drawing.Size(168, 23);
            this.btnAddRemovePrograms.TabIndex = 0;
            this.btnAddRemovePrograms.Text = "Open Add/Remove Programs";
            this.btnAddRemovePrograms.UseVisualStyleBackColor = true;
            this.btnAddRemovePrograms.Click += new System.EventHandler(this.btnAddRemovePrograms_Click);
            // 
            // btnEventViewer
            // 
            this.btnEventViewer.Location = new System.Drawing.Point(44, 89);
            this.btnEventViewer.Name = "btnEventViewer";
            this.btnEventViewer.Size = new System.Drawing.Size(168, 23);
            this.btnEventViewer.TabIndex = 2;
            this.btnEventViewer.Text = "Event Viewer";
            this.btnEventViewer.UseVisualStyleBackColor = true;
            this.btnEventViewer.Click += new System.EventHandler(this.btnEventViewer_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 428);
            this.Controls.Add(this.grpWindows);
            this.Controls.Add(this.grpAndroid);
            this.Controls.Add(this.grpSelenium);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "form";
            this.Text = "Handy Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.grpSelenium.ResumeLayout(false);
            this.grpAndroid.ResumeLayout(false);
            this.grpAndroid.PerformLayout();
            this.grpWindows.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartHub;
        private System.Windows.Forms.Button btnStopHub;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStartNode;
        private System.Windows.Forms.Button btnStopNode;
        private System.Windows.Forms.GroupBox grpSelenium;
        private System.Windows.Forms.GroupBox grpAndroid;
        private System.Windows.Forms.Button btnADBDevices;
        private System.Windows.Forms.GroupBox grpWindows;
        private System.Windows.Forms.Button btnAddRemovePrograms;
        private System.Windows.Forms.TextBox txtAdbDevices;
        private System.Windows.Forms.Button btnHostsFile;
        private System.Windows.Forms.Button btnEventViewer;
    }
}

