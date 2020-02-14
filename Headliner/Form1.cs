using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Headliner
{
    public partial class Form1 : Form
    {
        LinkedList<String> allHeadlines = new LinkedList<string>();
        LinkedList<String> secondaryHeadlines = new LinkedList<string>();
        LinkedList<String> headlineUrls = new LinkedList<string>();
        LinkedList<Font> fontUsed = new LinkedList<Font>();
        public Form1()
        {
            InitializeComponent();
            PrivateFontCollection f = new PrivateFontCollection();
            f.AddFontFile(@"C:\Users\Public\Videos\preeti.ttf");
            first_textfield.Font = new Font(f.Families[0], 14);
            first_textfield_2.Font = new Font(f.Families[0], 14);
            second_textfield.Font = new Font(f.Families[0], 14);
            second_textfield_2.Font = new Font(f.Families[0], 14);
            third_textfield.Font = new Font(f.Families[0], 14);
            third_textfield_2.Font = new Font(f.Families[0], 14);
            fourth_textfield.Font = new Font(f.Families[0], 14);
            fourth_textfield_2.Font = new Font(f.Families[0], 14);
        }

        private void label_firstHeadline_Click(object sender, EventArgs e)
        {

        }

        private void checkForCheckBoxClick()
        {
            if (second_checkBox.Checked)
            {
                forSecondCheckBox(true);
            }
            if (!second_checkBox.Checked)
            {
                forSecondCheckBox(false);
                third_checkBox.Checked = false;
                fourth_checkBox.Checked = false;
            }
            if (third_checkBox.Checked)
            {
                forThirdCheckBox(true);
            }
            if (!third_checkBox.Checked)
            {
                forThirdCheckBox(false);
                fourth_checkBox.Checked = false;
            }
            if (fourth_checkBox.Checked)
            {
                forFourthCheckBox(true);
            }
            if (!fourth_checkBox.Checked)
            {
                forFourthCheckBox(false);
            }
        }

        private void second_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            checkForCheckBoxClick();
        }

        private void third_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            checkForCheckBoxClick();
        }
        
        private void fourth_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            checkForCheckBoxClick();
        }

        private void forSecondCheckBox(Boolean status)
        {
            label_secondHeadline.Enabled = status;
            second_headline_checkbox.Enabled = status;
            second_textfield.Enabled = status;
            second_Image_RadioButton.Enabled = status;
            second_Video_RadioButton.Enabled = status;
            second_Choose_Button.Enabled = status;
            second_mute_button.Enabled = status;
            third_checkBox.Enabled = status;
        }
        private void forThirdCheckBox(Boolean status)
        {
            label_thirdHeadline.Enabled = status;
            third_textfield.Enabled = status;
            third_headline_checkbox.Enabled = status;
            third_Image_RadioButton.Enabled = status;
            third_Video_RadioButton.Enabled = status;
            third_Choose_Button.Enabled = status;
            third_mute_button.Enabled = status;
            fourth_checkBox.Enabled = status;
        }
        private void forFourthCheckBox(Boolean status)
        {
            label_fourthHeadline.Enabled = status;
            fourth_textfield.Enabled = status;
            fourth_headline_checkbox.Enabled = status;
            fourth_Image_RadioButton.Enabled = status;
            fourth_Video_RadioButton.Enabled = status;
            fourth_Choose_Button.Enabled = status;
            fourth_mute_button.Enabled = status;
        }

        private void first_Choose_Button_Click(object sender, EventArgs e)
        {
            if (first_Image_RadioButton.Checked == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".jpeg")
                    {
                        first_media_view.Ctlcontrols.stop();
                        first_media_view.Visible = false;
                        first_image_view.Image = Image.FromFile(path);
                        first_image_view.SizeMode = PictureBoxSizeMode.StretchImage;
                        first_image_view.Visible = true;
                        first_mute_button.Visible = false;
                        first_path.Text = path;
                        first_path.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You must choose a valid image file.", "Choose Image.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (first_Video_RadioButton.Checked == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension == ".mov" || fileExtension == ".avi" || fileExtension == ".mp4" || fileExtension == ".mkv")
                    {
                        first_image_view.Visible = false;
                        first_media_view.URL = path;
                        first_media_view.Ctlcontrols.play();
                        first_media_view.uiMode = "none";
                        first_media_view.Visible = true;
                        first_media_view.settings.mute = true;
                        first_mute_button.Visible = true;
                        first_path.Text = path;
                        first_path.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You must choose a valid video file.", "Choose Video.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose Either Image or Video", "Choose!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void second_Choose_Button_Click(object sender, EventArgs e)
        {
            if (second_Image_RadioButton.Checked == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".jpeg")
                    {
                        second_media_view.Ctlcontrols.stop();
                        second_media_view.Visible = false;
                        second_image_view.Image = Image.FromFile(path);
                        second_image_view.SizeMode = PictureBoxSizeMode.StretchImage;
                        second_image_view.Visible = true;
                        second_mute_button.Visible = false;
                        second_path.Text = path;
                        second_path.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You must choose a valid image file.", "Choose Image.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (second_Video_RadioButton.Checked == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension == ".mov" || fileExtension == ".avi" || fileExtension == ".mp4" || fileExtension == ".mkv")
                    {
                        second_image_view.Visible = false;
                        second_media_view.URL = path;
                        second_media_view.Ctlcontrols.play();
                        second_media_view.uiMode = "none";
                        second_media_view.Visible = true;
                        second_media_view.settings.mute = true;
                        second_mute_button.Visible = true;
                        second_path.Text = path;
                        second_path.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You must choose a valid video file.", "Choose Video.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose Either Image or Video", "Choose!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void third_Choose_Button_Click(object sender, EventArgs e)
        {
            if (third_Image_RadioButton.Checked == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".jpeg")
                    {
                        third_media_view.Ctlcontrols.stop();
                        third_media_view.Visible = false;
                        third_image_view.Image = Image.FromFile(path);
                        third_image_view.SizeMode = PictureBoxSizeMode.StretchImage;
                        third_image_view.Visible = true;
                        third_mute_button.Visible = false;
                        third_path.Text = path;
                        third_path.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You must choose a valid image file.", "Choose Image.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (third_Video_RadioButton.Checked == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension == ".mov" || fileExtension == ".avi" || fileExtension == ".mp4" || fileExtension == ".mkv")
                    {
                        third_image_view.Visible = false;
                        third_media_view.URL = path;
                        third_media_view.Ctlcontrols.play();
                        third_media_view.uiMode = "none";
                        third_media_view.Visible = true;
                        third_media_view.settings.mute = true;
                        third_mute_button.Visible = true;
                        third_path.Text = path;
                        third_path.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You must choose a valid video file.", "Choose Video.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose Either Image or Video", "Choose!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void fourth_Choose_Button_Click(object sender, EventArgs e)
        {
            if (fourth_Image_RadioButton.Checked == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".jpeg")
                    {
                        fourth_media_view.Ctlcontrols.stop();
                        fourth_media_view.Visible = false;
                        fourth_image_view.Image = Image.FromFile(path);
                        fourth_image_view.SizeMode = PictureBoxSizeMode.StretchImage;
                        fourth_image_view.Visible = true;
                        fourth_mute_button.Visible = false;
                        fourth_path.Text = path;
                        fourth_path.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You must choose a valid image file.", "Choose Image.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (fourth_Video_RadioButton.Checked == true)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension == ".mov" || fileExtension == ".avi" || fileExtension == ".mp4" || fileExtension == ".mkv")
                    {
                        fourth_image_view.Visible = false;
                        fourth_media_view.URL = path;
                        fourth_media_view.Ctlcontrols.play();
                        fourth_media_view.uiMode = "none";
                        fourth_media_view.Visible = true;
                        fourth_media_view.settings.mute = true;
                        fourth_mute_button.Visible = true;
                        fourth_path.Text = path;
                        fourth_path.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You must choose a valid video file.", "Choose Video.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose Either Image or Video", "Choose!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void first_mute_button_Click(object sender, EventArgs e)
        {
            if (first_mute_button.Text == "Unmute")
            {
                first_media_view.settings.mute = false;
                first_mute_button.Text = "Mute";
            }
            else
            {
                first_media_view.settings.mute = true;
                first_mute_button.Text = "Unmute";
            }
        }

        private void second_mute_button_Click(object sender, EventArgs e)
        {

            if (second_mute_button.Text == "Unmute")
            {
                second_media_view.settings.mute = false;
                second_mute_button.Text = "Mute";
            }
            else
            {
                second_media_view.settings.mute = true;
                second_mute_button.Text = "Unmute";
            }
        }

        private void third_mute_button_Click(object sender, EventArgs e)
        {
            if (third_mute_button.Text == "Unmute")
            {
                third_media_view.settings.mute = false;
                third_mute_button.Text = "Mute";
            }
            else
            {
                third_media_view.settings.mute = true;
                third_mute_button.Text = "Unmute";
            }
        }

        private void fourth_mute_button_Click(object sender, EventArgs e)
        {
            if (fourth_mute_button.Text == "Unmute")
            {
                fourth_media_view.settings.mute = false;
                fourth_mute_button.Text = "Mute";
            }
            else
            {
                fourth_media_view.settings.mute = true;
                fourth_mute_button.Text = "Unmute";
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            string firstHeadline = first_textfield.Text;
            if (string.IsNullOrWhiteSpace(firstHeadline))
            {
                MessageBox.Show("Enter something as your first headline.", "Enter in the first textfield.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                allHeadlines.AddLast(firstHeadline);
                if (first_headline_checkbox.Checked == true)
                {
                    secondaryHeadlines.AddLast(first_textfield_2.Text);
                }
                else
                {
                    secondaryHeadlines.AddLast("NULL");
                }
                if (first_path.Visible == true)
                {
                    headlineUrls.AddLast(first_path.Text);
                }
                else
                {
                    headlineUrls.AddLast("NULL");
                }
                if (second_checkBox.Checked)
                {
                    string secondHeadline = second_textfield.Text;
                    if (string.IsNullOrWhiteSpace(secondHeadline))
                    {
                        MessageBox.Show("Enter something as your second headline.", "Enter in the second textfield.", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    }
                    else
                    {
                        allHeadlines.AddLast(secondHeadline);
                        if (second_headline_checkbox.Checked == true)
                        {
                            secondaryHeadlines.AddLast(second_textfield_2.Text);
                        }
                        else
                        {
                            secondaryHeadlines.AddLast("NULL");
                        }
                        if (second_path.Visible == true)
                        {
                            headlineUrls.AddLast(second_path.Text);
                        }
                        else
                        {
                            headlineUrls.AddLast("NULL");
                        }
                        if (third_checkBox.Checked)
                        {
                            string thirdHeadline = third_textfield.Text;
                            if (string.IsNullOrWhiteSpace(thirdHeadline))
                            {
                                MessageBox.Show("Enter something as your third headline.", "Enter in the third textfield.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                allHeadlines.AddLast(thirdHeadline);

                                if (third_headline_checkbox.Checked == true)
                                {
                                    secondaryHeadlines.AddLast(third_textfield_2.Text);
                                }
                                else
                                {
                                    secondaryHeadlines.AddLast("NULL");
                                }
                                if (third_path.Visible == true)
                                {
                                    headlineUrls.AddLast(third_path.Text);
                                }
                                else
                                {
                                    headlineUrls.AddLast("NULL");
                                }
                                if (fourth_checkBox.Checked)
                                {
                                    string fourthHeadline = fourth_textfield.Text;
                                    if (string.IsNullOrWhiteSpace(fourthHeadline))
                                    {
                                        MessageBox.Show("Enter something as your fourth headline.", "Enter in the fourth textfield.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        allHeadlines.AddLast(fourthHeadline);
                                        if (fourth_headline_checkbox.Checked == true)
                                        {
                                            secondaryHeadlines.AddLast(fourth_textfield_2.Text);
                                        }
                                        else
                                        {
                                            secondaryHeadlines.AddLast("NULL");
                                        }
                                        if (fourth_path.Visible == true)
                                        {
                                            headlineUrls.AddLast(fourth_path.Text);
                                        }
                                        else
                                        {
                                            headlineUrls.AddLast("NULL");
                                        }
                                        var result = MessageBox.Show("Do you have any more headlines??", "Any More?", MessageBoxButtons.YesNo);
                                        if(result == DialogResult.Yes)
                                        {
                                            PuttingMedia();
                                            restartHeadlines();
                                        }
                                        else
                                        {
                                            PuttingMedia();
                                            NextPage();
                                        }
                                    }
                                }
                                else
                                {
                                    PuttingMedia();
                                    NextPage();
                                }
                            }
                        }
                        else
                        {
                            PuttingMedia();
                            NextPage();
                        }
                    }
                }
                else
                {
                    PuttingMedia();
                    NextPage();
                }
            }
        }

        private void PuttingMedia()
        {
            string path = @"C:\Windows\Temp\mediaUrls.txt";
            using (StreamWriter file = new StreamWriter(path))
                foreach (var entry in headlineUrls)
                    file.WriteLine(entry);

            string path2 = @"C:\Windows\Temp\headlines.txt";
            using (StreamWriter file2 = new StreamWriter(path2))
                foreach (var entry2 in allHeadlines)
                    file2.WriteLine(entry2);

            string path3 = @"C:\Windows\Temp\headlinerSettings.txt";
            using (StreamWriter file3 = new StreamWriter(path3))
                foreach (var entry3 in fontUsed)
                    file3.WriteLine(entry3);

            string path4 = @"C:\Windows\Temp\SecondaryHeadlines.txt";
            using (StreamWriter file4 = new StreamWriter(path4))
                foreach (var entry4 in secondaryHeadlines)
                    file4.WriteLine(entry4);

        }
        private void NextPage()
        {
            this.Hide();
            FullScreen fullScreen = new FullScreen();
            Image newImage = Image.FromFile(@"C:\Users\Public\Videos\12.png");
            fullScreen.BackgroundImage = newImage;
            fullScreen.ShowDialog();
            this.Close();
        }

        private void restartHeadlines()
        {
            first_textfield.Text = "";
            first_textfield_2.Text = "";
            second_textfield_2.Text = "";
            third_textfield_2.Text = "";
            fourth_textfield_2.Text = "";
            second_textfield.Text = "";
            third_textfield.Text = "";
            fourth_textfield.Text = "";
            first_headline_checkbox.Checked = false;
            second_headline_checkbox.Checked = false;
            third_headline_checkbox.Checked = false;
            fourth_headline_checkbox.Checked = false;
            first_Image_RadioButton.Checked = false;
            second_Image_RadioButton.Checked = false;
            third_Image_RadioButton.Checked = false;
            fourth_Image_RadioButton.Checked = false;
            first_Video_RadioButton.Checked = false;
            second_Video_RadioButton.Checked = false;
            third_Video_RadioButton.Checked = false;
            fourth_Video_RadioButton.Checked = false;
            second_checkBox.Checked = false;
            first_image_view.Visible = false;
            second_image_view.Visible = false;
            third_image_view.Visible = false;
            fourth_image_view.Visible = false;
            first_media_view.Visible = false;
            second_media_view.Visible = false;
            third_media_view.Visible = false;
            fourth_media_view.Visible = false;
            first_media_view.settings.mute = true;
            second_media_view.settings.mute = true;
            third_media_view.settings.mute = true;
            fourth_media_view.settings.mute = true;
            first_media_view.Ctlcontrols.stop();
            second_media_view.Ctlcontrols.stop();
            third_media_view.Ctlcontrols.stop();
            fourth_media_view.Ctlcontrols.stop();
            first_path.Visible = false;
            second_path.Visible = false;
            third_path.Visible = false;
            fourth_path.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = fontDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                fontUsed.AddLast(font);
                if (fontUsed.Count >= 2)
                {
                    fontUsed.RemoveFirst();
                }
                first_textfield.Font = new Font(font.FontFamily, 12);
                second_textfield.Font = new Font(font.FontFamily, 12); 
                third_textfield.Font = new Font(font.FontFamily, 12);
                fourth_textfield.Font = new Font(font.FontFamily, 12); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string dialogpath = "";
        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult saveResult = saveFileDialog1.ShowDialog();
            if(saveResult == DialogResult.OK)
            {
                dialogpath = saveFileDialog1.FileName;
                try
                {
                    LinkedList<String> allSavingHeadlines = new LinkedList<string>();
                    string firstHeadline = first_textfield.Text;
                    if (!string.IsNullOrWhiteSpace(firstHeadline))
                    {
                        allSavingHeadlines.AddLast(firstHeadline);
                        if (second_checkBox.Checked)
                        {
                            string secondHeadline = second_textfield.Text;
                            if (!string.IsNullOrWhiteSpace(secondHeadline))
                            {
                                allSavingHeadlines.AddLast(secondHeadline);
                                if (third_checkBox.Checked)
                                {
                                    string thirdHeadline = third_textfield.Text;
                                    if (!string.IsNullOrWhiteSpace(thirdHeadline))
                                    {
                                        allSavingHeadlines.AddLast(thirdHeadline);
                                        if (fourth_checkBox.Checked)
                                        {
                                            string fourthHeadline = fourth_textfield.Text;
                                            if (!string.IsNullOrWhiteSpace(fourthHeadline))
                                            {
                                                allSavingHeadlines.AddLast(fourthHeadline);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    using (StreamWriter file = new StreamWriter(dialogpath))
                        foreach (var entry in allSavingHeadlines)
                            file.WriteLine(entry);

                }
                catch(IOException ioe)
                {
                    MessageBox.Show("Error while saving file.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult saveResult = saveFileDialog1.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                dialogpath = saveFileDialog1.FileName;
                try
                {
                    LinkedList<String> allSavingUrls = new LinkedList<string>();
                    if (first_path.Visible == true)
                    {
                        allSavingUrls.AddLast(first_path.Text);
                    }
                    else
                    {
                        allSavingUrls.AddLast("NULL");
                    }
                    if (second_path.Visible == true)
                    {
                        allSavingUrls.AddLast(second_path.Text);
                    }
                    else
                    {
                        allSavingUrls.AddLast("NULL");
                    }
                    if (third_path.Visible == true)
                    {
                        allSavingUrls.AddLast(third_path.Text);
                    }
                    else
                    {
                        allSavingUrls.AddLast("NULL");
                    }
                    if (fourth_path.Visible == true)
                    {
                        allSavingUrls.AddLast(fourth_path.Text);
                    }
                    else
                    {
                        allSavingUrls.AddLast("NULL");
                    }

                    using (StreamWriter file = new StreamWriter(dialogpath))
                        foreach (var entry in allSavingUrls)
                            file.WriteLine(entry);

                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error while saving file.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                dialogpath = openFileDialog1.FileName;
                try
                {
                    LinkedList<String> openingHeadlines = new LinkedList<string>();
                    string[] content = System.IO.File.ReadAllLines(dialogpath);
                    foreach (string line in content)
                    {
                        openingHeadlines.AddLast(line);
                    }
                    if (openingHeadlines.Count == 4)
                    {
                        second_checkBox.Checked = true;
                        third_checkBox.Checked = true;
                        fourth_checkBox.Checked = true;
                        first_textfield.Text = openingHeadlines.ElementAt(0);
                        second_textfield.Text = openingHeadlines.ElementAt(1);
                        third_textfield.Text = openingHeadlines.ElementAt(2);
                        fourth_textfield.Text = openingHeadlines.ElementAt(3);
                    }
                    else if (openingHeadlines.Count == 3)
                    {
                        second_checkBox.Checked = true;
                        third_checkBox.Checked = true;
                        first_textfield.Text = openingHeadlines.ElementAt(0);
                        second_textfield.Text = openingHeadlines.ElementAt(1);
                        third_textfield.Text = openingHeadlines.ElementAt(2);
                    }
                    else if(openingHeadlines.Count == 2)
                    {
                        second_checkBox.Checked = true;
                        first_textfield.Text = openingHeadlines.ElementAt(0);
                        second_textfield.Text = openingHeadlines.ElementAt(1);
                    }
                    else if(openingHeadlines.Count == 1)
                    {
                        first_textfield.Text = openingHeadlines.ElementAt(0);
                    }
                }
                catch(IOException ioe)
                {
                    MessageBox.Show("Error while loading file.");
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                dialogpath = openFileDialog1.FileName;
                try
                {
                    LinkedList<String> openingUrls = new LinkedList<string>();
                    string[] content = System.IO.File.ReadAllLines(dialogpath);
                    foreach (string line in content)
                    {
                        openingUrls.AddLast(line);
                    }
                    first_media_view.uiMode = "none";
                    second_media_view.uiMode = "none";
                    third_media_view.uiMode = "none";
                    fourth_media_view.uiMode = "none";
                    if (openingUrls.Count == 4)
                    {
                        if (openingUrls.ElementAt(0) != "NULL")
                        {
                            first_path.Text = openingUrls.ElementAt(0);
                            first_path.Visible = true;
                            string firstPath = first_path.Text.ToUpper();
                            string extension = firstPath.Substring(firstPath.Length - 4);
                            if (extension == ".JPG" || extension == ".PNG" || extension == ".JPEG" || extension == ".W")
                            {
                                first_image_view.Image = Image.FromFile(first_path.Text);
                                first_image_view.SizeMode = PictureBoxSizeMode.StretchImage;
                                first_image_view.Visible = true;
                                first_media_view.Visible = false;
                            }
                            else if (extension == ".MOV" || extension == ".AVI" || extension == ".MP4" || extension == ".MKV" || extension == ".WEBM")
                            {
                                first_media_view.URL = first_path.Text;
                                first_media_view.Ctlcontrols.play();
                                first_media_view.settings.mute = true;
                                first_media_view.Visible = true;
                                first_image_view.Visible = false;
                                first_mute_button.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Error while loading file.");
                            }

                            if (openingUrls.ElementAt(1) != "NULL")
                            {
                                second_path.Text = openingUrls.ElementAt(1);
                                second_path.Visible = true;
                                second_checkBox.Checked = true;

                                string secondPath = second_path.Text.ToUpper();
                                string extension2 = secondPath.Substring(secondPath.Length - 4);
                                if (extension2 == ".JPG" || extension2 == ".PNG" || extension2 == ".JPEG")
                                {
                                    second_image_view.Image = Image.FromFile(second_path.Text);
                                    second_image_view.SizeMode = PictureBoxSizeMode.StretchImage;
                                    second_image_view.Visible = true;
                                    second_media_view.Visible = false;
                                }
                                else if (extension2 == ".MOV" || extension2 == ".AVI" || extension2 == ".MP4" || extension2 == ".MKV")
                                {
                                    second_media_view.URL = second_path.Text;
                                    second_media_view.Ctlcontrols.play();
                                    second_media_view.settings.mute = true;
                                    second_media_view.Visible = true;
                                    second_media_view.Visible = false;
                                    second_mute_button.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show("Error while loading file.");
                                }
                                if (openingUrls.ElementAt(2) != "NULL")
                                {
                                    third_path.Text = openingUrls.ElementAt(2);
                                    third_path.Visible = true;
                                    third_checkBox.Checked = true;

                                    string thirdPath = third_path.Text.ToUpper();
                                    string extension3 = thirdPath.Substring(thirdPath.Length - 4);
                                    if (extension3 == ".JPG" || extension3 == ".PNG" || extension3 == ".JPEG")
                                    {
                                        third_image_view.Image = Image.FromFile(third_path.Text);
                                        third_image_view.SizeMode = PictureBoxSizeMode.StretchImage;
                                        third_image_view.Visible = true;
                                        third_media_view.Visible = false;
                                    }
                                    else if (extension3 == ".MOV" || extension3 == ".AVI" || extension3 == ".MP4" || extension3 == ".MKV")
                                    {
                                        third_media_view.URL = third_path.Text;
                                        third_media_view.Ctlcontrols.play();
                                        third_media_view.settings.mute = true;
                                        third_media_view.Visible = true;
                                        third_image_view.Visible = false;
                                        third_mute_button.Visible = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error while loading file.");
                                    }
                                    if (openingUrls.ElementAt(3) != "NULL")
                                    {
                                        fourth_path.Text = openingUrls.ElementAt(3);
                                        fourth_path.Visible = true;
                                        fourth_checkBox.Checked = true;

                                        string fourthPath = fourth_path.Text.ToUpper();
                                        string extension4 = thirdPath.Substring(fourthPath.Length - 4);
                                        if (extension4 == ".JPG" || extension4 == ".PNG" || extension4 == ".JPEG")
                                        {
                                            fourth_image_view.Image = Image.FromFile(fourth_path.Text);
                                            fourth_image_view.SizeMode = PictureBoxSizeMode.StretchImage;
                                            fourth_image_view.Visible = true;
                                            fourth_media_view.Visible = false;
                                        }
                                        else if (extension4 == ".MOV" || extension4 == ".AVI" || extension4 == ".MP4" || extension4 == ".MKV")
                                        {
                                            fourth_media_view.URL = fourth_path.Text;
                                            fourth_media_view.Ctlcontrols.play();
                                            fourth_media_view.settings.mute = true;
                                            fourth_media_view.Visible = true;
                                            fourth_image_view.Visible = false;
                                            fourth_mute_button.Visible = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error while loading file.");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error while loading file.");
                    }

                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error while loading file.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void first_headline_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (first_headline_checkbox.Checked == true)
            {
                first_textfield_2.Enabled = true;
            }
            else
            {
                first_textfield_2.Enabled = false;
            }
        }

        private void second_headline_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (second_headline_checkbox.Checked == true)
            {
                second_textfield_2.Enabled = true;
            }
            else
            {
                second_textfield_2.Enabled = false;
            }
        }

        private void third_headline_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (third_headline_checkbox.Checked == true)
            {
                third_textfield_2.Enabled = true;
            }
            else
            {
                third_textfield_2.Enabled = false;
            }
        }

        private void fourth_headline_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (fourth_headline_checkbox.Checked == true)
            {
                fourth_textfield_2.Enabled = true;
            }
            else
            {
                fourth_textfield_2.Enabled = false;
            }
        }
    }
}
