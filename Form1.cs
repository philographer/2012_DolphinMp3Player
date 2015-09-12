using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using JLyrics;
using System.IO;//파일입출력


//576, 359
// 사이즈576(263), 359
namespace Teamproject
{
    public partial class PinkDolphinPlayer : Form
    {
        Form2 child;

        Random Randomnum = new Random();//랜덤재생을위한 난수 Randomnum생성
        int tempRandomnum = 0;
        
        Audio_Class audio = null;//오디오 클래스 사용

        private Lyrics Lyric = new Lyrics(); //가사 dll사용 Lyric

        public double leftTime = 0;//남은시간 0으로 초기 설저
        public int nowplaynum = 0;//현재 재생중인 곡 count1
        public int selectnum = 0;
        bool bCheckPause = false;//pause 사용중 x
        int repeatnum;
        ArrayList aFilePathListSave = new ArrayList();
        ArrayList filesSave = new ArrayList();
        ArrayList filesName = new ArrayList();

        ArrayList aFilePathList = new ArrayList();//파일경로 저장하는 리스트
        ArrayList aFileNameList = new ArrayList();//파일이름을 저장 하는리스트
        string[] files=null;//파일의 이름을 넣는 STRING배열
        //string[] Gasa; //가사를 넣는 string배열
        private String[] fLyricLists; //가사를 넣는 string배열
        bool hide = true;


        public PinkDolphinPlayer()
        {
            InitializeComponent();//폼에 디자인한 내용 적용

        }

        private void BtnShowingLyics_Click(object sender, EventArgs e)
        {


            if (child.IsDisposed) // 컨트롤이 죽었으면 ☆
            {
                child = new Form2(); // 다시 인스턴스생성
                child.Show();
            }
            else
            {
                child.Show();
            }



        }

        private void BtnShowingList_Click(object sender, EventArgs e) //재생 리스트 show
        {
            if (hide == false)
            {
                this.Width = 576; //넓이를 507사이즈로
                hide = true;
            }

            else
            {
                this.Width = 270;
                hide = false;
            }
        }



        private void RadioBtnNone_CheckedChanged(object sender, EventArgs e) //일반재생 라디오버튼 체크
        {

        }

        private void RadioBtnAllRefeat_CheckedChanged(object sender, EventArgs e)//랜덤재생 라디오버튼 체크
        {

        }

        private void RadioBtnOneRefeat_CheckedChanged(object sender, EventArgs e)//반복재생 라디오버튼 체크
        {


        }

        private void PinkDolphinPlayer_Load(object sender, EventArgs e)//돌핀플레이어 실행
        {

            //SetCtlsArgb();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //trackBarOpacity.BackColor = Color.Transparent;

            DirectoryInfo temp = new DirectoryInfo(@"C:\temp");
            if (temp.Exists == false)
            {
                temp.Create();
            }
            child = new Form2();

            try
            {

                FileStream fs = new FileStream(@"C:\temp\FileName.txt", FileMode.Open);
                StreamReader r = new StreamReader(fs);
                while (!r.EndOfStream)
                {
                    aFileNameList.Add(r.ReadLine());
                    //filesName.Add(r.ReadLine());
                }

                for (int i = 0; i < aFileNameList.Count; i++)
                {
                    listBox_PlayList.Items.Add(aFileNameList[i]);

                }

                r.Close();
                r.Dispose();

                //files = new string[filesName.Count];

                //for (int i = 0; i < filesName.Count; i++)
                //{

                //    files[i] = filesName[i].ToString();

                //}

                for (int i = 0; i < listBox_PlayList.Items.Count; i++)
                {
                    aFileNameList[i] = listBox_PlayList.Items[i];
                }
            }

            catch
            {
            }
      
          

            try//환경설정을 가져옴
            {

                FileStream fs2 = new FileStream(@"C:\temp\FilePath.txt", FileMode.Open);
                StreamReader r2 = new StreamReader(fs2);
                while (!r2.EndOfStream)
                {
                    aFilePathListSave.Add(r2.ReadLine());
                }

                for (int i = 0; i < aFileNameList.Count; i++)
                {
                    aFilePathList.Add(aFilePathListSave[i]);
                 
                }

                r2.Close();
                r2.Dispose();


            }


            catch
            {

            }



        }

