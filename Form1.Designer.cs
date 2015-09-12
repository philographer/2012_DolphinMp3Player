namespace Teamproject
{
    partial class PinkDolphinPlayer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinkDolphinPlayer));
            this.BtnShowingLyics = new System.Windows.Forms.Button();
            this.BtnSet = new System.Windows.Forms.Button();
            this.RadioBtnNone = new System.Windows.Forms.RadioButton();
            this.RadioBtnOneRefeat = new System.Windows.Forms.RadioButton();
            this.RadioBtnRandomRepeat = new System.Windows.Forms.RadioButton();
            this.BtnWait = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnShowingList = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.listBox_PlayList = new System.Windows.Forms.ListBox();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_PlayTime = new System.Windows.Forms.TextBox();
            this.TrackBarSound = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CkBox_NonSound = new System.Windows.Forms.CheckBox();
            this.TrackBar_State = new System.Windows.Forms.TrackBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재생ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일시정지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음곡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이전곡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblShowingBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_State)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowingLyics
            // 
            this.BtnShowingLyics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.BtnShowingLyics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnShowingLyics.Location = new System.Drawing.Point(13, 293);
            this.BtnShowingLyics.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowingLyics.Name = "BtnShowingLyics";
            this.BtnShowingLyics.Size = new System.Drawing.Size(85, 30);
            this.BtnShowingLyics.TabIndex = 1;
            this.BtnShowingLyics.Text = "가사보기";
            this.BtnShowingLyics.UseVisualStyleBackColor = false;
            this.BtnShowingLyics.Click += new System.EventHandler(this.BtnShowingLyics_Click);
            // 
            // BtnSet
            // 
            this.BtnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.BtnSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSet.Location = new System.Drawing.Point(13, 254);
            this.BtnSet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(85, 30);
            this.BtnSet.TabIndex = 2;
            this.BtnSet.Text = "반복설정";
            this.BtnSet.UseVisualStyleBackColor = false;
            // 
            // RadioBtnNone
            // 
            this.RadioBtnNone.AutoSize = true;
            this.RadioBtnNone.BackColor = System.Drawing.Color.Transparent;
            this.RadioBtnNone.Checked = true;
            this.RadioBtnNone.Font = new System.Drawing.Font("HY강M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RadioBtnNone.Location = new System.Drawing.Point(105, 264);
            this.RadioBtnNone.Name = "RadioBtnNone";
            this.RadioBtnNone.Size = new System.Drawing.Size(67, 21);
            this.RadioBtnNone.TabIndex = 13;
            this.RadioBtnNone.TabStop = true;
            this.RadioBtnNone.Text = "일반";
            this.RadioBtnNone.UseVisualStyleBackColor = false;
            this.RadioBtnNone.CheckedChanged += new System.EventHandler(this.RadioBtnNone_CheckedChanged);
            // 
            // RadioBtnOneRefeat
            // 
            this.RadioBtnOneRefeat.AutoSize = true;
            this.RadioBtnOneRefeat.BackColor = System.Drawing.Color.Transparent;
            this.RadioBtnOneRefeat.Font = new System.Drawing.Font("HY강M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RadioBtnOneRefeat.Location = new System.Drawing.Point(144, 264);
            this.RadioBtnOneRefeat.Name = "RadioBtnOneRefeat";
            this.RadioBtnOneRefeat.Size = new System.Drawing.Size(67, 21);
            this.RadioBtnOneRefeat.TabIndex = 12;
            this.RadioBtnOneRefeat.Text = "한곡";
            this.RadioBtnOneRefeat.UseVisualStyleBackColor = false;
            this.RadioBtnOneRefeat.CheckedChanged += new System.EventHandler(this.RadioBtnOneRefeat_CheckedChanged);
            // 
            // RadioBtnRandomRepeat
            // 
            this.RadioBtnRandomRepeat.AutoSize = true;
            this.RadioBtnRandomRepeat.BackColor = System.Drawing.Color.Transparent;
            this.RadioBtnRandomRepeat.Font = new System.Drawing.Font("HY강M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RadioBtnRandomRepeat.Location = new System.Drawing.Point(184, 264);
            this.RadioBtnRandomRepeat.Name = "RadioBtnRandomRepeat";
            this.RadioBtnRandomRepeat.Size = new System.Drawing.Size(67, 21);
            this.RadioBtnRandomRepeat.TabIndex = 13;
            this.RadioBtnRandomRepeat.Text = "랜덤";
            this.RadioBtnRandomRepeat.UseVisualStyleBackColor = false;
            this.RadioBtnRandomRepeat.CheckedChanged += new System.EventHandler(this.RadioBtnAllRefeat_CheckedChanged);
            // 
            // BtnWait
            // 
            this.BtnWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnWait.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnWait.ForeColor = System.Drawing.Color.Crimson;
            this.BtnWait.Location = new System.Drawing.Point(83, 171);
            this.BtnWait.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWait.Name = "BtnWait";
            this.BtnWait.Size = new System.Drawing.Size(43, 34);
            this.BtnWait.TabIndex = 17;
            this.BtnWait.Text = "∥";
            this.BtnWait.UseVisualStyleBackColor = false;
            this.BtnWait.Click += new System.EventHandler(this.BtnWait_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnStop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStop.ForeColor = System.Drawing.Color.Crimson;
            this.BtnStop.Location = new System.Drawing.Point(126, 170);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(43, 35);
            this.BtnStop.TabIndex = 17;
            this.BtnStop.Text = "■";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnShowingList
            // 
            this.BtnShowingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.BtnShowingList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnShowingList.Location = new System.Drawing.Point(152, 293);
            this.BtnShowingList.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShowingList.Name = "BtnShowingList";
            this.BtnShowingList.Size = new System.Drawing.Size(101, 30);
            this.BtnShowingList.TabIndex = 19;
            this.BtnShowingList.Text = "리스트보기";
            this.BtnShowingList.UseVisualStyleBackColor = false;
            this.BtnShowingList.Click += new System.EventHandler(this.BtnShowingList_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAdd.Location = new System.Drawing.Point(260, 34);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 30);
            this.BtnAdd.TabIndex = 23;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDelete.Location = new System.Drawing.Point(352, 34);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 30);
            this.BtnDelete.TabIndex = 24;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // listBox_PlayList
            // 
            this.listBox_PlayList.AllowDrop = true;
            this.listBox_PlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.listBox_PlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_PlayList.FormattingEnabled = true;
            this.listBox_PlayList.ItemHeight = 24;
            this.listBox_PlayList.Location = new System.Drawing.Point(260, 69);
            this.listBox_PlayList.Name = "listBox_PlayList";
            this.listBox_PlayList.Size = new System.Drawing.Size(256, 170);
            this.listBox_PlayList.TabIndex = 25;
            this.listBox_PlayList.DoubleClick += new System.EventHandler(this.listBox_PlayList_DoubleClick);
            this.listBox_PlayList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_PlayList_KeyDown);
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.BackColor = System.Drawing.Color.HotPink;
            this.trackBarOpacity.Location = new System.Drawing.Point(522, 34);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 10;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarOpacity.Size = new System.Drawing.Size(69, 293);
            this.trackBarOpacity.TabIndex = 26;
            this.trackBarOpacity.Value = 100;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // textBox_Title
            // 
            this.textBox_Title.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox_Title.Location = new System.Drawing.Point(260, 297);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(256, 35);
            this.textBox_Title.TabIndex = 27;
            this.textBox_Title.TextChanged += new System.EventHandler(this.textBox_Title_TextChanged);
            // 
            // textBox_PlayTime
            // 
            this.textBox_PlayTime.BackColor = System.Drawing.Color.HotPink;
            this.textBox_PlayTime.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_PlayTime.Location = new System.Drawing.Point(40, 97);
            this.textBox_PlayTime.Name = "textBox_PlayTime";
            this.textBox_PlayTime.Size = new System.Drawing.Size(100, 35);
            this.textBox_PlayTime.TabIndex = 28;
            this.textBox_PlayTime.TextChanged += new System.EventHandler(this.textBox_PlayTime_TextChanged);
            // 
            // TrackBarSound
            // 
            this.TrackBarSound.BackColor = System.Drawing.Color.HotPink;
            this.TrackBarSound.Location = new System.Drawing.Point(50, 211);
            this.TrackBarSound.Name = "TrackBarSound";
            this.TrackBarSound.Size = new System.Drawing.Size(100, 69);
            this.TrackBarSound.TabIndex = 29;
            this.TrackBarSound.Value = 10;
            this.TrackBarSound.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(257, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "현재 재생중인곡";
            // 
            // CkBox_NonSound
            // 
            this.CkBox_NonSound.AutoSize = true;
            this.CkBox_NonSound.BackColor = System.Drawing.Color.Transparent;
            this.CkBox_NonSound.Location = new System.Drawing.Point(152, 211);
            this.CkBox_NonSound.Name = "CkBox_NonSound";
            this.CkBox_NonSound.Size = new System.Drawing.Size(108, 28);
            this.CkBox_NonSound.TabIndex = 32;
            this.CkBox_NonSound.Text = "음소거";
            this.CkBox_NonSound.UseVisualStyleBackColor = false;
            this.CkBox_NonSound.CheckedChanged += new System.EventHandler(this.CkBox_NonSound_CheckedChanged);
            // 
            // TrackBar_State
            // 
            this.TrackBar_State.BackColor = System.Drawing.Color.HotPink;
            this.TrackBar_State.Location = new System.Drawing.Point(24, 123);
            this.TrackBar_State.Name = "TrackBar_State";
            this.TrackBar_State.Size = new System.Drawing.Size(205, 69);
            this.TrackBar_State.TabIndex = 37;
            this.TrackBar_State.TickFrequency = 0;
            this.TrackBar_State.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar_State.Scroll += new System.EventHandler(this.TrackBar_State_Scroll);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "PDPlayer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contextMenuStrip1.BackgroundImage")));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.기능ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(96, 94);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 기능ToolStripMenuItem
            // 
            this.기능ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("기능ToolStripMenuItem.BackgroundImage")));
            this.기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재생ToolStripMenuItem,
            this.일시정지ToolStripMenuItem,
            this.정지ToolStripMenuItem,
            this.다음곡ToolStripMenuItem,
            this.이전곡ToolStripMenuItem});
            this.기능ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.기능ToolStripMenuItem.Name = "기능ToolStripMenuItem";
            this.기능ToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
            this.기능ToolStripMenuItem.Text = "기능";
            // 
            // 재생ToolStripMenuItem
            // 
            this.재생ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("재생ToolStripMenuItem.BackgroundImage")));
            this.재생ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.재생ToolStripMenuItem.Name = "재생ToolStripMenuItem";
            this.재생ToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.재생ToolStripMenuItem.Text = "재생";
            this.재생ToolStripMenuItem.Click += new System.EventHandler(this.재생ToolStripMenuItem_Click);
            // 
            // 일시정지ToolStripMenuItem
            // 
            this.일시정지ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("일시정지ToolStripMenuItem.BackgroundImage")));
            this.일시정지ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.일시정지ToolStripMenuItem.Name = "일시정지ToolStripMenuItem";
            this.일시정지ToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.일시정지ToolStripMenuItem.Text = "일시정지";
            this.일시정지ToolStripMenuItem.Click += new System.EventHandler(this.일시정지ToolStripMenuItem_Click);
            // 
            // 정지ToolStripMenuItem
            // 
            this.정지ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("정지ToolStripMenuItem.BackgroundImage")));
            this.정지ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.정지ToolStripMenuItem.Name = "정지ToolStripMenuItem";
            this.정지ToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.정지ToolStripMenuItem.Text = "정지";
            this.정지ToolStripMenuItem.Click += new System.EventHandler(this.정지ToolStripMenuItem_Click);
            // 
            // 다음곡ToolStripMenuItem
            // 
            this.다음곡ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("다음곡ToolStripMenuItem.BackgroundImage")));
            this.다음곡ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.다음곡ToolStripMenuItem.Name = "다음곡ToolStripMenuItem";
            this.다음곡ToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.다음곡ToolStripMenuItem.Text = "다음곡";
            this.다음곡ToolStripMenuItem.Click += new System.EventHandler(this.다음곡ToolStripMenuItem_Click);
            // 
            // 이전곡ToolStripMenuItem
            // 
            this.이전곡ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("이전곡ToolStripMenuItem.BackgroundImage")));
            this.이전곡ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.이전곡ToolStripMenuItem.Name = "이전곡ToolStripMenuItem";
            this.이전곡ToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.이전곡ToolStripMenuItem.Text = "이전곡";
            this.이전곡ToolStripMenuItem.Click += new System.EventHandler(this.이전곡ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 34);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrevious.BackgroundImage")));
            this.BtnPrevious.Location = new System.Drawing.Point(40, 170);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(43, 35);
            this.BtnPrevious.TabIndex = 34;
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNext.BackgroundImage")));
            this.BtnNext.Location = new System.Drawing.Point(169, 170);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(43, 35);
            this.BtnNext.TabIndex = 33;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSave.Location = new System.Drawing.Point(444, 34);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(71, 30);
            this.BtnSave.TabIndex = 38;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblShowingBox
            // 
            this.LblShowingBox.BackColor = System.Drawing.Color.Transparent;
            this.LblShowingBox.Image = ((System.Drawing.Image)(resources.GetObject("LblShowingBox.Image")));
            this.LblShowingBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblShowingBox.Location = new System.Drawing.Point(10, 9);
            this.LblShowingBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblShowingBox.MinimumSize = new System.Drawing.Size(195, 120);
            this.LblShowingBox.Name = "LblShowingBox";
            this.LblShowingBox.Size = new System.Drawing.Size(250, 120);
            this.LblShowingBox.TabIndex = 39;
            // 
            // PinkDolphinPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(545, 314);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TrackBar_State);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.CkBox_NonSound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrackBarSound);
            this.Controls.Add(this.textBox_PlayTime);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.trackBarOpacity);
            this.Controls.Add(this.listBox_PlayList);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnShowingList);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnWait);
            this.Controls.Add(this.RadioBtnRandomRepeat);
            this.Controls.Add(this.RadioBtnOneRefeat);
            this.Controls.Add(this.RadioBtnNone);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.BtnShowingLyics);
            this.Controls.Add(this.LblShowingBox);
            this.Font = new System.Drawing.Font("HY강M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(567, 370);
            this.MinimumSize = new System.Drawing.Size(263, 370);
            this.Name = "PinkDolphinPlayer";
            this.Text = "PDPlayer";
            this.Activated += new System.EventHandler(this.PinkDolphinPlayer_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PinkDolphinPlayer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PinkDolphinPlayer_FormClosed);
            this.Load += new System.EventHandler(this.PinkDolphinPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar_State)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowingLyics;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.RadioButton RadioBtnNone;
        private System.Windows.Forms.RadioButton RadioBtnOneRefeat;
        private System.Windows.Forms.RadioButton RadioBtnRandomRepeat;
        private System.Windows.Forms.Button BtnWait;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnShowingList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ListBox listBox_PlayList;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.TextBox textBox_PlayTime;
        private System.Windows.Forms.TrackBar TrackBarSound;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.CheckBox CkBox_NonSound;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar TrackBar_State;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재생ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일시정지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다음곡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이전곡ToolStripMenuItem;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblShowingBox;
    }
}

