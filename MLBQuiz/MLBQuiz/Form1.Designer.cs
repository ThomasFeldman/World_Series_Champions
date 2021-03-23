
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
            this.Timer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Response = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartQuiz
            // 
            this.StartQuiz.Location = new System.Drawing.Point(193, 402);
            this.StartQuiz.Name = "StartQuiz";
            this.StartQuiz.Size = new System.Drawing.Size(114, 23);
            this.StartQuiz.TabIndex = 0;
            this.StartQuiz.Text = "Start Quiz";
            this.StartQuiz.UseVisualStyleBackColor = true;
            // 
            // timerTicker
            // 
            this.timerTicker.Interval = 1000;
            // 
            // Timer
            // 
            this.Timer.Location = new System.Drawing.Point(177, 30);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(100, 20);
            this.Timer.TabIndex = 1;
            this.Timer.Text = "Timer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timer";
            // 
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(111, 358);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(285, 20);
            this.Response.TabIndex = 3;
            this.Response.Text = "Congrats/Sorry";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(177, 88);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(100, 20);
            this.Year.TabIndex = 4;
            this.Year.Text = "1903-2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.StartQuiz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartQuiz;
        private System.Windows.Forms.Timer timerTicker;
        private System.Windows.Forms.TextBox Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Response;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Label label2;
    }
}

