﻿using System.Security.Cryptography;
using System.Text;
using MimyMart.Application.Common.Interfaces;

namespace MimyMart.Infrastructure.Services;

public class CryptographyService : ICryptographyService
{
    private const string Hash = "b415407e-3f08-43be-8130-46f8146467f7";

    public string Encrypt(string input)
    {
        var data = Encoding.UTF8.GetBytes(input);
        var keys = MD5.HashData(Encoding.UTF8.GetBytes(Hash));

        using var tripleDes = TripleDES.Create();
        tripleDes.Key = keys;
        tripleDes.Mode = CipherMode.ECB;
        tripleDes.Padding = PaddingMode.PKCS7;

        var transform = tripleDes.CreateEncryptor();
        var results = transform.TransformFinalBlock(data, 0, data.Length);

        return Convert.ToBase64String(results, 0, results.Length);
    }

    public string Decrypt(string input)
    {
        var data = Convert.FromBase64String(input);
        var keys = MD5.HashData(Encoding.UTF8.GetBytes(Hash));

        using var tripleDes = TripleDES.Create();
        tripleDes.Key = keys;
        tripleDes.Mode = CipherMode.ECB;
        tripleDes.Padding = PaddingMode.PKCS7;

        var transform = tripleDes.CreateDecryptor();
        var results = transform.TransformFinalBlock(data, 0, data.Length);

        return Encoding.UTF8.GetString(results);
    }
}