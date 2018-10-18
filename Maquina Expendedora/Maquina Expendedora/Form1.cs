using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina_Expendedora
{
    public partial class Form1 : Form
    {
        Dinero ObjetoDinero = new Dinero();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObjetoDinero.LlenarMaquina();
            tb_chocoroles.Text = Convert.ToString(ObjetoDinero.LimiteDePila[0].tope+1);
            tb_pinguinos.Text = Convert.ToString(ObjetoDinero.LimiteDePila[1].tope+1);
            tb_gansito.Text = Convert.ToString(ObjetoDinero.LimiteDePila[2].tope+1);
            tb_principe.Text = Convert.ToString(ObjetoDinero.LimiteDePila[3].tope+1);
            tb_trikitrakes.Text = Convert.ToString(ObjetoDinero.LimiteDePila[4].tope+1);
            tb_submarinos.Text = Convert.ToString(ObjetoDinero.LimiteDePila[5].tope+1);
            tb_barritas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[6].tope+1);
            tb_canelitas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[7].tope+1);
            tb_polvorones.Text = Convert.ToString(ObjetoDinero.LimiteDePila[8].tope+1);
            tb_spanch.Text = Convert.ToString(ObjetoDinero.LimiteDePila[9].tope+1);
            tb_lors.Text = Convert.ToString(ObjetoDinero.LimiteDePila[10].tope+1);
            tb_suavicremas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[11].tope+1);
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "0";
            
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text+"1";
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "2";
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "3";
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "4";
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "5";
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "6";
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "7";
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "8";
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "9";
        }

        private void tb_panel_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            tb_panel.Text = null;
            tb_Mostrador.Text = null;
            if (ObjetoDinero.CLICKEABLE == true)
            {
                gb_Productos.BackColor = DefaultBackColor;
                ObjetoDinero.CLICKEABLE = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox8_Click(object sender, EventArgs e)//picturebox_1peso
        {
            ObjetoDinero.InsertarDinero(1);
            tb_Mostrador.Text = "Credito: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
        }

        private void pb_2pesos_Click(object sender, EventArgs e)
        {
            ObjetoDinero.InsertarDinero(2);
            tb_Mostrador.Text = "Credito: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
        }

        private void pb_5pesos_Click(object sender, EventArgs e)
        {
            ObjetoDinero.InsertarDinero(5);
            tb_Mostrador.Text = "Credito: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
        }

        private void pb_10pesos_Click(object sender, EventArgs e)
        {
            ObjetoDinero.InsertarDinero(10);
            tb_Mostrador.Text = "Credito: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
        }

        private void pb_20pesos_Click(object sender, EventArgs e)
        {
            ObjetoDinero.InsertarDinero(20);
            tb_Mostrador.Text = "Credito: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
            
        }

        private void pb_50pesos_Click(object sender, EventArgs e)
        {
            ObjetoDinero.InsertarDinero(50);
            tb_Mostrador.Text = "Credito: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
        }

        private void b_A_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "A";
        }

        private void b_B_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "B";
        }

        private void b_C_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "C";
        }

        private void b_D_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "D";
        }


        private void b_E_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "E";
        }

        private void b_F_Click(object sender, EventArgs e)
        {
            tb_panel.Text = tb_panel.Text + "F";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void b_enter_Click(object sender, EventArgs e)
        {
            if(tb_panel.Text != null)
            {
                switch (tb_panel.Text)
                {
                    case "2B":
                        {
                            if (ObjetoDinero.LimiteDePila[0].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 16)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Chocoroles[ObjetoDinero.LimiteDePila[0].tope] = false;
                                    ObjetoDinero.LimiteDePila[0].tope--;
                                    tb_chocoroles.Text = Convert.ToString(ObjetoDinero.LimiteDePila[0].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[0].tope == -1)
                                    {
                                        pb_chocorol.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(16);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(16 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "2D":
                        {
                            if (ObjetoDinero.LimiteDePila[1].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 12)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Pinguinos[ObjetoDinero.LimiteDePila[1].tope] = false;
                                    ObjetoDinero.LimiteDePila[1].tope--;
                                    tb_pinguinos.Text = Convert.ToString(ObjetoDinero.LimiteDePila[1].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[1].tope == -1)
                                    {
                                        pb_pinguinos.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(12);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(12 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "2F":
                        {
                            if (ObjetoDinero.LimiteDePila[2].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 14)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Gansitos[ObjetoDinero.LimiteDePila[2].tope] = false;
                                    ObjetoDinero.LimiteDePila[2].tope--;
                                    tb_gansito.Text = Convert.ToString(ObjetoDinero.LimiteDePila[2].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[2].tope == -1)
                                    {
                                        pb_gansito.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(14);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(14 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "4B":
                        {
                            if (ObjetoDinero.LimiteDePila[3].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 16)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Principes[ObjetoDinero.LimiteDePila[3].tope] = false;
                                    ObjetoDinero.LimiteDePila[3].tope--;
                                    tb_principe.Text = Convert.ToString(ObjetoDinero.LimiteDePila[3].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[3].tope == -1)
                                    {
                                        pictureBox4.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(16);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(16 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "4D":
                        {
                            if (ObjetoDinero.LimiteDePila[4].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 16)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Trikitrakes[ObjetoDinero.LimiteDePila[4].tope] = false;
                                    ObjetoDinero.LimiteDePila[4].tope--;
                                    tb_trikitrakes.Text = Convert.ToString(ObjetoDinero.LimiteDePila[4].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[4].tope == -1)
                                    {
                                        pb_trikitrakes.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(16);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(16 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "4F":
                        {
                            if (ObjetoDinero.LimiteDePila[5].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 14)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Submarinos[ObjetoDinero.LimiteDePila[5].tope] = false;
                                    ObjetoDinero.LimiteDePila[5].tope--;
                                    tb_submarinos.Text = Convert.ToString(ObjetoDinero.LimiteDePila[5].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[5].tope == -1)
                                    {
                                        pb_submarinos.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(14);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(14 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "6B":
                        {
                            if (ObjetoDinero.LimiteDePila[6].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 8)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Barritas[ObjetoDinero.LimiteDePila[6].tope] = false;
                                    ObjetoDinero.LimiteDePila[6].tope--;
                                    tb_barritas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[6].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[6].tope == -1)
                                    {
                                        pb_barritas.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(8);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(8 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "6D":
                        {
                            if (ObjetoDinero.LimiteDePila[7].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 16)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Canelitas[ObjetoDinero.LimiteDePila[7].tope] = false;
                                    ObjetoDinero.LimiteDePila[7].tope--;
                                    tb_canelitas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[7].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[7].tope == -1)
                                    {
                                        pb_canelitas.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(16);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(16 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "6F":
                        {
                            if (ObjetoDinero.LimiteDePila[8].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 14)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Polvorones[ObjetoDinero.LimiteDePila[8].tope] = false;
                                    ObjetoDinero.LimiteDePila[8].tope--;
                                    tb_polvorones.Text = Convert.ToString(ObjetoDinero.LimiteDePila[8].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[8].tope == -1)
                                    {
                                        pb_polvorones.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(14);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(14 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "8B":
                        {
                            if (ObjetoDinero.LimiteDePila[9].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 12)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Spanch[ObjetoDinero.LimiteDePila[9].tope] = false;
                                    ObjetoDinero.LimiteDePila[9].tope--;
                                    tb_spanch.Text = Convert.ToString(ObjetoDinero.LimiteDePila[9].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[9].tope == -1)
                                    {
                                        pb_spanch.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(12);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(12 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "8D":
                        {
                            if (ObjetoDinero.LimiteDePila[10].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 14)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Lors[ObjetoDinero.LimiteDePila[10].tope] = false;
                                    ObjetoDinero.LimiteDePila[10].tope--;
                                    tb_lors.Text = Convert.ToString(ObjetoDinero.LimiteDePila[10].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[10].tope == -1)
                                    {
                                        pb_lors.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(14);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(14 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "8F":
                        {
                            if (ObjetoDinero.LimiteDePila[11].tope >= 0)
                            {
                                if (ObjetoDinero.DINEROTOTAL >= 14)
                                {
                                    //Lo fisico de pila
                                    ObjetoDinero.Suavicremas[ObjetoDinero.LimiteDePila[11].tope] = false;
                                    ObjetoDinero.LimiteDePila[11].tope--;
                                    tb_suavicremas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[11].tope + 1);
                                    if (ObjetoDinero.LimiteDePila[11].tope == -1)
                                    {
                                        pb_suavicremas.Image = Maquina_Expendedora.Properties.Resources.Agotado;
                                        //Se le dio doble click antes de cambiarle el nombre y no se moverle al archivo program
                                    }
                                    //Lo visual
                                    ObjetoDinero.RegresaCambio(14);
                                    tb_Mostrador.Text = "Tu cambio es: $" + Convert.ToString(ObjetoDinero.DINEROTOTAL);
                                    ObjetoDinero.DINEROTOTAL = 0;
                                    tb_panel.Text = null;
                                }
                                else
                                {
                                    tb_Mostrador.Text = "Inserta: $" + (Convert.ToString(14 - ObjetoDinero.DINEROTOTAL));
                                }
                            }
                            else
                            {
                                tb_Mostrador.Text = "Agotado...";
                            }
                            break;
                        }
                    case "C0CA":
                        {
                            ObjetoDinero.CLICKEABLE = true;
                            gb_Productos.BackColor = Color.DarkGray;
                            break;
                        }
                    case "":
                        {
                            tb_Mostrador.Text = "Inserta coordenada";
                            break;
                        }
                    default:
                        {
                            tb_Mostrador.Text = "Producto No Existe";
                            tb_panel.Text = null;
                            break;
                        }
                }
            }
        }
        private void pb_chocorol_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if(ObjetoDinero.LimiteDePila[0].tope < ObjetoDinero.LimiteDePila[0].Max)
                {
                    ObjetoDinero.LimiteDePila[0].tope++;
                    ObjetoDinero.Chocoroles[ObjetoDinero.LimiteDePila[0].tope] = true;
                    tb_chocoroles.Text = Convert.ToString(ObjetoDinero.LimiteDePila[0].tope+1);
                    if(ObjetoDinero.LimiteDePila[0].tope == 0)
                    {
                        pb_chocorol.Image = Maquina_Expendedora.Properties.Resources.Chocoroles;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_pinguinos_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[1].tope < ObjetoDinero.LimiteDePila[1].Max)
                {
                    ObjetoDinero.LimiteDePila[1].tope++;
                    ObjetoDinero.Pinguinos[ObjetoDinero.LimiteDePila[1].tope] = true;
                    tb_pinguinos.Text = Convert.ToString(ObjetoDinero.LimiteDePila[1].tope + 1);
                    if (ObjetoDinero.LimiteDePila[1].tope == 0)
                    {
                        pb_pinguinos.Image = Maquina_Expendedora.Properties.Resources.pinguinos;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_gansito_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[2].tope < ObjetoDinero.LimiteDePila[2].Max)
                {
                    ObjetoDinero.LimiteDePila[2].tope++;
                    ObjetoDinero.Gansitos[ObjetoDinero.LimiteDePila[2].tope] = true;
                    tb_gansito.Text = Convert.ToString(ObjetoDinero.LimiteDePila[2].tope + 1);
                    if (ObjetoDinero.LimiteDePila[2].tope == 0)
                    {
                        pb_gansito.Image = Maquina_Expendedora.Properties.Resources.Gansito1;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)//picturebox_principe
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[3].tope < ObjetoDinero.LimiteDePila[3].Max)
                {
                    ObjetoDinero.LimiteDePila[3].tope++;
                    ObjetoDinero.Principes[ObjetoDinero.LimiteDePila[3].tope] = true;
                    tb_principe.Text = Convert.ToString(ObjetoDinero.LimiteDePila[3].tope + 1);
                    if (ObjetoDinero.LimiteDePila[3].tope == 0)
                    {
                        pictureBox4.Image = Maquina_Expendedora.Properties.Resources.principe;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_trikitrakes_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[4].tope < ObjetoDinero.LimiteDePila[4].Max)
                {
                    ObjetoDinero.LimiteDePila[4].tope++;
                    ObjetoDinero.Trikitrakes[ObjetoDinero.LimiteDePila[4].tope] = true;
                    tb_trikitrakes.Text = Convert.ToString(ObjetoDinero.LimiteDePila[4].tope + 1);
                    if (ObjetoDinero.LimiteDePila[4].tope == 0)
                    {
                        pb_trikitrakes.Image = Maquina_Expendedora.Properties.Resources.triki_trakes;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_submarinos_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[5].tope < ObjetoDinero.LimiteDePila[5].Max)
                {
                    ObjetoDinero.LimiteDePila[5].tope++;
                    ObjetoDinero.Submarinos[ObjetoDinero.LimiteDePila[5].tope] = true;
                    tb_submarinos.Text = Convert.ToString(ObjetoDinero.LimiteDePila[5].tope + 1);
                    if (ObjetoDinero.LimiteDePila[5].tope == 0)
                    {
                        pb_submarinos.Image = Maquina_Expendedora.Properties.Resources.Submarinos;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_barritas_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[6].tope < ObjetoDinero.LimiteDePila[6].Max)
                {
                    ObjetoDinero.LimiteDePila[6].tope++;
                    ObjetoDinero.Barritas[ObjetoDinero.LimiteDePila[6].tope] = true;
                    tb_barritas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[6].tope + 1);
                    if (ObjetoDinero.LimiteDePila[6].tope == 0)
                    {
                        pb_barritas.Image = Maquina_Expendedora.Properties.Resources.barritas;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_canelitas_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[7].tope < ObjetoDinero.LimiteDePila[7].Max)
                {
                    ObjetoDinero.LimiteDePila[7].tope++;
                    ObjetoDinero.Canelitas[ObjetoDinero.LimiteDePila[7].tope] = true;
                    tb_canelitas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[7].tope + 1);
                    if (ObjetoDinero.LimiteDePila[7].tope == 0)
                    {
                        pb_canelitas.Image = Maquina_Expendedora.Properties.Resources.canelitas;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_polvorones_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[8].tope < ObjetoDinero.LimiteDePila[8].Max)
                {
                    ObjetoDinero.LimiteDePila[8].tope++;
                    ObjetoDinero.Polvorones[ObjetoDinero.LimiteDePila[8].tope] = true;
                    tb_polvorones.Text = Convert.ToString(ObjetoDinero.LimiteDePila[8].tope + 1);
                    if (ObjetoDinero.LimiteDePila[8].tope == 0)
                    {
                        pb_polvorones.Image = Maquina_Expendedora.Properties.Resources.polvorones;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_spanch_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[9].tope < ObjetoDinero.LimiteDePila[9].Max)
                {
                    ObjetoDinero.LimiteDePila[9].tope++;
                    ObjetoDinero.Spanch[ObjetoDinero.LimiteDePila[9].tope] = true;
                    tb_spanch.Text = Convert.ToString(ObjetoDinero.LimiteDePila[9].tope + 1);
                    if (ObjetoDinero.LimiteDePila[9].tope == 0)
                    {
                        pb_spanch.Image = Maquina_Expendedora.Properties.Resources.spanch;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_lors_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[10].tope < ObjetoDinero.LimiteDePila[10].Max)
                {
                    ObjetoDinero.LimiteDePila[10].tope++;
                    ObjetoDinero.Lors[ObjetoDinero.LimiteDePila[10].tope] = true;
                    tb_lors.Text = Convert.ToString(ObjetoDinero.LimiteDePila[10].tope + 1);
                    if (ObjetoDinero.LimiteDePila[10].tope == 0)
                    {
                        pb_lors.Image = Maquina_Expendedora.Properties.Resources.lors;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }
        private void pb_suavicremas_Click(object sender, EventArgs e)
        {
            if (ObjetoDinero.CLICKEABLE == true)
            {
                if (ObjetoDinero.LimiteDePila[11].tope < ObjetoDinero.LimiteDePila[11].Max)
                {
                    ObjetoDinero.LimiteDePila[11].tope++;
                    ObjetoDinero.Suavicremas[ObjetoDinero.LimiteDePila[11].tope] = true;
                    tb_suavicremas.Text = Convert.ToString(ObjetoDinero.LimiteDePila[11].tope + 1);
                    if (ObjetoDinero.LimiteDePila[11].tope == 0)
                    {
                        pb_suavicremas.Image = Maquina_Expendedora.Properties.Resources.suavicremas;
                    }
                }
                else
                {
                    tb_Mostrador.Text = "Lleno";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_Mostrador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
