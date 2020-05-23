using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Bibliography;
using DotnetCoreRedisExample.Models;
using DotnetCoreRedisExample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DotnetCoreRedisExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingOperationsController : ControllerBase
    {
        private readonly IBankingOperationsService _bankingOperationsService;
        private readonly IDistributedCache _redisDistributedCache;
        public BankingOperationsController(IBankingOperationsService bankingOperationService, IDistributedCache distributedCache)
        {
            _bankingOperationsService = bankingOperationService;
            _redisDistributedCache = distributedCache;
        }

        [HttpGet]
        public async Task<List<AccountItem>> GetUserAccountAsync(string branchId)
        {
            List<AccountItem> branchUserAccounts;
            string cacheJsonItem;
            var userAccountsFromCache = await _redisDistributedCache.GetAsync(branchId);
            if (userAccountsFromCache != null)
            {
                cacheJsonItem = Encoding.UTF8.GetString(userAccountsFromCache);
                branchUserAccounts = JsonConvert.DeserializeObject<List<AccountItem>>(cacheJsonItem);
            }
            else
            {
                branchUserAccounts = await Task.Run(() => _bankingOperationsService.GetBranhUserBankAccounts(branchId));
                cacheJsonItem = JsonConvert.SerializeObject(branchUserAccounts);
                userAccountsFromCache = Encoding.UTF8.GetBytes(cacheJsonItem);
                var options = new DistributedCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromDays(1))
                        .SetAbsoluteExpiration(DateTime.Now.AddMonths(1));
                await _redisDistributedCache.SetAsync(branchId, userAccountsFromCache, options);

            }
            return branchUserAccounts;
        }
    }
}
