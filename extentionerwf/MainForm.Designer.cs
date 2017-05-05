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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFolderPathDisplay = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.listBoxProgress = new System.Windows.Forms.ListBox();
            this.folderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.extensionChangerWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(10, 6);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 49);
            label1.TabIndex = 0;
            label1.Text = "Folder:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(10, 55);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 46);
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
            this.tableLayoutPanel1.Controls.Add(this.textBoxExtension, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxProgress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonGo
            // 
            this.buttonGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGo.Enabled = false;
            this.buttonGo.Location = new System.Drawing.Point(4, 5);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(507, 33);
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
            this.textBoxExtension.Location = new System.Drawing.Point(101, 60);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(937, 26);
            this.textBoxExtension.TabIndex = 3;
            this.textBoxExtension.TextChanged += new System.EventHandler(this.textBoxExtension_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxFolderPathDisplay, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSelectFolder, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(101, 11);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(937, 39);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // textBoxFolderPathDisplay
            // 
            this.textBoxFolderPathDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFolderPathDisplay.Location = new System.Drawing.Point(4, 5);
            this.textBoxFolderPathDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFolderPathDisplay.Name = "textBoxFolderPathDisplay";
            this.textBoxFolderPathDisplay.ReadOnly = true;
            this.textBoxFolderPathDisplay.Size = new System.Drawing.Size(767, 26);
            this.textBoxFolderPathDisplay.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectFolder.Location = new System.Drawing.Point(779, 5);
            this.buttonSelectFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSelectFolder.MaximumSize = new System.Drawing.Size(0, 37);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(154, 29);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // listBoxProgress
            // 
            this.listBoxProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProgress.FormattingEnabled = true;
            this.listBoxProgress.HorizontalScrollbar = true;
            this.listBoxProgress.ItemHeight = 20;
            this.listBoxProgress.Location = new System.Drawing.Point(101, 106);
            this.listBoxProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxProgress.Name = "listBoxProgress";
            this.listBoxProgress.Size = new System.Drawing.Size(937, 420);
            this.listBoxProgress.TabIndex = 5;
            // 
            // extensionChangerWorker
            // 
            this.extensionChangerWorker.WorkerReportsProgress = true;
            this.extensionChangerWorker.WorkerSupportsCancellation = true;
            this.extensionChangerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.extensionChangerWorker_DoWork);
            this.extensionChangerWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.extensionChangerWorker_ProgressChanged);
            this.extensionChangerWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.extensionChangerWorker_RunWorkerCompleted);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonGo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 534);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1030, 43);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(518, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(509, 37);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "extenioner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBoxProgress;
        private System.ComponentModel.BackgroundWorker extensionChangerWorker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonCancel;
    }
}

