using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        private GameManager.DiceController _diceController = null;
        private int playerTurn = 0;

        public Form1()
        {
            InitializeComponent();
            _diceController = new GameManager.DiceController(pictureBox1);

            GameManager.isEndTurn += UpdateCurrentPlayer;
            GameManager.onDiceEndSpinning += UpdateDiceCounter;
            
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            _diceController.SpinDice(false);
        }

        private void btnRoubar_Click(object sender, EventArgs e)
        {
            _diceController.SpinDice(true);
        }

        private void btnManter_Click(object sender, EventArgs e)
        {
            _diceController.MaintainDice();
        }

        private void UpdateDiceCounter()
        {
            numIndicator.Text = _diceController.GetCurrentSpin().ToString();
        }

        private void UpdateCurrentPlayer()
        {
            int spinValue = _diceController.GetCurrentSpin();

            
        }
    }
}
