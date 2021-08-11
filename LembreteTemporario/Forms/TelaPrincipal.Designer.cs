
namespace LembreteTemporario.Forms
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panLabel = new System.Windows.Forms.Panel();
            this.dgvLembretes = new System.Windows.Forms.DataGridView();
            this.rtxtLembrete = new System.Windows.Forms.RichTextBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tempoCronometro = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudSeg = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRepetir = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rtxtInformativo = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRepeticoes = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnConcluido = new System.Windows.Forms.Button();
            this.btnNaoConcluido = new System.Windows.Forms.Button();
            this.btnPendente = new System.Windows.Forms.Button();
            this.dgvTextoLembrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTempoLembrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCronometro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLembretes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepetir)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLabel
            // 
            this.panLabel.AutoScroll = true;
            this.panLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panLabel.Controls.Add(this.groupBox6);
            this.panLabel.Controls.Add(this.groupBox3);
            this.panLabel.Controls.Add(this.dgvLembretes);
            this.panLabel.Location = new System.Drawing.Point(12, 12);
            this.panLabel.Name = "panLabel";
            this.panLabel.Size = new System.Drawing.Size(382, 182);
            this.panLabel.TabIndex = 2;
            // 
            // dgvLembretes
            // 
            this.dgvLembretes.AllowUserToAddRows = false;
            this.dgvLembretes.AllowUserToDeleteRows = false;
            this.dgvLembretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLembretes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTextoLembrete,
            this.dgvTempoLembrar,
            this.dgvCronometro});
            this.dgvLembretes.Location = new System.Drawing.Point(3, 66);
            this.dgvLembretes.MultiSelect = false;
            this.dgvLembretes.Name = "dgvLembretes";
            this.dgvLembretes.ReadOnly = true;
            this.dgvLembretes.Size = new System.Drawing.Size(301, 101);
            this.dgvLembretes.TabIndex = 0;
            this.dgvLembretes.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvLembretes_RowsRemoved);
            // 
            // rtxtLembrete
            // 
            this.rtxtLembrete.Location = new System.Drawing.Point(10, 32);
            this.rtxtLembrete.Name = "rtxtLembrete";
            this.rtxtLembrete.Size = new System.Drawing.Size(199, 70);
            this.rtxtLembrete.TabIndex = 3;
            this.rtxtLembrete.Text = "";
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(139, 207);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(67, 28);
            this.btnPublicar.TabIndex = 4;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lembrete:";
            // 
            // tempoCronometro
            // 
            this.tempoCronometro.Interval = 1000;
            this.tempoCronometro.Tick += new System.EventHandler(this.tempoCronometro_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(158, 447);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 13);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "<TempoExecução>";
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(10, 36);
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(52, 20);
            this.nudHora.TabIndex = 9;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(72, 36);
            this.nudMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(52, 20);
            this.nudMin.TabIndex = 10;
            // 
            // nudSeg
            // 
            this.nudSeg.Location = new System.Drawing.Point(135, 36);
            this.nudSeg.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeg.Name = "nudSeg";
            this.nudSeg.Size = new System.Drawing.Size(52, 20);
            this.nudSeg.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Min.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seg.:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudHora);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudSeg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 71);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lembrar em:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudRepetir);
            this.groupBox2.Location = new System.Drawing.Point(10, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 50);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repetir(x):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "vezes";
            // 
            // nudRepetir
            // 
            this.nudRepetir.Location = new System.Drawing.Point(6, 20);
            this.nudRepetir.Name = "nudRepetir";
            this.nudRepetir.Size = new System.Drawing.Size(49, 20);
            this.nudRepetir.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbStatus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtFinal);
            this.groupBox3.Controls.Add(this.dtInicio);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(5, 31);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(95, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(106, 31);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(95, 20);
            this.dtFinal.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Início:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Final:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "C",
            "NC",
            "P"});
            this.cbStatus.Location = new System.Drawing.Point(207, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(45, 21);
            this.cbStatus.Sorted = true;
            this.cbStatus.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Status:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(286, 34);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 20);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPublicar);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.rtxtLembrete);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 241);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblRepeticoes);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.lblDuracao);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lblDataEntrada);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblStatus);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.rtxtInformativo);
            this.groupBox5.Location = new System.Drawing.Point(231, 202);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(163, 239);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informativo";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnPendente);
            this.groupBox6.Controls.Add(this.btnNaoConcluido);
            this.groupBox6.Controls.Add(this.btnConcluido);
            this.groupBox6.Location = new System.Drawing.Point(310, 67);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(60, 100);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Controle";
            // 
            // rtxtInformativo
            // 
            this.rtxtInformativo.Location = new System.Drawing.Point(6, 30);
            this.rtxtInformativo.Name = "rtxtInformativo";
            this.rtxtInformativo.ReadOnly = true;
            this.rtxtInformativo.Size = new System.Drawing.Size(151, 70);
            this.rtxtInformativo.TabIndex = 0;
            this.rtxtInformativo.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Lembrete:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(52, 116);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "<Situação>";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Location = new System.Drawing.Point(52, 139);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(67, 13);
            this.lblDataEntrada.TabIndex = 5;
            this.lblDataEntrada.Text = "<DtEntrada>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Data:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(52, 164);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(60, 13);
            this.lblDuracao.TabIndex = 7;
            this.lblDuracao.Text = "<Duração>";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Duração:";
            // 
            // lblRepeticoes
            // 
            this.lblRepeticoes.AutoSize = true;
            this.lblRepeticoes.Location = new System.Drawing.Point(86, 188);
            this.lblRepeticoes.Name = "lblRepeticoes";
            this.lblRepeticoes.Size = new System.Drawing.Size(61, 13);
            this.lblRepeticoes.TabIndex = 9;
            this.lblRepeticoes.Text = "<NumRep>";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Nº Repetições:";
            // 
            // btnConcluido
            // 
            this.btnConcluido.Enabled = false;
            this.btnConcluido.Location = new System.Drawing.Point(6, 19);
            this.btnConcluido.Name = "btnConcluido";
            this.btnConcluido.Size = new System.Drawing.Size(48, 23);
            this.btnConcluido.TabIndex = 0;
            this.btnConcluido.Text = "C";
            this.btnConcluido.UseVisualStyleBackColor = true;
            // 
            // btnNaoConcluido
            // 
            this.btnNaoConcluido.Enabled = false;
            this.btnNaoConcluido.Location = new System.Drawing.Point(6, 46);
            this.btnNaoConcluido.Name = "btnNaoConcluido";
            this.btnNaoConcluido.Size = new System.Drawing.Size(48, 23);
            this.btnNaoConcluido.TabIndex = 1;
            this.btnNaoConcluido.Text = "NC";
            this.btnNaoConcluido.UseVisualStyleBackColor = true;
            // 
            // btnPendente
            // 
            this.btnPendente.Enabled = false;
            this.btnPendente.Location = new System.Drawing.Point(6, 72);
            this.btnPendente.Name = "btnPendente";
            this.btnPendente.Size = new System.Drawing.Size(48, 23);
            this.btnPendente.TabIndex = 2;
            this.btnPendente.Text = "P";
            this.btnPendente.UseVisualStyleBackColor = true;
            // 
            // dgvTextoLembrete
            // 
            this.dgvTextoLembrete.HeaderText = "Lembrete:";
            this.dgvTextoLembrete.Name = "dgvTextoLembrete";
            this.dgvTextoLembrete.ReadOnly = true;
            // 
            // dgvTempoLembrar
            // 
            this.dgvTempoLembrar.HeaderText = "Em:";
            this.dgvTempoLembrar.Name = "dgvTempoLembrar";
            this.dgvTempoLembrar.ReadOnly = true;
            this.dgvTempoLembrar.Width = 75;
            // 
            // dgvCronometro
            // 
            this.dgvCronometro.HeaderText = "Relógio:";
            this.dgvCronometro.Name = "dgvCronometro";
            this.dgvCronometro.ReadOnly = true;
            this.dgvCronometro.Width = 75;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 469);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Lembrete";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLembretes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepetir)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panLabel;
        private System.Windows.Forms.RichTextBox rtxtLembrete;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLembretes;
        private System.Windows.Forms.Timer tempoCronometro;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudSeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRepetir;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnPendente;
        private System.Windows.Forms.Button btnNaoConcluido;
        private System.Windows.Forms.Button btnConcluido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextoLembrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTempoLembrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCronometro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblRepeticoes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtxtInformativo;
        private System.Windows.Forms.Button button1;
    }
}