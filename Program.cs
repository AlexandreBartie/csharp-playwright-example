using Microsoft.Playwright;

using var pw = await Playwright.CreateAsync();
await using var browser = await pw.Chromium.LaunchAsync(new() { Headless = false });

var page = await browser.NewPageAsync();

await page.GotoAsync("http://webcode.me");
await page.ScreenshotAsync(new() { Path = "screenshot.png" });
