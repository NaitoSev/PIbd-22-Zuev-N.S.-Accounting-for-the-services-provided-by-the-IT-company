using ItServiceAccounting.Entities;
using ItServiceAccounting.Repositories;

namespace ItServiceAccounting.Forms;

public partial class FormWorkReport : Form
{
    private readonly IWorkReportRepository _workReportRepository;

    public FormWorkReport(IWorkReportRepository workReportRepository, IContractRepository contractRepository,
        IEmployeeRepository employeeRepository)
    {
        InitializeComponent();
        _workReportRepository = workReportRepository ??
            throw new ArgumentNullException(nameof(workReportRepository));

        comboBoxContract.DataSource = contractRepository.ReadContracts();
        comboBoxContract.DisplayMember = "Number";
        comboBoxContract.ValueMember = "Id";

        comboBoxEmployee.DataSource = employeeRepository.ReadEmployees();
        comboBoxEmployee.DisplayMember = "LastName";
        comboBoxEmployee.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxContract.SelectedIndex < 0 ||
                comboBoxEmployee.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _workReportRepository.CreateWorkReport(WorkReport.CreateOperation(0,
                (int)comboBoxContract.SelectedValue!, (int)comboBoxEmployee.SelectedValue!,
                Convert.ToInt32(numericUpDownPercent.Value), textBoxDescription.Text));

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();
}
