using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CRC_Coda
{
    public partial class Form1 : Form
    {
        byte b2, b3, b4, crc;

        //These tables can be taken on faith. They work. I don't why precisely why
        //these values were chosen. If you want to know how the table was derived then take
        //a peek at bitmaskworksheet.
        byte[] swizzleTable = { 0xAA, 0x7F, 0xFE, 0x29, 0x52, 0xA4, 0x9D, 0xEF, 0xB, 0x16, 0x2C, 0x58, 0xB0, 0x60, 0xC0, 1 };

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Try to do the whole algorithm based on two static tables.
        //Take in three bytes and return the proper CRC byte.
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private byte calcCodaCRC(byte cmd, byte torqLow, byte torqHi) {
            byte crc;
            int tempTorq = torqLow + (256 * torqHi);

            crc = 0x7F; //7F is the answer if torque bytes are zero. We build up from there.

            //if b2 was 0xAx or 0x6x then add 1 to torque. Otherwise leave it alone.
            if (((cmd & 0xA0) == 0xA0) || ((cmd & 0x60) == 0x60))
            {
                tempTorq += 1;
            }

            if ((tempTorq % 4) == 3) tempTorq += 4; //Seems to be some form of obfuscation

            for (int i = 0; i < 16; i++)
            {
                if ((tempTorq & (1 << i)) == (1 << i))
                {
                    crc = (byte)(crc ^ swizzleTable[i]);
                }
            }
            return crc;
        }

        //try to calculate the entire CRC based on all of the bytes that matter (2, 3, 4) -> 5
        private void button1_Click_1(object sender, EventArgs e)
        {

            b2 = byte.Parse(txtFullByte2.Text, System.Globalization.NumberStyles.HexNumber);
            b3 = byte.Parse(txtFullByte3.Text, System.Globalization.NumberStyles.HexNumber);
            b4 = byte.Parse(txtFullByte4.Text, System.Globalization.NumberStyles.HexNumber);

            byte crc = calcCodaCRC(b2, b3, b4);

            txtFullCRC.Text = crc.ToString("X2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader oFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)            
            {
               oFile = new StreamReader(openFileDialog1.FileName);
               while (!oFile.EndOfStream) 
               {
                   String thisLine = oFile.ReadLine();
                   String[] items = thisLine.Split(',');
                   byte cmd, torql, torqh, crc;

                   if (items[0] != "")
                   {
                       cmd = byte.Parse(items[0], System.Globalization.NumberStyles.HexNumber);
                       torql = byte.Parse(items[1], System.Globalization.NumberStyles.HexNumber);
                       torqh = byte.Parse(items[2], System.Globalization.NumberStyles.HexNumber);
                       crc = byte.Parse(items[3], System.Globalization.NumberStyles.HexNumber);
                       byte calc_crc = calcCodaCRC(cmd, torql, torqh);
                       if (calc_crc != crc)
                       {
                           String outputLine = items[0] + "  " + items[1] + "  " + items[2] + "  " + items[3] + " calc: " + calc_crc.ToString("X2");
                           listProblems.Items.Add(outputLine);
                       }
                   }
               }
            }
            listProblems.Items.Add("Done");
        }
    }
}
