namespace OldPhonePad
{
    public class OldPhonePadFunctions
    {
        /// <summary>
        /// Display output according to input like old key pad phone.
        /// </summary>
        /// <example>
        /// OldPhonePad("33#") => output: E
        /// OldPhonePad("227*#") => output: B
        /// OldPhonePad("4433555 555666#") => output: HELLO
        /// OldPhonePad("8 88777444666*664#") => output: TURING
        /// </example>
        /// <param name="input message"></param>
        /// <returns>message to be showed</returns>

        public static string OldPhonePad(string typeMessages)
        {
            String completeOutput = "";
            if (typeMessages != null)
            {
                // split message with space
                string[] spaceSplit = typeMessages.Split(' ');
                for (int i = 0; i < spaceSplit.Length; i++)
                {
                    OldPhonePadFunctions opp = new OldPhonePadFunctions();

                    //seperate message with identical chars
                    List<string> parts = opp.seperate(spaceSplit[i]);
                    for (int j = 0; j < parts.Count; j++)
                    {
                        //get count of identical chars
                        int chCount = opp.getCounts(parts[j]);
                        char ch = parts[j][0];
                        //if input is '*', delete chars based on count of *.
                        if (ch == '*')
                        {
                            if (completeOutput.Length > 0)
                            {
                                for (int k = 0; k < chCount; k++)
                                   completeOutput = completeOutput.Remove(completeOutput.Length - 1);                             
                            }
                        }
                        //if input is '#', no need to take consideration.
                        else if (ch == '#')
                        {
                            if (completeOutput.Length > 0)
                               completeOutput = completeOutput.Remove(completeOutput.Length);                            
                        }
                        //if input is others, show char accordingly.
                        else
                        {
                            ch = opp.displayChar(ch, chCount);
                            completeOutput += ch;
                        } //end of checking if character is *
                    } // end of for loop parts                    
                } // end of for loop spacesplit
            } // end of checking if string is null or empty
            else completeOutput = "Null Input";
            return completeOutput;
        }
        /// <summary>
        /// Display char according to input number and its count.
        /// </summary>
        /// <param name="inputChar">Input Number</param>
        /// <param name="charCount">Number Count</param>
        /// <returns>Resulted Char</returns>
        private char displayChar(char inputChar, int charCount)
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
                    else displayChar = 'S';
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
                case '0':
                    displayChar = ' ';
                    break;

            }
            return displayChar;
        }
        /// <summary>
        /// Get the count of inputs.
        /// </summary>
        /// <param name="input">identical number sequence</param>
        /// <returns></returns>
        private int getCounts(string input)
        {
            int inputcount = input.Length;
            //Remainder is calculated if more than 4 in the case of 7 and 9.
            if (input.StartsWith('7') || input.StartsWith('9'))
            {
                if (input.Length > 4)
                {
                    inputcount = input.Length % 4;
                }
            }
            //Remainder is calculated if more than 3 in the case of others.
            else
            {
                if (input.Length > 3)
                {
                    inputcount = input.Length % 3;
                }

            }
            return inputcount;
        }
        /// <summary>
        /// Generate String List of Identical Chars.
        /// </summary>
        /// <param name="sequences">input string</param>
        /// <returns>String List of Identical Chars</returns>
        private List<String> seperate(string sequences)
        {
            List<string> individual = new List<string>();
            char[] chars = sequences.ToCharArray();
            if (chars.Length > 0)
            {
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
            }
            return individual;
        }
        /// <summary>
        /// Main Function
        /// </summary>
        /// <param name="args">input</param>
        static void Main(string[] args)
        {
            String display = OldPhonePadFunctions.OldPhonePad("      ");
            Console.WriteLine(display);
        }
    }
}
