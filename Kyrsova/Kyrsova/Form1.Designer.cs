namespace Kyrsova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_sum = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearA = new System.Windows.Forms.Button();
            this.randomA = new System.Windows.Forms.Button();
            this.randomB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.multiply_numberA = new System.Windows.Forms.Button();
            this.box_for_multiplyA = new System.Windows.Forms.TextBox();
            this.box_for_multiplyB = new System.Windows.Forms.TextBox();
            this.multiply_numberB = new System.Windows.Forms.Button();
            this.box_for_powA = new System.Windows.Forms.TextBox();
            this.powA = new System.Windows.Forms.Button();
            this.box_for_powB = new System.Windows.Forms.TextBox();
            this.powB = new System.Windows.Forms.Button();
            this.TransposeA = new System.Windows.Forms.Button();
            this.TransposeB = new System.Windows.Forms.Button();
            this.determinantB = new System.Windows.Forms.Button();
            this.determinantA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sum
            // 
            this.button_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sum.Location = new System.Drawing.Point(341, 152);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(188, 32);
            this.button_sum.TabIndex = 2;
            this.button_sum.Text = "A + B";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button_sum_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(341, 114);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(188, 32);
            this.sum.TabIndex = 3;
            this.sum.Text = "A - B";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.substraction_Click);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product.Location = new System.Drawing.Point(341, 76);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(188, 32);
            this.product.TabIndex = 4;
            this.product.Text = "A * B";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Matrix Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Matrix A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(145, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(670, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(550, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Matrix B:";
            // 
            // ClearA
            // 
            this.ClearA.Location = new System.Drawing.Point(36, 295);
            this.ClearA.Name = "ClearA";
            this.ClearA.Size = new System.Drawing.Size(88, 35);
            this.ClearA.TabIndex = 142;
            this.ClearA.Text = "Clear";
            this.ClearA.UseVisualStyleBackColor = true;
            this.ClearA.Click += new System.EventHandler(this.ClearA_Click);
            // 
            // randomA
            // 
            this.randomA.Location = new System.Drawing.Point(182, 295);
            this.randomA.Name = "randomA";
            this.randomA.Size = new System.Drawing.Size(88, 35);
            this.randomA.TabIndex = 143;
            this.randomA.Text = "Random numbers";
            this.randomA.UseVisualStyleBackColor = true;
            this.randomA.Click += new System.EventHandler(this.randomA_Click);
            // 
            // randomB
            // 
            this.randomB.Location = new System.Drawing.Point(731, 295);
            this.randomB.Name = "randomB";
            this.randomB.Size = new System.Drawing.Size(88, 35);
            this.randomB.TabIndex = 145;
            this.randomB.Text = "Random numbers";
            this.randomB.UseVisualStyleBackColor = true;
            this.randomB.Click += new System.EventHandler(this.randomB_Click);
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(585, 295);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(88, 35);
            this.ClearB.TabIndex = 144;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // multiply_numberA
            // 
            this.multiply_numberA.Location = new System.Drawing.Point(36, 336);
            this.multiply_numberA.Name = "multiply_numberA";
            this.multiply_numberA.Size = new System.Drawing.Size(174, 30);
            this.multiply_numberA.TabIndex = 147;
            this.multiply_numberA.Text = "Multiply Matrix A by number: ";
            this.multiply_numberA.UseVisualStyleBackColor = true;
            this.multiply_numberA.Click += new System.EventHandler(this.multiply_numberA_Click);
            // 
            // box_for_multiplyA
            // 
            this.box_for_multiplyA.Location = new System.Drawing.Point(216, 342);
            this.box_for_multiplyA.Name = "box_for_multiplyA";
            this.box_for_multiplyA.Size = new System.Drawing.Size(24, 20);
            this.box_for_multiplyA.TabIndex = 148;
            // 
            // box_for_multiplyB
            // 
            this.box_for_multiplyB.Location = new System.Drawing.Point(765, 342);
            this.box_for_multiplyB.Name = "box_for_multiplyB";
            this.box_for_multiplyB.Size = new System.Drawing.Size(24, 20);
            this.box_for_multiplyB.TabIndex = 150;
            // 
            // multiply_numberB
            // 
            this.multiply_numberB.Location = new System.Drawing.Point(585, 336);
            this.multiply_numberB.Name = "multiply_numberB";
            this.multiply_numberB.Size = new System.Drawing.Size(174, 30);
            this.multiply_numberB.TabIndex = 149;
            this.multiply_numberB.Text = "Multiply Matrix B by number: ";
            this.multiply_numberB.UseVisualStyleBackColor = true;
            this.multiply_numberB.Click += new System.EventHandler(this.multiply_numberB_Click);
            // 
            // box_for_powA
            // 
            this.box_for_powA.Location = new System.Drawing.Point(216, 378);
            this.box_for_powA.Name = "box_for_powA";
            this.box_for_powA.Size = new System.Drawing.Size(24, 20);
            this.box_for_powA.TabIndex = 156;
            // 
            // powA
            // 
            this.powA.Location = new System.Drawing.Point(36, 372);
            this.powA.Name = "powA";
            this.powA.Size = new System.Drawing.Size(174, 30);
            this.powA.TabIndex = 155;
            this.powA.Text = "Raise MatrixA by the pow:";
            this.powA.UseVisualStyleBackColor = true;
            this.powA.Click += new System.EventHandler(this.powA_Click);
            // 
            // box_for_powB
            // 
            this.box_for_powB.Location = new System.Drawing.Point(765, 378);
            this.box_for_powB.Name = "box_for_powB";
            this.box_for_powB.Size = new System.Drawing.Size(24, 20);
            this.box_for_powB.TabIndex = 158;
            // 
            // powB
            // 
            this.powB.Location = new System.Drawing.Point(585, 372);
            this.powB.Name = "powB";
            this.powB.Size = new System.Drawing.Size(174, 30);
            this.powB.TabIndex = 157;
            this.powB.Text = "Raise MatrixB by the pow:";
            this.powB.UseVisualStyleBackColor = true;
            this.powB.Click += new System.EventHandler(this.powB_Click);
            // 
            // TransposeA
            // 
            this.TransposeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransposeA.Location = new System.Drawing.Point(341, 208);
            this.TransposeA.Name = "TransposeA";
            this.TransposeA.Size = new System.Drawing.Size(188, 32);
            this.TransposeA.TabIndex = 159;
            this.TransposeA.Text = "Transpose Matrix A!";
            this.TransposeA.UseVisualStyleBackColor = true;
            this.TransposeA.Click += new System.EventHandler(this.TransposeA_Click);
            // 
            // TransposeB
            // 
            this.TransposeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransposeB.Location = new System.Drawing.Point(341, 307);
            this.TransposeB.Name = "TransposeB";
            this.TransposeB.Size = new System.Drawing.Size(188, 32);
            this.TransposeB.TabIndex = 160;
            this.TransposeB.Text = "Transpose Matrix B!";
            this.TransposeB.UseVisualStyleBackColor = true;
            this.TransposeB.Click += new System.EventHandler(this.TransposeB_Click);
            // 
            // determinantB
            // 
            this.determinantB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.determinantB.Location = new System.Drawing.Point(341, 345);
            this.determinantB.Name = "determinantB";
            this.determinantB.Size = new System.Drawing.Size(188, 32);
            this.determinantB.TabIndex = 162;
            this.determinantB.Text = "Determinant MatrixB!";
            this.determinantB.UseVisualStyleBackColor = true;
            this.determinantB.Click += new System.EventHandler(this.determinantB_Click);
            // 
            // determinantA
            // 
            this.determinantA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.determinantA.Location = new System.Drawing.Point(341, 246);
            this.determinantA.Name = "determinantA";
            this.determinantA.Size = new System.Drawing.Size(188, 32);
            this.determinantA.TabIndex = 161;
            this.determinantA.Text = "Determinant MatrixA!";
            this.determinantA.UseVisualStyleBackColor = true;
            this.determinantA.Click += new System.EventHandler(this.determinantA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 419);
            this.Controls.Add(this.determinantB);
            this.Controls.Add(this.determinantA);
            this.Controls.Add(this.TransposeB);
            this.Controls.Add(this.TransposeA);
            this.Controls.Add(this.box_for_powB);
            this.Controls.Add(this.powB);
            this.Controls.Add(this.box_for_powA);
            this.Controls.Add(this.powA);
            this.Controls.Add(this.box_for_multiplyB);
            this.Controls.Add(this.multiply_numberB);
            this.Controls.Add(this.box_for_multiplyA);
            this.Controls.Add(this.multiply_numberA);
            this.Controls.Add(this.randomB);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.randomA);
            this.Controls.Add(this.ClearA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.product);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.button_sum);
            this.Name = "Form1";
            this.Text = "Matrix Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearA;
        private System.Windows.Forms.Button randomA;
        private System.Windows.Forms.Button randomB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.Button multiply_numberA;
        private System.Windows.Forms.TextBox box_for_multiplyA;
        private System.Windows.Forms.TextBox box_for_multiplyB;
        private System.Windows.Forms.Button multiply_numberB;
        private System.Windows.Forms.TextBox box_for_powA;
        private System.Windows.Forms.Button powA;
        private System.Windows.Forms.TextBox box_for_powB;
        private System.Windows.Forms.Button powB;
        private System.Windows.Forms.Button TransposeA;
        private System.Windows.Forms.Button TransposeB;
        private System.Windows.Forms.Button determinantB;
        private System.Windows.Forms.Button determinantA;
    }
}

