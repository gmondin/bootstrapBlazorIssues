using System.Globalization;

namespace BlazorTest.Shared
{
  public static class Language
  {
    public static void SetDefaultLanguage(string language)
    {
      if (!string.IsNullOrEmpty(language))
      {
        CultureInfo culture = new(language);
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
      }
    }
  }
}
