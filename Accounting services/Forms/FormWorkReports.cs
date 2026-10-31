using ItServiceAccounting.Repositories;
using Unity;

namespace ItServiceAccounting.Forms;

public partial class FormWorkReports : Form
{
    private readonly IUnityContainer _container;

    private readonly IWorkReportRepository _workReportRepository;

    public FormWorkReports(IUnityContainer container, IWorkReportRepository workReportRepository)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
        _workReportRepository = workReportRepository ??
            throw new ArgumentNullException(nameof(workReportRepository));
    }

    private void FormWorkReports_Load(object sender, EventArgs e)
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

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormWorkReport>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewData.DataSource = _workReportRepository.ReadWorkReports();
}
