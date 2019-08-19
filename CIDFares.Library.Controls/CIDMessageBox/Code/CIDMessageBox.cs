using CIDFares.Library.Controls.CIDMessageBox.Enums;
using CIDFares.Library.Controls.CIDMessageBox.Forms;
using System;
using System.Windows.Forms;

namespace CIDFares.Library.Controls.CIDMessageBox.Code
{
    public static class CIDMessageBox
    {
        public static void ShowAlert(string Title, string Message, TypeMessage typeMessage)
        {
            try
            {
                FrmMessageBox instance = new FrmMessageBox
                {
                    Title = Title,
                    Message = Message,
                    typeMessage = typeMessage
                };
                instance.ShowDialog();
                instance.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DialogResult ShowAlertRequest(string Title, string Message)
        {
            try
            {
                FrmMessageBox instance = new FrmMessageBox
                {
                    Title = Title,
                    Message = Message,
                    typeMessage = TypeMessage.confirmacion
                };
                instance.ShowDialog();
                instance.Dispose();
                return instance.DialogResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ShowAlert()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DialogResult ShowAlertRequest(object systemName, object confirmDeleteMessage)
        {
            throw new NotImplementedException();
        }
    }
}
