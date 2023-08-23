using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl; 
using Tao.FreeGlut; 
using Tao.Platform.Windows;

namespace LR4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pict.InitializeContexts();
            Tao.OpenGl.Gl.glClearColor(255, 255, 255, 0);
            Tao.OpenGl.Gl.glClear(
       
            Tao.OpenGl.Gl.GL_COLOR_BUFFER_BIT | //очистка буфера цвета

            Tao.OpenGl.Gl.GL_DEPTH_BUFFER_BIT //очистка буфера глубины

            );
            Treug.Visible = false;
            priam.Visible = false;
            chet.Visible = false;
            piat.Visible = false;
            menuStrip1.Visible = true;
        }
        Color color_obj, BGcolor;
        float size;

        //Сплошная линия
        private void spl_Click(object sender, EventArgs e)
        {
            Gl.glEnable(Gl.GL_LINE_STIPPLE);
            Gl.glLineStipple(1, 0XFFFF);
        }

        //Штриховая линия

        private void shtr_Click(object sender, EventArgs e)
        {
            Gl.glEnable(Gl.GL_LINE_STIPPLE);
            Gl.glLineStipple(1, 0XF0F0);
        }


        //Штрихпунктирная линия


        private void shtrpunkt_Click(object sender, EventArgs e)
        {
            Gl.glEnable(Gl.GL_LINE_STIPPLE);
            Gl.glLineStipple(1, 0XF11F);
        }

        //Штрихпунктирная с 2 точками
        private void shtrpunkt2_Click(object sender, EventArgs e)
        {
            Gl.glEnable(Gl.GL_LINE_STIPPLE);
            Gl.glLineStipple(1, 0XF24F);
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }

        //Толщина линии

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = Convert.ToSingle(numericUpDown1.Value);
        }


        //Цвет объекта
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            color_obj = colorDialog2.Color;
            pictureBox2.BackColor = color_obj;
        }

        //Прямоугольник
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Pict.SwapBuffers();
            Gl.glLineWidth(size);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3d(color_obj.R / 255.0f, color_obj.G / 255.0f, color_obj.B / 255.0f);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown2.Value) / 100.0f, Convert.ToSingle(numericUpDown3.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown8.Value) / 100.0f, Convert.ToSingle(numericUpDown3.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown8.Value) / 100.0f, Convert.ToSingle(numericUpDown9.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown2.Value) / 100.0f, Convert.ToSingle(numericUpDown9.Value) / 100.0f, 0);
            Gl.glEnd();
            Pict.SwapBuffers();
        }

        //Четырёхугольник

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Pict.SwapBuffers();
            Gl.glLineWidth(size);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3d(color_obj.R / 255.0f, color_obj.G / 255.0f, color_obj.B / 255.0f);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown2.Value) / 100.0f, Convert.ToSingle(numericUpDown3.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown4.Value) / 100.0f, Convert.ToSingle(numericUpDown5.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown6.Value) / 100.0f, Convert.ToSingle(numericUpDown7.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown8.Value) / 100.0f, Convert.ToSingle(numericUpDown9.Value) / 100.0f, 0);
            Gl.glEnd();
            Pict.SwapBuffers();
        }

        //Треугольник

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Pict.SwapBuffers();
            Gl.glLineWidth(size);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3d(color_obj.R / 255.0f, color_obj.G / 255.0f, color_obj.B / 255.0f);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown2.Value) / 100.0f, Convert.ToSingle(numericUpDown3.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown4.Value) / 100.0f, Convert.ToSingle(numericUpDown5.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown6.Value) / 100.0f, Convert.ToSingle(numericUpDown7.Value) / 100.0f, 0);
            Gl.glEnd();
            Pict.SwapBuffers();
        }

        //Пятиугольник

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Pict.SwapBuffers();
            Gl.glLineWidth(size);
            Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3d(color_obj.R / 255.0f, color_obj.G / 255.0f, color_obj.B / 255.0f);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown2.Value) / 100.0f, Convert.ToSingle(numericUpDown3.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown4.Value) / 100.0f, Convert.ToSingle(numericUpDown5.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown6.Value) / 100.0f, Convert.ToSingle(numericUpDown7.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown8.Value) / 100.0f, Convert.ToSingle(numericUpDown9.Value) / 100.0f, 0);
            Gl.glVertex3d(Convert.ToSingle(numericUpDown10.Value) / 100.0f, Convert.ToSingle(numericUpDown11.Value) / 100.0f, 0);
            Gl.glEnd();
            Pict.SwapBuffers();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Линия
        private void button3_Click(object sender, EventArgs e)
        {
            if (Treug.Visible == true) {
                Treug.Visible = false;
                priam.Visible = false;
                chet.Visible = false;
                piat.Visible = false;
            }
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Pict.SwapBuffers();
            Gl.glLineWidth(size);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3d(color_obj.R / 255.0f, color_obj.G / 255.0f, color_obj.B / 255.0f);     
            Gl.glVertex3d(Convert.ToSingle(numericUpDown2.Value)/100.0f, Convert.ToSingle(numericUpDown3.Value)/100.0f, 0); 
            Gl.glVertex3d(Convert.ToSingle(numericUpDown4.Value)/100.0f, Convert.ToSingle(numericUpDown5.Value)/100.0f, 0);
            Gl.glEnd();
            Pict.SwapBuffers();

        }


        //Кнопка с фигурами
        private void button4_Click(object sender, EventArgs e)
        {
            Treug.Visible = true;
            priam.Visible = true;
            chet.Visible = true;
            piat.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT | Gl.GL_ACCUM_BUFFER_BIT);
            // Матрица проецирования
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Pict.SwapBuffers();
            //Glut.glutWireCube(0.75);
            Pict.SwapBuffers();
        }



        //Цвет фона


        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BGcolor = colorDialog1.Color;
                pictureBox1.BackColor = BGcolor;
                Tao.OpenGl.Gl.glClearColor(BGcolor.R/ 255.0f, BGcolor.G/ 255.0f, BGcolor.B/ 255.0f, 0f);
                Tao.OpenGl.Gl.glClear(

            Tao.OpenGl.Gl.GL_COLOR_BUFFER_BIT | //очистка буфера цвета

            Tao.OpenGl.Gl.GL_DEPTH_BUFFER_BIT //очистка буфера глубины
            
            );
                Pict.SwapBuffers();
            }
        }

    
    }
}
