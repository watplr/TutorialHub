using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using TutorialHub.Models;

namespace TutorialHub.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public TutorialsModel Data
        {
            get
            {
                string rawJson = System.IO.File.ReadAllText("./Data/stream.json");
                return JsonConvert.DeserializeObject<TutorialsModel>(rawJson);
            }
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}
