namespace RobotMananager {
    partial class MainWindow {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            TControl_Main = new TabControl();
            TPage_Server = new TabPage();
            Panl_LoggerContainer = new Panel();
            Panl_LoggerOptions = new Panel();
            Btn_Server_LogClear = new Button();
            FCTB_Logger = new FastColoredTextBoxNS.FastColoredTextBox();
            Panel_ServerOptions = new Panel();
            GBox_Server_Config = new GroupBox();
            TBox_Server_Address = new TextBox();
            Desc_Server_TargetAddress = new Label();
            Desc_Server_Port = new Label();
            Nud_Server_Port = new NumericUpDown();
            GBox_ServerOptions = new GroupBox();
            Btn_Server_ConnectAsClient = new Button();
            Btn_Server_StopServer = new Button();
            Btn_Server_StartServer = new Button();
            TPage_Manager = new TabPage();
            playfieldOverview1 = new CustomControls.PlayfieldOverview();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            numericUpDown3 = new NumericUpDown();
            label4 = new Label();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            TControl_Main.SuspendLayout();
            TPage_Server.SuspendLayout();
            Panl_LoggerContainer.SuspendLayout();
            Panl_LoggerOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FCTB_Logger).BeginInit();
            Panel_ServerOptions.SuspendLayout();
            GBox_Server_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Nud_Server_Port).BeginInit();
            GBox_ServerOptions.SuspendLayout();
            TPage_Manager.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TControl_Main
            // 
            TControl_Main.Controls.Add(TPage_Server);
            TControl_Main.Controls.Add(TPage_Manager);
            TControl_Main.Dock = DockStyle.Fill;
            TControl_Main.Location = new Point(0, 0);
            TControl_Main.Name = "TControl_Main";
            TControl_Main.SelectedIndex = 0;
            TControl_Main.Size = new Size(799, 505);
            TControl_Main.TabIndex = 0;
            // 
            // TPage_Server
            // 
            TPage_Server.Controls.Add(Panl_LoggerContainer);
            TPage_Server.Controls.Add(Panel_ServerOptions);
            TPage_Server.Location = new Point(4, 25);
            TPage_Server.Name = "TPage_Server";
            TPage_Server.Padding = new Padding(3);
            TPage_Server.Size = new Size(791, 476);
            TPage_Server.TabIndex = 0;
            TPage_Server.Text = "Server";
            TPage_Server.UseVisualStyleBackColor = true;
            // 
            // Panl_LoggerContainer
            // 
            Panl_LoggerContainer.Controls.Add(Panl_LoggerOptions);
            Panl_LoggerContainer.Controls.Add(FCTB_Logger);
            Panl_LoggerContainer.Dock = DockStyle.Fill;
            Panl_LoggerContainer.Location = new Point(3, 118);
            Panl_LoggerContainer.Name = "Panl_LoggerContainer";
            Panl_LoggerContainer.Size = new Size(785, 355);
            Panl_LoggerContainer.TabIndex = 0;
            // 
            // Panl_LoggerOptions
            // 
            Panl_LoggerOptions.BorderStyle = BorderStyle.Fixed3D;
            Panl_LoggerOptions.Controls.Add(Btn_Server_LogClear);
            Panl_LoggerOptions.Dock = DockStyle.Right;
            Panl_LoggerOptions.Location = new Point(736, 0);
            Panl_LoggerOptions.Name = "Panl_LoggerOptions";
            Panl_LoggerOptions.Size = new Size(49, 355);
            Panl_LoggerOptions.TabIndex = 0;
            // 
            // Btn_Server_LogClear
            // 
            Btn_Server_LogClear.Image = Properties.Resources.ClearIco;
            Btn_Server_LogClear.Location = new Point(3, 4);
            Btn_Server_LogClear.Name = "Btn_Server_LogClear";
            Btn_Server_LogClear.Size = new Size(41, 38);
            Btn_Server_LogClear.TabIndex = 0;
            Btn_Server_LogClear.UseVisualStyleBackColor = true;
            Btn_Server_LogClear.Click += Btn_Server_LogClear_Click;
            // 
            // FCTB_Logger
            // 
            FCTB_Logger.AcceptsReturn = false;
            FCTB_Logger.AcceptsTab = false;
            FCTB_Logger.AllowDrop = false;
            FCTB_Logger.AllowMacroRecording = false;
            FCTB_Logger.AutoCompleteBracketsList = (new Char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            FCTB_Logger.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            FCTB_Logger.AutoScrollMinSize = new Size(0, 14);
            FCTB_Logger.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FCTB_Logger.BackBrush = null;
            FCTB_Logger.BackColor = SystemColors.Control;
            FCTB_Logger.BorderStyle = BorderStyle.Fixed3D;
            FCTB_Logger.CaretBlinking = false;
            FCTB_Logger.CaretVisible = false;
            FCTB_Logger.CharHeight = 14;
            FCTB_Logger.CharWidth = 8;
            FCTB_Logger.DefaultMarkerSize = 8;
            FCTB_Logger.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            FCTB_Logger.Dock = DockStyle.Fill;
            FCTB_Logger.FindForm = null;
            FCTB_Logger.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FCTB_Logger.GoToForm = null;
            FCTB_Logger.HighlightFoldingIndicator = false;
            FCTB_Logger.Hotkeys = resources.GetString("FCTB_Logger.Hotkeys");
            FCTB_Logger.IsReplaceMode = false;
            FCTB_Logger.Location = new Point(0, 0);
            FCTB_Logger.Name = "FCTB_Logger";
            FCTB_Logger.Paddings = new Padding(0);
            FCTB_Logger.ReadOnly = true;
            FCTB_Logger.ReplaceForm = null;
            FCTB_Logger.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            FCTB_Logger.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("FCTB_Logger.ServiceColors");
            FCTB_Logger.ShowLineNumbers = false;
            FCTB_Logger.Size = new Size(785, 355);
            FCTB_Logger.TabIndex = 1;
            FCTB_Logger.WordWrap = true;
            FCTB_Logger.Zoom = 100;
            // 
            // Panel_ServerOptions
            // 
            Panel_ServerOptions.Controls.Add(GBox_Server_Config);
            Panel_ServerOptions.Controls.Add(GBox_ServerOptions);
            Panel_ServerOptions.Dock = DockStyle.Top;
            Panel_ServerOptions.Location = new Point(3, 3);
            Panel_ServerOptions.Name = "Panel_ServerOptions";
            Panel_ServerOptions.Size = new Size(785, 115);
            Panel_ServerOptions.TabIndex = 0;
            // 
            // GBox_Server_Config
            // 
            GBox_Server_Config.Controls.Add(TBox_Server_Address);
            GBox_Server_Config.Controls.Add(Desc_Server_TargetAddress);
            GBox_Server_Config.Controls.Add(Desc_Server_Port);
            GBox_Server_Config.Controls.Add(Nud_Server_Port);
            GBox_Server_Config.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GBox_Server_Config.Location = new Point(364, 0);
            GBox_Server_Config.Name = "GBox_Server_Config";
            GBox_Server_Config.Size = new Size(421, 109);
            GBox_Server_Config.TabIndex = 1;
            GBox_Server_Config.TabStop = false;
            GBox_Server_Config.Text = "Server Configuration";
            // 
            // TBox_Server_Address
            // 
            TBox_Server_Address.Location = new Point(73, 49);
            TBox_Server_Address.Name = "TBox_Server_Address";
            TBox_Server_Address.Size = new Size(176, 23);
            TBox_Server_Address.TabIndex = 4;
            TBox_Server_Address.Text = "127.0.0.0";
            // 
            // Desc_Server_TargetAddress
            // 
            Desc_Server_TargetAddress.AutoSize = true;
            Desc_Server_TargetAddress.Location = new Point(15, 52);
            Desc_Server_TargetAddress.Name = "Desc_Server_TargetAddress";
            Desc_Server_TargetAddress.Size = new Size(52, 15);
            Desc_Server_TargetAddress.TabIndex = 3;
            Desc_Server_TargetAddress.Text = "Address:";
            // 
            // Desc_Server_Port
            // 
            Desc_Server_Port.AutoSize = true;
            Desc_Server_Port.Location = new Point(15, 23);
            Desc_Server_Port.Name = "Desc_Server_Port";
            Desc_Server_Port.Size = new Size(32, 15);
            Desc_Server_Port.TabIndex = 1;
            Desc_Server_Port.Text = "Port:";
            // 
            // Nud_Server_Port
            // 
            Nud_Server_Port.Location = new Point(73, 20);
            Nud_Server_Port.Maximum = new Decimal(new Int32[] { 65535, 0, 0, 0 });
            Nud_Server_Port.Minimum = new Decimal(new Int32[] { 1, 0, 0, 0 });
            Nud_Server_Port.Name = "Nud_Server_Port";
            Nud_Server_Port.Size = new Size(89, 23);
            Nud_Server_Port.TabIndex = 0;
            Nud_Server_Port.Value = new Decimal(new Int32[] { 7400, 0, 0, 0 });
            // 
            // GBox_ServerOptions
            // 
            GBox_ServerOptions.Controls.Add(Btn_Server_ConnectAsClient);
            GBox_ServerOptions.Controls.Add(Btn_Server_StopServer);
            GBox_ServerOptions.Controls.Add(Btn_Server_StartServer);
            GBox_ServerOptions.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GBox_ServerOptions.Location = new Point(0, 0);
            GBox_ServerOptions.Name = "GBox_ServerOptions";
            GBox_ServerOptions.Size = new Size(358, 109);
            GBox_ServerOptions.TabIndex = 0;
            GBox_ServerOptions.TabStop = false;
            GBox_ServerOptions.Text = "Options";
            // 
            // Btn_Server_ConnectAsClient
            // 
            Btn_Server_ConnectAsClient.FlatStyle = FlatStyle.System;
            Btn_Server_ConnectAsClient.Location = new Point(87, 21);
            Btn_Server_ConnectAsClient.Name = "Btn_Server_ConnectAsClient";
            Btn_Server_ConnectAsClient.Size = new Size(75, 42);
            Btn_Server_ConnectAsClient.TabIndex = 2;
            Btn_Server_ConnectAsClient.Text = "Connect As Client";
            Btn_Server_ConnectAsClient.UseVisualStyleBackColor = true;
            Btn_Server_ConnectAsClient.Click += Btn_Server_ConnectAsClient_Click;
            // 
            // Btn_Server_StopServer
            // 
            Btn_Server_StopServer.FlatStyle = FlatStyle.System;
            Btn_Server_StopServer.Location = new Point(6, 62);
            Btn_Server_StopServer.Name = "Btn_Server_StopServer";
            Btn_Server_StopServer.Size = new Size(75, 34);
            Btn_Server_StopServer.TabIndex = 1;
            Btn_Server_StopServer.Text = "Stop Server";
            Btn_Server_StopServer.UseVisualStyleBackColor = true;
            Btn_Server_StopServer.Click += Btn_Server_StopServer_Click;
            // 
            // Btn_Server_StartServer
            // 
            Btn_Server_StartServer.FlatStyle = FlatStyle.System;
            Btn_Server_StartServer.Location = new Point(6, 22);
            Btn_Server_StartServer.Name = "Btn_Server_StartServer";
            Btn_Server_StartServer.Size = new Size(75, 34);
            Btn_Server_StartServer.TabIndex = 0;
            Btn_Server_StartServer.Text = "Start Server";
            Btn_Server_StartServer.UseVisualStyleBackColor = true;
            Btn_Server_StartServer.Click += Btn_Server_StartServer_Click;
            // 
            // TPage_Manager
            // 
            TPage_Manager.Controls.Add(playfieldOverview1);
            TPage_Manager.Controls.Add(panel2);
            TPage_Manager.Location = new Point(4, 25);
            TPage_Manager.Name = "TPage_Manager";
            TPage_Manager.Padding = new Padding(3);
            TPage_Manager.Size = new Size(791, 476);
            TPage_Manager.TabIndex = 1;
            TPage_Manager.Text = "Manager";
            TPage_Manager.UseVisualStyleBackColor = true;
            // 
            // playfieldOverview1
            // 
            playfieldOverview1.BorderStyle = BorderStyle.FixedSingle;
            playfieldOverview1.Dock = DockStyle.Fill;
            playfieldOverview1.Location = new Point(3, 3);
            playfieldOverview1.Name = "playfieldOverview1";
            playfieldOverview1.Size = new Size(579, 470);
            playfieldOverview1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(582, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 470);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Robot Control";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 1;
            label1.Text = "Target:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(68, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(132, 52);
            numericUpDown1.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(132, 81);
            numericUpDown2.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(57, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 54);
            label2.Name = "label2";
            label2.Size = new Size(17, 16);
            label2.TabIndex = 4;
            label2.Text = "X:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 81);
            label3.Name = "label3";
            label3.Size = new Size(17, 16);
            label3.TabIndex = 5;
            label3.Text = "Y:";
            // 
            // button1
            // 
            button1.Location = new Point(10, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 7;
            button1.Text = "Go To Location";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(10, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 45);
            button2.TabIndex = 8;
            button2.Text = "Create Object";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(132, 127);
            numericUpDown3.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(57, 23);
            numericUpDown3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 156);
            label4.Name = "label4";
            label4.Size = new Size(17, 16);
            label4.TabIndex = 12;
            label4.Text = "Y:";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(132, 156);
            numericUpDown4.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(57, 23);
            numericUpDown4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 129);
            label5.Name = "label5";
            label5.Size = new Size(17, 16);
            label5.TabIndex = 11;
            label5.Text = "X:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(6, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entities";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new Point(38, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 84);
            listBox1.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 505);
            Controls.Add(TControl_Main);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(815, 545);
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Robot Manager";
            TControl_Main.ResumeLayout(false);
            TPage_Server.ResumeLayout(false);
            Panl_LoggerContainer.ResumeLayout(false);
            Panl_LoggerOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FCTB_Logger).EndInit();
            Panel_ServerOptions.ResumeLayout(false);
            GBox_Server_Config.ResumeLayout(false);
            GBox_Server_Config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Nud_Server_Port).EndInit();
            GBox_ServerOptions.ResumeLayout(false);
            TPage_Manager.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TControl_Main;
        private TabPage TPage_Server;
        private TabPage TPage_Manager;
        private GroupBox GBox_ServerOptions;
        private FastColoredTextBoxNS.FastColoredTextBox FCTB_Logger;
        private Panel Panl_LoggerContainer;
        private Panel Panl_LoggerOptions;
        private Panel Panel_ServerOptions;
        private GroupBox GBox_Server_Config;
        private Label Desc_Server_TargetAddress;
        private Label Desc_Server_Port;
        private NumericUpDown Nud_Server_Port;
        private Button Btn_Server_ConnectAsClient;
        private Button Btn_Server_StopServer;
        private Button Btn_Server_StartServer;
        private TextBox TBox_Server_Address;
        private Panel panel2;
        private Button Btn_Server_LogClear;
        private CustomControls.PlayfieldOverview playfieldOverview1;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBox1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private NumericUpDown numericUpDown3;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private Label label5;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label2;
    }
}