using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using JarvisApiCall.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JarvisApiCall.Controllers
{
    public class ApiController : Controller
    {
        private const string baseUrl = "http://localhost:44370/api/";
        private readonly IHostingEnvironment _hostingEnvironment;

        public ApiController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateInstructionXml() {
            return View("CreateInstructionXml", "Instruction Response Here!");
        }

        [HttpGet]
        public IActionResult CreateInstructionJson()
        {
            return View("CreateInstructionJson", "Instruction Response Here!");
        }

        [HttpGet]
        public IActionResult GetEstimateXml() {
            return View("GetEstimateXml", "Estimate Response Here!");
        }

        [HttpGet]
        public IActionResult GetEstimateAndInvoiceXml()
        {
            return View("GetEstimateAndInvoiceXml", "Response Here!");
        }

        [HttpGet]
        public IActionResult GetEstimateJson() {
            return View("GetEstimateJson", "Estimate Response Here!");
        }

        [HttpGet]
        public IActionResult GetEstimateAndInvoiceJson()
        {
            return View("GetEstimateAndInvoiceJson", "Response Here!");
        }

        [HttpGet]
        public IActionResult GetInvoiceXml() {
            return View("GetInvoiceXml", "Response Here!");
        }

        [HttpGet]
        public IActionResult GetInvoiceJson()
        {
            return View("GetInvoiceJson", "Response Here!");
        }

        [HttpPost]
        public async Task<IActionResult> CreateInstructionXml(string filePath = "") {
            string url = "instruction/create";
            string actualUrl = $"{baseUrl}{url}";

            string root = _hostingEnvironment.ContentRootPath;
            var xmlData = System.IO.File.ReadAllText($"{root}/wwwroot/example/xmlData.xml");

            var stringContent = new StringContent(xmlData.ToString(), Encoding.UTF8, "application/xml");
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("email", "info@neworg.com");
            client.DefaultRequestHeaders.Add("password", "Abcd1#");
            client.DefaultRequestHeaders.Add("Accept", "application/xml");

            var response = await client.PostAsync(actualUrl, stringContent);
            var responseString = response.Content.ReadAsStringAsync().Result;
            return View("CreateInstructionXml", responseString);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInstructionJson(string filePath = "")
        {
            string url = "instruction/create";
            string actualUrl = $"{baseUrl}{url}";

            string root = _hostingEnvironment.ContentRootPath;
            var jsonData = System.IO.File.ReadAllText($"{root}/wwwroot/example/jsonData.json");

            var stringContent = new StringContent(jsonData.ToString(), Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("email", "info@neworg.com");
            client.DefaultRequestHeaders.Add("password", "Abcd1#");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.PostAsync(actualUrl, stringContent);
            var responseString = response.Content.ReadAsStringAsync().Result;
            return View("CreateInstructionJson", responseString);
        }

        [HttpPost]
        public async Task<IActionResult> GetEstimateXml(string filePath="") {
            string url = "estimate/get";
            string actualUrl = $"{baseUrl}{url}";

            string root = _hostingEnvironment.ContentRootPath;
            var xmlData = System.IO.File.ReadAllText($"{root}/wwwroot/example/estimateGet.xml");

            var stringContent = new StringContent(xmlData.ToString(), Encoding.UTF8, "application/xml");
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("email", "info@neworg.com");
            client.DefaultRequestHeaders.Add("password", "Abcd1#");
            client.DefaultRequestHeaders.Add("Accept", "application/xml");

            var response = await client.PostAsync(actualUrl, stringContent);
            var responseString = response.Content.ReadAsStringAsync().Result;
            return View("GetEstimateXml", responseString);
        }

        [HttpPost]
        public async Task<IActionResult> GetEstimateJson(string filePath = "") {
            string url = "estimate/get";
            string actualUrl = $"{baseUrl}{url}";

            string root = _hostingEnvironment.ContentRootPath;
            var xmlData = System.IO.File.ReadAllText($"{root}/wwwroot/example/estimateGet.json");

            var stringContent = new StringContent(xmlData.ToString(), Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("email", "info@neworg.com");
            client.DefaultRequestHeaders.Add("password", "Abcd1#");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.PostAsync(actualUrl, stringContent);
            var responseString = response.Content.ReadAsStringAsync().Result;
            return View("GetEstimateJson", responseString);
        }

        [HttpPost]
        public async Task<IActionResult> GetEstimateAndInvoiceXml(string filePath = "")
        {
            string url = "estimate/get";
            string actualUrl = $"{baseUrl}{url}";

            string root = _hostingEnvironment.ContentRootPath;
            var xmlData = System.IO.File.ReadAllText($"{root}/wwwroot/example/estimateAndInvoiceGet.xml");

            var stringContent = new StringContent(xmlData.ToString(), Encoding.UTF8, "application/xml");
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("email", "info@neworg.com");
            client.DefaultRequestHeaders.Add("password", "Abcd1#");
            client.DefaultRequestHeaders.Add("Accept", "application/xml");

            var response = await client.PostAsync(actualUrl, stringContent);
            var responseString = response.Content.ReadAsStringAsync().Result;
            return View("GetEstimateAndInvoiceXml", responseString);
        }

        [HttpPost]
        public async Task<IActionResult> GetEstimateAndInvoiceJson(string filePath = "") {
            string url = "estimate/get";
            string actualUrl = $"{baseUrl}{url}";

            string root = _hostingEnvironment.ContentRootPath;
            var xmlData = System.IO.File.ReadAllText($"{root}/wwwroot/example/estimateAndInvoiceGet.json");

            var stringContent = new StringContent(xmlData.ToString(), Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("email", "info@neworg.com");
            client.DefaultRequestHeaders.Add("password", "Abcd1#");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.PostAsync(actualUrl, stringContent);
            var responseString = response.Content.ReadAsStringAsync().Result;
            return View("GetEstimateAndInvoiceJson", responseString);
        }

        [HttpPost]
        public async Task<IActionResult> GetInvoiceXml(string filePath = "") {
            string url = "invoice/get";
            string actualUrl = $"{baseUrl}{url}";

            string root = _hostingEnvironment.ContentRootPath;
            var xmlData = System.IO.File.ReadAllText($"{root}/wwwroot/example/invoiceGet.xml");

            var stringContent = new StringContent(xmlData.ToString(), Encoding.UTF8, "application/xml");
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("email", "info@neworg.com");
            client.DefaultRequestHeaders.Add("password", "Abcd1#");
            client.DefaultRequestHeaders.Add("Accept", "application/xml");

            var response = await client.PostAsync(actualUrl, stringContent);
            var responseString = response.Content.ReadAsStringAsync().Result;
            return View("GetInvoiceXml", responseString);
        }

        [HttpPost]
        public async Task<IActionResult> GetInvoiceJson(string filePath = "")
        {
            string url = "invoice/get";
            string actualUrl = $"{baseUrl}{url}";

            string root = _hostingEnvironment.ContentRootPath;
            var xmlData = System.IO.File.ReadAllText($"{root}/wwwroot/example/invoiceGet.json");

            var stringContent = new StringContent(xmlData.ToString(), Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("email", "info@neworg.com");
            client.DefaultRequestHeaders.Add("password", "Abcd1#");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.PostAsync(actualUrl, stringContent);
            var responseString = response.Content.ReadAsStringAsync().Result;
            return View("GetInvoiceJson", responseString);
        }
    }
}