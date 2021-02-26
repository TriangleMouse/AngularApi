using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AngularApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.IO;
using System.Net.Http.Json;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace AngularApi.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class UsersController : Controller
    {
        private static List<UsersViewModel> _listItems { get; set; } = new List<UsersViewModel>();

        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        object jsonString1;
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IEnumerable<UsersViewModel>> GetAsync()
        {
        HttpClient webClient = new HttpClient();
            Uri uri = new Uri("http://fakeapi.jsonparseronline.com/users");
            HttpResponseMessage response = await webClient.GetAsync(uri);
            var jsonString = await response.Content.ReadAsStringAsync();
            var objData = JsonConvert.DeserializeObject<List<UsersViewModel>>(jsonString);
            jsonString1 = objData;
            return objData;
                
 
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult Post([Microsoft.AspNetCore.Mvc.FromBody] UsersViewModel user)
        { 
            return (IHttpActionResult)Json(jsonString1);
        }

    }


}


