using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClientForWSA
{
    public partial class Form1 : Form
    {
        // https://localhost:44394/WebService1.asmx link to connect
        WindowsFormsClientForWSA.ServiceReference1.WebService1SoapClient service = new WindowsFormsClientForWSA.ServiceReference1.WebService1SoapClient();
        private void buttonFToC_Click(object sender, EventArgs e)
        { 
            // Convertor Celsius->Fahrenheit
            textBoxRezultat.Text = (service.aFromFahrenheittoCelsius(Int32.Parse(textBoxTempF.Text))).ToString();
        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            textBoxRezultat.Text = (service.aFromCelsiustoFahrenheit(Int32.Parse(textBoxTempC.Text))).ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            //listBoxLista.Text = service.cfiveElements(buttonAddList.Text).ToString();
            listBoxLista.Items.Add("One mango");
            listBoxLista.Items.Add("Two bananas");
            listBoxLista.Items.Add("Three apples");
            listBoxLista.Items.Add("Four strawberries");
            listBoxLista.Items.Add("Five bubbles");
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void textBoxEurotoLei_TextChanged(object sender, EventArgs e)
        {
            try {
                textBoxEurotoLei2.Text = (service.dEuroToLei(Int32.Parse(textBoxEurotoLei.Text))).ToString();
            }
            catch {
                MessageBox.Show("You can add only numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEurotoLei2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxRotoEuro1_TextChanged(object sender, EventArgs e)
        {
            try {
                textBoxRotoEuro2.Text = (service.dLeiToEuro(Int32.Parse(textBoxRotoEuro1.Text))).ToString();
            }
            catch {
                MessageBox.Show("You can add only numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelData_Click(object sender, EventArgs e)
        {
            labelData.Text = DateTime.Now.ToString("dddddd, dd MMMMMM yyy HH':'mm':'ss");
            //labelData.Text = service.bDateTimeDisplay(labelData.Text).ToString();
        }
    }
}
