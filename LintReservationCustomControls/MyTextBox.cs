using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LintReservationCustomControls
{
    public class MyTextBox:TextBox
    {
        public enum WorkMode
        {
            Harf,
            Rakam,
            Normal
        }
        int[] turkce = { 252, 287, 351, 231, 246, 305, 304, 220, 286, 350, 199, 214 };
        int[] ozelkarakter = { 8, 32 };
        public WorkMode CalismaModu { get; set; }
        protected override void OnKeyPress(KeyPressEventArgs e) 
        {
            switch (CalismaModu)
            {
                case WorkMode.Harf:
                    if (!((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || turkce.Contains(e.KeyChar) || ozelkarakter.Contains(e.KeyChar)))
                    {
                        MessageBox.Show("Enter Data Using Letters", "!!Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                    }
                    
                    break;
                case WorkMode.Rakam:
                    if (!((e.KeyChar >= 48 && e.KeyChar <= 57) || ozelkarakter.Contains(e.KeyChar)))
                    {
                        MessageBox.Show("Enter Data Using Numbers", "!!Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                    }
                   
                    break;
                case WorkMode.Normal:
                    base.OnKeyPress(e);
                    break;
                default:
                    break;
            }
        }
    }
}
