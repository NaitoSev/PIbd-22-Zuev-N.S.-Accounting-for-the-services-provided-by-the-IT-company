#nullable disable

namespace ItServiceAccounting.Forms
{
    partial class FormContract
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
            labelNumber = new System.Windows.Forms.Label();
            textBoxNumber = new System.Windows.Forms.TextBox();
            labelOrganization = new System.Windows.Forms.Label();
            comboBoxOrganization = new System.Windows.Forms.ComboBox();
            labelEmployee = new System.Windows.Forms.Label();
            comboBoxEmployee = new System.Windows.Forms.ComboBox();
            labelDate = new System.Windows.Forms.Label();
            dateTimePickerSigning = new System.Windows.Forms.DateTimePicker();
            groupBoxServices = new System.Windows.Forms.GroupBox();
            dataGridViewServices = new System.Windows.Forms.DataGridView();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            ColumnService = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnService.Name = "ColumnService";
            ColumnService.HeaderText = "Услуга";
            ColumnService.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            ColumnPrice.Name = "ColumnPrice";
            ColumnPrice.HeaderText = "Стоимость";
            ColumnDuration.Name = "ColumnDuration";
            ColumnDuration.HeaderText = "Срок, дней";
            SuspendLayout();
            // labelNumber
            labelNumber.Name = "labelNumber";
            labelNumber.AutoSize = true;
            labelNumber.Location = new System.Drawing.Point(12, 15);
            labelNumber.Text = "Номер договора";
            // textBoxNumber
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Location = new System.Drawing.Point(150, 12);
            textBoxNumber.Size = new System.Drawing.Size(230, 23);
            // labelOrganization
            labelOrganization.Name = "labelOrganization";
            labelOrganization.AutoSize = true;
            labelOrganization.Location = new System.Drawing.Point(12, 50);
            labelOrganization.Text = "Организация";
            // comboBoxOrganization
            comboBoxOrganization.Name = "comboBoxOrganization";
            comboBoxOrganization.Location = new System.Drawing.Point(150, 47);
            comboBoxOrganization.Size = new System.Drawing.Size(230, 23);
            comboBoxOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // labelEmployee
            labelEmployee.Name = "labelEmployee";
            labelEmployee.AutoSize = true;
            labelEmployee.Location = new System.Drawing.Point(12, 85);
            labelEmployee.Text = "Ответственный";
            // comboBoxEmployee
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Location = new System.Drawing.Point(150, 82);
            comboBoxEmployee.Size = new System.Drawing.Size(230, 23);
            comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // labelDate
            labelDate.Name = "labelDate";
            labelDate.AutoSize = true;
            labelDate.Location = new System.Drawing.Point(12, 120);
            labelDate.Text = "Дата";
            // dateTimePickerSigning
            dateTimePickerSigning.Name = "dateTimePickerSigning";
            dateTimePickerSigning.Location = new System.Drawing.Point(150, 117);
            dateTimePickerSigning.Size = new System.Drawing.Size(230, 23);
            dateTimePickerSigning.Enabled = false;
            // groupBoxServices
            groupBoxServices.Name = "groupBoxServices";
            groupBoxServices.Location = new System.Drawing.Point(12, 150);
            groupBoxServices.Size = new System.Drawing.Size(516, 220);
            groupBoxServices.Text = "Услуги";
            groupBoxServices.TabStop = false;
            // dataGridViewServices
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.AllowUserToResizeRows = false;
            dataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewServices.RowHeadersVisible = false;
            dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnService, ColumnPrice, ColumnDuration });
            // buttonSave
            buttonSave.Name = "buttonSave";
            buttonSave.Location = new System.Drawing.Point(150, 385);
            buttonSave.Size = new System.Drawing.Size(110, 30);
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // buttonCancel
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Location = new System.Drawing.Point(270, 385);
            buttonCancel.Size = new System.Drawing.Size(110, 30);
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            groupBoxServices.Controls.Add(dataGridViewServices);
            Controls.Add(labelNumber);
            Controls.Add(textBoxNumber);
            Controls.Add(labelOrganization);
            Controls.Add(comboBoxOrganization);
            Controls.Add(labelEmployee);
            Controls.Add(comboBoxEmployee);
            Controls.Add(labelDate);
            Controls.Add(dateTimePickerSigning);
            Controls.Add(groupBoxServices);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            // FormContract
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(540, 435);
            Text = "Договор";
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

        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuration;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.ComboBox comboBoxOrganization;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSigning;
        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
