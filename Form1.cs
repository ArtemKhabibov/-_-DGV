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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pages_B_Click(object sender, EventArgs e)
        {
            int countpages = Convert.ToInt32(Pages_TB.Text); //Число окон получаем из TextBox
            
            for(int i = 0; i < countpages; i++)
            {
                TabPage newTabPage = new TabPage();
                newTabPage.Text = "Страница " + (i + 1).ToString();  //Имя окна можно брать из названия ChekBox
                Tab_TC.TabPages.Add(newTabPage);                     //Создание самого окна

                //Создаем в каждом окне DGV с именем
                Tab_TC.TabPages[i].Controls.Add(new DataGridView()
                {
                    Name = "DGV_" + (i + 1).ToString(),
                    Dock = DockStyle.Fill,
                    ColumnCount = 4,RowCount = 3, RowHeadersVisible = false,AllowUserToAddRows = false, AllowUserToDeleteRows = false,
                });
                //Устанавливаем названия заголовков столбцов
                var dg = Tab_TC.TabPages[i].Controls.OfType<DataGridView>().FirstOrDefault(x => x.Name == ("DGV_" + (i + 1).ToString()));
                if (dg != null)
                    for (int j = 0; j < dg.ColumnCount; j++)
                    {
                        dg.Columns[j].HeaderText = "Text";
                        dg[0, 0].Value = "More text";
                    }
                
            }
        }
        //При нажатии на текст DGV создаем новую форму
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.ColumnCount != 0)
            {
                //Проверка на то, что нажали на первую колонку
                if (DGV.CurrentCell.ColumnIndex == 0)
                {
                    //Создание формы
                    Form2_Clicked Dialog = new Form2_Clicked();
                    Dialog.Text = "Временная форма";
                    if(Dialog.ShowDialog() == DialogResult.OK)
                    {
                        //Дальше весь код, который нужен в форме, прописываем ниже
                    }
                }
            }
        }
        //Определение количества строк для DGV
        private void Form1_Load(object sender, EventArgs e)
        {
            DGV.ColumnCount = Convert.ToInt32(Col_NUD.Value);
            DGV.RowCount = Convert.ToInt32(Row_NUD.Value);

            DGV[0, 0].Value = "Перейти на форму";
            DGV[1, 0].Value = "Text";
        }

        private void Row_NUD_ValueChanged(object sender, EventArgs e)
        {
            DGV.RowCount = Convert.ToInt32(Row_NUD.Value);
        }

        private void Col_NUD_ValueChanged(object sender, EventArgs e)
        {
            DGV.ColumnCount = Convert.ToInt32(Col_NUD.Value);
        }
    }
}
