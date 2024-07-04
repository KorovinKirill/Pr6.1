using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp_Pr_6._1.PetShopSingleton;

namespace WindowsFormsApp_Pr_6._1
{
    public partial class PetShop : Form
    { 
        Client client = new Client(); 
        PetShopSingleton petShopSingleton;

        public double price = 759.99;
        public PetShop()
        {
            InitializeComponent();
            MessageBox.Show("Здравствуйте!", "Консультант зоомагазина 'Хвосты и лапы'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            petShopSingleton = PetShopSingleton.GetInstance();
            //petShopSingleton.Init();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Метод для вычасления остатка после покупки корма.
        /// </summary>
        /// <returns></returns>
        public double Purchase()
        {
            double purchase = client.Money - price;
            client.MoneyRemains(price);
            return purchase;
        }
        private void TurtleLook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите посмотреть на прекрасное животное?", "Консультант зоомагазина 'Хвосты и лапы'", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                petShopSingleton.AccidentallyTurtleLook();
            }
            else
            {
                MessageBox.Show("Жаль, а они у нас такие милые...", "Консультант зоомагазина 'Хвосты и лапы'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Метод для покупки корма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoodBuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Корм стоит 759.99 рублей. Вы точно будете брать?", "Консультант зоомагазина 'Хвосты и лапы'", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (client.Money > price)
                {
                    Purchase();
                    MessageBox.Show("Вот ваш корм, возьмите!", "Консультант зоомагазина 'Хвосты и лапы'", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    petShopSingleton.AccidentallyFood();
                }
                else
                {
                    MessageBox.Show("У вас недостаточно денег!", "Консультант зоомагазина 'Хвосты и лапы'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Тогда посмотрите на наших прекрасных животных!", "Консультант зоомагазина 'Хвосты и лапы'", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Метод для просмотра баланса денег на счету клиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Map_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"У вас на карте: {client.Money} рублей.", "Баланс", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
