namespace TestProject1.Common;

using static System.Environment;

public static class Settings
{
    public static readonly string BaseUrl = GetEnvironmentVariable("APPLICATION_BASE_URL") ?? "http://localhost:5203";

    // List of device keys from: https://github.com/microsoft/playwright/blob/main/packages/playwright-core/src/server/deviceDescriptorsSource.json
    public static IEnumerable<string> GetDeviceList()
    {
        yield return "iPhone 13";
        yield return "iPad (gen 7)";
        yield return "Desktop Chrome";
    }
}