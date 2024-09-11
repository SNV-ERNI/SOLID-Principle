namespace OpenClosePrinciple;
    class Program
    {
        static void Main(string[] args)
        {
            EncryptionStrategy aesEncryption = new AESEncryption();
            Encryption encryption = new Encryption(aesEncryption);
            string encryptedData = encryption.Encrypt("Hello AES");
            Console.WriteLine(encryptedData);

            EncryptionStrategy rsaEncryption = new RSAEncryption();
            encryption = new Encryption(rsaEncryption);
            encryptedData = encryption.Encrypt("Hello RSA");
            Console.WriteLine(encryptedData);
            
            EncryptionStrategy sha256Encryption = new SHA256Encryption();
            encryption = new Encryption(sha256Encryption);
            encryptedData = encryption.Encrypt("Hello SHA");
            Console.WriteLine(encryptedData);
        }
    }
