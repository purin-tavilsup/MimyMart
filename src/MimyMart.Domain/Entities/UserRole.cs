using System.Diagnostics.CodeAnalysis;

namespace MimyMart.Domain.Entities;

[ExcludeFromCodeCoverage]
public class UserRole
{
	public int Id { get; set; }

	public string Role { get; set; } = string.Empty;
}