using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3
{
    public partial class Form1 : Form
    {

        Graphics g;

        List<Point> points = new List<Point>();
        Brush Pointbrush = Brushes.Black;
        Brush Linebrush = Brushes.Blue;
       

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pBlack_MouseClick(object sender, MouseEventArgs e)
        {
            Pointbrush = Brushes.Black;
        }

        private void pRed_MouseClick(object sender, MouseEventArgs e)
        {
            Pointbrush = Brushes.Red;
        }

        private void pBlue_MouseClick(object sender, MouseEventArgs e)
        {
            Pointbrush = Brushes.Blue;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool RemovePoint(Point point)
        {
            int X = 0;
            int Y = 0;
            bool status = false;
            points.ForEach(p =>
            {
                if (point.X == p.X && point.Y == p.Y)
                {
                    status = true;
                    X = point.X;
                    Y = point.Y;
                }


            });
            if (status)
            {
                points.Remove(new Point(X, Y));
                return true;
            }


            return false;
        }
          private void DrawPoint(Point point)
        {   
            
            var x = point.X;
            var y = point.Y;       
           
           
            g.FillRectangle(Pointbrush, x, y, 5, 5);
            points.Add(point);
            RefreshGraph();
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (!RemovePoint(new Point(e.X, e.Y)))
                {
                    DrawPoint(new Point(e.X, e.Y));
                    listBox1.Items.Add(" X:" + e.X + " Y: " + e.Y);
                }
            }
            else
            {

                points.RemoveAt(points.Count() - 1);
                listBox1.Items.RemoveAt(points.Count());
            }

            RefreshGraph();


        }
    
        private void RefreshGraph()
        {
            Refresh();
            for(int i = 0; i < points.Count;i++)
            {
                var x = points.ElementAt(i);
               
                if (points.Count > 1)
                {
                    g.FillRectangle(Pointbrush, x.X, x.Y, 5, 5);
                    if (i == points.Count()-1){
                        return;
                    }
                    var x2 = points.ElementAt(i + 1);
                 
                    g.DrawLine(new Pen(Linebrush), x, x2);
                }
                else
                {
                    g.FillRectangle(Pointbrush, x.X, x.Y, 5, 5);
                }
            } 

          
        }

        private void lineBlack_MouseClick(object sender, MouseEventArgs e)
        {
            Linebrush = Brushes.Black;
        }

        private void lineRed_MouseClick(object sender, MouseEventArgs e)
        {
            Linebrush = Brushes.Red;
        }

        private void lineBlue_MouseClick(object sender, MouseEventArgs e)
        {
            Linebrush = Brushes.Blue;
        }
        private double CurveLenght()
        {
            double sum = 0;
            if (points.Count > 1)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Point first = points.ElementAt(i);

                    if (i == points.Count() - 1)
                    {

                        return sum;
                    }
                    Point second = points.ElementAt(i + 1);


                    sum += Math.Sqrt(Math.Pow((second.X - first.X), 2) + Math.Pow((second.Y - first.Y), 2));
                }
            }

            return sum;

        }

        private void curvelength_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = CurveLenght().ToString();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            

            mouseStatus.Text = "X: " + e.X + " Y: " + e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }

    }

