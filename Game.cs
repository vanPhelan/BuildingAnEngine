using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        private static bool _gameOver = false; //The game will end when set to true

        ///Run the game
        public void Run()
        {
            //Initialize the game
            Start();
            //Loop until the game is over
            while (!_gameOver)
            {
                //Step through the game logic
                Update();
                //Render the game to the screen
                Draw();
            }
            //Shut down the game
            End();
        }

        ///Initialize the game
        public void Start()
        {
            
        }

        ///Step through game logic
        public void Update()
        {
            
        }

        ///Render the game to the screen
        public void Draw()
        {

        }

        ///Shut down the game
        public void End()
        {
            
        }

        ///Set whether the game should end
        public static void SetGameOver(bool value)
        {
            _gameOver = value;
        }
    }
}
