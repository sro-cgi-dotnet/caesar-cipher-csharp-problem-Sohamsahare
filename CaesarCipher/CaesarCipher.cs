using System;
using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        
        public static string Rotate(string text, int shiftKey)
        {
            const int upperAlphabet = 65;
            const int lowerAlphabet = 97;
            // ASCII code for a -> 97 z -> 122 && A -> 65 Z -> 90
            StringBuilder cipher = new StringBuilder();
            int charInAscii = 0;
            foreach(char c in text){
                charInAscii = c;
                // if alphabet is a uppercase
                if(charInAscii >= 'A' && charInAscii <= 'Z'){
                    charInAscii = CaesarCipherHelper(charInAscii, upperAlphabet, shiftKey);
                }
                // if alphabet is a lowercase
                else if(charInAscii >= 'a' && charInAscii <= 'z'){
                    charInAscii = CaesarCipherHelper(charInAscii, lowerAlphabet, shiftKey);
                }
                // typecasting an ascii value to a character
                char cipherChar = (char)charInAscii;
                // typcasting a character to a string and appending it to output string
                cipher.Append(cipherChar);
            }
            return cipher.ToString();
        }
        // a character's ascii value is bought in a range of 0 - 26
        // and later shiftkey is added to it .
        // value can have a max value of 25 after which it goes to 0 again
        // later we add back the offset to convert it back to the case it belonged to
        private static int CaesarCipherHelper(int charInAscii, int alphabetStart, int shiftKey){
            charInAscii = charInAscii - alphabetStart + shiftKey;
            charInAscii %= 26;
            charInAscii += alphabetStart;
            return charInAscii;
        }
    }
}
