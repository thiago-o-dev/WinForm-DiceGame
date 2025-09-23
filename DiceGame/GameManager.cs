using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public static class GameManager
    {
        public static Action isEndTurn;

        public class DiceController
        {
            static string rootpath = "C:\\Users\\Aula\\source\\repos\\DiceGame\\DiceGame\\";

            string spinningDice = rootpath + "Resources\\DiceAssets\\dicerolling_gif.gif";

            string[] diceStatic = new [] {
                rootpath + "Resources\\DiceAssets\\1.png",
                rootpath + "Resources\\DiceAssets\\2.png",
                rootpath + "Resources\\DiceAssets\\3.png",
                rootpath + "Resources\\DiceAssets\\4.png",
                rootpath + "Resources\\DiceAssets\\5.png",
                rootpath + "Resources\\DiceAssets\\6.png",
            };

            private PictureBox _diceReference = null;
            int remainingSpins = 3;
            bool isSpinning = false;
            int currentSpin = 1;
            static Random _randInt;

            public DiceController(PictureBox diceReference)
            {
                GameManager.isEndTurn += ResetDice;
                _diceReference = diceReference;
                _randInt = new Random();
            }

            public async Task SpinDice(bool isRigged)
            {
                if (!isSpinning)
                {
                    isSpinning = true;
                    List<int> diceWeights = new List<int> { 1, 2, 3, 4, 5, 6 };
                    if (isRigged)
                        diceWeights = new List<int> { 1, 2, 3, 4, 5, 6, 6, 6 };

                    

                    await StartSpinningAnimation(diceWeights[_randInt.Next(1, diceWeights.Count())]);
                }
            }

            private async Task StartSpinningAnimation(int diceResult)
            {
                _diceReference.ImageLocation = spinningDice;

                var waitTime = _randInt.Next(1000, 3000);
                Console.WriteLine(waitTime);

                await Task.Delay(waitTime);

                _diceReference.ImageLocation = diceStatic[diceResult];

                currentSpin = diceResult;

                if (remainingSpins > 0)
                {
                    remainingSpins--;
                    isSpinning = false;
                }
                else
                {
                    GameManager.isEndTurn();
                }
            }
            public void MaintainDice()
            {
                if (!isSpinning)
                {
                    GameManager.isEndTurn();
                }
            }

            private void ResetDice()
            {
                remainingSpins = 3;
                isSpinning = false;
            }
            public int GetCurrentSpin()
            {
                return currentSpin;
            }
        }

        
    }
}
