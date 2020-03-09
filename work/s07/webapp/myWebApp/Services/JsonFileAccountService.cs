﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Hosting;
using myWebApp.Models;

namespace myWebApp.Services
{
    public class JsonFileAccountService
    {
        public JsonFileAccountService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.ContentRootPath, "../../../", "data", "account.json"); }
        }

        public IEnumerable<Account> GetAccounts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Account[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public IEnumerable<Account> GetIndexAccount(int index)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var accountId = JsonSerializer.Deserialize<Account[]>(jsonFileReader.ReadToEnd()
                return accountId[index],
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}