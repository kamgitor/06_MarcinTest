using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MojaApka : Form
    {
        public MojaApka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input2.Text = Input1.Text;
            Input1.Visible = false;
            ProgressBar.Value = 50;

            Ptaszek.Checked = true;
            Klikacz1.Checked = true;
            Klikacz2.Checked = true;


            CheckedListBox.

        }

        ushort bla()
        {
            ushort wartosc;

            wartosc = 5;
            wartosc += 3;
            return wartosc;
        }

        void oko()
        {

        }

        void nic()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Input1.Visible == false)
            {
                float zmienny;
                double podwojny;
                ushort _16bit;
                char _8bit = 'R';
                string tekst = "moj string";
                uint i, val1 = 0x0003, val2 = 0x000E;

                bool bool1 = true, bool2 = false;

                // _8bit = _16bit;
                _16bit = _8bit;

                if (bool1 & bool2)
                {
                    i = 1;
                }

                for (i = 0; i < 10; i++)
                {
                    switch (i)
                    {
                    case 0:
                        _16bit = bla();
                        break;
                    case 1:
                        oko();
                        break;
                    default:
                        nic();
                        break;
                    }

                    if (i == 0)
                        bla();
                    else if (i == 1)
                        oko();
                    else
                        nic();

                    if (i > 8)
                        break;
                    if (i == 6)
                        continue;

                }

                i = 0;
                while (i < 10)
                {

                    i++;
                }

                do
                {
                    i++;
                } while (i < 10);


                Input2.Text = "Okno 1 bylo zgaszone";
                Input1.Visible = true;
            }
            else
            {
                Ptaszek.Checked = false;
                Klikacz1.Checked = false;
                Klikacz2.Checked = false;
            }






        }
    }
}
