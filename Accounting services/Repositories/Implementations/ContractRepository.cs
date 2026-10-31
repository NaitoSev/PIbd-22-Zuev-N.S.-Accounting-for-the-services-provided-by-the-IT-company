using ItServiceAccounting.Entities;

namespace ItServiceAccounting.Repositories.Implementations;

internal class ContractRepository : IContractRepository
{
    public void CreateContract(Contract contract)
    {
    }

    public void DeleteContract(int id)
    {
    }

    public IEnumerable<Contract> ReadContracts(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? organizationId = null, int? employeeId = null)
    {
        return [];
    }
}
