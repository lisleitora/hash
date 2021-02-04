using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace velha
{
    public partial class MainPage : ContentPage
    {
        public List<Button> PlayerMarks = new List<Button>();
        public List<Button> RobotMarks = new List<Button>();


        public MainPage()
        {
            InitializeComponent();
            ClearAll();
        }
        
        public void Jogar(Button button)
        {
            if (button.Text!="")
            {
                return;
            }
            Mark(button, "X");
            CheckWin("X");
            playbot();
        }
        public async void playbot()
        {

            await Task.Delay(300);
            if(
               Checkbot("X","","","","","","","","") ||
               Checkbot("", "", "X", "", "", "", "", "", "") ||
               Checkbot("", "", "", "", "", "", "X", "", "") ||
               Checkbot("", "", "", "", "", "", "", "", "X") ||
               Checkbot("", "X", "", "", "", "", "", "", "") ||
               Checkbot("", "", "", "X", "", "", "", "", "") ||
               Checkbot("", "", "", "", "", "X", "", "", "") ||
               Checkbot("", "", "", "", "", "", "", "X", "") ||
               Checkbot("X", "", "", "", "", "", "", "", "")
               )
            {
                Mark(p5,"O");
                CheckWin("O");
                return;
            };

            if (
               Checkbot("", "X", "X", "", "O", "", "", "", "") ||
               Checkbot("", "", "X", "", "", "", "", "", "") ||
               Checkbot("", "", "", "", "", "", "X", "", "") ||
               Checkbot("", "", "", "", "", "", "", "", "X") ||
               Checkbot("", "X", "", "", "", "", "", "", "") ||
               Checkbot("", "", "", "X", "", "", "", "", "") ||
               Checkbot("", "", "", "", "", "X", "", "", "") ||
               Checkbot("", "", "", "", "", "", "", "X", "") ||
               Checkbot("X", "", "", "", "", "", "", "", "")
               )
            {
                Mark(p1, "O");
                CheckWin("O");
                return;
            };

            if (
               Checkbot("O", "X", "X", "", "O", "X", "", "", "")||
               Checkbot("O", "X", "X", "X", "O", "", "", "", "")||
               Checkbot("O", "X", "X", "", "O", "", "X", "", "")||
               Checkbot("O", "X", "X", "", "O", "", "", "X", "")
               )
            {
                Mark(p9, "O");
                CheckWin("O");
                return;
            };
        }

        public bool Checkbot(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9)
        {
            bool result = p1.Text == s1 && p2.Text == s2 && p3.Text == s3 && p4.Text == s4 && p5.Text == s5 && p6.Text == s6 && p7.Text == s7 && p8.Text == s8 && p9.Text == s9;
            return result;
        }

         public void CheckWin(string symbol)
        {
            if (p1.Text == symbol && p2.Text == symbol && p3.Text == symbol)
            {
                Winner(p1, p2, p3);
            }
            if (p1.Text == symbol && p4.Text == symbol && p7.Text == symbol)
            {
                Winner(p1, p4, p7);
            }
            if (p2.Text == symbol && p5.Text == symbol && p8.Text == symbol)
            {
                Winner(p2, p5, p8);
            }
            if (p3.Text == symbol && p6.Text == symbol && p9.Text == symbol)
            {
                Winner(p3, p6, p9);
            }
            if (p1.Text == symbol && p5.Text == symbol && p9.Text == symbol)
            {
                Winner(p1, p5, p9);
            }
            if (p3.Text == symbol && p5.Text == symbol && p7.Text == symbol)
            {
                Winner(p3, p5, p7);
            }
            if (p4.Text == symbol && p5.Text == symbol && p6.Text == symbol)
            {
                Winner(p4, p5, p6);
            }
            if (p7.Text == symbol && p8.Text == symbol && p9.Text == symbol)
            {
                Winner(p7, p8, p9);
            }

        }

        public async void Winner(Button b1, Button b2, Button b3)
        {
            b1.BackgroundColor = Color.GreenYellow;
            b2.BackgroundColor = Color.GreenYellow;
            b3.BackgroundColor = Color.GreenYellow;
            await Task.Delay(2000);
            ClearAll();

        }
        public void Mark(Button button, string symbol)
        {
            button.Text = symbol;
            if (symbol=="X")
            {
                PlayerMarks.Add(button);
                
            }
            if (symbol == "O")
            {
                RobotMarks.Add(button);

            }

        }


        public void ClearAll()
        {
            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            p4.Text = "";
            p5.Text = "";
            p6.Text = "";
            p7.Text = "";
            p8.Text = "";
            p9.Text = "";
            p1.BackgroundColor = Color.White; p2.BackgroundColor = Color.White; p3.BackgroundColor = Color.White; p4.BackgroundColor = Color.White; p5.BackgroundColor = Color.White; p6.BackgroundColor = Color.White; p7.BackgroundColor = Color.White; p8.BackgroundColor = Color.White; p9.BackgroundColor = Color.White;
        }

        void p1_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

        void p2_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

        void p3_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

        void p4_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

        void p5_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

        void p6_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

        void p7_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

        void p8_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

        void p9_Clicked(System.Object sender, System.EventArgs e)
        {
            Jogar((Button)sender);
        }

    };
};