namespace FoodAppTemplate
{
    partial class RestaurantApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.SidePannelButton = new System.Windows.Forms.Panel();
            this.CustomersButtons = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.TakeAwayButton = new System.Windows.Forms.Button();
            this.DeliveryButton = new System.Windows.Forms.Button();
            this.CollectionButton = new System.Windows.Forms.Button();
            this.EatInButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.secondUserControl1 = new FoodAppTemplate.SecondUserControl();
            this.firstCustomControl1 = new FoodAppTemplate.FirstCustomControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.SidePannelButton);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.CustomersButtons);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.PaymentButton);
            this.panel1.Controls.Add(this.TakeAwayButton);
            this.panel1.Controls.Add(this.DeliveryButton);
            this.panel1.Controls.Add(this.CollectionButton);
            this.panel1.Controls.Add(this.EatInButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 592);
            this.panel1.TabIndex = 0;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(9, 522);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(52, 58);
            this.button13.TabIndex = 13;
            this.button13.Text = "?";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // SidePannelButton
            // 
            this.SidePannelButton.BackColor = System.Drawing.Color.DarkRed;
            this.SidePannelButton.Location = new System.Drawing.Point(0, 81);
            this.SidePannelButton.Name = "SidePannelButton";
            this.SidePannelButton.Size = new System.Drawing.Size(10, 48);
            this.SidePannelButton.TabIndex = 3;
            // 
            // CustomersButtons
            // 
            this.CustomersButtons.FlatAppearance.BorderSize = 0;
            this.CustomersButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersButtons.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButtons.ForeColor = System.Drawing.Color.White;
            this.CustomersButtons.Image = ((System.Drawing.Image)(resources.GetObject("CustomersButtons.Image")));
            this.CustomersButtons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersButtons.Location = new System.Drawing.Point(9, 388);
            this.CustomersButtons.Name = "CustomersButtons";
            this.CustomersButtons.Size = new System.Drawing.Size(189, 45);
            this.CustomersButtons.TabIndex = 9;
            this.CustomersButtons.Text = "        Customers";
            this.CustomersButtons.UseVisualStyleBackColor = true;
            this.CustomersButtons.Click += new System.EventHandler(this.CustomersButtons_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.ForeColor = System.Drawing.Color.White;
            this.PaymentButton.Image = ((System.Drawing.Image)(resources.GetObject("PaymentButton.Image")));
            this.PaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentButton.Location = new System.Drawing.Point(12, 337);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(189, 45);
            this.PaymentButton.TabIndex = 8;
            this.PaymentButton.Text = "     Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // TakeAwayButton
            // 
            this.TakeAwayButton.FlatAppearance.BorderSize = 0;
            this.TakeAwayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TakeAwayButton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakeAwayButton.ForeColor = System.Drawing.Color.White;
            this.TakeAwayButton.Image = ((System.Drawing.Image)(resources.GetObject("TakeAwayButton.Image")));
            this.TakeAwayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TakeAwayButton.Location = new System.Drawing.Point(12, 286);
            this.TakeAwayButton.Name = "TakeAwayButton";
            this.TakeAwayButton.Size = new System.Drawing.Size(189, 45);
            this.TakeAwayButton.TabIndex = 7;
            this.TakeAwayButton.Text = "        Take Away";
            this.TakeAwayButton.UseVisualStyleBackColor = true;
            this.TakeAwayButton.Click += new System.EventHandler(this.TakeAwayButton_Click);
            // 
            // DeliveryButton
            // 
            this.DeliveryButton.FlatAppearance.BorderSize = 0;
            this.DeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryButton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryButton.ForeColor = System.Drawing.Color.White;
            this.DeliveryButton.Image = ((System.Drawing.Image)(resources.GetObject("DeliveryButton.Image")));
            this.DeliveryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryButton.Location = new System.Drawing.Point(12, 235);
            this.DeliveryButton.Name = "DeliveryButton";
            this.DeliveryButton.Size = new System.Drawing.Size(189, 45);
            this.DeliveryButton.TabIndex = 6;
            this.DeliveryButton.Text = "     Delivery";
            this.DeliveryButton.UseVisualStyleBackColor = true;
            this.DeliveryButton.Click += new System.EventHandler(this.DeliveryButton_Click);
            // 
            // CollectionButton
            // 
            this.CollectionButton.FlatAppearance.BorderSize = 0;
            this.CollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollectionButton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollectionButton.ForeColor = System.Drawing.Color.White;
            this.CollectionButton.Image = ((System.Drawing.Image)(resources.GetObject("CollectionButton.Image")));
            this.CollectionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CollectionButton.Location = new System.Drawing.Point(12, 184);
            this.CollectionButton.Name = "CollectionButton";
            this.CollectionButton.Size = new System.Drawing.Size(189, 45);
            this.CollectionButton.TabIndex = 5;
            this.CollectionButton.Text = "        Collection";
            this.CollectionButton.UseVisualStyleBackColor = true;
            this.CollectionButton.Click += new System.EventHandler(this.CollectionButton_Click);
            // 
            // EatInButton
            // 
            this.EatInButton.FlatAppearance.BorderSize = 0;
            this.EatInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EatInButton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EatInButton.ForeColor = System.Drawing.Color.White;
            this.EatInButton.Image = ((System.Drawing.Image)(resources.GetObject("EatInButton.Image")));
            this.EatInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EatInButton.Location = new System.Drawing.Point(12, 133);
            this.EatInButton.Name = "EatInButton";
            this.EatInButton.Size = new System.Drawing.Size(189, 45);
            this.EatInButton.TabIndex = 4;
            this.EatInButton.Text = "  Eat-In";
            this.EatInButton.UseVisualStyleBackColor = true;
            this.EatInButton.Click += new System.EventHandler(this.EatInButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(12, 82);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(189, 45);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "  Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 46);
            this.panel2.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(1049, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(47, 44);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Transparent;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(955, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(47, 44);
            this.button11.TabIndex = 13;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(1002, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(47, 44);
            this.button12.TabIndex = 14;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(217, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 118);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Restaurant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(331, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "C# UI Design by Andrei Roca";
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(18, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 58);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(76, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 58);
            this.button9.TabIndex = 11;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(134, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 58);
            this.button10.TabIndex = 12;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // secondUserControl1
            // 
            this.secondUserControl1.BackColor = System.Drawing.Color.White;
            this.secondUserControl1.Location = new System.Drawing.Point(201, 179);
            this.secondUserControl1.Name = "secondUserControl1";
            this.secondUserControl1.Size = new System.Drawing.Size(907, 459);
            this.secondUserControl1.TabIndex = 14;
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.BackColor = System.Drawing.Color.White;
            this.firstCustomControl1.Location = new System.Drawing.Point(201, 179);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(907, 459);
            this.firstCustomControl1.TabIndex = 13;
            // 
            // RestaurantApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 638);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondUserControl1);
            this.Controls.Add(this.firstCustomControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestaurantApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TakeAwayButton;
        private System.Windows.Forms.Button DeliveryButton;
        private System.Windows.Forms.Button CollectionButton;
        private System.Windows.Forms.Button EatInButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button CustomersButtons;
        private System.Windows.Forms.Panel SidePannelButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private FirstCustomControl firstCustomControl1;
        private SecondUserControl secondUserControl1;
    }
}

