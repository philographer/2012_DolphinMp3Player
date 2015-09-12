using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;


namespace Teamproject
{
    class Audio_Class
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn,
            int iReturnLength, IntPtr hwndCallback);

        public bool Open(string StrFileName)
        {
            FileInfo fi = new FileInfo(StrFileName);
            string strFileType = "";
            if (fi.Exists)   //존재하느냐 아니냐
            {
                if (fi.Extension.ToLower() == ".wav") strFileType = "waveaudio";                   //존재하면 화확장자가 wav면 waveaudio
                else if (fi.Extension.ToLower() == ".mp3") strFileType = "mpegvideo";                //mp3면 mpegvideo
                else
                {
                    MessageBox.Show("음악파일이 아닙니다", "파일선택 오류");                      //에러메세지
                    return false;
                }
            }
            else
            {
                return false;
            }
            string strCmdString = "open \"" + StrFileName + "\" type " + strFileType + " alias media";
            mciSendString(strCmdString, null, 0, IntPtr.Zero);
            return true;
        }
        public bool play()
        {
            mciSendString("Play media notify", null, 0, IntPtr.Zero);
            return true;
        }
        public void Pause()
        {
            mciSendString("pause media", null, 0, IntPtr.Zero);
        }
        public void Stop()
        {
            mciSendString("stop media", null, 0, IntPtr.Zero);
        }
        public void Close()      //재생하지않을때 메모리 차지하지 않게
        {
            mciSendString("close media", null, 0, IntPtr.Zero);
        }
    
        public int GetPosition()
        {
            
                int nReturnValue = 0;
                StringBuilder strReturn = new StringBuilder(128);
                mciSendString("status media position", strReturn, 128, IntPtr.Zero);
                nReturnValue = Convert.ToInt32(strReturn.ToString());
                return nReturnValue;
           
            
        }
  
        public int GetLength()
        {
            int nReturnValue = 0;
            StringBuilder strReturn = new StringBuilder(128);
            mciSendString("status media length", strReturn, 128, IntPtr.Zero);
            nReturnValue = Convert.ToInt32(strReturn.ToString());
            return nReturnValue;
        }
        public void SetVolume(int nVolume)
        {
            mciSendString("setaudio media volume to " + nVolume.ToString(), null, 0, IntPtr.Zero);
        }

     
        
    }
}
