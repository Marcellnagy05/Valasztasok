using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Valasztasok.Model;

namespace Valasztasok.Pages
{
    public class AdatokFeltolteseFilebolModel : PageModel
    {
        public IWebHostEnvironment _env { get; set; }
        public ValasztasokDbContext _context { get; set; }

        public AdatokFeltolteseFilebolModel(IWebHostEnvironment env, ValasztasokDbContext context)
        {
            _context = context;
            _env = env;
        }

        [BindProperty]
        public IFormFile UploadFile { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var UploadFilePath = Path.Combine(_env.ContentRootPath, "uploads", UploadFile.FileName);

            using (var stream = new FileStream(UploadFilePath, FileMode.Create))
            {
                await UploadFile.CopyToAsync(stream);
            }

            StreamReader sr = new StreamReader(UploadFilePath);

            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var items = line.Split(" ");
                Jelolt ujJelolt = new Jelolt();
                Part ujPart = new Part();
                ujJelolt.Id = int.Parse(items[0]);
                ujJelolt.SzavazatokSzama = int.Parse(items[1]);
                ujJelolt.Nev = items[2] + " " + items[3];
                ujJelolt.Part = ujPart;
                ujJelolt.Kerulet = items[4];
                _context.Add(ujJelolt);
                _context.Add(ujPart);
            }

            sr.Close();
            _context.SaveChanges();
            return Page();
        }
    }
}
