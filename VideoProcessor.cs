using OpenCvSharp;

namespace export_image_to_video
{
    public class VideoProcessor
    {
        public int iContadorFrames = 0;
        public int iTotalFrames = 0;


        public async Task<List<Bitmap>> ExportFramesToMemory(string videoFilePath, ToolStripProgressBar progressBar, int qualidade, int frameInicial, int frameFinal)
        {
            iContadorFrames = 0;
            iTotalFrames = 0;

            using (var capture = new VideoCapture(videoFilePath, VideoCaptureAPIs.FFMPEG))
            {
                List<Bitmap> Frames = new List<Bitmap>();
                if (!capture.IsOpened())
                    throw new ApplicationException("Não foi possível abrir o vídeo.");

                int frameCount = (int)capture.FrameCount;
                progressBar.Maximum = frameCount;

                for (int i = frameInicial; i < frameFinal; i++)
                {
                    iContadorFrames++;
                    progressBar.Value = iContadorFrames;
                    using (var frame = new Mat())
                    {
                        capture.Read(frame);
                        if (frame.Empty()) break;

                        // Redimensionando o frame manualmente
                        int newWidth = frame.Width / qualidade;
                        int newHeight = frame.Height / qualidade;
                        var resizedFrame = new Mat();
                        Cv2.Resize(frame, resizedFrame, new OpenCvSharp.Size(newWidth, newHeight));

                        // Convertendo para Bitmap e adicionando à lista
                        Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(resizedFrame);
                        Frames.Add(bitmap);
                    }
                }
                return Frames;
            }
        }

        public async Task<int> GetNumeroFrames(string videoFilePath)
        {

            using (var capture = new VideoCapture(videoFilePath, VideoCaptureAPIs.FFMPEG))
            {
                if (!capture.IsOpened())
                    throw new ApplicationException("Não foi possível abrir o vídeo.");

                int frameCount = (int)capture.FrameCount;

                return frameCount;

            }
        }



        public async Task<string> ExportFrames(string videoFilePath, string outputDirectory, string nameArquivo, ToolStripProgressBar progressBar, int qualidade, int frameInicial, int frameFinal)
        {
            try
            {
                iContadorFrames = 0;
                iTotalFrames = 0;

                if (!File.Exists(videoFilePath))
                    return string.Concat("O arquivo de vídeo não foi encontrado.", videoFilePath);

                if (!Directory.Exists(outputDirectory))
                    Directory.CreateDirectory(outputDirectory);

                using (var capture = new VideoCapture(videoFilePath, VideoCaptureAPIs.FFMPEG))
                {
                    if (!capture.IsOpened())
                        return "Não foi possível abrir o vídeo.";

                    int frameCount = (int)capture.FrameCount;
                    int originalWidth = capture.FrameWidth;
                    int originalHeight = capture.FrameHeight;
                    iTotalFrames = frameCount;
                    progressBar.Maximum = frameCount;
                    progressBar.Value = 0;

                    for (int i = frameInicial; i < frameFinal; i++)
                    {
                        iContadorFrames++;
                        progressBar.Value = iContadorFrames;

                        using (var frame = new Mat())
                        {
                            capture.Read(frame);
                            if (frame.Empty()) break;

                            // Redimensionando o frame manualmente
                            int newWidth = originalWidth / qualidade;
                            int newHeight = originalHeight / qualidade;
                            var resizedFrame = new Mat();
                            Cv2.Resize(frame, resizedFrame, new OpenCvSharp.Size(newWidth, newHeight));

                            // Salvando o frame redimensionado
                            string framePath = Path.Combine(outputDirectory, $"{nameArquivo}_frame_{i:D6}.png");
                            Cv2.ImWrite(framePath, resizedFrame);
                        }
                    }

                    return $"{frameCount} imagens foram geradas com resolução de {originalWidth / qualidade}x{originalHeight / qualidade} pixels.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
