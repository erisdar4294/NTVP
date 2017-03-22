using System;
using FuelModele;
using System.Windows.Forms;


namespace FuelView
{
    public partial class AddForm : Form
    {
        public IFuelable IFuelable { get; set; }
        Random random = new Random();

        public AddForm()
        {
            InitializeComponent();
            typeComboBox.SelectedIndex = 0;
#if !DEBUG //Пункт 11. Если режим не дебаг то это релиз, и там нам не нужна эта кнопка.
            generateButton.Visible = false;
#endif
        }

        /// <summary>
        /// обработчик событий при нажатии ок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch(typeComboBox.SelectedIndex)
                {
                    case 0:
                        Car car = new Car();
                        car.Coastof = int.Parse(CoastofTextBox.Text);
                        car.Distance = int.Parse(DistanceTextBox.Text);
                        car.Consuption = int.Parse(ConsuptionTextBox.Text);
                        IFuelable = car;
                        break;
                    case 1:
                        HybridCar hybrid = new HybridCar();
                        hybrid.ChargingCoast = int.Parse(ChargingCoastTextBox.Text);
                        hybrid.Distance = int.Parse(DistanceTextBox.Text);
                        hybrid.Time = int.Parse(TimeTextBox.Text);
                        IFuelable = hybrid;
                        break;
                    case 2:
                        Helicopter helicopter = new Helicopter();
                        helicopter.InsuranceLife = int.Parse(InsurTextBox.Text);
                        helicopter.RentHelicopter = int.Parse(RentTextBox.Text);
                        helicopter.Time = int.Parse(TrentTextBox.Text);
                        IFuelable = helicopter;
                        break;       
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        /// <summary>
        /// при выборе варианта из комбобокса
        /// меняется и активность текст боксов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeComboBox.SelectedIndex)
            {
                case 0:
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    CoastofTextBox.Visible = true;
                    ConsuptionTextBox.Visible = true;
                    DistanceTextBox.Visible = true;
                    ChargingCoastTextBox.Visible = false;
                    TimeTextBox.Visible = false;
                    RentTextBox.Visible = false;
                    TrentTextBox.Visible = false;
                    InsurTextBox.Visible = false;
                    break;
                case 1:

                    label2.Visible = false;
                    label3.Visible = true;
                    label4.Visible = false;
                    label5.Visible = true;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = true;
                    CoastofTextBox.Visible = false;
                    ConsuptionTextBox.Visible = false;
                    DistanceTextBox.Visible = true;
                    ChargingCoastTextBox.Visible = true;
                    TimeTextBox.Visible = true;
                    RentTextBox.Visible = false;
                    TrentTextBox.Visible = false;
                    InsurTextBox.Visible = false;
                    break;
                case 2:
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = false;
                    CoastofTextBox.Visible = false;
                    ConsuptionTextBox.Visible = false;
                    DistanceTextBox.Visible = false;
                    ChargingCoastTextBox.Visible = false;
                    TimeTextBox.Visible = false;
                    RentTextBox.Visible = true;
                    TrentTextBox.Visible = true;
                    InsurTextBox.Visible = true;
                    break;
            }
            
        }

        /// <summary>
        /// в комбобоксы можно вводить только числа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoastofTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        /// обработчик событий при нажатии на кнопку  генерации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            int f = random.Next(1, 999);
            typeComboBox.SelectedIndex = typeTransport(0, 3);
            CoastofTextBox.Text = Convert.ToString(f);
            ConsuptionTextBox.Text = Convert.ToString(f);
            DistanceTextBox.Text = Convert.ToString(f);
            ChargingCoastTextBox.Text = Convert.ToString(f);
            TimeTextBox.Text = Convert.ToString(f);
            RentTextBox.Text = Convert.ToString(f);
            TrentTextBox.Text = Convert.ToString(f);
            InsurTextBox.Text = Convert.ToString(f);
        }

        /// <summary>
        /// случайный выбор из комбобокса
        /// </summary>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        private int typeTransport(int minLength, int maxLength)
        {
            typeComboBox.SelectedIndex = random.Next(0, 3);
            return typeComboBox.SelectedIndex;
        }
    }
}
