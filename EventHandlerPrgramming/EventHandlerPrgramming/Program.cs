using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerPrgramming
{
    //The signature of the handler method must match the delegate signature
    public delegate void Notify();
    public class Program
    {
        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            //Register with an event using the += operator. Unsubscribe it using the -= operator. 
            //Cannot use the = operator.
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.StartProcess();
            Console.ReadKey();
        }


        public static void bl_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }
    }

    public class ProcessBusinessLogic
    {
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            try
            {

                OnProcessCompleted(true);
            
            }
            catch (Exception ex)
            {
                OnProcessCompleted(false);
                Console.WriteLine(ex.Message);
            }
        }


        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }
}
    
