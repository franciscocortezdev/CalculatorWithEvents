namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        
        
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(33, 75);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultado.MaxLength = 15;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(281, 45);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TabStop = false;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(33, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 79);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(106, 401);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 79);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(177, 401);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 79);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(33, 312);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 71);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(106, 312);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 71);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(177, 312);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 71);
            this.button6.TabIndex = 6;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(33, 221);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 71);
            this.button7.TabIndex = 7;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(106, 221);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 71);
            this.button8.TabIndex = 8;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(177, 221);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 71);
            this.button9.TabIndex = 9;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(248, 221);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 71);
            this.button10.TabIndex = 10;
            this.button10.TabStop = false;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.agregarOperador);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(248, 312);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(66, 71);
            this.button11.TabIndex = 11;
            this.button11.TabStop = false;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.agregarOperador);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(248, 401);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(66, 79);
            this.button12.TabIndex = 12;
            this.button12.TabStop = false;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.agregarOperador);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResultado.Location = new System.Drawing.Point(248, 492);
            this.btnResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(66, 79);
            this.btnResultado.TabIndex = 0;
            this.btnResultado.TabStop = false;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            this.btnResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFunction);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPunto.Location = new System.Drawing.Point(175, 492);
            this.btnPunto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(66, 79);
            this.btnPunto.TabIndex = 14;
            this.btnPunto.TabStop = false;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(33, 492);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(135, 79);
            this.button15.TabIndex = 15;
            this.button15.TabStop = false;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.agregarNumero);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(33, 143);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(66, 71);
            this.button16.TabIndex = 16;
            this.button16.TabStop = false;
            this.button16.Text = "%";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.agregarOperador);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button17.Location = new System.Drawing.Point(106, 143);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(66, 71);
            this.button17.TabIndex = 17;
            this.button17.TabStop = false;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.agregarOperador);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAll.Location = new System.Drawing.Point(177, 143);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(64, 71);
            this.btnDeleteAll.TabIndex = 18;
            this.btnDeleteAll.TabStop = false;
            this.btnDeleteAll.Text = "C";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOne.Location = new System.Drawing.Point(248, 143);
            this.btnDeleteOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(66, 71);
            this.btnDeleteOne.TabIndex = 19;
            this.btnDeleteOne.TabStop = false;
            this.btnDeleteOne.Text = "<";
            this.btnDeleteOne.UseVisualStyleBackColor = true;
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(33, 37);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(0, 20);
            this.lblHistorial.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(350, 620);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Calculator App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFunction);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResultado;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btnResultado;
        private Button btnPunto;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button btnDeleteAll;
        private Button btnDeleteOne;
        private Label lblHistorial;
    }
}