using System.Globalization;
using MimyMart.Application.Abstractions;
using MimyMart.Application.Enums;

namespace MimyMart.Windows.Forms;

public class InstalledOsLanguage : IInstalledOsLanguage
{
	private const string Thai = "th-TH";
	public OsLanguage Language => CultureInfo.InstalledUICulture.Name == Thai
									  ? OsLanguage.Thai
									  : OsLanguage.English;
}