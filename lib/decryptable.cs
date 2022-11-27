namespace Enigma_CSharp.lib;

public class Decryptable
{
    public static (string Encryption, string Decryption) Decrypt(string encryption, int key)
    {
        var decryptedMessage = "";
        foreach (var letter in encryption)
        {
            decryptedMessage += (char)(letter - key);
        }
            
        return (encryption, decryptedMessage);
    }
}