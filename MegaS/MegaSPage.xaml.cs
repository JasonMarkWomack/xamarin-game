using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace MegaS
{
    public partial class MegaSPage : ContentPage
    {
        private Button[] button = new Button[9];
		private GameEngine game = new GameEngine();

		public MegaSPage()
        {
            InitializeComponent();

			button[0] = button1;
			button[1] = button2;
			button[2] = button3;
			button[3] = button4;
			button[4] = button5;
			button[5] = button6;
			button[6] = button7;
			button[7] = button8;
			button[8] = button9;
        
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            game.SetButton((Button)sender);
            if (game.CheckWinner(button))
            {
               
                GameOverStackLayout.IsVisible = true;
            }
        }
        private void playagain_Clicked(object sender, EventArgs e)
        {
            game.ResetGame(button);
            GameOverStackLayout.IsVisible = false;
        }
    }
}
