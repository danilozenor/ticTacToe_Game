using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe_Game
{
    public partial class Form1 : Form
    {

        Boolean checker;
        int plusone;

        void Enable_false()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic6.Enabled = false;
            btnTic5.Enabled = false;
            btnTic4.Enabled = false;
            btnTic9.Enabled = false;
            btnTic8.Enabled = false;
            btnTic7.Enabled = false;
        }

        void score()
        {
            if (btnTic3.Text == "X" && btnTic2.Text == "X" && btnTic1.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.PowderBlue;
                btnTic2.BackColor = System.Drawing.Color.PowderBlue;
                btnTic3.BackColor = System.Drawing.Color.PowderBlue;



                MessageBox.Show("The winer is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }

            if (btnTic9.Text == "X" && btnTic5.Text == "X" && btnTic1.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Pink;
                btnTic5.BackColor = System.Drawing.Color.Pink;
                btnTic9.BackColor = System.Drawing.Color.Pink;



                MessageBox.Show("The winer is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }



            if (btnTic8.Text == "X" && btnTic5.Text == "X" && btnTic2.Text == "X")
            {
                btnTic2.BackColor = System.Drawing.Color.Crimson;
                btnTic5.BackColor = System.Drawing.Color.Crimson;
                btnTic8.BackColor = System.Drawing.Color.Crimson;



                MessageBox.Show("The winer is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }


            if (btnTic7.Text == "X" && btnTic5.Text == "X" && btnTic3.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;



                MessageBox.Show("The winer is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }


         
            if (btnTic7.Text == "X" && btnTic4.Text == "X" && btnTic1.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Violet;
                btnTic4.BackColor = System.Drawing.Color.Violet;
                btnTic7.BackColor = System.Drawing.Color.Violet;



                MessageBox.Show("The winer is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }

            if (btnTic6.Text == "X" && btnTic5.Text == "X" && btnTic4.Text == "X")
            {
                btnTic6.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic5.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic4.BackColor = System.Drawing.Color.DarkSlateBlue;



                MessageBox.Show("The winer is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }

            if (btnTic9.Text == "X" && btnTic8.Text == "X" && btnTic7.Text == "X")
            {
                btnTic9.BackColor = System.Drawing.Color.Azure;
                btnTic8.BackColor = System.Drawing.Color.Azure;
                btnTic7.BackColor = System.Drawing.Color.Azure;



                MessageBox.Show("The winer is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
               plusone = int.Parse(playerO.Text);
              playerO.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }

            if (btnTic9.Text == "X" && btnTic6.Text == "X" && btnTic3.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.Azure;
                btnTic6.BackColor = System.Drawing.Color.Azure;
                btnTic9.BackColor = System.Drawing.Color.Azure;



                MessageBox.Show("The winer is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
               plusone = int.Parse(playerO.Text);
                playerO.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }


            //-------------------------------------------------------------------



            if (btnTic3.Text == "O" && btnTic2.Text == "O" && btnTic1.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.AliceBlue;
                btnTic2.BackColor = System.Drawing.Color.AliceBlue;
                btnTic3.BackColor = System.Drawing.Color.AliceBlue;



                MessageBox.Show("The winer is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }



            if (btnTic9.Text == "O" && btnTic5.Text == "O" && btnTic1.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.LemonChiffon;
                btnTic5.BackColor = System.Drawing.Color.LemonChiffon;
                btnTic9.BackColor = System.Drawing.Color.LemonChiffon;



                MessageBox.Show("The winer is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }


            if (btnTic7.Text == "O" && btnTic4.Text == "O" && btnTic1.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.BlueViolet;
                btnTic4.BackColor = System.Drawing.Color.BlueViolet;
                btnTic7.BackColor = System.Drawing.Color.BlueViolet;



                MessageBox.Show("The winer is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }


            if (btnTic9.Text == "O" && btnTic6.Text == "O" && btnTic3.Text == "O")
            {
                btnTic3.BackColor = System.Drawing.Color.NavajoWhite;
                btnTic6.BackColor = System.Drawing.Color.NavajoWhite;
                btnTic9.BackColor = System.Drawing.Color.NavajoWhite;



                MessageBox.Show("The winer is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
               plusone = int.Parse(lblPlayerX.Text);
               lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }


            if (btnTic8.Text == "O" && btnTic5.Text == "O" && btnTic2.Text == "O")
            {
                btnTic2.BackColor = System.Drawing.Color.SandyBrown;
                btnTic5.BackColor = System.Drawing.Color.SandyBrown;
                btnTic8.BackColor = System.Drawing.Color.SandyBrown;



                MessageBox.Show("The winer is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
               plusone = int.Parse(lblPlayerX.Text);
               lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }



            if (btnTic6.Text == "O" && btnTic5.Text == "O" && btnTic4.Text == "O")
            {
                btnTic4.BackColor = System.Drawing.Color.Azure;
                btnTic5.BackColor = System.Drawing.Color.Azure;
                btnTic6.BackColor = System.Drawing.Color.Azure;



                MessageBox.Show("The winer is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }


          

            if (btnTic9.Text == "O" && btnTic8.Text == "O" && btnTic7.Text == "O")
            {
                btnTic9.BackColor = System.Drawing.Color.DarkBlue;
                btnTic8.BackColor = System.Drawing.Color.DarkBlue;
                btnTic7.BackColor = System.Drawing.Color.DarkBlue;



                MessageBox.Show("The winer is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }
            if (btnTic7.Text == "O" && btnTic5.Text == "O" && btnTic3.Text == "O")
            {
                btnTic3.BackColor = System.Drawing.Color.DarkBlue;
                btnTic5.BackColor = System.Drawing.Color.DarkBlue;
                btnTic7.BackColor = System.Drawing.Color.DarkBlue;



                MessageBox.Show("The winer is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_false();
            }










        }
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            score();
            btnTic1.Enabled = false;

        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            score();
            btnTic6.Enabled = false;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            score();
            btnTic8.Enabled = false;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            score();
            btnTic9.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {


                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic6.Enabled = true;
                btnTic5.Enabled = true;
                btnTic4.Enabled = true;
                btnTic9.Enabled = true;
                btnTic8.Enabled = true;
                btnTic7.Enabled = true;


                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                lblPlayerX.Text = "O";
                playerO.Text = "O";

                btnTic1.BackColor = Color.Yellow;
                btnTic2.BackColor = Color.Yellow;
                btnTic3.BackColor = Color.Yellow;
                btnTic4.BackColor = Color.Yellow;
                btnTic5.BackColor = Color.Yellow;
                btnTic6.BackColor = Color.Yellow;
                btnTic7.BackColor = Color.Yellow;
                btnTic8.BackColor = Color.Yellow;
                btnTic9.BackColor = Color.Yellow;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("confirm if want to exit", "Tic Tac Toe",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {


                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic6.Enabled = true;
                btnTic5.Enabled = true;
                btnTic4.Enabled = true;
                btnTic9.Enabled = true;
                btnTic8.Enabled = true;
                btnTic7.Enabled = true;


                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnNewGame.Enabled = true;

                btnTic1.BackColor = Color.Yellow;
                btnTic2.BackColor = Color.Yellow;
                btnTic3.BackColor = Color.Yellow;
                btnTic4.BackColor = Color.Yellow;
                btnTic5.BackColor = Color.Yellow;
                btnTic6.BackColor = Color.Yellow;
                btnTic7.BackColor = Color.Yellow;
                btnTic8.BackColor = Color.Yellow;
                btnTic9.BackColor = Color.Yellow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
    }

        private void playerX(object sender, EventArgs e)
        {

        }

        private void payerO_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerX_Click(object sender, EventArgs e)
        {

        }

        private void playerO_Click(object sender, EventArgs e)
        {

        }
    }
}
