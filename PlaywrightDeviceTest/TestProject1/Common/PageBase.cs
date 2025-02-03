using Microsoft.Playwright;

namespace TestProject1.Common;

public abstract class PageBase(IPage page)
{
    // Assertions that are common amongst pages go here
    public async Task SomeCommonAssertion()
    {
        
    }
}