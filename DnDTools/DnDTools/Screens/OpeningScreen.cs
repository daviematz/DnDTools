using DnDTools.Screens;
using System.Windows.Forms;

namespace DnDTools
{
    public partial class OpeningScreen : Form
    {
        public OpeningScreen()
        {
            InitializeComponent();
        }

        private void CharacterCreator_Click(object sender, System.EventArgs e)
        {

        }

        private void DiceRoller_Click(object sender, System.EventArgs e)
        {
            new DiceRoller().Show();
        }
    }
}
