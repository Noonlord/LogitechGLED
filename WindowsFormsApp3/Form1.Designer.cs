namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redTrack = new System.Windows.Forms.TrackBar();
            this.greenTrack = new System.Windows.Forms.TrackBar();
            this.blueTrack = new System.Windows.Forms.TrackBar();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedTrack = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.blueRed = new System.Windows.Forms.RadioButton();
            this.blueGreen = new System.Windows.Forms.RadioButton();
            this.redGreen = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // redTrack
            // 
            this.redTrack.Location = new System.Drawing.Point(92, 12);
            this.redTrack.Maximum = 100;
            this.redTrack.Name = "redTrack";
            this.redTrack.Size = new System.Drawing.Size(258, 56);
            this.redTrack.TabIndex = 0;
            this.redTrack.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // greenTrack
            // 
            this.greenTrack.Location = new System.Drawing.Point(92, 74);
            this.greenTrack.Maximum = 100;
            this.greenTrack.Name = "greenTrack";
            this.greenTrack.Size = new System.Drawing.Size(258, 56);
            this.greenTrack.TabIndex = 1;
            this.greenTrack.Scroll += new System.EventHandler(this.greenTrack_Scroll);
            // 
            // blueTrack
            // 
            this.blueTrack.Location = new System.Drawing.Point(92, 136);
            this.blueTrack.Maximum = 100;
            this.blueTrack.Name = "blueTrack";
            this.blueTrack.Size = new System.Drawing.Size(258, 56);
            this.blueTrack.TabIndex = 2;
            this.blueTrack.Scroll += new System.EventHandler(this.blueTrack_Scroll);
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(357, 12);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(16, 17);
            this.redLabel.TabIndex = 3;
            this.redLabel.Text = "0";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(357, 74);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(16, 17);
            this.greenLabel.TabIndex = 4;
            this.greenLabel.Text = "0";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(356, 136);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(16, 17);
            this.blueLabel.TabIndex = 5;
            this.blueLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blue:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open color picker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Toggle effect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedTrack
            // 
            this.speedTrack.Location = new System.Drawing.Point(92, 195);
            this.speedTrack.Maximum = 100;
            this.speedTrack.Name = "speedTrack";
            this.speedTrack.Size = new System.Drawing.Size(258, 56);
            this.speedTrack.TabIndex = 11;
            this.speedTrack.Scroll += new System.EventHandler(this.speedTrack_Scroll);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(356, 195);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(53, 17);
            this.speedLabel.TabIndex = 12;
            this.speedLabel.Text = "Default";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Speed:";
            // 
            // blueRed
            // 
            this.blueRed.AutoSize = true;
            this.blueRed.Checked = true;
            this.blueRed.Location = new System.Drawing.Point(15, 352);
            this.blueRed.Name = "blueRed";
            this.blueRed.Size = new System.Drawing.Size(148, 21);
            this.blueRed.TabIndex = 14;
            this.blueRed.TabStop = true;
            this.blueRed.Text = "Blue-Magenta-Red";
            this.blueRed.UseVisualStyleBackColor = true;
            this.blueRed.CheckedChanged += new System.EventHandler(this.blueRed_CheckedChanged);
            // 
            // blueGreen
            // 
            this.blueGreen.AutoSize = true;
            this.blueGreen.Location = new System.Drawing.Point(261, 352);
            this.blueGreen.Name = "blueGreen";
            this.blueGreen.Size = new System.Drawing.Size(139, 21);
            this.blueGreen.TabIndex = 15;
            this.blueGreen.Text = "Blue-Cyan-Green";
            this.blueGreen.UseVisualStyleBackColor = true;
            this.blueGreen.CheckedChanged += new System.EventHandler(this.blueGreen_CheckedChanged);
            // 
            // redGreen
            // 
            this.redGreen.AutoSize = true;
            this.redGreen.Location = new System.Drawing.Point(137, 379);
            this.redGreen.Name = "redGreen";
            this.redGreen.Size = new System.Drawing.Size(145, 21);
            this.redGreen.TabIndex = 16;
            this.redGreen.Text = "Red-Yellow-Green";
            this.redGreen.UseVisualStyleBackColor = true;
            this.redGreen.CheckedChanged += new System.EventHandler(this.redGreen_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Effect colors:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.redGreen);
            this.Controls.Add(this.blueGreen);
            this.Controls.Add(this.blueRed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedTrack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueTrack);
            this.Controls.Add(this.greenTrack);
            this.Controls.Add(this.redTrack);
            this.Name = "Form1";
            this.Text = "Logitech Işık Ayarlayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redTrack;
        private System.Windows.Forms.TrackBar greenTrack;
        private System.Windows.Forms.TrackBar blueTrack;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar speedTrack;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton blueRed;
        private System.Windows.Forms.RadioButton blueGreen;
        private System.Windows.Forms.RadioButton redGreen;
        private System.Windows.Forms.Label label5;
    }
}

