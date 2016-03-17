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
            string prevString = null;
            List<string> strings = new List<string>();
            while (true)
            {
                //compare
                if (prevString != Clipboard.GetText())
                {
                    if (Clipboard.ContainsText())
                    {
                        string txt = Clipboard.GetText();
                        strings.Add(txt);

                        prevString = txt;
                        //set type and data in the database
                        //MessageBox.Show(txt);
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
                        MessageBox.Show("Error: Clipboard contains unrecognized stuff");
                    }
                }
                Thread.Sleep(250);
            }
            
        }
    }
}
