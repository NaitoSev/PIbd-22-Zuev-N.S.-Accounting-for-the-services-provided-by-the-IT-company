using ItServiceAccounting.Repositories;
using Unity;

namespace ItServiceAccounting.Forms;

public partial class FormContracts : Form
{
    private readonly IUnityContainer _container;

    private readonly IContractRepository _contractRepository;

    private readonly IOrganizationRepository _organizationRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IWorkReportRepository _workReportRepository;
    private readonly ComboBox _organizations = new() { DropDownStyle = ComboBoxStyle.DropDownList, Width = 190 };
    private readonly ComboBox _employees = new() { DropDownStyle = ComboBoxStyle.DropDownList, Width = 190 };

    public FormContracts(IUnityContainer container, IContractRepository contractRepository,
        IOrganizationRepository organizationRepository, IEmployeeRepository employeeRepository,
        IWorkReportRepository workReportRepository)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
        _contractRepository = contractRepository ??
            throw new ArgumentNullException(nameof(contractRepository));
        _organizationRepository = organizationRepository;
        _employeeRepository = employeeRepository;
        _workReportRepository = workReportRepository;

        var filters = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 42, Padding = new Padding(6) };
        filters.Controls.Add(new Label { Text = "Организация", AutoSize = true, Margin = new Padding(3, 7, 3, 0) });
        filters.Controls.Add(_organizations);
        filters.Controls.Add(new Label { Text = "Ответственный", AutoSize = true, Margin = new Padding(12, 7, 3, 0) });
        filters.Controls.Add(_employees);
        Controls.Add(filters);
        ClientSize = new Size(1040, 440);
    }

    private void FormContracts_Load(object sender, EventArgs e)
    {
        try
        {
            var organizations = _organizationRepository.ReadOrganizations()
                .Select(x => new FilterOption(x.Id, x.Name)).Prepend(new FilterOption(null, "Все организации")).ToList();
            var employees = _employeeRepository.ReadEmployees()
                .Select(x => new FilterOption(x.Id, $"{x.LastName} {x.FirstName}"))
                .Prepend(new FilterOption(null, "Все сотрудники")).ToList();

            BindFilter(_organizations, organizations);
            BindFilter(_employees, employees);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormContract>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonDel_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }

        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }

        try
        {
            _contractRepository.DeleteContract(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BindFilter(ComboBox filter, List<FilterOption> options)
    {
        filter.DisplayMember = nameof(FilterOption.Name);
        filter.DataSource = options;
        filter.SelectedIndexChanged += FormContracts_LoadList;
    }

    private void FormContracts_LoadList(object? sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList()
    {
        var organizationId = (_organizations.SelectedItem as FilterOption)?.Id;
        var employeeId = (_employees.SelectedItem as FilterOption)?.Id;
        var organizations = ((List<FilterOption>)_organizations.DataSource!)
            .Where(x => x.Id.HasValue).ToDictionary(x => x.Id!.Value, x => x.Name);
        var employees = ((List<FilterOption>)_employees.DataSource!)
            .Where(x => x.Id.HasValue).ToDictionary(x => x.Id!.Value, x => x.Name);
        var latestReports = _workReportRepository.ReadWorkReports()
            .GroupBy(x => x.ContractId).ToDictionary(x => x.Key, x => x.First().CompletionPercent);

        dataGridViewData.DataSource = _contractRepository.ReadContracts(organizationId: organizationId, employeeId: employeeId)
            .Select(x => new
            {
                x.Id,
                Номер = x.Number,
                Организация = organizations.GetValueOrDefault(x.OrganizationId),
                Ответственный = employees.GetValueOrDefault(x.EmployeeId),
                Подписан = x.SigningDate.ToShortDateString(),
                Срок = x.SigningDate.AddDays(x.ServiceContracts.Select(s => s.DurationDays).DefaultIfEmpty().Max()).ToShortDateString(),
                Сумма = x.TotalAmount,
                Выполнено = $"{latestReports.GetValueOrDefault(x.Id)} %"
            }).ToList();
        dataGridViewData.Columns["Id"].Visible = false;
    }

    private sealed record FilterOption(int? Id, string Name);

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewData.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
        return true;
    }
}
