using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;

namespace PlaywrightTests;

public class UnitTest1: PageTest
{
    [Fact]
    public async Task Test1()
    {
        await Page.GotoAsync("https://www.bankofcanada.ca/");
    }
}
