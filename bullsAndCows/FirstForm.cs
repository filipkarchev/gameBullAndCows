using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bullsAndCows
{
    public partial class FirstForm : Form
    {
       
        public int NumberLength { get; set; }
        string firstPlayerName, secondPlayerName;
        public FirstForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            AtemptData.DeleteData();
            if (rb3.Checked == true)
                Operations.numberLength = 3;
            if (rb4.Checked == true)
                Operations.numberLength = 4;
            if (rb5.Checked == true)
                Operations.numberLength = 5;
            if (rb6.Checked == true)
                Operations.numberLength = 6;

            firstPlayerName = txtFirstPlayer.Text;
            secondPlayerName = txtSecondPlayer.Text;

            // Тук трябва да се отвори формата за въвеждане на числата за двамата потребителя
            UserInicialisation first = new UserInicialisation(firstPlayerName);
            first.ShowDialog();
            UserInicialisation second = new UserInicialisation(secondPlayerName);
            second.ShowDialog();
            Game game = new Game();
            while(Operations.finish==false){
            game.ShowDialog();
            }
            Operations.finish = false;
           


        }
    }
}
