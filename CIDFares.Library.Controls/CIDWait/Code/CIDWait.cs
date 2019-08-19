using CIDFares.Library.Controls.CIDWait.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Library.Controls.CIDWait.Code
{
    public static class CIDWait
    {

        private static FrmWait _FrmEspere { get; set; }

        public static ResultCIDWait Show(Func<Task> action, string message)
        {
            ResultCIDWait resultCIDWait = new ResultCIDWait();
            _FrmEspere = new FrmWait(action, message);
            resultCIDWait.IsCompleted = (_FrmEspere.ShowDialog() == System.Windows.Forms.DialogResult.OK);
            if (!resultCIDWait.IsCompleted)
                resultCIDWait.ExceptionsList = _FrmEspere.Exceptions;
            _FrmEspere.Dispose();
            return resultCIDWait;
        }
    }

    public class ResultCIDWait
    {
        public ResultCIDWait()
        {
            IsCompleted = false;
            ExceptionsList = null;
        }
        public AggregateException ExceptionsList { get; set; }
        public bool IsCompleted { get; set; }
    }
}
