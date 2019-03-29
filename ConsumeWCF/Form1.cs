using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumeWCF.NumberConverterWS;

namespace ConsumeWCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCnv_Click(object sender, EventArgs e)
        {
            NumberConverterWS.NumberConversionSoapTypeClient cnv = new NumberConverterWS.NumberConversionSoapTypeClient("NumberConversionSoap");
            tbResult.Text = cnv.NumberToWords(ulong.Parse(tbToConvert.Text));
        }
    }
}
