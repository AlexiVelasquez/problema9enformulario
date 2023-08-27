namespace problema9enformulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {




        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {


        }

        private void boton_Click(object sender, EventArgs e)
        {



            int num1 = int.Parse(txt1.Text);
            int num2 = int.Parse(txt2.Text);
            int num3 = int.Parse(txt3.Text);

            if (num1 > num2 && num1 > num3)
            {


                lbl1.Text = ("El numero mayor es:" + num1);

            }

            if (num2 > num1 && num2 > num3)
            {


                lbl1.Text = ("El numero mayor es:" + num2);

            }

            if (num3 > num1 && num3 > num2)
            {


                lbl1.Text = ("El numero mayor es:" + num3);

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}