using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Electronica
{

    public partial class Form1 : Form
    {

        List<productos> p = new List<productos>;

        p.Add(new producto("Cajas ATX",20000,02304,12));
        p.Add(new producto("Procesadores",80000,1204,5));
        p.Add(new producto("Impresora láser",120000,2399,12));
        p.Add(new producto("Tarjetas de Expansión",143020,6754,23));
        p.Add(new producto("Tarjetas de Red",40000,2345,30));
        p.Add(new producto("Ventiladores y Accesorios Refrigeración",50000,2334,40));
     
            


        List<string> productos = new List<string> { "Cajas yyy", "Procesadores", "Impresora láser", "Laptop", "Tarjetas de Expansión" };
        //List<int> precio = new List<int> { 50000, 400000,60000,80000,58000};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[2].Value = comboBox1.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBox3.Text;
            if (radioButton1.Checked == true) dataGridView1.Rows[n].Cells[8].Value = "efectivo";
            if (radioButton2.Checked == true) dataGridView1.Rows[n].Cells[8].Value = "tarjeta Debito";
            if (radioButton3.Checked == true) dataGridView1.Rows[n].Cells[8].Value = "tarjeta Crédito";
            //dataGridView1.Rows[n].Cells[4].Value = precio.Find(comboBox1.SelectedIndex);
           //if (comboBox1.Text == productos[0]) dataGridView1.Rows[n].Cells[4].Value= 50000;
           
           

                





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            comboBox1.Items.Add("Cajas ATX");
            comboBox1.Items.Add("Procesadores");
            comboBox1.Items.Add("Impresora láser");
            comboBox1.Items.Add("Laptop");
            comboBox1.Items.Add("Tarjetas de Expansión");
            comboBox1.Items.Add("Tarjetas de Red");
            comboBox1.Items.Add("Ventiladores y Accesorios Refrigeración");
            comboBox1.Items.Add("Computador de escritorio");
            */

            for (int i = 0; i < productos.Count; i++)
            {
                comboBox1.Items.Add(productos[i]);
            }

            foreach (var producto in Productos)
            {
                comboBox1.Items.Add("{0} [{1}]", producto.name, producto.stock);
            }


        }
            private void button5_Click(object sender, EventArgs e)
            {

            }

            private void button5_Click_1(object sender, EventArgs e)
            {
                panel2.Visible = true;
            }

        private void Agregar_Producto_Click(object sender, EventArgs e)
        {
            productos.Add(Agre_Product.Text);



            comboBox1.Items.Add(Agre_Product.Text);
            
            //productos[productos.Count + 1] = Agre_Product.Text;
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}

