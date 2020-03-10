using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;
using myWebApp.Services;
using myWebApp.Models;

namespace myWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        public AccountsController(JsonFileAccountService accountService)
        {
            AccountService = accountService;
        }

        public JsonFileAccountService AccountService { get; }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return AccountService.GetAccounts();
        }
        
        [HttpGet("{number}")]
        public IEnumerable<object> Get(int number)
        {
            var filteredAccounts =
                AccountService
                    .GetAccounts()
                    .Where(account => account.Number == number)
                    .ToArray();
            return filteredAccounts.Any() ? (IEnumerable<object>) filteredAccounts : new[] {"ERROR"};
        }

    }
}