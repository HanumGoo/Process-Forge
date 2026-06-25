using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ProcessForge.RefreshLogic;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessForge
{
    public partial class BulkWindowForm : Form
    {
        //check import status
        bool isUsingImport = false;
        string ProcessName = string.Empty;

        //page
        int PageCount = 1;

        public BulkWindowForm(string processName)
        {
            InitializeComponent();
            ProcessName = processName;
            FormStartup();
            RefreshFunction();
        }
        public void FormStartup()
        {
            ProcessListLabel.Text = !string.IsNullOrEmpty(ProcessName) ? $"Process List ({ProcessName})" : "Process List (None)";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshFunction();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (PageCount == 1)
            {
                return;
            }
            PageCount -= 1;
            RefreshFunction();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName(ProcessName).Length < PageCount * 100)
            {
                return;
            }
            PageCount += 1;
            RefreshFunction();
        }
            private void RefreshFunction()
            {
                if (string.IsNullOrEmpty(ProcessName))
                {
                    MessageBox.Show("please add process name first at the main form", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Process[] AllProcess = Process.GetProcessesByName(ProcessName);
                List<string> ProcessTitle = new List<string>();

                foreach (Process item in AllProcess)
                {
                    if (string.IsNullOrEmpty(item.MainWindowTitle))
                    {
                        
                    }
                    else
                    {
                        ProcessTitle.Add(item.MainWindowTitle);
                    }
                    
                }

                if (!isUsingImport)
                {
                    RefreshLogic.RefreshLogic.Refresh(flowLayoutPanel, LabelPage, PageCount, ProcessTitle);
                }
                else
                {
                    string path = ImportTextbox.Text;

                    if (!File.Exists(path) || string.IsNullOrEmpty(path))
                    {
                        MessageBox.Show("Error! : the path isnt right or you didn't add one.", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string[] AllData = File.ReadAllText(path).Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    List<List<string>> AllDataImport = new List<List<string>>
                    {
                        new List<string>(),
                        new List<string>()
                    };


                    foreach (string item in AllData)
                    {
                        string[] TitleAndStatus = item.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                        if (TitleAndStatus.Length != 2)
                        {
                            MessageBox.Show("Import Data error! please check this one: \n" + item, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        AllDataImport[0].Add(TitleAndStatus[0]);
                        AllDataImport[1].Add(TitleAndStatus[1]);
                    }

                    RefreshLogic.RefreshLogic.RefreshWIthNotepadCheck(flowLayoutPanel, LabelPage, PageCount, ProcessTitle, AllDataImport);
                }
            }
    }
}
