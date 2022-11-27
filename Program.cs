using Enigma_CSharp.lib;

namespace Enigma_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Would you like to encrypt(0) a message, or decrypt(1) a message:");
            var userResponse = Console.ReadLine();

            switch (userResponse)
            {
                case "0":
                    Encrypt();
                    return;
                case "1":
                    Decrypt();
                    return;
                default:
                    Console.WriteLine("Error: Incorrect argument, can either be 0, or 1");
                    return;
            }
        }

        private static void Encrypt()
        {
            Console.WriteLine("Please enter a message(string), followed by a key(number):");
            var userResponse = Console.ReadLine().Split(" ");
            
            var message = Encryptable.Encrypt(userResponse[0], Int16.Parse(userResponse[1]));
            Console.WriteLine($"Encrypted Message: {message.Encryption}, Original Message: {message.OriginalMessage}");
        }
        
        private static void Decrypt()
        {
            Console.WriteLine("Please enter the encrypted message(string), followed by the key used(number):");
            var userResponse = Console.ReadLine().Split(" ");
            
            var message = Decryptable.Decrypt(userResponse[0], Int16.Parse(userResponse[1]));
            Console.WriteLine($"Encrypted Message: {message.Encryption}, Original Message: {message.Decryption}");
        }
    }
}