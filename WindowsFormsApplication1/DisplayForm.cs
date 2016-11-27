using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShutdownServerWithHdmi
{
    public partial class DisplayForm : Form
    {

        // https://msdn.microsoft.com/en-us/library/system.windows.forms.timer.tick.aspx
        public DisplayForm()
        {
            

            InitializeComponent();

            RunTimer();
        }

     

        public void RunTimer()
        {

            /* Adds the event and the event handler for the method that will 
             process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 3000;
            myTimer.Start();


            // Processes all the events in the queue.
            Application.DoEvents();

        }


        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 10;

        // This is the method to run when the timer is raised.
        private  void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {

            // Restarts the timer and increments the counter.
            alarmCounter += 1;
            myTimer.Enabled = true;


            ShowScreens();

            

        }

        public void ClearText()
        {
            display1.Text = "";
            display2.Text = "";
        }


        public  void ShowScreens()
        {
            ClearText();

           
            Screen[] monitors = Screen.AllScreens;

            string output = "";
            foreach (Screen monitor in monitors)
            {
                output+= "Bits Per Pixel: " + monitor.BitsPerPixel;
                output+= "Bounds: " + monitor.Bounds;
                output+= "Device Name: " + monitor.DeviceName;
                output+= "Is Primary: " + monitor.Primary;
                output+= "Working Area: " + monitor.WorkingArea + "/n";
            }

            display1.Text = output;

      

        }
    }
}
