using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace tmntMMSaveEditor
{
    // vars
    public struct StoryProgression
    {
        public ushort leoOfst;
        public ushort donOfst;
        public ushort mikeyOfst;
        public ushort raphOfst;
        public ushort aprilOfst;
        public byte aprilCmplteOfst;
        public ushort caseyOfst;
        public ushort footOfst;
        public ushort hunOfst;
        public ushort shredrOfst;
        public ushort splntrOfst;
    }

    public enum BasicAdvCharacters
    {
        leo,
        don,
        mikey,
        raph
    }

    public enum AdvCharacters
    {
        april = 0x27,
        casey,
        foot,
        hun,
        shredder = 0x2c,
        splinter
    }

    public enum MeleeCharacters
    {
        gldn_shredr = 0x10,
        monster,
        lrg_foot,
        oroku_saki,
        april_suit2,
        casey_suit2,
        tech_foot,
        april_suit3,
        casey_suit3,
        hun_suit2
    }

    public enum UnlockableStages
    {
        turt_lair = 0x1c5,
        swr_canal,
        subway,
        autumn,
        wtrfall,
        jnkyard,
        sewer,
        lab,
        pond,
        swr_falls,
        shrdr_plc_ext,
        shrdr_plc_int,
        lava,
        stone,
        frezer,
        april_apt,
        bamboo
    }

    public partial class Form1 : Form
    {
        private readonly OpenFileDialog _openSaveFile = new OpenFileDialog();
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        // drag winForm by image
        private bool _dragging;
        //public bool saveWritten = false;

        public int money;

        public string saveFilePath;
        //public bool saveLoaded;
        public ushort storyComplete = 0xFFFE;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // limit money to 6 digits, just in case whatever
            tboxMoney.MaxLength = 6;
        }

        // check every KeyPress, allowing only numbers
        private void tboxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnOpenReadSave_Click(object sender, EventArgs e)
        {
            // uncheck all boxes before every load
            for (var i = 0; i < cListBox_stages.Items.Count; i++)
                cListBox_stages.SetItemChecked(i, false);
            for (var i = 0; i < cListBox_meleeChars.Items.Count; i++)
                cListBox_meleeChars.SetItemChecked(i, false);
            cbox_unlockLibrary.Checked = false;
            cbox_unlockStoryLeo.Checked = false;
            cbox_unlockStoryDon.Checked = false;
            cbox_unlockStoryMikey.Checked = false;
            cbox_unlockStoryRaph.Checked = false;
            cbox_unlockStoryApril.Checked = false;
            cbox_unlockStoryCasey.Checked = false;
            cbox_unlockStoryFoot.Checked = false;
            cbox_unlockStoryHun.Checked = false;
            cbox_unlockStoryShredder.Checked = false;
            cbox_unlockStorySplinter.Checked = false;
            cbox_unlockApril.Checked = false;
            cbox_unlockCasey.Checked = false;
            cbox_unlockFoot.Checked = false;
            cbox_unlockHun.Checked = false;
            cbox_unlockShredder.Checked = false;
            cbox_unlockSplinter.Checked = false;

            _openSaveFile.Filter = "tmnt.sv (*.sv)|*sv";
            _openSaveFile.Title = "Select TMNT save file...";

            if (_openSaveFile.ShowDialog() != DialogResult.OK) return;

            saveFilePath = _openSaveFile.FileName;
            var backupPath = saveFilePath.Replace(".sv", ".bak");

            // checks is file length is exactly 628 bytes, if not, it's not a valid MM save
            var saveSize = new FileInfo(saveFilePath).Length;
            if (saveSize != 0x274)
            {
                MessageBox.Show("Not a valid TMNT MM save!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //saveLoaded = false;
                return;
            }

            //saveLoaded = true;
            btnSave.Enabled = true;

            if (File.Exists(saveFilePath))
            {
                if (File.Exists(backupPath))
                    File.Delete(backupPath);

                File.Copy(saveFilePath, backupPath);
            }

            // enable gui controls on successful load
            cbox_unlockLibrary.Enabled = true;
            tboxMoney.Enabled = true;
            cListBox_meleeChars.Enabled = true;
            cListBox_stages.Enabled = true;
            cbox_unlockLibrary.Enabled = true;
            cbox_unlockStoryLeo.Enabled = true;
            cbox_unlockStoryDon.Enabled = true;
            cbox_unlockStoryMikey.Enabled = true;
            cbox_unlockStoryRaph.Enabled = true;
            cbox_unlockStoryApril.Enabled = true;
            cbox_unlockStoryCasey.Enabled = true;
            cbox_unlockStoryFoot.Enabled = true;
            cbox_unlockStoryHun.Enabled = true;
            cbox_unlockStoryShredder.Enabled = true;
            cbox_unlockStorySplinter.Enabled = true;
            cbox_unlockApril.Enabled = true;
            cbox_unlockCasey.Enabled = true;
            cbox_unlockFoot.Enabled = true;
            cbox_unlockHun.Enabled = true;
            cbox_unlockShredder.Enabled = true;
            cbox_unlockSplinter.Enabled = true;

            using (var saveData = new FileStream(saveFilePath, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(saveData))
            {
                //----------
                //   READ   
                //----------

                // read money/tokens
                saveData.Seek(0xc4, SeekOrigin.Begin);
                money = binaryReader.ReadUInt16();
                tboxMoney.Text = money.ToString();

                // read stages, 0 = unlocked
                var i = 0;
                foreach (int stage in Enum.GetValues(typeof(UnlockableStages)))
                {
                    saveData.Seek(stage, SeekOrigin.Begin);
                    if (binaryReader.ReadByte() == 0)
                        cListBox_stages.SetItemChecked(i, true);
                    i++;
                }

                // read melee characters, 1 = unlocked
                i = 0;
                foreach (int character in Enum.GetValues(typeof(MeleeCharacters)))
                {
                    saveData.Seek(character, SeekOrigin.Begin);
                    if (binaryReader.ReadByte() == 1)
                        cListBox_meleeChars.SetItemChecked(i, true);
                    i++;
                }

                // read adventure characters, 1 = unlocked
                foreach (var character in Enum.GetNames(typeof(AdvCharacters)))
                    switch (character)
                    {
                        case "april":
                            saveData.Seek((long)AdvCharacters.april, SeekOrigin.Begin);
                            if (binaryReader.ReadByte() == 1)
                                cbox_unlockApril.Checked = true;
                            break;
                        case "casey":
                            saveData.Seek((long)AdvCharacters.casey, SeekOrigin.Begin);
                            if (binaryReader.ReadByte() == 1)
                                cbox_unlockCasey.Checked = true;
                            break;
                        case "foot":
                            saveData.Seek((long)AdvCharacters.foot, SeekOrigin.Begin);
                            if (binaryReader.ReadByte() == 1)
                                cbox_unlockFoot.Checked = true;
                            break;
                        case "hun":
                            saveData.Seek((long)AdvCharacters.hun, SeekOrigin.Begin);
                            if (binaryReader.ReadByte() == 1)
                                cbox_unlockHun.Checked = true;
                            break;
                        case "shredder":
                            saveData.Seek((long)AdvCharacters.shredder, SeekOrigin.Begin);
                            if (binaryReader.ReadByte() == 1)
                                cbox_unlockShredder.Checked = true;
                            break;
                        case "splinter":
                            saveData.Seek((long)AdvCharacters.splinter, SeekOrigin.Begin);
                            if (binaryReader.ReadByte() == 1)
                                cbox_unlockSplinter.Checked = true;
                            break;
                    }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StoryProgression storyProg;
            // set offsets
            storyProg.leoOfst = 0xcc;
            storyProg.donOfst = 0xd4;
            storyProg.mikeyOfst = 0xdc;
            storyProg.raphOfst = 0xe4;
            storyProg.aprilOfst = 0xec;
            storyProg.aprilCmplteOfst = 0xef;
            storyProg.caseyOfst = 0xf4;
            storyProg.footOfst = 0xfc;
            storyProg.hunOfst = 0x104;
            storyProg.shredrOfst = 0x114;
            storyProg.splntrOfst = 0x11c;

            using (var loadedSaveData = new FileStream(saveFilePath, FileMode.Open, FileAccess.Write))
            using (var binaryWriter = new BinaryWriter(loadedSaveData))
            {
                //-----------
                //   WRITE   
                //-----------

                // save money/tokens
                if (tboxMoney.Text != string.Empty || tboxMoney.Text == money.ToString())
                {
                    loadedSaveData.Seek(0xc4, SeekOrigin.Begin);
                    binaryWriter.Write(Convert.ToUInt16(tboxMoney.Text));
                    //save_written = true;
                }

                // unlock whole library
                if (cbox_unlockLibrary.Checked)
                {
                    var libOfst = 0x84; // starting offset of library array
                    loadedSaveData.Seek(libOfst, SeekOrigin.Begin);
                    while (libOfst <= 0xaa)
                    {
                        binaryWriter.Write((byte)0xff);
                        libOfst++;
                    }
                }

                // save checked unlockable stages, 0 = unlocked
                var i = 0;
                foreach (int stage in Enum.GetValues(typeof(UnlockableStages)))
                {
                    loadedSaveData.Seek(stage, SeekOrigin.Begin);
                    if (cListBox_stages.GetItemChecked(i))
                        binaryWriter.Write((byte)0);
                    else
                        binaryWriter.Write((byte)1);
                    i++;
                }

                // save checked melee characters, 1 = unlocked
                i = 0;
                foreach (int character in Enum.GetValues(typeof(MeleeCharacters)))
                {
                    loadedSaveData.Seek(character, SeekOrigin.Begin);
                    if (cListBox_meleeChars.GetItemChecked(i))
                        binaryWriter.Write((byte)1);
                    else
                        binaryWriter.Write((byte)0);
                    i++;
                }

                // save basic adventure characters story completion
                foreach (var character in Enum.GetNames(typeof(BasicAdvCharacters)))
                    switch (character)
                    {
                        case "leo":
                            if (cbox_unlockStoryLeo.Checked)
                            {
                                loadedSaveData.Seek(storyProg.leoOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                binaryWriter.Write((byte)0x81);
                            }
                            break;

                        case "don":
                            if (cbox_unlockStoryDon.Checked)
                            {
                                loadedSaveData.Seek(storyProg.donOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                binaryWriter.Write((byte)0xf1);
                            }
                            break;

                        case "mikey":
                            if (cbox_unlockStoryMikey.Checked)
                            {
                                loadedSaveData.Seek(storyProg.mikeyOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                binaryWriter.Write((byte)0x83);
                            }
                            break;

                        case "raph":
                            if (cbox_unlockStoryRaph.Checked)
                            {
                                loadedSaveData.Seek(storyProg.raphOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                binaryWriter.Write((byte)0x70);
                            }
                            break;
                    }

                // save unlockable adventure characters, 1 = unlocked + story completion
                foreach (var character in Enum.GetNames(typeof(AdvCharacters)))
                    switch (character)
                    {
                        case "april":
                            loadedSaveData.Seek((long)AdvCharacters.april, SeekOrigin.Begin);
                            if (cbox_unlockApril.Checked)
                                binaryWriter.Write((byte)1);
                            else
                                binaryWriter.Write((byte)0);

                            if (cbox_unlockStoryApril.Checked)
                            {
                                loadedSaveData.Seek(storyProg.aprilOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                loadedSaveData.Seek(storyProg.aprilCmplteOfst, SeekOrigin.Begin);
                                binaryWriter.Write((byte)0x9c);
                            }
                            break;

                        case "casey":
                            loadedSaveData.Seek((long)AdvCharacters.casey, SeekOrigin.Begin);
                            if (cbox_unlockCasey.Checked)
                                binaryWriter.Write((byte)1);
                            else
                                binaryWriter.Write((byte)0);

                            if (cbox_unlockStoryCasey.Checked)
                            {
                                loadedSaveData.Seek(storyProg.caseyOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                binaryWriter.Write((byte)0x70);
                            }
                            break;

                        case "foot":
                            loadedSaveData.Seek((long)AdvCharacters.foot, SeekOrigin.Begin);
                            if (cbox_unlockFoot.Checked)
                                binaryWriter.Write((byte)1);
                            else
                                binaryWriter.Write((byte)0);

                            if (cbox_unlockStoryFoot.Checked)
                            {
                                loadedSaveData.Seek(storyProg.footOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                binaryWriter.Write((byte)0x30);
                            }
                            break;

                        case "hun":
                            loadedSaveData.Seek((long)AdvCharacters.hun, SeekOrigin.Begin);
                            if (cbox_unlockHun.Checked)
                                binaryWriter.Write((byte)1);
                            else
                                binaryWriter.Write((byte)0);

                            if (cbox_unlockStoryHun.Checked)
                            {
                                loadedSaveData.Seek(storyProg.hunOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                            }
                            break;

                        case "shredder":
                            loadedSaveData.Seek((long)AdvCharacters.shredder, SeekOrigin.Begin);
                            if (cbox_unlockShredder.Checked)
                                binaryWriter.Write((byte)1);
                            else
                                binaryWriter.Write((byte)0);

                            if (cbox_unlockStoryShredder.Checked)
                            {
                                loadedSaveData.Seek(storyProg.shredrOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                binaryWriter.Write((byte)0x87);
                            }
                            break;

                        case "splinter":
                            loadedSaveData.Seek((long)AdvCharacters.splinter, SeekOrigin.Begin);
                            if (cbox_unlockShredder.Checked)
                                binaryWriter.Write((byte)1);
                            else
                                binaryWriter.Write((byte)0);

                            if (cbox_unlockStorySplinter.Checked)
                            {
                                loadedSaveData.Seek(storyProg.splntrOfst, SeekOrigin.Begin);
                                binaryWriter.Write(storyComplete);
                                binaryWriter.Write((byte)0x83);
                            }
                            break;
                    }

                MessageBox.Show("Save successfully written!", "Success:", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Other stuff
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = Location;
            pictureBox1.Cursor = Cursors.SizeAll;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;

            var pt = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
            Location = Point.Add(_dragFormPoint, new Size(pt));
        }
    }
}