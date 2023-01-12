using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Авито_Создание_переключаемых_DGV
{
    public partial class Form2_Clicked : Form
    {
        public Form2_Clicked()
        {
            InitializeComponent();
        }

        private void Form2_Clicked_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                try
                {
                    if (A_TB.Text.Trim() == "")
                    {
                        A_TB.Focus();
                        throw new Exception("Не введенно значение");
                    }
                    int a;
                    if (!int.TryParse(A_TB.Text, out a))
                    {
                        A_TB.Focus();
                        throw new Exception("Значение должно быть целым");
                    }
                }
                catch(Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Ошибка");
                }
            }
        }
    }
}
