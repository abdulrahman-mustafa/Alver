using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Alver.MISC
{
    public static class UsbFuncs
    {
        public struct USBDevice
        {
            public string Description, DeviceID, Status;
        };
        public static USBDevice _usb;

        #region DDETECT CONNECTED USBs

        //detect a USB device when it's connected to the computer
        public static void StartDetecting()
        {
            _usb = new USBDevice();
            var queryStr = "SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_PnPEntity'";
            var watcher = new ManagementEventWatcher(queryStr);
            watcher.EventArrived += DeviceChangeEventReceived;
            watcher.Start();
        }
        //Event handler:
        private static void DeviceChangeEventReceived(object sender, EventArrivedEventArgs e)
        {
            var instance = ((PropertyData)(e.NewEvent.Properties["TargetInstance"]));
            var obj = (ManagementBaseObject)instance.Value;

            _usb.Description= (string)obj.Properties["Description"].Value;
            _usb.DeviceID = (string)obj.Properties["DeviceID"].Value;
            _usb.Status = (string)obj.Properties["Status"].Value;
        }
        #endregion
    }
}
