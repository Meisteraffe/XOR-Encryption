using System;

namespace XOR_cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Frågar användaren om meddelandet dom vill enkryptera
            Console.WriteLine("Sätt in meddelande för att krypteras: ");
            string input = Console.ReadLine();
            // Frågar användaren vilken enkrypterings nyckel dom vill använda
            Console.WriteLine("Sätt in nyckel för att kryptera med: ");
            string key = Console.ReadLine();

            // Enkrypterar meddelandet med XOR 
            string encrypted = XOREncrypt(input, key);

            // Skriver ut det krypterade meddelandet
            Console.WriteLine("Krypterade meddelande: " + "[" + encrypted + "]");
        }

        static string XOREncrypt(string input, string key)
        {
            // Omvandlar både meddelandet och nyckeln till bytes
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] keyBytes = System.Text.Encoding.ASCII.GetBytes(key);

            // Skapar ett nytt byte array för det enkrypterade meddelandet
            byte[] encryptedBytes = new byte[inputBytes.Length];

            // Enkrypterar meddelandet genom att använda XOR operationen mellan varje byte i meddelandet ock nyckeln
            for (int i = 0; i < inputBytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            // Omvandlar tillbaka det enkrypterade meddelandet tillbaka till bokstäver
            return System.Text.Encoding.ASCII.GetString(encryptedBytes);
        }
    }
}
