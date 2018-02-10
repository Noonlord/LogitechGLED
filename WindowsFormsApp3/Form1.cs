using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            globals.globalRed = redTrack.Value;
            writeColors();
        }

        private void greenTrack_Scroll(object sender, EventArgs e)
        {
            globals.globalGreen = greenTrack.Value;
            writeColors();
        }

        private void blueTrack_Scroll(object sender, EventArgs e)
        {
            globals.globalBlue = blueTrack.Value;
            writeColors();
        }
        //Function for changing led colors. Maybe it could be better with arguments, but it worked so i left it this way.
       private void writeColors()
        {
            LedCSharp.LogitechGSDK.LogiLedInit();
            LedCSharp.LogitechGSDK.LogiLedSaveCurrentLighting();
            LedCSharp.LogitechGSDK.LogiLedSetLighting(globals.globalRed, globals.globalGreen, globals.globalBlue);
            //These three lines changes positions of trackbars when an effect is present.
            redTrack.Value = globals.globalRed;
            greenTrack.Value = globals.globalGreen;
            blueTrack.Value = globals.globalBlue;
            //And these lines are for changing labels next to track bars. 
            redLabel.Text = globals.globalRed.ToString();
            greenLabel.Text = globals.globalGreen.ToString();
            blueLabel.Text = globals.globalBlue.ToString();

        }
        public class globals
        {
            //I used this class as a place for global variables.
            public static int globalRed, globalBlue, globalGreen, globalStatus, globalCounter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            globals.globalCounter = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            int r = colorDialog1.Color.R;
            int g = colorDialog1.Color.G;
            int b = colorDialog1.Color.B;
            int mappedR, mappedG, mappedB;
            mappedR = ExtensionMethods.Map(r, 0, 255, 0, 100);
            mappedG = ExtensionMethods.Map(g, 0, 255, 0, 100);
            mappedB = ExtensionMethods.Map(b, 0, 255, 0, 100);
            globals.globalRed = mappedR;
            globals.globalGreen = mappedG;
            globals.globalBlue = mappedB;
            writeColors();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            globals.globalCounter++;
            if (globals.globalCounter % 2 == 1)
            {
                timer1.Enabled = true;
            }
            if (globals.globalCounter %2 == 0)
            {
                timer1.Enabled = false;
            }
            globals.globalRed = 0;
            globals.globalGreen = 0;
            globals.globalBlue = 0;
            globals.globalStatus = 1;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hard-coded effects. I was just too tired for writing a proper function for changing colors.
            //So I just opened a text editor, copied whole code for effect and replaced colors with new ones...
            if (blueRed.Checked == true)
            {
                if (globals.globalBlue < 100 & globals.globalStatus == 1)
                {
                    globals.globalBlue++;
                    writeColors();
                    if (globals.globalBlue == 100)
                    {
                        globals.globalStatus = 2;
                    }
                }
                if (globals.globalRed < 100 & globals.globalBlue == 100 & globals.globalStatus == 2)
                {
                    globals.globalRed++;
                    writeColors();
                    if (globals.globalBlue == 100 & globals.globalRed == 100)
                    {
                        globals.globalStatus = 3;
                    }
                }
                if (globals.globalRed == 100 & globals.globalBlue != 0 & globals.globalStatus == 3)
                {
                    globals.globalBlue--;
                    writeColors();
                    if (globals.globalRed == 100 & globals.globalBlue == 0)
                    {
                        globals.globalStatus = 4;
                    }
                }
                if (globals.globalBlue < 100 & globals.globalStatus == 4)
                {
                    globals.globalBlue++;
                    writeColors();
                    if (globals.globalBlue == 100)
                    {
                        globals.globalStatus = 5;
                    }
                }
                if (globals.globalRed != 0 & globals.globalStatus == 5)
                {
                    globals.globalRed--;
                    writeColors();
                    if (globals.globalRed == 0)
                    {
                        globals.globalStatus = 2;
                    }
                }
            }
            if (blueGreen.Checked == true)
            {
                if (globals.globalBlue < 100 & globals.globalStatus == 1)
                {
                    globals.globalBlue++;
                    writeColors();
                    if (globals.globalBlue == 100)
                    {
                        globals.globalStatus = 2;
                    }
                }
                if (globals.globalGreen < 100 & globals.globalBlue == 100 & globals.globalStatus == 2)
                {
                    globals.globalGreen++;
                    writeColors();
                    if (globals.globalBlue == 100 & globals.globalGreen == 100)
                    {
                        globals.globalStatus = 3;
                    }
                }
                if (globals.globalGreen == 100 & globals.globalBlue != 0 & globals.globalStatus == 3)
                {
                    globals.globalBlue--;
                    writeColors();
                    if (globals.globalGreen == 100 & globals.globalBlue == 0)
                    {
                        globals.globalStatus = 4;
                    }
                }
                if (globals.globalBlue < 100 & globals.globalStatus == 4)
                {
                    globals.globalBlue++;
                    writeColors();
                    if (globals.globalBlue == 100)
                    {
                        globals.globalStatus = 5;
                    }
                }
                if (globals.globalGreen != 0 & globals.globalStatus == 5)
                {
                    globals.globalGreen--;
                    writeColors();
                    if (globals.globalGreen == 0)
                    {
                        globals.globalStatus = 2;
                    }
                }
            }
            if (redGreen.Checked == true)
            {
                if (globals.globalRed < 100 & globals.globalStatus == 1)
                {
                    globals.globalRed++;
                    writeColors();
                    if (globals.globalRed == 100)
                    {
                        globals.globalStatus = 2;
                    }
                }
                if (globals.globalGreen < 100 & globals.globalRed == 100 & globals.globalStatus == 2)
                {
                    globals.globalGreen++;
                    writeColors();
                    if (globals.globalRed == 100 & globals.globalGreen == 100)
                    {
                        globals.globalStatus = 3;
                    }
                }
                if (globals.globalGreen == 100 & globals.globalRed != 0 & globals.globalStatus == 3)
                {
                    globals.globalRed--;
                    writeColors();
                    if (globals.globalGreen == 100 & globals.globalRed == 0)
                    {
                        globals.globalStatus = 4;
                    }
                }
                if (globals.globalRed < 100 & globals.globalStatus == 4)
                {
                    globals.globalRed++;
                    writeColors();
                    if (globals.globalRed == 100)
                    {
                        globals.globalStatus = 5;
                    }
                }
                if (globals.globalGreen != 0 & globals.globalStatus == 5)
                {
                    globals.globalGreen--;
                    writeColors();
                    if (globals.globalGreen == 0)
                    {
                        globals.globalStatus = 2;
                    }
                }
            }
        }

        private void speedTrack_Scroll(object sender, EventArgs e)
        {
            int speed = speedTrack.Value;
            int mappedSpeed = ExtensionMethods.Map(speed, 0, 100, 100, 1);
            timer1.Interval = mappedSpeed;
            speedLabel.Text = speed.ToString();
        }

        private void blueRed_CheckedChanged(object sender, EventArgs e)
        {
            if (blueRed.Checked == true)
            {
                globals.globalCounter++;
            }
        }

        private void blueGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (blueGreen.Checked == true)
            {
                globals.globalCounter++;
            }
        }

        private void redGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (redGreen.Checked == true)
            {
                globals.globalCounter++;
            }
        }
    }
    public static class ExtensionMethods
    {
        //This is for mapping color picker value (which is between 0 and 255) to percentage (that SDK wants which is between 0 and 100).
        //And also for changing timer interval: int mappedSpeed = ExtensionMethods.Map(speed, 0, 100, 100, 1);
        //for example, if I choose 1 for speed this code will map this and make interval 100ms. If I choose 100, it will make interval 1 ms.
        public static int Map(this int input, int inputMin, int inputMax, int outputMin, int outputMax)
        {
            return (input - inputMin) * (outputMax - outputMin) / (inputMax - inputMin) + outputMin;
        }
    }
}
