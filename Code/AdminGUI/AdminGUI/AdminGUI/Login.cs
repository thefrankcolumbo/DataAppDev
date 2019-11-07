using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI
{
   public partial class Login : Form
   {
      public Login()
      {
         InitializeComponent();
      }

      private void Login_Load(object sender, EventArgs e)
      {
         
      }

      private void Submit_Click(object sender, EventArgs e)
      {
         this.Hide();
         AdminView adminView = new AdminView();
         adminView.Closed += (s, args) => this.Close();
         adminView.Show();
      }
   }
}
