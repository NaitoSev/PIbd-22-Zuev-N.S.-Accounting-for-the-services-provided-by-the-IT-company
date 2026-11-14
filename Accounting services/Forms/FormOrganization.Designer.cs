#nullable disable

namespace ItServiceAccounting.Forms
{
    partial class FormOrganization
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
            labelInn = new System.Windows.Forms.Label();
            textBoxInn = new System.Windows.Forms.TextBox();
            labelContactPerson = new System.Windows.Forms.Label();
            textBoxContactPerson = new System.Windows.Forms.TextBox();
            labelPhone = new System.Windows.Forms.Label();
            textBoxPhone = new System.Windows.Forms.TextBox();
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
            // labelInn
            labelInn.Name = "labelInn";
            labelInn.AutoSize = true;
            labelInn.Location = new System.Drawing.Point(12, 50);
            labelInn.Text = "ИНН";
            // textBoxInn
            textBoxInn.Name = "textBoxInn";
            textBoxInn.Location = new System.Drawing.Point(150, 47);
            textBoxInn.Size = new System.Drawing.Size(230, 23);
            // labelContactPerson
            labelContactPerson.Name = "labelContactPerson";
            labelContactPerson.AutoSize = true;
            labelContactPerson.Location = new System.Drawing.Point(12, 85);
            labelContactPerson.Text = "Контактное лицо";
            // textBoxContactPerson
            textBoxContactPerson.Name = "textBoxContactPerson";
            textBoxContactPerson.Location = new System.Drawing.Point(150, 82);
            textBoxContactPerson.Size = new System.Drawing.Size(230, 23);
            // labelPhone
            labelPhone.Name = "labelPhone";
            labelPhone.AutoSize = true;
            labelPhone.Location = new System.Drawing.Point(12, 120);
            labelPhone.Text = "Телефон";
            // textBoxPhone
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Location = new System.Drawing.Point(150, 117);
            textBoxPhone.Size = new System.Drawing.Size(230, 23);
            // buttonSave
            buttonSave.Name = "buttonSave";
            buttonSave.Location = new System.Drawing.Point(150, 160);
            buttonSave.Size = new System.Drawing.Size(110, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // buttonCancel
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Location = new System.Drawing.Point(270, 160);
            buttonCancel.Size = new System.Drawing.Size(110, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelInn);
            Controls.Add(textBoxInn);
            Controls.Add(labelContactPerson);
            Controls.Add(textBoxContactPerson);
            Controls.Add(labelPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            // FormOrganization
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 210);
            Text = "Организация";
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
        private System.Windows.Forms.Label labelInn;
        private System.Windows.Forms.TextBox textBoxInn;
        private System.Windows.Forms.Label labelContactPerson;
        private System.Windows.Forms.TextBox textBoxContactPerson;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
