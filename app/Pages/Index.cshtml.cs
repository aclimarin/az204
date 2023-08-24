using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az204.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        _logger.LogError("On Get from index.cshtml.cs -- MY LOG!!!");
        // System.Diagnostics.Trace.TraceError("If you're seeing this, something bad happened");
    }
}
