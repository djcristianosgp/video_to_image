namespace export_image_to_video
{
    public partial class Form1 : Form
    {
        private VideoProcessor videoProcessor;
        private int currentFrameIndex = 0;
        private string namearquivo = string.Empty;

        public static int iContadorFrames = 0;
        public static int iTotalFrames = 0;
        public List<Bitmap> FramesMarcados { get; private set; }
        public List<Bitmap> Frames { get; private set; }
        public Form1()
        {
            InitializeComponent();
            videoProcessor = new VideoProcessor();
            CheckForIllegalCrossThreadCalls = false;
            FramesMarcados = new List<Bitmap>();
            // Inicializar o Timer
            timerMensagem = new System.Windows.Forms.Timer();
            timerMensagem.Interval = 10000; // 10 segundos
            timerMensagem.Tick += TimerMensagem_Tick;
            cbxQualidade.SelectedIndex = 0;
        }

        private async Task GetNomeArquivo()
        {
            FileInfo fileInfo = new FileInfo(txtVideo.Text);
            namearquivo = fileInfo.Name.Replace(fileInfo.Extension, "");
        }

        private async void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                pbProgresso.Visible = true;
                await GetNomeArquivo();

                var retorno = await videoProcessor.ExportFrames(txtVideo.Text, txtOut.Text, namearquivo, pbProgresso, cbxQualidade.SelectedIndex + 1, (int)nmFrameInicial.Value, (int)nmFrameFinal.Value);
                pbProgresso.Visible = false;
                MessageBox.Show(retorno);

                // Limpar variáveis e recursos
                retorno = null;
            }
            finally
            {
                // Forçar a coleta de lixo e liberação de memória
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private async void btnLoadVideo_Click(object sender, EventArgs e)
        {
            LimparFrames();
            pbProgresso.Visible = true;
            await GetNomeArquivo();
            Frames = await videoProcessor.ExportFramesToMemory(txtVideo.Text, pbProgresso, cbxQualidade.SelectedIndex + 1, (int)nmFrameInicial.Value, (int)nmFrameFinal.Value);
            pnControles.Enabled = Frames.Count > 0;
            btnExportarMarcados.Enabled = FramesMarcados.Count > 0;
            DisplayFrame(0);
            pbProgresso.Visible = false;
        }
        private void LimparFrames()
        {
            if (Frames != null)
            {
                foreach (var frame in Frames)
                {
                    frame.Dispose();
                }
                Frames.Clear();
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentFrameIndex > 0)
            {
                currentFrameIndex--;
                DisplayFrame(currentFrameIndex);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (currentFrameIndex < Frames.Count - 1)
            {
                currentFrameIndex++;
                DisplayFrame(currentFrameIndex);
            }
        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            if (piImagem.Image != null)
            {

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    saveFileDialog.Title = "Salvar Imagem";
                    saveFileDialog.FileName = $"{namearquivo}_frame_{currentFrameIndex:D6}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        piImagem.Image.Save(saveFileDialog.FileName);
                        MostrarMensagem("Imagem salva com sucesso!");
                    }
                }
            }
            else
            {
                MostrarMensagem("Nenhuma imagem para salvar.");
            }
        }

        private void DisplayFrame(int index)
        {
            piImagem.Image = Frames[index];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void btnSelecionarVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Defina o filtro para exibir apenas arquivos de vídeo suportados
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov;*.flv;*.wmv|All Files|*.*";
                openFileDialog.Title = "Selecione um vídeo";
                openFileDialog.Multiselect = false; // Permite selecionar apenas um arquivo

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Exiba o caminho do arquivo de vídeo na TextBox correspondente
                    txtVideo.Text = openFileDialog.FileName;
                    btnLoadVideo.Enabled = true;
                    btnExecutar.Enabled = !String.IsNullOrEmpty(txtOut.Text);
                    nmFrameFinal.Maximum = await videoProcessor.GetNumeroFrames(txtVideo.Text);
                    nmFrameFinal.Value = nmFrameFinal.Maximum;
                    lblNumeroFrames.Text = $"Vídeo com {nmFrameFinal.Value} Frames";
                }
            }
        }

        private void btnSelecionarPasta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecione a pasta onde as imagens serão exportadas";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Exiba o caminho da pasta selecionada na TextBox correspondente
                    txtOut.Text = folderBrowserDialog.SelectedPath;
                    btnExecutar.Enabled = !String.IsNullOrEmpty(txtVideo.Text);
                    btnExportarMarcados.Enabled = FramesMarcados.Count > 0 && !String.IsNullOrEmpty(txtVideo.Text);
                }
            }
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            FramesMarcados.Add(Frames[currentFrameIndex]);
            btnExportarMarcados.Enabled = FramesMarcados.Count > 0 && !String.IsNullOrEmpty(txtVideo.Text);
            MostrarMensagem("Imagem marcada e adicionada com sucesso!");
        }

        private void MostrarMensagem(string mensagem)
        {
            lblMensagem.Text = mensagem;
            lblMensagem.Visible = true;

            // Iniciar o Timer
            timerMensagem.Start();
        }

        private void TimerMensagem_Tick(object sender, EventArgs e)
        {
            // Esconder a Label e parar o Timer
            lblMensagem.Visible = false;
            timerMensagem.Stop();
        }

        private void btnExportarMarcados_Click(object sender, EventArgs e)
        {
            int iContadorExpor = 0;
            foreach (var item in FramesMarcados)
            {
                string caminhoArquivo = Path.Combine(txtOut.Text, $"{namearquivo}_frame_{iContadorExpor:D6}.png");
                item.Save(caminhoArquivo, System.Drawing.Imaging.ImageFormat.Png);
                iContadorExpor++;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    btnAnterior.PerformClick();
                    break;
                case Keys.Right:
                    btnProximo.PerformClick();
                    break;
                case Keys.E:
                    btnExportarMarcados.PerformClick();
                    break;
                case Keys.C:
                    btnCaptura.PerformClick();
                    break;
                case Keys.M:
                    btnMarcar.PerformClick();
                    break;
            }
        }

        private void nmFrameInicial_ValueChanged(object sender, EventArgs e)
        {
            nmFrameInicial.Maximum = nmFrameFinal.Value - 1;
            nmFrameFinal.Minimum = nmFrameInicial.Value;
        }

        private void nmFrameFinal_ValueChanged(object sender, EventArgs e)
        {
            nmFrameFinal.Minimum = nmFrameInicial.Value + 1;
            nmFrameInicial.Maximum = nmFrameFinal.Value;
        }
    }
}
