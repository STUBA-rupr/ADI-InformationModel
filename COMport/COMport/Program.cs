using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace COMport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the serial port with basic settings
            SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            string response = "S D     300.07 g\r\n";
            byte[] sData;
            sData = Encoding.ASCII.GetBytes(response);
            port.Open();
            port.BaseStream.Write(sData, 0, sData.Length);
            port.Close();

        }
    }
}
