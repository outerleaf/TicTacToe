using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FInalProjectTTT
{


    public partial class Form1 : Form
    {
        class check5
        {
            public bool check;
        }
        check5 check = new check5();
        public Button[] getButtons()
        {
            Button[] butArray = new[] {btnTic1,btnTic2,btnTic3,btnTic4,
                                            btnTic5,btnTic6,btnTic7,btnTic8,
                                            btnTic9,btnTic10,btnTic11,btnTic12,
                                            btnTic13,btnTic14,btnTic15,btnTic16 };
            return butArray;
        }


        void playerWinner(Button a, Button b, Button c, Button d, bool winner)
        {


            //color does not change need to fix

            if (winner == true)//winner x
            {
                playerXscorebox.Text = Convert.ToString(int.Parse(playerXscorebox.Text) + 1);


                a.BackColor = Color.Purple;
                b.BackColor = Color.Purple;
                c.BackColor = Color.Purple;
                d.BackColor = Color.Purple;
                MessageBox.Show("The winner is " + playerXlbl.Text + "!");
            }
            else//winner 0
            {
                playerOscorebox.Text = Convert.ToString(int.Parse(playerOscorebox.Text) + 1);


                a.BackColor = Color.Blue;
                b.BackColor = Color.Blue;
                c.BackColor = Color.Blue;
                d.BackColor = Color.Blue;
                MessageBox.Show("The winner is " + playerOlbl.Text + "!");
            }
            //resetButtons();

        }
        void scorecheck()
        {  //horizontal 
            if ((btnTic1.Text == "X") && (btnTic2.Text == "X") && (btnTic3.Text == "X") && (btnTic4.Text == "X"))
            {
                playerWinner(btnTic1, btnTic2, btnTic3, btnTic4, true);
            }
            else if ((btnTic5.Text == "X") && (btnTic6.Text == "X") && (btnTic7.Text == "X") && (btnTic8.Text == "X"))
            {
                playerWinner(btnTic5, btnTic6, btnTic7, btnTic8, true);

            }
            else if ((btnTic9.Text == "X") && (btnTic10.Text == "X") && (btnTic11.Text == "X") && (btnTic12.Text == "X"))
            {
                playerWinner(btnTic9, btnTic10, btnTic11, btnTic12, true);

            }
            else if ((btnTic13.Text == "X") && (btnTic14.Text == "X") && (btnTic15.Text == "X") && (btnTic16.Text == "X"))
            {
                playerWinner(btnTic13, btnTic14, btnTic15, btnTic16, true);

            }//vertical 1-5-9-13, 2-6-10-14,3-7-11-15, 4-8-12-16
            else if ((btnTic1.Text == "X") && (btnTic5.Text == "X") && (btnTic9.Text == "X") && (btnTic13.Text == "X"))
            {
                playerWinner(btnTic1, btnTic5, btnTic9, btnTic13, true);
            }
            else if ((btnTic2.Text == "X") && (btnTic6.Text == "X") && (btnTic10.Text == "X") && (btnTic14.Text == "X"))
            {
                playerWinner(btnTic2, btnTic6, btnTic10, btnTic14, true);

            }
            else if ((btnTic3.Text == "X") && (btnTic7.Text == "X") && (btnTic11.Text == "X") && (btnTic15.Text == "X"))
            {
                playerWinner(btnTic3, btnTic7, btnTic11, btnTic15, true);

            }
            else if ((btnTic4.Text == "X") && (btnTic8.Text == "X") && (btnTic12.Text == "X") && (btnTic16.Text == "X"))
            {
                playerWinner(btnTic4, btnTic8, btnTic12, btnTic16, true);

            }//diagonal 1-6-11-16,4-7-10-13
            else if ((btnTic1.Text == "X") && (btnTic6.Text == "X") && (btnTic11.Text == "X") && (btnTic16.Text == "X"))
            {
                playerWinner(btnTic1, btnTic6, btnTic11, btnTic16, true);

            }
            else if ((btnTic4.Text == "X") && (btnTic7.Text == "X") && (btnTic10.Text == "X") && (btnTic13.Text == "X"))
            {
                playerWinner(btnTic4, btnTic7, btnTic10, btnTic13, true);

            }// winner is o
            else if ((btnTic1.Text == "O") && (btnTic2.Text == "O") && (btnTic3.Text == "O") && (btnTic4.Text == "O"))
            {
                playerWinner(btnTic1, btnTic2, btnTic3, btnTic4, false);
            }
            else if ((btnTic5.Text == "O") && (btnTic6.Text == "O") && (btnTic7.Text == "O") && (btnTic8.Text == "O"))
            {
                playerWinner(btnTic5, btnTic6, btnTic7, btnTic8, false);

            }
            else if ((btnTic9.Text == "O") && (btnTic10.Text == "O") && (btnTic11.Text == "O") && (btnTic12.Text == "O"))
            {
                playerWinner(btnTic9, btnTic10, btnTic11, btnTic12, false);

            }
            else if ((btnTic13.Text == "O") && (btnTic14.Text == "O") && (btnTic15.Text == "O") && (btnTic16.Text == "O"))
            {
                playerWinner(btnTic13, btnTic14, btnTic15, btnTic16, false);

            }//vertical 1-5-9-13, 2-6-10-14,3-7-11-15, 4-8-12-16
            else if ((btnTic1.Text == "O") && (btnTic5.Text == "O") && (btnTic9.Text == "O") && (btnTic13.Text == "O"))
            {
                playerWinner(btnTic1, btnTic5, btnTic9, btnTic13, false);
            }
            else if ((btnTic2.Text == "O") && (btnTic6.Text == "O") && (btnTic10.Text == "O") && (btnTic14.Text == "O"))
            {
                playerWinner(btnTic2, btnTic6, btnTic10, btnTic14, false);

            }
            else if ((btnTic3.Text == "O") && (btnTic7.Text == "O") && (btnTic11.Text == "O") && (btnTic15.Text == "O"))
            {
                playerWinner(btnTic3, btnTic7, btnTic11, btnTic15, false);

            }
            else if ((btnTic4.Text == "O") && (btnTic8.Text == "O") && (btnTic12.Text == "O") && (btnTic16.Text == "O"))
            {
                playerWinner(btnTic4, btnTic8, btnTic12, btnTic16, false);

            }//diagonal 1-6-11-16,4-7-10-13
            else if ((btnTic1.Text == "O") && (btnTic6.Text == "O") && (btnTic11.Text == "O") && (btnTic16.Text == "O"))
            {
                playerWinner(btnTic1, btnTic6, btnTic11, btnTic16, false);

            }
            else if ((btnTic4.Text == "O") && (btnTic7.Text == "O") && (btnTic10.Text == "O") && (btnTic13.Text == "O"))
            {
                playerWinner(btnTic4, btnTic7, btnTic10, btnTic13, false);

            }
            else
            {
            }
        }

        void placePoint(check5 checker, Button a)
        {
            if (checker.check == true)
            {
                a.Text = "X";
                playerXlbl.BackColor = Color.Red;
                playerOlbl.BackColor = Color.Green;
            }
            if (checker.check == false)
            {
                a.Text = "O";
                playerXlbl.BackColor = Color.Green;
                playerOlbl.BackColor = Color.Red;
            }
            scorecheck();
            //after every move MessageBox.Show("The winnwer is player fdsa");
            checker.check = !checker.check;
            a.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to Tic-Tac-Toe with saving capabilites\n Created By Ian Woytowich and Amine Sabil");

            playerXlbl.Text = Interaction.InputBox("What is Player X's Name: ", "Player X Name Creation", "Player X", 1, 1);
            playerOlbl.Text = Interaction.InputBox("What is Player O's Name: ", "Player O Name Creation", "Player O", 1, 1);
            if (playerXlbl.Text == "")
            {
                playerXlbl.Text = "Player X";
            }
            if (playerOlbl.Text == "")
            {
                playerOlbl.Text = "Player O";

            }
            //maybe ask for names here   
        }




        private void button1_Click(object sender, EventArgs e)
        {           // placePoint(check,btnTic1);

        }
        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // placePoint(check, btnTic2);

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic1);

        }
        private void btnTic2_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic2);
        }
        private void btnTic3_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic3);
        }
        private void btnTic4_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic4);

        }
        private void btnTic5_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic5);

        }
        private void btnTic6_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic6);

        }
        private void btnTic7_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic7);

        }
        private void btnTic8_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic8);

        }
        private void btnTic9_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic9);

        }
        private void btnTic10_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic10);
        }
        private void btnTic11_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic11);
        }
        private void btnTic12_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic12);

        }
        private void btnTic13_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic13);

        }
        private void btnTic14_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic14);

        }
        private void btnTic15_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic15);

        }
        private void btnTic16_Click(object sender, EventArgs e)
        {
            placePoint(check, btnTic16);

        }
        private void btnTic1_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic1);

        }
        private void btnTic2_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic2);

        }
        private void btnTic3_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic3);

        }
        private void btnTic4_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic4);

        }
        private void btnTic5_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic5);

        }
        private void btnTic6_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic6);

        }
        private void btnTic7_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic7);

        }
        private void btnTic8_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic8);

        }
        private void btnTic9_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic9);

        }
        private void btnTic10_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic10);
        }
        private void btnTic11_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic11);
        }
        private void btnTic12_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic12);

        }
        private void btnTic13_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic13);

        }
        private void btnTic14_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic14);

        }
        private void btnTic15_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic15);

        }
        private void btnTic16_Click_1(object sender, EventArgs e)
        {
            placePoint(check, btnTic16);

        }
        private void btnTic12_Click_2(object sender, EventArgs e)
        {
            placePoint(check, btnTic12);
        }
        private void btnTic11_Click_2(object sender, EventArgs e)
        {
            placePoint(check, btnTic11);

        }
        private void btnTic10_Click_2(object sender, EventArgs e)
        {
            placePoint(check, btnTic10);

        }
        private void btnTic9_Click_2(object sender, EventArgs e)
        {
            placePoint(check, btnTic9);

        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Button[] butArray = getButtons();
            for (int i = 0; i <= 15; i++)
            {
                butArray[i].Enabled = true;
                butArray[i].BackColor = Color.SkyBlue;
                butArray[i].Text = "";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult exitGame = MessageBox.Show("Would you like to close the game? Notice: If you don't have a save key you won't be able to resume this game", "Tic-Tac-Toe",
                MessageBoxButtons.OKCancel);
            if (exitGame == DialogResult.OK)
                Application.Exit();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this b utton no longer exists
        }

        private string getButtonValues()
        {
            string buttonValues = "";
            Button[] butArray = getButtons();
            for (int i = 0; i <= 15; i++)
            {
                if (butArray[i].Text == "X")
                {
                    buttonValues += "X";
                }
                else if (butArray[i].Text == "O")
                {
                    buttonValues += "O";
                }
                else
                {
                    buttonValues += "B";
                }
            }
            return buttonValues;



        }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            //get information on table 16 button values
            //scores as well and convert into something to save
            string message = "If you would like to save this game, type a savekey and click 'Ok'; Otherwise click 'Cancel'";
            string fileSave = "";

            fileSave = Interaction.InputBox(message, "Save Game Here", "", 1, 1);
            //is doing weird things but makes a box and has a input
            //fileSave = "save1file";
            if (fileSave != "")
            {
                //do file stuff
                if (File.Exists(fileSave))
                {
                    File.Delete(fileSave);//will overide old save
                }
                using (StreamWriter filewriter = File.CreateText(fileSave))
                {
                    filewriter.WriteLine(playerXlbl.Text);
                    filewriter.WriteLine(playerOlbl.Text);
                    filewriter.WriteLine(playerXscorebox.Text);
                    filewriter.WriteLine(playerOscorebox.Text);
                    filewriter.WriteLine(getButtonValues());
                    MessageBox.Show("Game saved correctly, have a good day");
                    //need to press the close button and ask if they want to leave;
                    //closeBtn(sender, e);

                    DialogResult exitGame = MessageBox.Show("Would you like to close the game? Notice: If you don't have a save key you won't be able to resume this game", "Tic-Tac-Toe",
                        MessageBoxButtons.OKCancel);
                    if (exitGame == DialogResult.OK)
                        Application.Exit();
                }
            }

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string message = "If you would like to load a game, type the savekey and click 'Ok'; Otherwise press 'Cancel'";
            string title = "Load Screen";
            string fileSave = "";
            fileSave = Interaction.InputBox(message, title, "", 1, 1);
            //is doing weird things but makes a box and has a input
            // fileSave = "save1file";
            if (fileSave != "")
            {
                StreamReader readingFile = File.OpenText(fileSave);
                playerXlbl.Text = Convert.ToString(readingFile.ReadLine());
                playerOlbl.Text = Convert.ToString(readingFile.ReadLine());
                playerXscorebox.Text = Convert.ToString(readingFile.ReadLine());
                playerOscorebox.Text = Convert.ToString(readingFile.ReadLine());
                Button[] butArray = getButtons();

                for (int i = 0; i <= 15; i++)
                {
                    butArray[i].Text = Convert.ToString(readingFile.Read());


                    if (butArray[i].Text == "79")
                    {
                        butArray[i].Text = "O";
                    }
                    else if (butArray[i].Text == "88")
                    {
                        butArray[i].Text = "X";
                    }
                    else
                    {
                        butArray[i].Text = "";
                    }


                }
                scorecheck();
            }
        }
    }
}

