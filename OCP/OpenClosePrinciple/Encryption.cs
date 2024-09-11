namespace OpenClosePrinciple;

    public class Encryption
    {
        private readonly EncryptionStrategy _encryptionStrategy;

        public Encryption(EncryptionStrategy encryptionStrategy)
        {
            _encryptionStrategy = encryptionStrategy;
        }

        public string Encrypt(string data)
        {
            return _encryptionStrategy.Encrypt(data);
        }
    }