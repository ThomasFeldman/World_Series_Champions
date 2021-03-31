
namespace MLBQuiz
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
            this.StartQuiz = new System.Windows.Forms.Button();
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.ComboBox();
            this.Response = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.YearOutput = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartQuiz
            // 
            this.StartQuiz.Location = new System.Drawing.Point(117, 283);
            this.StartQuiz.Name = "StartQuiz";
            this.StartQuiz.Size = new System.Drawing.Size(114, 23);
            this.StartQuiz.TabIndex = 0;
            this.StartQuiz.Text = "Start Quiz";
            this.StartQuiz.UseVisualStyleBackColor = true;
            this.StartQuiz.Click += new System.EventHandler(this.StartQuiz_Click);
            // 
            // timerTicker
            // 
            this.timerTicker.Interval = 1000;
            this.timerTicker.Tick += new System.EventHandler(this.timerTicker_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timer";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year";
            // 
            // Answer
            // 
            this.Answer.FormattingEnabled = true;
            this.Answer.Items.AddRange(new object[] {
            "",
            "Anaheim Angels",
            "Arizona Diamondbacks",
            "Atlanta Braves",
            "Baltimore Orioles",
            "Boston Americans",
            "Boston Braves",
            "Boston Red Sox",
            "Brooklyn Dodgers",
            "Chicago Cubs",
            "Chicago White Sox",
            "Cincinnati Reds",
            "Cleveland Indians",
            "Detroit Tigers",
            "Florida Marlins",
            "Houston Astros",
            "Kansas City Royals",
            "Los Angeles Dodgers",
            "Milwaukee Braves",
            "Minnesota Twins",
            "No Champion",
            "New York Giants",
            "New York Mets",
            "New York Yankees",
            "Oakland Athletics",
            "Philadelphia Athletics",
            "Philadelphia Phillies",
            "Pittsburgh Pirates",
            "San Fransico Giants",
            "St. Louis Cardinals",
            "Toronto Blue Jays",
            "Washington Nationals",
            "Washington Senators"});
            this.Answer.Location = new System.Drawing.Point(240, 177);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(203, 21);
            this.Answer.TabIndex = 6;
            // 
            // Response
            // 
            this.Response.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Response.Location = new System.Drawing.Point(104, 66);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(297, 25);
            this.Response.TabIndex = 7;
            this.Response.Text = "Response box";
            // 
            // Timer
            // 
            this.Timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(269, 283);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(100, 23);
            this.Timer.TabIndex = 8;
            this.Timer.Text = "30 Seconds";
            // 
            // YearOutput
            // 
            this.YearOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearOutput.Location = new System.Drawing.Point(117, 175);
            this.YearOutput.Name = "YearOutput";
            this.YearOutput.Size = new System.Drawing.Size(100, 23);
            this.YearOutput.TabIndex = 9;
            this.YearOutput.Text = " ";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(174, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(146, 34);
            this.title.TabIndex = 10;
            this.title.Text = "MLB Quiz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.title);
            this.Controls.Add(this.YearOutput);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartQuiz);
            this.Name = "Form1";
            this.Text = "MLB Quiz";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartQuiz;
        private System.Windows.Forms.Timer timerTicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Answer;
        private System.Windows.Forms.Label Response;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label YearOutput;
        private System.Windows.Forms.Label title;
    }
}

