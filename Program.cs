using System;
using Enigma_CSharp.lib;

namespace Enigma_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            (string encryption, string orginalMessage) message = Encryptable.Encrypt(args[0]);
            Console.WriteLine($"Encrypted Message: {message.encryption}, Oringal Message: {message.orginalMessage}");
        }
    }
}