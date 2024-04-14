using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace Eco_Tanger.Controllers
{
    public class ChartsController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ChartsController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [Authorize]
        public ActionResult Charts()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Upload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "json");
                var filePath = Path.Combine(folderPath, file.FileName);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                // Process the uploaded file and generate the charts
                var jsonData = ReadJsonFile(filePath);

                // Rest of the code to process the data and create the charts

                return Ok(jsonData);
            }

            return BadRequest("No file uploaded.");
        }
        private dynamic ReadJsonFile(string filePath)
        {
            // Read and parse the JSON file
            var jsonData = System.IO.File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<dynamic>(jsonData);
        }
    }
}