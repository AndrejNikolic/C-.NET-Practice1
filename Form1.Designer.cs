namespace DomaciZadatak6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.add_truck = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_maxWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_passingers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_maxHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_wings = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add_car = new System.Windows.Forms.Button();
            this.add_plane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(105, 47);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(86, 23);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // add_truck
            // 
            this.add_truck.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_truck.Location = new System.Drawing.Point(19, 186);
            this.add_truck.Name = "add_truck";
            this.add_truck.Size = new System.Drawing.Size(182, 26);
            this.add_truck.TabIndex = 2;
            this.add_truck.Text = "Dodaj Kamion";
            this.add_truck.UseVisualStyleBackColor = true;
            this.add_truck.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(225, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(568, 382);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Težina";
            // 
            // textBox_weight
            // 
            this.textBox_weight.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_weight.Location = new System.Drawing.Point(105, 76);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(86, 23);
            this.textBox_weight.TabIndex = 5;
            this.textBox_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max. brzina";
            // 
            // textBox_speed
            // 
            this.textBox_speed.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_speed.Location = new System.Drawing.Point(105, 105);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.Size = new System.Drawing.Size(86, 23);
            this.textBox_speed.TabIndex = 7;
            this.textBox_speed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max. težina tereta";
            // 
            // textBox_maxWeight
            // 
            this.textBox_maxWeight.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maxWeight.Location = new System.Drawing.Point(144, 157);
            this.textBox_maxWeight.Name = "textBox_maxWeight";
            this.textBox_maxWeight.Size = new System.Drawing.Size(57, 23);
            this.textBox_maxWeight.TabIndex = 9;
            this.textBox_maxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Broj putnika";
            // 
            // textBox_passingers
            // 
            this.textBox_passingers.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passingers.Location = new System.Drawing.Point(152, 232);
            this.textBox_passingers.Name = "textBox_passingers";
            this.textBox_passingers.Size = new System.Drawing.Size(49, 23);
            this.textBox_passingers.TabIndex = 11;
            this.textBox_passingers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max visina";
            // 
            // textBox_maxHeight
            // 
            this.textBox_maxHeight.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maxHeight.Location = new System.Drawing.Point(145, 310);
            this.textBox_maxHeight.Name = "textBox_maxHeight";
            this.textBox_maxHeight.Size = new System.Drawing.Size(56, 23);
            this.textBox_maxHeight.TabIndex = 13;
            this.textBox_maxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Raspon krila";
            // 
            // textBox_wings
            // 
            this.textBox_wings.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_wings.Location = new System.Drawing.Point(152, 337);
            this.textBox_wings.Name = "textBox_wings";
            this.textBox_wings.Size = new System.Drawing.Size(49, 23);
            this.textBox_wings.TabIndex = 15;
            this.textBox_wings.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Vozilo podaci";
            // 
            // add_car
            // 
            this.add_car.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_car.Location = new System.Drawing.Point(59, 261);
            this.add_car.Name = "add_car";
            this.add_car.Size = new System.Drawing.Size(142, 28);
            this.add_car.TabIndex = 19;
            this.add_car.Text = "Dodaj Automobil";
            this.add_car.UseVisualStyleBackColor = true;
            this.add_car.Click += new System.EventHandler(this.add_car_Click);
            // 
            // add_plane
            // 
            this.add_plane.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_plane.Location = new System.Drawing.Point(66, 369);
            this.add_plane.Name = "add_plane";
            this.add_plane.Size = new System.Drawing.Size(135, 27);
            this.add_plane.TabIndex = 20;
            this.add_plane.Text = "Dodaj Avion";
            this.add_plane.UseVisualStyleBackColor = true;
            this.add_plane.Click += new System.EventHandler(this.add_plane_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 431);
            this.Controls.Add(this.add_plane);
            this.Controls.Add(this.add_car);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_wings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_maxHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_passingers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_maxWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add_truck);
            this.Controls.Add(this.textBox_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domaći Zadatak 06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button add_truck;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_maxWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_passingers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_maxHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_wings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_car;
        private System.Windows.Forms.Button add_plane;
    }
}

