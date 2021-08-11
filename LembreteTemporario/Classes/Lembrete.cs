using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LembreteTemporario.Classes
{
    public class Lembrete
    {

        private string textoLembrete;
        private string tempoRepetir;
        private decimal horaLembrar;
        private decimal minLembrar;
        private decimal segLembrar;
        private Timer timer;

        private decimal horaCrono = 0;
        private decimal minCrono = 0;
        private decimal segCrono = 0;
        private string cronometro;

        private decimal quantasVezes;
        private decimal auxVezes = 0;

        private bool onOff;
        public Lembrete(string texto, decimal hr, decimal min, decimal seg, decimal qtdVezes)
        {
            this.textoLembrete = texto;
            this.horaLembrar = hr;
            this.minLembrar = min;
            this.segLembrar = seg;
            timer = new Timer();
            timer.Interval = 1000;
            this.quantasVezes = qtdVezes;
            inicializarTimer();
        }

        public string getTextoLembrete()
        {
            return textoLembrete;
        }

        public string getTempoRepetir()
        {
            return Convert.ToString(horaLembrar + ":" + minLembrar + ":" + segLembrar);
        }

        public decimal getHora()
        {
            return horaLembrar;
        }

        public decimal getMinuto()
        {
            return minLembrar;
        }

        public decimal getSegundo()
        {
            return segLembrar;
        }

        public string getCronometro()
        {
            return Convert.ToString(horaCrono + ":" + minCrono + ":" + segCrono);
        }

        public decimal getQtdVezes()
        {
            return quantasVezes;
        }

        public decimal getAuxVezes()
        {
            return auxVezes;
        }

        public void inicializarTimer()
        {
            timer.Start();
            onOff = true;
        }

        public void encerrarTimer()
        {
            timer.Stop();
            onOff = false;
        }

        public void reiniciarTimer()
        {
            horaCrono = 0;
            minCrono = 0;
            segCrono = 0;
            onOff = true;
            auxVezes++;
        }

        public bool getOnOff()
        {
            return onOff;
        }

        public void ControlarRelogio()
        {
            segCrono++;

            if (segCrono == 60)
            {
                segCrono = 0;

                minCrono++;

                if (minCrono == 60)
                {
                    minCrono = 0;

                    horaCrono++;
                }
            }

        }

        public void Temporizador_Tick(object sender, EventArgs e)
        {
            ControlarRelogio();
            //cronometro = horaCrono + ":" + minCrono + ":" + segCrono;
        }



    }
}
