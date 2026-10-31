#nullable disable

namespace ItServiceAccounting.Forms
{
    partial class FormEmployees
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
            buttonUpd = new System.Windows.Forms.Button();
            buttonDel = new System.Windows.Forms.Button();
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
            // buttonUpd
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Location = new System.Drawing.Point(8, 52);
            buttonUpd.Size = new System.Drawing.Size(104, 32);
            buttonUpd.Text = "Изменить";
            buttonUpd.UseVisualStyleBackColor = true;
            // buttonDel
            buttonDel.Name = "buttonDel";
            buttonDel.Location = new System.Drawing.Point(8, 92);
            buttonDel.Size = new System.Drawing.Size(104, 32);
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Controls.Add(buttonUpd);
            panelButtons.Controls.Add(buttonDel);
            Controls.Add(dataGridViewData);
            Controls.Add(panelButtons);
            // FormEmployees
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(680, 400);
            Text = "Сотрудники";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Load += FormEmployees_Load;
            buttonAdd.Click += ButtonAdd_Click;
            buttonUpd.Click += ButtonUpd_Click;
            buttonDel.Click += ButtonDel_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonDel;
    }
}
