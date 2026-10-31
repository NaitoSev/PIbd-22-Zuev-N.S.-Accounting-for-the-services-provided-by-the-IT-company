#nullable disable

namespace ItServiceAccounting.Forms
{
    partial class FormItCompany
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
            menuStrip = new System.Windows.Forms.MenuStrip();
            directoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            organizationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contractsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            workReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            directoriesToolStripMenuItem.Text = "Справочники";
            directoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { organizationsToolStripMenuItem, employeesToolStripMenuItem, servicesToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Text = "Операции";
            operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { contractsToolStripMenuItem, workReportsToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Text = "Отчеты";
            organizationsToolStripMenuItem.Name = "organizationsToolStripMenuItem";
            organizationsToolStripMenuItem.Text = "Организации";
            organizationsToolStripMenuItem.Click += OrganizationsToolStripMenuItem_Click;
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Text = "Сотрудники";
            employeesToolStripMenuItem.Click += EmployeesToolStripMenuItem_Click;
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Text = "Услуги";
            servicesToolStripMenuItem.Click += ServicesToolStripMenuItem_Click;
            contractsToolStripMenuItem.Name = "contractsToolStripMenuItem";
            contractsToolStripMenuItem.Text = "Договоры";
            contractsToolStripMenuItem.Click += ContractsToolStripMenuItem_Click;
            workReportsToolStripMenuItem.Name = "workReportsToolStripMenuItem";
            workReportsToolStripMenuItem.Text = "Отчеты о выполнении работ";
            workReportsToolStripMenuItem.Click += WorkReportsToolStripMenuItem_Click;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Text = "Учет оказываемых услуг IT-компании";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem directoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workReportsToolStripMenuItem;
    }
}
