namespace export_image_to_video
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtVideo = new TextBox();
            btnExecutar = new Button();
            txtOut = new TextBox();
            label2 = new Label();
            btnLoadVideo = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            btnSelecionarPasta = new Button();
            cbxQualidade = new ComboBox();
            btnSelecionarVideo = new Button();
            groupBox2 = new GroupBox();
            piImagem = new PictureBox();
            pnControles = new Panel();
            btnExportarMarcados = new Button();
            btnProximo = new Button();
            btnMarcar = new Button();
            btnCaptura = new Button();
            btnAnterior = new Button();
            statusStrip1 = new StatusStrip();
            pbProgresso = new ToolStripProgressBar();
            lblMensagem = new ToolStripStatusLabel();
            lblNumeroFrames = new ToolStripStatusLabel();
            ttInfo = new ToolTip(components);
            timerMensagem = new System.Windows.Forms.Timer(components);
            nmFrameInicial = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            nmFrameFinal = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piImagem).BeginInit();
            pnControles.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFrameInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFrameFinal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Vídeo";
            // 
            // txtVideo
            // 
            txtVideo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVideo.BackColor = Color.White;
            txtVideo.Location = new Point(13, 37);
            txtVideo.Name = "txtVideo";
            txtVideo.PlaceholderText = "Selecione o video no botão ao lado";
            txtVideo.ReadOnly = true;
            txtVideo.Size = new Size(613, 23);
            txtVideo.TabIndex = 1;
            // 
            // btnExecutar
            // 
            btnExecutar.Dock = DockStyle.Right;
            btnExecutar.Enabled = false;
            btnExecutar.FlatStyle = FlatStyle.Flat;
            btnExecutar.Image = (Image)resources.GetObject("btnExecutar.Image");
            btnExecutar.Location = new Point(747, 19);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(99, 135);
            btnExecutar.TabIndex = 2;
            btnExecutar.Text = "Executar";
            btnExecutar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // txtOut
            // 
            txtOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOut.BackColor = Color.White;
            txtOut.Location = new Point(13, 81);
            txtOut.Name = "txtOut";
            txtOut.PlaceholderText = "Selecione a pasta para exportação no botão ao lado  ao lado";
            txtOut.ReadOnly = true;
            txtOut.Size = new Size(613, 23);
            txtOut.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 63);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "Out";
            // 
            // btnLoadVideo
            // 
            btnLoadVideo.Dock = DockStyle.Right;
            btnLoadVideo.Enabled = false;
            btnLoadVideo.FlatStyle = FlatStyle.Flat;
            btnLoadVideo.Image = (Image)resources.GetObject("btnLoadVideo.Image");
            btnLoadVideo.Location = new Point(648, 19);
            btnLoadVideo.Name = "btnLoadVideo";
            btnLoadVideo.Size = new Size(99, 135);
            btnLoadVideo.TabIndex = 5;
            btnLoadVideo.Text = "Load";
            btnLoadVideo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoadVideo.UseVisualStyleBackColor = true;
            btnLoadVideo.Click += btnLoadVideo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nmFrameFinal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nmFrameInicial);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSelecionarPasta);
            groupBox1.Controls.Add(cbxQualidade);
            groupBox1.Controls.Add(btnSelecionarVideo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLoadVideo);
            groupBox1.Controls.Add(txtVideo);
            groupBox1.Controls.Add(txtOut);
            groupBox1.Controls.Add(btnExecutar);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(849, 157);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Video";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 113);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 12;
            label3.Text = "Qualidade:";
            // 
            // btnSelecionarPasta
            // 
            btnSelecionarPasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelecionarPasta.FlatStyle = FlatStyle.Flat;
            btnSelecionarPasta.Location = new Point(602, 81);
            btnSelecionarPasta.Name = "btnSelecionarPasta";
            btnSelecionarPasta.Size = new Size(24, 23);
            btnSelecionarPasta.TabIndex = 7;
            btnSelecionarPasta.Text = "...";
            btnSelecionarPasta.UseVisualStyleBackColor = true;
            btnSelecionarPasta.Click += btnSelecionarPasta_Click;
            // 
            // cbxQualidade
            // 
            cbxQualidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxQualidade.FormattingEnabled = true;
            cbxQualidade.Items.AddRange(new object[] { "ORIGINAL", "/2", "/3", "/4", "/5", "/6", "/7", "/8" });
            cbxQualidade.Location = new Point(83, 110);
            cbxQualidade.Name = "cbxQualidade";
            cbxQualidade.Size = new Size(121, 23);
            cbxQualidade.TabIndex = 11;
            // 
            // btnSelecionarVideo
            // 
            btnSelecionarVideo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelecionarVideo.FlatStyle = FlatStyle.Flat;
            btnSelecionarVideo.Location = new Point(602, 37);
            btnSelecionarVideo.Name = "btnSelecionarVideo";
            btnSelecionarVideo.Size = new Size(24, 23);
            btnSelecionarVideo.TabIndex = 6;
            btnSelecionarVideo.Text = "...";
            btnSelecionarVideo.UseVisualStyleBackColor = true;
            btnSelecionarVideo.Click += btnSelecionarVideo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(piImagem);
            groupBox2.Controls.Add(pnControles);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(0, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(849, 371);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visualização";
            groupBox2.UseCompatibleTextRendering = true;
            // 
            // piImagem
            // 
            piImagem.Dock = DockStyle.Fill;
            piImagem.Location = new Point(3, 19);
            piImagem.Name = "piImagem";
            piImagem.Size = new Size(843, 277);
            piImagem.SizeMode = PictureBoxSizeMode.Zoom;
            piImagem.TabIndex = 1;
            piImagem.TabStop = false;
            // 
            // pnControles
            // 
            pnControles.Controls.Add(btnExportarMarcados);
            pnControles.Controls.Add(btnProximo);
            pnControles.Controls.Add(btnMarcar);
            pnControles.Controls.Add(btnCaptura);
            pnControles.Controls.Add(btnAnterior);
            pnControles.Dock = DockStyle.Bottom;
            pnControles.Enabled = false;
            pnControles.Location = new Point(3, 296);
            pnControles.Name = "pnControles";
            pnControles.Size = new Size(843, 72);
            pnControles.TabIndex = 0;
            // 
            // btnExportarMarcados
            // 
            btnExportarMarcados.Dock = DockStyle.Right;
            btnExportarMarcados.FlatStyle = FlatStyle.Flat;
            btnExportarMarcados.Image = (Image)resources.GetObject("btnExportarMarcados.Image");
            btnExportarMarcados.Location = new Point(744, 0);
            btnExportarMarcados.Name = "btnExportarMarcados";
            btnExportarMarcados.Size = new Size(99, 72);
            btnExportarMarcados.TabIndex = 10;
            btnExportarMarcados.Text = "(E)";
            btnExportarMarcados.TextImageRelation = TextImageRelation.ImageAboveText;
            ttInfo.SetToolTip(btnExportarMarcados, "Exportar marcado ");
            btnExportarMarcados.UseVisualStyleBackColor = true;
            btnExportarMarcados.Click += btnExportarMarcados_Click;
            // 
            // btnProximo
            // 
            btnProximo.Dock = DockStyle.Left;
            btnProximo.FlatStyle = FlatStyle.Flat;
            btnProximo.Image = (Image)resources.GetObject("btnProximo.Image");
            btnProximo.Location = new Point(297, 0);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(99, 72);
            btnProximo.TabIndex = 8;
            btnProximo.Text = "(>)";
            btnProximo.TextImageRelation = TextImageRelation.ImageAboveText;
            ttInfo.SetToolTip(btnProximo, "Próxima Imagem");
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnMarcar
            // 
            btnMarcar.Dock = DockStyle.Left;
            btnMarcar.FlatStyle = FlatStyle.Flat;
            btnMarcar.Image = (Image)resources.GetObject("btnMarcar.Image");
            btnMarcar.Location = new Point(198, 0);
            btnMarcar.Name = "btnMarcar";
            btnMarcar.Size = new Size(99, 72);
            btnMarcar.TabIndex = 9;
            btnMarcar.Text = "(M)";
            btnMarcar.TextImageRelation = TextImageRelation.ImageAboveText;
            ttInfo.SetToolTip(btnMarcar, "Marcar Imagem");
            btnMarcar.UseVisualStyleBackColor = true;
            btnMarcar.Click += btnMarcar_Click;
            // 
            // btnCaptura
            // 
            btnCaptura.Dock = DockStyle.Left;
            btnCaptura.FlatStyle = FlatStyle.Flat;
            btnCaptura.Image = (Image)resources.GetObject("btnCaptura.Image");
            btnCaptura.Location = new Point(99, 0);
            btnCaptura.Name = "btnCaptura";
            btnCaptura.Size = new Size(99, 72);
            btnCaptura.TabIndex = 7;
            btnCaptura.Text = "(C)";
            btnCaptura.TextImageRelation = TextImageRelation.ImageAboveText;
            ttInfo.SetToolTip(btnCaptura, "Salvar Imagem");
            btnCaptura.UseVisualStyleBackColor = true;
            btnCaptura.Click += btnCaptura_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Dock = DockStyle.Left;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Image = (Image)resources.GetObject("btnAnterior.Image");
            btnAnterior.Location = new Point(0, 0);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(99, 72);
            btnAnterior.TabIndex = 6;
            btnAnterior.Text = "(<)";
            btnAnterior.TextImageRelation = TextImageRelation.ImageAboveText;
            ttInfo.SetToolTip(btnAnterior, "Imagem Anterior");
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { pbProgresso, lblMensagem, lblNumeroFrames });
            statusStrip1.Location = new Point(0, 528);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(849, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // pbProgresso
            // 
            pbProgresso.Name = "pbProgresso";
            pbProgresso.Size = new Size(100, 16);
            pbProgresso.Visible = false;
            // 
            // lblMensagem
            // 
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(16, 17);
            lblMensagem.Text = "...";
            // 
            // lblNumeroFrames
            // 
            lblNumeroFrames.Name = "lblNumeroFrames";
            lblNumeroFrames.Size = new Size(16, 17);
            lblNumeroFrames.Text = "...";
            // 
            // ttInfo
            // 
            ttInfo.IsBalloon = true;
            // 
            // nmFrameInicial
            // 
            nmFrameInicial.Location = new Point(293, 110);
            nmFrameInicial.Name = "nmFrameInicial";
            nmFrameInicial.Size = new Size(72, 23);
            nmFrameInicial.TabIndex = 13;
            nmFrameInicial.TextAlign = HorizontalAlignment.Center;
            nmFrameInicial.ValueChanged += nmFrameInicial_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 113);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 14;
            label4.Text = "Frame Inicial:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 113);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 16;
            label5.Text = "Frame Final:";
            // 
            // nmFrameFinal
            // 
            nmFrameFinal.Location = new Point(454, 110);
            nmFrameFinal.Name = "nmFrameFinal";
            nmFrameFinal.Size = new Size(72, 23);
            nmFrameFinal.TabIndex = 15;
            nmFrameFinal.TextAlign = HorizontalAlignment.Center;
            nmFrameFinal.ValueChanged += nmFrameFinal_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 61, 61);
            ClientSize = new Size(849, 550);
            Controls.Add(groupBox2);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Export Video to Imagem";
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)piImagem).EndInit();
            pnControles.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFrameInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFrameFinal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVideo;
        private Button btnExecutar;
        private TextBox txtOut;
        private Label label2;
        private Button btnLoadVideo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox piImagem;
        private Panel pnControles;
        private Button btnProximo;
        private Button btnCaptura;
        private Button btnAnterior;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar pbProgresso;
        private Button btnSelecionarPasta;
        private Button btnSelecionarVideo;
        private ToolTip ttInfo;
        private Button btnMarcar;
        private ToolStripStatusLabel lblMensagem;
        private System.Windows.Forms.Timer timerMensagem;
        private Button btnExportarMarcados;
        private Label label3;
        private ComboBox cbxQualidade;
        private ToolStripStatusLabel lblNumeroFrames;
        private NumericUpDown nmFrameInicial;
        private Label label4;
        private Label label5;
        private NumericUpDown nmFrameFinal;
    }
}
