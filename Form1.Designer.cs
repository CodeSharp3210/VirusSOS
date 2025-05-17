namespace VirusSOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 30);
            label1.TabIndex = 0;
            label1.Text = "Minecraft Seed Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(516, 30);
            label2.TabIndex = 1;
            label2.Text = "Inserisci il numero minimo e massimo di caratteri";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(549, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "1 - 10";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(12, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 25);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Seed alfanumerico";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(198, 261);
            label3.Name = "label3";
            label3.Size = new Size(408, 30);
            label3.TabIndex = 4;
            label3.Text = "Il seed generato verrà visualizzato qui";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 356);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(471, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(567, 399);
            button1.Name = "button1";
            button1.Size = new Size(235, 58);
            button1.TabIndex = 6;
            button1.Text = "Premi qui per generare";
            button1.UseVisualStyleBackColor = true;
            //
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 481);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Minecraft Seed Generator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
    }
}
