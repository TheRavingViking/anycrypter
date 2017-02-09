using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Any_crypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // TODO: List
        /*
         *      
         *      Code netter maken
         *      Comments toevoegen
         *      console comments verwijderen
         *      muziekjes updaten
         *      rickroll toevoegen
         *      max char toevoegen
         *      opmaak
         *      geluiden toevoegen aan de dev branch.
         *      als applicatie compilen en testen.
         *      testen
         * 
         */

          


        //Encrypt the input from the first input field
        private void encrypt()
        {
            
            Console.WriteLine(textBox1.Text.ToCharArray());                                             //TODO: moet nog weg.

            // Set variables
            string s = textBox1.Text;
            int teller = 1;
            int code = 0;
            string ready_To_Hexa = "";
            string hexValue = "";
            string trimmed_String = "";

            // clear text so we can set the new encrypted code
            textBox3.Clear();

            // cycle through the chars from the input
            foreach (char c in s)
            {
                // here we sprankle our magic dust and create the code to encrypt.
                Console.WriteLine((int)c);                                                              //TODO: moet nog weg.
                teller += 1;
                Console.WriteLine(teller);                                                              //TODO: moet nog weg.
                code = ((c * 3) + teller) * 3;
                Console.WriteLine(code);                                                                //TODO: moet nog weg.

                // hexa code maken.
                // hele string converten naar hexa.
                // output hexa in textbox3   
             
                ready_To_Hexa+= code.ToString();

                hexValue = code.ToString("X");
                Console.WriteLine(hexValue);                                                            //TODO: moet nog weg.
                trimmed_String += hexValue;

                textBox3.Text = trimmed_String;
                textBox2.Text = trimmed_String;
            }

        }


        //Decrypt
        private void decrypt()
        {
            Console.WriteLine(textBox2.Text.ToCharArray());                                             //TODO: moet nog weg.
            // Set variables
            int parsedstring = 0;
            int teller = 1;
            int asciiChar = 0;
            string decryptedText = "";
            char[] s = textBox2.Text.ToCharArray();

            List<string> encrypted_Chars = new List<string>();

            for (int i = 0; i < s.Length; i += 3)
            {
                string char_String = "";
                char_String = (s[i].ToString() + s[i+1].ToString() + s[i+2].ToString());
                encrypted_Chars.Add(char_String);
            }

            // clear text so we can set the new encrypted code
            textBox3.Clear();


          



            // here we sprankle our magic dust and create the words from the encryption.
            foreach (string hexValue in encrypted_Chars)
            {
                // terug van hexa code
                // hexa naar deciamal
                // splitten na elke 3 char's 
                // de foreach loop in.

                try
                {
                    parsedstring = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                    Console.WriteLine(hexValue);                                                            //TODO: moet nog weg.
                    Console.WriteLine(parsedstring);                                                        //TODO: moet nog weg.

                    teller += 1;
                    Console.WriteLine(teller);                                                              //TODO: moet nog weg.
                    asciiChar = (parsedstring / 3) - teller;
                    Console.WriteLine(asciiChar);                                                           //TODO: moet nog weg.
                    decryptedText = (Convert.ToChar(asciiChar / 3)).ToString();
                    Console.WriteLine(decryptedText);                                                       //TODO: moet nog weg.
                    textBox3.Text += decryptedText;
                }
                catch (Exception)
                {
                    Console.Write("error");
                    //throw;
                    textBox3.Text = "No valid code";
                }
                

            }
           
        }

        //Textbox 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "karim")
            {
                karimRoll();
            }
            else
            {
                encrypt();
                //startupSound();
            }
        }

        // Keystrokes for textbox 1
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                encrypt();
            }

        }

        //Textbox 2
        private void button2_Click(object sender, EventArgs e)
        {
            decrypt();
            //shutdownSound();
        }

        // Keystrokes for textbox 2
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decrypt();
            }

        }
        private void startupSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"startup.wav");
            simpleSound.Play();

        }
        private void shutdownSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"shutdown.wav");
            simpleSound.Play();

        }

        private void trollSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"troll.wav");
            simpleSound.PlayLooping();

        }

        private void karimRoll()
        {
            trollSound();
            textBox3.Text = "We're no strangers to love" + Environment.NewLine +
"You know the rules and so do I" + Environment.NewLine +
"A full commitment's what I'm thinking of" + Environment.NewLine +
"You wouldn't get this from any other guy" + Environment.NewLine + Environment.NewLine +

"I just want to tell you how I'm feeling" + Environment.NewLine +
"Gotta make you understand" + Environment.NewLine + Environment.NewLine +

"Never gonna give you up, never gonna let you down" + Environment.NewLine +
"Never gonna run around and desert you" + Environment.NewLine +
"Never gonna make you cry, never gonna say goodbye" + Environment.NewLine +
"Never gonna tell a lie and hurt you" + Environment.NewLine + Environment.NewLine +

"We've known each other for so long" + Environment.NewLine +
"Your heart's been aching but you're too shy to say it" + Environment.NewLine +
"Inside we both know what's been going on" + Environment.NewLine +
"We know the game and we're gonna play it" + Environment.NewLine + Environment.NewLine +

"And if you ask me how I'm feeling" + Environment.NewLine +
"Don't tell me you're too blind to see" + Environment.NewLine + Environment.NewLine +

"Never gonna give you up, never gonna let you down" + Environment.NewLine +
"Never gonna run around and desert you" + Environment.NewLine +
"Never gonna make you cry, never gonna say goodbye" + Environment.NewLine +
"Never gonna tell a lie and hurt you" + Environment.NewLine + Environment.NewLine +

"Never gonna give you up, never gonna let you down" + Environment.NewLine +
"Never gonna run around and desert you" + Environment.NewLine +
"Never gonna make you cry, never gonna say goodbye" + Environment.NewLine +
"Never gonna tell a lie and hurt you" + Environment.NewLine + Environment.NewLine +

"We've known each other for so long" + Environment.NewLine +
"Your heart's been aching but you're too shy to say it" + Environment.NewLine +
"Inside we both know what's been going on" + Environment.NewLine +
"We know the game and we're gonna play it" + Environment.NewLine + Environment.NewLine +

"I just want to tell you how I'm feeling" + Environment.NewLine +
"Gotta make you understand" + Environment.NewLine + Environment.NewLine +

"Never gonna give you up, never gonna let you down" + Environment.NewLine +
"Never gonna run around and desert you" + Environment.NewLine +
"Never gonna make you cry, never gonna say goodbye" + Environment.NewLine +
"Never gonna tell a lie and hurt you";
        }

    }
}
