using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
	class NewUser
	{
		public string fullName{get; set;}
		public string emailID { get; set; }
		public string password { get; set; }
		public string phoneNumber { get; set; }
		public string confirmPassword { get; set; }

		public NewUser(string name, string email,string pwd, string confPwd,string phone)
		{
			this.fullName = name;
			this.emailID = email;
			this.password = pwd;
			this.phoneNumber = phone;
			this.confirmPassword = confPwd;
		}

		static bool isText(char input)
		{
			return (input >= 'a' && input <= 'z') || (input >= 'A' && input <= 'Z');
		}

		static bool isDigit(char input)
		{
			return (input >= '0' && input <= '9');
		}

		static bool isSymbol(char input)
		{
			return (input > 32 && input < 127 && !isDigit(input) && !isText(input));
		}

		static bool IsValidPassword(string pwd)
		{
			return
				pwd.Any(input => isText(input)) &&
				pwd.Any(input => isDigit(input)) &&
				pwd.Any(input => isSymbol(input));
		}

	}
}
