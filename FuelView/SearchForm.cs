using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FuelModele;

namespace FuelView
{
    public partial class SearchForm : Form
    {
        private BindingList<IFuelable> all;
        public SearchForm(BindingList<IFuelable> list)
        {
            all = list;
            InitializeComponent();
            resultGridView.AutoGenerateColumns = false;
        }

        /// <summary>
        /// валидация данных, вводить можно только числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back))
                e.Handled = false;
            else
            {
                MessageBox.Show("Вводить можно только числа", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        /// <summary>
        /// обработчик событий при нажатии кнопки найти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            List<IFuelable> foundList = new List<IFuelable>();
            for (int i = 0; i < all.Count; i++)
            {
                IFuelable ifuelable = all[i];
                if (ContainsString(Convert.ToString(ifuelable.CalcFuel), RasTextBox.Text))
                {
                    foundList.Add(ifuelable);
                    resultGridView.DataSource = null;
                    resultGridView.DataSource = foundList;
                }
                else
                {
                    MessageBox.Show("По вашему запросу ничего не найдено", "Ошибка",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

      /*  private bool ContainsNumber(int field, int search)
        {
            if (search == 0)
            {
                return false;
            }
            if (field == search)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
       /// <summary>
       /// если начинается с таких же чисел, не значит что тоже самое число
       /// </summary>
       /// <param name="field"></param>
       /// <param name="search"></param>
       /// <returns></returns>
       private bool ContainsString(string field, string search)
        {
            if (field.StartsWith(search))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// кнопка найти не активна, пока TextBox не заполнен
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RasTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RasTextBox.Text == "")
            {
                FindButton.Enabled = false;
            }
            else
            {
                FindButton.Enabled = true;
            }
        }
    }
}
