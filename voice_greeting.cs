using System;
using System.Media;


namespace POE_Part1
{//start of namespace
    public class voice_greeting
    {//start of class
        public voice_greeting()
        {//start of constructor

            //calling the greet method 
            greet();


        }//end of constructor

        //method to play the voice 

        private void greet()
        {//start of greet method 

            //auto get the path of the voice record
            string paths = AppDomain.CurrentDomain.BaseDirectory;

            //then rename the path
            string fullpath = paths.Replace(@"bin\Debug\", "VoiceGreeting.wav");
            //load the audio , then play the audio after the instance
            SoundPlayer voice_play = new SoundPlayer(fullpath);
            //load the audio
            voice_play.Load();
            //THEN play it 
            voice_play.PlaySync();


        }//end of greet method 



    }//end of class
}//end of namespace