using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;
using thexpr.Utility;

namespace thexpr
{
    public partial class Form1 : Form
    {
        private ClipBoardMonitor clipBoardMonitor = null;

        public Form1()
        {
            InitializeComponent();
            clipBoardMonitor = new ClipBoardMonitor();
            clipBoardMonitor.NewFileDropList += clipBoardMonitor_NewFileDropList;
        }

        private void clipBoardMonitor_NewFileDropList(StringCollection fileDropList)
        {
            if (fileDropList.Count != 0)
            {
                Console.WriteLine(fileDropList[0]);
                pictureBox1.Image = Image.FromFile(fileDropList[0]);
            }
        }
    }
}


