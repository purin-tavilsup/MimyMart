namespace MimyMart.Application.Common.Interfaces;

public interface ICryptographyService
{
	string Encrypt(string input);
	string Decrypt(string input);
}