namespace Hello_C_Sharp_Win
{
     partial class Calculator
     {
          /// <summary>
          /// 필수 디자이너 변수입니다.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// 사용 중인 모든 리소스를 정리합니다.
          /// </summary>
          /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form 디자이너에서 생성한 코드

          /// <summary>
          /// 디자이너 지원에 필요한 메서드입니다. 
          /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
          /// </summary>
          private void InitializeComponent()
          {
               this.Number1 = new System.Windows.Forms.Button();
               this.Number2 = new System.Windows.Forms.Button();
               this.NumScreen = new System.Windows.Forms.Label();
               this.NumPlus = new System.Windows.Forms.Button();
               this.Number3 = new System.Windows.Forms.Button();
               this.Number4 = new System.Windows.Forms.Button();
               this.Number5 = new System.Windows.Forms.Button();
               this.Number6 = new System.Windows.Forms.Button();
               this.Number7 = new System.Windows.Forms.Button();
               this.Number8 = new System.Windows.Forms.Button();
               this.Number9 = new System.Windows.Forms.Button();
               this.Number0 = new System.Windows.Forms.Button();
               this.NumMinus = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // Number1
               // 
               this.Number1.Location = new System.Drawing.Point(12, 164);
               this.Number1.Name = "Number1";
               this.Number1.Size = new System.Drawing.Size(41, 41);
               this.Number1.TabIndex = 0;
               this.Number1.Text = "1";
               this.Number1.UseVisualStyleBackColor = true;
               this.Number1.Click += new System.EventHandler(this.Number1_Click);
               // 
               // Number2
               // 
               this.Number2.Location = new System.Drawing.Point(57, 164);
               this.Number2.Name = "Number2";
               this.Number2.Size = new System.Drawing.Size(41, 41);
               this.Number2.TabIndex = 1;
               this.Number2.Text = "2";
               this.Number2.UseVisualStyleBackColor = true;
               this.Number2.Click += new System.EventHandler(this.Number1_Click);
               // 
               // NumScreen
               // 
               this.NumScreen.BackColor = System.Drawing.Color.White;
               this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.NumScreen.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
               this.NumScreen.Location = new System.Drawing.Point(12, 23);
               this.NumScreen.Name = "NumScreen";
               this.NumScreen.Size = new System.Drawing.Size(180, 47);
               this.NumScreen.TabIndex = 2;
               this.NumScreen.Text = "0";
               this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
               // 
               // NumPlus
               // 
               this.NumPlus.Location = new System.Drawing.Point(12, 114);
               this.NumPlus.Name = "NumPlus";
               this.NumPlus.Size = new System.Drawing.Size(41, 41);
               this.NumPlus.TabIndex = 3;
               this.NumPlus.Text = "+";
               this.NumPlus.UseVisualStyleBackColor = true;
               this.NumPlus.Click += new System.EventHandler(this.NumOperation_Click);
               // 
               // Number3
               // 
               this.Number3.Location = new System.Drawing.Point(103, 164);
               this.Number3.Name = "Number3";
               this.Number3.Size = new System.Drawing.Size(41, 41);
               this.Number3.TabIndex = 4;
               this.Number3.Text = "3";
               this.Number3.UseVisualStyleBackColor = true;
               this.Number3.Click += new System.EventHandler(this.Number1_Click);
               // 
               // Number4
               // 
               this.Number4.Location = new System.Drawing.Point(12, 214);
               this.Number4.Name = "Number4";
               this.Number4.Size = new System.Drawing.Size(41, 41);
               this.Number4.TabIndex = 5;
               this.Number4.Text = "4";
               this.Number4.UseVisualStyleBackColor = true;
               this.Number4.Click += new System.EventHandler(this.Number1_Click);
               // 
               // Number5
               // 
               this.Number5.Location = new System.Drawing.Point(57, 214);
               this.Number5.Name = "Number5";
               this.Number5.Size = new System.Drawing.Size(41, 41);
               this.Number5.TabIndex = 6;
               this.Number5.Text = "5";
               this.Number5.UseVisualStyleBackColor = true;
               this.Number5.Click += new System.EventHandler(this.Number1_Click);
               // 
               // Number6
               // 
               this.Number6.Location = new System.Drawing.Point(103, 214);
               this.Number6.Name = "Number6";
               this.Number6.Size = new System.Drawing.Size(41, 41);
               this.Number6.TabIndex = 7;
               this.Number6.Text = "6";
               this.Number6.UseVisualStyleBackColor = true;
               this.Number6.Click += new System.EventHandler(this.Number1_Click);
               // 
               // Number7
               // 
               this.Number7.Location = new System.Drawing.Point(12, 264);
               this.Number7.Name = "Number7";
               this.Number7.Size = new System.Drawing.Size(41, 41);
               this.Number7.TabIndex = 8;
               this.Number7.Text = "7";
               this.Number7.UseVisualStyleBackColor = true;
               this.Number7.Click += new System.EventHandler(this.Number1_Click);
               // 
               // Number8
               // 
               this.Number8.Location = new System.Drawing.Point(57, 264);
               this.Number8.Name = "Number8";
               this.Number8.Size = new System.Drawing.Size(41, 41);
               this.Number8.TabIndex = 9;
               this.Number8.Text = "8";
               this.Number8.UseVisualStyleBackColor = true;
               this.Number8.Click += new System.EventHandler(this.Number1_Click);
               // 
               // Number9
               // 
               this.Number9.Location = new System.Drawing.Point(103, 264);
               this.Number9.Name = "Number9";
               this.Number9.Size = new System.Drawing.Size(41, 41);
               this.Number9.TabIndex = 10;
               this.Number9.Text = "9";
               this.Number9.UseVisualStyleBackColor = true;
               this.Number9.Click += new System.EventHandler(this.Number1_Click);
               // 
               // Number0
               // 
               this.Number0.Location = new System.Drawing.Point(57, 311);
               this.Number0.Name = "Number0";
               this.Number0.Size = new System.Drawing.Size(41, 41);
               this.Number0.TabIndex = 11;
               this.Number0.Text = "0";
               this.Number0.UseVisualStyleBackColor = true;
               this.Number0.Click += new System.EventHandler(this.Number1_Click);
               // 
               // NumMinus
               // 
               this.NumMinus.Location = new System.Drawing.Point(57, 114);
               this.NumMinus.Name = "NumMinus";
               this.NumMinus.Size = new System.Drawing.Size(41, 41);
               this.NumMinus.TabIndex = 12;
               this.NumMinus.Text = "-";
               this.NumMinus.UseVisualStyleBackColor = true;
               this.NumMinus.Click += new System.EventHandler(this.NumOperation_Click);
               // 
               // Calculator
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(204, 378);
               this.Controls.Add(this.NumMinus);
               this.Controls.Add(this.Number0);
               this.Controls.Add(this.Number9);
               this.Controls.Add(this.Number8);
               this.Controls.Add(this.Number7);
               this.Controls.Add(this.Number6);
               this.Controls.Add(this.Number5);
               this.Controls.Add(this.Number4);
               this.Controls.Add(this.Number3);
               this.Controls.Add(this.NumPlus);
               this.Controls.Add(this.NumScreen);
               this.Controls.Add(this.Number2);
               this.Controls.Add(this.Number1);
               this.Name = "Calculator";
               this.Text = "Calculator";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button Number1;
          private System.Windows.Forms.Button Number2;
          private System.Windows.Forms.Label NumScreen;
          private System.Windows.Forms.Button NumPlus;
          private System.Windows.Forms.Button Number3;
          private System.Windows.Forms.Button Number4;
          private System.Windows.Forms.Button Number5;
          private System.Windows.Forms.Button Number6;
          private System.Windows.Forms.Button Number7;
          private System.Windows.Forms.Button Number8;
          private System.Windows.Forms.Button Number9;
          private System.Windows.Forms.Button Number0;
          private System.Windows.Forms.Button NumMinus;
     }
}

