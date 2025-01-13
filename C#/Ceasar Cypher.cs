using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("What is your secret message?");
      string secretMsg = Console.ReadLine();

      char[] secretMessage = secretMsg.ToCharArray();
      char[] encryptedArray = new char[secretMessage.Length];

      for (int i=0; i<secretMessage.Length; i++)
      {
        char letter = secretMessage[i];
        int index = Array.IndexOf(alphabet, letter);
        char newLetter = alphabet[(index+3)%alphabet.Length];
        encryptedArray[i] = newLetter;
      }
     string encryptedMsg = string.Join("", encryptedArray);
     Console.WriteLine(encryptedMsg);
    }
  }
}


/* The app doesn’t work with uppercase letters. Fix that by converting any message to lowercase.
The app doesn’t work with symbols, like ! or ?. Skip any symbols in your loop so that they are not encrypted.
Rewrite the loop as a method Encrypt() which takes a character array and key and returns an encrypted character array .
Write a Decrypt() method which takes a character array and key and returns a decrypted character array.

char[] secretMessage = {'h', 'e', 'l', 'l', 'o'};
 
//encrypted should equal  {'k', 'h', 'o', 'o', 'r'}
string encrypted = Encrypt(secretMessage, 3);
 
//decrypted should equal {'h', 'e', 'l', 'l', 'o'}
string decrypted = Decrypt(encrypted, 3); */