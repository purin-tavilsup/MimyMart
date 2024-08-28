using MimyMart.Application.Enums;

namespace MimyMart.Application.Abstractions;

public interface IInstalledOsLanguage
{
	OsLanguage Language { get; init; }
}