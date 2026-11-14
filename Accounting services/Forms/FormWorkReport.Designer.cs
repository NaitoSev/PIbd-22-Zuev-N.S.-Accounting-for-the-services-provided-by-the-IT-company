#nullable disable

namespace ItServiceAccounting.Forms
{
    partial class FormWorkReport
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
            labelContract = new System.Windows.Forms.Label();
            comboBoxContract = new System.Windows.Forms.ComboBox();
            labelEmployee = new System.Windows.Forms.Label();
            comboBoxEmployee = new System.Windows.Forms.ComboBox();
            labelDate = new System.Windows.Forms.Label();
            dateTimePickerReport = new System.Windows.Forms.DateTimePicker();
            labelPercent = new System.Windows.Forms.Label();
            numericUpDownPercent = new System.Windows.Forms.NumericUpDown();
            labelDescription = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // labelContract
            labelContract.Name = "labelContract";
            labelContract.AutoSize = true;
            labelContract.Location = new System.Drawing.Point(12, 15);
            labelContract.Text = "Договор";
            // comboBoxContract
            comboBoxContract.Name = "comboBoxContract";
            comboBoxContract.Location = new System.Drawing.Point(150, 12);
            comboBoxContract.Size = new System.Drawing.Size(230, 23);
            comboBoxContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // labelEmployee
            labelEmployee.Name = "labelEmployee";
            labelEmployee.AutoSize = true;
            labelEmployee.Location = new System.Drawing.Point(12, 50);
            labelEmployee.Text = "Исполнитель";
            // comboBoxEmployee
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Location = new System.Drawing.Point(150, 47);
            comboBoxEmployee.Size = new System.Drawing.Size(230, 23);
            comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // labelDate
            labelDate.Name = "labelDate";
            labelDate.AutoSize = true;
            labelDate.Location = new System.Drawing.Point(12, 85);
            labelDate.Text = "Дата";
            // dateTimePickerReport
            dateTimePickerReport.Name = "dateTimePickerReport";
            dateTimePickerReport.Location = new System.Drawing.Point(150, 82);
            dateTimePickerReport.Size = new System.Drawing.Size(230, 23);
            dateTimePickerReport.Enabled = false;
            // labelPercent
            labelPercent.Name = "labelPercent";
            labelPercent.AutoSize = true;
            labelPercent.Location = new System.Drawing.Point(12, 120);
            labelPercent.Text = "Выполнено, %";
            // numericUpDownPercent
            numericUpDownPercent.Name = "numericUpDownPercent";
            numericUpDownPercent.Location = new System.Drawing.Point(150, 117);
            numericUpDownPercent.Size = new System.Drawing.Size(120, 23);
            numericUpDownPercent.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            // labelDescription
            labelDescription.Name = "labelDescription";
            labelDescription.AutoSize = true;
            labelDescription.Location = new System.Drawing.Point(12, 155);
            labelDescription.Text = "Описание";
            // textBoxDescription
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Location = new System.Drawing.Point(150, 152);
            textBoxDescription.Size = new System.Drawing.Size(230, 70);
            textBoxDescription.Multiline = true;
            // buttonSave
            buttonSave.Name = "buttonSave";
            buttonSave.Location = new System.Drawing.Point(150, 235);
            buttonSave.Size = new System.Drawing.Size(110, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // buttonCancel
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Location = new System.Drawing.Point(270, 235);
            buttonCancel.Size = new System.Drawing.Size(110, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            Controls.Add(labelContract);
            Controls.Add(comboBoxContract);
            Controls.Add(labelEmployee);
            Controls.Add(comboBoxEmployee);
            Controls.Add(labelDate);
            Controls.Add(dateTimePickerReport);
            Controls.Add(labelPercent);
            Controls.Add(numericUpDownPercent);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            // FormWorkReport
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 285);
            Text = "Отчет о выполнении работ";
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

        private System.Windows.Forms.Label labelContract;
        private System.Windows.Forms.ComboBox comboBoxContract;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReport;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.NumericUpDown numericUpDownPercent;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
