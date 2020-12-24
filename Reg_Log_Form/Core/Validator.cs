using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_Log_Form
{
    public static class Validator
    {
        public static void Validate(params string[] txbxs)
        {
            foreach (string txbx in txbxs)
            {
                if (string.IsNullOrEmpty(txbx))
                {
                    throw new ArgumentNullException("All fields must be filled out");
                }
            }
        }

        public static sbyte CheckUserAge(string age)
        {
            if (string.IsNullOrEmpty(age))
                throw new ArgumentNullException("Age value is not given!");
            if (!sbyte.TryParse(age, out sbyte result))
                throw new FormatException("Age value is not valied!");

            return result;
        }

        public static bool IsEmailValid(string userEmail)
        {
            if (string.IsNullOrEmpty(userEmail))
                throw new ArgumentNullException();

            if (userEmail.Contains("@"))
            {
                return true;
            }
            else return false;
        }

        public static bool IsPasswordValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException();

            if (password.Length >= 4)
            {
                return true;
            }
            else return false;
        }
    }
}
