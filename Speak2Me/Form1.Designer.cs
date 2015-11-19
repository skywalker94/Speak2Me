namespace Speak2Me
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resume = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.rateBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.speak = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.voice = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.Button();
            this.standby = new System.Windows.Forms.Label();
            this.recording = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.resume);
            this.groupBox1.Controls.Add(this.pause);
            this.groupBox1.Controls.Add(this.rateBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.volumeBar);
            this.groupBox1.Controls.Add(this.speak);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.voice);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text to Speech";
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.Black;
            this.resume.Location = new System.Drawing.Point(168, 16);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(75, 23);
            this.resume.TabIndex = 102;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Black;
            this.pause.Location = new System.Drawing.Point(87, 16);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 101;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // rateBar
            // 
            this.rateBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rateBar.LargeChange = 2;
            this.rateBar.Location = new System.Drawing.Point(460, 118);
            this.rateBar.Minimum = 1;
            this.rateBar.Name = "rateBar";
            this.rateBar.Size = new System.Drawing.Size(175, 45);
            this.rateBar.TabIndex = 11;
            this.rateBar.Value = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Volume";
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volumeBar.LargeChange = 10;
            this.volumeBar.Location = new System.Drawing.Point(54, 118);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(364, 45);
            this.volumeBar.SmallChange = 5;
            this.volumeBar.TabIndex = 8;
            this.volumeBar.Value = 70;
            // 
            // speak
            // 
            this.speak.BackColor = System.Drawing.Color.Black;
            this.speak.Location = new System.Drawing.Point(6, 16);
            this.speak.Name = "speak";
            this.speak.Size = new System.Drawing.Size(75, 23);
            this.speak.TabIndex = 7;
            this.speak.Text = "Speak";
            this.speak.UseVisualStyleBackColor = false;
            this.speak.Click += new System.EventHandler(this.speak_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(560, 89);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 42);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(629, 70);
            this.textBox.TabIndex = 4;
            // 
            // voice
            // 
            this.voice.AutoSize = true;
            this.voice.Location = new System.Drawing.Point(479, 21);
            this.voice.Name = "voice";
            this.voice.Size = new System.Drawing.Size(37, 13);
            this.voice.TabIndex = 3;
            this.voice.Text = "Voice:";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(576, 19);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 2;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(522, 19);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 1;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(398, 16);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 100;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.play);
            this.groupBox2.Controls.Add(this.stop);
            this.groupBox2.Controls.Add(this.record);
            this.groupBox2.Controls.Add(this.standby);
            this.groupBox2.Controls.Add(this.recording);
            this.groupBox2.Controls.Add(this.status);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorder";
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Black;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(430, 33);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(205, 53);
            this.play.TabIndex = 16;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Black;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(217, 33);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(207, 53);
            this.stop.TabIndex = 15;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.Color.Black;
            this.record.Image = ((System.Drawing.Image)(resources.GetObject("record.Image")));
            this.record.Location = new System.Drawing.Point(6, 33);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(205, 53);
            this.record.TabIndex = 12;
            this.record.UseVisualStyleBackColor = false;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // standby
            // 
            this.standby.AutoSize = true;
            this.standby.ForeColor = System.Drawing.Color.LimeGreen;
            this.standby.Location = new System.Drawing.Point(573, 16);
            this.standby.Name = "standby";
            this.standby.Size = new System.Drawing.Size(49, 13);
            this.standby.TabIndex = 14;
            this.standby.Text = "Stand by";
            // 
            // recording
            // 
            this.recording.AutoSize = true;
            this.recording.ForeColor = System.Drawing.Color.Red;
            this.recording.Location = new System.Drawing.Point(573, 16);
            this.recording.Name = "recording";
            this.recording.Size = new System.Drawing.Size(65, 13);
            this.recording.TabIndex = 13;
            this.recording.Text = "Recording...";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(530, 16);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(40, 13);
            this.status.TabIndex = 12;
            this.status.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(665, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(681, 330);
            this.MinimumSize = new System.Drawing.Size(681, 330);
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = " Audio Crypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar rateBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Button speak;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label voice;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label standby;
        private System.Windows.Forms.Label recording;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button pause;
    }
}

