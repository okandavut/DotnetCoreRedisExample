using DotnetCoreRedisExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
