using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp_Pr_6._1
{
    internal class PetShopSingleton
    {
        public static PetShopSingleton instance;
        public static PetShopSingleton GetInstance()
        {
            if (instance == null)
                instance = new PetShopSingleton();
            return instance;
        }
        
        /// <summary>
        /// Метод AccidentallyFood() случайные события для покупки корма.
        /// </summary>
        public void AccidentallyFood()
        {
            Random random = new Random();
            int rand = random.Next(0, 3);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("Ай, ваш корм убежал от вас!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("Ой, к сожалению оплата не прошла, ваши деньги обязательно вернуться к вам!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 2:
                    MessageBox.Show("Ааа... В корме семья тараканов!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }
        /// <summary>
        /// Метод AccidentallyTurtleLook() случайных событий для наблюдения за животными.
        /// </summary>
        public void AccidentallyTurtleLook()
        {
            Random random = new Random();
            int rand = random.Next(0, 3);
            switch (rand)
            {
                case 0:
                    MessageBox.Show("Ой.. Черепаха сбежала!!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 1:
                    MessageBox.Show("Вместо черепахи вы обратили внимание на инопланетную собаку, такие разве бывают????!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case 2:
                    DialogResult result = MessageBox.Show("О нет, продавец съел вас!", "Случайное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) { Application.Exit(); }
                    break;
            }
        }
    }
}
