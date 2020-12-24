using Reg_Log_Form.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_Log_Form
{
    public static class Session
    {
        public static Form1 Form1 { get; set; }

        public static User User { get; set; }

        public static DashBoard DashBoard { get; set; }

        public static AdminPanel AdminPanel { get; set; }
        
        public static UsersListForm ListForm { get; set; }

        public static LogsListForm LogsForm { get; set; }

        public static string Code { get; set; }

        public static void CloseApp()
        {
            Form1.Close();
        }
    }
}
