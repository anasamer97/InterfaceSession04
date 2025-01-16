namespace Interface
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Part 02 - Assignment
			#region Question 01
			/*// Create instances of Circle and Rectangle
			ICircle circle = new Circle(5);
			IRectangle rectangle = new Rectangle(4, 6);

			// Display information about both shapes
			circle.DisplayShapeInfo();
			Console.WriteLine();
			rectangle.DisplayShapeInfo();*/
			#endregion


			#region Question 02
			/*// Create an instance of BasicAuthenticationService and assign it to IAuthenticationService
			IAuthenticationService authService = new BasicAuthenticationService();

			// Test user credentials and authorization
			string username = "admin";
			string password = "password123";
			string role = "admin";

			bool isAuthenticated = authService.AuthenticateUser(username, password);
			bool isAuthorized = authService.AuthorizeUser(username, role);

			// Display results
			if (isAuthenticated)
			{
				Console.WriteLine("User authenticated successfully.");

				if (isAuthorized)
				{
					Console.WriteLine("User is authorized.");
				}
				else
				{
					Console.WriteLine("User is not authorized.");
				}
			}
			else
			{
				Console.WriteLine("Authentication failed.");
			}*/

			#endregion

			#region Question 03
			/*// Create instances of each notification service class
			INotificationService emailService = new EmailNotificationService();
			INotificationService smsService = new SmsNotificationService();
			INotificationService pushService = new PushNotificationService();

			// Sample recipient and message
			string recipient = "user@example.com";
			string message = "Your notification has arrived!";

			// Call the SendNotification method for each service
			emailService.SendNotification(recipient, message);
			smsService.SendNotification(recipient, message);
			pushService.SendNotification(recipient, message);*/
			#endregion
			#endregion


			#region Session Demo
			#region Interface 
			//Reference Type 
			//Signeture 
			//Implementation 
			//Ref Interface => Refere Any Object Impelented that Interface 
			//Class => More Than Interface 
			//Class => One Class 
			//IMyType myType = new MyType();
			//myType.Func1();
			//myType.Salary = 6000;
			//myType.Print()
			#endregion
			#region Explicit and Implicit Implementation
			//SeriesByTwo series = new SeriesByTwo();//Current = 0;

			//SeriesByThree byThree = new SeriesByThree();
			//SeriesByFour byFour = new SeriesByFour();

			//Print10NumbersBySeries(byThree);
			//Print10NumbersBySeries(series);
			//Print10NumbersBySeries(byFour);


			//IFlayble plane = new AirPlane();

			//plane.Backword(); 
			#endregion
			#region Shallow Copy and Deep Copy
			//int[] Nums1 = { 1, 2, 3 };
			//int[] Nums2 = new int[3]; // 0 0 0
			//Console.WriteLine(Nums1.GetHashCode());
			//Console.WriteLine(Nums2.GetHashCode());
			//Console.WriteLine("==============================");

			////Shallow Copy
			////Nums2 = Nums1;//2 Reference => Object  object =>Unllocated
			////Console.WriteLine(Nums1.GetHashCode());
			////Console.WriteLine(Nums2.GetHashCode());

			////Deep Copy
			//Nums2 = (int[])Nums1.Clone();
			//Console.WriteLine(Nums1.GetHashCode());
			//Console.WriteLine(Nums2.GetHashCode());
			//Console.WriteLine("==============================");
			//Console.WriteLine(Nums1[0]);
			//Console.WriteLine(Nums2[0]);

			//StringBuilder[] Names1 = new StringBuilder[1];////null
			//Names1[0] = new StringBuilder();
			//Names1[0].Append("Omar");
			//StringBuilder[] Names2 = new StringBuilder[1];//Empty 1 ref =< null
			//Console.WriteLine(Names1.GetHashCode());
			//Console.WriteLine(Names2.GetHashCode());
			//Console.WriteLine("===============================");
			//Names2 = Names1;
			//Console.WriteLine(Names1.GetHashCode());
			//Console.WriteLine(Names2.GetHashCode());
			//Console.WriteLine("===============================");
			//Names2[0].Append("Ahmed");
			//Console.WriteLine(Names1[0]);
			//Console.WriteLine(Names2[0]);
			//Names2 = (StringBuilder[]) Names1.Clone();
			//Console.WriteLine(Names1.GetHashCode());
			//Console.WriteLine(Names2.GetHashCode());
			//Console.WriteLine("===============================");
			//Names2[0].Append("Ahmed");
			//Console.WriteLine(Names1[0]);
			//Console.WriteLine(Names2[0]); 
			#endregion
			#region IClonable 
			//int[] Nums1 = { 1, 2, 3 };
			//int[] Nums2 = new int[3]; 
			//Nums2 = (int[]) Nums1.Clone();

			//Object Ini
			//Employee employee = new Employee()
			//{
			//	Id = 10,
			//	Name = "Ahmed",
			//	Salary = 8000
			//};
			//Console.WriteLine(employee);
			//Employee employee2 = new Employee();

			//employee2 = (Employee)employee.Clone();

			//Console.WriteLine(employee2);

			#endregion
			#endregion
		}
	}


	#region Part 01 - Assignment
	/*
		 Part 01:
		-----------
		Qustion 1:
		What is the primary purpose of an interface in C#?

		Answer: b - To define a blueprint for a class


		Question 2:
		Which of the following is NOT a valid access modifier for interface members in C#?

		Answer: a - Private


		Question 3:
		Can an interface contain fields in C#?

		Answer: b - No


		Question 4:
		In C#, can an interface inherit from another interface?

		Answer: b - Yes


		Question 5:
		Which keyword is used to implement an interface in a class in C#?

		Answer: Nothing from the choices. The correct answer is :


		Question 6:
		Can an interface contain static methods in C#?


		Answer: a - Yes

		Question 7: In C#, can an interface have explicit access modifiers for its members?

		Answer: b - No, all members are implicitly public


		Qustion 8: What is the purpose of an explicit interface implementation in C#?

		Answer: b - To hide the interface members from outside access


		Question 9: In C#, can an interface have a constructor?

		Answer: b - No, interfaces cannot have constructors


		Question 10: How can a C# class implement multiple interfaces?

		Answer: c - By separating interface names with commas

 */
	#endregion
}
