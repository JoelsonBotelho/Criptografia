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

namespace Exc1
{
    public partial class Form1 : Form
    {
        string caminho = @"C:\Users\hp\Documents\Joelson Botelho\Exc1\Exc1.txt";
        int Num;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriptografia_Click(object sender, EventArgs e)
        {
            StreamReader Read = new StreamReader(caminho,true);
            txtCriptografia.Text = Read.ReadToEnd();
            Read.Close();
            if (txtCriptografia.Text == "" || txtCriptografia.Text == " ")
            {
                MessageBox.Show("O ficheiro não tem nada escrito");
            }
            else
            {
               txtCriptografia.Text = txtCriptografia.Text.ToLower();
               try
               {
                   Num = int.Parse(txtPosicao.Text);
                   if (Num == 0 || Num == 26 || Num == 52)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "Z");
                   }
                   if (Num == 1 || Num == 27 || Num == 53)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "A");
                   }
                   if (Num == 2 || Num == 28 || Num == 54)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "B");
                   }
                   if (Num == 3 || Num == 29 || Num == 55)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "C");
                   }
                   if (Num == 4 || Num == 30 || Num == 56)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "w");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "D");
                   }
                   if (Num == 5 || Num == 31 || Num == 57)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "E");
                   }
                   if (Num == 6 || Num == 32 || Num == 58)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "F");
                   }
                   if (Num == 7 || Num == 33 || Num == 59)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "G");
                   }
                   if (Num == 8 || Num == 34 || Num == 60)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "H");
                   }
                   if (Num == 9 || Num == 35 || Num == 61)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "I");
                   }
                   if (Num == 10 || Num == 36 || Num == 62)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "J");
                   }
                   if (Num == 11 || Num == 37 || Num == 63)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "K");
                   }
                   if (Num == 12 || Num == 38 || Num == 64)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "L");
                   }
                   if (Num == 13 || Num == 39 || Num == 65)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "M");
                   }
                   if (Num == 14 || Num == 40 || Num == 67)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "N");
                   }
                   if (Num == 15 || Num == 41 || Num == 68)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "O");
                   }
                   if (Num == 16 || Num == 42 || Num == 69)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "P");
                   }
                   if (Num == 17 || Num == 43 || Num == 70)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "Q");
                   }
                   if (Num == 18 || Num == 44 || Num == 71)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "R");
                   }
                   if (Num == 19 || Num == 45 || Num == 72)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "S");
                   }
                   if (Num == 20 || Num == 46 || Num == 73)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "T");
                   }
                   if (Num == 21 || Num == 47 || Num == 74)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "U");
                   }
                   if (Num == 22 || Num == 48 || Num == 75)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "V");
                   }
                   if (Num == 23 || Num == 49 || Num == 76)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "W");
                   }
                   if (Num == 24 || Num == 50 || Num == 77)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "X");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "Y");
                   }
                   if (Num == 25 || Num == 51 || Num == 78)
                   {
                       txtCriptografia.Text = txtCriptografia.Text.Replace("a", "Z");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("b", "A");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("c", "B");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("d", "C");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("e", "D");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("f", "E");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("g", "F");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("h", "G");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("i", "H");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("j", "I");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("k", "J");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("l", "K");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("m", "L");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("n", "M");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("o", "N");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("p", "O");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("q", "P");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("r", "Q");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("s", "R");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("t", "S");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("u", "T");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("v", "U");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("w", "V");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("y", "W");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("x", "Y");
                       txtCriptografia.Text = txtCriptografia.Text.Replace("z", "X");
                   }
                   if (Num < 0)
                       MessageBox.Show("Digite Um Número Positivo");
                   if (Num > 78)
                       MessageBox.Show("Digite uma Posição no Intervalo de 0 à 78");
               }
               catch (Exception)
               {
                   MessageBox.Show("Digite Um Número Como Posição");
               }
            }
        }
    }
}