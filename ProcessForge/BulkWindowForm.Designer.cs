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
            ProcessListLabel = new Label();
            label2 = new Label();
            RefreshButton = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            FilePathName = new TextBox();
            button1 = new Button();
            PreviousButton = new Button();
            NextButton = new Button();
            LabelPage = new Label();
            ImportTextbox = new TextBox();
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            button6 = new Button();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // ProcessListLabel
            // 
            ProcessListLabel.AutoSize = true;
            ProcessListLabel.Font = new Font("Segoe UI Symbol", 12F);
            ProcessListLabel.ForeColor = Color.White;
            ProcessListLabel.Location = new Point(12, 9);
            ProcessListLabel.Name = "ProcessListLabel";
            ProcessListLabel.Size = new Size(135, 32);
            ProcessListLabel.TabIndex = 1;
            ProcessListLabel.Text = "Process List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(210, 28);
            label2.TabIndex = 2;
            label2.Text = "Using Notepad Import";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = SystemColors.Desktop;
            RefreshButton.Font = new Font("Segoe UI Symbol", 9F);
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(682, 11);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(105, 32);
            RefreshButton.TabIndex = 48;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(11, 118);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(776, 507);
            flowLayoutPanel.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(11, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 10);
            panel1.TabIndex = 50;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(11, 631);
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
            FilePathName.Size = new Size(230, 31);
            FilePathName.TabIndex = 52;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Segoe UI Symbol", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(595, 11);
            button1.Name = "button1";
            button1.Size = new Size(83, 32);
            button1.TabIndex = 53;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = false;
            // 
            // PreviousButton
            // 
            PreviousButton.BackColor = SystemColors.Desktop;
            PreviousButton.Font = new Font("Segoe UI Symbol", 9F);
            PreviousButton.ForeColor = Color.White;
            PreviousButton.Location = new Point(244, 647);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(103, 32);
            PreviousButton.TabIndex = 54;
            PreviousButton.Text = "Previous";
            PreviousButton.UseVisualStyleBackColor = false;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = SystemColors.Desktop;
            NextButton.Font = new Font("Segoe UI Symbol", 9F);
            NextButton.ForeColor = Color.White;
            NextButton.Location = new Point(455, 647);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(103, 32);
            NextButton.TabIndex = 55;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // LabelPage
            // 
            LabelPage.AutoSize = true;
            LabelPage.Font = new Font("Segoe UI", 10F);
            LabelPage.ForeColor = Color.White;
            LabelPage.Location = new Point(371, 648);
            LabelPage.Name = "LabelPage";
            LabelPage.Size = new Size(56, 28);
            LabelPage.TabIndex = 56;
            LabelPage.Text = "??/??";
            // 
            // ImportTextbox
            // 
            ImportTextbox.BackColor = SystemColors.Desktop;
            ImportTextbox.Font = new Font("Segoe UI Symbol", 9F);
            ImportTextbox.ForeColor = Color.White;
            ImportTextbox.Location = new Point(443, 68);
            ImportTextbox.Name = "ImportTextbox";
            ImportTextbox.Size = new Size(233, 31);
            ImportTextbox.TabIndex = 57;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Desktop;
            button4.Font = new Font("Segoe UI Symbol", 9F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(682, 67);
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
            button5.Location = new Point(351, 67);
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
            panel3.Location = new Point(224, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(29, 26);
            panel3.TabIndex = 42;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Desktop;
            button6.Font = new Font("Segoe UI Symbol", 9F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(259, 67);
            button6.Name = "button6";
            button6.Size = new Size(86, 32);
            button6.TabIndex = 62;
            button6.Text = "On";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(11, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(775, 10);
            panel4.TabIndex = 51;
            // 
            // BulkWindowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 691);
            Controls.Add(panel4);
            Controls.Add(button6);
            Controls.Add(panel3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(ImportTextbox);
            Controls.Add(LabelPage);
            Controls.Add(PreviousButton);
            Controls.Add(NextButton);
            Controls.Add(button1);
            Controls.Add(FilePathName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel);
            Controls.Add(RefreshButton);
            Controls.Add(label2);
            Controls.Add(ProcessListLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BulkWindowForm";
            Text = "App Handler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProcessListLabel;
        private Label label2;
        private Button RefreshButton;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel panel1;
        private Panel panel2;
        private TextBox FilePathName;
        private Button button1;
        private Button PreviousButton;
        private Button NextButton;
        private Label LabelPage;
        private TextBox ImportTextbox;
        private Button button4;
        private Button button5;
        private Panel panel3;
        private Button button6;
        private Panel panel4;
    }
}