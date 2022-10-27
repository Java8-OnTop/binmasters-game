namespace control
{
    partial class Binmasters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Binmasters));
            this.add_bins_button = new System.Windows.Forms.Button();
            this.buy_robot_button = new System.Windows.Forms.Button();
            this.buy_farm_button = new System.Windows.Forms.Button();
            this.factory_buy_button = new System.Windows.Forms.Button();
            this.powerplant_buy_button = new System.Windows.Forms.Button();
            this.quantumcomputer_buy_button = new System.Windows.Forms.Button();
            this.warehouse_buy_button = new System.Windows.Forms.Button();
            this.shopLabel = new System.Windows.Forms.Label();
            this.bins_amount = new System.Windows.Forms.Label();
            this.robots_label = new System.Windows.Forms.Label();
            this.farms_label = new System.Windows.Forms.Label();
            this.factories_label = new System.Windows.Forms.Label();
            this.power_plants_label = new System.Windows.Forms.Label();
            this.quantum_computers_label = new System.Windows.Forms.Label();
            this.warehouses_label = new System.Windows.Forms.Label();
            this.robots_amount_label = new System.Windows.Forms.Label();
            this.farms_amount_label = new System.Windows.Forms.Label();
            this.factories_amount_label = new System.Windows.Forms.Label();
            this.powerplants_amount_label = new System.Windows.Forms.Label();
            this.quantumcomputers_amount_label = new System.Windows.Forms.Label();
            this.warehouses_amount_label = new System.Windows.Forms.Label();
            this.bins_amount_label = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            this.bins_storage_amount_label = new System.Windows.Forms.Label();
            this.bins_per_click_label = new System.Windows.Forms.Label();
            // 
            // add_bins_button
            // 
            this.add_bins_button.Location = new System.Drawing.Point(18, 18);
            this.add_bins_button.Name = "add_bins_button";
            this.add_bins_button.Size = new System.Drawing.Size(75, 23);
            this.add_bins_button.TabIndex = 0;
            this.add_bins_button.Text = "Click";
            this.add_bins_button.UseVisualStyleBackColor = true;
            this.add_bins_button.Click += new System.EventHandler(this.add_bins_button_Click);
            // 
            // buy_robot_button
            // 
            this.buy_robot_button.Location = new System.Drawing.Point(634, 90);
            this.buy_robot_button.Name = "buy_robot_button";
            this.buy_robot_button.Size = new System.Drawing.Size(95, 46);
            this.buy_robot_button.TabIndex = 1;
            this.buy_robot_button.Text = "1x Robot: " + robot_price;
            this.buy_robot_button.UseVisualStyleBackColor = true;
            this.buy_robot_button.Click += new System.EventHandler(this.buy_robot_button_Click);
            // 
            // buy_farm_button
            // 
            this.buy_farm_button.Location = new System.Drawing.Point(634, 140);
            this.buy_farm_button.Name = "buy_farm_button";
            this.buy_farm_button.Size = new System.Drawing.Size(95, 46);
            this.buy_farm_button.TabIndex = 2;
            this.buy_farm_button.Text = "1x Farm: " + farm_price;
            this.buy_farm_button.UseVisualStyleBackColor = true;
            this.buy_farm_button.Click += new System.EventHandler(this.buy_farm_button_Click);
            // 
            // factory_buy_button
            // 
            this.factory_buy_button.Location = new System.Drawing.Point(634, 188);
            this.factory_buy_button.Name = "factory_buy_button";
            this.factory_buy_button.Size = new System.Drawing.Size(95, 46);
            this.factory_buy_button.TabIndex = 3;
            this.factory_buy_button.Text = "1x Factory: " + factory_price;
            this.factory_buy_button.UseVisualStyleBackColor = true;
            this.factory_buy_button.Click += new System.EventHandler(this.factory_buy_button_Click);
            // 
            // powerplant_buy_button
            // 
            this.powerplant_buy_button.Location = new System.Drawing.Point(634, 238);
            this.powerplant_buy_button.Name = "powerplant_buy_button";
            this.powerplant_buy_button.Size = new System.Drawing.Size(95, 40);
            this.powerplant_buy_button.TabIndex = 4;
            this.powerplant_buy_button.Text = "1x Power Plant: " + powerplant_price;
            this.powerplant_buy_button.UseVisualStyleBackColor = true;
            this.powerplant_buy_button.Click += new System.EventHandler(this.powerplant_buy_button_Click);
            // 
            // quantumcomputer_buy_button
            // 
            this.quantumcomputer_buy_button.Location = new System.Drawing.Point(634, 279);
            this.quantumcomputer_buy_button.Name = "quantumcomputer_buy_button";
            this.quantumcomputer_buy_button.Size = new System.Drawing.Size(95, 60);
            this.quantumcomputer_buy_button.TabIndex = 5;
            this.quantumcomputer_buy_button.Text = "1x Quantum Computer: " + quantumcomputer_price;
            this.quantumcomputer_buy_button.UseVisualStyleBackColor = true;
            this.quantumcomputer_buy_button.Click += new System.EventHandler(this.quantumcomputer_buy_button_Click);
            // 
            // warehouse_buy_button
            // 
            this.warehouse_buy_button.Location = new System.Drawing.Point(634, 345);
            this.warehouse_buy_button.Name = "warehouse_buy_button";
            this.warehouse_buy_button.Size = new System.Drawing.Size(95, 46);
            this.warehouse_buy_button.TabIndex = 6;
            this.warehouse_buy_button.Text = "1x Warehouse: " + warehouse_price;
            this.warehouse_buy_button.UseVisualStyleBackColor = true;
            this.warehouse_buy_button.Click += new System.EventHandler(this.warehouse_buy_button_Click);
            // 
            // shopLabel
            // 
            this.shopLabel.AutoSize = true;
            this.shopLabel.Location = new System.Drawing.Point(654, 52);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(38, 15);
            this.shopLabel.TabIndex = 7;
            this.shopLabel.Text = "SHOP";
            // 
            // bins_amount
            // 
            this.bins_amount.AutoSize = true;
            this.bins_amount.Location = new System.Drawing.Point(36, 73);
            this.bins_amount.Name = "bins_amount";
            this.bins_amount.Size = new System.Drawing.Size(35, 15);
            this.bins_amount.TabIndex = 8;
            this.bins_amount.Text = "Bins: ";
            // 
            // robots_label
            // 
            this.robots_label.AutoSize = true;
            this.robots_label.Location = new System.Drawing.Point(18, 130);
            this.robots_label.Name = "robots_label";
            this.robots_label.Size = new System.Drawing.Size(50, 15);
            this.robots_label.TabIndex = 9;
            this.robots_label.Text = "Robots: ";
            // 
            // farms_label
            // 
            this.farms_label.AutoSize = true;
            this.farms_label.Location = new System.Drawing.Point(18, 159);
            this.farms_label.Name = "farms_label";
            this.farms_label.Size = new System.Drawing.Size(45, 15);
            this.farms_label.TabIndex = 10;
            this.farms_label.Text = "Farms: ";
            // 
            // factories_label
            // 
            this.factories_label.AutoSize = true;
            this.factories_label.Location = new System.Drawing.Point(18, 188);
            this.factories_label.Name = "factories_label";
            this.factories_label.Size = new System.Drawing.Size(60, 15);
            this.factories_label.TabIndex = 11;
            this.factories_label.Text = "Factories: ";
            // 
            // power_plants_label
            // 
            this.power_plants_label.AutoSize = true;
            this.power_plants_label.Location = new System.Drawing.Point(18, 213);
            this.power_plants_label.Name = "power_plants_label";
            this.power_plants_label.Size = new System.Drawing.Size(78, 15);
            this.power_plants_label.TabIndex = 12;
            this.power_plants_label.Text = "Power Plants:";
            // 
            // quantum_computers_label
            // 
            this.quantum_computers_label.AutoSize = true;
            this.quantum_computers_label.Location = new System.Drawing.Point(18, 234);
            this.quantum_computers_label.Name = "quantum_computers_label";
            this.quantum_computers_label.Size = new System.Drawing.Size(123, 15);
            this.quantum_computers_label.TabIndex = 13;
            this.quantum_computers_label.Text = "Quantum Computers:";
            // 
            // warehouses_label
            // 
            this.warehouses_label.AutoSize = true;
            this.warehouses_label.Location = new System.Drawing.Point(18, 257);
            this.warehouses_label.Name = "warehouses_label";
            this.warehouses_label.Size = new System.Drawing.Size(74, 15);
            this.warehouses_label.TabIndex = 14;
            this.warehouses_label.Text = "Warehouses:";
            // 
            // robots_amount_label
            // 
            this.robots_amount_label.AutoSize = true;
            this.robots_amount_label.Location = new System.Drawing.Point(74, 130);
            this.robots_amount_label.Name = "robots_amount_label";
            this.robots_amount_label.Size = new System.Drawing.Size(13, 15);
            this.robots_amount_label.TabIndex = 15;
            this.robots_amount_label.Text = "0";
            // 
            // farms_amount_label
            // 
            this.farms_amount_label.AutoSize = true;
            this.farms_amount_label.Location = new System.Drawing.Point(69, 159);
            this.farms_amount_label.Name = "farms_amount_label";
            this.farms_amount_label.Size = new System.Drawing.Size(13, 15);
            this.farms_amount_label.TabIndex = 16;
            this.farms_amount_label.Text = "0";
            // 
            // factories_amount_label
            // 
            this.factories_amount_label.AutoSize = true;
            this.factories_amount_label.Location = new System.Drawing.Point(83, 188);
            this.factories_amount_label.Name = "factories_amount_label";
            this.factories_amount_label.Size = new System.Drawing.Size(13, 15);
            this.factories_amount_label.TabIndex = 17;
            this.factories_amount_label.Text = "0";
            // 
            // powerplants_amount_label
            // 
            this.powerplants_amount_label.AutoSize = true;
            this.powerplants_amount_label.Location = new System.Drawing.Point(102, 213);
            this.powerplants_amount_label.Name = "powerplants_amount_label";
            this.powerplants_amount_label.Size = new System.Drawing.Size(13, 15);
            this.powerplants_amount_label.TabIndex = 18;
            this.powerplants_amount_label.Text = "0";
            // 
            // quantumcomputers_amount_label
            // 
            this.quantumcomputers_amount_label.AutoSize = true;
            this.quantumcomputers_amount_label.Location = new System.Drawing.Point(147, 234);
            this.quantumcomputers_amount_label.Name = "quantumcomputers_amount_label";
            this.quantumcomputers_amount_label.Size = new System.Drawing.Size(13, 15);
            this.quantumcomputers_amount_label.TabIndex = 19;
            this.quantumcomputers_amount_label.Text = "0";
            // 
            // warehouses_amount_label
            // 
            this.warehouses_amount_label.AutoSize = true;
            this.warehouses_amount_label.Location = new System.Drawing.Point(98, 257);
            this.warehouses_amount_label.Name = "warehouses_amount_label";
            this.warehouses_amount_label.Size = new System.Drawing.Size(13, 15);
            this.warehouses_amount_label.TabIndex = 20;
            this.warehouses_amount_label.Text = "0";
            // 
            // bins_amount_amount_label
            // 
            this.bins_amount_label.AutoSize = true;
            this.bins_amount_label.Location = new System.Drawing.Point(77, 73);
            this.bins_amount_label.Name = "bins_amount_label";
            this.bins_amount_label.Size = new System.Drawing.Size(13, 15);
            this.bins_amount_label.TabIndex = 21;
            this.bins_amount_label.Text = "0";
            //
            // bins_storage_label
            // 
            this.bins_storage_amount_label.AutoSize = true;
            this.bins_storage_amount_label.Location = new System.Drawing.Point(130, 73);
            this.bins_storage_amount_label.Name = "bins_storage_amount_label";
            this.bins_storage_amount_label.Size = new System.Drawing.Size(13, 15);
            this.bins_storage_amount_label.TabIndex = 21;
            this.bins_storage_amount_label.Text = "/ 75000";
            //
            // bins_per_click_label
            //
            this.bins_per_click_label.AutoSize = true;
            this.bins_per_click_label.Location = new System.Drawing.Point(36, 93);
            this.bins_per_click_label.Name = "bins_per_click_label";
            this.bins_per_click_label.Size = new System.Drawing.Size(13, 15);
            this.bins_per_click_label.TabIndex = 21;
            this.bins_per_click_label.Text = "Bins per Click: 1";
            //
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(-3, 436);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(118, 15);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://binmasters.tk/";
            // 
            // Binmasters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bins_amount_label);
            this.Controls.Add(this.warehouses_amount_label);
            this.Controls.Add(this.quantumcomputers_amount_label);
            this.Controls.Add(this.powerplants_amount_label);
            this.Controls.Add(this.factories_amount_label);
            this.Controls.Add(this.farms_amount_label);
            this.Controls.Add(this.robots_amount_label);
            this.Controls.Add(this.warehouses_label);
            this.Controls.Add(this.quantum_computers_label);
            this.Controls.Add(this.power_plants_label);
            this.Controls.Add(this.factories_label);
            this.Controls.Add(this.farms_label);
            this.Controls.Add(this.robots_label);
            this.Controls.Add(this.bins_amount);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.warehouse_buy_button);
            this.Controls.Add(this.quantumcomputer_buy_button);
            this.Controls.Add(this.powerplant_buy_button);
            this.Controls.Add(this.factory_buy_button);
            this.Controls.Add(this.buy_farm_button);
            this.Controls.Add(this.buy_robot_button);
            this.Controls.Add(this.add_bins_button);
            this.Controls.Add(this.bins_storage_amount_label);
            this.Controls.Add(this.bins_per_click_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Binmasters";
            this.Text = "Binmasters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button add_bins_button;
        private Button buy_robot_button;
        private Button buy_farm_button;
        private Button factory_buy_button;
        private Button powerplant_buy_button;
        private Button quantumcomputer_buy_button;
        private Button warehouse_buy_button;
        private Label shopLabel;
        private Label bins_amount;
        private Label robots_label;
        private Label farms_label;
        private Label factories_label;
        private Label power_plants_label;
        private Label quantum_computers_label;
        private Label warehouses_label;
        private Label robots_amount_label;
        private Label farms_amount_label;
        private Label factories_amount_label;
        private Label powerplants_amount_label;
        private Label quantumcomputers_amount_label;
        private Label warehouses_amount_label;
        private Label bins_amount_label;
        private Label bins_storage_amount_label;
        private Label bins_per_click_label;
        private LinkLabel linkLabel1;
        private SaveFileDialog saveFileDialog1;
    }
}