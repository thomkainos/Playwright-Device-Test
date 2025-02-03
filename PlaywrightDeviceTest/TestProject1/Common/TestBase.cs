using Microsoft.Playwright;

namespace TestProject1.Common;

public class TestBase(string device)
{
    protected IPage Page = null!;

    private IBrowser _browser = null!;
    private IBrowserContext _browserContext = null!;
    private IPlaywright _playwright = null!;

    [OneTimeSetUp]
    public async Task TestBaseOneTimeSetUp()
    {
        _playwright = await Microsoft.Playwright.Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync();
    }

    [SetUp]
    public async Task TestBaseSetUp()
    {
        _browserContext = await _browser.NewContextAsync(_playwright.Devices[device]);
        Page = await _browserContext.NewPageAsync();
    }

    [TearDown]
    public async Task TestBaseTearDown()
    {
        await Page.CloseAsync();
        await _browserContext.CloseAsync();
    }

    [OneTimeTearDown]
    public async Task TestBaseOneTimeTearDown()
    {
        await _browser.CloseAsync();
    }
}