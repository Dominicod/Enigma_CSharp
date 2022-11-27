using System;
using Enigma_CSharp.lib;

namespace Enigma_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var message = Encryptable.Encrypt(args[0]);
            Console.WriteLine($"Encrypted Message: {message.Encryption}, Original Message: {message.OriginalMessage}");
        }
    }
}