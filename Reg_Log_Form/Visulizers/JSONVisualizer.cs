using Reg_Log_Form.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_Log_Form.Visulizers
{
    public class JSONVisualizer : IVisualizer
    {
        private readonly string _user;
        private readonly LogStatus _action;

        public JSONVisualizer(string user, LogStatus action)
        {
            _user = user;
            _action = action;
        }
        public string Visualize()
        {
            return string.Format("[\n\t[user]:[{0}]\n\t[action]:[{1}]\n\t[time]:[{2}]\n]\n", _user, _action, DateTime.Now);
        }
    }
}
