using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bassify
{
    class Bar
    {

        //declaring the list to hold the lines of guitiar tab for this bar.
        private String[] guitarTabLines = new String[6];

        //declaring the list to hold the lines of bass tab for this bar.
        private String[] bassTabLines = new String[4];

        //getters and setters for array items
        public void setGuitarLine(string line, int number)
        {
            guitarTabLines[number] = line;
        }

        public void setBassLine(string line, int number)
        {
            bassTabLines[number] = line;
        }

        public string getGuitarLine(int number)
        {
            return guitarTabLines[number];
        }

        public string getBassLine(int number)
        {
            return bassTabLines[number];
        }

        //function that takes two strings of tab and merges them into a single line. Works with strings (e and G) and (B and D).
        public string mergeTabStrings(string lowerBassStringTab, string higherBassStringTab)
        {
            //creating char list to hold bass G string tab. - creating list with size to avoid exceptions later on.
            List<char> mergedBassLine = new List<char>();
            //adding the G string notes from the guitar tab to the bass tab G string.
            mergedBassLine.InsertRange(0, lowerBassStringTab.ToCharArray());

            //adding the notes from the e string on the guitar to the G string on the bass.
            for (int i = 0; i < higherBassStringTab.Length; i++)
            {
                //checking if char is number
                if ((Char.IsNumber(higherBassStringTab[i])) && (!Char.IsNumber(mergedBassLine[i])))
                {
                    try
                    {
                        //checking if following char is number to catch double digit numbers.
                        //if not number follow standard single digit procedure
                        if (!(Char.IsNumber(higherBassStringTab[i + 1])))
                        {
                            //if it is - add 5 to it and convert it to a char array.
                            double note = Char.GetNumericValue(higherBassStringTab[i]) + 10;
                            char[] noteAsChars = note.ToString().ToCharArray();
                            //insert char array into bass line string
                            mergedBassLine[i] = noteAsChars[0];
                            mergedBassLine[i + 1] = noteAsChars[1];
                        }
                        //this is what happens for double digit numbers
                        else
                        {
                            //adding to digits as string to get single double digit
                            string note = (higherBassStringTab[i].ToString()) + (higherBassStringTab[i + 1].ToString());
                            //converting string to double so that I can add 10 to it as a number
                            double noteAsNum = Double.Parse(note) + 10;
                            //converting double to char arry so it can be added back to bassline
                            char[] noteAsChars = noteAsNum.ToString().ToCharArray();
                            mergedBassLine[i] = noteAsChars[0];
                            mergedBassLine[i + 1] = noteAsChars[1];
                        }
                    }
                    //executed if digit is at the end of the string as new characters need to be added to the string if this is the case.
                    catch (IndexOutOfRangeException e)
                    {
                        double note = Char.GetNumericValue(guitarTabLines[0][i]) + 10;
                        char[] noteAsChars = note.ToString().ToCharArray();
                        //insert char array into bass line string
                        mergedBassLine[i] = noteAsChars[0];
                        mergedBassLine.Add(noteAsChars[1]);
                    }
                }
            }
            //returning the merged bassline string tab.
            return (new string(mergedBassLine.ToArray()));
        }

        public string convertSingleTabString(string guitarString, int index)
        {
            char[] inputGuitarLine = guitarString.ToCharArray();
            char[] bassline = new char[inputGuitarLine.Length];
            //adding chars from input string to bassline if there are know numbers below them.
            bool spotFree = true;
            for (int i = 5; i == index; i--)
            {
                for (int x = 5; x == index; x++)
                {
                    if (!Char.IsNumber(guitarTabLines[x][i]))
                    {
                        spotFree = true;
                    }
                    else
                    {
                        spotFree = false;
                    }
                }
                if (spotFree)
                {
                    bassline[i] = inputGuitarLine[i];
                }
                else
                {
                    bassline[i] = '-';
                }
            }
            return new string(bassline);
        }



        //function which creates bass tab based off of guitar tab in guitarTabLines array.
        public void translateGuitarToBassTab()
        {
            //BASS G STRING
            //merging the strings e and G and returning the result to the G string of the bass tab.
            bassTabLines[0] = this.mergeTabStrings(guitarTabLines[2], guitarTabLines[0]);

            //BASS D STRING
            //merging the strings e and G and returning the result to the G string of the bass tab.
            bassTabLines[1] = this.mergeTabStrings(guitarTabLines[3], guitarTabLines[1]);

            //BASS A STRING
            //adding the A string notes from the guitar tab to the bass tab A string.
            bassTabLines[2] = guitarTabLines[4];

            //BASS E STRING
            //adding the E string notes from the guitar tab to the bass tab E string.
            bassTabLines[3] = guitarTabLines[5];

        }

    }
}
