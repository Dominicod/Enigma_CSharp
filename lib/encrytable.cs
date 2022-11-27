namespace Enigma_CSharp.lib
{
    public class Encryptable
    {
        public static (string Encryption, string OriginalMessage) Encrypt(string message)
        {
            var encryptedMessage = "";
            foreach (var letter in message)
            {
                encryptedMessage += (char)(letter + 1);
            }
            
            return (encryptedMessage, message);
        }
    }
}