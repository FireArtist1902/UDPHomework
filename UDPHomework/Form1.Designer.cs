namespace UDPHomework
{
    partial class Form1
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
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            BreadCB = new CheckBox();
            EggCB = new CheckBox();
            MilkCB = new CheckBox();
            CheeseCB = new CheckBox();
            SausageCB = new CheckBox();
            FlourCB = new CheckBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 229);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(464, 209);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(297, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(382, 185);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BreadCB
            // 
            BreadCB.AutoSize = true;
            BreadCB.Location = new Point(12, 45);
            BreadCB.Name = "BreadCB";
            BreadCB.Size = new Size(61, 24);
            BreadCB.TabIndex = 4;
            BreadCB.Text = "Хліб";
            BreadCB.UseVisualStyleBackColor = true;
            BreadCB.CheckedChanged += BreadCB_CheckedChanged;
            // 
            // EggCB
            // 
            EggCB.AutoSize = true;
            EggCB.Location = new Point(12, 75);
            EggCB.Name = "EggCB";
            EggCB.Size = new Size(66, 24);
            EggCB.TabIndex = 5;
            EggCB.Text = "Яйця";
            EggCB.UseVisualStyleBackColor = true;
            EggCB.CheckedChanged += EggCB_CheckedChanged;
            // 
            // MilkCB
            // 
            MilkCB.AutoSize = true;
            MilkCB.Location = new Point(12, 105);
            MilkCB.Name = "MilkCB";
            MilkCB.Size = new Size(86, 24);
            MilkCB.TabIndex = 6;
            MilkCB.Text = "Молоко";
            MilkCB.UseVisualStyleBackColor = true;
            MilkCB.CheckedChanged += MilkCB_CheckedChanged;
            // 
            // CheeseCB
            // 
            CheeseCB.AutoSize = true;
            CheeseCB.Location = new Point(12, 135);
            CheeseCB.Name = "CheeseCB";
            CheeseCB.Size = new Size(58, 24);
            CheeseCB.TabIndex = 7;
            CheeseCB.Text = "Сир";
            CheeseCB.UseVisualStyleBackColor = true;
            CheeseCB.CheckedChanged += CheeseCB_CheckedChanged;
            // 
            // SausageCB
            // 
            SausageCB.AutoSize = true;
            SausageCB.Location = new Point(12, 165);
            SausageCB.Name = "SausageCB";
            SausageCB.Size = new Size(89, 24);
            SausageCB.TabIndex = 8;
            SausageCB.Text = "Ковбаса";
            SausageCB.UseVisualStyleBackColor = true;
            SausageCB.CheckedChanged += SausageCB_CheckedChanged;
            // 
            // FlourCB
            // 
            FlourCB.AutoSize = true;
            FlourCB.Location = new Point(12, 195);
            FlourCB.Name = "FlourCB";
            FlourCB.Size = new Size(97, 24);
            FlourCB.TabIndex = 9;
            FlourCB.Text = "Борошно";
            FlourCB.UseVisualStyleBackColor = true;
            FlourCB.CheckedChanged += FlourCB_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(FlourCB);
            Controls.Add(SausageCB);
            Controls.Add(CheeseCB);
            Controls.Add(MilkCB);
            Controls.Add(EggCB);
            Controls.Add(BreadCB);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private CheckBox BreadCB;
        private CheckBox EggCB;
        private CheckBox MilkCB;
        private CheckBox CheeseCB;
        private CheckBox SausageCB;
        private CheckBox FlourCB;
    }
}