namespace Headliner
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
            this.label_firstHeadline = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.first_headline_checkbox = new System.Windows.Forms.CheckBox();
            this.first_textfield_2 = new System.Windows.Forms.TextBox();
            this.first_path = new System.Windows.Forms.Label();
            this.first_textfield = new System.Windows.Forms.TextBox();
            this.first_mute_button = new System.Windows.Forms.Button();
            this.first_Choose_Button = new System.Windows.Forms.Button();
            this.first_Video_RadioButton = new System.Windows.Forms.RadioButton();
            this.first_Image_RadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.second_headline_checkbox = new System.Windows.Forms.CheckBox();
            this.second_textfield_2 = new System.Windows.Forms.TextBox();
            this.second_path = new System.Windows.Forms.Label();
            this.second_textfield = new System.Windows.Forms.TextBox();
            this.second_mute_button = new System.Windows.Forms.Button();
            this.second_Choose_Button = new System.Windows.Forms.Button();
            this.second_Video_RadioButton = new System.Windows.Forms.RadioButton();
            this.second_checkBox = new System.Windows.Forms.CheckBox();
            this.second_Image_RadioButton = new System.Windows.Forms.RadioButton();
            this.label_secondHeadline = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.third_headline_checkbox = new System.Windows.Forms.CheckBox();
            this.third_textfield_2 = new System.Windows.Forms.TextBox();
            this.third_path = new System.Windows.Forms.Label();
            this.third_textfield = new System.Windows.Forms.TextBox();
            this.third_mute_button = new System.Windows.Forms.Button();
            this.third_Choose_Button = new System.Windows.Forms.Button();
            this.third_Video_RadioButton = new System.Windows.Forms.RadioButton();
            this.third_checkBox = new System.Windows.Forms.CheckBox();
            this.third_Image_RadioButton = new System.Windows.Forms.RadioButton();
            this.label_thirdHeadline = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fourth_headline_checkbox = new System.Windows.Forms.CheckBox();
            this.fourth_textfield_2 = new System.Windows.Forms.TextBox();
            this.fourth_path = new System.Windows.Forms.Label();
            this.fourth_textfield = new System.Windows.Forms.TextBox();
            this.fourth_mute_button = new System.Windows.Forms.Button();
            this.fourth_Choose_Button = new System.Windows.Forms.Button();
            this.fourth_Video_RadioButton = new System.Windows.Forms.RadioButton();
            this.fourth_checkBox = new System.Windows.Forms.CheckBox();
            this.fourth_Image_RadioButton = new System.Windows.Forms.RadioButton();
            this.label_fourthHeadline = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.first_image_view = new System.Windows.Forms.PictureBox();
            this.second_image_view = new System.Windows.Forms.PictureBox();
            this.third_image_view = new System.Windows.Forms.PictureBox();
            this.fourth_image_view = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fourth_media_view = new AxWMPLib.AxWindowsMediaPlayer();
            this.third_media_view = new AxWMPLib.AxWindowsMediaPlayer();
            this.second_media_view = new AxWMPLib.AxWindowsMediaPlayer();
            this.first_media_view = new AxWMPLib.AxWindowsMediaPlayer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.first_image_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_image_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.third_image_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourth_image_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourth_media_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.third_media_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_media_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_media_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label_firstHeadline
            // 
            this.label_firstHeadline.AutoSize = true;
            this.label_firstHeadline.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstHeadline.Location = new System.Drawing.Point(12, 12);
            this.label_firstHeadline.Name = "label_firstHeadline";
            this.label_firstHeadline.Size = new System.Drawing.Size(145, 24);
            this.label_firstHeadline.TabIndex = 0;
            this.label_firstHeadline.Text = "First Headline";
            this.label_firstHeadline.Click += new System.EventHandler(this.label_firstHeadline_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.first_headline_checkbox);
            this.panel1.Controls.Add(this.first_textfield_2);
            this.panel1.Controls.Add(this.first_path);
            this.panel1.Controls.Add(this.first_textfield);
            this.panel1.Controls.Add(this.first_mute_button);
            this.panel1.Controls.Add(this.first_Choose_Button);
            this.panel1.Controls.Add(this.first_Video_RadioButton);
            this.panel1.Controls.Add(this.first_Image_RadioButton);
            this.panel1.Controls.Add(this.label_firstHeadline);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 153);
            this.panel1.TabIndex = 1;
            // 
            // first_headline_checkbox
            // 
            this.first_headline_checkbox.AutoSize = true;
            this.first_headline_checkbox.Location = new System.Drawing.Point(214, 16);
            this.first_headline_checkbox.Name = "first_headline_checkbox";
            this.first_headline_checkbox.Size = new System.Drawing.Size(95, 17);
            this.first_headline_checkbox.TabIndex = 14;
            this.first_headline_checkbox.Text = "More than 35?";
            this.first_headline_checkbox.UseVisualStyleBackColor = true;
            this.first_headline_checkbox.CheckedChanged += new System.EventHandler(this.first_headline_checkbox_CheckedChanged);
            // 
            // first_textfield_2
            // 
            this.first_textfield_2.Enabled = false;
            this.first_textfield_2.Location = new System.Drawing.Point(16, 78);
            this.first_textfield_2.MaxLength = 30;
            this.first_textfield_2.Name = "first_textfield_2";
            this.first_textfield_2.Size = new System.Drawing.Size(544, 20);
            this.first_textfield_2.TabIndex = 7;
            // 
            // first_path
            // 
            this.first_path.AutoSize = true;
            this.first_path.Location = new System.Drawing.Point(22, 130);
            this.first_path.Name = "first_path";
            this.first_path.Size = new System.Drawing.Size(35, 13);
            this.first_path.TabIndex = 6;
            this.first_path.Text = "NULL";
            this.first_path.Visible = false;
            this.first_path.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_textfield
            // 
            this.first_textfield.Location = new System.Drawing.Point(16, 39);
            this.first_textfield.MaxLength = 30;
            this.first_textfield.Name = "first_textfield";
            this.first_textfield.Size = new System.Drawing.Size(544, 20);
            this.first_textfield.TabIndex = 5;
            // 
            // first_mute_button
            // 
            this.first_mute_button.Location = new System.Drawing.Point(485, 110);
            this.first_mute_button.Name = "first_mute_button";
            this.first_mute_button.Size = new System.Drawing.Size(75, 23);
            this.first_mute_button.TabIndex = 4;
            this.first_mute_button.Text = "Unmute";
            this.first_mute_button.UseVisualStyleBackColor = true;
            this.first_mute_button.Visible = false;
            this.first_mute_button.Click += new System.EventHandler(this.first_mute_button_Click);
            // 
            // first_Choose_Button
            // 
            this.first_Choose_Button.Location = new System.Drawing.Point(378, 110);
            this.first_Choose_Button.Name = "first_Choose_Button";
            this.first_Choose_Button.Size = new System.Drawing.Size(75, 23);
            this.first_Choose_Button.TabIndex = 3;
            this.first_Choose_Button.Text = "Choose";
            this.first_Choose_Button.UseVisualStyleBackColor = true;
            this.first_Choose_Button.Click += new System.EventHandler(this.first_Choose_Button_Click);
            // 
            // first_Video_RadioButton
            // 
            this.first_Video_RadioButton.AutoSize = true;
            this.first_Video_RadioButton.Location = new System.Drawing.Point(173, 110);
            this.first_Video_RadioButton.Name = "first_Video_RadioButton";
            this.first_Video_RadioButton.Size = new System.Drawing.Size(91, 17);
            this.first_Video_RadioButton.TabIndex = 2;
            this.first_Video_RadioButton.TabStop = true;
            this.first_Video_RadioButton.Text = "Choose Video";
            this.first_Video_RadioButton.UseVisualStyleBackColor = true;
            // 
            // first_Image_RadioButton
            // 
            this.first_Image_RadioButton.AutoSize = true;
            this.first_Image_RadioButton.Location = new System.Drawing.Point(16, 110);
            this.first_Image_RadioButton.Name = "first_Image_RadioButton";
            this.first_Image_RadioButton.Size = new System.Drawing.Size(93, 17);
            this.first_Image_RadioButton.TabIndex = 1;
            this.first_Image_RadioButton.TabStop = true;
            this.first_Image_RadioButton.Text = "Choose Image";
            this.first_Image_RadioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.second_headline_checkbox);
            this.panel2.Controls.Add(this.second_textfield_2);
            this.panel2.Controls.Add(this.second_path);
            this.panel2.Controls.Add(this.second_textfield);
            this.panel2.Controls.Add(this.second_mute_button);
            this.panel2.Controls.Add(this.second_Choose_Button);
            this.panel2.Controls.Add(this.second_Video_RadioButton);
            this.panel2.Controls.Add(this.second_checkBox);
            this.panel2.Controls.Add(this.second_Image_RadioButton);
            this.panel2.Controls.Add(this.label_secondHeadline);
            this.panel2.Location = new System.Drawing.Point(12, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 160);
            this.panel2.TabIndex = 2;
            // 
            // second_headline_checkbox
            // 
            this.second_headline_checkbox.AutoSize = true;
            this.second_headline_checkbox.Enabled = false;
            this.second_headline_checkbox.Location = new System.Drawing.Point(214, 16);
            this.second_headline_checkbox.Name = "second_headline_checkbox";
            this.second_headline_checkbox.Size = new System.Drawing.Size(95, 17);
            this.second_headline_checkbox.TabIndex = 13;
            this.second_headline_checkbox.Text = "More than 35?";
            this.second_headline_checkbox.UseVisualStyleBackColor = true;
            this.second_headline_checkbox.CheckedChanged += new System.EventHandler(this.second_headline_checkbox_CheckedChanged);
            // 
            // second_textfield_2
            // 
            this.second_textfield_2.Enabled = false;
            this.second_textfield_2.Location = new System.Drawing.Point(16, 79);
            this.second_textfield_2.MaxLength = 30;
            this.second_textfield_2.Name = "second_textfield_2";
            this.second_textfield_2.Size = new System.Drawing.Size(544, 20);
            this.second_textfield_2.TabIndex = 8;
            // 
            // second_path
            // 
            this.second_path.AutoSize = true;
            this.second_path.Location = new System.Drawing.Point(22, 131);
            this.second_path.Name = "second_path";
            this.second_path.Size = new System.Drawing.Size(35, 13);
            this.second_path.TabIndex = 7;
            this.second_path.Text = "NULL";
            this.second_path.Visible = false;
            // 
            // second_textfield
            // 
            this.second_textfield.Enabled = false;
            this.second_textfield.Location = new System.Drawing.Point(16, 41);
            this.second_textfield.MaxLength = 30;
            this.second_textfield.Name = "second_textfield";
            this.second_textfield.Size = new System.Drawing.Size(544, 20);
            this.second_textfield.TabIndex = 6;
            // 
            // second_mute_button
            // 
            this.second_mute_button.Enabled = false;
            this.second_mute_button.Location = new System.Drawing.Point(485, 111);
            this.second_mute_button.Name = "second_mute_button";
            this.second_mute_button.Size = new System.Drawing.Size(75, 23);
            this.second_mute_button.TabIndex = 5;
            this.second_mute_button.Text = "Unmute";
            this.second_mute_button.UseVisualStyleBackColor = true;
            this.second_mute_button.Visible = false;
            this.second_mute_button.Click += new System.EventHandler(this.second_mute_button_Click);
            // 
            // second_Choose_Button
            // 
            this.second_Choose_Button.Enabled = false;
            this.second_Choose_Button.Location = new System.Drawing.Point(378, 111);
            this.second_Choose_Button.Name = "second_Choose_Button";
            this.second_Choose_Button.Size = new System.Drawing.Size(75, 23);
            this.second_Choose_Button.TabIndex = 4;
            this.second_Choose_Button.Text = "Choose";
            this.second_Choose_Button.UseVisualStyleBackColor = true;
            this.second_Choose_Button.Click += new System.EventHandler(this.second_Choose_Button_Click);
            // 
            // second_Video_RadioButton
            // 
            this.second_Video_RadioButton.AutoSize = true;
            this.second_Video_RadioButton.Enabled = false;
            this.second_Video_RadioButton.Location = new System.Drawing.Point(173, 111);
            this.second_Video_RadioButton.Name = "second_Video_RadioButton";
            this.second_Video_RadioButton.Size = new System.Drawing.Size(91, 17);
            this.second_Video_RadioButton.TabIndex = 4;
            this.second_Video_RadioButton.TabStop = true;
            this.second_Video_RadioButton.Text = "Choose Video";
            this.second_Video_RadioButton.UseVisualStyleBackColor = true;
            // 
            // second_checkBox
            // 
            this.second_checkBox.AutoSize = true;
            this.second_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_checkBox.Location = new System.Drawing.Point(401, 11);
            this.second_checkBox.Name = "second_checkBox";
            this.second_checkBox.Size = new System.Drawing.Size(159, 24);
            this.second_checkBox.TabIndex = 1;
            this.second_checkBox.Text = "Second Headline?";
            this.second_checkBox.UseVisualStyleBackColor = true;
            this.second_checkBox.CheckedChanged += new System.EventHandler(this.second_checkBox_CheckedChanged);
            // 
            // second_Image_RadioButton
            // 
            this.second_Image_RadioButton.AutoSize = true;
            this.second_Image_RadioButton.Enabled = false;
            this.second_Image_RadioButton.Location = new System.Drawing.Point(16, 111);
            this.second_Image_RadioButton.Name = "second_Image_RadioButton";
            this.second_Image_RadioButton.Size = new System.Drawing.Size(93, 17);
            this.second_Image_RadioButton.TabIndex = 3;
            this.second_Image_RadioButton.TabStop = true;
            this.second_Image_RadioButton.Text = "Choose Image";
            this.second_Image_RadioButton.UseVisualStyleBackColor = true;
            // 
            // label_secondHeadline
            // 
            this.label_secondHeadline.AutoSize = true;
            this.label_secondHeadline.Enabled = false;
            this.label_secondHeadline.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_secondHeadline.Location = new System.Drawing.Point(12, 9);
            this.label_secondHeadline.Name = "label_secondHeadline";
            this.label_secondHeadline.Size = new System.Drawing.Size(168, 24);
            this.label_secondHeadline.TabIndex = 0;
            this.label_secondHeadline.Text = "Second Headline";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.third_headline_checkbox);
            this.panel3.Controls.Add(this.third_textfield_2);
            this.panel3.Controls.Add(this.third_path);
            this.panel3.Controls.Add(this.third_textfield);
            this.panel3.Controls.Add(this.third_mute_button);
            this.panel3.Controls.Add(this.third_Choose_Button);
            this.panel3.Controls.Add(this.third_Video_RadioButton);
            this.panel3.Controls.Add(this.third_checkBox);
            this.panel3.Controls.Add(this.third_Image_RadioButton);
            this.panel3.Controls.Add(this.label_thirdHeadline);
            this.panel3.Location = new System.Drawing.Point(12, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 156);
            this.panel3.TabIndex = 2;
            // 
            // third_headline_checkbox
            // 
            this.third_headline_checkbox.AutoSize = true;
            this.third_headline_checkbox.Enabled = false;
            this.third_headline_checkbox.Location = new System.Drawing.Point(214, 11);
            this.third_headline_checkbox.Name = "third_headline_checkbox";
            this.third_headline_checkbox.Size = new System.Drawing.Size(95, 17);
            this.third_headline_checkbox.TabIndex = 12;
            this.third_headline_checkbox.Text = "More than 35?";
            this.third_headline_checkbox.UseVisualStyleBackColor = true;
            this.third_headline_checkbox.CheckedChanged += new System.EventHandler(this.third_headline_checkbox_CheckedChanged);
            // 
            // third_textfield_2
            // 
            this.third_textfield_2.Enabled = false;
            this.third_textfield_2.Location = new System.Drawing.Point(16, 82);
            this.third_textfield_2.MaxLength = 35;
            this.third_textfield_2.Name = "third_textfield_2";
            this.third_textfield_2.Size = new System.Drawing.Size(544, 20);
            this.third_textfield_2.TabIndex = 9;
            // 
            // third_path
            // 
            this.third_path.AutoSize = true;
            this.third_path.Location = new System.Drawing.Point(22, 134);
            this.third_path.Name = "third_path";
            this.third_path.Size = new System.Drawing.Size(35, 13);
            this.third_path.TabIndex = 8;
            this.third_path.Text = "NULL";
            this.third_path.Visible = false;
            // 
            // third_textfield
            // 
            this.third_textfield.Enabled = false;
            this.third_textfield.Location = new System.Drawing.Point(16, 43);
            this.third_textfield.MaxLength = 35;
            this.third_textfield.Name = "third_textfield";
            this.third_textfield.Size = new System.Drawing.Size(544, 20);
            this.third_textfield.TabIndex = 7;
            // 
            // third_mute_button
            // 
            this.third_mute_button.Enabled = false;
            this.third_mute_button.Location = new System.Drawing.Point(485, 111);
            this.third_mute_button.Name = "third_mute_button";
            this.third_mute_button.Size = new System.Drawing.Size(75, 23);
            this.third_mute_button.TabIndex = 6;
            this.third_mute_button.Text = "Unmute";
            this.third_mute_button.UseVisualStyleBackColor = true;
            this.third_mute_button.Visible = false;
            this.third_mute_button.Click += new System.EventHandler(this.third_mute_button_Click);
            // 
            // third_Choose_Button
            // 
            this.third_Choose_Button.Enabled = false;
            this.third_Choose_Button.Location = new System.Drawing.Point(378, 111);
            this.third_Choose_Button.Name = "third_Choose_Button";
            this.third_Choose_Button.Size = new System.Drawing.Size(75, 23);
            this.third_Choose_Button.TabIndex = 4;
            this.third_Choose_Button.Text = "Choose";
            this.third_Choose_Button.UseVisualStyleBackColor = true;
            this.third_Choose_Button.Click += new System.EventHandler(this.third_Choose_Button_Click);
            // 
            // third_Video_RadioButton
            // 
            this.third_Video_RadioButton.AutoSize = true;
            this.third_Video_RadioButton.Enabled = false;
            this.third_Video_RadioButton.Location = new System.Drawing.Point(173, 111);
            this.third_Video_RadioButton.Name = "third_Video_RadioButton";
            this.third_Video_RadioButton.Size = new System.Drawing.Size(91, 17);
            this.third_Video_RadioButton.TabIndex = 6;
            this.third_Video_RadioButton.TabStop = true;
            this.third_Video_RadioButton.Text = "Choose Video";
            this.third_Video_RadioButton.UseVisualStyleBackColor = true;
            // 
            // third_checkBox
            // 
            this.third_checkBox.AutoSize = true;
            this.third_checkBox.Enabled = false;
            this.third_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.third_checkBox.Location = new System.Drawing.Point(421, 13);
            this.third_checkBox.Name = "third_checkBox";
            this.third_checkBox.Size = new System.Drawing.Size(139, 24);
            this.third_checkBox.TabIndex = 2;
            this.third_checkBox.Text = "Third Headline?";
            this.third_checkBox.UseVisualStyleBackColor = true;
            this.third_checkBox.CheckedChanged += new System.EventHandler(this.third_checkBox_CheckedChanged);
            // 
            // third_Image_RadioButton
            // 
            this.third_Image_RadioButton.AutoSize = true;
            this.third_Image_RadioButton.Enabled = false;
            this.third_Image_RadioButton.Location = new System.Drawing.Point(16, 111);
            this.third_Image_RadioButton.Name = "third_Image_RadioButton";
            this.third_Image_RadioButton.Size = new System.Drawing.Size(93, 17);
            this.third_Image_RadioButton.TabIndex = 5;
            this.third_Image_RadioButton.TabStop = true;
            this.third_Image_RadioButton.Text = "Choose Image";
            this.third_Image_RadioButton.UseVisualStyleBackColor = true;
            // 
            // label_thirdHeadline
            // 
            this.label_thirdHeadline.AutoSize = true;
            this.label_thirdHeadline.Enabled = false;
            this.label_thirdHeadline.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thirdHeadline.Location = new System.Drawing.Point(12, 11);
            this.label_thirdHeadline.Name = "label_thirdHeadline";
            this.label_thirdHeadline.Size = new System.Drawing.Size(152, 24);
            this.label_thirdHeadline.TabIndex = 0;
            this.label_thirdHeadline.Text = "Third Headline";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.fourth_headline_checkbox);
            this.panel4.Controls.Add(this.fourth_textfield_2);
            this.panel4.Controls.Add(this.fourth_path);
            this.panel4.Controls.Add(this.fourth_textfield);
            this.panel4.Controls.Add(this.fourth_mute_button);
            this.panel4.Controls.Add(this.fourth_Choose_Button);
            this.panel4.Controls.Add(this.fourth_Video_RadioButton);
            this.panel4.Controls.Add(this.fourth_checkBox);
            this.panel4.Controls.Add(this.fourth_Image_RadioButton);
            this.panel4.Controls.Add(this.label_fourthHeadline);
            this.panel4.Location = new System.Drawing.Point(12, 490);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 157);
            this.panel4.TabIndex = 3;
            // 
            // fourth_headline_checkbox
            // 
            this.fourth_headline_checkbox.AutoSize = true;
            this.fourth_headline_checkbox.Enabled = false;
            this.fourth_headline_checkbox.Location = new System.Drawing.Point(214, 17);
            this.fourth_headline_checkbox.Name = "fourth_headline_checkbox";
            this.fourth_headline_checkbox.Size = new System.Drawing.Size(95, 17);
            this.fourth_headline_checkbox.TabIndex = 11;
            this.fourth_headline_checkbox.Text = "More than 35?";
            this.fourth_headline_checkbox.UseVisualStyleBackColor = true;
            this.fourth_headline_checkbox.CheckedChanged += new System.EventHandler(this.fourth_headline_checkbox_CheckedChanged);
            // 
            // fourth_textfield_2
            // 
            this.fourth_textfield_2.Enabled = false;
            this.fourth_textfield_2.Location = new System.Drawing.Point(7, 83);
            this.fourth_textfield_2.MaxLength = 35;
            this.fourth_textfield_2.Name = "fourth_textfield_2";
            this.fourth_textfield_2.Size = new System.Drawing.Size(544, 20);
            this.fourth_textfield_2.TabIndex = 10;
            // 
            // fourth_path
            // 
            this.fourth_path.AutoSize = true;
            this.fourth_path.Location = new System.Drawing.Point(22, 135);
            this.fourth_path.Name = "fourth_path";
            this.fourth_path.Size = new System.Drawing.Size(35, 13);
            this.fourth_path.TabIndex = 9;
            this.fourth_path.Text = "NULL";
            this.fourth_path.Visible = false;
            // 
            // fourth_textfield
            // 
            this.fourth_textfield.Enabled = false;
            this.fourth_textfield.Location = new System.Drawing.Point(7, 42);
            this.fourth_textfield.MaxLength = 35;
            this.fourth_textfield.Name = "fourth_textfield";
            this.fourth_textfield.Size = new System.Drawing.Size(544, 20);
            this.fourth_textfield.TabIndex = 8;
            // 
            // fourth_mute_button
            // 
            this.fourth_mute_button.Enabled = false;
            this.fourth_mute_button.Location = new System.Drawing.Point(485, 112);
            this.fourth_mute_button.Name = "fourth_mute_button";
            this.fourth_mute_button.Size = new System.Drawing.Size(75, 23);
            this.fourth_mute_button.TabIndex = 7;
            this.fourth_mute_button.Text = "Unmute";
            this.fourth_mute_button.UseVisualStyleBackColor = true;
            this.fourth_mute_button.Visible = false;
            this.fourth_mute_button.Click += new System.EventHandler(this.fourth_mute_button_Click);
            // 
            // fourth_Choose_Button
            // 
            this.fourth_Choose_Button.Enabled = false;
            this.fourth_Choose_Button.Location = new System.Drawing.Point(378, 112);
            this.fourth_Choose_Button.Name = "fourth_Choose_Button";
            this.fourth_Choose_Button.Size = new System.Drawing.Size(75, 23);
            this.fourth_Choose_Button.TabIndex = 7;
            this.fourth_Choose_Button.Text = "Choose";
            this.fourth_Choose_Button.UseVisualStyleBackColor = true;
            this.fourth_Choose_Button.Click += new System.EventHandler(this.fourth_Choose_Button_Click);
            // 
            // fourth_Video_RadioButton
            // 
            this.fourth_Video_RadioButton.AutoSize = true;
            this.fourth_Video_RadioButton.Enabled = false;
            this.fourth_Video_RadioButton.Location = new System.Drawing.Point(173, 115);
            this.fourth_Video_RadioButton.Name = "fourth_Video_RadioButton";
            this.fourth_Video_RadioButton.Size = new System.Drawing.Size(91, 17);
            this.fourth_Video_RadioButton.TabIndex = 8;
            this.fourth_Video_RadioButton.TabStop = true;
            this.fourth_Video_RadioButton.Text = "Choose Video";
            this.fourth_Video_RadioButton.UseVisualStyleBackColor = true;
            // 
            // fourth_checkBox
            // 
            this.fourth_checkBox.AutoSize = true;
            this.fourth_checkBox.Enabled = false;
            this.fourth_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourth_checkBox.Location = new System.Drawing.Point(421, 12);
            this.fourth_checkBox.Name = "fourth_checkBox";
            this.fourth_checkBox.Size = new System.Drawing.Size(151, 24);
            this.fourth_checkBox.TabIndex = 3;
            this.fourth_checkBox.Text = "Fourth Headline?";
            this.fourth_checkBox.UseVisualStyleBackColor = true;
            this.fourth_checkBox.CheckedChanged += new System.EventHandler(this.fourth_checkBox_CheckedChanged);
            // 
            // fourth_Image_RadioButton
            // 
            this.fourth_Image_RadioButton.AutoSize = true;
            this.fourth_Image_RadioButton.Enabled = false;
            this.fourth_Image_RadioButton.Location = new System.Drawing.Point(16, 115);
            this.fourth_Image_RadioButton.Name = "fourth_Image_RadioButton";
            this.fourth_Image_RadioButton.Size = new System.Drawing.Size(93, 17);
            this.fourth_Image_RadioButton.TabIndex = 7;
            this.fourth_Image_RadioButton.TabStop = true;
            this.fourth_Image_RadioButton.Text = "Choose Image";
            this.fourth_Image_RadioButton.UseVisualStyleBackColor = true;
            // 
            // label_fourthHeadline
            // 
            this.label_fourthHeadline.AutoSize = true;
            this.label_fourthHeadline.Enabled = false;
            this.label_fourthHeadline.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fourthHeadline.Location = new System.Drawing.Point(12, 10);
            this.label_fourthHeadline.Name = "label_fourthHeadline";
            this.label_fourthHeadline.Size = new System.Drawing.Size(165, 24);
            this.label_fourthHeadline.TabIndex = 0;
            this.label_fourthHeadline.Text = "Fourth Headline";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(516, 653);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // first_image_view
            // 
            this.first_image_view.Location = new System.Drawing.Point(597, 12);
            this.first_image_view.Name = "first_image_view";
            this.first_image_view.Size = new System.Drawing.Size(225, 144);
            this.first_image_view.TabIndex = 5;
            this.first_image_view.TabStop = false;
            this.first_image_view.Visible = false;
            // 
            // second_image_view
            // 
            this.second_image_view.Location = new System.Drawing.Point(597, 162);
            this.second_image_view.Name = "second_image_view";
            this.second_image_view.Size = new System.Drawing.Size(225, 144);
            this.second_image_view.TabIndex = 6;
            this.second_image_view.TabStop = false;
            this.second_image_view.Visible = false;
            // 
            // third_image_view
            // 
            this.third_image_view.Location = new System.Drawing.Point(597, 312);
            this.third_image_view.Name = "third_image_view";
            this.third_image_view.Size = new System.Drawing.Size(225, 144);
            this.third_image_view.TabIndex = 7;
            this.third_image_view.TabStop = false;
            this.third_image_view.Visible = false;
            // 
            // fourth_image_view
            // 
            this.fourth_image_view.Location = new System.Drawing.Point(597, 462);
            this.fourth_image_view.Name = "fourth_image_view";
            this.fourth_image_view.Size = new System.Drawing.Size(225, 144);
            this.fourth_image_view.TabIndex = 8;
            this.fourth_image_view.TabStop = false;
            this.fourth_image_view.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Choose Font";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(93, 653);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save Headlines";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(421, 653);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(89, 23);
            this.loadButton.TabIndex = 15;
            this.loadButton.Text = "Load Medias";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save Medias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 653);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Load Headlines";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fourth_media_view
            // 
            this.fourth_media_view.Enabled = true;
            this.fourth_media_view.Location = new System.Drawing.Point(597, 490);
            this.fourth_media_view.Name = "fourth_media_view";
            this.fourth_media_view.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fourth_media_view.OcxState")));
            this.fourth_media_view.Size = new System.Drawing.Size(225, 157);
            this.fourth_media_view.TabIndex = 12;
            this.fourth_media_view.Visible = false;
            // 
            // third_media_view
            // 
            this.third_media_view.Enabled = true;
            this.third_media_view.Location = new System.Drawing.Point(597, 328);
            this.third_media_view.Name = "third_media_view";
            this.third_media_view.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("third_media_view.OcxState")));
            this.third_media_view.Size = new System.Drawing.Size(225, 156);
            this.third_media_view.TabIndex = 11;
            this.third_media_view.Visible = false;
            // 
            // second_media_view
            // 
            this.second_media_view.Enabled = true;
            this.second_media_view.Location = new System.Drawing.Point(597, 162);
            this.second_media_view.Name = "second_media_view";
            this.second_media_view.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("second_media_view.OcxState")));
            this.second_media_view.Size = new System.Drawing.Size(225, 160);
            this.second_media_view.TabIndex = 10;
            this.second_media_view.Visible = false;
            // 
            // first_media_view
            // 
            this.first_media_view.Enabled = true;
            this.first_media_view.Location = new System.Drawing.Point(597, 3);
            this.first_media_view.Name = "first_media_view";
            this.first_media_view.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("first_media_view.OcxState")));
            this.first_media_view.Size = new System.Drawing.Size(225, 153);
            this.first_media_view.TabIndex = 9;
            this.first_media_view.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(834, 688);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fourth_media_view);
            this.Controls.Add(this.third_media_view);
            this.Controls.Add(this.second_media_view);
            this.Controls.Add(this.first_media_view);
            this.Controls.Add(this.fourth_image_view);
            this.Controls.Add(this.third_image_view);
            this.Controls.Add(this.second_image_view);
            this.Controls.Add(this.first_image_view);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Form1";
            this.Text = "Mega TV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.first_image_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_image_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.third_image_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourth_image_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourth_media_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.third_media_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second_media_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_media_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_firstHeadline;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_secondHeadline;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_thirdHeadline;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_fourthHeadline;
        private System.Windows.Forms.CheckBox second_checkBox;
        private System.Windows.Forms.CheckBox third_checkBox;
        private System.Windows.Forms.CheckBox fourth_checkBox;
        private System.Windows.Forms.RadioButton first_Video_RadioButton;
        private System.Windows.Forms.RadioButton first_Image_RadioButton;
        private System.Windows.Forms.RadioButton second_Video_RadioButton;
        private System.Windows.Forms.RadioButton second_Image_RadioButton;
        private System.Windows.Forms.RadioButton third_Video_RadioButton;
        private System.Windows.Forms.RadioButton third_Image_RadioButton;
        private System.Windows.Forms.RadioButton fourth_Video_RadioButton;
        private System.Windows.Forms.RadioButton fourth_Image_RadioButton;
        private System.Windows.Forms.Button first_Choose_Button;
        private System.Windows.Forms.Button second_Choose_Button;
        private System.Windows.Forms.Button third_Choose_Button;
        private System.Windows.Forms.Button fourth_Choose_Button;
        private System.Windows.Forms.Button first_mute_button;
        private System.Windows.Forms.Button second_mute_button;
        private System.Windows.Forms.Button third_mute_button;
        private System.Windows.Forms.Button fourth_mute_button;
        private System.Windows.Forms.TextBox first_textfield;
        private System.Windows.Forms.TextBox second_textfield;
        private System.Windows.Forms.TextBox third_textfield;
        private System.Windows.Forms.TextBox fourth_textfield;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.PictureBox first_image_view;
        private System.Windows.Forms.PictureBox second_image_view;
        private System.Windows.Forms.PictureBox third_image_view;
        private System.Windows.Forms.PictureBox fourth_image_view;
        private AxWMPLib.AxWindowsMediaPlayer first_media_view;
        private AxWMPLib.AxWindowsMediaPlayer second_media_view;
        private AxWMPLib.AxWindowsMediaPlayer third_media_view;
        private AxWMPLib.AxWindowsMediaPlayer fourth_media_view;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label first_path;
        private System.Windows.Forms.Label second_path;
        private System.Windows.Forms.Label third_path;
        private System.Windows.Forms.Label fourth_path;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fourth_textfield_2;
        private System.Windows.Forms.CheckBox fourth_headline_checkbox;
        private System.Windows.Forms.CheckBox first_headline_checkbox;
        private System.Windows.Forms.TextBox first_textfield_2;
        private System.Windows.Forms.CheckBox second_headline_checkbox;
        private System.Windows.Forms.TextBox second_textfield_2;
        private System.Windows.Forms.CheckBox third_headline_checkbox;
        private System.Windows.Forms.TextBox third_textfield_2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

