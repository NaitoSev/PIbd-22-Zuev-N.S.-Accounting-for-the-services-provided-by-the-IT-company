using ItServiceAccounting.Entities;

namespace ItServiceAccounting.Repositories;

public interface IContractRepository
{
    IEnumerable<Contract> ReadContracts(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? organizationId = null, int? employeeId = null);

    void CreateContract(Contract contract);

    void DeleteContract(int id);
}
