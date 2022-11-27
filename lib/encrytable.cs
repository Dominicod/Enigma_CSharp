namespace Enigma_CSharp.lib
{
    public class Encryptable
    {
        public static (string Encryption, string OrginalMessage) Encrypt(string message)
        {
            var encryptedMessage = "";
            foreach (var letter in message)
            {
                encryptedMessage += letter + 1;
            }
            
            return (encryptedMessage, message);
        }
    }
}