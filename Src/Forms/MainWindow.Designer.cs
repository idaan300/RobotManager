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
            Btn_Server_StopServer = new Button();
            Desc_NumberOfRobotsToManage = new Label();
            Btn_Server_StartServer = new Button();
            Nud_NumberOfRobotsToManage = new NumericUpDown();
            TBox_Server_Address = new TextBox();
            Desc_Server_TargetAddress = new Label();
            Desc_Server_Port = new Label();
            Nud_Server_Port = new NumericUpDown();
            TPage_Manager = new TabPage();
            PFOV_Main = new PlayfieldOverview();
            Panel_Manager_Controls = new Panel();
            GBox_Manager_Entities = new GroupBox();
            label1 = new Label();
            CmBox_RobotTasks = new ComboBox();
            LBox_Entities = new ListBox();
            GBox_Manager_RobotControls = new GroupBox();
            Nud_FlagCreateCount = new NumericUpDown();
            Btn_ResumeFlagCap = new Button();
            button1 = new Button();
            Btn_Manager_CreateFlag = new Button();
            Btn_Manager_GotoLoc = new Button();
            Desc_Target = new Label();
            Nud_LocX = new NumericUpDown();
            Desc_LocY = new Label();
            CmBox_RobotCommands = new ComboBox();
            Nud_LocY = new NumericUpDown();
            Desc_LocX = new Label();
            TControl_Main.SuspendLayout();
            TPage_Server.SuspendLayout();
            Panl_LoggerContainer.SuspendLayout();
            Panl_LoggerOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FCTB_Logger).BeginInit();
            Panel_ServerOptions.SuspendLayout();
            GBox_Server_Config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Nud_NumberOfRobotsToManage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nud_Server_Port).BeginInit();
            TPage_Manager.SuspendLayout();
            Panel_Manager_Controls.SuspendLayout();
            GBox_Manager_Entities.SuspendLayout();
            GBox_Manager_RobotControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Nud_FlagCreateCount).BeginInit();
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
            TControl_Main.Size = new Size(938, 622);
            TControl_Main.TabIndex = 0;
            // 
            // TPage_Server
            // 
            TPage_Server.Controls.Add(Panl_LoggerContainer);
            TPage_Server.Controls.Add(Panel_ServerOptions);
            TPage_Server.Location = new Point(4, 25);
            TPage_Server.Name = "TPage_Server";
            TPage_Server.Padding = new Padding(3);
            TPage_Server.Size = new Size(930, 593);
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
            Panl_LoggerContainer.Size = new Size(924, 472);
            Panl_LoggerContainer.TabIndex = 0;
            // 
            // Panl_LoggerOptions
            // 
            Panl_LoggerOptions.BorderStyle = BorderStyle.Fixed3D;
            Panl_LoggerOptions.Controls.Add(Btn_Server_LogClear);
            Panl_LoggerOptions.Dock = DockStyle.Right;
            Panl_LoggerOptions.Location = new Point(875, 0);
            Panl_LoggerOptions.Name = "Panl_LoggerOptions";
            Panl_LoggerOptions.Size = new Size(49, 472);
            Panl_LoggerOptions.TabIndex = 0;
            // 
            // Btn_Server_LogClear
            // 
            Btn_Server_LogClear.Image = Properties.Resources.ClearIco;
            Btn_Server_LogClear.Location = new Point(3, 4);
            Btn_Server_LogClear.Name = "Btn_Server_LogClear";
            Btn_Server_LogClear.Size = new Size(39, 36);
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
            FCTB_Logger.AutoIndentExistingLines = false;
            FCTB_Logger.AutoScrollMinSize = new Size(0, 14);
            FCTB_Logger.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FCTB_Logger.BackBrush = null;
            FCTB_Logger.BackColor = SystemColors.ControlText;
            FCTB_Logger.BorderStyle = BorderStyle.Fixed3D;
            FCTB_Logger.CaretBlinking = false;
            FCTB_Logger.CaretColor = Color.White;
            FCTB_Logger.CaretVisible = false;
            FCTB_Logger.CharHeight = 14;
            FCTB_Logger.CharWidth = 8;
            FCTB_Logger.DefaultMarkerSize = 8;
            FCTB_Logger.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            FCTB_Logger.Dock = DockStyle.Fill;
            FCTB_Logger.FindForm = null;
            FCTB_Logger.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FCTB_Logger.ForeColor = Color.White;
            FCTB_Logger.GoToForm = null;
            FCTB_Logger.HighlightFoldingIndicator = false;
            FCTB_Logger.Hotkeys = resources.GetString("FCTB_Logger.Hotkeys");
            FCTB_Logger.IsReplaceMode = false;
            FCTB_Logger.Location = new Point(0, 0);
            FCTB_Logger.Name = "FCTB_Logger";
            FCTB_Logger.Paddings = new Padding(0);
            FCTB_Logger.ReadOnly = true;
            FCTB_Logger.ReplaceForm = null;
            FCTB_Logger.SelectionColor = Color.FromArgb(60, 255, 255, 0);
            FCTB_Logger.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("FCTB_Logger.ServiceColors");
            FCTB_Logger.Size = new Size(924, 472);
            FCTB_Logger.TabIndex = 1;
            FCTB_Logger.WordWrap = true;
            FCTB_Logger.Zoom = 100;
            // 
            // Panel_ServerOptions
            // 
            Panel_ServerOptions.Controls.Add(GBox_Server_Config);
            Panel_ServerOptions.Dock = DockStyle.Top;
            Panel_ServerOptions.Location = new Point(3, 3);
            Panel_ServerOptions.Name = "Panel_ServerOptions";
            Panel_ServerOptions.Size = new Size(924, 115);
            Panel_ServerOptions.TabIndex = 0;
            // 
            // GBox_Server_Config
            // 
            GBox_Server_Config.Controls.Add(Btn_Server_StopServer);
            GBox_Server_Config.Controls.Add(Desc_NumberOfRobotsToManage);
            GBox_Server_Config.Controls.Add(Btn_Server_StartServer);
            GBox_Server_Config.Controls.Add(Nud_NumberOfRobotsToManage);
            GBox_Server_Config.Controls.Add(TBox_Server_Address);
            GBox_Server_Config.Controls.Add(Desc_Server_TargetAddress);
            GBox_Server_Config.Controls.Add(Desc_Server_Port);
            GBox_Server_Config.Controls.Add(Nud_Server_Port);
            GBox_Server_Config.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GBox_Server_Config.Location = new Point(5, 0);
            GBox_Server_Config.Name = "GBox_Server_Config";
            GBox_Server_Config.Size = new Size(914, 109);
            GBox_Server_Config.TabIndex = 1;
            GBox_Server_Config.TabStop = false;
            GBox_Server_Config.Text = "Server Configuration";
            // 
            // Btn_Server_StopServer
            // 
            Btn_Server_StopServer.FlatStyle = FlatStyle.System;
            Btn_Server_StopServer.Location = new Point(833, 53);
            Btn_Server_StopServer.Name = "Btn_Server_StopServer";
            Btn_Server_StopServer.Size = new Size(75, 34);
            Btn_Server_StopServer.TabIndex = 3;
            Btn_Server_StopServer.Text = "Stop Server";
            Btn_Server_StopServer.UseVisualStyleBackColor = true;
            // 
            // Desc_NumberOfRobotsToManage
            // 
            Desc_NumberOfRobotsToManage.AutoSize = true;
            Desc_NumberOfRobotsToManage.Location = new Point(15, 81);
            Desc_NumberOfRobotsToManage.Name = "Desc_NumberOfRobotsToManage";
            Desc_NumberOfRobotsToManage.Size = new Size(93, 15);
            Desc_NumberOfRobotsToManage.TabIndex = 6;
            Desc_NumberOfRobotsToManage.Text = "Num Of Robots:";
            // 
            // Btn_Server_StartServer
            // 
            Btn_Server_StartServer.FlatStyle = FlatStyle.System;
            Btn_Server_StartServer.Location = new Point(833, 13);
            Btn_Server_StartServer.Name = "Btn_Server_StartServer";
            Btn_Server_StartServer.Size = new Size(75, 34);
            Btn_Server_StartServer.TabIndex = 2;
            Btn_Server_StartServer.Text = "Start Server";
            Btn_Server_StartServer.UseVisualStyleBackColor = true;
            // 
            // Nud_NumberOfRobotsToManage
            // 
            Nud_NumberOfRobotsToManage.Location = new Point(114, 78);
            Nud_NumberOfRobotsToManage.Maximum = new Decimal(new Int32[] { 2, 0, 0, 0 });
            Nud_NumberOfRobotsToManage.Minimum = new Decimal(new Int32[] { 2, 0, 0, 0 });
            Nud_NumberOfRobotsToManage.Name = "Nud_NumberOfRobotsToManage";
            Nud_NumberOfRobotsToManage.Size = new Size(89, 23);
            Nud_NumberOfRobotsToManage.TabIndex = 5;
            Nud_NumberOfRobotsToManage.Value = new Decimal(new Int32[] { 2, 0, 0, 0 });
            // 
            // TBox_Server_Address
            // 
            TBox_Server_Address.Location = new Point(73, 49);
            TBox_Server_Address.Name = "TBox_Server_Address";
            TBox_Server_Address.Size = new Size(89, 23);
            TBox_Server_Address.TabIndex = 4;
            TBox_Server_Address.Text = "127.0.0.1";
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
            Nud_Server_Port.Value = new Decimal(new Int32[] { 8001, 0, 0, 0 });
            // 
            // TPage_Manager
            // 
            TPage_Manager.Controls.Add(PFOV_Main);
            TPage_Manager.Controls.Add(Panel_Manager_Controls);
            TPage_Manager.Location = new Point(4, 25);
            TPage_Manager.Name = "TPage_Manager";
            TPage_Manager.Padding = new Padding(3);
            TPage_Manager.Size = new Size(930, 593);
            TPage_Manager.TabIndex = 1;
            TPage_Manager.Text = "Manager";
            TPage_Manager.UseVisualStyleBackColor = true;
            // 
            // PFOV_Main
            // 
            PFOV_Main.Location = new Point(3, 3);
            PFOV_Main.Name = "PFOV_Main";
            PFOV_Main.Size = new Size(570, 570);
            PFOV_Main.TabIndex = 2;
            // 
            // Panel_Manager_Controls
            // 
            Panel_Manager_Controls.BackColor = Color.White;
            Panel_Manager_Controls.Controls.Add(GBox_Manager_Entities);
            Panel_Manager_Controls.Controls.Add(GBox_Manager_RobotControls);
            Panel_Manager_Controls.Dock = DockStyle.Right;
            Panel_Manager_Controls.Location = new Point(579, 3);
            Panel_Manager_Controls.Name = "Panel_Manager_Controls";
            Panel_Manager_Controls.Size = new Size(348, 587);
            Panel_Manager_Controls.TabIndex = 1;
            // 
            // GBox_Manager_Entities
            // 
            GBox_Manager_Entities.BackColor = Color.White;
            GBox_Manager_Entities.Controls.Add(label1);
            GBox_Manager_Entities.Controls.Add(CmBox_RobotTasks);
            GBox_Manager_Entities.Controls.Add(LBox_Entities);
            GBox_Manager_Entities.Location = new Point(6, 3);
            GBox_Manager_Entities.Name = "GBox_Manager_Entities";
            GBox_Manager_Entities.Size = new Size(337, 425);
            GBox_Manager_Entities.TabIndex = 1;
            GBox_Manager_Entities.TabStop = false;
            GBox_Manager_Entities.Text = "Robot Tasks";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 3;
            label1.Text = "Target:";
            // 
            // CmBox_RobotTasks
            // 
            CmBox_RobotTasks.DropDownStyle = ComboBoxStyle.DropDownList;
            CmBox_RobotTasks.FormattingEnabled = true;
            CmBox_RobotTasks.Items.AddRange(new Object[] { "Pinky", "Blinky" });
            CmBox_RobotTasks.Location = new Point(68, 22);
            CmBox_RobotTasks.Name = "CmBox_RobotTasks";
            CmBox_RobotTasks.Size = new Size(263, 24);
            CmBox_RobotTasks.TabIndex = 2;
            // 
            // LBox_Entities
            // 
            LBox_Entities.BackColor = Color.White;
            LBox_Entities.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBox_Entities.FormattingEnabled = true;
            LBox_Entities.ItemHeight = 25;
            LBox_Entities.Items.AddRange(new Object[] { "Pickup Flag At (0,1)", "Pickup Flag At (5,10)", "Deliver Flag(s) To (0,0)" });
            LBox_Entities.Location = new Point(6, 51);
            LBox_Entities.Name = "LBox_Entities";
            LBox_Entities.Size = new Size(325, 354);
            LBox_Entities.TabIndex = 0;
            // 
            // GBox_Manager_RobotControls
            // 
            GBox_Manager_RobotControls.Controls.Add(Nud_FlagCreateCount);
            GBox_Manager_RobotControls.Controls.Add(Btn_ResumeFlagCap);
            GBox_Manager_RobotControls.Controls.Add(button1);
            GBox_Manager_RobotControls.Controls.Add(Btn_Manager_CreateFlag);
            GBox_Manager_RobotControls.Controls.Add(Btn_Manager_GotoLoc);
            GBox_Manager_RobotControls.Controls.Add(Desc_Target);
            GBox_Manager_RobotControls.Controls.Add(Nud_LocX);
            GBox_Manager_RobotControls.Controls.Add(Desc_LocY);
            GBox_Manager_RobotControls.Controls.Add(CmBox_RobotCommands);
            GBox_Manager_RobotControls.Controls.Add(Nud_LocY);
            GBox_Manager_RobotControls.Controls.Add(Desc_LocX);
            GBox_Manager_RobotControls.Location = new Point(6, 429);
            GBox_Manager_RobotControls.Name = "GBox_Manager_RobotControls";
            GBox_Manager_RobotControls.Size = new Size(337, 153);
            GBox_Manager_RobotControls.TabIndex = 0;
            GBox_Manager_RobotControls.TabStop = false;
            GBox_Manager_RobotControls.Text = "Robot Control";
            // 
            // Nud_FlagCreateCount
            // 
            Nud_FlagCreateCount.Location = new Point(33, 115);
            Nud_FlagCreateCount.Maximum = new Decimal(new Int32[] { 4, 0, 0, 0 });
            Nud_FlagCreateCount.Minimum = new Decimal(new Int32[] { 1, 0, 0, 0 });
            Nud_FlagCreateCount.Name = "Nud_FlagCreateCount";
            Nud_FlagCreateCount.Size = new Size(37, 23);
            Nud_FlagCreateCount.TabIndex = 11;
            Nud_FlagCreateCount.Value = new Decimal(new Int32[] { 1, 0, 0, 0 });
            // 
            // Btn_ResumeFlagCap
            // 
            Btn_ResumeFlagCap.Enabled = false;
            Btn_ResumeFlagCap.Location = new Point(57, 52);
            Btn_ResumeFlagCap.Name = "Btn_ResumeFlagCap";
            Btn_ResumeFlagCap.Size = new Size(86, 45);
            Btn_ResumeFlagCap.TabIndex = 10;
            Btn_ResumeFlagCap.Text = "Resume Flag Capture";
            Btn_ResumeFlagCap.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(172, 103);
            button1.Name = "button1";
            button1.Size = new Size(96, 45);
            button1.TabIndex = 9;
            button1.Text = "Emergency Stop";
            button1.UseVisualStyleBackColor = true;
            // 
            // Btn_Manager_CreateFlag
            // 
            Btn_Manager_CreateFlag.Location = new Point(76, 103);
            Btn_Manager_CreateFlag.Name = "Btn_Manager_CreateFlag";
            Btn_Manager_CreateFlag.Size = new Size(86, 45);
            Btn_Manager_CreateFlag.TabIndex = 8;
            Btn_Manager_CreateFlag.Text = "Create New Flag(s)";
            Btn_Manager_CreateFlag.UseVisualStyleBackColor = true;
            Btn_Manager_CreateFlag.Click += Btn_Manager_CreateFlag_Click;
            // 
            // Btn_Manager_GotoLoc
            // 
            Btn_Manager_GotoLoc.Location = new Point(149, 52);
            Btn_Manager_GotoLoc.Name = "Btn_Manager_GotoLoc";
            Btn_Manager_GotoLoc.Size = new Size(96, 45);
            Btn_Manager_GotoLoc.TabIndex = 7;
            Btn_Manager_GotoLoc.Text = "Go To Location Override";
            Btn_Manager_GotoLoc.UseVisualStyleBackColor = true;
            // 
            // Desc_Target
            // 
            Desc_Target.AutoSize = true;
            Desc_Target.Location = new Point(8, 25);
            Desc_Target.Name = "Desc_Target";
            Desc_Target.Size = new Size(42, 16);
            Desc_Target.TabIndex = 1;
            Desc_Target.Text = "Target:";
            // 
            // Nud_LocX
            // 
            Nud_LocX.Location = new Point(274, 52);
            Nud_LocX.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            Nud_LocX.Name = "Nud_LocX";
            Nud_LocX.Size = new Size(57, 23);
            Nud_LocX.TabIndex = 2;
            // 
            // Desc_LocY
            // 
            Desc_LocY.AutoSize = true;
            Desc_LocY.Location = new Point(251, 81);
            Desc_LocY.Name = "Desc_LocY";
            Desc_LocY.Size = new Size(17, 16);
            Desc_LocY.TabIndex = 5;
            Desc_LocY.Text = "Y:";
            // 
            // CmBox_RobotCommands
            // 
            CmBox_RobotCommands.DropDownStyle = ComboBoxStyle.DropDownList;
            CmBox_RobotCommands.FormattingEnabled = true;
            CmBox_RobotCommands.Items.AddRange(new Object[] { "Pinky", "Blinky" });
            CmBox_RobotCommands.Location = new Point(57, 22);
            CmBox_RobotCommands.Name = "CmBox_RobotCommands";
            CmBox_RobotCommands.Size = new Size(274, 24);
            CmBox_RobotCommands.TabIndex = 0;
            // 
            // Nud_LocY
            // 
            Nud_LocY.Location = new Point(274, 81);
            Nud_LocY.Maximum = new Decimal(new Int32[] { 32, 0, 0, 0 });
            Nud_LocY.Name = "Nud_LocY";
            Nud_LocY.Size = new Size(57, 23);
            Nud_LocY.TabIndex = 3;
            // 
            // Desc_LocX
            // 
            Desc_LocX.AutoSize = true;
            Desc_LocX.Location = new Point(251, 54);
            Desc_LocX.Name = "Desc_LocX";
            Desc_LocX.Size = new Size(17, 16);
            Desc_LocX.TabIndex = 4;
            Desc_LocX.Text = "X:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 622);
            Controls.Add(TControl_Main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)Nud_NumberOfRobotsToManage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nud_Server_Port).EndInit();
            TPage_Manager.ResumeLayout(false);
            Panel_Manager_Controls.ResumeLayout(false);
            GBox_Manager_Entities.ResumeLayout(false);
            GBox_Manager_Entities.PerformLayout();
            GBox_Manager_RobotControls.ResumeLayout(false);
            GBox_Manager_RobotControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Nud_FlagCreateCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nud_LocX).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nud_LocY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TControl_Main;
        private TabPage TPage_Server;
        private TabPage TPage_Manager;
        private FastColoredTextBoxNS.FastColoredTextBox FCTB_Logger;
        private Panel Panl_LoggerContainer;
        private Panel Panl_LoggerOptions;
        private Panel Panel_ServerOptions;
        private GroupBox GBox_Server_Config;
        private Label Desc_Server_TargetAddress;
        private Label Desc_Server_Port;
        private NumericUpDown Nud_Server_Port;
        private TextBox TBox_Server_Address;
        private Panel Panel_Manager_Controls;
        private Button Btn_Server_LogClear;
        private PlayfieldOverview PFOV_Main;
        private GroupBox GBox_Manager_RobotControls;
        private Label Desc_Target;
        private ComboBox CmBox_RobotCommands;
        private GroupBox GBox_Manager_Entities;
        private ListBox LBox_Entities;
        private Button Btn_Manager_CreateFlag;
        private Button Btn_Manager_GotoLoc;
        private NumericUpDown Nud_LocX;
        private Label Desc_LocY;
        private NumericUpDown Nud_LocY;
        private Label Desc_LocX;
        private Label Desc_NumberOfRobotsToManage;
        private NumericUpDown Nud_NumberOfRobotsToManage;
        private Button Btn_Server_StopServer;
        private Button Btn_Server_StartServer;
        private Label label1;
        private ComboBox CmBox_RobotTasks;
        private Button Btn_ResumeFlagCap;
        private Button button1;
        private NumericUpDown Nud_FlagCreateCount;
    }
}