namespace Lukasz_Kulesza_184764
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
            this.pointsLabel = new System.Windows.Forms.Label();
            this.bannedColorLabel = new System.Windows.Forms.Label();
            this.trainingResultLabel = new System.Windows.Forms.Label();
            this.trainingStartButton = new System.Windows.Forms.Button();
            this.changeGameButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.reflexTestTimeLabel = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.PictureBox();
            this.reflexTestBox = new System.Windows.Forms.PictureBox();
            this.bannedColorBox = new System.Windows.Forms.PictureBox();
            this.circleBox = new System.Windows.Forms.PictureBox();
            this.highestScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflexTestBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannedColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.Location = new System.Drawing.Point(12, 60);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(315, 29);
            this.pointsLabel.TabIndex = 0;
            this.pointsLabel.Text = "Liczba zdobytych punktów: 0";
            // 
            // bannedColorLabel
            // 
            this.bannedColorLabel.AutoSize = true;
            this.bannedColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bannedColorLabel.Location = new System.Drawing.Point(12, 102);
            this.bannedColorLabel.Name = "bannedColorLabel";
            this.bannedColorLabel.Size = new System.Drawing.Size(179, 29);
            this.bannedColorLabel.TabIndex = 1;
            this.bannedColorLabel.Text = "Zakazany kolor:";
            // 
            // trainingResultLabel
            // 
            this.trainingResultLabel.AutoSize = true;
            this.trainingResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trainingResultLabel.Location = new System.Drawing.Point(494, 308);
            this.trainingResultLabel.Name = "trainingResultLabel";
            this.trainingResultLabel.Size = new System.Drawing.Size(0, 29);
            this.trainingResultLabel.TabIndex = 2;
            this.trainingResultLabel.Visible = false;
            // 
            // trainingStartButton
            // 
            this.trainingStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trainingStartButton.Location = new System.Drawing.Point(463, 370);
            this.trainingStartButton.Name = "trainingStartButton";
            this.trainingStartButton.Size = new System.Drawing.Size(273, 60);
            this.trainingStartButton.TabIndex = 3;
            this.trainingStartButton.Text = "Rozpocznij trening";
            this.trainingStartButton.UseVisualStyleBackColor = true;
            this.trainingStartButton.Click += new System.EventHandler(this.trainingStartButton_Click);
            // 
            // changeGameButton
            // 
            this.changeGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeGameButton.Location = new System.Drawing.Point(878, 13);
            this.changeGameButton.Name = "changeGameButton";
            this.changeGameButton.Size = new System.Drawing.Size(292, 43);
            this.changeGameButton.TabIndex = 4;
            this.changeGameButton.Text = "Sprawdź swój refleks!";
            this.changeGameButton.UseVisualStyleBackColor = true;
            this.changeGameButton.Click += new System.EventHandler(this.changeGameButton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // reflexTestTimeLabel
            // 
            this.reflexTestTimeLabel.AutoSize = true;
            this.reflexTestTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reflexTestTimeLabel.Location = new System.Drawing.Point(508, 103);
            this.reflexTestTimeLabel.Name = "reflexTestTimeLabel";
            this.reflexTestTimeLabel.Size = new System.Drawing.Size(183, 29);
            this.reflexTestTimeLabel.TabIndex = 9;
            this.reflexTestTimeLabel.Text = "Twój refleks to: ";
            this.reflexTestTimeLabel.Visible = false;
            // 
            // infoBox
            // 
            this.infoBox.BackgroundImage = global::Lukasz_Kulesza_184764.Properties.Resources.info;
            this.infoBox.Image = global::Lukasz_Kulesza_184764.Properties.Resources.info;
            this.infoBox.Location = new System.Drawing.Point(812, 13);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(43, 36);
            this.infoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoBox.TabIndex = 11;
            this.infoBox.TabStop = false;
            this.infoBox.Click += new System.EventHandler(this.infoBox_Click);
            // 
            // reflexTestBox
            // 
            this.reflexTestBox.BackColor = System.Drawing.Color.Green;
            this.reflexTestBox.Location = new System.Drawing.Point(303, 340);
            this.reflexTestBox.Name = "reflexTestBox";
            this.reflexTestBox.Size = new System.Drawing.Size(600, 334);
            this.reflexTestBox.TabIndex = 10;
            this.reflexTestBox.TabStop = false;
            this.reflexTestBox.Visible = false;
            this.reflexTestBox.Click += new System.EventHandler(this.reflexTestBox_Click);
            // 
            // bannedColorBox
            // 
            this.bannedColorBox.Location = new System.Drawing.Point(187, 92);
            this.bannedColorBox.MaximumSize = new System.Drawing.Size(41, 41);
            this.bannedColorBox.Name = "bannedColorBox";
            this.bannedColorBox.Size = new System.Drawing.Size(40, 40);
            this.bannedColorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bannedColorBox.TabIndex = 6;
            this.bannedColorBox.TabStop = false;
            // 
            // circleBox
            // 
            this.circleBox.Location = new System.Drawing.Point(312, 167);
            this.circleBox.Name = "circleBox";
            this.circleBox.Size = new System.Drawing.Size(100, 50);
            this.circleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circleBox.TabIndex = 5;
            this.circleBox.TabStop = false;
            this.circleBox.Click += new System.EventHandler(this.circleBox_Click);
            // 
            // highestScoreLabel
            // 
            this.highestScoreLabel.AutoSize = true;
            this.highestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highestScoreLabel.Location = new System.Drawing.Point(12, 20);
            this.highestScoreLabel.Name = "highestScoreLabel";
            this.highestScoreLabel.Size = new System.Drawing.Size(277, 29);
            this.highestScoreLabel.TabIndex = 12;
            this.highestScoreLabel.Text = "Twój najwyższy wynik to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.highestScoreLabel);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.reflexTestBox);
            this.Controls.Add(this.reflexTestTimeLabel);
            this.Controls.Add(this.bannedColorBox);
            this.Controls.Add(this.circleBox);
            this.Controls.Add(this.changeGameButton);
            this.Controls.Add(this.trainingStartButton);
            this.Controls.Add(this.trainingResultLabel);
            this.Controls.Add(this.bannedColorLabel);
            this.Controls.Add(this.pointsLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zadbaj o swój refleks!";
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflexTestBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannedColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.PictureBox bannedColorBox;
        public System.Windows.Forms.Label pointsLabel;
        public System.Windows.Forms.Label bannedColorLabel;
        public System.Windows.Forms.PictureBox circleBox;
        public System.Windows.Forms.Button trainingStartButton;
        public System.Windows.Forms.Button changeGameButton;
        public System.Windows.Forms.Label trainingResultLabel;
        public System.Windows.Forms.PictureBox reflexTestBox;
        public System.Windows.Forms.Label reflexTestTimeLabel;
        public System.Windows.Forms.PictureBox infoBox;
        private System.Windows.Forms.Label highestScoreLabel;
    }
}

