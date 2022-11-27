namespace tmntMMSaveEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cListBox_stages = new System.Windows.Forms.CheckedListBox();
            this.btnOpenReadSave = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tboxMoney = new System.Windows.Forms.TextBox();
            this.gbox_adventureStory = new System.Windows.Forms.GroupBox();
            this.cbox_unlockStorySplinter = new System.Windows.Forms.CheckBox();
            this.cbox_unlockStoryShredder = new System.Windows.Forms.CheckBox();
            this.cbox_unlockSplinter = new System.Windows.Forms.CheckBox();
            this.lbl_splinter = new System.Windows.Forms.Label();
            this.lbl_leo = new System.Windows.Forms.Label();
            this.cbox_unlockStoryRaph = new System.Windows.Forms.CheckBox();
            this.cbox_unlockStoryHun = new System.Windows.Forms.CheckBox();
            this.lbl_shredder = new System.Windows.Forms.Label();
            this.cbox_unlockShredder = new System.Windows.Forms.CheckBox();
            this.cbox_unlockStoryApril = new System.Windows.Forms.CheckBox();
            this.cbox_unlockStoryFoot = new System.Windows.Forms.CheckBox();
            this.cbox_unlockApril = new System.Windows.Forms.CheckBox();
            this.lbl_hun = new System.Windows.Forms.Label();
            this.cbox_unlockStoryCasey = new System.Windows.Forms.CheckBox();
            this.cbox_unlockHun = new System.Windows.Forms.CheckBox();
            this.lbl_raph = new System.Windows.Forms.Label();
            this.cbox_unlockStoryDon = new System.Windows.Forms.CheckBox();
            this.lbl_foot = new System.Windows.Forms.Label();
            this.cbox_unlockStoryMikey = new System.Windows.Forms.CheckBox();
            this.lbl_mikey = new System.Windows.Forms.Label();
            this.cbox_unlockFoot = new System.Windows.Forms.CheckBox();
            this.lbl_don = new System.Windows.Forms.Label();
            this.lbl_casey = new System.Windows.Forms.Label();
            this.cbox_unlockStoryLeo = new System.Windows.Forms.CheckBox();
            this.lbl_april = new System.Windows.Forms.Label();
            this.cbox_unlockCasey = new System.Windows.Forms.CheckBox();
            this.gbox_meleeMatch = new System.Windows.Forms.GroupBox();
            this.cListBox_meleeChars = new System.Windows.Forms.CheckedListBox();
            this.gbox_stages = new System.Windows.Forms.GroupBox();
            this.gbox_library = new System.Windows.Forms.GroupBox();
            this.cbox_unlockLibrary = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbox_money = new System.Windows.Forms.GroupBox();
            this.gbox_adventureStory.SuspendLayout();
            this.gbox_meleeMatch.SuspendLayout();
            this.gbox_stages.SuspendLayout();
            this.gbox_library.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbox_money.SuspendLayout();
            this.SuspendLayout();
            // 
            // cListBox_stages
            // 
            this.cListBox_stages.CheckOnClick = true;
            this.cListBox_stages.Enabled = false;
            this.cListBox_stages.FormattingEnabled = true;
            this.cListBox_stages.Items.AddRange(new object[] {
            "#1 - Turtle\'s Lair",
            "#2 - Sewer-Canal",
            "#3 - Subway",
            "#4 - Autumn",
            "#5 - Waterfall",
            "#6 - Junkyard",
            "#7 - Sewer",
            "#8 - Lab",
            "#9 - Pond",
            "#10 - Sewer Falls",
            "#11 - Shredder\'s Palace Exterior",
            "#12 - Shredder\'s Palace Interior",
            "#13 - Lava",
            "#14 - Stone",
            "#15 - Freezer",
            "#16 - April\'s Apartment",
            "#17 - Bamboo"});
            this.cListBox_stages.Location = new System.Drawing.Point(7, 19);
            this.cListBox_stages.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cListBox_stages.Name = "cListBox_stages";
            this.cListBox_stages.Size = new System.Drawing.Size(180, 259);
            this.cListBox_stages.TabIndex = 0;
            // 
            // btnOpenReadSave
            // 
            this.btnOpenReadSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenReadSave.Location = new System.Drawing.Point(186, 273);
            this.btnOpenReadSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpenReadSave.Name = "btnOpenReadSave";
            this.btnOpenReadSave.Size = new System.Drawing.Size(58, 33);
            this.btnOpenReadSave.TabIndex = 1;
            this.btnOpenReadSave.Text = "Load";
            this.btnOpenReadSave.UseVisualStyleBackColor = true;
            this.btnOpenReadSave.Click += new System.EventHandler(this.btnOpenReadSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(186, 312);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tboxMoney
            // 
            this.tboxMoney.Enabled = false;
            this.tboxMoney.Font = new System.Drawing.Font("Input", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMoney.Location = new System.Drawing.Point(7, 19);
            this.tboxMoney.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tboxMoney.Name = "tboxMoney";
            this.tboxMoney.Size = new System.Drawing.Size(75, 23);
            this.tboxMoney.TabIndex = 3;
            this.tboxMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxMoney_KeyPress);
            // 
            // gbox_adventureStory
            // 
            this.gbox_adventureStory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStorySplinter);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryShredder);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockSplinter);
            this.gbox_adventureStory.Controls.Add(this.lbl_splinter);
            this.gbox_adventureStory.Controls.Add(this.lbl_leo);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryRaph);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryHun);
            this.gbox_adventureStory.Controls.Add(this.lbl_shredder);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockShredder);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryApril);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryFoot);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockApril);
            this.gbox_adventureStory.Controls.Add(this.lbl_hun);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryCasey);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockHun);
            this.gbox_adventureStory.Controls.Add(this.lbl_raph);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryDon);
            this.gbox_adventureStory.Controls.Add(this.lbl_foot);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryMikey);
            this.gbox_adventureStory.Controls.Add(this.lbl_mikey);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockFoot);
            this.gbox_adventureStory.Controls.Add(this.lbl_don);
            this.gbox_adventureStory.Controls.Add(this.lbl_casey);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockStoryLeo);
            this.gbox_adventureStory.Controls.Add(this.lbl_april);
            this.gbox_adventureStory.Controls.Add(this.cbox_unlockCasey);
            this.gbox_adventureStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_adventureStory.Location = new System.Drawing.Point(13, 12);
            this.gbox_adventureStory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbox_adventureStory.Name = "gbox_adventureStory";
            this.gbox_adventureStory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbox_adventureStory.Size = new System.Drawing.Size(149, 524);
            this.gbox_adventureStory.TabIndex = 8;
            this.gbox_adventureStory.TabStop = false;
            this.gbox_adventureStory.Text = "Adventure Story";
            // 
            // cbox_unlockStorySplinter
            // 
            this.cbox_unlockStorySplinter.AutoSize = true;
            this.cbox_unlockStorySplinter.Enabled = false;
            this.cbox_unlockStorySplinter.Location = new System.Drawing.Point(10, 498);
            this.cbox_unlockStorySplinter.Name = "cbox_unlockStorySplinter";
            this.cbox_unlockStorySplinter.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStorySplinter.TabIndex = 8;
            this.cbox_unlockStorySplinter.Text = "Unlock All Story Levels";
            this.cbox_unlockStorySplinter.UseVisualStyleBackColor = true;
            // 
            // cbox_unlockStoryShredder
            // 
            this.cbox_unlockStoryShredder.AutoSize = true;
            this.cbox_unlockStoryShredder.Enabled = false;
            this.cbox_unlockStoryShredder.Location = new System.Drawing.Point(10, 438);
            this.cbox_unlockStoryShredder.Name = "cbox_unlockStoryShredder";
            this.cbox_unlockStoryShredder.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryShredder.TabIndex = 24;
            this.cbox_unlockStoryShredder.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryShredder.UseVisualStyleBackColor = true;
            // 
            // cbox_unlockSplinter
            // 
            this.cbox_unlockSplinter.AutoSize = true;
            this.cbox_unlockSplinter.Enabled = false;
            this.cbox_unlockSplinter.Location = new System.Drawing.Point(10, 481);
            this.cbox_unlockSplinter.Name = "cbox_unlockSplinter";
            this.cbox_unlockSplinter.Size = new System.Drawing.Size(98, 17);
            this.cbox_unlockSplinter.TabIndex = 15;
            this.cbox_unlockSplinter.Text = "Unlock Splinter";
            this.cbox_unlockSplinter.UseVisualStyleBackColor = true;
            // 
            // lbl_splinter
            // 
            this.lbl_splinter.AutoSize = true;
            this.lbl_splinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_splinter.ForeColor = System.Drawing.Color.Peru;
            this.lbl_splinter.Location = new System.Drawing.Point(1, 465);
            this.lbl_splinter.Name = "lbl_splinter";
            this.lbl_splinter.Size = new System.Drawing.Size(50, 13);
            this.lbl_splinter.TabIndex = 20;
            this.lbl_splinter.Text = "Splinter";
            // 
            // lbl_leo
            // 
            this.lbl_leo.AutoSize = true;
            this.lbl_leo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_leo.Location = new System.Drawing.Point(1, 16);
            this.lbl_leo.Name = "lbl_leo";
            this.lbl_leo.Size = new System.Drawing.Size(60, 13);
            this.lbl_leo.TabIndex = 28;
            this.lbl_leo.Text = "Leonardo";
            // 
            // cbox_unlockStoryRaph
            // 
            this.cbox_unlockStoryRaph.AutoSize = true;
            this.cbox_unlockStoryRaph.Enabled = false;
            this.cbox_unlockStoryRaph.Location = new System.Drawing.Point(10, 150);
            this.cbox_unlockStoryRaph.Name = "cbox_unlockStoryRaph";
            this.cbox_unlockStoryRaph.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryRaph.TabIndex = 24;
            this.cbox_unlockStoryRaph.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryRaph.UseVisualStyleBackColor = true;
            // 
            // cbox_unlockStoryHun
            // 
            this.cbox_unlockStoryHun.AutoSize = true;
            this.cbox_unlockStoryHun.Enabled = false;
            this.cbox_unlockStoryHun.Location = new System.Drawing.Point(10, 380);
            this.cbox_unlockStoryHun.Name = "cbox_unlockStoryHun";
            this.cbox_unlockStoryHun.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryHun.TabIndex = 23;
            this.cbox_unlockStoryHun.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryHun.UseVisualStyleBackColor = true;
            // 
            // lbl_shredder
            // 
            this.lbl_shredder.AutoSize = true;
            this.lbl_shredder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shredder.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_shredder.Location = new System.Drawing.Point(1, 405);
            this.lbl_shredder.Name = "lbl_shredder";
            this.lbl_shredder.Size = new System.Drawing.Size(58, 13);
            this.lbl_shredder.TabIndex = 19;
            this.lbl_shredder.Text = "Shredder";
            // 
            // cbox_unlockShredder
            // 
            this.cbox_unlockShredder.AutoSize = true;
            this.cbox_unlockShredder.Enabled = false;
            this.cbox_unlockShredder.Location = new System.Drawing.Point(10, 421);
            this.cbox_unlockShredder.Name = "cbox_unlockShredder";
            this.cbox_unlockShredder.Size = new System.Drawing.Size(106, 17);
            this.cbox_unlockShredder.TabIndex = 14;
            this.cbox_unlockShredder.Text = "Unlock Shredder";
            this.cbox_unlockShredder.UseVisualStyleBackColor = true;
            // 
            // cbox_unlockStoryApril
            // 
            this.cbox_unlockStoryApril.AutoSize = true;
            this.cbox_unlockStoryApril.Enabled = false;
            this.cbox_unlockStoryApril.Location = new System.Drawing.Point(10, 207);
            this.cbox_unlockStoryApril.Name = "cbox_unlockStoryApril";
            this.cbox_unlockStoryApril.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryApril.TabIndex = 7;
            this.cbox_unlockStoryApril.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryApril.UseVisualStyleBackColor = true;
            // 
            // cbox_unlockStoryFoot
            // 
            this.cbox_unlockStoryFoot.AutoSize = true;
            this.cbox_unlockStoryFoot.Enabled = false;
            this.cbox_unlockStoryFoot.Location = new System.Drawing.Point(10, 321);
            this.cbox_unlockStoryFoot.Name = "cbox_unlockStoryFoot";
            this.cbox_unlockStoryFoot.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryFoot.TabIndex = 21;
            this.cbox_unlockStoryFoot.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryFoot.UseVisualStyleBackColor = true;
            // 
            // cbox_unlockApril
            // 
            this.cbox_unlockApril.AutoSize = true;
            this.cbox_unlockApril.Enabled = false;
            this.cbox_unlockApril.Location = new System.Drawing.Point(10, 190);
            this.cbox_unlockApril.Name = "cbox_unlockApril";
            this.cbox_unlockApril.Size = new System.Drawing.Size(118, 17);
            this.cbox_unlockApril.TabIndex = 8;
            this.cbox_unlockApril.Text = "Unlock April O\'Neal";
            this.cbox_unlockApril.UseVisualStyleBackColor = true;
            // 
            // lbl_hun
            // 
            this.lbl_hun.AutoSize = true;
            this.lbl_hun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hun.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_hun.Location = new System.Drawing.Point(1, 347);
            this.lbl_hun.Name = "lbl_hun";
            this.lbl_hun.Size = new System.Drawing.Size(30, 13);
            this.lbl_hun.TabIndex = 18;
            this.lbl_hun.Text = "Hun";
            // 
            // cbox_unlockStoryCasey
            // 
            this.cbox_unlockStoryCasey.AutoSize = true;
            this.cbox_unlockStoryCasey.Enabled = false;
            this.cbox_unlockStoryCasey.Location = new System.Drawing.Point(10, 265);
            this.cbox_unlockStoryCasey.Name = "cbox_unlockStoryCasey";
            this.cbox_unlockStoryCasey.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryCasey.TabIndex = 22;
            this.cbox_unlockStoryCasey.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryCasey.UseVisualStyleBackColor = true;
            // 
            // cbox_unlockHun
            // 
            this.cbox_unlockHun.AutoSize = true;
            this.cbox_unlockHun.Enabled = false;
            this.cbox_unlockHun.Location = new System.Drawing.Point(10, 363);
            this.cbox_unlockHun.Name = "cbox_unlockHun";
            this.cbox_unlockHun.Size = new System.Drawing.Size(83, 17);
            this.cbox_unlockHun.TabIndex = 13;
            this.cbox_unlockHun.Text = "Unlock Hun";
            this.cbox_unlockHun.UseVisualStyleBackColor = true;
            // 
            // lbl_raph
            // 
            this.lbl_raph.AutoSize = true;
            this.lbl_raph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_raph.ForeColor = System.Drawing.Color.Red;
            this.lbl_raph.Location = new System.Drawing.Point(1, 134);
            this.lbl_raph.Name = "lbl_raph";
            this.lbl_raph.Size = new System.Drawing.Size(54, 13);
            this.lbl_raph.TabIndex = 31;
            this.lbl_raph.Text = "Raphael";
            // 
            // cbox_unlockStoryDon
            // 
            this.cbox_unlockStoryDon.AutoSize = true;
            this.cbox_unlockStoryDon.Enabled = false;
            this.cbox_unlockStoryDon.Location = new System.Drawing.Point(10, 72);
            this.cbox_unlockStoryDon.Name = "cbox_unlockStoryDon";
            this.cbox_unlockStoryDon.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryDon.TabIndex = 26;
            this.cbox_unlockStoryDon.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryDon.UseVisualStyleBackColor = true;
            // 
            // lbl_foot
            // 
            this.lbl_foot.AutoSize = true;
            this.lbl_foot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foot.Location = new System.Drawing.Point(1, 288);
            this.lbl_foot.Name = "lbl_foot";
            this.lbl_foot.Size = new System.Drawing.Size(65, 13);
            this.lbl_foot.TabIndex = 17;
            this.lbl_foot.Text = "Foot Ninja";
            // 
            // cbox_unlockStoryMikey
            // 
            this.cbox_unlockStoryMikey.AutoSize = true;
            this.cbox_unlockStoryMikey.Enabled = false;
            this.cbox_unlockStoryMikey.Location = new System.Drawing.Point(10, 111);
            this.cbox_unlockStoryMikey.Name = "cbox_unlockStoryMikey";
            this.cbox_unlockStoryMikey.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryMikey.TabIndex = 25;
            this.cbox_unlockStoryMikey.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryMikey.UseVisualStyleBackColor = true;
            // 
            // lbl_mikey
            // 
            this.lbl_mikey.AutoSize = true;
            this.lbl_mikey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mikey.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_mikey.Location = new System.Drawing.Point(1, 95);
            this.lbl_mikey.Name = "lbl_mikey";
            this.lbl_mikey.Size = new System.Drawing.Size(82, 13);
            this.lbl_mikey.TabIndex = 30;
            this.lbl_mikey.Text = "Michelangelo";
            // 
            // cbox_unlockFoot
            // 
            this.cbox_unlockFoot.AutoSize = true;
            this.cbox_unlockFoot.Enabled = false;
            this.cbox_unlockFoot.Location = new System.Drawing.Point(10, 304);
            this.cbox_unlockFoot.Name = "cbox_unlockFoot";
            this.cbox_unlockFoot.Size = new System.Drawing.Size(111, 17);
            this.cbox_unlockFoot.TabIndex = 12;
            this.cbox_unlockFoot.Text = "Unlock Foot Ninja";
            this.cbox_unlockFoot.UseVisualStyleBackColor = true;
            // 
            // lbl_don
            // 
            this.lbl_don.AutoSize = true;
            this.lbl_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_don.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lbl_don.Location = new System.Drawing.Point(1, 56);
            this.lbl_don.Name = "lbl_don";
            this.lbl_don.Size = new System.Drawing.Size(61, 13);
            this.lbl_don.TabIndex = 29;
            this.lbl_don.Text = "Donatello";
            // 
            // lbl_casey
            // 
            this.lbl_casey.AutoSize = true;
            this.lbl_casey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_casey.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_casey.Location = new System.Drawing.Point(1, 232);
            this.lbl_casey.Name = "lbl_casey";
            this.lbl_casey.Size = new System.Drawing.Size(78, 13);
            this.lbl_casey.TabIndex = 16;
            this.lbl_casey.Text = "Casey Jones";
            // 
            // cbox_unlockStoryLeo
            // 
            this.cbox_unlockStoryLeo.AutoSize = true;
            this.cbox_unlockStoryLeo.Enabled = false;
            this.cbox_unlockStoryLeo.Location = new System.Drawing.Point(10, 32);
            this.cbox_unlockStoryLeo.Name = "cbox_unlockStoryLeo";
            this.cbox_unlockStoryLeo.Size = new System.Drawing.Size(135, 17);
            this.cbox_unlockStoryLeo.TabIndex = 27;
            this.cbox_unlockStoryLeo.Text = "Unlock All Story Levels";
            this.cbox_unlockStoryLeo.UseVisualStyleBackColor = true;
            // 
            // lbl_april
            // 
            this.lbl_april.AutoSize = true;
            this.lbl_april.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_april.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_april.Location = new System.Drawing.Point(1, 174);
            this.lbl_april.Name = "lbl_april";
            this.lbl_april.Size = new System.Drawing.Size(78, 13);
            this.lbl_april.TabIndex = 9;
            this.lbl_april.Text = "April O\' Neal";
            // 
            // cbox_unlockCasey
            // 
            this.cbox_unlockCasey.AutoSize = true;
            this.cbox_unlockCasey.Enabled = false;
            this.cbox_unlockCasey.Location = new System.Drawing.Point(10, 248);
            this.cbox_unlockCasey.Name = "cbox_unlockCasey";
            this.cbox_unlockCasey.Size = new System.Drawing.Size(123, 17);
            this.cbox_unlockCasey.TabIndex = 10;
            this.cbox_unlockCasey.Text = "Unlock Casey Jones";
            this.cbox_unlockCasey.UseVisualStyleBackColor = true;
            // 
            // gbox_meleeMatch
            // 
            this.gbox_meleeMatch.AutoSize = true;
            this.gbox_meleeMatch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbox_meleeMatch.Controls.Add(this.cListBox_meleeChars);
            this.gbox_meleeMatch.Location = new System.Drawing.Point(261, 232);
            this.gbox_meleeMatch.Name = "gbox_meleeMatch";
            this.gbox_meleeMatch.Size = new System.Drawing.Size(142, 192);
            this.gbox_meleeMatch.TabIndex = 9;
            this.gbox_meleeMatch.TabStop = false;
            this.gbox_meleeMatch.Text = "Melee Match";
            // 
            // cListBox_meleeChars
            // 
            this.cListBox_meleeChars.CheckOnClick = true;
            this.cListBox_meleeChars.Enabled = false;
            this.cListBox_meleeChars.FormattingEnabled = true;
            this.cListBox_meleeChars.Items.AddRange(new object[] {
            "Golden Shredder",
            "Monster",
            "Large Foot",
            "Oroku Saki",
            "April O\'Neal (suit #2)",
            "Casey Jones (suit #2)",
            "Tech Foot",
            "April O\'Neal (suit #3)",
            "Casey Jones (suit #3)",
            "Hun (suit #2)"});
            this.cListBox_meleeChars.Location = new System.Drawing.Point(6, 19);
            this.cListBox_meleeChars.Name = "cListBox_meleeChars";
            this.cListBox_meleeChars.Size = new System.Drawing.Size(130, 154);
            this.cListBox_meleeChars.TabIndex = 0;
            // 
            // gbox_stages
            // 
            this.gbox_stages.AutoSize = true;
            this.gbox_stages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbox_stages.Controls.Add(this.cListBox_stages);
            this.gbox_stages.Location = new System.Drawing.Point(409, 232);
            this.gbox_stages.Name = "gbox_stages";
            this.gbox_stages.Size = new System.Drawing.Size(194, 297);
            this.gbox_stages.TabIndex = 10;
            this.gbox_stages.TabStop = false;
            this.gbox_stages.Text = "Unlock Stages";
            // 
            // gbox_library
            // 
            this.gbox_library.AutoSize = true;
            this.gbox_library.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbox_library.Controls.Add(this.cbox_unlockLibrary);
            this.gbox_library.Location = new System.Drawing.Point(272, 429);
            this.gbox_library.Name = "gbox_library";
            this.gbox_library.Size = new System.Drawing.Size(125, 55);
            this.gbox_library.TabIndex = 11;
            this.gbox_library.TabStop = false;
            this.gbox_library.Text = "Library";
            // 
            // cbox_unlockLibrary
            // 
            this.cbox_unlockLibrary.AutoSize = true;
            this.cbox_unlockLibrary.Enabled = false;
            this.cbox_unlockLibrary.Location = new System.Drawing.Point(6, 19);
            this.cbox_unlockLibrary.Name = "cbox_unlockLibrary";
            this.cbox_unlockLibrary.Size = new System.Drawing.Size(113, 17);
            this.cbox_unlockLibrary.TabIndex = 0;
            this.cbox_unlockLibrary.Text = "Unlock Everything";
            this.cbox_unlockLibrary.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(186, 351);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 33);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::tmntMMSaveEditor.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 203);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // gbox_money
            // 
            this.gbox_money.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbox_money.Controls.Add(this.tboxMoney);
            this.gbox_money.Location = new System.Drawing.Point(171, 429);
            this.gbox_money.Name = "gbox_money";
            this.gbox_money.Size = new System.Drawing.Size(95, 55);
            this.gbox_money.TabIndex = 13;
            this.gbox_money.TabStop = false;
            this.gbox_money.Text = "Money/Tokens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 541);
            this.Controls.Add(this.gbox_money);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbox_library);
            this.Controls.Add(this.gbox_stages);
            this.Controls.Add(this.gbox_meleeMatch);
            this.Controls.Add(this.gbox_adventureStory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenReadSave);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TMNT Mutant Melee Save Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_adventureStory.ResumeLayout(false);
            this.gbox_adventureStory.PerformLayout();
            this.gbox_meleeMatch.ResumeLayout(false);
            this.gbox_stages.ResumeLayout(false);
            this.gbox_library.ResumeLayout(false);
            this.gbox_library.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbox_money.ResumeLayout(false);
            this.gbox_money.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cListBox_stages;
        private System.Windows.Forms.Button btnOpenReadSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tboxMoney;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbox_adventureStory;
        private System.Windows.Forms.CheckBox cbox_unlockStoryApril;
        private System.Windows.Forms.GroupBox gbox_meleeMatch;
        private System.Windows.Forms.CheckBox cbox_unlockApril;
        private System.Windows.Forms.CheckedListBox cListBox_meleeChars;
        private System.Windows.Forms.GroupBox gbox_stages;
        private System.Windows.Forms.GroupBox gbox_library;
        private System.Windows.Forms.CheckBox cbox_unlockLibrary;
        private System.Windows.Forms.CheckBox cbox_unlockCasey;
        private System.Windows.Forms.CheckBox cbox_unlockFoot;
        private System.Windows.Forms.CheckBox cbox_unlockHun;
        private System.Windows.Forms.CheckBox cbox_unlockShredder;
        private System.Windows.Forms.CheckBox cbox_unlockSplinter;
        private System.Windows.Forms.Label lbl_april;
        private System.Windows.Forms.Label lbl_casey;
        private System.Windows.Forms.Label lbl_foot;
        private System.Windows.Forms.Label lbl_hun;
        private System.Windows.Forms.Label lbl_shredder;
        private System.Windows.Forms.Label lbl_splinter;
        private System.Windows.Forms.CheckBox cbox_unlockStorySplinter;
        private System.Windows.Forms.CheckBox cbox_unlockStoryShredder;
        private System.Windows.Forms.Label lbl_leo;
        private System.Windows.Forms.CheckBox cbox_unlockStoryRaph;
        private System.Windows.Forms.CheckBox cbox_unlockStoryHun;
        private System.Windows.Forms.CheckBox cbox_unlockStoryFoot;
        private System.Windows.Forms.CheckBox cbox_unlockStoryCasey;
        private System.Windows.Forms.Label lbl_raph;
        private System.Windows.Forms.CheckBox cbox_unlockStoryDon;
        private System.Windows.Forms.CheckBox cbox_unlockStoryMikey;
        private System.Windows.Forms.Label lbl_mikey;
        private System.Windows.Forms.Label lbl_don;
        private System.Windows.Forms.CheckBox cbox_unlockStoryLeo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbox_money;
    }
}

