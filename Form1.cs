namespace control
{
    public partial class Binmasters : Form
    {
        public static int Bins;
        public static int bins_multiplier = 1;
        public static int robots = 0;
        public static int farms = 0;
        public static int factories = 0;
        public static int powerplants = 0;
        public static int quantumcomputers = 0;
        public static int warehouses = 0;
        public static int robot_price = 1000;
        public static int farm_price = 250;
        public static int factory_price = 500;
        public static int powerplant_price = 1500;
        public static int quantumcomputer_price = 15000;
        public static int warehouse_price = 75000;
        public static int bin_storage = 75000;
        public Binmasters()
        {
            InitializeComponent();
        }
        
        private void add_bins_button_Click(object sender, EventArgs e)
        {
            Bins += bins_multiplier;
            bins_amount_label.Text = Bins.ToString();
            bins_storage_amount_label.Text = "/ " + bin_storage;
            bins_per_click_label.Text = "Bins per Click: " + bins_multiplier;
            
            if(Bins >= bin_storage)
            {
                Bins = bin_storage;
            }

            if(Bins >= 100000)
            {
                bins_storage_amount_label.Location = new System.Drawing.Point(140, 73);
            }

            if(Bins >= 100000000)
            {
                bins_storage_amount_label.Location = new System.Drawing.Point(150, 73);
            }

            if(Bins >= 100000000000)
            {
                bins_storage_amount_label.Location = new System.Drawing.Point(160, 73);
            }

            else 
            {
                bins_storage_amount_label.Location = new System.Drawing.Point(140, 73);
            }
        }

        private void buy_robot_button_Click(object sender, EventArgs e)
        {
            if(Bins >= robot_price)
            {
                robots += 1;
                robots_amount_label.Text = robots.ToString();
                Bins -= robot_price;
                bins_amount_label.Text = Bins.ToString();
                bins_multiplier += 8;
                robot_price *= 2;
                buy_robot_button.Text = "1x Robot: " + robot_price;
                bins_per_click_label.Text = "Bins per Click: " + bins_multiplier;
            }
            else {
                MessageBox.Show("You dont have enough bins, get " + robot_price + "+ Bins.");
            }
        }

        private void buy_farm_button_Click(object sender, EventArgs e)
        {
            if(Bins >= farm_price)
            {
                farms += 1;
                farms_amount_label.Text = farms.ToString();
                Bins -= farm_price;
                bins_amount_label.Text = Bins.ToString();
                bins_multiplier += 2;
                farm_price *= 2;
                buy_farm_button.Text = "1x Farm: " + farm_price;
                bins_per_click_label.Text = "Bins per Click: " + bins_multiplier;
            }
            else {
                MessageBox.Show("You dont have enough bins, get " + farm_price + "+ Bins.");
            }
        }

        private void factory_buy_button_Click(object sender, EventArgs e)
        {
            if(Bins >= factory_price)
            {
                factories += 1;
                factories_amount_label.Text = factories.ToString();
                Bins -= factory_price;
                bins_amount_label.Text = Bins.ToString();
                bins_multiplier += 4;
                factory_price *= 2;
                factory_buy_button.Text = "1x Factory: " + factory_price;
                bins_per_click_label.Text = "Bins per Click: " + bins_multiplier;
            }
            else {
                MessageBox.Show("You dont have enough bins, get " + factory_price + "+ Bins.");
            }
        }

        private void powerplant_buy_button_Click(object sender, EventArgs e)
        {
            if(Bins >= powerplant_price)
            {
                powerplants += 1;
                power_plants_label.Text = powerplants.ToString();
                Bins -= powerplant_price;
                bins_amount_label.Text = Bins.ToString();
                bins_multiplier += 12;
                powerplant_price *= 2;
                powerplant_buy_button.Text = "1x Power Plant: " + powerplant_price;
                bins_per_click_label.Text = "Bins per Click: " + bins_multiplier;
            }
            else {
                MessageBox.Show("You dont have enough bins, get " + powerplant_price + "+ Bins.");
            }
        }

        private void quantumcomputer_buy_button_Click(object sender, EventArgs e)
        {
            if(Bins >= quantumcomputer_price)
            {
                quantumcomputers += 1;
                quantum_computers_label.Text = robots.ToString();
                Bins -= quantumcomputer_price;
                bins_amount_label.Text = Bins.ToString();
                bins_multiplier += 100;
                quantumcomputer_price *= 2;
                quantumcomputer_buy_button.Text = "1x Quantum Computer: " + quantumcomputer_price;
                bins_per_click_label.Text = "Bins per Click: " + bins_multiplier;
            }
            else {
                MessageBox.Show("You dont have enough bins, get " + quantumcomputer_price + "+ Bins.");
            }
        }

        private void warehouse_buy_button_Click(object sender, EventArgs e)
        {
            if(Bins >= warehouse_price)
            {
                warehouses += 1;
                warehouses_amount_label.Text = warehouses.ToString();
                Bins -= warehouse_price;
                warehouse_price += 75000;
                warehouse_buy_button.Text = "1x Warehouse: " + warehouse_price;
                bin_storage += 75000;
                bins_amount_label.Text = Bins.ToString();
                bins_storage_amount_label.Text = "/ " + bin_storage;
                bins_per_click_label.Text = "Bins per Click: " + bins_multiplier;
            }
            else {
                MessageBox.Show("You dont have enough bins, get " + warehouse_price + "+ Bins.");
            }
        }
    }
}