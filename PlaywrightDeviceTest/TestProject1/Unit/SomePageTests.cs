using TestProject1.Common;
using TestProject1.Pages;

namespace TestProject1.Unit;

// This fixture source allows us to run the suite of tests for each device 
[TestFixtureSource(typeof(Settings), nameof(Settings.GetDeviceList), Category = Categories.Accessibility)]
public class SomePageTests(string device) : TestBase(device)
{
    private SomePage _somePage = null!;

    [SetUp]
    public async Task SetUp()
    {
        _somePage = new SomePage(Page);
    }
    
    [Test]
    public void GivenSomePage_WhenPageLoads_ThenPageHasNoViolations()
    {
        Assert.Pass(); 
    }
}
