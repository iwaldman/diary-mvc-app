using Microsoft.AspNetCore.Mvc;
using DiaryApp.Data;

namespace DiaryApp.Controllers;

public class DiaryEntriesController(ApplicationDbContext context) : Controller
{
    public IActionResult Index()
    {
        var diaryEntries = context.DiaryEntries.ToList();
        return View(diaryEntries);
    }
}
