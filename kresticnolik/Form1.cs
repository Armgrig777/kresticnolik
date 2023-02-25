using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kresticnolik
{
    public partial class Form1 : Form
    {
        List<Button> combo;
        Random random = new Random();
        int playerscore = 0;
        int compscore = 0;
        public Form1()
        {
            InitializeComponent();
         LoadButtons(); 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadButtons()
        {
            combo = new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Control button in this.Panelbox.Controls)
            {
                Button btn = (Button)button;
                if (btn == null)
                    continue;

                btn.Click += btnNum_Click;
                
                
            }
            Score();
           
           

        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled=false;
            btn.Text = "X";
            btn.BackColor = Color.Aqua;
            AIMove();
            
            
          
            
            
           
            
        }

        public void AIMove()
        {
         Button btn = new Button();
            int index;

            if (btn1.Text == "X" && btn3.Text == "X" && btn2.Text == "")
                btn2.BackColor = Color.MediumVioletRed;
                btn2.Text = "O";
            if (btn4.Text == "X" && btn6.Text == "X" && btn5.Text == "")
                btn5.BackColor = Color.MediumVioletRed;
            btn5.Text = "O";
            if (btn7.Text == "X" && btn9.Text == "X" && btn8.Text == "")
                btn8.BackColor = Color.MediumVioletRed;
            btn8.Text = "O";
            if (btn1.Text == "X" && btn7.Text == "X" && btn4.Text == "")
                btn4.BackColor = Color.MediumVioletRed;
            btn4.Text = "O";
            if (btn2.Text == "X" && btn8.Text == "X" && btn5.Text == "")
                btn5.BackColor = Color.MediumVioletRed;
            btn5.Text = "O";
            if (btn3.Text == "X" && btn9.Text == "X" && btn6.Text == "")
                btn6.BackColor = Color.MediumVioletRed;
            btn6.Text = "O";
            if (btn1.Text == "X" && btn9.Text == "X" && btn5.Text == "")
                btn5.BackColor = Color.MediumVioletRed;
            btn5.Text = "O";
            if (btn3.Text == "X" && btn7.Text == "X" && btn5.Text == "")
                btn5.BackColor = Color.MediumVioletRed;
            btn5.Text = "O";
            if (btn4.Text == "X" && btn7.Text == "X" && btn1.Text == "")
                btn1.BackColor = Color.MediumVioletRed;
            btn1.Text = "O";
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "")
                btn7.BackColor = Color.MediumVioletRed;
            btn7.Text = "O";
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "")
                btn8.BackColor = Color.MediumVioletRed;
            btn8.Text = "O";
            if (btn8.Text == "X" && btn5.Text == "X" && btn2.Text == "")
                btn2.BackColor = Color.MediumVioletRed;
            btn2.Text = "O";
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "")
                btn9.BackColor = Color.MediumVioletRed;
            btn9.Text = "O";
            if (btn6.Text == "X" && btn9.Text == "X" && btn3.Text == "")
                btn3.BackColor = Color.MediumVioletRed;
            btn3.Text = "O";
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "")
                btn9.BackColor = Color.MediumVioletRed;
            btn9.Text = "O";
            if (btn9.Text == "X" && btn5.Text == "X" && btn1.Text == "")
                btn1.BackColor = Color.MediumVioletRed;
            btn1.Text = "O";
            if (btn5.Text == "X" && btn3.Text == "X" && btn7.Text == "")
                btn7.BackColor = Color.MediumVioletRed;
            btn7.Text = "O";
            if (btn7.Text == "X" && btn5.Text == "X" && btn3.Text == "")
                btn3.BackColor = Color.MediumVioletRed;
            btn3.Text = "O";
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "")
                btn9.BackColor = Color.MediumVioletRed;
            btn9.Text = "O";
            if (btn8.Text == "X" && btn9.Text == "X" && btn7.Text == "")
                btn7.BackColor = Color.MediumVioletRed;
            btn7.Text = "O";
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "")
                btn6.BackColor = Color.MediumVioletRed;
            btn6.Text = "O";
            if (btn5.Text == "X" && btn6.Text == "X" && btn4.Text == "")
                btn4.BackColor = Color.MediumVioletRed;
            btn4.Text = "O";
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "")
                btn3.BackColor = Color.MediumVioletRed;
            btn3.Text = "O";
            if (btn2.Text == "X" && btn3.Text == "X" && btn1.Text == "")
                btn1.BackColor = Color.MediumVioletRed;
            btn1.Text = "O";
            if (default)
            {
                index = random.Next(combo.Count);
                btn = (Button)combo[index];
                btn.Text = "O";
                btn.BackColor = Color.MediumVioletRed;

            }
            Score();
                
            

        }
        public void Score()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X"
              || btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X"
              || btn7.Text == "X" && btn9.Text == "X" && btn8.Text == "X"
              || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X"
              || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X"
              || btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X"
              || btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X"
              || btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                
                MessageBox.Show("Player Wins");
                playerscore++;

                label4.Text = playerscore.ToString();
                restart();

            }
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O"
             || btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O"
             || btn7.Text == "O" && btn9.Text == "O" && btn8.Text == "O"
             || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O"
             || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O"
             || btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O"
             || btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O"
             || btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Computer Wins");
                compscore++;
                label5.Text =  compscore.ToString();
                restart();

            }


        }

       

        private void btnrestart_Click(object sender, EventArgs e)
        {
            restart();
            playerscore = 0;
            compscore = 0;
        }
        public void restart()
        {
            foreach (Control item in this.Panelbox.Controls)
            {
                Button btn = item as Button;
                btn.Text = "";
                btn.Enabled = true;
                btn.BackColor = default(Color);
               

            }
            LoadButtons();
          
            
        }
    }
}
