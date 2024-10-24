using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public partial class FrmScreen : Form
    {
        public FrmScreen()
        {
            InitializeComponent();
        }
        private byte GetSelectedRadioButton()
        {
            foreach (Control control in gbSelectRound.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                   
                   return Convert.ToByte(radioButton.Text);
                }
            }
            return 0;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMainGame frmMainGame = new frmMainGame(GetSelectedRadioButton());
            
            frmMainGame.ShowDialog();
            this.Close();   
            
            
        }

        private void lblMassage_Click(object sender, EventArgs e)
        {

        }

        private void gbSelectRound_Enter(object sender, EventArgs e)
        {

        }

        private void FrmScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
