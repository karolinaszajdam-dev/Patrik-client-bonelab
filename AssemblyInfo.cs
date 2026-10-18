using System.Reflection;
using PatrikClient;
using MelonLoader;

[assembly: AssemblyTitle(PatrikClient.Main.Description)]
[assembly: AssemblyDescription(PatrikClient.Main.Description)]
[assembly: AssemblyCompany(PatrikClient.Main.Company)]
[assembly: AssemblyProduct(PatrikClient.Main.Name)]
[assembly: AssemblyCopyright("Developed by " + PatrikClient.Main.Author)]
[assembly: AssemblyTrademark(PatrikClient.Main.Company)]
[assembly: AssemblyVersion(PatrikClient.Main.Version)]
[assembly: AssemblyFileVersion(PatrikClient.Main.Version)]
[assembly: MelonInfo(typeof(PatrikClient.Main), PatrikClient.Main.Name, PatrikClient.Main.Version, PatrikClient.Main.Author, PatrikClient.Main.DownloadLink)]
[assembly: MelonColor(System.ConsoleColor.White)]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]