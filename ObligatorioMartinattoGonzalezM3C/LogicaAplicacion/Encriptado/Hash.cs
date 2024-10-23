﻿using System;
using System.Security.Cryptography;
using System.Text;

public class Hash
{
    public Hash() { }
    public string GetHashSha256(string text)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text); 
        using (SHA256 hashAlgorithm = SHA256.Create()) 
        {
            byte[] hash = hashAlgorithm.ComputeHash(bytes); 
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
