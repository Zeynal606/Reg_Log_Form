using Reg_Log_Form.Roles;
using Reg_Log_Form.Visulizers;
using System;

namespace Reg_Log_Form
{
    internal class XMLVisualizer : IVisualizer
    {
        private string _user;
        private LogStatus _action;

        public XMLVisualizer(string user, LogStatus action)
        {
            _user = user;
            _action = action;
        }

        public string Visualize()
        {
            return string.Format("<log>\n\t<user>{0}</user>\n\t<action>{1}</action>\n\t<time>{2}</time>\n</log>\n", _user, _action, DateTime.Now);
        }
    }
}