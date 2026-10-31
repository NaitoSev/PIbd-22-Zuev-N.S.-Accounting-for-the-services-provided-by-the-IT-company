using ItServiceAccounting.Entities;
using ItServiceAccounting.Entities.Enums;
using ItServiceAccounting.Repositories;

namespace ItServiceAccounting.Forms;

public partial class FormService : Form
{
    private readonly IServiceRepository _serviceRepository;

    private int? _serviceId;

    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var service = _serviceRepository.ReadServiceById(value);
                if (service == null)
                {
                    throw new InvalidDataException(nameof(service));
                }

                foreach (ServiceCategory elem in Enum.GetValues(typeof(ServiceCategory)))
                {
                    if ((elem & service.ServiceCategory) != 0)
                    {
                        checkedListBoxServiceCategory.SetItemChecked(
                            checkedListBoxServiceCategory.Items.IndexOf(elem), true);
                    }
                }

                textBoxName.Text = service.Name;
                textBoxDescription.Text = service.Description;
                _serviceId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormService(IServiceRepository serviceRepository)
    {
        InitializeComponent();
        _serviceRepository = serviceRepository ??
            throw new ArgumentNullException(nameof(serviceRepository));

        foreach (ServiceCategory elem in Enum.GetValues(typeof(ServiceCategory)))
        {
            if (elem != ServiceCategory.None)
            {
                checkedListBoxServiceCategory.Items.Add(elem);
            }
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
                checkedListBoxServiceCategory.CheckedItems.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_serviceId.HasValue)
            {
                _serviceRepository.UpdateService(CreateService(_serviceId.Value));
            }
            else
            {
                _serviceRepository.CreateService(CreateService(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Service CreateService(int id)
    {
        var serviceCategory = ServiceCategory.None;
        foreach (var elem in checkedListBoxServiceCategory.CheckedItems)
        {
            serviceCategory |= (ServiceCategory)elem;
        }

        return Service.CreateEntity(id, textBoxName.Text, serviceCategory, textBoxDescription.Text);
    }
}
