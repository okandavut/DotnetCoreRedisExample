using DotnetCoreRedisExample.Models;
using System.Collections.Generic;

namespace DotnetCoreRedisExample.Services
{
    public interface IBankingOperationsService
    {
        List<AccountItem> GetBranchUserBankAccounts(string branchId);
    }
}
