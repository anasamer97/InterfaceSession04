using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal interface INotificationService
	{
		void SendNotification(string recipient, string message);  // Method to send a notification

	}


	// Implementing the EmailNotificationService class
	public class EmailNotificationService : INotificationService
	{
		public void SendNotification(string recipient, string message)
		{
			// Simulating sending an email by outputting a message to the console
			Console.WriteLine($"Sending Email to {recipient}: {message}");
		}
	}

	// Implementing the SmsNotificationService class
	public class SmsNotificationService : INotificationService
	{
		public void SendNotification(string recipient, string message)
		{
			// Simulating sending an SMS by outputting a message to the console
			Console.WriteLine($"Sending SMS to {recipient}: {message}");
		}
	}

	// Implementing the PushNotificationService class
	public class PushNotificationService : INotificationService
	{
		public void SendNotification(string recipient, string message)
		{
			// Simulating sending a push notification by outputting a message to the console
			Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
		}
	}
}
