using ItServiceAccounting.Entities;
using ItServiceAccounting.Repositories;

namespace ItServiceAccounting.Forms;

public partial class FormOrganization : Form
{
    private readonly IOrganizationRepository _organizationRepository;

    private int? _organizationId;

    [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var organization = _organizationRepository.ReadOrganizationById(value);
                if (organization == null)
                {
                    throw new InvalidDataException(nameof(organization));
                }

                textBoxName.Text = organization.Name;
                textBoxInn.Text = organization.Inn;
                textBoxContactPerson.Text = organization.ContactPerson;
                textBoxPhone.Text = organization.Phone;

                _organizationId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormOrganization(IOrganizationRepository organizationRepository)
    {
        InitializeComponent();
        _organizationRepository = organizationRepository ??
            throw new ArgumentNullException(nameof(organizationRepository));
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxInn.Text) ||
                string.IsNullOrWhiteSpace(textBoxContactPerson.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            if (_organizationId.HasValue)
            {
                _organizationRepository.UpdateOrganization(CreateOrganization(_organizationId.Value));
            }
            else
            {
                _organizationRepository.CreateOrganization(CreateOrganization(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonCancel_Click(object sender, EventArgs e) => Close();

    private Organization CreateOrganization(int id) =>
        Organization.CreateEntity(id, textBoxName.Text, textBoxInn.Text, textBoxContactPerson.Text,
            textBoxPhone.Text);
}
