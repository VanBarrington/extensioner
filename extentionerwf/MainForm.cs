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

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(ExtensionSetter extensionSetter) : this()
        {
            ExtensionSetter = extensionSetter;
        }        

        private ExtensionSetter ExtensionSetter { get; }

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

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            foreach (var f in ExtensionSetter.Set(FolderSelection, SelectedExtension))
            {
                listBox1.Items.Add(f);
            }
        }

        private void CalculateUiState()
        {
            buttonGo.Enabled = SelectedFolderExists;
            textBoxFolderPathDisplay.Text = FolderSelection;
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
    }
}
