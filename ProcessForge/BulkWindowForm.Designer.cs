namespace ProcessForge
{
    partial class BulkWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkWindowForm));
            label1 = new Label();
            label2 = new Label();
            OpenBulkWindow = new Button();
            FlowLayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            FilePathName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            TestGenerate = new Button();
            TestGenerate2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 1;
            label1.Text = "Process List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 594);
            label2.Name = "label2";
            label2.Size = new Size(89, 42);
            label2.TabIndex = 2;
            label2.Text = "Text Import\r\nCheck";
            // 
            // OpenBulkWindow
            // 
            OpenBulkWindow.BackColor = SystemColors.Desktop;
            OpenBulkWindow.Font = new Font("Segoe UI Symbol", 9F);
            OpenBulkWindow.ForeColor = Color.White;
            OpenBulkWindow.Location = new Point(666, 11);
            OpenBulkWindow.Name = "OpenBulkWindow";
            OpenBulkWindow.Size = new Size(122, 32);
            OpenBulkWindow.TabIndex = 48;
            OpenBulkWindow.Text = "Refresh";
            OpenBulkWindow.UseVisualStyleBackColor = false;
            OpenBulkWindow.Click += OpenBulkWindow_Click;
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.AutoScroll = true;
            FlowLayoutPanel.Location = new Point(12, 68);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Size = new Size(776, 448);
            FlowLayoutPanel.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 10);
            panel1.TabIndex = 50;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(12, 522);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 10);
            panel2.TabIndex = 51;
            // 
            // FilePathName
            // 
            FilePathName.BackColor = SystemColors.Desktop;
            FilePathName.Font = new Font("Segoe UI Symbol", 9F);
            FilePathName.ForeColor = Color.White;
            FilePathName.Location = new Point(359, 12);
            FilePathName.Name = "FilePathName";
            FilePathName.Size = new Size(173, 31);
            FilePathName.TabIndex = 52;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Segoe UI Symbol", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(538, 11);
            button1.Name = "button1";
            button1.Size = new Size(122, 32);
            button1.TabIndex = 53;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Desktop;
            button2.Font = new Font("Segoe UI Symbol", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(245, 538);
            button2.Name = "button2";
            button2.Size = new Size(103, 32);
            button2.TabIndex = 54;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Desktop;
            button3.Font = new Font("Segoe UI Symbol", 9F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(456, 538);
            button3.Name = "button3";
            button3.Size = new Size(103, 32);
            button3.TabIndex = 55;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(372, 539);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 56;
            label3.Text = "??/??";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Desktop;
            textBox1.Font = new Font("Segoe UI Symbol", 9F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(234, 599);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 31);
            textBox1.TabIndex = 57;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Desktop;
            button4.Font = new Font("Segoe UI Symbol", 9F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(328, 599);
            button4.Name = "button4";
            button4.Size = new Size(105, 32);
            button4.TabIndex = 58;
            button4.Text = "Browse";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Desktop;
            button5.Font = new Font("Segoe UI Symbol", 9F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(142, 598);
            button5.Name = "button5";
            button5.Size = new Size(86, 32);
            button5.TabIndex = 59;
            button5.Text = "Check";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(107, 601);
            panel3.Name = "panel3";
            panel3.Size = new Size(29, 26);
            panel3.TabIndex = 42;
            // 
            // TestGenerate
            // 
            TestGenerate.BackColor = SystemColors.Desktop;
            TestGenerate.Font = new Font("Segoe UI Symbol", 9F);
            TestGenerate.ForeColor = Color.White;
            TestGenerate.Location = new Point(139, 12);
            TestGenerate.Name = "TestGenerate";
            TestGenerate.Size = new Size(106, 32);
            TestGenerate.TabIndex = 60;
            TestGenerate.Text = "Generate";
            TestGenerate.UseVisualStyleBackColor = false;
            TestGenerate.Click += TestGenerate_Click;
            // 
            // TestGenerate2
            // 
            TestGenerate2.BackColor = SystemColors.Desktop;
            TestGenerate2.Font = new Font("Segoe UI Symbol", 9F);
            TestGenerate2.ForeColor = Color.White;
            TestGenerate2.Location = new Point(247, 12);
            TestGenerate2.Name = "TestGenerate2";
            TestGenerate2.Size = new Size(106, 32);
            TestGenerate2.TabIndex = 61;
            TestGenerate2.Text = "Generate2";
            TestGenerate2.UseVisualStyleBackColor = false;
            TestGenerate2.Click += TestGenerate2_Click;
            // 
            // BulkWindowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 645);
            Controls.Add(TestGenerate2);
            Controls.Add(TestGenerate);
            Controls.Add(panel3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(FilePathName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(FlowLayoutPanel);
            Controls.Add(OpenBulkWindow);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BulkWindowForm";
            Text = "App Handler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button OpenBulkWindow;
        private FlowLayoutPanel FlowLayoutPanel;
        private Panel panel1;
        private Panel panel2;
        private TextBox FilePathName;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private Panel panel3;
        private Button TestGenerate;
        private Button TestGenerate2;
    }
}