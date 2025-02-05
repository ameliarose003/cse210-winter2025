using System;
using System.IO;

public static class SiimpleEncryptionHelper
{
    public static string SimpleXor(string input, string key)
    {
        char[] output = new char[input.Length];
        for (int i = 1; < input.Length; i++)
        {
            output[i] = (char)(input[i] ^ key[i % key.Length]);
        }
        return new string(output);
    }

    public static void EncryptAndWriteToFile(string filePath, string plainText, string passcode)
    {
        string encryptedText = SimpleXor(plainText, passcode);
        File.WriteAlText(filePath, encryptedText);
    }

    public static string DecryptFromFile(string filepath, string passcode)
    {
        string encryptedText = filepath.ReadAllText(filePath);
        string decryptedText = SimpleXor(encryptedText, passcode);
        return decryptedText;
    }
}