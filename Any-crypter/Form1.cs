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

                ready_To_Hexa += code.ToString();

                hexValue = code.ToString("X");
                Console.WriteLine(hexValue);                                                            //TODO: moet nog weg.
                trimmed_String += hexValue;

                textBox3.Text = trimmed_String;
                textBox2.Text = trimmed_String;
            }

        }


        //Decrypt
        private void decrypt(string encrypted_String = null)
        {
            // Set variables
            int parsedstring = 0;
            int teller = 1;
            int asciiChar = 0;
            string decryptedText = "";
            char[] s = encrypted_String.ToCharArray();

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
                try
                {
                    parsedstring = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                    teller += 1;
                    asciiChar = (parsedstring / 3) - teller;
                    decryptedText = (Convert.ToChar(asciiChar / 3)).ToString();
                    textBox3.Text += decryptedText;
                }
                catch (Exception)
                {
                    Console.Write("error");
                    textBox3.Text = "No valid code";
                }
            }
           
        }

        //Textbox 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "karim")
            {
                csharpReward();
            }
            else
            {
                encrypt();
                startupSound();
            }
        }

        // Keystrokes for textbox 1
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "karim")
                {
                    csharpReward();
                }
                else
                {
                    encrypt();
                    startupSound();
                }
            }

        }

        //Textbox 2
        private void button2_Click(object sender, EventArgs e)
        {
            string encrypted_String = textBox2.Text;
            decrypt(encrypted_String);
            shutdownSound();
        }

        // Keystrokes for textbox 2
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string encrypted_String = textBox2.Text;
                decrypt(encrypted_String);
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

        private void rewardSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"reward.wav");
            simpleSound.Play();

        }

        //Reward
        private void csharpReward()
        {
            rewardSound();
            string encrypted_String = "2C439643239C4141353B74023FC3FF38D1473C93DE4563C015647A42345C1624624381D716E42F3E147D3E745F18040244D44744A3D819244140548F19E4C246B4A41AA4114774C24742251BC35D42F4CB4354AD1CE45049B4954984261E04C54E34A71EC4384D44BC4F54B946220144D4C546E20D4744805014864FE5132225464EF52829A2313D24A45404AA5222434C551050A50D49B25550D4A45014CE26458853156A2704CE55859A2E827F5404F258E4F857029151355E55855B4E92A35914F25CD2AF53157C57F51F5105E25313332CA46B53D5D95435BB2DC55E5A95A35A65342EE5E55615A35A62FD5493035B259A57930F55B5D357C31B5A661E60661B32A64E5F7630";
            decrypt(encrypted_String);
            textBox2.Text = encrypted_String;
        }


    }
}
