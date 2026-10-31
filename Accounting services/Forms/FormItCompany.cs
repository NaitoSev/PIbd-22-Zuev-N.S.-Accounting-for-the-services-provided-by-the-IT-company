using Unity;

namespace ItServiceAccounting.Forms;

public partial class FormItCompany : Form
{
    private readonly IUnityContainer _container;

    public FormItCompany(IUnityContainer container)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
    }

    private void OrganizationsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormOrganizations>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormEmployees>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormServices>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ContractsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormContracts>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void WorkReportsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormWorkReports>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
