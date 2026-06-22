using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcessForge
{
    public partial class BulkWindowForm : Form
    {
        public BulkWindowForm()
        {
            InitializeComponent();
        }

        private void OpenBulkWindow_Click(object sender, EventArgs e)
        {

        }

        private void TestGenerate_Click(object sender, EventArgs e)
        {
            //FlowLayoutPanel.Controls.Clear();
            List<string> _savedApps = new List<string>
            {
                "app1",
                "app2",
                "app3"
            };

            foreach (var item in _savedApps)
            {
                Button btn = new Button();

                btn.Text = item;
                //btn.Tag = item;

                //btn.Click += Button_Click;

                FlowLayoutPanel.Controls.Add(btn);
            }
        }

        private void TestGenerate2_Click(object sender, EventArgs e)
        {
            //FlowLayoutPanel.Controls.Clear();
            List<string> _savedApps = new List<string>
            {
                "app1",
                "app2",
                "app3"
            };

            foreach (var item in _savedApps)
            {
                Button btn = new Button();

                btn.Text = item;
                btn.Margin = new Padding(5, 5, 5, 5);
                btn.Size = new Size(135, 40);
                btn.Width = FlowLayoutPanel.Width - 300;
                btn.Font = new Font("Segoe UI Symbol", 9F);
                btn.ForeColor = Color.White;

                Button btn2 = new Button(); 
                btn2.Text = item;
                btn2.Margin = new Padding(5, 5, 5, 5);
                btn2.Size = new Size(135, 40);
                btn2.Width = FlowLayoutPanel.Width - 550;
                btn2.Font = new Font("Segoe UI Symbol", 9F);
                btn2.ForeColor = Color.White;
                //btn.Tag = item;

                //btn.Click += Button_Click;

                FlowLayoutPanel.Controls.Add(btn);
                FlowLayoutPanel.Controls.Add(btn2);
            }
        }
    }
}
