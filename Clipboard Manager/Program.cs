using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Clipboard_Manager
{
    class Program
    {        
        [STAThread]
        static void Main(string[] args)
        {
            object prevObj = 0;

            while (true)
            {
                //compare
                if (prevObj == Clipboard.GetDataObject())
                {
                    //do nothing
                    MessageBox.Show("Nothing");
                }
                else
                {
                    if (Clipboard.ContainsText())
                    {
                        string txt = Clipboard.GetText();                        
                        object obj = Clipboard.GetDataObject();

                        prevObj = obj;
                        //set type and data in the database
                        MessageBox.Show(txt);
                    }
                    else if (Clipboard.ContainsFileDropList())
                    {

                    }
                    else if (Clipboard.ContainsImage())
                    {

                    }
                    else if (Clipboard.ContainsAudio())
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error: Clipboard contains unrecognized ");
                    }
                }
                Thread.Sleep(250);
            }
            
        }
    }
}
