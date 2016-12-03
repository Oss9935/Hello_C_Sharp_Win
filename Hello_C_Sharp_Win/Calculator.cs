using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/// <summary>
/// C# 계산기 프로그램
/// </summary>
namespace Hello_C_Sharp_Win
{

     /// <summary>
     /// 
     /// </summary>
     public partial class Calculator : Form
     {

          /// <summary>
          /// 
          /// </summary>
          public Calculator()
          {
               InitializeComponent();
          }

          /// <summary>
          /// lable1 클릭 시 발생하는 이벤트 핸들러
          /// 
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void HelloLable_Click(object sender, EventArgs e)
          {
               HelloLable.Text = "Hello C#";

               int number1 = 1;
               int number2 = 2;

               int sum = number1 + number2;

               HelloLable.Text = sum.ToString();


          }


          /// <summary>
          /// 
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void Calculator_Load(object sender, EventArgs e)
          {

          }

          /// <summary>
          /// Result : get sum of two event args
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void getResultButton_Click(object sender, EventArgs e)
          {
               int number1 = Convert.ToInt32(Input1.Text);
               int number2 = Convert.ToInt32(Input2.Text);

               int sum = number1 + number2;

               ResultOutput.Text = sum.ToString();
          }
     }
}
