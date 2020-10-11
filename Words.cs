using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;

namespace AssignmentFour
{
    class Words

    {
        public static string CountCharactersInSentence(string inputString)
            // A method is always within the class brackets and followed by curly brackets
            //this is a string method and we need to return string value. All methods methods require you to set a return other wise if won't work

        {
            string wordNumber = inputString;
            string countLetter = "";
            //this line above will be used at the end of the code 

            wordNumber = wordNumber.Replace(" ", string.Empty);
            //this code is making sure that we do not count the black spaces as when we ran it before without the above it counted it which is not what we wanted
            while (wordNumber != "")
            //this vale is hello world - for what while loop means above
            //while loop checks if we have an empty sentence if not then it continues 
            // using a while loop because we would like to divide the sentence or text that we are using into characters and be able to check how many times each letter is used in the sentence
            // so below we have curly brackets as we need to set a return for the while loop but first we are declaring new variables for each character
            {
                char letters = wordNumber[0];
                // we are now changing the string into an array and the [0] is because we want it to look at the first letter of the imput string this would be technically the "H" in hello world due to characters starting with zero
                int repeats = 1;
                // we created a interger to help count the individual letters in the sentence

                for (int count = 1; count < wordNumber.Length; count++)
                    //we declaring the for look above in the brackets and the .Length is to make sure it reads the entire sentence that we use anf the count++ is to ensure it adds on if there are more than one of each letter
                {
                    if (wordNumber[count] == letters)
                        // this if statement is to basically compare the array string wordNumber[0] to letters because letters in basically refereing to "H" in hello world

                    {
                        repeats++;
                        //if it a repeat we are asking for it to add 1 basically this is how the counting process starts if it does equal to the previous number it continues

                    }
                }
                // we are now still in the while loop but outside of the for loop and if statement coding
                countLetter += " " + letters + " --> " + repeats + " ";
                //so the above line is basically defining what we want to happen from the sentence that we need the characters to be counted 

                wordNumber  = wordNumber.Replace(new String(letters, 1), string.Empty);
                // the above line before we initialise the first character of the sentence it will pick up any blanks like when you normally run your code
                // this code helps to prevent the code from out putting a blank screen as it is the first character technically


            }

            return countLetter;
        }

    }
}
