using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StreamTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task Index()
        {
            Response.ContentType = "text/vtt";
            await using (var writer = new StreamWriter(Response.Body))
            {
                await writer.WriteAsync("WEBVTT");
                await writer.FlushAsync();
            }
        }
    }
}
