// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

var showMvcImage = "https://developer.mozilla.org/en-US/docs/Glossary/MVC#model_view_controller_example";
Process.Start(new ProcessStartInfo("cmd", $"/c start {showMvcImage}") { CreateNoWindow = true });

var showSimpelMvcImage = "https://www.matridtech.net/what-is-asp-net-mvc-and-what-are-its-main-features/";
Process.Start(new ProcessStartInfo("cmd", $"/c start {showSimpelMvcImage}") { CreateNoWindow = true });

var showMiddelWareImage = "https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0#middleware-order";
Process.Start(new ProcessStartInfo("cmd", $"/c start {showMiddelWareImage}") { CreateNoWindow = true });


