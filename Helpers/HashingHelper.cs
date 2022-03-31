using System;
using System.Security.Cryptography;

namespace SpotOps.Api.Helpers;

public class HashingHelper
{
    /// <summary>
    ///     Create a new hash using password-Based Key Derivation Function 2.
    /// </summary>
    /// <param name="password"></param>
    /// <param name="salt"></param>
    /// <returns></returns>
    public static string HashUsingPbkdf2(string password, string? salt)
    {
        using var bytes =
            new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), 10000, HashAlgorithmName.SHA256);
        var derivedRandomKey = bytes.GetBytes(32);
        var hash = Convert.ToBase64String(derivedRandomKey);
        return hash;
    }
}