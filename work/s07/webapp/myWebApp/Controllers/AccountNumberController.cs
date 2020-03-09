using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using myWebApp.Models;
using myWebApp.Services;

namespace myWebApp.Controllers
{
    [ApiController]
    [Route("api/accounts/[controller]")]
    public class AccountsNumberController : ControllerBase
    {
        public AccountsNumberController(JsonFileAccountService accountService)
        {
            AccountService = accountService;
        }

        public JsonFileAccountService AccountService { get; }

        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return AccountService.GetIndexAccounts();
        }
    }
}