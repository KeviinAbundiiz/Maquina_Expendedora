using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Expendedora
{
    class Dinero
    {
        int dinerototal;
        bool clickeable = false;
        public int DINEROTOTAL
        {
            get
            {
                return dinerototal;
            }
            set
            {
                dinerototal = value;
            }
        }
        public bool CLICKEABLE
        {
            get
            {
                return clickeable;
            }
            set
            {
                clickeable = value;
            }
        }
        public void InsertarDinero(int monedas)
        {
            dinerototal += monedas;
           
        }
        public void RegresaCambio(int monedas)
        {
            dinerototal -= monedas;
        }
        public struct PilaLimites
        {
            public int tope;
            public int Max;
        }
        //---------Declara Arreglos-------
        public PilaLimites[] LimiteDePila = new PilaLimites[12];
        public bool[] Chocoroles = new bool[5];
        public bool[] Pinguinos = new bool[5];
        public bool[] Gansitos = new bool[5];
        public bool[] Principes = new bool[5];
        public bool[] Trikitrakes = new bool[5];
        public bool[] Submarinos = new bool[5];
        public bool[] Barritas = new bool[5];
        public bool[] Canelitas = new bool[5];
        public bool[] Polvorones = new bool[5];
        public bool[] Spanch = new bool[5];
        public bool[] Lors = new bool[5];
        public bool[] Suavicremas = new bool[5];
        //------------------------------------
        public void Maximiza_Max_tope()
        {
            for(int i = 0; i < 12; i++)
            {
                LimiteDePila[i].Max = 4;
                LimiteDePila[i].tope = 4;
            }
        }
        public void LlenarMaquina()
        {
            Maximiza_Max_tope();
            for(int i = 0; i<5; i++)
            {
                Chocoroles[i] = true;
                Pinguinos[i] = true;
                Gansitos[i] = true;
                Principes[i] = true;
                Trikitrakes[i] = true;
                Submarinos[i] = true;
                Barritas[i] = true;
                Canelitas[i] = true;
                Polvorones[i] = true;
                Spanch[i] = true;
                Lors[i] = true;
                Suavicremas[i] = true;
            }
        }
    }
}
