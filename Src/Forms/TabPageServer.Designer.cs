using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastColoredTextBoxNS;

namespace RobotMananager {

    public partial class MainWindow : Form {


        //---------------
        // Buttons
        //---------------

        private void Btn_Server_StartServer_Click(Object sender, EventArgs e) => FCTB_Logger.AppendText("StartServer Stub\n");
        private void Btn_Server_StopServer_Click(Object sender, EventArgs e) => FCTB_Logger.AppendText("StopServer Stub\n");
        private void Btn_Server_ConnectAsClient_Click(Object sender, EventArgs e) => FCTB_Logger.AppendText("ConnectAsClient Stub\n");
        private void Btn_Server_LogClear_Click(Object sender, EventArgs e) => BeginInvoke(() => FCTB_Logger.Clear());


    }
}
