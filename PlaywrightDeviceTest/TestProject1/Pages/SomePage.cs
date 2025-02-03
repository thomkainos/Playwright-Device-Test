using Microsoft.Playwright;
using TestProject1.Common;

namespace TestProject1.Pages;

public class SomePage(IPage page) : PageBase(page)
{
    private readonly IPage _page = page;

    // Methods to perform Playwright interactions
    public async Task ClickContinueButtonAsync()
    {
        
    }
}
