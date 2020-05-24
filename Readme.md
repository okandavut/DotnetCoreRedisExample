## .NET Core & Redis Basic Implementation
**Simple example checking the local Redis cache.**
 - [x]  If data exists in Redis  gets data from Redis. 
 - [x]  If data not exists in Redis, gets data from BankingOperationService and writes to Redis.
 - [x]  Also calls SetSlidingExpiration(TimeSpan.FromDays(1)) and sets inactive time for data on Redis.
 - [x]  Also calls SetAbsoluteExpiration(DateTime.Now.AddMonths(1)) and sets it determines when the data will be deleted.



**Technologies :** 
 -  .NET Core Api Project (Version-3.1)
 -  Redis 3.2.100

## Contributors ✨
Thanks goes to these wonderful people!
<table>
  <tr>
    <td align="center"><a href="https://medium.com/@okandavut"><img src="https://avatars3.githubusercontent.com/u/10600157?v=4" width="100px;" alt=""/><br /><sub><b>Okan DAVUT</b></sub></a><br /><a href="https://github.com/nadchif/adobe-brackets-encode-decode/commits?author=okandavut" title="Code">💻</a><a href="#maintenance-nadchif" title="Maintenance">🚧</a></td>
    <td align="center"><a href="https://firateski.com/"><img src="https://avatars0.githubusercontent.com/u/9573857?s=460&u=44e18d8957ef7cc0e0770db7affc66b53ff75a35&v=4" width="100px;" alt=""/><br /><sub><b>Fırat Eski</b></sub></a><br /><a href="https://github.com/okandavut/DotnetCoreRedisExample/commits?author=firateski" title="Code">💻</a></td>
  </tr>
</table>