        private void BtnStop_Click(object sender, EventArgs e) //음악 정지버튼 클릭
        {
            if (audio != null)
            {
                audio.Stop();//오디오 정지
                timer1.Stop();//timer1 정지
            }
        }

        private void BtnWait_Click(object sender, EventArgs e) //일시정지버튼 클릭
        {
            if (bCheckPause == false)
            {

                if (audio != null)
                {

                    audio.Pause();//오디오 일시정지
                    timer1.Stop();//타이머1 정지
                    bCheckPause = true;//오디오 일시정지상태 true

                }
            }

            else
            {
                BtnStart_Click(sender, e);
            }



        }

        private void BtnDelete_Click(object sender, EventArgs e)//선택한것 삭제버튼
        {
            int nIndex = listBox_PlayList.SelectedIndex; // nindex = 리스트박스에서 선택한 인덱스

            if (nIndex >= 0)
            {
                listBox_PlayList.Items.RemoveAt(nIndex); //선택한 인덱스를 리스트박스에서 제거
                aFilePathList.RemoveAt(nIndex); //선택한 인덱스를 aFilepaths arraylist에서 삭제
                aFileNameList.RemoveAt(nIndex);
            }

            else
            {
                MessageBox.Show("삭제할 파일이 없습니다.", "파일 삭제"); //인덱스에서 선택하지 않았을때
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) //OFD
        {

        }

        private void BtnStart_Click(object sender, EventArgs e) //시작버튼 클릭
        {
            MusicStart(); //음악재생 함수
        }


        public void setLylics(string Data)
        {
            textBox_Title.Text = Data;
        }

        private void MusicStart() //한곡재생
        {
            try
            {
                nowplaynum = listBox_PlayList.SelectedIndex;
                int nIndex = listBox_PlayList.SelectedIndex;    //선택된 인덱스 번호

                if (repeatnum < 0) //선택한 인덱스가 없을때
                {
                    MessageBox.Show("재생할 곡을 선택해 주세요.", "재 생");
                    return;
                }

                if (!bCheckPause) //음악이 일시정지 상태가 아닐때
                {
                    if (audio != null) // 오디오객체가 있을때
                    {
                        audio.Stop(); // 재생중인 오디오를 멈추고
                        audio.Close();//재생하지않을때 메모리 차지하지 않게
                    }

                    audio = new Audio_Class(); //새 오디오객체 생성
                    timer1.Start(); //timer1 시작

                    //장치 오픈

                    if (!audio.Open((string)aFilePathList[repeatnum])) //선택된 인덱스의 파일경로를 통해 audio객체생성할 수 없을때
                    {
                        MessageBox.Show("재생할 수 없는 곡입니다.", "재 생");
                        return;//audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex]) 실행
                    }

                    textBox_Title.Text = listBox_PlayList.Items[repeatnum].ToString();//제목창에 선택재생된 인덱스를 출력
                    //child.TxtName.Text = listBox_PlayList.SelectedItem.ToString();//가사창에 선택재생된 인덱스를 출력
                }           //재생

                int nVolume = TrackBarSound.Value * 30; // 트랙바를 통한 사운드값 조정
                audio.SetVolume(nVolume);

                audio.play();//음악재생 시작
                leftTime = audio.GetLength() / 1000; // 남은시간(hour) 

                timer1.Start();//타이머1 시작
                bCheckPause = false;//일시정지상태 아님

                if (Lyric.GetLyricsFromFile(((string)aFilePathList[repeatnum]), child.ckViewTime1.Checked))
                {
                    fLyricLists = null;
                    fLyricLists = Lyric.LyricLists;
                    child.TxtLyric.Text = fLyricLists[0];
                }
            }

            catch
            {
            }

            //Gasa = Lyric.GetFileLyrics((string)aFilePathList[listBox_PlayList.SelectedIndex]).Split(new string[] { " <br> " }, StringSplitOptions.RemoveEmptyEntries);

            // files = openFileDialog1.SafeFileNames; // 열기 대화상자에서 선택한 파일 이름들을 모두 가져옴

            //for (int i = 0; i < Gasa.Length; i++) //for문을 이용해 가져온 파일 이름을 listbox에 추가시킴
            //{
            //    child.TxtLyric.Text = Gasa[i];


            //}

            //child.TxtLyric.Text = Gasa;
        }

        private void PreviousMusicStart()
        {

            int nIndex = listBox_PlayList.SelectedIndex;    //선택된 인덱스 번호

            if (nIndex < 0) //선택된 인덱스의 파일경로를 통해 audio객체생성
            {
                MessageBox.Show("재생할 곡을 선택해 주세요.", "재 생");
                return;
            }

            audio.Stop();// 재생중인 오디오를 멈추고
            audio.Close();//재생하지않을때 메모리 차지하지 않게



            audio = new Audio_Class(); //새 오디오객체 생성
            timer1.Start(); //timer1 시작

            //장치 오픈
            if (!audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum])) //선택된 인덱스의 파일경로를 통해 audio객체생성할 수 없을때
            {
                MessageBox.Show("재생할 수 없는 곡입니다.", "재 생");

                return; //audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum]) 실행
            }

