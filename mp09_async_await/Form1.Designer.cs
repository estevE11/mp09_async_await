namespace mp09_async_await
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inpt_1 = new System.Windows.Forms.TextBox();
            this.inpt_2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.inpt_date = new System.Windows.Forms.TextBox();
            this.txtBox_1 = new System.Windows.Forms.TextBox();
            this.txtBox_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "btn_1";
            this.button1.Location = new System.Drawing.Point(27, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "btn_2";
            this.button2.Location = new System.Drawing.Point(549, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "MT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inpt_1
            // 
            this.inpt_1.AccessibleName = "inpt_time_1";
            this.inpt_1.Location = new System.Drawing.Point(109, 335);
            this.inpt_1.Name = "inpt_1";
            this.inpt_1.Size = new System.Drawing.Size(203, 20);
            this.inpt_1.TabIndex = 5;
            // 
            // inpt_2
            // 
            this.inpt_2.AccessibleName = "input_time_2";
            this.inpt_2.Location = new System.Drawing.Point(339, 335);
            this.inpt_2.Name = "inpt_2";
            this.inpt_2.Size = new System.Drawing.Size(203, 20);
            this.inpt_2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.AccessibleName = "btn_date";
            this.button3.Location = new System.Drawing.Point(173, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Date";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inpt_date
            // 
            this.inpt_date.AccessibleDescription = "inpt_date";
            this.inpt_date.AccessibleName = "inpt_date";
            this.inpt_date.Location = new System.Drawing.Point(254, 375);
            this.inpt_date.Name = "inpt_date";
            this.inpt_date.Size = new System.Drawing.Size(203, 20);
            this.inpt_date.TabIndex = 8;
            // 
            // txtBox_1
            // 
            this.txtBox_1.Location = new System.Drawing.Point(27, 26);
            this.txtBox_1.Multiline = true;
            this.txtBox_1.Name = "txtBox_1";
            this.txtBox_1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBox_1.Size = new System.Drawing.Size(285, 299);
            this.txtBox_1.TabIndex = 9;
            // 
            // txtBox_2
            // 
            this.txtBox_2.Location = new System.Drawing.Point(339, 26);
            this.txtBox_2.Multiline = true;
            this.txtBox_2.Name = "txtBox_2";
            this.txtBox_2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBox_2.Size = new System.Drawing.Size(285, 299);
            this.txtBox_2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 415);
            this.Controls.Add(this.txtBox_2);
            this.Controls.Add(this.txtBox_1);
            this.Controls.Add(this.inpt_date);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.inpt_2);
            this.Controls.Add(this.inpt_1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Roger Esteve] MP09 UF2 Processos i fils - Practica AsyncAwait";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inpt_1;
        private System.Windows.Forms.TextBox inpt_2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox inpt_date;
        private System.Windows.Forms.TextBox txtBox_1;
        private System.Windows.Forms.TextBox txtBox_2;
    }
}

