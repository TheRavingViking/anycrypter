using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Any_crypter
{
    class Sounds
    {

        //sounds
        public static void startupSound()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"startup.wav");
                simpleSound.Play();
            }
            catch (Exception)
            {

            }

        }

        public static void shutdownSound()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"shutdown.wav");
                simpleSound.Play();
            }
            catch (Exception)
            {

            }

        }

        public static void rewardSound()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer(@"reward.wav");
                simpleSound.Play();
            }
            catch (Exception)
            {

            }

        }
    }
}
