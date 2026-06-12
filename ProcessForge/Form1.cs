using System.Runtime.InteropServices;
using ProcessForge.ApplicationLogic;
using ProcessForge.FindWindowLogic;
using ProcessForge.ComboBoxLogic;

namespace ProcessForge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int secondsRemaining;
        bool isRun1Running = false;
        string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //clear the RAM by emptying the working set of the current process
        private void ClearRAM_Click(object sender, EventArgs e)
        {
            string processName = ProcessName.Text;
            ClearUnusedMemoryLogic.ClearUnusedMemory(processName);
        }

        //browse for the executable file to run
        private void BrowseFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Executable Files (*.exe)|*.exe";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FilePathName.Text = OFD.FileName;
            }
        }

        //test button for validating the click event
        private void ValidatingEvent_Click(object sender, EventArgs e)
        {
            decimal testmyint = TimeSetForClearRAM.Value;
            MSTimeSetLabel.Text = $"Validating - Time Set: {testmyint} ms";
        }

        //run the process with the given path and time for looping
        private void Run1_Click(object sender, EventArgs e)
        {   
            
            if (isRun1Running)
            {
                CountDownTimer.Stop();
                TimerForSeconds.Stop();

                Run1.Text = "Run";
                isRun1Running = false;
                CountDownSeconds.Text = "Count down event : Stopped";
            }
            else
            {
                secondsRemaining = (int)TimeSetForClearRAM.Value / 1000;
                CountDownTimer.Interval = (int)TimeSetForClearRAM.Value;
                CountDownTimer.Start();
                TimerForSeconds.Start();

                Run1.Text = "Stop";
                isRun1Running = true;
            }
            
        }
            private void TimerForSeconds_Tick(object sender, EventArgs e)
            {
                if (secondsRemaining > 0)
                {
                    secondsRemaining--;
                    CountDownSeconds.Text = $"Count down event : {secondsRemaining} seconds";
                } 
            }
        //test button for validating the click event
        private void TestButton_Click(object sender, EventArgs e)
        {

        }

        //run the process with the given path and time for looping

        private void Run2_Click(object sender, EventArgs e)
        {

        }

        //terminate the process with the given path
        private void Terminate_Click(object sender, EventArgs e)
        {

        }
    }
}