            //제목 창 출력
            textBox_Title.Text = listBox_PlayList.SelectedItem.ToString(); //제목창에 선택재생된 인덱스를 출력
            //child.TxtName.Text = listBox_PlayList.SelectedItem.ToString();//가사창에 선택재생된 인덱스를 출력

            //재생

            int nVolume = TrackBarSound.Value * 30; // 트랙바를 통한 사운드값 조정
            audio.SetVolume(nVolume);
            nowplaynum++; //nowplaynum 1 증가

            audio.play(); //음악재생 시작
            leftTime = audio.GetLength() / 1000;// 남은시간(hour) 

            timer1.Start(); //타이머1 시작
            bCheckPause = false; //일시정지상태 아님

            if (Lyric.GetLyricsFromFile(((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum]), child.ckViewTime1.Checked))
            {
                fLyricLists = null;
                fLyricLists = Lyric.LyricLists;
                child.TxtLyric.Text = fLyricLists[0];
            }

        }







        private void RandomMusicStart() //랜덤재생 시작
        {

            try
            {
                int nIndex = listBox_PlayList.SelectedIndex;    //선택된 인덱스 번호

                if (nIndex < 0) //선택된 인덱스의 파일경로를 통해 audio객체생성
                {
                    MessageBox.Show("재생할 곡을 선택해 주세요.", "재 생");
                    return;
                }

                int RandomNum = Randomnum.Next(1, 999); //랜덤 난수 생성
                

                while(true) //랜덤시 중복배제 
                {
                    if (tempRandomnum == tempRandomnum % listBox_PlayList.Items.Count)
                    {
                        RandomNum = Randomnum.Next(1, 999);
                        tempRandomnum = RandomNum;
                    }


                    if (tempRandomnum != tempRandomnum % listBox_PlayList.Items.Count)
                        break;
                   
                }

                if (!bCheckPause) //음악이 일시정지 상태가 아닐때
                {
                    if (audio != null)// 오디오객체가 있을때
                    {
                        audio.Stop(); // 재생중인 오디오를 멈추고
                        audio.Close(); //재생하지않을때 메모리 차지하지 않게
                    }

                    audio = new Audio_Class(); //새 오디오객체 생성
                    timer1.Start();//타이머1 시작

                    //장치 오픈
                    if (!audio.Open((string)aFilePathList[RandomNum % listBox_PlayList.Items.Count])) //선택된 인덱스의 파일경로를 통해 audio객체생성할 수 없을때
                    {
                        MessageBox.Show("재생할 수 없는 곡입니다.", "재 생");
                        return; //audio.Open((string)aFilePathList[RandomNum % listBox_PlayList.Items.Count])실행
                    }

                    textBox_Title.Text = aFileNameList[RandomNum % listBox_PlayList.Items.Count].ToString(); //제목창에 선택재생된 인덱스를 출력
                    //child.TxtName.Text = listBox_PlayList.SelectedItem.ToString();//가사창에 선택재생된 인덱스를 출력
                }

                int nVolume = TrackBarSound.Value * 30; // 트랙바를 통한 사운드값 조정
                audio.SetVolume(nVolume);

                audio.play(); //음악재생 시작
                leftTime = audio.GetLength() / 1000;// 남은시간(hour) 

                timer1.Start(); //타이머1 시작
                bCheckPause = false; //일시정지상태 아님

                if (Lyric.GetLyricsFromFile(((string)aFilePathList[RandomNum % listBox_PlayList.Items.Count]), child.ckViewTime1.Checked))
                {
                    fLyricLists = null;
                    fLyricLists = Lyric.LyricLists;
                    child.TxtLyric.Text = fLyricLists[0];
                }

                tempRandomnum = RandomNum;
            }

            catch
            {
            }
            
        }

