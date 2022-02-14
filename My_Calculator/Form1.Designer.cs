
namespace My_Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberOne = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Div = new System.Windows.Forms.Button();
            this.NumberThree = new System.Windows.Forms.Button();
            this.NumberTwo = new System.Windows.Forms.Button();
            this.NumberSix = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.NumberFive = new System.Windows.Forms.Button();
            this.NumberFour = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.NumberNine = new System.Windows.Forms.Button();
            this.NumberEight = new System.Windows.Forms.Button();
            this.NumberSeven = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.NumberZero = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberOne
            // 
            this.NumberOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberOne.Location = new System.Drawing.Point(12, 188);
            this.NumberOne.Name = "NumberOne";
            this.NumberOne.Size = new System.Drawing.Size(77, 68);
            this.NumberOne.TabIndex = 0;
            this.NumberOne.Text = "1";
            this.NumberOne.UseVisualStyleBackColor = true;
            this.NumberOne.Click += new System.EventHandler(this.NumberOne_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(13, 91);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(408, 39);
            this.Result.TabIndex = 16;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Div.Location = new System.Drawing.Point(262, 262);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(77, 68);
            this.Div.TabIndex = 17;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // NumberThree
            // 
            this.NumberThree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberThree.Location = new System.Drawing.Point(178, 188);
            this.NumberThree.Name = "NumberThree";
            this.NumberThree.Size = new System.Drawing.Size(77, 68);
            this.NumberThree.TabIndex = 18;
            this.NumberThree.Text = "3";
            this.NumberThree.UseVisualStyleBackColor = true;
            this.NumberThree.Click += new System.EventHandler(this.NumberThree_Click);
            // 
            // NumberTwo
            // 
            this.NumberTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberTwo.Location = new System.Drawing.Point(95, 188);
            this.NumberTwo.Name = "NumberTwo";
            this.NumberTwo.Size = new System.Drawing.Size(77, 68);
            this.NumberTwo.TabIndex = 19;
            this.NumberTwo.Text = "2";
            this.NumberTwo.UseVisualStyleBackColor = true;
            this.NumberTwo.Click += new System.EventHandler(this.NumberTwo_Click);
            // 
            // NumberSix
            // 
            this.NumberSix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberSix.Location = new System.Drawing.Point(179, 262);
            this.NumberSix.Name = "NumberSix";
            this.NumberSix.Size = new System.Drawing.Size(77, 68);
            this.NumberSix.TabIndex = 20;
            this.NumberSix.Text = "6";
            this.NumberSix.UseVisualStyleBackColor = true;
            this.NumberSix.Click += new System.EventHandler(this.NumberSix_Click);
            // 
            // Multi
            // 
            this.Multi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Multi.Location = new System.Drawing.Point(344, 262);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(77, 68);
            this.Multi.TabIndex = 21;
            this.Multi.Text = "*";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // NumberFive
            // 
            this.NumberFive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberFive.Location = new System.Drawing.Point(96, 262);
            this.NumberFive.Name = "NumberFive";
            this.NumberFive.Size = new System.Drawing.Size(77, 68);
            this.NumberFive.TabIndex = 22;
            this.NumberFive.Text = "5";
            this.NumberFive.UseVisualStyleBackColor = true;
            this.NumberFive.Click += new System.EventHandler(this.NumberFive_Click);
            // 
            // NumberFour
            // 
            this.NumberFour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberFour.Location = new System.Drawing.Point(13, 262);
            this.NumberFour.Name = "NumberFour";
            this.NumberFour.Size = new System.Drawing.Size(77, 68);
            this.NumberFour.TabIndex = 23;
            this.NumberFour.Text = "4";
            this.NumberFour.UseVisualStyleBackColor = true;
            this.NumberFour.Click += new System.EventHandler(this.NumberFour_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sub.Location = new System.Drawing.Point(261, 336);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(77, 68);
            this.Sub.TabIndex = 24;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // NumberNine
            // 
            this.NumberNine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberNine.Location = new System.Drawing.Point(178, 336);
            this.NumberNine.Name = "NumberNine";
            this.NumberNine.Size = new System.Drawing.Size(77, 68);
            this.NumberNine.TabIndex = 25;
            this.NumberNine.Text = "9";
            this.NumberNine.UseVisualStyleBackColor = true;
            this.NumberNine.Click += new System.EventHandler(this.NumberNine_Click);
            // 
            // NumberEight
            // 
            this.NumberEight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberEight.Location = new System.Drawing.Point(95, 336);
            this.NumberEight.Name = "NumberEight";
            this.NumberEight.Size = new System.Drawing.Size(77, 68);
            this.NumberEight.TabIndex = 26;
            this.NumberEight.Text = "8";
            this.NumberEight.UseVisualStyleBackColor = true;
            this.NumberEight.Click += new System.EventHandler(this.NumberEight_Click);
            // 
            // NumberSeven
            // 
            this.NumberSeven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberSeven.Location = new System.Drawing.Point(12, 336);
            this.NumberSeven.Name = "NumberSeven";
            this.NumberSeven.Size = new System.Drawing.Size(77, 68);
            this.NumberSeven.TabIndex = 27;
            this.NumberSeven.Text = "7";
            this.NumberSeven.UseVisualStyleBackColor = true;
            this.NumberSeven.Click += new System.EventHandler(this.NumberSeven_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Equal.Location = new System.Drawing.Point(262, 410);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(159, 68);
            this.Equal.TabIndex = 28;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sum.Location = new System.Drawing.Point(344, 336);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(77, 68);
            this.Sum.TabIndex = 29;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Point.Location = new System.Drawing.Point(179, 410);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(77, 68);
            this.Point.TabIndex = 30;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // NumberZero
            // 
            this.NumberZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberZero.Location = new System.Drawing.Point(13, 410);
            this.NumberZero.Name = "NumberZero";
            this.NumberZero.Size = new System.Drawing.Size(160, 68);
            this.NumberZero.TabIndex = 31;
            this.NumberZero.Text = "0";
            this.NumberZero.UseVisualStyleBackColor = true;
            this.NumberZero.Click += new System.EventHandler(this.NumberZero_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(262, 188);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(159, 68);
            this.Delete.TabIndex = 32;
            this.Delete.Text = "C";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 493);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.NumberZero);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.NumberSeven);
            this.Controls.Add(this.NumberEight);
            this.Controls.Add(this.NumberNine);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.NumberFour);
            this.Controls.Add(this.NumberFive);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.NumberSix);
            this.Controls.Add(this.NumberTwo);
            this.Controls.Add(this.NumberThree);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.NumberOne);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculator";
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NumberOne;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button NumberThree;
        private System.Windows.Forms.Button NumberTwo;
        private System.Windows.Forms.Button NumberSix;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button NumberFive;
        private System.Windows.Forms.Button NumberFour;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button NumberNine;
        private System.Windows.Forms.Button NumberEight;
        private System.Windows.Forms.Button NumberSeven;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button NumberZero;
        private System.Windows.Forms.Button Delete;
    }
}

