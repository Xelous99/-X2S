namespace IDE_X2S
{
    partial class Home
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
            this.BTN_openProj = new System.Windows.Forms.Button();
            this.BTN_newProj = new System.Windows.Forms.Button();
            this.codeWIndow = new System.Windows.Forms.RichTextBox();
            this.fileBrowser = new System.Windows.Forms.TreeView();
            this.consoleWindow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTN_openProj
            // 
            this.BTN_openProj.Location = new System.Drawing.Point(12, 12);
            this.BTN_openProj.Name = "BTN_openProj";
            this.BTN_openProj.Size = new System.Drawing.Size(135, 46);
            this.BTN_openProj.TabIndex = 0;
            this.BTN_openProj.Text = "Open";
            this.BTN_openProj.UseVisualStyleBackColor = true;
            this.BTN_openProj.Click += new System.EventHandler(this.BTN_openProj_Click);
            // 
            // BTN_newProj
            // 
            this.BTN_newProj.Location = new System.Drawing.Point(153, 12);
            this.BTN_newProj.Name = "BTN_newProj";
            this.BTN_newProj.Size = new System.Drawing.Size(124, 46);
            this.BTN_newProj.TabIndex = 1;
            this.BTN_newProj.Text = "New";
            this.BTN_newProj.UseVisualStyleBackColor = true;
            this.BTN_newProj.Click += new System.EventHandler(this.BTN_newProj_Click);
            // 
            // codeWIndow
            // 
            this.codeWIndow.Location = new System.Drawing.Point(12, 64);
            this.codeWIndow.Name = "codeWIndow";
            this.codeWIndow.Size = new System.Drawing.Size(890, 457);
            this.codeWIndow.TabIndex = 2;
            this.codeWIndow.Text = "";
            this.codeWIndow.TextChanged += new System.EventHandler(this.codeWIndow_TextChanged);
            // 
            // fileBrowser
            // 
            this.fileBrowser.Location = new System.Drawing.Point(933, 64);
            this.fileBrowser.Name = "fileBrowser";
            this.fileBrowser.Size = new System.Drawing.Size(200, 457);
            this.fileBrowser.TabIndex = 3;
            this.fileBrowser.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.fileBrowser_AfterSelect);
            // 
            // consoleWindow
            // 
            this.consoleWindow.Location = new System.Drawing.Point(12, 527);
            this.consoleWindow.Name = "consoleWindow";
            this.consoleWindow.Size = new System.Drawing.Size(890, 134);
            this.consoleWindow.TabIndex = 4;
            this.consoleWindow.Text = "";
            this.consoleWindow.TextChanged += new System.EventHandler(this.consoleWindow_TextChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 697);
            this.Controls.Add(this.consoleWindow);
            this.Controls.Add(this.fileBrowser);
            this.Controls.Add(this.codeWIndow);
            this.Controls.Add(this.BTN_newProj);
            this.Controls.Add(this.BTN_openProj);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_openProj;
        private System.Windows.Forms.Button BTN_newProj;
        private System.Windows.Forms.RichTextBox codeWIndow;
        private System.Windows.Forms.TreeView fileBrowser;
        private System.Windows.Forms.RichTextBox consoleWindow;
    }
}