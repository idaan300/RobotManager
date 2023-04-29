using RobotMananager.CustomControls;

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
            PFOV_Main = new PlayfieldOverview();
            Panel_Manager_Controls = new Panel();
            GBox_Manager_Entities = new GroupBox();
            LBox_Entities = new ListBox();
            GBox_Manager_RobotControls = new GroupBox();
            Nud_ObjX = new NumericUpDown();
            Desc_ObjY = new Label();
            Nud_ObjY = new NumericUpDown();
            Desc_ObjX = new Label();
            Btn_Manager_CreateObject = new Button();
            Btn_Manager_GotoLoc = new Button();
            Desc_Target = new Label();
            Nud_LocX = new NumericUpDown();
            Desc_LocY = new Label();
            comboBox1 = new ComboBox();
            Nud_LocY = new NumericUpDown();
            Desc_LocX = new Label();
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
            Panel_Manager_Controls.SuspendLayout();
            GBox_Manager_Entities.SuspendLayout();
            GBox_Manager_RobotControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Nud_ObjX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nud_ObjY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nud_LocX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nud_LocY).BeginInit();
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
            TPage_Manager.Controls.Add(PFOV_Main);
            TPage_Manager.Controls.Add(Panel_Manager_Controls);
            TPage_Manager.Location = new Point(4, 25);
            TPage_Manager.Name = "TPage_Manager";
            TPage_Manager.Padding = new Padding(3);
            TPage_Manager.Size = new Size(791, 476);
            TPage_Manager.TabIndex = 1;
            TPage_Manager.Text = "Manager";
            TPage_Manager.UseVisualStyleBackColor = true;
            // 
            // PFOV_Main
            // 
            PFOV_Main.BorderStyle = BorderStyle.FixedSingle;
            PFOV_Main.Dock = DockStyle.Fill;
            PFOV_Main.Location = new Point(3, 3);
            PFOV_Main.Name = "PFOV_Main";
            PFOV_Main.Size = new Size(579, 470);
            PFOV_Main.TabIndex = 2;
            // 
            // Panel_Manager_Controls
            // 
            Panel_Manager_Controls.BackColor = Color.White;
            Panel_Manager_Controls.Controls.Add(GBox_Manager_Entities);
            Panel_Manager_Controls.Controls.Add(GBox_Manager_RobotControls);
            Panel_Manager_Controls.Dock = DockStyle.Right;
            Panel_Manager_Controls.Location = new Point(582, 3);
            Panel_Manager_Controls.Name = "Panel_Manager_Controls";
            Panel_Manager_Controls.Size = new Size(206, 470);
            Panel_Manager_Controls.TabIndex = 1;
            // 
            // GBox_Manager_Entities
            // 
            GBox_Manager_Entities.BackColor = Color.White;
            GBox_Manager_Entities.Controls.Add(LBox_Entities);
            GBox_Manager_Entities.Location = new Point(6, 3);
            GBox_Manager_Entities.Name = "GBox_Manager_Entities";
            GBox_Manager_Entities.Size = new Size(195, 125);
            GBox_Manager_Entities.TabIndex = 1;
            GBox_Manager_Entities.TabStop = false;
            GBox_Manager_Entities.Text = "Entities";
            // 
            // LBox_Entities
            // 
            LBox_Entities.BackColor = Color.White;
            LBox_Entities.BorderStyle = BorderStyle.None;
            LBox_Entities.Dock = DockStyle.Fill;
            LBox_Entities.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBox_Entities.FormattingEnabled = true;
            LBox_Entities.ItemHeight = 25;
            LBox_Entities.Items.AddRange(new Object[] { "Dummy1", "Dummy2", "Dummy3", "Dummy4" });
            LBox_Entities.Location = new Point(3, 19);
            LBox_Entities.Name = "LBox_Entities";
            LBox_Entities.Size = new Size(189, 103);
            LBox_Entities.TabIndex = 0;
            // 
            // GBox_Manager_RobotControls
            // 
            GBox_Manager_RobotControls.Controls.Add(Nud_ObjX);
            GBox_Manager_RobotControls.Controls.Add(Desc_ObjY);
            GBox_Manager_RobotControls.Controls.Add(Nud_ObjY);
            GBox_Manager_RobotControls.Controls.Add(Desc_ObjX);
            GBox_Manager_RobotControls.Controls.Add(Btn_Manager_CreateObject);
            GBox_Manager_RobotControls.Controls.Add(Btn_Manager_GotoLoc);
            GBox_Manager_RobotControls.Controls.Add(Desc_Target);
            GBox_Manager_RobotControls.Controls.Add(Nud_LocX);
            GBox_Manager_RobotControls.Controls.Add(Desc_LocY);
            GBox_Manager_RobotControls.Controls.Add(comboBox1);
            GBox_Manager_RobotControls.Controls.Add(Nud_LocY);
            GBox_Manager_RobotControls.Controls.Add(Desc_LocX);
            GBox_Manager_RobotControls.Location = new Point(6, 274);
            GBox_Manager_RobotControls.Name = "GBox_Manager_RobotControls";
            GBox_Manager_RobotControls.Size = new Size(195, 191);
            GBox_Manager_RobotControls.TabIndex = 0;
            GBox_Manager_RobotControls.TabStop = false;
            GBox_Manager_RobotControls.Text = "Robot Control";
            // 
            // Nud_ObjX
            // 
            Nud_ObjX.Location = new Point(132, 127);
            Nud_ObjX.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            Nud_ObjX.Name = "Nud_ObjX";
            Nud_ObjX.Size = new Size(57, 23);
            Nud_ObjX.TabIndex = 9;
            // 
            // Desc_ObjY
            // 
            Desc_ObjY.AutoSize = true;
            Desc_ObjY.Location = new Point(109, 156);
            Desc_ObjY.Name = "Desc_ObjY";
            Desc_ObjY.Size = new Size(17, 16);
            Desc_ObjY.TabIndex = 12;
            Desc_ObjY.Text = "Y:";
            // 
            // Nud_ObjY
            // 
            Nud_ObjY.Location = new Point(132, 156);
            Nud_ObjY.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            Nud_ObjY.Name = "Nud_ObjY";
            Nud_ObjY.Size = new Size(57, 23);
            Nud_ObjY.TabIndex = 10;
            // 
            // Desc_ObjX
            // 
            Desc_ObjX.AutoSize = true;
            Desc_ObjX.Location = new Point(109, 129);
            Desc_ObjX.Name = "Desc_ObjX";
            Desc_ObjX.Size = new Size(17, 16);
            Desc_ObjX.TabIndex = 11;
            Desc_ObjX.Text = "X:";
            // 
            // Btn_Manager_CreateObject
            // 
            Btn_Manager_CreateObject.Location = new Point(10, 127);
            Btn_Manager_CreateObject.Name = "Btn_Manager_CreateObject";
            Btn_Manager_CreateObject.Size = new Size(75, 45);
            Btn_Manager_CreateObject.TabIndex = 8;
            Btn_Manager_CreateObject.Text = "Create Object";
            Btn_Manager_CreateObject.UseVisualStyleBackColor = true;
            // 
            // Btn_Manager_GotoLoc
            // 
            Btn_Manager_GotoLoc.Location = new Point(10, 52);
            Btn_Manager_GotoLoc.Name = "Btn_Manager_GotoLoc";
            Btn_Manager_GotoLoc.Size = new Size(75, 45);
            Btn_Manager_GotoLoc.TabIndex = 7;
            Btn_Manager_GotoLoc.Text = "Go To Location";
            Btn_Manager_GotoLoc.UseVisualStyleBackColor = true;
            // 
            // Desc_Target
            // 
            Desc_Target.AutoSize = true;
            Desc_Target.Location = new Point(13, 25);
            Desc_Target.Name = "Desc_Target";
            Desc_Target.Size = new Size(42, 16);
            Desc_Target.TabIndex = 1;
            Desc_Target.Text = "Target:";
            // 
            // Nud_LocX
            // 
            Nud_LocX.Location = new Point(132, 52);
            Nud_LocX.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            Nud_LocX.Name = "Nud_LocX";
            Nud_LocX.Size = new Size(57, 23);
            Nud_LocX.TabIndex = 2;
            // 
            // Desc_LocY
            // 
            Desc_LocY.AutoSize = true;
            Desc_LocY.Location = new Point(109, 81);
            Desc_LocY.Name = "Desc_LocY";
            Desc_LocY.Size = new Size(17, 16);
            Desc_LocY.TabIndex = 5;
            Desc_LocY.Text = "Y:";
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
            // Nud_LocY
            // 
            Nud_LocY.Location = new Point(132, 81);
            Nud_LocY.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            Nud_LocY.Name = "Nud_LocY";
            Nud_LocY.Size = new Size(57, 23);
            Nud_LocY.TabIndex = 3;
            // 
            // Desc_LocX
            // 
            Desc_LocX.AutoSize = true;
            Desc_LocX.Location = new Point(109, 54);
            Desc_LocX.Name = "Desc_LocX";
            Desc_LocX.Size = new Size(17, 16);
            Desc_LocX.TabIndex = 4;
            Desc_LocX.Text = "X:";
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
            Panel_Manager_Controls.ResumeLayout(false);
            GBox_Manager_Entities.ResumeLayout(false);
            GBox_Manager_RobotControls.ResumeLayout(false);
            GBox_Manager_RobotControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Nud_ObjX).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nud_ObjY).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nud_LocX).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nud_LocY).EndInit();
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
        private Panel Panel_Manager_Controls;
        private Button Btn_Server_LogClear;
        private PlayfieldOverview PFOV_Main;
        private GroupBox GBox_Manager_RobotControls;
        private Label Desc_Target;
        private ComboBox comboBox1;
        private GroupBox GBox_Manager_Entities;
        private ListBox LBox_Entities;
        private NumericUpDown Nud_ObjX;
        private Label Desc_ObjY;
        private NumericUpDown Nud_ObjY;
        private Label Desc_ObjX;
        private Button Btn_Manager_CreateObject;
        private Button Btn_Manager_GotoLoc;
        private NumericUpDown Nud_LocX;
        private Label Desc_LocY;
        private NumericUpDown Nud_LocY;
        private Label Desc_LocX;
    }
}