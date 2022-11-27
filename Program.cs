using Enigma_CSharp.lib;

namespace Enigma_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static void Encrypt(string[] args)
        {
            var message = Encryptable.Encrypt(args[0], Int16.Parse(args[1]));
            Console.WriteLine($"Encrypted Message: {message.Encryption}, Original Message: {message.OriginalMessage}");
        }

        public static void Decrypt(string[] args)
        {
            
        }
    }
}