using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FuelModele;



namespace FuelView
{
    public partial class MainForm : Form
    {
        BindingList<IFuelable> all = new BindingList<IFuelable>();
        public MainForm()
        {
            InitializeComponent();
            mainDataGridView.AutoGenerateColumns = false;
            mainDataGridView.DataSource = all;
        }

        /// <summary>
        /// обработчик событий при нажатии на кнопку добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                all.Add(addForm.IFuelable);
            }
        }

        /// <summary>
        /// удаление из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(mainDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет элементов для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                int index = mainDataGridView.SelectedCells[0].RowIndex;
                all.RemoveAt(index);
        }

        /// <summary>
        /// вызов Search формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Элементов для поиска не существует.\nДобавте рассчет и повторите запрос",
                    "Ошибка поиска", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SearchForm form = new SearchForm(all);
                form.ShowDialog();
            }
        }

        /// <summary>
        /// сериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            Stream mystream;
            BinaryFormatter bf = new BinaryFormatter();
            SaveFileDialog fsd = new SaveFileDialog();
            fsd.Filter = ".dat файлы(*.dat)|*.dat";
            if (fsd.ShowDialog() == DialogResult.OK)
            {
                if ((mystream = fsd.OpenFile()) != null)
                {
                    bf.Serialize(mystream, all);
                    mystream.Close();
                }
            }
        }

        /// <summary>
        /// десериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            BinaryFormatter bf = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".dat файлы (*.dat) | *.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = ofd.OpenFile()) != null)
                    {
                        using (mystream)
                        {
                            all = (BindingList<IFuelable>)bf.Deserialize(mystream);
                            mainDataGridView.DataSource = all;
                            mystream.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка загрузки файла\nУбедитесь, что формат файла поддерживается",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
