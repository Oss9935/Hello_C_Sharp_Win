using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_C_Sharp_Win
{
     public partial class Calculator : Form
     {
          public Calculator()
          {
               InitializeComponent();
          }

          private void HelloLable_Click(object sender, EventArgs e)
          {
               HelloLable.Text = "Hello C#";

               int number1 = 1;
               int number2 = 2;

               int sum = number1 + number2;

               HelloLable.Text = sum.ToString();


          }
     }
}
