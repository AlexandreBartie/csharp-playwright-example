Welcome to the csharp-playwright-example wiki!

This template supports the little steps to create c# console project with playwright automation test library.

## Create C# console project

Inside the visual code, open your terminal and write the commands below.

> Please note that it is very important to switch to the new folder. The name of this folder will be the same as the project name.

`dotnet new console -n <name-project>`

`cd <name-project>`

## Add Playwright Library in the project

This command will install Playwright and allow the creation of automation scripts.

`dotnet add package Microsoft.Playwright`


## Write a simple automation script

Overwrite a Program.cs file with this code lines.

----
using Microsoft.Playwright;

using var pw = await Playwright.CreateAsync();
await using var browser = await pw.Chromium.LaunchAsync(new() { Headless = false });

var page = await browser.NewPageAsync();

await page.GotoAsync("http://webcode.me");
await page.ScreenshotAsync(new() { Path = "screenshot.png" });
----