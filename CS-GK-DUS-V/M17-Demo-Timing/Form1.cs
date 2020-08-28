using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace M17_Demo_Timing
{
    public partial class Form1 : Form
    {
        // Timer läuft in einem separaten Thread. 
        // EventHandler vom Timer können auf Kontroll-Elemente 
        // vom Formular einfach so nicht zugreifen.

        // ctor
        public Form1()
        {
            InitializeComponent();
            // timersTimer.Elapsed += new ElapsedEventHandler(Countdown); // eine Prop, wo Handler für ElapsedEvent gesammelt werden
            #region Timers.Timer
            timersTimer.Elapsed += CountdownTimersTimer;
            timersTimer.Interval = 1000;
            #endregion

            #region Forms.Timer
            // Interval und Tick-Hanlder kann man vom Designer aus anlegen    

            #endregion

            Console.WriteLine($"ThreadId in Konstruktor: {Thread.CurrentThread.ManagedThreadId}");
        }

        // fields
        private int secondsTimers = 0;
        private int secondsForms = 0;
        static private int secondsThreading = 0; // statische Methoden dürfen nur auf statische Variablen zugreifen


        private System.Windows.Forms.Timer winFormsTimer = new System.Windows.Forms.Timer(); // System.Windows.Forms.Timer
        private System.Timers.Timer timersTimer = new System.Timers.Timer();

        AutoResetEvent autoEvent;
        StatusChecker statusChecker;
        System.Threading.Timer threadingTimer;  

        // methods
        #region Timers Timer
        // ElapsedEventArgs kommt aus System.Timers 
        void CountdownTimersTimer(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"ThreadId in CountdownTimers: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"seconds: {secondsTimers--}");
            Console.WriteLine($"sender: {sender}");            
            if (secondsTimers == 0)
                timersTimer.Stop();
            // um vom Timer-Thread auf Form-Thread zuzugreifen
            Invoke(new Action(
                () => textBox1.Text = secondsTimers.ToString()
            ));
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            secondsTimers = int.Parse(textBox1.Text);
            // timersTimer.Start();
            // oder: 
            timer1.Enabled = true;
        }
        #endregion
        #region Forms.Timer
        private void btnStartFormsTimer_Click(object sender, EventArgs e)
        {
            secondsForms = int.Parse(textBox2.Text);
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine($"ThreadId in timer1_Tick: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"seconds: {secondsForms--}");
            Console.WriteLine($"sender: {sender}");

            if (secondsForms == 0)
                // timer1.Stop();
                // oder:
                timer1.Enabled = false;
            // um vom Timer-Thread auf Form-Thread zuzugreifen
            //Invoke(new Action(
            //    () => 
            textBox2.Text = secondsForms.ToString();
            // ));
        }

        #endregion


        #region Threading Timer
        // ??? Warum läuft der Timer zwei mal durch?
        // https://docs.microsoft.com/de-de/dotnet/api/system.threading.timer?view=netcore-3.1
        //static void CountdownThreadingTimer(object sender)
        //{
        //    Console.WriteLine($"ThreadId in CountdownThreading: {Thread.CurrentThread.ManagedThreadId}");
        //    Console.WriteLine($"seconds: {secondsThreading--}");
        //    Console.WriteLine($"sender: {sender}");
        //    if (secondsThreading == 0)
        //        Dispose();
        //    // um vom Timer-Thread auf Form-Thread zuzugreifen
        //    Invoke(new Action(
        //        () => textBox3.Text = secondsThreading.ToString()
        //    ));
        //}
        #endregion
        private void btnThreadingTimer_Click(object sender, EventArgs e)
        {
            autoEvent = new AutoResetEvent(false);
            statusChecker = new StatusChecker(int.Parse(textBox3.Text));
            threadingTimer = new System.Threading.Timer(statusChecker.ChekStatus, autoEvent, 1000, 1000);
            autoEvent.WaitOne();
            threadingTimer.Change(0, 1000);
            autoEvent.WaitOne();
            threadingTimer.Dispose();
            Console.WriteLine("\n Timer gelöscht.");
        }
    }

    class StatusChecker
    {
        private int invokeCount;
        private int maxCount;

        public StatusChecker(int count)
        {
            invokeCount = 0;
            maxCount = count;
        }

        public void ChekStatus(Object stateInfo)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
            Console.WriteLine(++invokeCount);
            // invokeCount++;
            if (invokeCount == maxCount && invokeCount > 0)
            {
                invokeCount = 0;
                autoEvent.Set();
            }

        }
    }
}
