using System;
using System.Windows.Forms;

namespace DnDTools.Screens
{
    public partial class DiceRoller : Form
    {
        public DiceRoller()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RollAllDice_Click(object sender, EventArgs e)
        {
            D2Output.Text = RollTheDice(D2Input.Text, 2);
            D4Output.Text = RollTheDice(D4Input.Text, 4);
            D6Output.Text = RollTheDice(D6Input.Text, 6);
            D8Output.Text = RollTheDice(D8Input.Text, 8);
            D10Output.Text = RollTheDice(D10Input.Text, 10);
            D12Output.Text = RollTheDice(D12Input.Text, 12);
            D20Output.Text = RollTheDice(D20Input.Text, 20);
            D100Output.Text = RollTheDice(D100Input.Text, 100);
            DXOutput.Text = RollTheDice(DXInput.Text, DX.Text);
        }

        private string RollTheDice(string num, string size)
        {
            var numRolls = 0;
            try
            {
                numRolls = Convert.ToInt32(num);
            }catch(FormatException e)
            {
                return "Invalid Number Of Rolls";
            }
            var sizeOfDice = 0;
            try
            {
                sizeOfDice = Convert.ToInt32(size);
            }
            catch (FormatException e)
            {
                return "Invalid Size of Dice";
            }

            var random = new Random();
            string returnString = "";

            for(int i = 0; i < numRolls; i++)
            {
                returnString += random.Next(1, sizeOfDice + 1).ToString() + ", ";
            }

            return returnString.TrimEnd(','); ;
        }

        private string RollTheDice(int num, int size)
        {
            var random = new Random();
            string returnString = "";

            for (int i = 0; i < num; i++)
            {
                returnString += random.Next(1, size + 1).ToString() + ", ";
            }

            return returnString.TrimEnd(',');
        }

        private string RollTheDice(string num, int size)
        {
            var numRolls = 0;
            try
            {
                numRolls = Convert.ToInt32(num);
            }
            catch (FormatException e)
            {
                return "Invalid Number Of Rolls";
            }

            var random = new Random();
            string returnString = "";

            for (int i = 0; i < numRolls; i++)
            {
                returnString += random.Next(1, size +1).ToString() + ", ";
            }

            return returnString.TrimEnd(','); ;
        }
    }
}
