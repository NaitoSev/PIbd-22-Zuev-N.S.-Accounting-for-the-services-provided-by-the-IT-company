#nullable disable

namespace ItServiceAccounting.Forms
{
    partial class FormWorkReports
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
            dataGridViewData = new System.Windows.Forms.DataGridView();
            panelButtons = new System.Windows.Forms.Panel();
            buttonAdd = new System.Windows.Forms.Button();
            SuspendLayout();
            // dataGridViewData
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.AllowUserToAddRows = false;
            dataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewData.AllowUserToResizeColumns = false;
            dataGridViewData.AllowUserToResizeRows = false;
            dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewData.MultiSelect = false;
            dataGridViewData.ReadOnly = true;
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewData.Size = new System.Drawing.Size(560, 400);
            dataGridViewData.TabIndex = 0;
            // panelButtons
            panelButtons.Name = "panelButtons";
            panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            panelButtons.Size = new System.Drawing.Size(120, 400);
            panelButtons.TabIndex = 1;
            // buttonAdd
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Location = new System.Drawing.Point(8, 12);
            buttonAdd.Size = new System.Drawing.Size(104, 32);
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            panelButtons.Controls.Add(buttonAdd);
            Controls.Add(dataGridViewData);
            Controls.Add(panelButtons);
            // FormWorkReports
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(680, 400);
            Text = "Отчеты о выполнении работ";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Load += FormWorkReports_Load;
            buttonAdd.Click += ButtonAdd_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
    }
}
