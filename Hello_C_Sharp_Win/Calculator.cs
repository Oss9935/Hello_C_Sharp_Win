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
          public int Result = 0;
          public bool isNewNum = true;


          /// <summary>
          /// 생성자.
          /// </summary>
          public Calculator()
          {
               InitializeComponent();
          }
          

          /// <summary>
          /// return sum of two int parm
          /// </summary>
          /// <param name="number1"></param>
          /// <param name="number2"></param>
          /// <returns></returns>
          public int Add(int number1, int number2)
          {
               int sum = number1 + number2;
               return sum;
          }


          /// <summary>
          /// return sum of two float parm
          /// </summary>
          /// <param name="number1"></param>
          /// <param name="number2"></param>
          /// <returns></returns>
          public float Add(float number1, float number2)
          {
               float sum = number1 + number2;
               return sum;
          }

          public int Sub(int number1, int number2)
          {
               int sub = number1 - number2;
               return sub;
          }



          /// <summary>
          /// number button 0~9
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void Number1_Click(object sender, EventArgs e)
          {
               SetNum("1");

          }

          private void Number2_Click(object sender, EventArgs e)
          {
               SetNum("2");
          }


          private void Number3_Click(object sender, EventArgs e)
          {
               SetNum("3");
          }

          private void Number4_Click(object sender, EventArgs e)
          {
               SetNum("4");
          }

          private void Number5_Click(object sender, EventArgs e)
          {
               SetNum("5");
          }

          private void Number6_Click(object sender, EventArgs e)
          {
               SetNum("6");
          }

          private void Number7_Click(object sender, EventArgs e)
          {
               SetNum("7");
          }

          private void Number8_Click(object sender, EventArgs e)
          {
               SetNum("8");
          }

          private void Number9_Click(object sender, EventArgs e)
          {
               SetNum("9");
          }

          private void Number0_Click(object sender, EventArgs e)
          {
               SetNum("0");
          }



          /// <summary>
          /// single input number to display 
          /// </summary>
          /// <param name="num"></param>
          public void SetNum(string num)
          {
               if (isNewNum)
               {
                    NumScreen.Text = num;
                    isNewNum = false;
               }
               else if (NumScreen.Text == "0")
               {
                    NumScreen.Text = num;
               }
               else
               {
                    NumScreen.Text = NumScreen.Text + num;
               }     
               
          }




          private void NumPlus_Click(object sender, EventArgs e)
          {
               //Int.Parse(string) : String => Int
               int num = int.Parse(NumScreen.Text);
               Result += num;

               //dataType.ToString() : DataType => String
               NumScreen.Text = Result.ToString();
               isNewNum = true;
          }

     }
}
