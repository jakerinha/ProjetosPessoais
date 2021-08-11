using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LembreteTemporario.Classes;


namespace LembreteTemporario.Forms
{
    public partial class TelaPrincipal : Form
    {
        List<Lembrete> lembretes = new List<Lembrete>();

        Lembrete lembrete;

        int hora = 0, min = 0, seg = 0;

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            lembrete = new Lembrete(rtxtLembrete.Text, nudHora.Value, nudMin.Value, nudSeg.Value, nudRepetir.Value);

            lembretes.Add(lembrete);

            rtxtLembrete.Clear();
            nudHora.Value = 0;
            nudMin.Value = 0;
            nudSeg.Value = 0;
            nudRepetir.Value = 0;

            preencherDataGridLembrete();
        }

        private void preencherDataGridLembrete()
        {
            if(dgvLembretes.RowCount == 0)
            {
                dgvLembretes.Rows.Add();
                dgvLembretes.Rows[0].Cells[dgvTextoLembrete.Index].Value = lembrete.getTextoLembrete();
                dgvLembretes.Rows[0].Cells[dgvTempoLembrar.Index].Value = lembrete.getTempoRepetir();
                dgvLembretes.Rows[0].Cells[dgvCronometro.Index].Value = lembrete.getCronometro();
            }
            else
            {
                dgvLembretes.Rows.Add();
                dgvLembretes.Rows[dgvLembretes.RowCount - 1].Cells[dgvTextoLembrete.Index].Value = lembrete.getTextoLembrete();
                dgvLembretes.Rows[dgvLembretes.RowCount - 1].Cells[dgvTempoLembrar.Index].Value = lembrete.getTempoRepetir();
                dgvLembretes.Rows[dgvLembretes.RowCount - 1].Cells[dgvCronometro.Index].Value = lembrete.getCronometro();
            }
        }

        private void dgvLembretes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //Adicionar remoção de lembretes aqui... posteriormente
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            lblTimer.Text = Convert.ToString("Tempo em Execução: " + hora + ":" + min + ":" + seg);
            tempoCronometro.Start();
        }

        private void tempoCronometro_Tick(object sender, EventArgs e)
        {
            ControlarRelogio();
            lblTimer.Text = Convert.ToString("Tempo em Execução: " + hora + ":" + min + ":" + seg);

            int i = dgvLembretes.RowCount;
            int aux = 0;
            
            foreach (Lembrete x in lembretes)
            {
                if (x.getOnOff() == true)
                {
                    x.Temporizador_Tick(sender, e);
                    dgvLembretes.Rows[aux].Cells[dgvCronometro.Index].Value = x.getCronometro();

                    if(x.getTempoRepetir() == x.getCronometro())
                    {
                        //x.encerrarTimer();
                        //MessageBox.Show("Lembrete: \n" + x.getTextoLembrete());
                        x.encerrarTimer();
                        if (MessageBox.Show("Lembrete: \n" + x.getTextoLembrete() + "\nFoi concluido?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            dgvLembretes.Rows[aux].DefaultCellStyle.BackColor = Color.Green;
                        }
                        else
                        {
                            x.encerrarTimer();
                            if (x.getAuxVezes() == x.getQtdVezes())
                            {
                                dgvLembretes.Rows[aux].DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                x.reiniciarTimer();
                                dgvLembretes.Rows[aux].Cells[dgvCronometro.Index].Value = x.getCronometro();

                            }
                        }

                    }
                }
                
                aux++;

                if(aux > i)
                {
                    break;
                }
            }
                
            

        }

        private void ControlarRelogio()
        {
            seg++;

            if(seg == 60)
            {
                seg = 0;

                min++;

                if(min == 60)
                {
                    min = 0;

                    hora++;
                }
            }

        }

        /* Cronomêtro
         * Referente a terceira coluna da GRID, ela
         * deve decrementar a cada segundo que passa.
         * Utilizando a ferramenta TIMER, acredito que deva funcionar.
         */
    }
}
