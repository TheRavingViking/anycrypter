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

        // Encrypt a textvalue
        private void encrypt()
        {
            string encryptedResult = "";
            // clear text so we can set the new encrypted code
            textBox3.Clear();
            // here we call the function encrypt in Encryption class and we retrun the encrypted value
            encryptedResult = Encryption.Encrypt(textBox1.Text);
            textBox3.Text = encryptedResult;
            textBox2.Text = encryptedResult;
          
        }
        
       
        // Decrypt a textvalue
        private void decrypt(string encrypted_String = null)
        {
            string decryptedResult = "";
            // clear text so we can set the new decrypted code
            textBox3.Clear();
            // here we call the function decrypt in Encryption class and we retrun the decrypted value
            decryptedResult = Encryption.Decrypt(encrypted_String);
            textBox3.Text = decryptedResult;

        }

        //Textbox 1
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1_Input();
        }

        // Keystrokes for textbox 1
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1_Input();
            }

        }

        // call the function encrypt()
        private void textBox1_Input()
        {
            if (textBox1.Text == "karim" || textBox1.Text == "Karim")
            {
                csharpReward();
            }
            else
            {
                encrypt();
                Sounds.startupSound();
            }
        }

        //Textbox 2
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2_Input();
        }

        // Keystrokes for textbox 2
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_Input();
            }

        }

        //  call the function decrypt()
        private void textBox2_Input()
        {
            string encrypted_String = textBox2.Text;
            decrypt(encrypted_String);
            Sounds.shutdownSound();
        }

        //Reward
        private void csharpReward()
        {
            Sounds.rewardSound();
            string encrypted_String = "2C439643239C4141353B74023FC3FF38D1473C93DE4563C015647A42345C1624624381D716E42F3E147D3E745F18040244D44744A3D819244140548F19E4C246B4A41AA4114774C24742251BC35D42F4CB4354AD1CE45049B4954984261E04C54E34A71EC4384D44BC4F54B946220144D4C546E20D4744805014864FE5132225464EF52829A2313D24A45404AA5222434C551050A50D49B25550D4A45014CE26458853156A2704CE55859A2E827F5404F258E4F857029151355E55855B4E92A35914F25CD2AF53157C57F51F5105E25313332CA46B53D5D95435BB2DC55E5A95A35A65342EE5E55615A35A62FD5493035B259A57930F55B5D357C31B5A661E60661B32A64E5F7630";
            decrypt(encrypted_String);
            textBox2.Text = encrypted_String;
        }


    }
}
