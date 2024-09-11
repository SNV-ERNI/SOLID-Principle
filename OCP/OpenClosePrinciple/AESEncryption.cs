namespace OpenClosePrinciple;
    public class AESEncryption : EncryptionStrategy
    {
        public override string Encrypt(string data)
        {
            return "AES Encrypted data";
        }
    }