using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.ScreenCapture;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Headliner
{
    public partial class FullScreen : Form
    {
        int x = 0;
        int loopCount = 0;
        int totalTw = 0;
        ScreenRecorder screenRec = new ScreenRecorder(new Rectangle(), "");
        int whichOne = 0;
        private ScreenCaptureJob job;
        string[] allHeadlinesArray = System.IO.File.ReadAllLines(@"C:\Windows\Temp\headlines.txt");
        string[] allSecondaryHeadlineArray = System.IO.File.ReadAllLines(@"C:\Windows\Temp\SecondaryHeadlines.txt");
        string[] fontArray = System.IO.File.ReadAllLines(@"C:\Windows\Temp\headlinerSettings.txt");
        Font choosenFont;
        LinkedList<String> allHeadlines = new LinkedList<string>();
        LinkedList<String> allSecondaryHeadlines = new LinkedList<string>();
        string[] allUrlsArray = System.IO.File.ReadAllLines(@"C:\Windows\Temp\mediaUrls.txt");
        LinkedList<String> allUrls = new LinkedList<string>();
        string path = "";
        int noOfTwentySec = 0;
        int noOfSmaller = 0;
        int closeCall = 0;
        WMPLib.IWMPPlaylist playlist;
        public FullScreen()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            axWindowsMediaPlayer1.Size = new Size(width, height);
            axWindowsMediaPlayer2.Size = new Size((width / 100) * 30, (height / 100) * 40);
            axWindowsMediaPlayer2.Location = new Point((width / 100) * 63, (height / 100) * 34);
            pictureBox1.Size = new Size((width / 100) * 30, (height / 100) * 40);
            pictureBox1.Location = new Point((width / 100) * 63, (height / 100) * 34);
            axWindowsMediaPlayer2.uiMode = "none";
            
        }

        private void FullScreen_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            foreach (string line in allHeadlinesArray)
            {
                allHeadlines.AddLast(line);
            }
            foreach (string line in allSecondaryHeadlineArray)
            {
                allSecondaryHeadlines.AddLast(line);
            }
            foreach (string line in allUrlsArray)
            {
                allUrls.AddLast(line);
            }
            for (int i=0; i < allUrlsArray.Length; i++)
            {
                Console.WriteLine(allUrls.ElementAt(i));
            }
            string fontString="";
            foreach (string line in fontArray)
            {
                fontString = line;
            }
            var cvt = new FontConverter();
            fontString = cvt.ConvertToString(this.Font);
            choosenFont = cvt.ConvertFromString(fontString) as Font;
            PrivateFontCollection f = new PrivateFontCollection();
            
            f.AddFontFile(@"C:\Users\Public\Videos\preeti.ttf");
            int fontSizeForFirst = 22;
            int fontSizeForSecond = 22;
            int fontSizeForThird = 22;
            int fontSizeForFourth = 22;
            string colorCode = "#2866FA";
            byte [] newColorCode = CmykToRgb(.87,0.64,0,0.03);
            Color qwe = new Color();
            qwe = Color.FromArgb(newColorCode[0], newColorCode[1], newColorCode[2]);
            label1.Font = new Font(f.Families[0], fontSizeForFirst);
            label1_2.Font = new Font(f.Families[0], fontSizeForFirst);
            label1.BackColor = ColorTranslator.FromHtml(colorCode);
            label1_2.BackColor = ColorTranslator.FromHtml(colorCode);
            label2.Font = new Font(f.Families[0], fontSizeForSecond);
            label2_2.Font = new Font(f.Families[0], fontSizeForSecond);
            label2.BackColor = ColorTranslator.FromHtml(colorCode);
            label2_2.BackColor = ColorTranslator.FromHtml(colorCode);
            label3.Font = new Font(f.Families[0], fontSizeForThird);
            label3_2.Font = new Font(f.Families[0], fontSizeForThird);
            label3.BackColor = ColorTranslator.FromHtml(colorCode);
            label3_2.BackColor = ColorTranslator.FromHtml(colorCode);
            label4.Font = new Font(f.Families[0], fontSizeForFourth);
            label4_2.Font = new Font(f.Families[0], fontSizeForFourth);
            label4.BackColor = ColorTranslator.FromHtml(colorCode);
            label4_2.BackColor = ColorTranslator.FromHtml(colorCode);
            int noOfHeadlines = allHeadlines.Count;
            loopCount = noOfHeadlines / 4;
            if (noOfHeadlines % 4 != 0)
            {
                loopCount++;
            }
            Console.WriteLine(loopCount);
            int totalTime = noOfHeadlines * 5;
            Console.WriteLine(totalTime);
            int q = ((totalTime / 20) * 20);
            noOfSmaller = totalTime - q; 
            noOfTwentySec = q / 20;
            totalTw = noOfTwentySec;
            Console.WriteLine("20 sec " + noOfTwentySec);
            Console.WriteLine("select " + noOfSmaller);

            firstWait();
            if (loopCount == 1)
            {
                if (noOfSmaller == 5)
                {
                    noOfSmaller = noOfSmaller - 5;
                    path = "C:/Users/Public/Videos/FiveTotal.mp4";
                    int width = Screen.PrimaryScreen.Bounds.Width;
                    int height = Screen.PrimaryScreen.Bounds.Height;
                    label1.Location = new Point((width / 100) * 13, (height / 100) * 50);
                    label1_2.Location = new Point((width / 100) * 13, (height / 100) * 54);
                    removeFirstItems();

                }
                else if (noOfSmaller == 10)
                {
                    noOfSmaller = noOfSmaller - 10;
                    path = "C:/Users/Public/Videos/TenTotal.mp4";
                    int width = Screen.PrimaryScreen.Bounds.Width;
                    int height = Screen.PrimaryScreen.Bounds.Height;
                    label1.Location = new Point((width / 100) * 13, (height / 100) * 40);
                    label1_2.Location = new Point((width / 100) * 13, (height / 100) * 44);
                    label2.Location = new Point((width / 100) * 13, (height / 100) * 60);
                    label2_2.Location = new Point((width / 100) * 13, (height / 100) * 64);
                    secondWait();
                    removeSecondItems();

                }
                else if (noOfSmaller == 15)
                {
                    noOfSmaller = noOfSmaller - 15;
                    path = "C:/Users/Public/Videos/FifteenTotal.mp4";
                    int width = Screen.PrimaryScreen.Bounds.Width;
                    int height = Screen.PrimaryScreen.Bounds.Height;
                    label1.Location = new Point((width / 100) * 13, (height / 100) * 35);
                    label1_2.Location = new Point((width / 100) * 13, (height / 100) * 39);
                    label2.Location = new Point((width / 100) * 13, (height / 100) * 50);
                    label2_2.Location = new Point((width / 100) * 13, (height / 100) * 54);
                    label3.Location = new Point((width / 100) * 13, (height / 100) * 65);
                    label3_2.Location = new Point((width / 100) * 13, (height / 100) * 69);
                    secondWait();
                    thirdWait();
                    removeThirdItems();
                }
                else if (noOfSmaller == 0)
                {
                    noOfSmaller = noOfSmaller - 0;
                    path = "C:/Users/Public/Videos/FinalForm_20.mp4";
                    int width = Screen.PrimaryScreen.Bounds.Width;
                    int height = Screen.PrimaryScreen.Bounds.Height;
                    label1.Location = new Point((width / 100) * 13, (height / 100) * 30);
                    label1_2.Location = new Point((width / 100) * 13, (height / 100) * 34);
                    label2.Location = new Point((width / 100) * 13, (height / 100) * 43);
                    label2_2.Location = new Point((width / 100) * 13, (height / 100) * 47);
                    label3.Location = new Point((width / 100) * 13, (height / 100) * 56);
                    label3_2.Location = new Point((width / 100) * 13, (height / 100) * 60);
                    label4.Location = new Point((width / 100) * 13, (height / 100) * 69);
                    label4_2.Location = new Point((width / 100) * 13, (height / 100) * 73);
                    secondWait();
                    thirdWait();
                    fourthWait();
                    removeFourthItems();
                }
                axWindowsMediaPlayer1.URL = path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                StartRecord();
                axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(VideoEnd);
            }
            else
            {
                WMPLib.IWMPMedia media;
                playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("playlist");
                playlist.appendItem(axWindowsMediaPlayer1.newMedia("C:/Users/Public/Videos/Twenty_EndCut.mp4"));
                for(int i=0; i < noOfTwentySec-1; i++)
                {
                    if (i == noOfTwentySec - 1)
                    {
                        media = axWindowsMediaPlayer1.newMedia("C:/Users/Public/Videos/20_EditedEnd.mp4");
                    }
                    else
                    {
                        media = axWindowsMediaPlayer1.newMedia("C:/Users/Public/Videos/20_Edited.mp4");
                    }
                    playlist.appendItem(media);
                }
                
                if (noOfSmaller == 5)
                {
                    whichOne = 5;
                    noOfSmaller = noOfSmaller - 5;
                    media = axWindowsMediaPlayer1.newMedia("C:/Users/Public/Videos/5_EditedEnd.mp4");
                    playlist.appendItem(media);
                }
                else if (noOfSmaller == 10)
                {
                    whichOne = 10;
                    noOfSmaller = noOfSmaller - 10;
                    media = axWindowsMediaPlayer1.newMedia("C:/Users/Public/Videos/10_EditedEnd.mp4");
                    playlist.appendItem(media);
                }
                else if (noOfSmaller == 15)
                {
                    whichOne = 15;
                    noOfSmaller = noOfSmaller - 15;
                    media = axWindowsMediaPlayer1.newMedia("C:/Users/Public/Videos/15_EditedEnd.mp4");
                    playlist.appendItem(media);
                }
                else if (noOfSmaller == 0)
                {
                    whichOne = 20;
                    noOfSmaller = noOfSmaller - 0;
                }
                axWindowsMediaPlayer1.currentPlaylist = playlist;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                int width = Screen.PrimaryScreen.Bounds.Width;
                int height = Screen.PrimaryScreen.Bounds.Height;
                label1.Location = new Point((width / 100) * 13, (height / 100) * 30);
                label1_2.Location = new Point((width / 100) * 13, (height / 100) * 34);
                label2.Location = new Point((width / 100) * 13, (height / 100) * 43);
                label2_2.Location = new Point((width / 100) * 13, (height / 100) * 47);
                label3.Location = new Point((width / 100) * 13, (height / 100) * 56);
                label3_2.Location = new Point((width / 100) * 13, (height / 100) * 60);
                label4.Location = new Point((width / 100) * 13, (height / 100) * 69);
                label4_2.Location = new Point((width / 100) * 13, (height / 100) * 73);
                firstWait();
                secondWait();
                thirdWait();
                fourthWait();
                removeFourthItems();
                axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(VideoEnd);
                StartRecord();
                Console.WriteLine("P   " + playlist.count);
            }
        }
        private void VideoEnd(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                if (allHeadlinesArray.Length <= 4)
                {
                    this.Close();
                }
                else
                {
                    noOfTwentySec--;
                    Console.WriteLine("T"+noOfTwentySec);
                    if (noOfSmaller <= 0 && noOfTwentySec <= 0)
                    {
                        closeCall++;
                    }
                    if (closeCall == 1)
                    {
                        x = 1;
                        if (whichOne == 5)
                        {
                            int width = Screen.PrimaryScreen.Bounds.Width;
                            int height = Screen.PrimaryScreen.Bounds.Height;
                            label1.Location = new Point((width / 100) * 13, (height / 100) * 50);
                            label1_2.Location = new Point((width / 100) * 13, (height / 100) * 54);
                            firstWait();
                            removeFirstItems();
                        }
                        if (whichOne == 10)
                        {
                            int width = Screen.PrimaryScreen.Bounds.Width;
                            int height = Screen.PrimaryScreen.Bounds.Height;
                            label1.Location = new Point((width / 100) * 13, (height / 100) * 40);
                            label1_2.Location = new Point((width / 100) * 13, (height / 100) * 44);
                            label2.Location = new Point((width / 100) * 13, (height / 100) * 60);
                            label2_2.Location = new Point((width / 100) * 13, (height / 100) * 64);
                            firstWait();
                            secondWait();
                            removeSecondItems();
                        }
                        if (whichOne == 15)
                        {
                            int width = Screen.PrimaryScreen.Bounds.Width;
                            int height = Screen.PrimaryScreen.Bounds.Height;
                            label1.Location = new Point((width / 100) * 13, (height / 100) * 35);
                            label1_2.Location = new Point((width / 100) * 13, (height / 100) * 39);
                            label2.Location = new Point((width / 100) * 13, (height / 100) * 50);
                            label2_2.Location = new Point((width / 100) * 13, (height / 100) * 54);
                            label3.Location = new Point((width / 100) * 13, (height / 100) * 65);
                            label3_2.Location = new Point((width / 100) * 13, (height / 100) * 69);
                            firstWait();
                            secondWait();
                            thirdWait();
                            removeThirdItems();
                        }
                        if (whichOne == 20)
                        {
                            int width = Screen.PrimaryScreen.Bounds.Width;
                            int height = Screen.PrimaryScreen.Bounds.Height;
                            label1.Location = new Point((width / 100) * 13, (height / 100) * 30);
                            label1_2.Location = new Point((width / 100) * 13, (height / 100) * 34);
                            label2.Location = new Point((width / 100) * 13, (height / 100) * 43);
                            label2_2.Location = new Point((width / 100) * 13, (height / 100) * 47);
                            label3.Location = new Point((width / 100) * 13, (height / 100) * 56);
                            label3_2.Location = new Point((width / 100) * 13, (height / 100) * 60);
                            label4.Location = new Point((width / 100) * 13, (height / 100) * 69);
                            label4_2.Location = new Point((width / 100) * 13, (height / 100) * 73);
                            firstWait();
                            secondWait();
                            thirdWait();
                            fourthWait();
                            removeFourthItems();
                        }
                    }
                    if (closeCall >= 2)
                    {
                        this.Close();
                    }
                    if (closeCall == 0)
                    {
                        x = 1;
                        int width = Screen.PrimaryScreen.Bounds.Width;
                        int height = Screen.PrimaryScreen.Bounds.Height;
                        label1.Location = new Point((width / 100) * 13, (height / 100) * 30);
                        label1_2.Location = new Point((width / 100) * 13, (height / 100) * 34);
                        label2.Location = new Point((width / 100) * 13, (height / 100) * 43);
                        label2_2.Location = new Point((width / 100) * 13, (height / 100) * 47);
                        label3.Location = new Point((width / 100) * 13, (height / 100) * 56);
                        label3_2.Location = new Point((width / 100) * 13, (height / 100) * 60);
                        label4.Location = new Point((width / 100) * 13, (height / 100) * 69);
                        label4_2.Location = new Point((width / 100) * 13, (height / 100) * 73);
                        firstWait();
                        secondWait();
                        thirdWait();
                        fourthWait();
                        removeFourthItems();
                        if (noOfTwentySec == 0)
                        {
                            closeCall++;
                        }
                        else if (totalTw == loopCount)
                        {
                            closeCall++;
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        allHeadlines.RemoveFirst();
                        allSecondaryHeadlines.RemoveFirst();
                        allUrls.RemoveFirst();
                    }
                }
            }
        }

        private async void firstWait()
        {
            if (x == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            if (!allSecondaryHeadlines.ElementAt(0).Equals("NULL"))
            {
                label1_2.Text = allSecondaryHeadlines.ElementAt(0); var path22 = new System.Drawing.Drawing2D.GraphicsPath();
                path22.AddEllipse(0, 0, label1_2.Width, label1_2.Height);
                this.label1_2.Region = new Region(path22);
                label1_2.Visible = true;
            }
            else
            {
                label1.Text = allHeadlines.ElementAt(0); var path22 = new System.Drawing.Drawing2D.GraphicsPath();
                path22.AddEllipse(0, 0, label1.Width, label1.Height);
                this.label1.Region = new Region(path22);
            }
            label1.Visible = true;
            string url = allUrls.ElementAt(0).ToUpper();
            string extension = url.Substring(url.Length - 4);
            if (extension != "NULL")
            {
                if (extension == ".JPG" || extension == ".PNG" || extension == ".JPEG")
                {
                    Console.WriteLine("Image");
                    pictureBox1.Image = Image.FromFile(url);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Visible = true;
                    axWindowsMediaPlayer2.Visible = false;

                }
                if (extension == ".MOV" || extension == ".AVI" || extension == ".MP4" || extension == ".MKV")
                {
                    Console.WriteLine("Video");
                    axWindowsMediaPlayer2.URL = url;
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                    axWindowsMediaPlayer2.settings.mute = true;
                    axWindowsMediaPlayer2.Visible = true;
                    pictureBox1.Visible = false;
                }

            }
        }

        private async void secondWait()
        {
            if (x == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(8));
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(6));
            }
            int length = allHeadlines.ElementAt(1).Length;
            if (!allSecondaryHeadlines.ElementAt(1).Equals("NULL"))
            {
                label2_2.Text = allSecondaryHeadlines.ElementAt(1);
                label2_2.Visible = true;
            }
            else
            {
                label2.Text = allHeadlines.ElementAt(1);
            }
            label2.Visible = true;
            string url = allUrls.ElementAt(1).ToUpper();
            string extension = url.Substring(url.Length - 4);
            if (extension != "NULL")
            {
                if (extension == ".JPG" || extension == ".PNG" || extension == ".JPEG")
                {
                    Console.WriteLine("Image");
                    pictureBox1.Image = Image.FromFile(url);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Visible = true;
                    axWindowsMediaPlayer2.Visible = false;

                }
                if (extension == ".MOV" || extension == ".AVI" || extension == ".MP4" || extension == ".MKV")
                {
                    Console.WriteLine("Video");
                    axWindowsMediaPlayer2.URL = url;
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                    axWindowsMediaPlayer2.settings.mute = true;
                    axWindowsMediaPlayer2.Visible = true;
                    pictureBox1.Visible = false;
                }

            }
        }
        private async void thirdWait()
        {
            if (x == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(13));
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(11));
            }
            int length = allHeadlines.ElementAt(2).Length;
            if (!allSecondaryHeadlines.ElementAt(2).Equals("NULL"))
            {
                label3_2.Text = allSecondaryHeadlines.ElementAt(2);
                label3_2.Visible = true;
            }
            else
            {
                label3.Text = allHeadlines.ElementAt(2);
            }
            label3.Visible = true;
            string url = allUrls.ElementAt(2).ToUpper();
            string extension = url.Substring(url.Length - 4);
            if (extension != "NULL")
            {
                if (extension == ".JPG" || extension == ".PNG" || extension == ".JPEG")
                {
                    Console.WriteLine("Image");
                    pictureBox1.Image = Image.FromFile(url);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Visible = true;
                    axWindowsMediaPlayer2.Visible = false;

                }
                if (extension == ".MOV" || extension == ".AVI" || extension == ".MP4" || extension == ".MKV")
                {
                    Console.WriteLine("Video");
                    axWindowsMediaPlayer2.URL = url;
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                    axWindowsMediaPlayer2.settings.mute = true;
                    axWindowsMediaPlayer2.Visible = true;
                    pictureBox1.Visible = false;
                }

            }
        }
        private async void fourthWait()
        {
            if (x == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(18));
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(16));
            }
            int length = allHeadlines.ElementAt(3).Length;
            if (!allSecondaryHeadlines.ElementAt(3).Equals("NULL"))
            {
                label4_2.Text = allSecondaryHeadlines.ElementAt(3);
                label4_2.Visible = true;
            }
            else
            {
                label4.Text = allHeadlines.ElementAt(3);
            }
            label4.Visible = true;
            string url = allUrls.ElementAt(3).ToUpper();
            string extension = url.Substring(url.Length - 4);
            if (extension != "NULL")
            {
                if (extension == ".JPG" || extension == ".PNG" || extension == ".JPEG")
                {
                    Console.WriteLine("Image");
                    pictureBox1.Image = Image.FromFile(url);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Visible = true;
                    axWindowsMediaPlayer2.Visible = false;

                }
                if (extension == ".MOV" || extension == ".AVI" || extension == ".MP4" || extension == ".MKV")
                {
                    Console.WriteLine("Video");
                    axWindowsMediaPlayer2.URL = url;
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                    axWindowsMediaPlayer2.settings.mute = true;
                    axWindowsMediaPlayer2.Visible = true;
                    pictureBox1.Visible = false;
                }

            }
        }

        private async void removeFirstItems()
        {
            if (x == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(8));
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(6));
            }
            label1.Visible = false;
            label1_2.Visible = false;
            pictureBox1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
        }
        private async void removeSecondItems()
        {
            if (x == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(13));
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(11));
            }
            label2.Visible = false;
            label2_2.Visible = false;
            label1.Visible = false;
            label1_2.Visible = false;
            pictureBox1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
        }
        private async void removeThirdItems()
        {
            if (x == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(18));
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(16));
            }
            label1.Visible = false;
            label1_2.Visible = false;
            label2.Visible = false;
            label2_2.Visible = false;
            label3.Visible = false;
            label3_2.Visible = false;
            pictureBox1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
        }
        private async void removeFourthItems()
        {
            if (x == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(23));
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(21));
            }
            label2.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label2_2.Visible = false;
            label1_2.Visible = false;
            label3_2.Visible = false;
            label4_2.Visible = false;
            pictureBox1.Visible = false;
            axWindowsMediaPlayer2.Visible = false;
        }

        void StartRecord()
        {
            job = new ScreenCaptureJob();
            System.Drawing.Size WorkingArea = SystemInformation.WorkingArea.Size;
            Rectangle captureRect = new Rectangle(0, 0, WorkingArea.Width, WorkingArea.Height);
            job.CaptureRectangle = captureRect;

            job.ShowFlashingBoundary = false;
            job.ShowCountdown = false;
            job.CaptureMouseCursor = false;
            job.OutputPath = @"C:\Users\Public\Videos";
            job.ScreenCaptureVideoProfile.Quality = 95;
            var audioDevices = Microsoft.Expression.Encoder.Devices.EncoderDevices.FindDevices(Microsoft.Expression.Encoder.Devices.EncoderDeviceType.Audio);
            job.AddAudioDeviceSource(audioDevices.ElementAt(1));
            Microsoft.Expression.Encoder.Profiles.ConstantBitrate b = new Microsoft.Expression.Encoder.Profiles.ConstantBitrate(135000);
            job.ScreenCaptureVideoProfile.Bitrate = b;
            job.ScreenCaptureVideoProfile.FrameRate = 25.0;
            job.Start();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (job.Status == RecordStatus.Running)
            {
                job.Stop();
                job.Dispose();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        static byte[] CmykToRgb(double cyan, double magenta, double yellow, double black)
        {
            byte red = Convert.ToByte((1 - Math.Min(1, cyan * (1 - black) + black)) * 255);
            byte green = Convert.ToByte((1 - Math.Min(1, magenta * (1 - black) + black)) * 255);
            byte blue = Convert.ToByte((1 - Math.Min(1, yellow * (1 - black) + black)) * 255);
            return new[] { red, green, blue };
        }
    }
}
