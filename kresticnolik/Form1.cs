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
            combo.Remove(btn);
            
          
            
            
           
            
        }

        public void AIMove()
        {
          

                int index = random.Next(combo.Count);
                combo[index].Enabled = false;
                combo[index].Text = "O";
                combo[index].BackColor = Color.Red;
                combo.RemoveAt(index);
                
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
