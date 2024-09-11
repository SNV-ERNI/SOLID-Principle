namespace OpenClosePrinciple;

    public class SHA256Encryption : EncryptionStrategy
    {
        public override string Encrypt(string data)
        {
            return "SHA256 Encrypted data";
        }
    }