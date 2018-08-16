using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1_ED2
{
    public partial class Form1 : Form
    {
        private Boolean[] vagas;
        private ComboBox dia;
        private Button selecionadia;
        private Button reservar;
        private Button[,] FilaPoltrona;



        public void iniciarComponentes()
        {
            dia = new ComboBox();
            dia.Parent = this;
            dia.Top = 0;
            dia.Left = 0;
            for (int i = 0; i <= 31; i++) { dia.Items.Add(i); }
            selecionadia = new Button();
            selecionadia.Parent = this;
            selecionadia.Text = "Ok";
            selecionadia.Top = 0;
            selecionadia.Left = 120;
            reservar = new Button();
            reservar.Parent = this;
            reservar.Text = "Reservar";
            reservar.Top = 0;
            reservar.Left = 200;


            int left = 10;
            int top = 150;
            FilaPoltrona = new Button[4, 25];
            for (int i = 0; i < 4; i++)
            {
                for (int b = 0; b < 25; b++)
                {
                    FilaPoltrona[i, b] = new Button();
                    FilaPoltrona[i, b].Parent = this;
                    FilaPoltrona[i, b].Top = top;
                    FilaPoltrona[i, b].Left = left;
                    FilaPoltrona[i, b].Width = 25;
                    FilaPoltrona[i, b].Text = "L";
                    left += 25;
                }
                top += 25;
                left = 10;
               
            }
        }







        public Form1()
        {
            InitializeComponent();
            iniciarComponentes();
        }
        
    }
}
