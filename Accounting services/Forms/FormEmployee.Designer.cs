#nullable disable

namespace ItServiceAccounting.Forms
{
    partial class FormEmployee
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelFirstName = new System.Windows.Forms.Label();
            textBoxFirstName = new System.Windows.Forms.TextBox();
            labelLastName = new System.Windows.Forms.Label();
            textBoxLastName = new System.Windows.Forms.TextBox();
            labelPost = new System.Windows.Forms.Label();
            comboBoxPost = new System.Windows.Forms.ComboBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // labelFirstName
            labelFirstName.Name = "labelFirstName";
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new System.Drawing.Point(12, 15);
            labelFirstName.Text = "Имя";
            // textBoxFirstName
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Location = new System.Drawing.Point(150, 12);
            textBoxFirstName.Size = new System.Drawing.Size(230, 23);
            // labelLastName
            labelLastName.Name = "labelLastName";
            labelLastName.AutoSize = true;
            labelLastName.Location = new System.Drawing.Point(12, 50);
            labelLastName.Text = "Фамилия";
            // textBoxLastName
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Location = new System.Drawing.Point(150, 47);
            textBoxLastName.Size = new System.Drawing.Size(230, 23);
            // labelPost
            labelPost.Name = "labelPost";
            labelPost.AutoSize = true;
            labelPost.Location = new System.Drawing.Point(12, 85);
            labelPost.Text = "Должность";
            // comboBoxPost
            comboBoxPost.Name = "comboBoxPost";
            comboBoxPost.Location = new System.Drawing.Point(150, 82);
            comboBoxPost.Size = new System.Drawing.Size(230, 23);
            comboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // buttonSave
            buttonSave.Name = "buttonSave";
            buttonSave.Location = new System.Drawing.Point(150, 125);
            buttonSave.Size = new System.Drawing.Size(110, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // buttonCancel
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Location = new System.Drawing.Point(270, 125);
            buttonCancel.Size = new System.Drawing.Size(110, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            Controls.Add(labelFirstName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelPost);
            Controls.Add(comboBoxPost);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            // FormEmployee
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 175);
            Text = "Сотрудник";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            buttonSave.Click += ButtonSave_Click;
            buttonCancel.Click += ButtonCancel_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
