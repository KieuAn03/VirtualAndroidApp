using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AppAndroid
{
    public partial class chart : UserControl
    {
        public chart()
        {
            InitializeComponent();
            generatechart();
        }
        private void generatechart()
        {
            string dir = Directory.GetParent("Users").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir+"\\Users");
            if (fi.Exists)
            {
                string[] word = new string[6];
                List <string> rating = new List<string>();
                List <string>list = new List<string>();
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string user = rd.ReadLine();
                rd.Close();
                rd = new StreamReader(dir + "\\Users\\"+ user + "\\history.txt");
                while (!rd.EndOfStream)
                {
                    
                        list.Add(rd.ReadLine());
                    
                }
                rd.Close();

                for(int i = 0; i < list.Count; i++)
                {
                    word = list[i].Split('\t');
                    rating.Add(word[5]);
                }    
                int count0 = 0;
                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                int count4 = 0;
                int count5 = 0;
                for(int i =0; i<rating.Count; i++)
                {
                    switch (rating[i])
                    {
                        case "N/A":
                            {
                                count0++;
                                break;
                            }
                        case "one":
                            {
                                count1++;
                                break;
                            }
                        case "two":
                            {
                                count2++;
                                break;
                            }
                        case "three":
                            {
                                count3++;
                                break;
                            }
                        case "four":
                            {
                                count4++;
                                break;
                            }
                        case "five":
                            {
                                count5++;
                                break;
                            }
                            

                    }
                }
                chart1.Series["SL"].Points.AddXY("N/A", count0);
                chart1.Series["SL"].Points.AddXY("1 Sao", count1);
                chart1.Series["SL"].Points.AddXY("2 Sao", count2);
                chart1.Series["SL"].Points.AddXY("3 Sao", count3);
                chart1.Series["SL"].Points.AddXY("4 Sao", count4);
                chart1.Series["SL"].Points.AddXY("5 Sao", count5);
                chart1.Titles.Add("ĐÁNH GIÁ");

            }
        }
        private void chartgen()
        {
            chart1.Series["SL"].Points.AddXY("N/A", 10);
            chart1.Series["SL"].Points.AddXY("1 Sao", 20);
            chart1.Series["SL"].Points.AddXY("2 Sao", 1);
            chart1.Series["SL"].Points.AddXY("3 Sao", 3);
            chart1.Series["SL"].Points.AddXY("4 Sao", 4);
            chart1.Series["SL"].Points.AddXY("5 Sao", 5);
            chart1.Titles.Add("ĐÁNH GIÁ");
        }
        private void chart_Load(object sender, EventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
