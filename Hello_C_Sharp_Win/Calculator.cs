﻿using System;
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
               HelloLable.Text = "Hello C# _ Made by BBKIM";
          }


          /// <summary>
          /// Result : get sum of two event args
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void getResultButton_Click(object sender, EventArgs e)
          {
               int number1 = 0;
               int number2 = 0;

               //validation check : Null, Whitespace
               if (String.IsNullOrWhiteSpace(Input1.Text))
               {
                    MessageBox.Show("Input Format Error");
                    Input1.Focus();
                    return;
               }

               //validation check : Null, Whitespace
               if (String.IsNullOrWhiteSpace(Input2.Text))
               {
                    MessageBox.Show("Input Format Error");
                    Input2.Focus();
                    return;
               }
               
               //validation check : string(Not Number)
               if (int.TryParse(Input1.Text, out number1) == false)
               {
                    MessageBox.Show("Input Format Error");
                    Input1.SelectAll();
                    Input1.Focus();
                    return;
               }

               //validation check : string(Not Number)
               if(int.TryParse(Input2.Text, out number2) == false)
               {
                    MessageBox.Show("Input Format Error");
                    Input2.SelectAll();
                    Input2.Focus();
                    return;
               }

               Convert.ToInt32(Input1.Text);
               Convert.ToInt32(Input2.Text);

               int sum = Add(number1, number2);

               ResultOutput.Text = sum.ToString();
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
          public float Add2(float number1, float number2)
          {
               float sum = number1 + number2;
               return sum;
          }

          public int Sub(int number1, int number2)
          {
               int sub = number1 - number2;
               return sub;
          }


     }
}
