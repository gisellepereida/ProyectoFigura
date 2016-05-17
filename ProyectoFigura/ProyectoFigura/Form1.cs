﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFigura
{
    public partial class Form1 : Form
    {
        enum TipoFigura { Rectangulo, Circulo,Recta };
        private TipoFigura figura_actual;
        private List<Figura> rectangulos;
        private List<Figura> circulos;
        private List<Figura> rectas;
        public Form1()
        {
            figura_actual = TipoFigura.Circulo;
            rectangulos = new List<Figura>();
            circulos = new List<Figura>();
            rectas = new List<Figura>();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);
            }
            else if (MouseButtons.Left == e.Button)
            {
                if (figura_actual == TipoFigura.Circulo)
                {
                    Circulo c = new Circulo(e.X, e.Y);
                    c.Dibuja(this);
                    circulos.Add(c);

                }
                else if (figura_actual == TipoFigura.Rectangulo)
                {
                    Rectangulo r = new Rectangulo(e.X, e.Y);
                    r.Dibuja(this);
                    rectangulos.Add(r);

                }
                else if(figura_actual==TipoFigura.Recta)
                {
                    Recta rec = new Recta(e.X, e.Y);
                    rec.Dibuja(this);
                    rectas.Add(rec);                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura r in rectangulos)
                r.Dibuja(this);
        }

        private void rectanguloToolStripMenuItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
            this.rectaToolStripMenuItem.Checked=false
            figura_actual = TipoFigura.Rectangulo;
        }

        private void circuloToolStripMenuItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.circuloToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;
            this.rectaToolStripMenuItem.Checked = false;
        }

        private void rectaToolStripMenuItem_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.rectaToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;
            this.circuloToolStripMenuItem.Checked = false;
        }
    }

}

        
  