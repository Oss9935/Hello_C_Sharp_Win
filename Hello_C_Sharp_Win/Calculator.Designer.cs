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
               this.HelloLable = new System.Windows.Forms.Label();
               this.Input1 = new System.Windows.Forms.TextBox();
               this.Input2 = new System.Windows.Forms.TextBox();
               this.getResultButton = new System.Windows.Forms.Button();
               this.ResultOutput = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // HelloLable
               // 
               this.HelloLable.AutoSize = true;
               this.HelloLable.Cursor = System.Windows.Forms.Cursors.Hand;
               this.HelloLable.Location = new System.Drawing.Point(25, 31);
               this.HelloLable.Name = "HelloLable";
               this.HelloLable.Size = new System.Drawing.Size(67, 12);
               this.HelloLable.TabIndex = 0;
               this.HelloLable.Text = "Click Here!";
               this.HelloLable.CursorChanged += new System.EventHandler(this.HelloLable_Click);
               this.HelloLable.Click += new System.EventHandler(this.HelloLable_Click);
               // 
               // Input1
               // 
               this.Input1.Location = new System.Drawing.Point(27, 85);
               this.Input1.Name = "Input1";
               this.Input1.Size = new System.Drawing.Size(65, 21);
               this.Input1.TabIndex = 1;
               // 
               // Input2
               // 
               this.Input2.Location = new System.Drawing.Point(98, 85);
               this.Input2.Name = "Input2";
               this.Input2.Size = new System.Drawing.Size(65, 21);
               this.Input2.TabIndex = 2;
               // 
               // getResultButton
               // 
               this.getResultButton.Location = new System.Drawing.Point(169, 83);
               this.getResultButton.Name = "getResultButton";
               this.getResultButton.Size = new System.Drawing.Size(36, 23);
               this.getResultButton.TabIndex = 3;
               this.getResultButton.Text = "=";
               this.getResultButton.UseVisualStyleBackColor = true;
               this.getResultButton.Click += new System.EventHandler(this.getResultButton_Click);
               // 
               // ResultOutput
               // 
               this.ResultOutput.Location = new System.Drawing.Point(211, 85);
               this.ResultOutput.Name = "ResultOutput";
               this.ResultOutput.Size = new System.Drawing.Size(100, 21);
               this.ResultOutput.TabIndex = 4;
               // 
               // Calculator
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(374, 365);
               this.Controls.Add(this.ResultOutput);
               this.Controls.Add(this.getResultButton);
               this.Controls.Add(this.Input2);
               this.Controls.Add(this.Input1);
               this.Controls.Add(this.HelloLable);
               this.Name = "Calculator";
               this.Text = "Calculator";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label HelloLable;
          private System.Windows.Forms.TextBox Input1;
          private System.Windows.Forms.TextBox Input2;
          private System.Windows.Forms.Button getResultButton;
          private System.Windows.Forms.TextBox ResultOutput;
     }
}

