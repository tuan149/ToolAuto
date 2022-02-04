namespace AutoKeyTomoto
{
    partial class AutoKeyTomoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoKeyTomoto));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.btnStop = new FontAwesome.Sharp.IconButton();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.numberTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVer = new System.Windows.Forms.Label();
            this.labelTomoto = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numberTime)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPlay.IconColor = System.Drawing.Color.Black;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.Location = new System.Drawing.Point(307, 118);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(119, 50);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightSalmon;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnStop.IconColor = System.Drawing.Color.Black;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.Location = new System.Drawing.Point(307, 174);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(119, 50);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 53);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(289, 171);
            this.txtKey.TabIndex = 3;
            // 
            // timerDelay
            // 
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time(s)";
            // 
            // numberTime
            // 
            this.numberTime.Location = new System.Drawing.Point(59, 7);
            this.numberTime.Name = "numberTime";
            this.numberTime.Size = new System.Drawing.Size(109, 20);
            this.numberTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Status";
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(143, 9);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(51, 13);
            this.labelVer.TabIndex = 6;
            this.labelVer.Text = "Tool by : ";
            // 
            // labelTomoto
            // 
            this.labelTomoto.AutoSize = true;
            this.labelTomoto.Location = new System.Drawing.Point(224, 9);
            this.labelTomoto.Name = "labelTomoto";
            this.labelTomoto.Size = new System.Drawing.Size(48, 13);
            this.labelTomoto.TabIndex = 7;
            this.labelTomoto.TabStop = true;
            this.labelTomoto.Text = "ToMoTo";
            this.labelTomoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelTomoto_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.labelTomoto);
            this.panel1.Controls.Add(this.labelVer);
            this.panel1.Location = new System.Drawing.Point(-2, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 31);
            this.panel1.TabIndex = 8;
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(307, 69);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(119, 19);
            this.progressBarStatus.TabIndex = 9;
            // 
            // AutoKeyTomoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 272);
            this.Controls.Add(this.progressBarStatus);
            this.Controls.Add(this.numberTime);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoKeyTomoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoKeyTomoto";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnStop;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.LinkLabel labelTomoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBarStatus;
    }
}

