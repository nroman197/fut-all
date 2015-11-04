using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace fut_all
{
    public class Encrypt
    {
        #region Encriptar
        //• Name: Encriptar
        //• Version: 1.0
        //• Date: 09/26/2013
        //• Description: Call the function Encriptar to encrypt information.
        //• References: System.Security.Cryptography;
        //• Parameters: string textoQueEncriptaremos
        //• Return: string value 
        //• Exception:
        //• Throws:

        public static string Encriptar(string textoQueEncriptaremos)
        {
            return Encriptar(textoQueEncriptaremos, "pass75dc@avz10", "s@lAvz", "MD5", 1, "@1B2c3D4e5F6g7H8", 128);
        }

        //• Name: Encriptar
        //• Version: 1.0
        //• Date: 09/26/2013
        //• Description: This function is called by Encriptar, here is the process to encrypt the information.
        //• References: System.Security.Cryptography;
        //• Parameters: string textoQueEncriptaremos, string passBase, string saltValue,
        //              string hashAlgorithm, int passwordIterations, string initVector, int keySize
        //• Return: string value
        //• Exception:
        //• Throws:

        public static string Encriptar(string textoQueEncriptaremos, string passBase, string saltValue,
                                       string hashAlgorithm, int passwordIterations, string initVector, int keySize)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(textoQueEncriptaremos);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passBase,
              saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged()
            {
                Mode = CipherMode.CBC
            };
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes,
              initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor,
             CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);
            return cipherText;
        }
        #endregion

        #region Desencriptar
        //• Name: Desencriptar
        //• Version: 1.0
        //• Date: 09/26/2013
        //• Description: Call the function Desencriptar to decrypt information.
        //• References: System.Security.Cryptography;
        //• Parameters: string value
        //• Return: string value
        //• Exception:
        //• Throws:

        public static string Desencriptar(string textoEncriptado)
        {
            return Desencriptar(textoEncriptado, "pass75dc@avz10", "s@lAvz", "MD5", 1, "@1B2c3D4e5F6g7H8", 128);
        }

        //• Name: Desencriptar
        //• Version: 1.0
        //• Date: 09/26/2013
        //• Description: This function is called by Desencriptar, here is the process to decrypt the information.
        //• References: System.Security.Cryptography;
        //• Parameters: string textoEncriptado, string passBase, string saltValue,
        //              string hashAlgorithm, int passwordIterations, string initVector,
        //              int keySize
        //• Return: string value
        //• Exception:
        //• Throws:

        public static string Desencriptar(string textoEncriptado, string passBase, string saltValue,
                                          string hashAlgorithm, int passwordIterations, string initVector,
                                          int keySize)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
            byte[] cipherTextBytes = Convert.FromBase64String(textoEncriptado);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passBase,
              saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged()
            {
                Mode = CipherMode.CBC
            };
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes,
              initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor,
              CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0,
              plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            string plainText = Encoding.UTF8.GetString(plainTextBytes, 0,
              decryptedByteCount);
            return plainText;
        }
        #endregion
    }
}