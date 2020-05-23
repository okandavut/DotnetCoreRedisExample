## .NET Core & Redis Basic Implementation
**Simple example checking the local Redis cache.**
 - [x]  If data exists in Redis  gets data from Redis. 
 - [ ]  If data not exists in Redis, gets data from BankingOperationService and writes to Redis.
 - [ ]  Also calls SetSlidingExpiration(TimeSpan.FromDays(1)) and sets inactive time for data on Redis.
 - [ ]  Also calls SetAbsoluteExpiration(DateTime.Now.AddMonths(1)) and sets it determines when the data will be deleted.



**Technologies :** 
 -  .NET Core Api Project (Version-3.1)
 -  Redis 3.2.100

