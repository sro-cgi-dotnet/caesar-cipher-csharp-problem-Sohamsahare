﻿using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        
        public static string Rotate(string text, int shiftKey)
        {
            const int upperAlphabet = 65;
            const int lowerAlphabet = 97;
            // ASCII code for a -> 97 z -> 122 && A -> 65 Z -> 90
            string cipher = "";
            int charInAscii = 0;
            foreach(char c in text){
                charInAscii = c;
                // if alphabet is a uppercase
                if(charInAscii >= 65 && charInAscii <= 90){
                    charInAscii = CaesarCipherHelper(charInAscii, upperAlphabet, shiftKey);
                }
                // if alphabet is a lowercase
                else if(charInAscii >= 97 && charInAscii <= 122){
                    charInAscii = CaesarCipherHelper(charInAscii, lowerAlphabet, shiftKey);
                }
                char cipherChar = (char)charInAscii;
                cipher += cipherChar.ToString();
            }
            return cipher;
        }

        private static int CaesarCipherHelper(int charInAscii, int alphabetStart, int shiftKey){
            charInAscii = charInAscii - alphabetStart + shiftKey;
            charInAscii %= 26;
            charInAscii += alphabetStart;
            return charInAscii;
        }
    }
}
