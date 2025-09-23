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

        private int dicePlayer1 = 0;
        private int dicePlayer2 = 0;

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

            if (playerTurn % 2 == 0)
            {
                lastDicePlayer1.Text = $"Ultimo dado do Jogador 1: {spinValue}";
                dicePlayer1 = spinValue;
            }
            else
            {
                lastDicePlayer2.Text = $"Ultimo dado do Jogador 2: {spinValue}";
                dicePlayer2 = spinValue;

                if (dicePlayer1 > dicePlayer2)
                    turnWinIndicator.Text = $"O Jogador 1 venceu o round { playerTurn << 1 }!";
                else if (dicePlayer2 > dicePlayer1)
                    turnWinIndicator.Text = $"O Jogador 2 venceu o round { playerTurn << 1 }!";
                else
                    turnWinIndicator.Text = $"Empate no round { playerTurn << 1 }!";
            }

            playerTurn++;
            turnIndicator.Text = $"Turno do Jogador {(playerTurn % 2) + 1}";
        }
    }
}
