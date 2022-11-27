namespace Enigma_CSharp.lib
{
    public class Encryptable
    {
        public static (string Encryption, string OriginalMessage) Encrypt(string message, int key)
        {
            var encryptedMessage = "";
            foreach (var letter in message)
            {
                encryptedMessage += (char)(letter + key);
            }
            
            return (encryptedMessage, message);
        }
    }
}