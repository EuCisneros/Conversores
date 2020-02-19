using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    private void Resolver()
    {
            if (txtentrada.Text != "")
            {
                double dato = Convert.ToDouble(txtentrada.Text);
                int tipo1 = cmbentrada.SelectedIndex;
                int tipo2 = cmbsalida.SelectedIndex;

                //0= RUBLO RUSO
                //1= PESO FILIPINO
                //2= PESO CHILENO
                //3= PESO COLOMBIANO
                //4= DOLAR ESTADOUNIDENSE
                //5=
                //6= KILOMETROS
                //7= METROS
                //8= PIES
                //9= PULGADAS
                //10= CENTIMETROS
                //11=
                //12= QUINTAL
                //13= TONELADA
                //14= LIBRA
                //15= ONZA
                //16= GRAMO
                //17=
                //18= KILÓMETRO CÚBICO
                //19= DECÁMETRO CÚBICO
                //20= METRO CÚBICO
                //21= DECÍMETRO CÚBICO
                //22= MILÍMETRO CÚBICO

             switch (tipo1)
                {
                 case 0:
                        if (tipo2 == 0)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 1)
                            txtsalida.Text = (dato * 0.79).ToString();
                        if (tipo2 == 2)
                            txtsalida.Text = (dato * 62.46).ToString();
                        if (tipo2 == 3)
                            txtsalida.Text = (dato * 53.30).ToString();
                        if (tipo2 == 4)
                            txtsalida.Text = (dato * 0.016).ToString();
                        break;
                    case 1:
                        if (tipo2 == 0)
                            txtsalida.Text = (dato* 1.26).ToString(); ;
                        if (tipo2 == 1)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 2)
                            txtsalida.Text = (dato * 15.77).ToString();
                        if (tipo2 == 3)
                            txtsalida.Text = (dato * 67.34).ToString();
                        if (tipo2 == 4)
                            txtsalida.Text = (dato * 0.020).ToString();
                        break;
                    case 2:
                        if (tipo2 == 0)
                            txtsalida.Text = (dato * 63.88).ToString(); ;
                        if (tipo2 == 1)
                            txtsalida.Text = (dato* 50.55).ToString();
                        if (tipo2 == 2)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 3)
                            txtsalida.Text = (dato * 3, 403.90).ToString();
                        if (tipo2 == 4)
                            txtsalida.Text = (dato * 0.0013).ToString();
                        break;
                    case 3:
                        if (tipo2 == 0)
                            txtsalida.Text = (dato * 0.019).ToString(); ;
                        if (tipo2 == 1)
                            txtsalida.Text = (dato * 0.015).ToString();
                        if (tipo2 == 2)
                            txtsalida.Text = (dato * 0.23).ToString();
                        if (tipo2 == 3)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 4)
                            txtsalida.Text = (dato * 0.00029).ToString();
                        break;
                    case 4:
                        if (tipo2 == 0)
                            txtsalida.Text = (dato * 63.88).ToString();
                        if (tipo2 == 1)
                            txtsalida.Text = (dato * 50.54).ToString();
                        if (tipo2 == 2)
                            txtsalida.Text = (dato * 797.40).ToString();
                        if (tipo2 == 3)
                            txtsalida.Text = (dato * 3, 403.90).ToString();
                        if (tipo2 == 4)
                            txtsalida.Text = dato.ToString();
                        break;
                    case 6:
                        if (tipo2 == 6)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 7)
                            txtsalida.Text = (dato * 1000).ToString();
                        if (tipo2 == 8)
                            txtsalida.Text = (dato * 3280.84).ToString();
                        if (tipo2 == 9)
                            txtsalida.Text = (dato * 39370.08).ToString();
                        if (tipo2 == 10)
                            txtsalida.Text = (dato * 100000).ToString();
                        break;
                    case 7:
                        if (tipo2 == 6)
                            txtsalida.Text = (dato* 0.001).ToString();
                        if (tipo2 == 7)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 8)
                            txtsalida.Text = (dato* 3.28084).ToString();
                        if (tipo2 == 9)
                            txtsalida.Text = (dato* 39.3701).ToString();
                        if (tipo2 == 10)
                            txtsalida.Text = (dato* 100).ToString();
                        break;
                    case 8:
                        if (tipo2 == 6)
                            txtsalida.Text = (dato* 0.0003048).ToString();
                        if (tipo2 == 7)
                            txtsalida.Text = (dato* 0.3048).ToString();
                        if (tipo2 == 8)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 9)
                            txtsalida.Text = (dato* 12).ToString();
                        if (tipo2 == 10)
                            txtsalida.Text = (dato* 30.48).ToString();
                        break;
                    case 9:
                        if (tipo2 == 6)
                            txtsalida.Text = (dato* 2.54e-5).ToString();
                        if (tipo2 == 7)
                            txtsalida.Text = (dato* 0.0254).ToString();
                        if (tipo2 == 8)
                            txtsalida.Text = (dato* 0.0833333).ToString();
                        if (tipo2 == 9)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 10)
                            txtsalida.Text = (dato* 2.54).ToString();
                        break;
                    case 10:
                        if (tipo2 == 6)
                            txtsalida.Text = (dato* 1e-5).ToString();
                        if (tipo2 == 7)
                            txtsalida.Text = (dato* 0.01).ToString();
                        if (tipo2 == 8)
                            txtsalida.Text = (dato* 0.0328084).ToString();
                        if (tipo2 == 9)
                            txtsalida.Text = (dato* 0.393701).ToString();
                        if (tipo2 == 10)
                            txtsalida.Text = dato.ToString();
                        break;
                    case 12:
                        if (tipo2 == 12)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 13)
                            txtsalida.Text = (dato* 0.1).ToString();
                        if (tipo2 == 14)
                            txtsalida.Text = (dato* 220.462).ToString();
                        if (tipo2 == 15)
                            txtsalida.Text = (dato* 3527.4).ToString();
                        if (tipo2 == 16)
                            txtsalida.Text = (dato* 100000).ToString();
                        break;
                    case 13:
                        if (tipo2 == 12)
                            txtsalida.Text = (dato* 10).ToString();
                        if (tipo2 == 13)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 14)
                            txtsalida.Text = (dato* 2204.62).ToString();
                        if (tipo2 == 15)
                            txtsalida.Text = (dato* 35274).ToString();
                        if (tipo2 == 16)
                            txtsalida.Text = (dato* 1e+6).ToString();
                        break;
                    case 14:
                        if (tipo2 == 12)
                            txtsalida.Text = (dato* 0.00453592).ToString();
                        if (tipo2 == 13)
                            txtsalida.Text = (dato* 0.000453592).ToString();
                        if (tipo2 == 14)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 15)
                            txtsalida.Text = (dato* 16).ToString();
                        if (tipo2 == 16)
                            txtsalida.Text = (dato* 453.592).ToString();
                        break;
                    case 15:
                        if (tipo2 == 12)
                            txtsalida.Text = (dato* 0.000283495).ToString();
                        if (tipo2 == 13)
                            txtsalida.Text = (dato* 2.835e-5).ToString();
                        if (tipo2 == 14)
                            txtsalida.Text = (dato* 0.0625).ToString();
                        if (tipo2 == 15)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 16)
                            txtsalida.Text = (dato* 28.3495).ToString();
                        break;
                    case 16:
                        if (tipo2 == 12)
                            txtsalida.Text = (dato* 1e-5).ToString();
                        if (tipo2 == 13)
                            txtsalida.Text = (dato* 1e-6).ToString();
                        if (tipo2 == 14)
                            txtsalida.Text = (dato* 0.00220462).ToString();
                        if (tipo2 == 15)
                            txtsalida.Text = (dato* 0.035274).ToString();
                        if (tipo2 == 16)
                            txtsalida.Text = dato.ToString();
                        break;
                    case 18:
                        if (tipo2 == 18)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 19)
                            txtsalida.Text = (dato* 1000000).ToString();
                        if (tipo2 == 20)
                            txtsalida.Text = (dato* 1e+9).ToString();
                        if (tipo2 == 21)
                            txtsalida.Text = (dato* 1e+6).ToString();
                        if (tipo2 == 22)
                            txtsalida.Text = (dato* 1e+9).ToString();
                        break;
                    case 19:
                        if (tipo2 == 18)
                            txtsalida.Text = (dato* 1e-6).ToString();
                        if (tipo2 == 19)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 20)
                            txtsalida.Text = (dato* 1000).ToString();
                        if (tipo2 == 21)
                            txtsalida.Text = (dato* 1000000).ToString();
                        if (tipo2 == 22)
                            txtsalida.Text = (dato* 1e+12).ToString();
                        break;
                    case 20:
                        if (tipo2 == 18)
                            txtsalida.Text = (dato* 1e-6).ToString();
                        if (tipo2 == 19)
                            txtsalida.Text = (dato* 0.001).ToString();
                        if (tipo2 == 20)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 21)
                            txtsalida.Text = (dato* 1000).ToString();
                        if (tipo2 == 22)
                            txtsalida.Text = (dato* 1e+9).ToString();
                        break;
                    case 21:
                        if (tipo2 == 18)
                            txtsalida.Text = (dato* 1e-12).ToString();
                        if (tipo2 == 19)
                            txtsalida.Text = (dato* 1e-6).ToString();
                        if (tipo2 == 20)
                            txtsalida.Text = (dato* 0.001).ToString();
                        if (tipo2 == 21)
                            txtsalida.Text = dato.ToString();
                        if (tipo2 == 22)
                            txtsalida.Text = (dato* 1000000).ToString();
                        break;
                    case 22:
                        if (tipo2 == 18)
                            txtsalida.Text = (dato* 1e-18).ToString();
                        if (tipo2 == 19)
                            txtsalida.Text = (dato* 1e-12).ToString();
                        if (tipo2 == 20)
                            txtsalida.Text = (dato* 1e-9).ToString();
                        if (tipo2 == 21)
                            txtsalida.Text = (dato* 1e-6).ToString();
                        if (tipo2 == 22)
                            txtsalida.Text = dato.ToString();
                        break;
                }
            }

        }

        private void txtentrada_TextChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void cmbentrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolver();
        }

        private void cmbsalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resolver();
        }
    }
  
}
