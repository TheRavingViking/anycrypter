using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Any_crypter
{
    class Encryption
    {

        //Encrypt the input from the first input field
        public static string Encrypt(string encrypt)
        {
            // Set variables
            int counter = 1;
            // our mathematical flavour to encrypt. 
            int ourMagic = 0;
            string readyToHexa = "";
            string hexValueOfChar = "";
            string encryptResult = "";
            
            // cycle through the chars from the input
            foreach (char c in encrypt)
            {
                // here we sprankle our magic dust and create the code to encrypt.
                counter += 1;
                ourMagic = ((c * 3) + counter) * 3;
                readyToHexa += ourMagic.ToString();
                hexValueOfChar = ourMagic.ToString("X");
                encryptResult += hexValueOfChar;
            }

            return encryptResult;

        }

        //Decrypt
        public static string Decrypt(string decrypt)
        {
  
            // Set variables
            string decryptedResult = "";
            int parsedString = 0;
            int counter = 1;
            int asciiChar = 0;
            string decryptedText = "";
            char[] charArray = decrypt.ToCharArray();

            List<string> encrypted_Chars = new List<string>();

            for (int i = 0; i < charArray.Length; i += 3)
            {
                string char_String = "";
                char_String = (charArray[i].ToString() + charArray[i + 1].ToString() + charArray[i + 2].ToString());
                encrypted_Chars.Add(char_String);
            }

            // here we sprankle our magic dust and create the words from the encryption.
            foreach (string hexValue in encrypted_Chars)
            {
                try
                {
                    parsedString = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                    counter += 1;
                    asciiChar = (parsedString / 3) - counter;
                    decryptedText = (Convert.ToChar(asciiChar / 3)).ToString();
                    decryptedResult += decryptedText;
                }
                // if encrypted_Chars cant be parsed an exception will be thrown and returns an string.
                catch (Exception)
                {
                    return "No valid code";
                }
            }

            return decryptedResult;

        }

    }
}
