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
     /// Operation Type
     /// </summary>
     public enum Operators { Add, Sub, Multi, Div };

     /// <summary>
     /// 
     /// </summary>
     public partial class Calculator : Form
     {
          public int Result = 0;
          public bool isNewNum = true;
          public Operators Opt = Operators.Add;

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
               Button numButton = (Button)sender;
               SetNum(numButton.Text);

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




          private void NumOperation_Click(object sender, EventArgs e)
          {
               if (isNewNum == false)
               {
                    //Int.Parse(string) : String => Int
                    int num = int.Parse(NumScreen.Text);
                    if (Opt == Operators.Add)
                         Result += num;
                    else if (Opt == Operators.Sub)
                         Result -= num;

                    //dataType.ToString() : DataType => String
                    NumScreen.Text = Result.ToString();
                    isNewNum = true;
               }
              
               Button optButton = (Button)sender;
               if (optButton.Text == "+")
                    Opt = Operators.Add;
               else if (optButton.Text == "-")
                    Opt = Operators.Sub;
          }
     }
}
