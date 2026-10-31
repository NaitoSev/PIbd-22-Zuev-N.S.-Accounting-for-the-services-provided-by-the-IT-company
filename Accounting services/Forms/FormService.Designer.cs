#nullable disable

namespace ItServiceAccounting.Forms
{
    partial class FormService
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
            labelName = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            labelCategory = new System.Windows.Forms.Label();
            checkedListBoxServiceCategory = new System.Windows.Forms.CheckedListBox();
            labelDescription = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // labelName
            labelName.Name = "labelName";
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(12, 15);
            labelName.Text = "Название";
            // textBoxName
            textBoxName.Name = "textBoxName";
            textBoxName.Location = new System.Drawing.Point(150, 12);
            textBoxName.Size = new System.Drawing.Size(230, 23);
            // labelCategory
            labelCategory.Name = "labelCategory";
            labelCategory.AutoSize = true;
            labelCategory.Location = new System.Drawing.Point(12, 50);
            labelCategory.Text = "Категория";
            // checkedListBoxServiceCategory
            checkedListBoxServiceCategory.Name = "checkedListBoxServiceCategory";
            checkedListBoxServiceCategory.Location = new System.Drawing.Point(150, 47);
            checkedListBoxServiceCategory.Size = new System.Drawing.Size(230, 80);
            checkedListBoxServiceCategory.CheckOnClick = true;
            // labelDescription
            labelDescription.Name = "labelDescription";
            labelDescription.AutoSize = true;
            labelDescription.Location = new System.Drawing.Point(12, 143);
            labelDescription.Text = "Описание";
            // textBoxDescription
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Location = new System.Drawing.Point(150, 140);
            textBoxDescription.Size = new System.Drawing.Size(230, 70);
            textBoxDescription.Multiline = true;
            // buttonSave
            buttonSave.Name = "buttonSave";
            buttonSave.Location = new System.Drawing.Point(150, 225);
            buttonSave.Size = new System.Drawing.Size(110, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // buttonCancel
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Location = new System.Drawing.Point(270, 225);
            buttonCancel.Size = new System.Drawing.Size(110, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelCategory);
            Controls.Add(checkedListBoxServiceCategory);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            // FormService
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 275);
            Text = "Услуга";
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

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.CheckedListBox checkedListBoxServiceCategory;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
