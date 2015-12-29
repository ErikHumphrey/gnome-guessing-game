namespace HumphreyErikGuessPuzzle
{
    partial class frmGuessPuzzle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuessPuzzle));
            this.tmrGnomeHead = new System.Windows.Forms.Timer(this.components);
            this.tabGuess = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGuess9 = new System.Windows.Forms.Label();
            this.lblGuess8 = new System.Windows.Forms.Label();
            this.lblGuess7 = new System.Windows.Forms.Label();
            this.lblGuess6 = new System.Windows.Forms.Label();
            this.lblGuess5 = new System.Windows.Forms.Label();
            this.lblGuess4 = new System.Windows.Forms.Label();
            this.lblGuess3 = new System.Windows.Forms.Label();
            this.lblGuess2 = new System.Windows.Forms.Label();
            this.lblSelectAnOption = new System.Windows.Forms.Label();
            this.lblGuess1 = new System.Windows.Forms.Label();
            this.tabGnomeDialogue = new System.Windows.Forms.TabPage();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblClickToContinue = new System.Windows.Forms.Label();
            this.picGnomeChild = new System.Windows.Forms.PictureBox();
            this.lblGnomeName = new System.Windows.Forms.Label();
            this.lblGnomeChat = new System.Windows.Forms.Label();
            this.tabsSections = new System.Windows.Forms.TabControl();
            this.tabQuestComplete = new System.Windows.Forms.TabPage();
            this.lblClickToAskForReplay = new System.Windows.Forms.Label();
            this.lblCongratulationsQuestComplete = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.tabAskForReplay = new System.Windows.Forms.TabPage();
            this.lblNoReplay = new System.Windows.Forms.Label();
            this.lblResetPuzzle = new System.Windows.Forms.Label();
            this.lblWannaReset = new System.Windows.Forms.Label();
            this.tmrPleaseWait = new System.Windows.Forms.Timer(this.components);
            this.tabGuess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabGnomeDialogue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGnomeChild)).BeginInit();
            this.tabsSections.SuspendLayout();
            this.tabQuestComplete.SuspendLayout();
            this.tabAskForReplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGuess
            // 
            this.tabGuess.BackgroundImage = global::HumphreyErikGuessPuzzle.Properties.Resources.mysterybg;
            this.tabGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabGuess.Controls.Add(this.pictureBox3);
            this.tabGuess.Controls.Add(this.pictureBox1);
            this.tabGuess.Controls.Add(this.lblGuess9);
            this.tabGuess.Controls.Add(this.lblGuess8);
            this.tabGuess.Controls.Add(this.lblGuess7);
            this.tabGuess.Controls.Add(this.lblGuess6);
            this.tabGuess.Controls.Add(this.lblGuess5);
            this.tabGuess.Controls.Add(this.lblGuess4);
            this.tabGuess.Controls.Add(this.lblGuess3);
            this.tabGuess.Controls.Add(this.lblGuess2);
            this.tabGuess.Controls.Add(this.lblSelectAnOption);
            this.tabGuess.Controls.Add(this.lblGuess1);
            this.tabGuess.Location = new System.Drawing.Point(4, 5);
            this.tabGuess.Name = "tabGuess";
            this.tabGuess.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuess.Size = new System.Drawing.Size(524, 162);
            this.tabGuess.TabIndex = 1;
            this.tabGuess.Text = "Guess";
            this.tabGuess.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HumphreyErikGuessPuzzle.Properties.Resources.imgSwordLeft;
            this.pictureBox3.Location = new System.Drawing.Point(340, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HumphreyErikGuessPuzzle.Properties.Resources.imgSwordRight;
            this.pictureBox1.Location = new System.Drawing.Point(90, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblGuess9
            // 
            this.lblGuess9.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess9.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess9.Location = new System.Drawing.Point(336, 93);
            this.lblGuess9.Name = "lblGuess9";
            this.lblGuess9.Size = new System.Drawing.Size(108, 22);
            this.lblGuess9.TabIndex = 26;
            this.lblGuess9.Text = "nine (9)";
            this.lblGuess9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess9.Click += new System.EventHandler(this.lblGuess9_Click);
            this.lblGuess9.MouseEnter += new System.EventHandler(this.lblGuess9_MouseEnter);
            this.lblGuess9.MouseLeave += new System.EventHandler(this.lblGuess9_MouseLeave);
            // 
            // lblGuess8
            // 
            this.lblGuess8.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess8.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess8.Location = new System.Drawing.Point(336, 71);
            this.lblGuess8.Name = "lblGuess8";
            this.lblGuess8.Size = new System.Drawing.Size(108, 22);
            this.lblGuess8.TabIndex = 25;
            this.lblGuess8.Text = "eight (8)";
            this.lblGuess8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess8.Click += new System.EventHandler(this.lblGuess8_Click);
            this.lblGuess8.MouseEnter += new System.EventHandler(this.lblGuess8_MouseEnter);
            this.lblGuess8.MouseLeave += new System.EventHandler(this.lblGuess8_MouseLeave);
            // 
            // lblGuess7
            // 
            this.lblGuess7.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess7.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess7.Location = new System.Drawing.Point(336, 49);
            this.lblGuess7.Name = "lblGuess7";
            this.lblGuess7.Size = new System.Drawing.Size(108, 22);
            this.lblGuess7.TabIndex = 24;
            this.lblGuess7.Text = "seven (7)";
            this.lblGuess7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess7.Click += new System.EventHandler(this.lblGuess7_Click);
            this.lblGuess7.MouseEnter += new System.EventHandler(this.lblGuess7_MouseEnter);
            this.lblGuess7.MouseLeave += new System.EventHandler(this.lblGuess7_MouseLeave);
            // 
            // lblGuess6
            // 
            this.lblGuess6.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess6.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess6.Location = new System.Drawing.Point(215, 93);
            this.lblGuess6.Name = "lblGuess6";
            this.lblGuess6.Size = new System.Drawing.Size(108, 22);
            this.lblGuess6.TabIndex = 23;
            this.lblGuess6.Text = "six (6)";
            this.lblGuess6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess6.Click += new System.EventHandler(this.lblGuess6_Click);
            this.lblGuess6.MouseEnter += new System.EventHandler(this.lblGuess6_MouseEnter);
            this.lblGuess6.MouseLeave += new System.EventHandler(this.lblGuess6_MouseLeave);
            // 
            // lblGuess5
            // 
            this.lblGuess5.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess5.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess5.Location = new System.Drawing.Point(215, 71);
            this.lblGuess5.Name = "lblGuess5";
            this.lblGuess5.Size = new System.Drawing.Size(108, 22);
            this.lblGuess5.TabIndex = 22;
            this.lblGuess5.Text = "five (5)";
            this.lblGuess5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess5.Click += new System.EventHandler(this.lblGuess5_Click);
            this.lblGuess5.MouseEnter += new System.EventHandler(this.lblGuess5_MouseEnter);
            this.lblGuess5.MouseLeave += new System.EventHandler(this.lblGuess5_MouseLeave);
            // 
            // lblGuess4
            // 
            this.lblGuess4.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess4.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess4.Location = new System.Drawing.Point(215, 49);
            this.lblGuess4.Name = "lblGuess4";
            this.lblGuess4.Size = new System.Drawing.Size(108, 22);
            this.lblGuess4.TabIndex = 21;
            this.lblGuess4.Text = "four (4)";
            this.lblGuess4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess4.Click += new System.EventHandler(this.lblGuess4_Click);
            this.lblGuess4.MouseEnter += new System.EventHandler(this.lblGuess4_MouseEnter);
            this.lblGuess4.MouseLeave += new System.EventHandler(this.lblGuess4_MouseLeave);
            // 
            // lblGuess3
            // 
            this.lblGuess3.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess3.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess3.Location = new System.Drawing.Point(86, 93);
            this.lblGuess3.Name = "lblGuess3";
            this.lblGuess3.Size = new System.Drawing.Size(108, 22);
            this.lblGuess3.TabIndex = 20;
            this.lblGuess3.Text = "three (3)";
            this.lblGuess3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess3.Click += new System.EventHandler(this.lblGuess3_Click);
            this.lblGuess3.MouseEnter += new System.EventHandler(this.lblGuess3_MouseEnter);
            this.lblGuess3.MouseLeave += new System.EventHandler(this.lblGuess3_MouseLeave);
            // 
            // lblGuess2
            // 
            this.lblGuess2.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess2.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess2.Location = new System.Drawing.Point(86, 71);
            this.lblGuess2.Name = "lblGuess2";
            this.lblGuess2.Size = new System.Drawing.Size(108, 22);
            this.lblGuess2.TabIndex = 19;
            this.lblGuess2.Text = "two (2)";
            this.lblGuess2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess2.Click += new System.EventHandler(this.lblGuess2_Click);
            this.lblGuess2.MouseEnter += new System.EventHandler(this.lblGuess2_MouseEnter);
            this.lblGuess2.MouseLeave += new System.EventHandler(this.lblGuess2_MouseLeave);
            // 
            // lblSelectAnOption
            // 
            this.lblSelectAnOption.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectAnOption.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAnOption.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSelectAnOption.Location = new System.Drawing.Point(0, 20);
            this.lblSelectAnOption.Name = "lblSelectAnOption";
            this.lblSelectAnOption.Size = new System.Drawing.Size(524, 23);
            this.lblSelectAnOption.TabIndex = 14;
            this.lblSelectAnOption.Text = "Select an Option";
            this.lblSelectAnOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuess1
            // 
            this.lblGuess1.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess1.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess1.Location = new System.Drawing.Point(87, 49);
            this.lblGuess1.Name = "lblGuess1";
            this.lblGuess1.Size = new System.Drawing.Size(108, 22);
            this.lblGuess1.TabIndex = 15;
            this.lblGuess1.Text = "one (1)";
            this.lblGuess1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuess1.Click += new System.EventHandler(this.lblGuess1_Click);
            this.lblGuess1.MouseEnter += new System.EventHandler(this.lblGuess1_MouseEnter);
            this.lblGuess1.MouseLeave += new System.EventHandler(this.lblGuess1_MouseLeave);
            // 
            // tabGnomeDialogue
            // 
            this.tabGnomeDialogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabGnomeDialogue.BackgroundImage = global::HumphreyErikGuessPuzzle.Properties.Resources.mysterybg;
            this.tabGnomeDialogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabGnomeDialogue.Controls.Add(this.picClose);
            this.tabGnomeDialogue.Controls.Add(this.lblClickToContinue);
            this.tabGnomeDialogue.Controls.Add(this.picGnomeChild);
            this.tabGnomeDialogue.Controls.Add(this.lblGnomeName);
            this.tabGnomeDialogue.Controls.Add(this.lblGnomeChat);
            this.tabGnomeDialogue.Location = new System.Drawing.Point(4, 5);
            this.tabGnomeDialogue.Margin = new System.Windows.Forms.Padding(0);
            this.tabGnomeDialogue.Name = "tabGnomeDialogue";
            this.tabGnomeDialogue.Size = new System.Drawing.Size(524, 162);
            this.tabGnomeDialogue.TabIndex = 0;
            this.tabGnomeDialogue.Text = "Chat";
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::HumphreyErikGuessPuzzle.Properties.Resources.closex;
            this.picClose.Location = new System.Drawing.Point(487, 15);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(21, 23);
            this.picClose.TabIndex = 8;
            this.picClose.TabStop = false;
            this.picClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // lblClickToContinue
            // 
            this.lblClickToContinue.BackColor = System.Drawing.Color.Transparent;
            this.lblClickToContinue.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToContinue.ForeColor = System.Drawing.Color.Blue;
            this.lblClickToContinue.Location = new System.Drawing.Point(228, 121);
            this.lblClickToContinue.Name = "lblClickToContinue";
            this.lblClickToContinue.Size = new System.Drawing.Size(185, 23);
            this.lblClickToContinue.TabIndex = 12;
            this.lblClickToContinue.Text = "Click here to continue";
            this.lblClickToContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClickToContinue.Click += new System.EventHandler(this.lblClickToContinue_Click);
            this.lblClickToContinue.MouseEnter += new System.EventHandler(this.lblClickToContinue_MouseEnter);
            this.lblClickToContinue.MouseLeave += new System.EventHandler(this.lblClickToContinue_MouseLeave);
            // 
            // picGnomeChild
            // 
            this.picGnomeChild.BackColor = System.Drawing.Color.Transparent;
            this.picGnomeChild.Image = global::HumphreyErikGuessPuzzle.Properties.Resources.gnome19;
            this.picGnomeChild.Location = new System.Drawing.Point(37, 17);
            this.picGnomeChild.Name = "picGnomeChild";
            this.picGnomeChild.Size = new System.Drawing.Size(85, 112);
            this.picGnomeChild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGnomeChild.TabIndex = 11;
            this.picGnomeChild.TabStop = false;
            // 
            // lblGnomeName
            // 
            this.lblGnomeName.BackColor = System.Drawing.Color.Transparent;
            this.lblGnomeName.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGnomeName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGnomeName.Location = new System.Drawing.Point(143, 20);
            this.lblGnomeName.Name = "lblGnomeName";
            this.lblGnomeName.Size = new System.Drawing.Size(338, 23);
            this.lblGnomeName.TabIndex = 9;
            this.lblGnomeName.Text = "Gnome child";
            this.lblGnomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGnomeChat
            // 
            this.lblGnomeChat.BackColor = System.Drawing.Color.Transparent;
            this.lblGnomeChat.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGnomeChat.Location = new System.Drawing.Point(143, 28);
            this.lblGnomeChat.Name = "lblGnomeChat";
            this.lblGnomeChat.Size = new System.Drawing.Size(357, 96);
            this.lblGnomeChat.TabIndex = 10;
            this.lblGnomeChat.Text = "Hey, you! There\'s gnome treasure behind this locked door, but I can\'t open it wit" +
    "hout a number from 1 to 9! Perhaps you can solve the puzzle?";
            this.lblGnomeChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabsSections
            // 
            this.tabsSections.Controls.Add(this.tabGnomeDialogue);
            this.tabsSections.Controls.Add(this.tabGuess);
            this.tabsSections.Controls.Add(this.tabQuestComplete);
            this.tabsSections.Controls.Add(this.tabAskForReplay);
            this.tabsSections.Font = new System.Drawing.Font("RuneScape NPC Chat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsSections.ItemSize = new System.Drawing.Size(0, 1);
            this.tabsSections.Location = new System.Drawing.Point(9, 9);
            this.tabsSections.Margin = new System.Windows.Forms.Padding(0);
            this.tabsSections.Name = "tabsSections";
            this.tabsSections.Padding = new System.Drawing.Point(0, 0);
            this.tabsSections.SelectedIndex = 0;
            this.tabsSections.Size = new System.Drawing.Size(532, 171);
            this.tabsSections.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabsSections.TabIndex = 0;
            // 
            // tabQuestComplete
            // 
            this.tabQuestComplete.BackgroundImage = global::HumphreyErikGuessPuzzle.Properties.Resources.mysterybg;
            this.tabQuestComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabQuestComplete.Controls.Add(this.lblClickToAskForReplay);
            this.tabQuestComplete.Controls.Add(this.lblCongratulationsQuestComplete);
            this.tabQuestComplete.Controls.Add(this.lblAttempts);
            this.tabQuestComplete.Font = new System.Drawing.Font("RuneScape NPC Chat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuestComplete.Location = new System.Drawing.Point(4, 5);
            this.tabQuestComplete.Name = "tabQuestComplete";
            this.tabQuestComplete.Size = new System.Drawing.Size(524, 162);
            this.tabQuestComplete.TabIndex = 2;
            this.tabQuestComplete.Text = "Quest complete!";
            this.tabQuestComplete.UseVisualStyleBackColor = true;
            // 
            // lblClickToAskForReplay
            // 
            this.lblClickToAskForReplay.BackColor = System.Drawing.Color.Transparent;
            this.lblClickToAskForReplay.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToAskForReplay.ForeColor = System.Drawing.Color.Blue;
            this.lblClickToAskForReplay.Location = new System.Drawing.Point(170, 110);
            this.lblClickToAskForReplay.Name = "lblClickToAskForReplay";
            this.lblClickToAskForReplay.Size = new System.Drawing.Size(185, 23);
            this.lblClickToAskForReplay.TabIndex = 16;
            this.lblClickToAskForReplay.Text = "Click here to continue";
            this.lblClickToAskForReplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClickToAskForReplay.Click += new System.EventHandler(this.lblClickToAskForReplay_Click);
            this.lblClickToAskForReplay.MouseEnter += new System.EventHandler(this.lblClickToAskForReplay_MouseEnter);
            this.lblClickToAskForReplay.MouseLeave += new System.EventHandler(this.lblClickToAskForReplay_MouseLeave);
            // 
            // lblCongratulationsQuestComplete
            // 
            this.lblCongratulationsQuestComplete.BackColor = System.Drawing.Color.Transparent;
            this.lblCongratulationsQuestComplete.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongratulationsQuestComplete.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCongratulationsQuestComplete.Location = new System.Drawing.Point(0, 20);
            this.lblCongratulationsQuestComplete.Name = "lblCongratulationsQuestComplete";
            this.lblCongratulationsQuestComplete.Size = new System.Drawing.Size(524, 23);
            this.lblCongratulationsQuestComplete.TabIndex = 15;
            this.lblCongratulationsQuestComplete.Text = "Congratulations, quest complete!";
            this.lblCongratulationsQuestComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttempts
            // 
            this.lblAttempts.BackColor = System.Drawing.Color.Transparent;
            this.lblAttempts.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempts.Location = new System.Drawing.Point(4, 43);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(517, 65);
            this.lblAttempts.TabIndex = 11;
            this.lblAttempts.Text = "It took you a lot of tries.";
            this.lblAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabAskForReplay
            // 
            this.tabAskForReplay.BackgroundImage = global::HumphreyErikGuessPuzzle.Properties.Resources.mysterybg;
            this.tabAskForReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAskForReplay.Controls.Add(this.lblNoReplay);
            this.tabAskForReplay.Controls.Add(this.lblResetPuzzle);
            this.tabAskForReplay.Controls.Add(this.lblWannaReset);
            this.tabAskForReplay.Location = new System.Drawing.Point(4, 5);
            this.tabAskForReplay.Name = "tabAskForReplay";
            this.tabAskForReplay.Size = new System.Drawing.Size(524, 162);
            this.tabAskForReplay.TabIndex = 3;
            this.tabAskForReplay.Text = "Replay?";
            // 
            // lblNoReplay
            // 
            this.lblNoReplay.BackColor = System.Drawing.Color.Transparent;
            this.lblNoReplay.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoReplay.Location = new System.Drawing.Point(179, 83);
            this.lblNoReplay.Name = "lblNoReplay";
            this.lblNoReplay.Size = new System.Drawing.Size(171, 22);
            this.lblNoReplay.TabIndex = 23;
            this.lblNoReplay.Text = "No, close the program.";
            this.lblNoReplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoReplay.Click += new System.EventHandler(this.lblNoReplay_Click);
            this.lblNoReplay.MouseEnter += new System.EventHandler(this.lblNoReplay_MouseEnter);
            this.lblNoReplay.MouseLeave += new System.EventHandler(this.lblNoReplay_MouseLeave);
            // 
            // lblResetPuzzle
            // 
            this.lblResetPuzzle.BackColor = System.Drawing.Color.Transparent;
            this.lblResetPuzzle.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPuzzle.Location = new System.Drawing.Point(169, 50);
            this.lblResetPuzzle.Name = "lblResetPuzzle";
            this.lblResetPuzzle.Size = new System.Drawing.Size(186, 22);
            this.lblResetPuzzle.TabIndex = 22;
            this.lblResetPuzzle.Text = "Yes, I want to try again!";
            this.lblResetPuzzle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResetPuzzle.Click += new System.EventHandler(this.lblResetPuzzle_Click);
            this.lblResetPuzzle.MouseEnter += new System.EventHandler(this.lblResetPuzzle_MouseEnter);
            this.lblResetPuzzle.MouseLeave += new System.EventHandler(this.lblResetPuzzle_MouseLeave);
            // 
            // lblWannaReset
            // 
            this.lblWannaReset.BackColor = System.Drawing.Color.Transparent;
            this.lblWannaReset.Font = new System.Drawing.Font("RuneScape NPC Chat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWannaReset.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWannaReset.Location = new System.Drawing.Point(0, 20);
            this.lblWannaReset.Name = "lblWannaReset";
            this.lblWannaReset.Size = new System.Drawing.Size(524, 23);
            this.lblWannaReset.TabIndex = 16;
            this.lblWannaReset.Text = "Do you want to reset the puzzle?";
            this.lblWannaReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrPleaseWait
            // 
            this.tmrPleaseWait.Interval = 650;
            this.tmrPleaseWait.Tick += new System.EventHandler(this.tmrPleaseWait_Tick);
            // 
            // frmGuessPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(558, 189);
            this.Controls.Add(this.tabsSections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuessPuzzle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Guess Puzzle by Erik H.";
            this.Load += new System.EventHandler(this.frmGuessPuzzle_Load);
            this.tabGuess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabGnomeDialogue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGnomeChild)).EndInit();
            this.tabsSections.ResumeLayout(false);
            this.tabQuestComplete.ResumeLayout(false);
            this.tabAskForReplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrGnomeHead;
        private System.Windows.Forms.TabPage tabGuess;
        private System.Windows.Forms.Label lblSelectAnOption;
        private System.Windows.Forms.Label lblGuess1;
        private System.Windows.Forms.TabPage tabGnomeDialogue;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblClickToContinue;
        private System.Windows.Forms.PictureBox picGnomeChild;
        private System.Windows.Forms.Label lblGnomeName;
        private System.Windows.Forms.Label lblGnomeChat;
        private System.Windows.Forms.TabControl tabsSections;
        private System.Windows.Forms.Label lblGuess9;
        private System.Windows.Forms.Label lblGuess8;
        private System.Windows.Forms.Label lblGuess7;
        private System.Windows.Forms.Label lblGuess6;
        private System.Windows.Forms.Label lblGuess5;
        private System.Windows.Forms.Label lblGuess4;
        private System.Windows.Forms.Label lblGuess3;
        private System.Windows.Forms.Label lblGuess2;
        private System.Windows.Forms.Timer tmrPleaseWait;
        private System.Windows.Forms.TabPage tabQuestComplete;
        private System.Windows.Forms.Label lblClickToAskForReplay;
        private System.Windows.Forms.Label lblCongratulationsQuestComplete;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.TabPage tabAskForReplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWannaReset;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNoReplay;
        private System.Windows.Forms.Label lblResetPuzzle;
    }
}

