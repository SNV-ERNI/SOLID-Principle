namespace OpenClosePrinciple;
    public class RSAEncryption : EncryptionStrategy
    {
        public override string Encrypt(string data)
        {
            return "RSA Encrypted data";
        }
    }