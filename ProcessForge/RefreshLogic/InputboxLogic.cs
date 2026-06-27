using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessForge.RefreshLogic
{
    public static class InputBox
    {
        public static string[]? Show(string text, string title, bool isMultiLine, string defaultValue = "")
        {
            Form form = new Form();
            Label lblText = new Label();
            TextBox txtInput = new TextBox();
            Button btnOk = new Button();
            Button btnCancel = new Button();

            form.Text = title;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ClientSize = new Size(360, 130);
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowInTaskbar = false;
            form.AcceptButton = btnOk;
            form.CancelButton = btnCancel;
            form.BackColor = SystemColors.Desktop;

            lblText.Text = text;
            lblText.Location = new Point(12, 12);
            lblText.AutoSize = true;
            lblText.ForeColor = Color.White;

            txtInput.Location = new Point(15, 38);
            txtInput.Size = new Size(330, 23);
            txtInput.Text = defaultValue;
            txtInput.ForeColor = Color.Black;

            btnOk.Text = "OK";
            btnOk.Size = new Size(80, 30);
            btnOk.Location = new Point(175, 80);
            btnOk.DialogResult = DialogResult.OK;
            btnOk.ForeColor = Color.White;

            btnCancel.Text = "Cancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.Location = new Point(265, 80);
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.ForeColor = Color.White;

            if (isMultiLine)
            {
                form.ClientSize = new Size(420, 260);

                txtInput.Multiline = true;
                txtInput.ScrollBars = ScrollBars.Vertical;
                txtInput.AcceptsReturn = true;
                txtInput.AcceptsTab = true;

                txtInput.Location = new Point(15, 40);
                txtInput.Size = new Size(390, 160);

                btnOk.Location = new Point(240, 215);
                btnCancel.Location = new Point(325, 215);
            }
            else
            {
                form.ClientSize = new Size(360, 130);

                txtInput.Multiline = false;
                txtInput.Location = new Point(15, 38);
                txtInput.Size = new Size(330, 23);

                btnOk.Location = new Point(175, 80);
                btnCancel.Location = new Point(265, 80);
            }

            form.Controls.Add(lblText);
            form.Controls.Add(txtInput);
            form.Controls.Add(btnOk);
            form.Controls.Add(btnCancel);

            if (form.ShowDialog() == DialogResult.OK)
                return txtInput.Text.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries); ;

            return null;
        }
    }
}
