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
    public partial class Game : Form
    {
        User user1 = UserData.GetUserById(1);
        User user2 = UserData.GetUserById(2);
        int turn = 1;
        public Game()
        {
            InitializeComponent();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Определяме с числото на кой потребител,ще проверим за съответствие
            User user = null;
            if (turn == 1)
            {
                user = user1;
                //   turn = 2;
            }
            else if (turn == 2)
            {
                user = user2;
                //      turn = 1;
            }


            int number; 
 

            int secondNumber = (int)user.Number;
            int bulls = 0;
            if (Operations.CheckIsNumber(txtNumber.Text) && (txtNumber.Text.Length == Operations.numberLength) && Operations.CheckNumber(txtNumber.Text))
            {
                number = int.Parse(txtNumber.Text);
                Atempt at = new Atempt();
                at.id_user = turn;
                at.number = number;

                bulls = Operations.Bulls(number, secondNumber);
                if (bulls == Operations.numberLength)
                {
                    DialogResult result = MessageBox.Show("Победител е " + lblName.Text);
                  
                        Operations.finish = true;
    //   AtemptData.DeleteData();
                        this.Close();

                }
                at.bulls = bulls;
                at.cows = Operations.Cows(number, secondNumber);
                AtemptData.InsertAtempt(at);

                this.Close();

            }
            else MessageBox.Show("Невалидно число");
        }

        private void Game_Load(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                turn = 2;
                lblName.Text = user1.UserName;
                txtNumber.Text = "";
                txtHistory.Text = "\n" + AtemptData.GetAtemptByUserId(turn);

            }

            else if (turn == 2)
            {
                turn = 1;
                lblName.Text = user2.UserName;
                txtNumber.Text = "";
                txtHistory.Text ="\n"+ AtemptData.GetAtemptByUserId(turn);

            }
        }


    }
}
