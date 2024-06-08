using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Xml;

namespace OldPhonePad
{
    public class OldPhonePadFunctions
    {

        public static String OldPhonePad(string typeMessages)
        {
            String completeOutput="";
            if(typeMessages != null && typeMessages != "")
            { 
             string[] spaceSplit = typeMessages.Split(' ');
                for (int i = 0; i < spaceSplit.Length; i++)
                {
                    Console.WriteLine("Space Split : " + spaceSplit[i]);
                    OldPhonePadFunctions opp = new OldPhonePadFunctions();
                    List<string> parts = opp.seperate(spaceSplit[i]);
                    for (int j = 0; j < parts.Count; j++)
                    {
                        Console.WriteLine("wording......" + parts[j]);
                        int chCount = opp.getCounts(parts[j]);
                        char ch = parts[j][0];
                        if (ch == '*')
                        {
                            if (completeOutput.Length > 0)
                            {
                                for (int k = 0; k < chCount; k++)
                                {
                                    completeOutput = completeOutput.Remove(completeOutput.Length - 1);
                                    Console.WriteLine("After Removing..........." + completeOutput);
                                }
                            }
                        }
                        else
                        {
                            ch = opp.displayChar(ch, chCount);
                            completeOutput += ch;
                            Console.WriteLine("Complete Output..........." + completeOutput);
                        } //end of checking if character is *
                    } // end of for loop parts                    
                } // end of for loop spacesplit
             } // end of checking if string is null or empty
            else completeOutput = "No input or No words to Display";
            return completeOutput;
        }

        public char displayChar(char inputChar, int charCount)
        {
            char displayChar = '\0';
            switch (inputChar)
            {
                case '1':
                    if (charCount == 1) displayChar = '&';
                    else if (charCount == 2) displayChar = '\'';
                    else displayChar = '(';
                    break;
                case '2':
                    if (charCount == 1) displayChar = 'A';
                    else if (charCount == 2) displayChar = 'B';
                    else displayChar = 'C';
                    break;
                case '3':
                    if (charCount == 1) displayChar = 'D';
                    else if (charCount == 2) displayChar = 'E';
                    else displayChar = 'F';
                    break;
                case '4':
                    if (charCount == 1) displayChar = 'G';
                    else if (charCount == 2) displayChar = 'H';
                    else displayChar = 'I';
                    break;
                case '5':
                    if (charCount == 1) displayChar = 'J';
                    else if (charCount == 2) displayChar = 'K';
                    else displayChar = 'L';
                    break;
                case '6':
                    if (charCount == 1) displayChar = 'M';
                    else if (charCount == 2) displayChar = 'N';
                    else displayChar = 'O';
                    break;
                case '7':
                    if (charCount == 1) displayChar = 'P';
                    else if (charCount == 2) displayChar = 'Q';
                    else if (charCount == 3) displayChar = 'R';
                    else displayChar = 'O';
                    break;
                case '8':
                    if (charCount == 1) displayChar = 'T';
                    else if (charCount == 2) displayChar = 'U';
                    else displayChar = 'V';
                    break;
                case '9':
                    if (charCount == 1) displayChar = 'W';
                    else if (charCount == 2) displayChar = 'X';
                    else if (charCount == 3) displayChar = 'Y';
                    else displayChar = 'Z';
                    break;
            }
            return displayChar;
        }

        public int getCounts(string input)
        {
            int inputcount=input.Length;
            if (input.StartsWith('7') || input.StartsWith('9'))
            {
                if (input.Length > 4)
                {
                    inputcount = input.Length % 4;
                }
            }
            else
            {
                if (input.Length > 4)
                {
                    inputcount = input.Length % 3;
                }

            }
            return inputcount;
        }

        public List<String> seperate(string squences)
        {
            List<string> individual = new List<string>();
            char[] chars = squences.ToCharArray();
            string temp = chars[0].ToString();
            
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i - 1] != chars[i])
                {
                    individual.Add(temp);
                    temp = chars[i].ToString();
                }
                else
                {
                    temp += chars[i];
                }
               
            }
            individual.Add(temp);
            return individual; 
        }
        public string showChars(string splitMessage)
        {
            char[] chars = splitMessage.ToCharArray();
            String temp = "";
            for (int i = chars.Length-1; i>-1; i--)
            {
                Console.WriteLine("i:" + i + " value:" + chars[i]);
                switch (chars[i])
                {                    
                    case '1':
                        if (chars[i - 2] == '1' && chars[i - 1] == '1') temp = '('+temp;
                        else if (chars[i - 1] == '1') temp='\''+ temp;
                        else temp='&'+temp;
                        break;
                    case '2':
                        if (i - 2 == '2' && i - 1 == '2') temp = 'C' + temp;
                        else if (i - 1 == '2') temp = 'B' + temp;
                        else temp = 'A' + temp;
                        break;
                    case '3':
                        if (i - 2 == '3' && i - 1 =='3') temp = 'F' + temp;
                        else if (i - 1 == '3') temp = 'E' + temp;
                        else temp = 'D' + temp;
                        break;
                    case '4':
                        if (i - 2 == '4' && i - 1 == '4') temp = 'I' + temp;
                        else if (i - 1 == '4') temp = 'H' + temp;
                        else temp = 'G' + temp;
                        break;
                    case '5':
                        if (i - 2 == '5' && i - 1 == '5') temp = 'L' + temp;
                        else if (i - 1 == '5') temp = 'K' + temp;
                        else temp = 'J' + temp;
                        break;
                    case '6':
                        if (i - 2 == '6' && i - 1 == '6') temp = 'O' + temp;
                        else if (i - 1 == '6') temp = 'N' + temp;
                        else temp = 'M' + temp;
                        break;
                    case '7':
                        if (i-3=='7' && i - 2 == '7' && i - 1 == '7') temp = 'S' + temp;
                        else if (i - 2 == '7' && i - 1 == '7') temp = 'R' + temp;
                        else if (i - 1 == '7') temp = 'Q' + temp;
                        else temp = 'P' + temp;
                        break;
                    case '8':
                        if (i - 2 == '8' && i - 1 == '8') temp = 'V' + temp;
                        else if (i - 1 == '8') temp = 'U' + temp;
                        else temp = 'T' + temp;
                        break;
                    case '9':
                        if (i - 3 == '9' && i - 2 == '9' && i - 1 == '9') temp = 'Z' + temp;
                        else if (i - 2 == '9' && i - 1 == '9') temp = 'Y' + temp;
                        else if (i - 1 == '9') temp = 'X' + temp;
                        else temp = 'W' + temp;
                        break;
                    case '*':
                        temp.Remove(temp.Length-1);
                        break;
                    case ' ': break;
                    default: 
                        break;
                }
            }
            return temp;
        }
       
        static void Main(string[] args)
        {
            String display= OldPhonePadFunctions.OldPhonePad("8 88 777444666*664#");
            Console.WriteLine(display);

        }
    }
}
