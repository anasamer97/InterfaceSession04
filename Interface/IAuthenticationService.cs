using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal interface IAuthenticationService
	{
		bool AuthenticateUser(string username, string password);
		bool AuthorizeUser(string username, string password);

	}

	public class BasicAuthenticationService : IAuthenticationService
	{
		// Simulated stored credentials
		private readonly string storedUsername = "admin";
		private readonly string storedPassword = "password123";
		private readonly string storedRole = "admin";

		public bool AuthenticateUser(string username, string password)
		{
			// Compare the provided username and password with the stored credentials
			return username == storedUsername && password == storedPassword;
		}

		// Implementing AuthorizeUser method
		public bool AuthorizeUser(string username, string role)
		{
			// Check if the user has the specified role
			return username == storedUsername && role == storedRole;
		}

	}
}
