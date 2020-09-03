using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventHandlerPrgramming
{
	
	class LastProgram
	{
		public static void Main()
		{
			ProcessBusinessLogic2 bl = new ProcessBusinessLogic2();
			//Register with an event using the += operator. 
			//Unsubscribe it using the -= operator.
			//Cannot use the = operator.
			bl.ProcessCompleted += bl_ProcessCompleted;
			bl.StartProcess();
			Console.ReadKey();

		}


		public static void bl_ProcessCompleted(object sender, ProcessEventArgs e)
		{
			Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
			Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
		}
	}

	

	public class ProcessBusinessLogic2
	{
		//Use built-in delegate EventHandler or EventHandler<TEventArgs> for common events.
		public event EventHandler<ProcessEventArgs> ProcessCompleted;

		public void StartProcess()
		{
			var data = new ProcessEventArgs();

			try
			{
				Console.WriteLine("Process Started!");


				data.IsSuccessful = true;
				data.CompletionTime = DateTime.Now;
				//Name the method which raises an event prefixed with "On" with the event name.
				OnProcessCompleted(data);
			}
			catch (Exception ex)
			{
				data.IsSuccessful = false;
				data.CompletionTime = DateTime.Now;
				//Name the method which raises an event prefixed with "On" with the event name.
				OnProcessCompleted(data);
				Console.WriteLine(ex.Message);
			}
		}

		protected virtual void OnProcessCompleted(ProcessEventArgs e)
		{
			ProcessCompleted?.Invoke(this, e);
		}
	}
	public class ProcessEventArgs : EventArgs
	{
		public bool IsSuccessful { get; set; }
		public DateTime CompletionTime { get; set; }

	}
}

