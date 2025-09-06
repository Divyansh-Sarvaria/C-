using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFirstApp.Pages;

public class IndexModel : PageModel
{
    public List<Menuitem> menuitems { get; set; }
    public void OnGet()
    {
        ViewData["menuitems"] = new List<Menuitem>{
            new Menuitem { text = "home", url = "/" },
            new Menuitem { text = "about", url = "/about" },
            new Menuitem { text = "about", url = "/about" },
            new Menuitem { text = "about", url = "/about" },
            new Menuitem { text = "about", url = "/about" },
            new Menuitem { text = "about", url = "/about" }
        };
    }

}
public class Menuitem {
    public string text { get; set; }
    public string url { get; set; }
    
}
