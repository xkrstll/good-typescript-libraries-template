using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ATMuto.classes
{
    internal static class Security
    {
        // Encrypts the provided text using AES encryption
        public static string Encrypt(string text)
        {
            // Convert the input text to a byte array using UTF-8 encoding
            var b = Encoding.UTF8.GetBytes(text);

            // Encrypt the byte array using AES and return the encrypted data as a Base64 string
            var encrypted = getAES().CreateEncryptor().TransformFinalBlock(b, 0, b.Length);
            return Convert.ToBase64String(encrypted);
        }

        // Decrypts the provided encrypted string using AES decryption
        public static string Decrypt(string encrypted)
        {
            // Convert the Base64 encrypted string back into a byte array
            var b = Convert.FromBase64String(encrypted);

            // Decrypt the byte array and return the resulting text as a UTF-8 string
            var decrypted = getAES().CreateDecryptor().TransformFinalBlock(b, 0, b.Length);
            return Encoding.UTF8.GetString(decrypted);
        }

        // Creates and configures an AES encryption object
        static Aes getAES()
        {
            // Create a 16-byte array for the AES key (128-bit key size)
            var keyBytes = new byte[16];

            // Define a secret key string (32 characters long for 256-bit encryption, but we'll use only the first 16 bytes)
            var skeyBytes = Encoding.UTF8.GetBytes("12345678901234567890123456789012");

            // Copy the first 16 bytes of the key string into the keyBytes array
            Array.Copy(skeyBytes, keyBytes, Math.Min(keyBytes.Length, skeyBytes.Length));

            // Create a new AES instance and set its properties
            Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;  // Set the mode to CBC (Cipher Block Chaining)
            aes.Padding = PaddingMode.PKCS7;  // Set the padding mode to PKCS7
            aes.KeySize = 128;  // Set the key size to 128 bits (16 bytes)
            aes.Key = keyBytes;  // Assign the 128-bit key to the AES object
            aes.IV = keyBytes;   // Use the same key as the Initialization Vector (IV) for simplicity

            return aes;  // Return the configured AES object
        }
    }
}
