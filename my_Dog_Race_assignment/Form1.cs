using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_Dog_Race_assignment
{
    public partial class Form1 : Form
    {
        private int parvesh = 100, greak = 100, kuldeep = 100;
        public RunnerDog runner = new RunnerDog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_race_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dog1_pic_box.Left += runner.move_Dog();
            dog2_pic_box.Left += runner.move_Dog();
            dog3_pic_box.Left += runner.move_Dog();
            dog4_pic_box.Left += runner.move_Dog();

            if (dog1_pic_box.Left>800) {
                timer1.Stop();
                MessageBox.Show("first Dog won the race ");
                if (parvesh_balance.Text.Contains("amount")) {
                    parvesh = runner.resultSetup(parvesh_balance.Text, 1, parvesh);
                }
                if (Greak_balance.Text.Contains("amount"))
                {
                    greak = runner.resultSetup(Greak_balance.Text, 1, greak);
                }
                if (kuldeep_has.Text.Contains("amount"))
                {
                    kuldeep = runner.resultSetup(kuldeep_has.Text, 1, greak);
                }
                reset();

            }
            if (dog2_pic_box.Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("Second Dog won the race ");
                if (parvesh_balance.Text.Contains("amount"))
                {
                    parvesh = runner.resultSetup(parvesh_balance.Text, 2, parvesh);
                }
                if (Greak_balance.Text.Contains("amount"))
                {
                    greak = runner.resultSetup(Greak_balance.Text, 2, greak);
                }
                if (kuldeep_has.Text.Contains("amount"))
                {
                    kuldeep = runner.resultSetup(kuldeep_has.Text, 2, greak);
                }
                reset();
            }
            if (dog3_pic_box.Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("Third DOg won the race ");

                if (parvesh_balance.Text.Contains("amount"))
                {
                    parvesh = runner.resultSetup(parvesh_balance.Text, 3, parvesh);
                }
                if (Greak_balance.Text.Contains("amount"))
                {
                    greak = runner.resultSetup(Greak_balance.Text, 3, greak);
                }
                if (kuldeep_has.Text.Contains("amount"))
                {
                    kuldeep = runner.resultSetup(kuldeep_has.Text, 3, greak);
                }
                reset();
            }
            if (dog4_pic_box.Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("Forth Dog won the race ");

                if (parvesh_balance.Text.Contains("amount"))
                {
                    parvesh = runner.resultSetup(parvesh_balance.Text, 4, parvesh);
                }
                if (Greak_balance.Text.Contains("amount"))
                {
                    greak = runner.resultSetup(Greak_balance.Text, 4, greak);
                }
                if (kuldeep_has.Text.Contains("amount"))
                {
                    kuldeep = runner.resultSetup(kuldeep_has.Text, 4, greak);
                }
                reset();
            }

        }

        public void reset() {
            parvesh_balance.Text = "Parvesh has " + parvesh;
            Greak_balance.Text = "Greak has " + greak;
            kuldeep_has.Text = "Kuldeep has " + kuldeep;
            dog1_pic_box.Left = 0; dog2_pic_box.Left = 0; dog3_pic_box.Left = 0; dog4_pic_box.Left = 0;
            Run_race_button.Enabled = false;
            Players.Text = "";
            bet_comboBox.Text = "";
            Dog_select_combo.Text = "";


        }
        private void Form1_Load(object sender, EventArgs e)
        {
           ///here  this code is used to generate the amount for the bet 
            int y = 5;
            while (y<=50) {
                bet_comboBox.Items.Add(y.ToString());
                y += 5;
            }
        }

        // check will check all conditions 

        private void check_bet_button_Click(object sender, EventArgs e)
        {
            if (!Players.Text.ToString().Equals(""))
            {
                //Here we are going to check the details of the betting 
                for (int y = 0; y < 3; y++)
                {
                    if (Players.SelectedIndex == y)
                    {
                        // here now need to check the wokring of the further option 
                        // now need to check the dog value and bet amount 
                        if (!Dog_select_combo.SelectedItem.ToString().Equals(""))
                        {
                            if (!bet_comboBox.SelectedItem.ToString().Equals(""))
                            {
                                if (y == 0 && Convert.ToInt32(bet_comboBox.SelectedItem.ToString()) < parvesh)
                                {
                                    parvesh_balance.Text = "Parvesh selected " + Dog_select_combo.Text + " with the amount " + bet_comboBox.Text;
                                    Run_race_button.Enabled = true;
                                    break;
                                }
                              else  if (y == 1 && Convert.ToInt32(bet_comboBox.SelectedItem.ToString()) < greak)
                                {
                                    Greak_balance.Text = "Greak selected " + Dog_select_combo.Text + " with the amount " + bet_comboBox.Text;
                                    Run_race_button.Enabled = true;
                                    break;
                                }
                               
                               else  if (y == 2 && Convert.ToInt32(bet_comboBox.SelectedItem.ToString()) < kuldeep)
                                {
                                    kuldeep_has.Text = "Kuldeep selected " + Dog_select_combo.Text + " with the amount " + bet_comboBox.Text;
                                    Run_race_button.Enabled = true;
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("You need to check your balance ");
                                }
                            }
                        }
                        
                    }
                }
            }
            else {
                MessageBox.Show("You need to select the details ");
            }
        }
    }
}
