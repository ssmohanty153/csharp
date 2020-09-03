using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
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
        }

        class Program
        {
         
            static void Main()
            {
                
                ISpeaker speaker = SpeakerFactory.CreateSpeaker(Language.German);
                speaker.Speak();
                Console.ReadLine();
            }
        }

        public interface ISpeaker
        {
            void Speak();
        }

        public abstract class Speaker : ISpeaker
        {

          

            public abstract void Speak();

            public virtual void SayHello()
            {
                Console.WriteLine("Hello world.");
            }

           
        }

        public class EnglishSpeaker : Speaker
        {
            public EnglishSpeaker() { }

           
            public override void Speak()
            {
                this.SayHello();
                Console.WriteLine("I speak English.");
            }

           
        }

        public class GermanSpeaker : Speaker
        {
            public GermanSpeaker() { }

           

            public override void Speak()
            {
                Console.WriteLine("I speak German.");
                this.SayHello();
            }

            
        }

        public class SpanishSpeaker : Speaker
        {
            public SpanishSpeaker() { }

         

            public override void Speak()
            {
                Console.WriteLine("I speak Spanish.");
            }

            public override void SayHello()
            {
                throw new ApplicationException("I cannot say Hello World.");
            }

          
        }
    }

