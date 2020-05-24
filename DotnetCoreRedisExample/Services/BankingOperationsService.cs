using DotnetCoreRedisExample.Models;
using System.Collections.Generic;

namespace DotnetCoreRedisExample.Services
{
    public class BankingOperationsService : IBankingOperationsService
    {
        public List<AccountItem> GetBranchUserBankAccounts(string branchId)
        {
            List<AccountItem> UserAccounts = new List<AccountItem>() {
                new AccountItem(){ UserId =1, AccountBalance=6700},
                new AccountItem(){ UserId =2, AccountBalance=5300},
            };

            return UserAccounts;
        }
    }
}
