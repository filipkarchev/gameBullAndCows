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
    public partial class UserInicialisation : Form
    {   public int ID=0;
        string userName;
        public UserInicialisation(string name)
        {
            InitializeComponent();
            userName = name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int userNumber ;

            if (Operations.CheckIsNumber(txtNumber.Text) && (txtNumber.Text.Length == Operations.numberLength) && Operations.CheckNumber((txtNumber.Text)))
            {
                //Ако числото е подходящо,се създава нов user и се записва в базата
                userNumber = int.Parse(txtNumber.Text);
                User user = new User();
                user.Number = userNumber;
                user.UserName = userName;
                UserData.InsertUser(user);
           
                this.Close();
              
            }
            else MessageBox.Show("Неподходящо число");
        }

        private void UserInicialisation_Load(object sender, EventArgs e)
        {
       
            lblName.Text=userName;
        
        }
    }
}
