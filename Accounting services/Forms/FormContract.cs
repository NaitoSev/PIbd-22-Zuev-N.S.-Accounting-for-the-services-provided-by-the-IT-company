using ItServiceAccounting.Entities;
using ItServiceAccounting.Repositories;

namespace ItServiceAccounting.Forms;

public partial class FormContract : Form
{
    private readonly IContractRepository _contractRepository;

    public FormContract(IContractRepository contractRepository, IOrganizationRepository organizationRepository,
        IEmployeeRepository employeeRepository, IServiceRepository serviceRepository)
    {
        InitializeComponent();
        _contractRepository = contractRepository ??
            throw new ArgumentNullException(nameof(contractRepository));

        comboBoxOrganization.DataSource = organizationRepository.ReadOrganizations();
        comboBoxOrganization.DisplayMember = "Name";
        comboBoxOrganization.ValueMember = "Id";

        comboBoxEmployee.DataSource = employeeRepository.ReadEmployees();
        comboBoxEmployee.DisplayMember = "LastName";
        comboBoxEmployee.ValueMember = "Id";

        ColumnService.DataSource = serviceRepository.ReadServices();
        ColumnService.DisplayMember = "Name";
        ColumnService.ValueMember = "Id";
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            var serviceContracts = CreateListServiceContractsFromDataGrid();
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text) ||
                comboBoxOrganization.SelectedIndex < 0 ||
                comboBoxEmployee.SelectedIndex < 0 ||
                serviceContracts.Count < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _contractRepository.CreateContract(Contract.CreateOperation(0, textBoxNumber.Text,
                (int)comboBoxOrganization.SelectedValue!, (int)comboBoxEmployee.SelectedValue!,
                serviceContracts));

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private List<ServiceContract> CreateListServiceContractsFromDataGrid()
    {
        var list = new List<ServiceContract>();
        foreach (DataGridViewRow row in dataGridViewServices.Rows)
        {
            if (row.Cells["ColumnService"].Value == null ||
                row.Cells["ColumnPrice"].Value == null ||
                row.Cells["ColumnDuration"].Value == null)
            {
                continue;
            }

            list.Add(ServiceContract.CreateElement(0,
                Convert.ToInt32(row.Cells["ColumnService"].Value),
                Convert.ToDecimal(row.Cells["ColumnPrice"].Value),
                Convert.ToInt32(row.Cells["ColumnDuration"].Value)));
        }

        return list;
    }
}
