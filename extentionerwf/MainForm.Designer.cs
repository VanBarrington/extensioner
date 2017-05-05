namespace extentionerwf
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.folderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFolderPathDisplay = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(7, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 32);
            label1.TabIndex = 0;
            label1.Text = "Folder:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(7, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 30);
            label2.TabIndex = 1;
            label2.Text = "Extension:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxExtension, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonGo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonGo, 2);
            this.buttonGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGo.Enabled = false;
            this.buttonGo.Location = new System.Drawing.Point(7, 348);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(685, 26);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtension.Location = new System.Drawing.Point(69, 39);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(623, 20);
            this.textBoxExtension.TabIndex = 3;
            this.textBoxExtension.TextChanged += new System.EventHandler(this.textBoxExtension_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxFolderPathDisplay, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSelectFolder, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(69, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 26);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // textBoxFolderPathDisplay
            // 
            this.textBoxFolderPathDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFolderPathDisplay.Location = new System.Drawing.Point(3, 3);
            this.textBoxFolderPathDisplay.Name = "textBoxFolderPathDisplay";
            this.textBoxFolderPathDisplay.ReadOnly = true;
            this.textBoxFolderPathDisplay.Size = new System.Drawing.Size(509, 20);
            this.textBoxFolderPathDisplay.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectFolder.Location = new System.Drawing.Point(518, 3);
            this.buttonSelectFolder.MaximumSize = new System.Drawing.Size(0, 24);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(102, 20);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(623, 273);
            this.listBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "extenioner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.FolderBrowserDialog folderPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxFolderPathDisplay;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.ListBox listBox1;
    }
}

