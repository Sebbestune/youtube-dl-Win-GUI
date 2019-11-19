namespace VidMp3Downloader
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
            this.components = new System.ComponentModel.Container();
            this.titleLable = new System.Windows.Forms.Label();
            this.videoRadioButton = new System.Windows.Forms.RadioButton();
            this.mp3RadioButton = new System.Windows.Forms.RadioButton();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLable = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.disclaimerLable = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.configuration_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(12, 86);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(241, 24);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Video / Mp3 Downloader";
            // 
            // videoRadioButton
            // 
            this.videoRadioButton.AutoSize = true;
            this.videoRadioButton.Location = new System.Drawing.Point(16, 45);
            this.videoRadioButton.Name = "videoRadioButton";
            this.videoRadioButton.Size = new System.Drawing.Size(52, 17);
            this.videoRadioButton.TabIndex = 1;
            this.videoRadioButton.TabStop = true;
            this.videoRadioButton.Text = "Video";
            this.videoRadioButton.UseVisualStyleBackColor = true;
            // 
            // mp3RadioButton
            // 
            this.mp3RadioButton.AutoSize = true;
            this.mp3RadioButton.Location = new System.Drawing.Point(71, 45);
            this.mp3RadioButton.Name = "mp3RadioButton";
            this.mp3RadioButton.Size = new System.Drawing.Size(46, 17);
            this.mp3RadioButton.TabIndex = 2;
            this.mp3RadioButton.TabStop = true;
            this.mp3RadioButton.Text = "Mp3";
            this.mp3RadioButton.UseVisualStyleBackColor = true;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(16, 146);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(304, 20);
            this.urlTextBox.TabIndex = 9;
            // 
            // descriptionLable
            // 
            this.descriptionLable.AutoSize = true;
            this.descriptionLable.Location = new System.Drawing.Point(13, 130);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(206, 13);
            this.descriptionLable.TabIndex = 10;
            this.descriptionLable.Text = "Url (http:// ...) of the video, song or playlist";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(354, 139);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(87, 32);
            this.downloadButton.TabIndex = 12;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // disclaimerLable
            // 
            this.disclaimerLable.AutoSize = true;
            this.disclaimerLable.Location = new System.Drawing.Point(13, 210);
            this.disclaimerLable.Name = "disclaimerLable";
            this.disclaimerLable.Size = new System.Drawing.Size(451, 13);
            this.disclaimerLable.TabIndex = 13;
            this.disclaimerLable.Text = "This software comes with no guarantees. But should work without any problems. //S" +
    "iNASTON";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Note that in some cases some videos cannot be downloaded for different reasons (e" +
    "specially when downloading playlists).";
            // 
            // configuration_label
            // 
            this.configuration_label.AutoSize = true;
            this.configuration_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration_label.Location = new System.Drawing.Point(12, 9);
            this.configuration_label.Name = "configuration_label";
            this.configuration_label.Size = new System.Drawing.Size(134, 24);
            this.configuration_label.TabIndex = 14;
            this.configuration_label.Text = "Configuration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 242);
            this.Controls.Add(this.configuration_label);
            this.Controls.Add(this.disclaimerLable);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.descriptionLable);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.mp3RadioButton);
            this.Controls.Add(this.videoRadioButton);
            this.Controls.Add(this.titleLable);
            this.Name = "Form1";
            this.Text = "Youtube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.RadioButton videoRadioButton;
        private System.Windows.Forms.RadioButton mp3RadioButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label descriptionLable;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label disclaimerLable;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label configuration_label;
    }
}

