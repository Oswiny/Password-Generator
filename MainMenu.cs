using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;


namespace Password_Generator
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {



            InitializeComponent();
        }

        private void MinLen_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePass_Click(object sender, EventArgs e)
        {
            String[] alphabet = new String[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            String[] numArray = new String[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            String[] specChar = new String[] { "!", "#", "$", "=", "?", "*"};
            string password = "";


            Random rnd = new Random();
            try
            {
                if (!OnlyLowerText.Checked && !OnlyUpperText.Checked && !BothText.Checked)
                {
                    throw new Exception("None of the char modifiers was selected!");
                }
                
                int passLen = rnd.Next(Convert.ToInt32(MinLen.Text), Convert.ToInt32(MaxLen.Text) + 1);
                for (int i = 0; i < passLen; i++)
                {

                    int numOrChar = rnd.Next(1, 3);
                    int numOrCharOrSpec = rnd.Next(1, 4);


                    if ((numOrChar == 1 && !IncSpecChar.Checked) || (numOrCharOrSpec == 1 && IncSpecChar.Checked))
                    {
                        int chooseAlph = rnd.Next(0, alphabet.Length);


                        if (OnlyLowerText.Checked)
                        {

                            password += alphabet[chooseAlph].ToLower();
                        }
                        else if (OnlyUpperText.Checked)
                        {
                            password += alphabet[chooseAlph].ToUpper();
                        }
                        else if (BothText.Checked)
                        {
                            int lowerOrUpper = rnd.Next(1, 3);
                            if (lowerOrUpper == 1)
                            {
                                password += alphabet[chooseAlph].ToUpper();
                            }
                            else if (lowerOrUpper == 2)
                            {
                                password += alphabet[chooseAlph].ToLower();
                            }
                        }
                    }
                    else if ((numOrChar == 2 && !IncSpecChar.Checked) || (numOrCharOrSpec == 2 && IncSpecChar.Checked))
                    {
                        int chooseNum = rnd.Next(0, 8);
                        password += numArray[chooseNum];
                    }
                    else if ((numOrChar == 3 && !IncSpecChar.Checked) || (numOrCharOrSpec == 3 && IncSpecChar.Checked))
                    {
                        int chooseSpec = rnd.Next(0, 5);
                        password += specChar[chooseSpec];
                    }
                }
                passShowBox.Text = password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
            }


            
        }

        private void IncSpecChar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OnlyLowerText_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlyLowerText.Checked)
            {
                OnlyUpperText.Checked = false;
                BothText.Checked = false;
            }
        }

        private void OnlyUpperText_CheckedChanged(object sender, EventArgs e)
        {
            if (OnlyUpperText.Checked)
            {
                OnlyLowerText.Checked = false;
                BothText.Checked = false;
            }
        }

        private void BothText_CheckedChanged(object sender, EventArgs e)
        {
            if (BothText.Checked)
            {
                OnlyLowerText.Checked = false;
                OnlyUpperText.Checked = false;
            }
        }

        private void MaxLen_TextChanged(object sender, EventArgs e)
        {
        }

        private void passShowBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveText_Click(object sender, EventArgs e)
        {

            string path = Application.StartupPath + "\\password.txt";
            TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine(PassSaveName.Text + " : " + passShowBox.Text);
            tw.Close();
        }

        private void PassSaveNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassSaveName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinLengthText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
