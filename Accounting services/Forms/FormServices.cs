using ItServiceAccounting.Repositories;
using Unity;

namespace ItServiceAccounting.Forms;

public partial class FormServices : Form
{
    private readonly IUnityContainer _container;

    private readonly IServiceRepository _serviceRepository;

    public FormServices(IUnityContainer container, IServiceRepository serviceRepository)
    {
        InitializeComponent();
        _container = container ??
            throw new ArgumentNullException(nameof(container));
        _serviceRepository = serviceRepository ??
            throw new ArgumentNullException(nameof(serviceRepository));
    }

    private void FormServices_Load(object sender, EventArgs e)
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
            _container.Resolve<FormService>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonUpd_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findId))
        {
            return;
        }

        try
        {
            var form = _container.Resolve<FormService>();
            form.Id = findId;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _serviceRepository.DeleteService(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewData.DataSource = _serviceRepository.ReadServices();

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
