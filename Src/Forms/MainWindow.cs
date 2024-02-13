using System.Media;
using System.Net.WebSockets;
using System.Text;

using FastColoredTextBoxNS;
using FastColoredTextBoxNS.Input;

namespace RobotMananager {
    public partial class MainWindow : Form {


        TextBoxStreamWriter Writer;
        List<DataStructures.FlagData> Flags = new();
        DataStructures.Map Map = new();



        public MainWindow() {
            InitializeComponent();
            Init();

            //TCPServerManager Serv = new("192.168.178.10", 8001, 1);
            //Serv.Start();

        }


        private void playSimpleSound() {
            SoundPlayer simpleSound = new(@"D:\Projects\RobotManager\Bin\Debug\net7.0-windows\sus.wav");
            simpleSound.Play();
        }



        private void Init() {
            // Instantiate the writer
            Writer = new(FCTB_Logger);
            // Redirect the out Console stream
            Console.SetOut(Writer);
            Console.SetError(Writer);
            Console.WriteLine("[RobotManager] Ready!");
            //Set CmBox Indexes
            CmBox_RobotCommands.SelectedIndex = 0;
            CmBox_RobotTasks.SelectedIndex = 0;


        }

        private void Btn_Manager_CreateFlag_Click(Object sender, EventArgs e) {
            GenFlags(CmBox_RobotTasks.SelectedIndex);

            //Todo Event From Robot To Re-Enable
            (sender as Button).Text = "Disabled";
            (sender as Button).Enabled = false;

        }

        //Todo, In The Command Decoder Func
        //Register This Function As An Event Callback
        //On the still ToDo "OnFlagsCollected" Event
        public void EnableFlagButton() {
            Invoke(() => {
                Btn_Manager_CreateFlag.Enabled = true;
                Btn_Manager_CreateFlag.Text = "Create Random Flags";
            });
        }
    }
}


/*
 * Robot Heeft Interne Map Array van [11][11]
 * Server Stuurt PCcmd Met De struct van wat we van 1 flag willen maken (Dus pos? en wat nog meer...)
 * De robot krijgt dit cmd binnen en plaatst de positie van die vlag in zijn interne map array
 * De robot is niet bewust van muren die kan hij alleen zien via de distance sensor
 * De robot gaat gwn via pytagoras vector naar de vlag toe
 * 
 * 
 */