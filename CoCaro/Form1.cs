using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Name = "" + i + j;
                    button.Size = new Size(20,20);
                    button.Location = new Point(20 + i * 25, 20 + j * 25);
                    button.Click += new EventHandler(Button_Click);
                    this.Controls.Add(button);
                }
            }
        }

        bool laNguoiChoi1 = true;

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (laNguoiChoi1)
                bt.Text = "X";
            else
                bt.Text = "O";
            laNguoiChoi1 = !laNguoiChoi1;
        }

        private bool checkCaroWin()
        {
            
            return false;
        }


        int gameState(char[][] values, int boardSz)
        {


            bool[] colCheckNotRequired = new bool[boardSz];//default is false
            bool diag1CheckNotRequired = false;
            bool diag2CheckNotRequired = false;
            bool allFilled = true;


            int x_count = 0;
            int o_count = 0;
            /* Check rows */
            for (int i = 0; i < boardSz; i++)
            {
                x_count = o_count = 0;
                for (int j = 0; j < boardSz; j++)
                {
                    if (values[i][j] == 'X') x_count++;
                    if (values[i][j] == '0') o_count++;
                    if (values[i][j] == 0)
                    {
                        colCheckNotRequired[j] = true;
                        if (i == j) diag1CheckNotRequired = true;
                        if (i + j == boardSz - 1) diag2CheckNotRequired = true;
                        allFilled = false;
                        //No need check further
                        break;
                    }
                }
                if (x_count == boardSz) return 1;
                if (o_count == boardSz) return 0;
            }


            /* check cols */
            for (int i = 0; i < boardSz; i++)
            {
                x_count = o_count = 0;
                if (colCheckNotRequired[i] == false)
                {
                    for (int j = 0; j < boardSz; j++)
                    {
                        if (values[j][i] == 'X') x_count++;
                        if (values[j][i] == '0') o_count++;
                        //No need check further
                        if (values[i][j] == 0) break;
                    }
                    if (x_count == boardSz) return 1;
                    if (o_count == boardSz) return 0;
                }
            }

            x_count = o_count = 0;
            /* check diagonal 1 */
            if (diag1CheckNotRequired == false)
            {
                for (int i = 0; i < boardSz; i++)
                {
                    if (values[i][i] == 'X') x_count++;
                    if (values[i][i] == '0') o_count++;
                    if (values[i][i] == 0) break;
                }
                if (x_count == boardSz) return 1;
                if (o_count == boardSz) return 0;
            }

            x_count = o_count = 0;
            /* check diagonal 2 */
            if (diag2CheckNotRequired == false)
            {
                for (int i = boardSz - 1, j = 0; i >= 0 && j < boardSz; i--, j++)
                {
                    if (values[j][i] == 'X') x_count++;
                    if (values[j][i] == '0') o_count++;
                    if (values[j][i] == 0) break;
                }
                if (x_count == boardSz) return 1;
                if (o_count == boardSz) return 0;
                x_count = o_count = 0;
            }

            if (allFilled == true)
            {
                for (int i = 0; i < boardSz; i++)
                {
                    for (int j = 0; j < boardSz; j++)
                    {
                        if (values[i][j] == 0)
                        {
                            allFilled = false;
                            break;
                        }
                    }

                    if (allFilled == false)
                    {
                        break;
                    }
                }
            }

            if (allFilled)
                return -1;

            return -2;
        }
    }
}
