using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extentionerwf
{
    public partial class MainForm : Form
    {
        private string _folderSelection;
        private string _selectedExtension;
        private bool _processingFiles;
        private bool _cancelling;

        public MainForm()
        {
            InitializeComponent();
        }

        private string FolderSelection {
            get
            {
                return _folderSelection;
            }
            set {
                _folderSelection = value;
                CalculateUiState();
            }
        }

        private bool ProcessingFiles {
            get
            {
                return _processingFiles;
            }
            set
            {
                _processingFiles = value;
                CalculateUiState();
            }
        }

        private string SelectedExtension
        {
            get
            {
                return _selectedExtension;
            }
            set
            {
                _selectedExtension = value;
                CalculateUiState();
            }
        }

        private bool SelectedFolderExists
        {
            get
            {
                return !string.IsNullOrWhiteSpace(FolderSelection) && System.IO.Directory.Exists(FolderSelection); 
            }
        }

        private bool Cancelling
        {
            get
            {
                return _cancelling;
            }
            set
            {
                _cancelling = value;
                CalculateUiState();
            }
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            listBoxProgress.Items.Clear();
            ProcessingFiles = true;
            extensionChangerWorker.RunWorkerAsync();
        }

        private void CalculateUiState()
        {
            buttonGo.Enabled = SelectedFolderExists && !ProcessingFiles;
            buttonSelectFolder.Enabled = !ProcessingFiles;
            textBoxFolderPathDisplay.Text = FolderSelection;
            buttonCancel.Enabled = ProcessingFiles;
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderPicker.ShowDialog();
            FolderSelection = folderPicker.SelectedPath;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
        }

        private void textBoxExtension_TextChanged(object sender, EventArgs e)
        {
            SelectedExtension = textBoxExtension.Text;
        }

        private void extensionChangerWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var exists = !string.IsNullOrWhiteSpace(FolderSelection) && System.IO.Directory.Exists(FolderSelection);
            if (!exists) throw new ArgumentException($"Path \"{FolderSelection}\" doesn't exist.");
            foreach (var f in System.IO.Directory.GetFiles(FolderSelection))
            {
                var newF = System.IO.Path.ChangeExtension(f, SelectedExtension);
                System.IO.File.Move(f, newF);
                extensionChangerWorker.ReportProgress(0, new FileProgress(f, newF));
            }
        }

        private void extensionChangerWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var fp = (FileProgress) e.UserState;
            listBoxProgress.Items.Add($"{fp.Before} to {fp.After}");
        }

        private class FileProgress
        {   
            public FileProgress(string before, string after)
            {
                Before = before;
                After = after;
            }
            public string Before { get; }
            public string After { get; }
        }

        private void extensionChangerWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cancelling = false;
            ProcessingFiles = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancelling = true;
            extensionChangerWorker.CancelAsync();
        }
    }
}
