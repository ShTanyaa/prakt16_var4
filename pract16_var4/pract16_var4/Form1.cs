using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace pract16_var4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Queue q = new Queue();
             Queue q1 = new Queue();
             StreamReader sr = new StreamReader("t.txt");
             foreach (char s in sr.ReadLine())
             {
                 int number = int.Parse(s);
                 if (number >= 0) q.Enqueue(number);
                 else q1.Enqueue(number);
             }*/

            int[] positiveNumbers = new int[100];
            int[] negativeNumbers = new int[100];
            int positiveCount = 0;
            int negativeCount = 0;
            StreamReader sr = new StreamReader("t.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                int num = int.Parse(line);
                if (num >= 0)
                {
                    positiveNumbers[positiveCount++] = num;
                    
                }
                else
                    negativeNumbers[negativeCount++] = num;
            }
            for (int i = 0; i < positiveCount; i++)
            {
                listBox1.Items.Add(positiveCount);
            }
            for (int i = 0; i < negativeCount; i++)
            {
                listBox1.Items.Add(negativeNumbers);
            }
        }
    }
}

