## .NET Core & Redis Basic Implementation
<!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors-)
<!-- ALL-CONTRIBUTORS-BADGE:END -->
**Simple example checking the local Redis cache.**
 - [x]  If data exists in Redis  gets data from Redis. 
 - [x]  If data not exists in Redis, gets data from BankingOperationService and writes to Redis.
 - [x]  Also calls SetSlidingExpiration(TimeSpan.FromDays(1)) and sets inactive time for data on Redis.
 - [x]  Also calls SetAbsoluteExpiration(DateTime.Now.AddMonths(1)) and sets it determines when the data will be deleted.



**Technologies :** 
 -  .NET Core Api Project (Version-3.1)
 -  Redis 3.2.100




## Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
       <td align="center"><a href="https://medium.com/@okandavut"><img src="https://avatars3.githubusercontent.com/u/10600157?v=4" width="100px;" alt=""/><br /><sub><b>Okan DAVUT</b></sub></a><br /><a href="https://github.com/okandavut/DotnetCoreRedisExample/commits?author=okandavut" title="Code">💻</a><a href="#maintenance-nadchif" title="Maintenance">🚧</a></td>
    <td align="center"><a href="http://firateski.com"><img src="https://avatars0.githubusercontent.com/u/9573857?v=4" width="100px;" alt=""/><br /><sub><b>Firat Eski</b></sub></a><br /><a href="https://github.com/okandavut/DotnetCoreRedisExample/commits?author=firateski" title="Code">💻</a></td>
  </tr>
</table>

<!-- markdownlint-enable -->
<!-- prettier-ignore-end -->
<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!
