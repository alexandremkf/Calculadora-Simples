namespace calculadora_simples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonLess = new System.Windows.Forms.Button();
            this.buttonMultiple = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonCopy_click = new System.Windows.Forms.Button();
            this.buttonParenteses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.ReadOnly = true;
            this.textBoxDisplay.Size = new System.Drawing.Size(305, 91);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(245, 359);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(75, 120);
            this.buttonEqual.TabIndex = 1;
            this.buttonEqual.Tag = "";
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(245, 307);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 46);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonLess
            // 
            this.buttonLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLess.Location = new System.Drawing.Point(245, 255);
            this.buttonLess.Name = "buttonLess";
            this.buttonLess.Size = new System.Drawing.Size(75, 46);
            this.buttonLess.TabIndex = 3;
            this.buttonLess.Text = "-";
            this.buttonLess.UseVisualStyleBackColor = true;
            this.buttonLess.Click += new System.EventHandler(this.buttonLess_Click);
            // 
            // buttonMultiple
            // 
            this.buttonMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiple.Location = new System.Drawing.Point(245, 203);
            this.buttonMultiple.Name = "buttonMultiple";
            this.buttonMultiple.Size = new System.Drawing.Size(75, 46);
            this.buttonMultiple.TabIndex = 4;
            this.buttonMultiple.Text = "x";
            this.buttonMultiple.UseVisualStyleBackColor = true;
            this.buttonMultiple.Click += new System.EventHandler(this.buttonMultiple_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(245, 151);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 46);
            this.buttonDivision.TabIndex = 5;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonDelete.Location = new System.Drawing.Point(12, 109);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(72, 36);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "C";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErase.ForeColor = System.Drawing.Color.Black;
            this.buttonErase.Location = new System.Drawing.Point(245, 109);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(72, 36);
            this.buttonErase.TabIndex = 7;
            this.buttonErase.Text = "⌫";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber7.Location = new System.Drawing.Point(12, 201);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Size = new System.Drawing.Size(72, 64);
            this.buttonNumber7.TabIndex = 8;
            this.buttonNumber7.Tag = "";
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = true;
            this.buttonNumber7.Click += new System.EventHandler(this.buttonNumber7_Click);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber8.Location = new System.Drawing.Point(90, 201);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Size = new System.Drawing.Size(68, 64);
            this.buttonNumber8.TabIndex = 9;
            this.buttonNumber8.Tag = "";
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = true;
            this.buttonNumber8.Click += new System.EventHandler(this.buttonNumber8_Click);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber9.Location = new System.Drawing.Point(164, 201);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Size = new System.Drawing.Size(72, 64);
            this.buttonNumber9.TabIndex = 10;
            this.buttonNumber9.Tag = "";
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = true;
            this.buttonNumber9.Click += new System.EventHandler(this.buttonNumber9_Click);
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber6.Location = new System.Drawing.Point(164, 271);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Size = new System.Drawing.Size(72, 64);
            this.buttonNumber6.TabIndex = 13;
            this.buttonNumber6.Tag = "";
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = true;
            this.buttonNumber6.Click += new System.EventHandler(this.buttonNumber6_Click);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber5.Location = new System.Drawing.Point(90, 271);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(68, 64);
            this.buttonNumber5.TabIndex = 12;
            this.buttonNumber5.Tag = "";
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = true;
            this.buttonNumber5.Click += new System.EventHandler(this.buttonNumber5_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber4.Location = new System.Drawing.Point(12, 271);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(72, 64);
            this.buttonNumber4.TabIndex = 11;
            this.buttonNumber4.Tag = "";
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            this.buttonNumber4.Click += new System.EventHandler(this.buttonNumber4_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber3.Location = new System.Drawing.Point(164, 341);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(72, 64);
            this.buttonNumber3.TabIndex = 16;
            this.buttonNumber3.Tag = "";
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            this.buttonNumber3.Click += new System.EventHandler(this.buttonNumber3_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber2.Location = new System.Drawing.Point(90, 341);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(68, 64);
            this.buttonNumber2.TabIndex = 15;
            this.buttonNumber2.Tag = "";
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            this.buttonNumber2.Click += new System.EventHandler(this.buttonNumber2_Click);
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber1.Location = new System.Drawing.Point(12, 341);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(72, 64);
            this.buttonNumber1.TabIndex = 14;
            this.buttonNumber1.Tag = "";
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber1_Click);
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber0.Location = new System.Drawing.Point(90, 415);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(68, 64);
            this.buttonNumber0.TabIndex = 17;
            this.buttonNumber0.Tag = "";
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = true;
            this.buttonNumber0.Click += new System.EventHandler(this.buttonNumber0_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoint.Location = new System.Drawing.Point(12, 415);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(72, 64);
            this.buttonPoint.TabIndex = 18;
            this.buttonPoint.Tag = "";
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.button12_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlack.ForeColor = System.Drawing.Color.White;
            this.buttonBlack.Location = new System.Drawing.Point(90, 109);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(72, 36);
            this.buttonBlack.TabIndex = 19;
            this.buttonBlack.Text = "black";
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.SystemColors.Control;
            this.buttonWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhite.ForeColor = System.Drawing.Color.Black;
            this.buttonWhite.Location = new System.Drawing.Point(168, 109);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(72, 36);
            this.buttonWhite.TabIndex = 20;
            this.buttonWhite.Text = "white";
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonCopy_click
            // 
            this.buttonCopy_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopy_click.Location = new System.Drawing.Point(164, 415);
            this.buttonCopy_click.Name = "buttonCopy_click";
            this.buttonCopy_click.Size = new System.Drawing.Size(72, 64);
            this.buttonCopy_click.TabIndex = 21;
            this.buttonCopy_click.Tag = "";
            this.buttonCopy_click.Text = "Copy";
            this.buttonCopy_click.UseVisualStyleBackColor = true;
            this.buttonCopy_click.Click += new System.EventHandler(this.buttonCopy_click_Click);
            // 
            // buttonParenteses
            // 
            this.buttonParenteses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParenteses.ForeColor = System.Drawing.Color.Black;
            this.buttonParenteses.Location = new System.Drawing.Point(12, 151);
            this.buttonParenteses.Name = "buttonParenteses";
            this.buttonParenteses.Size = new System.Drawing.Size(72, 44);
            this.buttonParenteses.TabIndex = 22;
            this.buttonParenteses.Text = "( )";
            this.buttonParenteses.UseVisualStyleBackColor = true;
            this.buttonParenteses.Click += new System.EventHandler(this.buttonParenteses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(329, 491);
            this.Controls.Add(this.buttonParenteses);
            this.Controls.Add(this.buttonCopy_click);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonNumber0);
            this.Controls.Add(this.buttonNumber3);
            this.Controls.Add(this.buttonNumber2);
            this.Controls.Add(this.buttonNumber1);
            this.Controls.Add(this.buttonNumber6);
            this.Controls.Add(this.buttonNumber5);
            this.Controls.Add(this.buttonNumber4);
            this.Controls.Add(this.buttonNumber9);
            this.Controls.Add(this.buttonNumber8);
            this.Controls.Add(this.buttonNumber7);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiple);
            this.Controls.Add(this.buttonLess);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.textBoxDisplay);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Calculadora do Alex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonLess;
        private System.Windows.Forms.Button buttonMultiple;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonNumber7;
        private System.Windows.Forms.Button buttonNumber8;
        private System.Windows.Forms.Button buttonNumber9;
        private System.Windows.Forms.Button buttonNumber6;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button buttonNumber0;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonCopy_click;
        private System.Windows.Forms.Button buttonParenteses;
    }
}

