using Cnc3Launcher.Helper;
using System.Configuration;
using System.Diagnostics;

namespace Cnc3Launcher
{
    public partial class MainForm : Form
    {
        HH_Lib hwh = new HH_Lib();
        bool hardwareIsEnabled = true;
        bool deviceIsFound = false;
        List<DEVICE_INFO> HardwareList;
        DEVICE_INFO device;

        private readonly string friendlyName = ConfigurationManager.AppSettings["DevicefriendlyName"];
        private readonly string hardwareId = ConfigurationManager.AppSettings["DeviceHardwareId"];
        private readonly string cnc3Path = ConfigurationManager.AppSettings["CNC3Path"];
        private readonly string cnc3kwPath = ConfigurationManager.AppSettings["CNC3KWPath"];

        public MainForm()
        {
            InitializeComponent();
            //retrieves a list of all devices
            HardwareList = hwh.GetAll();
            //filters the list in hopes of finding the hands-on ag device
            device = HardwareList.First(x => x.hardwareId.Contains(hardwareId) && x.friendlyName.Contains(friendlyName));

            if (device.name != null)
            {
                log("Device found -> " + device.friendlyName);
                deviceIsFound = true;
            }
        }
        void log(string message)
        {
            if (InvokeRequired)
            {
                lbLog.Invoke(new Action(() => lbLog.Items.Add(message)));
            }
            else
            {
                lbLog.Items.Add(message);
            }

        }
        void LaunchGame(string path)
        {
            Process process = new Process();
            process.StartInfo.FileName = path;
            process.Start();
            process.EnableRaisingEvents = true;
            process.Exited += (sender, e) => { GameExit();  };

        }
        void GameExit() {

            log("The game was terminated");
            EnableSoundDevices(true);
        }
        void EnableSoundDevices(bool enabling)
        {
            if (deviceIsFound)
            {
                try
                {                   
                    log("Attempting to " + (enabling ? "enable " : "disable ") + device.friendlyName);
                    hwh.SetDeviceState(device, enabling);
                    log(device.friendlyName + " was " + (enabling ? "enabled" : "disabled"));
                    hardwareIsEnabled = enabling;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }



        private void btnLaunchGame_Click(object sender, EventArgs e)
        {
            EnableSoundDevices(false);
            log("Launching Command and Conquer 3");
            LaunchGame(cnc3Path);
        }
        private void btnLaunchExpansion_Click(object sender, EventArgs e)
        {
            EnableSoundDevices(false);
            log("Launching Command and Conquer 3 Kane's Wrath");
            LaunchGame(cnc3kwPath);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //ensure to re-enable the sound hardware
            if (hardwareIsEnabled == false)
            {
                EnableSoundDevices(true);
            }

            base.OnFormClosing(e);

        }


    }
}