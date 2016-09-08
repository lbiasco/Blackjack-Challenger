namespace Blackjack
{
    partial class BlackjackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackjackForm));
            this.deckPicture = new System.Windows.Forms.PictureBox();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.playerCard1Picture = new System.Windows.Forms.PictureBox();
            this.playerCard2Picture = new System.Windows.Forms.PictureBox();
            this.houseCard1Picture = new System.Windows.Forms.PictureBox();
            this.houseCard2Picture = new System.Windows.Forms.PictureBox();
            this.stayButton = new System.Windows.Forms.Button();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.bankTextBox = new System.Windows.Forms.TextBox();
            this.betLabel = new System.Windows.Forms.Label();
            this.bankLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.playerCard3Picture = new System.Windows.Forms.PictureBox();
            this.playerCard4Picture = new System.Windows.Forms.PictureBox();
            this.playerCard5Picture = new System.Windows.Forms.PictureBox();
            this.houseCard3Picture = new System.Windows.Forms.PictureBox();
            this.houseCard4Picture = new System.Windows.Forms.PictureBox();
            this.houseCard5Picture = new System.Windows.Forms.PictureBox();
            this.playerCard6Picture = new System.Windows.Forms.PictureBox();
            this.houseCard6Picture = new System.Windows.Forms.PictureBox();
            this.playerCard7Picture = new System.Windows.Forms.PictureBox();
            this.houseCard7Picture = new System.Windows.Forms.PictureBox();
            this.playerCard8Picture = new System.Windows.Forms.PictureBox();
            this.houseCard8Picture = new System.Windows.Forms.PictureBox();
            this.enemyBankLabel = new System.Windows.Forms.Label();
            this.houseBankTextBox = new System.Windows.Forms.TextBox();
            this.houseOutputLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cardStylesTS = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripEnabler = new System.Windows.Forms.Timer(this.components);
            this.deckTopPicture = new System.Windows.Forms.PictureBox();
            this.level1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level2 = new System.Windows.Forms.ToolStripMenuItem();
            this.level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.level4 = new System.Windows.Forms.ToolStripMenuItem();
            this.level5 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.deckPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard3Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard4Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard5Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard6Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard6Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard7Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard7Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard8Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard8Picture)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckTopPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // deckPicture
            // 
            this.deckPicture.Image = ((System.Drawing.Image)(resources.GetObject("deckPicture.Image")));
            this.deckPicture.Location = new System.Drawing.Point(466, 118);
            this.deckPicture.Name = "deckPicture";
            this.deckPicture.Size = new System.Drawing.Size(71, 102);
            this.deckPicture.TabIndex = 0;
            this.deckPicture.TabStop = false;
            // 
            // dealButton
            // 
            this.dealButton.BackColor = System.Drawing.SystemColors.Control;
            this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(86, 333);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(101, 44);
            this.dealButton.TabIndex = 1;
            this.dealButton.Text = "DEAL";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.SystemColors.Control;
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(30, 333);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(101, 44);
            this.hitButton.TabIndex = 2;
            this.hitButton.Text = "HIT";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Visible = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // playerCard1Picture
            // 
            this.playerCard1Picture.BackColor = System.Drawing.Color.Transparent;
            this.playerCard1Picture.Location = new System.Drawing.Point(34, 183);
            this.playerCard1Picture.Name = "playerCard1Picture";
            this.playerCard1Picture.Size = new System.Drawing.Size(72, 96);
            this.playerCard1Picture.TabIndex = 3;
            this.playerCard1Picture.TabStop = false;
            this.playerCard1Picture.Visible = false;
            // 
            // playerCard2Picture
            // 
            this.playerCard2Picture.BackColor = System.Drawing.Color.Transparent;
            this.playerCard2Picture.Location = new System.Drawing.Point(134, 183);
            this.playerCard2Picture.Name = "playerCard2Picture";
            this.playerCard2Picture.Size = new System.Drawing.Size(72, 96);
            this.playerCard2Picture.TabIndex = 4;
            this.playerCard2Picture.TabStop = false;
            this.playerCard2Picture.Visible = false;
            // 
            // houseCard1Picture
            // 
            this.houseCard1Picture.Location = new System.Drawing.Point(34, 36);
            this.houseCard1Picture.Name = "houseCard1Picture";
            this.houseCard1Picture.Size = new System.Drawing.Size(72, 96);
            this.houseCard1Picture.TabIndex = 5;
            this.houseCard1Picture.TabStop = false;
            this.houseCard1Picture.Visible = false;
            // 
            // houseCard2Picture
            // 
            this.houseCard2Picture.Location = new System.Drawing.Point(134, 36);
            this.houseCard2Picture.Name = "houseCard2Picture";
            this.houseCard2Picture.Size = new System.Drawing.Size(72, 96);
            this.houseCard2Picture.TabIndex = 6;
            this.houseCard2Picture.TabStop = false;
            this.houseCard2Picture.Visible = false;
            // 
            // stayButton
            // 
            this.stayButton.BackColor = System.Drawing.SystemColors.Control;
            this.stayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stayButton.Location = new System.Drawing.Point(149, 333);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(101, 44);
            this.stayButton.TabIndex = 7;
            this.stayButton.Text = "STAY";
            this.stayButton.UseVisualStyleBackColor = false;
            this.stayButton.Visible = false;
            this.stayButton.Click += new System.EventHandler(this.stayButton_Click);
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(321, 333);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(85, 20);
            this.betTextBox.TabIndex = 8;
            // 
            // bankTextBox
            // 
            this.bankTextBox.Location = new System.Drawing.Point(321, 365);
            this.bankTextBox.Name = "bankTextBox";
            this.bankTextBox.ReadOnly = true;
            this.bankTextBox.Size = new System.Drawing.Size(85, 20);
            this.bankTextBox.TabIndex = 9;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(280, 336);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(30, 13);
            this.betLabel.TabIndex = 10;
            this.betLabel.Text = "Bet:";
            // 
            // bankLabel
            // 
            this.bankLabel.AutoSize = true;
            this.bankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankLabel.Location = new System.Drawing.Point(280, 368);
            this.bankLabel.Name = "bankLabel";
            this.bankLabel.Size = new System.Drawing.Size(40, 13);
            this.bankLabel.TabIndex = 11;
            this.bankLabel.Text = "Bank:";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(436, 239);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(128, 146);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "(result)";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerCard3Picture
            // 
            this.playerCard3Picture.BackColor = System.Drawing.Color.Transparent;
            this.playerCard3Picture.Location = new System.Drawing.Point(234, 183);
            this.playerCard3Picture.Name = "playerCard3Picture";
            this.playerCard3Picture.Size = new System.Drawing.Size(72, 96);
            this.playerCard3Picture.TabIndex = 13;
            this.playerCard3Picture.TabStop = false;
            this.playerCard3Picture.Visible = false;
            // 
            // playerCard4Picture
            // 
            this.playerCard4Picture.BackColor = System.Drawing.Color.Transparent;
            this.playerCard4Picture.Location = new System.Drawing.Point(334, 183);
            this.playerCard4Picture.Name = "playerCard4Picture";
            this.playerCard4Picture.Size = new System.Drawing.Size(72, 96);
            this.playerCard4Picture.TabIndex = 14;
            this.playerCard4Picture.TabStop = false;
            this.playerCard4Picture.Visible = false;
            // 
            // playerCard5Picture
            // 
            this.playerCard5Picture.BackColor = System.Drawing.Color.Transparent;
            this.playerCard5Picture.Location = new System.Drawing.Point(49, 203);
            this.playerCard5Picture.Name = "playerCard5Picture";
            this.playerCard5Picture.Size = new System.Drawing.Size(72, 96);
            this.playerCard5Picture.TabIndex = 15;
            this.playerCard5Picture.TabStop = false;
            this.playerCard5Picture.Visible = false;
            // 
            // houseCard3Picture
            // 
            this.houseCard3Picture.Location = new System.Drawing.Point(234, 36);
            this.houseCard3Picture.Name = "houseCard3Picture";
            this.houseCard3Picture.Size = new System.Drawing.Size(72, 96);
            this.houseCard3Picture.TabIndex = 16;
            this.houseCard3Picture.TabStop = false;
            this.houseCard3Picture.Visible = false;
            // 
            // houseCard4Picture
            // 
            this.houseCard4Picture.Location = new System.Drawing.Point(334, 37);
            this.houseCard4Picture.Name = "houseCard4Picture";
            this.houseCard4Picture.Size = new System.Drawing.Size(72, 96);
            this.houseCard4Picture.TabIndex = 17;
            this.houseCard4Picture.TabStop = false;
            this.houseCard4Picture.Visible = false;
            // 
            // houseCard5Picture
            // 
            this.houseCard5Picture.Location = new System.Drawing.Point(49, 56);
            this.houseCard5Picture.Name = "houseCard5Picture";
            this.houseCard5Picture.Size = new System.Drawing.Size(72, 96);
            this.houseCard5Picture.TabIndex = 18;
            this.houseCard5Picture.TabStop = false;
            this.houseCard5Picture.Visible = false;
            // 
            // playerCard6Picture
            // 
            this.playerCard6Picture.BackColor = System.Drawing.Color.Transparent;
            this.playerCard6Picture.Location = new System.Drawing.Point(149, 203);
            this.playerCard6Picture.Name = "playerCard6Picture";
            this.playerCard6Picture.Size = new System.Drawing.Size(72, 96);
            this.playerCard6Picture.TabIndex = 19;
            this.playerCard6Picture.TabStop = false;
            this.playerCard6Picture.Visible = false;
            // 
            // houseCard6Picture
            // 
            this.houseCard6Picture.Location = new System.Drawing.Point(149, 56);
            this.houseCard6Picture.Name = "houseCard6Picture";
            this.houseCard6Picture.Size = new System.Drawing.Size(72, 96);
            this.houseCard6Picture.TabIndex = 20;
            this.houseCard6Picture.TabStop = false;
            this.houseCard6Picture.Visible = false;
            // 
            // playerCard7Picture
            // 
            this.playerCard7Picture.BackColor = System.Drawing.Color.Transparent;
            this.playerCard7Picture.Location = new System.Drawing.Point(249, 203);
            this.playerCard7Picture.Name = "playerCard7Picture";
            this.playerCard7Picture.Size = new System.Drawing.Size(72, 96);
            this.playerCard7Picture.TabIndex = 22;
            this.playerCard7Picture.TabStop = false;
            this.playerCard7Picture.Visible = false;
            // 
            // houseCard7Picture
            // 
            this.houseCard7Picture.Location = new System.Drawing.Point(249, 56);
            this.houseCard7Picture.Name = "houseCard7Picture";
            this.houseCard7Picture.Size = new System.Drawing.Size(72, 96);
            this.houseCard7Picture.TabIndex = 23;
            this.houseCard7Picture.TabStop = false;
            this.houseCard7Picture.Visible = false;
            // 
            // playerCard8Picture
            // 
            this.playerCard8Picture.BackColor = System.Drawing.Color.Transparent;
            this.playerCard8Picture.Location = new System.Drawing.Point(349, 203);
            this.playerCard8Picture.Name = "playerCard8Picture";
            this.playerCard8Picture.Size = new System.Drawing.Size(72, 96);
            this.playerCard8Picture.TabIndex = 24;
            this.playerCard8Picture.TabStop = false;
            this.playerCard8Picture.Visible = false;
            // 
            // houseCard8Picture
            // 
            this.houseCard8Picture.Location = new System.Drawing.Point(349, 56);
            this.houseCard8Picture.Name = "houseCard8Picture";
            this.houseCard8Picture.Size = new System.Drawing.Size(72, 96);
            this.houseCard8Picture.TabIndex = 25;
            this.houseCard8Picture.TabStop = false;
            this.houseCard8Picture.Visible = false;
            // 
            // enemyBankLabel
            // 
            this.enemyBankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyBankLabel.Location = new System.Drawing.Point(427, 34);
            this.enemyBankLabel.Name = "enemyBankLabel";
            this.enemyBankLabel.Size = new System.Drawing.Size(46, 31);
            this.enemyBankLabel.TabIndex = 27;
            this.enemyBankLabel.Text = "Enemy\r\nBank:";
            // 
            // enemyBankTextBox
            // 
            this.houseBankTextBox.Location = new System.Drawing.Point(479, 45);
            this.houseBankTextBox.Name = "enemyBankTextBox";
            this.houseBankTextBox.ReadOnly = true;
            this.houseBankTextBox.Size = new System.Drawing.Size(85, 20);
            this.houseBankTextBox.TabIndex = 26;
            // 
            // enemyOutputLabel
            // 
            this.houseOutputLabel.BackColor = System.Drawing.Color.Firebrick;
            this.houseOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.houseOutputLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseOutputLabel.Location = new System.Drawing.Point(78, 90);
            this.houseOutputLabel.Name = "enemyOutputLabel";
            this.houseOutputLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.houseOutputLabel.Size = new System.Drawing.Size(431, 168);
            this.houseOutputLabel.TabIndex = 28;
            this.houseOutputLabel.Text = "(output)";
            this.houseOutputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.houseOutputLabel.Visible = false;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.IndianRed;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(234, 215);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(109, 32);
            this.okButton.TabIndex = 29;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardStylesTS,
            this.toolStripDropDownButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(576, 25);
            this.toolStrip.TabIndex = 30;
            this.toolStrip.Text = "Toolbar";
            this.toolStrip.Visible = false;
            // 
            // cardStylesTS
            // 
            this.cardStylesTS.AutoToolTip = false;
            this.cardStylesTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cardStylesTS.Image = ((System.Drawing.Image)(resources.GetObject("cardStylesTS.Image")));
            this.cardStylesTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cardStylesTS.Name = "cardStylesTS";
            this.cardStylesTS.Size = new System.Drawing.Size(69, 22);
            this.cardStylesTS.Text = "Card Styles";
            this.cardStylesTS.Click += new System.EventHandler(this.cardStylesTS_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level1,
            this.level2,
            this.level3,
            this.level4,
            this.level5});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton1.Text = "Level Select";
            this.toolStripDropDownButton1.ToolTipText = "Skill and money opponent play with.\r\nThese are normally progressed by winning.";
            // 
            // toolStripEnabler
            // 
            this.toolStripEnabler.Enabled = true;
            this.toolStripEnabler.Interval = 10;
            this.toolStripEnabler.Tick += new System.EventHandler(this.toolStripEnabler_Tick);
            // 
            // deckTopPicture
            // 
            this.deckTopPicture.Image = ((System.Drawing.Image)(resources.GetObject("deckTopPicture.Image")));
            this.deckTopPicture.Location = new System.Drawing.Point(466, 118);
            this.deckTopPicture.Name = "deckTopPicture";
            this.deckTopPicture.Size = new System.Drawing.Size(72, 96);
            this.deckTopPicture.TabIndex = 31;
            this.deckTopPicture.TabStop = false;
            // 
            // level1
            // 
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(152, 22);
            this.level1.Text = "Level 1";
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level2
            // 
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(152, 22);
            this.level2.Text = "Level 2";
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level3
            // 
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(152, 22);
            this.level3.Text = "Level 3";
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // level4
            // 
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(152, 22);
            this.level4.Text = "Level 4";
            this.level4.Click += new System.EventHandler(this.level4_Click);
            // 
            // level5
            // 
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(152, 22);
            this.level5.Text = "Level 5";
            this.level5.Click += new System.EventHandler(this.level5_Click);
            // 
            // BlackjackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(576, 410);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.houseOutputLabel);
            this.Controls.Add(this.enemyBankLabel);
            this.Controls.Add(this.houseBankTextBox);
            this.Controls.Add(this.houseCard8Picture);
            this.Controls.Add(this.playerCard8Picture);
            this.Controls.Add(this.houseCard7Picture);
            this.Controls.Add(this.playerCard7Picture);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.houseCard6Picture);
            this.Controls.Add(this.playerCard6Picture);
            this.Controls.Add(this.houseCard5Picture);
            this.Controls.Add(this.houseCard4Picture);
            this.Controls.Add(this.houseCard3Picture);
            this.Controls.Add(this.playerCard5Picture);
            this.Controls.Add(this.playerCard4Picture);
            this.Controls.Add(this.playerCard3Picture);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.bankLabel);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.bankTextBox);
            this.Controls.Add(this.betTextBox);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.houseCard2Picture);
            this.Controls.Add(this.houseCard1Picture);
            this.Controls.Add(this.playerCard2Picture);
            this.Controls.Add(this.playerCard1Picture);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.deckTopPicture);
            this.Controls.Add(this.deckPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlackjackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack Challenger";
            ((System.ComponentModel.ISupportInitialize)(this.deckPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard3Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard4Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard5Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard6Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard6Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard7Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard7Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard8Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseCard8Picture)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckTopPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox deckPicture;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.PictureBox playerCard1Picture;
        private System.Windows.Forms.PictureBox playerCard2Picture;
        private System.Windows.Forms.PictureBox houseCard1Picture;
        private System.Windows.Forms.PictureBox houseCard2Picture;
        private System.Windows.Forms.Button stayButton;
        private System.Windows.Forms.TextBox betTextBox;
        private System.Windows.Forms.TextBox bankTextBox;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label bankLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox playerCard3Picture;
        private System.Windows.Forms.PictureBox playerCard4Picture;
        private System.Windows.Forms.PictureBox playerCard5Picture;
        private System.Windows.Forms.PictureBox houseCard3Picture;
        private System.Windows.Forms.PictureBox houseCard4Picture;
        private System.Windows.Forms.PictureBox houseCard5Picture;
        private System.Windows.Forms.PictureBox playerCard6Picture;
        private System.Windows.Forms.PictureBox houseCard6Picture;
        private System.Windows.Forms.PictureBox playerCard7Picture;
        private System.Windows.Forms.PictureBox houseCard7Picture;
        private System.Windows.Forms.PictureBox playerCard8Picture;
        private System.Windows.Forms.PictureBox houseCard8Picture;
        private System.Windows.Forms.Label enemyBankLabel;
        private System.Windows.Forms.TextBox houseBankTextBox;
        private System.Windows.Forms.Label houseOutputLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Timer toolStripEnabler;
        private System.Windows.Forms.ToolStripButton cardStylesTS;
        private System.Windows.Forms.PictureBox deckTopPicture;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem level1;
        private System.Windows.Forms.ToolStripMenuItem level2;
        private System.Windows.Forms.ToolStripMenuItem level3;
        private System.Windows.Forms.ToolStripMenuItem level4;
        private System.Windows.Forms.ToolStripMenuItem level5;
    }
}

