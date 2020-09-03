using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer
{
    public enum Language
    {
        English, German, Spanish
    }

    public class SpeakerFactory
    {
        public static ISpeaker CreateSpeaker(Language language)
        {
            switch (language)
            {
                case Language.English:
                    return new EnglishSpeaker();
                case Language.German:
                    return new GermanSpeaker();
                case Language.Spanish:
                    return new SpanishSpeaker();
                default:
                    throw new ApplicationException("No speaker can speak such language");
            }
        }


        
        static void Main()
        {
           
            ISpeaker speaker = SpeakerFactory.CreateSpeaker(Language.English);
            speaker.Speak();
            Console.ReadLine();
        }

        public interface ISpeaker
        {
            void Speak();
        }

        public class EnglishSpeaker : ISpeaker
        {
            public EnglishSpeaker() { }



            public void Speak()
            {
                Console.WriteLine("I speak English.");
            }


        }

        public class GermanSpeaker : ISpeaker
        {
            public GermanSpeaker() { }



            public void Speak()
            {
                Console.WriteLine("I speak German.");
            }


        }

        public class SpanishSpeaker : ISpeaker
        {
            public SpanishSpeaker() { }



            public void Speak()
            {
                Console.WriteLine("I speak Spanish.");
            }


        }
    }
}