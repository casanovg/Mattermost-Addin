using System.Reflection;

[assembly: AssemblyCompany("HellermannTyton Argentina")]
[assembly: AssemblyProduct("Mattermost Add-in")]
[assembly: AssemblyDescription("Mattermost Add-in for Outlook")]
[assembly: AssemblyCopyright("(C) 2021 Gustavo Casanova")]
[assembly: AssemblyTrademark("This application has no trademarks")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyVersion(Version.Current)]
[assembly: AssemblyFileVersion(Version.Current)]
[assembly: AssemblyInformationalVersion(Version.FullCurrent)]

internal class Version
{
    // refer to http://semver.org for more information
    public const string Major = "2";
    public const string Minor = "1";
    public const string Patch = "0";

    public const string AdditionalReleaseInformation = "";
    public const string Current = Major + "." + Minor + "." + Patch;
    public const string FullCurrent = Current + "-release" + AdditionalReleaseInformation;
}
