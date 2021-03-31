using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLBQuiz
{
    public partial class Form1 : Form
    {
        //sets up variables for the class.
        int timeLeft = 30;
        int Year;
        Random randomizer = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            Response.Text = "Please select the MLB champions for the provided year";
        }
        private void StartQuiz_Click(object sender, EventArgs e)
        {
            //randomizes year and prints
            Year = randomizer.Next(1903, 2021);
            YearOutput.Text = Year.ToString();

            // clears the answer box
            Answer.Text = " ";

            //disables start button to avoid multiple starts
            StartQuiz.Enabled = false;

            //sets and starts the timer
            timeLeft = 30;
            Timer.Text = "30 Seconds";
            timerTicker.Start();
        }

        private void timerTicker_Tick(object sender, EventArgs e)
        {
            //timer controls
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                Timer.Text = timeLeft + " seconds";
                answerCheck();
            }
            else
            {
                timerTicker.Stop();
                // Response.Show();
                Response.Text = "Time Ran out, Sorry!";
                StartQuiz.Enabled = true;
            }
        }
        private bool answerCheck()
        {
            string year = YearOutput.Text;
            string team = Answer.Text;
            if ((team == "New York Yankees") && (year == "1923" || year == "1927" || year == "1927" || year == "1928" || year == "1932" || year == "1936" || year == "1937" || year == "1938" || year == "1939" || year == "1941" || year == "1943" || year == "1947" || year == "1949" || year == "1950" || year == "1951" || year == "1952"
           || year == "1952" || year == "1953" || year == "1956" || year == "1958" || year == "1961" || year == "1962" || year == "1977" || year == "1978" || year == "1996" || year == "1998" || year == "1999" || year == "2000" || year == "2009"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "St. Louis Cardinals") && (year == "1926" || year == "1931" || year == "1934" || year == "1942" || year == "1944" || year == "1946" || year == "1964" || year == "1967" || year == "1982" || year == "2006" || year == "2011"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Oakland Athletics") && (year == "1972" || year == "1973" || year == "1974" || year == "1989"))
            {
                CorrectAnswer();
                return true;

            }
            else if ((team == "Philadelphia Athletics") && (year == "1910" || year == "1911" || year == "1913" || year == "1929" || year == "1930"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Boston Red Sox") && (year == "1903" || year == "1912" || year == "1915" || year == "1915" || year == "1918" || year == "2004" || year == "2007" || year == "2013" || year == "2018"))
            {
                CorrectAnswer();
                return true;
            }
            else if((team == "No Champion")&&(year == "1904"|| year == "1994")){
                CorrectAnswer();
                return true;
            }
            else if((team == "New York Giants")&&(year == "1905" || year =="1921" || year == "1922" || year == "1933" || year == "1954"))
            {
                CorrectAnswer();
                return true;
            }
            else if((team == "San Francisco Giants")&&(year == "2010"|| year == "2012"|| year == "2014"))
            {
                CorrectAnswer();
                return true;
            }
            else if((team =="Brooklyn Dodgers" )&&(year == "1955"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Los Angeles Dodgers" ) && (year == "1959" || year == "1963" || year == "1965" || year == "1981" || year == "1988" || year == "2020"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Cincinnati Reds") && (year == "1919" || year == "1940" || year == "1975" || year == "1976" || year == "1990"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Pittsburgh Pirates" ) && (year == "1909" || year == "1925" || year == "1960" || year == "1971" || year == "1979"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Detroit Tigers" ) && ( year == "1935" || year == "1945" || year == "1968" || year == "1984"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Chicago Cubs") && (year == "1907" || year == "1908" || year == "2016"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Boston Braves" ) && (year == "1941"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Milwaukee Braves" ) && (year == "1957"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Atlanta Braves" ) && (year == "1995"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Baltimore Orioles" ) && (year == "1966" || year == "1970" || year == "1983"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Washington Senators") && (year == "1924"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team =="Minnisota Twins" ) && (year == "1987" || year == "1991"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Chicago White Sox" ) && (year == "1906" || year == "1917" || year == "2005"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Philadelphia Phillies") && (year == "1980" || year == "2008"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Cleaveland Indians" ) && (year == "1920" || year == "1948"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "New York Mets" ) && (year == "1969" || year == "1986"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Kansas City Royals") && (year == "1985" || year == "2015"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Toronto Blue Jays" ) && (year == "1992" || year == "1993"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Miami Marlins") && (year == "1997" || year == "2003"))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Houston Astros" ) && (year == "2017" ))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Arizona Diamondbacks" ) && (year == "2001" ))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Los Angeles Angels" ) && (year == "2002" ))
            {
                CorrectAnswer();
                return true;
            }
            else if ((team == "Washington Nationals") && (year == "2019" ))
            {
                CorrectAnswer();
                return true;
            }
            else
            {
                return false;
            }
        }
        private int CorrectAnswer()
        {
            timerTicker.Stop();
            Response.Text = "Congrats! That's the winning team!";
            StartQuiz.Enabled = true;
            return 0;
        }
    }
}