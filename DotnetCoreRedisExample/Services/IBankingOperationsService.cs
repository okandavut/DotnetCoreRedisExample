using DotnetCoreRedisExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreRedisExample.Services
{
    public interface IBankingOperationsService
    {
        List<AccountItem> GetBranchUserBankAccounts(string branchId);
    }
}