        private void BtnAdd_Click(object sender, EventArgs e) //추가 버튼 클릭 
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //OFD 생성
            openFileDialog1.Filter = "Music Files(*.mp3; *.wmv; *.wma;)|*.mp3;*.wmv;*.wma|" +
            "All files (*.*)|*.*"; // 선택가능한 확장자 필터
            openFileDialog1.DefaultExt = "mp3"; //초기 선택값
            openFileDialog1.Multiselect = true; //다중선택 설정
            this.openFileDialog1.Title = "My Music Browser"; //OFD창 이름

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) // 파일 열기 대화상자에서 파일 클릭 후 열기 버튼 눌렀다면?
            {
                files = openFileDialog1.SafeFileNames; // 열기 대화상자에서 선택한 파일 이름들을 모두 가져옴
                //paths = openFileDialog1.FileNames; // 여기도 마찬가지, 다만 FileNames는 전체 경로를 포함합함

                this.aFilePathList.AddRange(openFileDialog1.FileNames); //OFD에서 가져온 파일들의 경로들을 aFilePathList araaylist 에 저장
                aFileNameList.AddRange(openFileDialog1.SafeFileNames);
                
                
                for (int i = 0; i < files.Length; i++) //for문을 이용해 가져온 파일 이름을 listbox에 추가시킴
                {

                    this.listBox_PlayList.Items.Add(files[i]);
                }
            }
            //  01 02 03 04 05 06 12 13 14 15 16 23 24 25 26 34 35 36 45 46 56 

            for (int i = 0; i < listBox_PlayList.Items.Count; i++)
            {
                for (int i2 = i + 1; i2 < listBox_PlayList.Items.Count; i2++)
                    if (listBox_PlayList.Items[i].ToString() == listBox_PlayList.Items[i2].ToString())
                    {
                        MessageBox.Show("중복된 파일을 축가할 수 없습니다.");
                        listBox_PlayList.Items.RemoveAt(i);
                        aFilePathList.RemoveAt(i);
                        aFileNameList.RemoveAt(i);
                    }
            }

            

           


        }

        private void trackBar1_Scroll(object sender, EventArgs e) //볼륨조절
        {
            if (audio != null) //오디오객체가 사용중이라면
            {
                int nVolume = TrackBarSound.Value * 30; // 트랙바를 통한 사운드값 조정
                audio.SetVolume(nVolume);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //타이머(현재재생시간/총재생시간)
        {
            try
            {
                int nCurTime = audio.GetPosition() / 1000; //Khour ->hour
                int nTotalTime = audio.GetLength() / 1000; //khour ->hour
                int nCurMinute = nCurTime / 60; // 시간을 60분으로 나누어 분으로
                int nCurSecond = nCurTime % 60; // 시간을 60의 나머지로 하여 초로
                int nTotalMinute = nTotalTime / 60; //전체시간 분
                int nTotalSecond = nTotalTime % 60; //전체시간 초 
                textBox_PlayTime.Text = nCurMinute.ToString() + ":" + nCurSecond.ToString() //텍스트박스에 "현재분:현재초 / 전체분:전체초" 표시
                    + "/" + nTotalMinute.ToString() + ":" + nTotalSecond.ToString();
                // 노래가 끝났을때
                if (leftTime <= 0)
                {

                    if (RadioBtnOneRefeat.Checked) // 한곡반복이면
                    {
                        MusicStart();//음악 시작 함수
                    }

                    if (RadioBtnNone.Checked)// 일반재생(순차재생)이면
                    {



                        if (nowplaynum + selectnum < aFileNameList.Count)
                        {
                            NextMusicStart();// 다음음악 시작 함수
                        }

                        else
                        {
                            audio.Stop(); // 오디오 멈춤
                            nowplaynum = 0;//다시처음재생순서로
                        }
                    }

                    if (RadioBtnRandomRepeat.Checked)// 랜덤재생이면
                    {
                        RandomMusicStart();//랜덤재생 함수
                    }
                }
                leftTime = leftTime - 0.1; //남은시간:  타이머의 인터벌이 0.1초니깐 0.1초씩 깎음


                TrackBar_State.Maximum = 100;
                TrackBar_State.Minimum = 0;
                TrackBar_State.Value = Convert.ToInt32(Convert.ToInt32(audio.GetPosition().ToString()) * 100 / audio.GetLength());
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "이전곡이 존재하지 않습니다.");
            }
        }

        private void listBox_PlayList_DoubleClick(object sender, EventArgs e)//파일리스트에 있는 목록을 더블클릭하면
        {
            repeatnum = listBox_PlayList.SelectedIndex;
            BtnStart_Click(null, null);//음악시작
        }

        private void trackBar2_Scroll(object sender, EventArgs e)// 트랙바를 움직이면 
        {
            this.Opacity = this.trackBarOpacity.Value * 0.01;//트랙바 투명/
        }

        private void listBox_PlayList_KeyDown(object sender, KeyEventArgs e)//delete키를 눌렀을때 선택목록 삭제
        {
            if (e.KeyCode == Keys.Delete)
            {
                BtnDelete_Click(null, null);
            }
        }

        private void textBox_PlayTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVolum_Click(object sender, EventArgs e)
        {

        }

        private void CkBox_NonSound_CheckedChanged(object sender, EventArgs e)//음소거박스 체크
        {
            try
            {

                if (CkBox_NonSound.CheckState == CheckState.Checked)
                {
                    audio.SetVolume(0);//소리 0
                }

                else
                {
                    int nVolume = TrackBarSound.Value * 30; // 트랙바를 통한 사운드값 조정
                    audio.SetVolume(nVolume);
                }
            }

            catch
            {
            }



        }

    
        private void BtnNext_Click(object sender, EventArgs e)
        {
          
                if (RadioBtnRandomRepeat.Checked)// 랜덤재생이면
                {
                    RandomMusicStart();//랜덤재생 함수
                }

                if (RadioBtnNone.Checked)
                {
                    NextButtonMusicMusicStart();
                }

                if (RadioBtnOneRefeat.Checked)
                {
                    NextButtonMusicMusicStart();

                }
            

           
        }
    

   

        private void NextMusicStart() //순차재생
        {

            nowplaynum++; //nowplaynum 1 증가
            if (aFilePathList.Count <= nowplaynum)
            {
                nowplaynum = 0;
            }
            if (selectnum < 0) //선택된 인덱스의 파일경로를 통해 audio객체생성
            {
                MessageBox.Show("재생할 곡을 선택해 주세요.", "재 생");
                return;
            }

            if (!bCheckPause) //음악이 일시정지 상태가 아닐때
            {
                if (audio != null)// 오디오객체가 있을때
                {
                    audio.Stop();// 재생중인 오디오를 멈추고
                    audio.Close();//재생하지않을때 메모리 차지하지 않게

                }

                audio = new Audio_Class(); //새 오디오객체 생성
                timer1.Start(); //timer1 시작

                //장치 오픈
                //if (!audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum])) //선택된 인덱스의 파일경로를 통해 audio객체생성할 수 없을때
                if (!audio.Open((string)aFilePathList[selectnum + nowplaynum]))
                {
                    MessageBox.Show("재생할 수 없는 곡입니다.", "재 생");

                    return; //audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum]) 실행
                }

                //제목 창 출력
                textBox_Title.Text = aFileNameList[selectnum + nowplaynum].ToString(); //제목창에 선택재생된 인덱스를 출력
                //child.TxtName.Text = listBox_PlayList.SelectedItem.ToString();//가사창에 선택재생된 인덱스를 출력
            }
            //재생

            audio.SetVolume(200); //오디오의 시작볼륨


            audio.play(); //음악재생 시작
            leftTime = audio.GetLength() / 1000;// 남은시간(hour) 

            timer1.Start(); //타이머1 시작
            bCheckPause = false; //일시정지상태 아님

            try
            {

                if (Lyric.GetLyricsFromFile(((string)aFilePathList[selectnum + nowplaynum]), child.ckViewTime1.Checked))
                {
                    fLyricLists = null;
                    fLyricLists = Lyric.LyricLists;
                    child.TxtLyric.Text = fLyricLists[0];
                }
            }

            catch
            {
                child.TxtLyric.Text = "가사를 찾을 수 없습니다.";
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (RadioBtnRandomRepeat.Checked)// 랜덤재생이면
            {
                RandomMusicStart();//랜덤재생 함수
            }

            if (RadioBtnNone.Checked)
            {
                PreviousButtonMusicStart();
            }

            if (RadioBtnOneRefeat.Checked)
            {
                PreviousButtonMusicStart();

            }

        }

        private void PinkDolphinPlayer_Activated(object sender, EventArgs e)
        {

        }

        private void PinkDolphinPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 종료 이벤트를 취소 시킨다
            this.Visible = false; // 폼을 표시하지 않는다;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다 
            this.Activate(); // 폼을 활성화 시킨다
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다 
            this.Activate(); // 폼을 활성화 시킨다
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
            this.Close();
        }

        private void 재생ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnStart_Click(sender, e);
        }

        private void 일시정지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnWait_Click(sender, e);
        }

        private void 정지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnStop_Click(sender, e);
        }

        private void 다음곡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnNext_Click(sender, e);
        }

        private void 이전곡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnPrevious_Click(sender, e);
        }


        private void NextButtonMusicMusicStart()
        {
            nowplaynum++; //nowplaynum 1 증가
            if (aFilePathList.Count <= nowplaynum)
            {
                nowplaynum = 0;
            }
            if (selectnum < 0) //선택된 인덱스의 파일경로를 통해 audio객체생성
            {
                MessageBox.Show("재생할 곡을 선택해 주세요.", "재 생");
                return;
            }

            if (!bCheckPause) //음악이 일시정지 상태가 아닐때
            {
                if (audio != null)// 오디오객체가 있을때
                {
                    audio.Stop();// 재생중인 오디오를 멈추고
                    audio.Close();//재생하지않을때 메모리 차지하지 않게

                }

                audio = new Audio_Class(); //새 오디오객체 생성
                timer1.Start(); //timer1 시작

                //장치 오픈
                //if (!audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum])) //선택된 인덱스의 파일경로를 통해 audio객체생성할 수 없을때
                if (!audio.Open((string)aFilePathList[selectnum + nowplaynum]))
                {
                    MessageBox.Show("재생할 수 없는 곡입니다.", "재 생");

                    return; //audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum]) 실행
                }

                //제목 창 출력
                textBox_Title.Text = aFileNameList[selectnum + nowplaynum].ToString(); //제목창에 선택재생된 인덱스를 출력
                //child.TxtName.Text = listBox_PlayList.SelectedItem.ToString();//가사창에 선택재생된 인덱스를 출력
            }
            //재생

            audio.SetVolume(200); //오디오의 시작볼륨


            audio.play(); //음악재생 시작
            leftTime = audio.GetLength() / 1000;// 남은시간(hour) 

            timer1.Start(); //타이머1 시작
            bCheckPause = false; //일시정지상태 아님

            try
            {

                if (Lyric.GetLyricsFromFile(((string)aFilePathList[selectnum + nowplaynum]), child.ckViewTime1.Checked))
                {
                    fLyricLists = null;
                    fLyricLists = Lyric.LyricLists;
                    child.TxtLyric.Text = fLyricLists[0];
                }
            }

            catch
            {
                child.TxtLyric.Text = "가사를 찾을 수 없습니다.";
            }

        }

        private void PreviousButtonMusicStart()
        {
            --nowplaynum; //nowplaynum 1 감소
            try
            {

                if (nowplaynum < 0)
                {
                    nowplaynum = aFileNameList.Count -1;
                }
                if (selectnum < 0) //선택된 인덱스의 파일경로를 통해 audio객체생성
                {
                    MessageBox.Show("재생할 곡을 선택해 주세요.", "재 생");
                    return;
                }

                if (!bCheckPause) //음악이 일시정지 상태가 아닐때
                {
                    if (audio != null)// 오디오객체가 있을때
                    {
                        audio.Stop();// 재생중인 오디오를 멈추고
                        audio.Close();//재생하지않을때 메모리 차지하지 않게

                    }

                    audio = new Audio_Class(); //새 오디오객체 생성
                    timer1.Start(); //timer1 시작

                    //장치 오픈
                    //if (!audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum])) //선택된 인덱스의 파일경로를 통해 audio객체생성할 수 없을때
                    if (!audio.Open((string)aFilePathList[selectnum + nowplaynum]))
                    {
                        MessageBox.Show("재생할 수 없는 곡입니다.", "재 생");

                        return; //audio.Open((string)aFilePathList[listBox_PlayList.SelectedIndex + nowplaynum]) 실행
                    }

                    //제목 창 출력
                    textBox_Title.Text = aFileNameList[selectnum + nowplaynum].ToString(); //제목창에 선택재생된 인덱스를 출력
                    //child.TxtName.Text = listBox_PlayList.SelectedItem.ToString();//가사창에 선택재생된 인덱스를 출력
                }
                //재생

                audio.SetVolume(200); //오디오의 시작볼륨


                audio.play(); //음악재생 시작
                leftTime = audio.GetLength() / 1000;// 남은시간(hour) 

                timer1.Start(); //타이머1 시작
                bCheckPause = false; //일시정지상태 아님

                try
                {

                    if (Lyric.GetLyricsFromFile(((string)aFilePathList[selectnum + nowplaynum]), child.ckViewTime1.Checked))
                    {
                        fLyricLists = null;
                        fLyricLists = Lyric.LyricLists;
                        child.TxtLyric.Text = fLyricLists[0];
                    }
                }

                catch
                {
                    child.TxtLyric.Text = "가사를 찾을 수 없습니다.";
                }
            }
            catch
            {
                nowplaynum = 0;
            }
        }

        private void PinkDolphinPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            filesSave.Clear();
            filesName.Clear();
            
            aFilePathListSave.Clear();


            for (int i = 0; i < listBox_PlayList.Items.Count; i++)
            {

                filesName.Add(listBox_PlayList.Items[i]);
            }

            StreamWriter sw1;
            sw1 = new StreamWriter(@"C:\temp\FilePath.txt");

            for (int i = 0; i < listBox_PlayList.Items.Count; i++)
            {
                //aFilePathListSave[i] += "\r\n";
                aFilePathListSave.Add(aFilePathList[i]);
            }

            for (int i = 0; i < listBox_PlayList.Items.Count; i++)
            {
                aFilePathListSave[i] += "\r\n";
                sw1.Write(aFilePathListSave[i]);
            }

            aFilePathListSave.Clear();
            sw1.Close();
            StreamWriter sw2;
            sw2 = new StreamWriter(@"C:\temp\FileName.txt");


            for (int i = 0; i < listBox_PlayList.Items.Count; i++)
            {
               
                filesSave.Add(aFileNameList[i]);
            }

            for (int i = 0; i < listBox_PlayList.Items.Count; i++)
            {
                filesSave[i] += "\r\n";
                sw2.Write(filesSave[i]);
            }

            
            filesName.Clear();
            filesSave.Clear();
            sw2.Close();
        }

        private void SetCtlsArgb()
        {
            Control.ControlCollection coll = this.Controls;
            foreach (Control c in coll)
            {
                if (c != null)
                {
                    // CheckBox , Lable인 컨트롤의 경우 투명하게 처리합니다.
                    if (c.GetType() == typeof(CheckBox) || c.GetType() == typeof(Label))
                    {
                        c.BackColor = Color.FromArgb(0, 0, 0, 0);
                    }

                }

            }
        }

        private void TrackBar_State_Scroll(object sender, EventArgs e)
        {

        }

    }
}




/*고칠점
1. delete 오류(index) clear 
2. 순차재생 index오류(index값 벗어날때 설정) clear
3. 파일멀티셀렉트로 추가후 다음파일 추가할때 인덱스 곂침 claer
4. 랜덤재생 claer
5. 가사clear
6. 가사 다시키면 사라짐 clear
6. 음소거clear
7. 가사보기 두번클릭 오류clear
8. 리스트에 같은 노래 삽입됨. 에러메세지 창 출력할것.
9. 리스트 노래제목 짤림.clear
10. 호균이 수고했다  ㅎㅎㅎclear
11. 노래제목 짤림clear
12.폼 크기 고정시키는거 그거 -ㅁx 에서 ㅁ누르면 확 커진디야.clear
13.음소거파트를 clear
14.진행바 clear
15.가사1줄xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
16.작업표시줄트레이아이콘clear
17.앞뒤버튼 clear
18. 앞뒤 알고리즘 다음재생xxxxxxxxxxxxx
 * ----------------------------------------------------
19. 한곡clear
20. 일반
21. 랜덤
22. 앞재생
23. 뒤재생
24.일반재생
 */
