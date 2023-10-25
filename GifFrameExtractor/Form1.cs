using System.Drawing.Imaging;

namespace GifFrameExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectLocalFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "gif files (*.gif)|*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtLocalFilePath.Text = openFileDialog.FileName;
                    string gifPath = openFileDialog.FileName;
                    ConvertGifToJpg(gifPath);
                }
            }
        }

        private async void btnDownloadFile_Click(object sender, EventArgs e)
        {
            string url = txtFileUrl.Text;
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a valid URL.");
                return;
            }

            try
            {
                using var client = new HttpClient();
                using var response = await client.GetAsync(url);
                using var stream = await response.Content.ReadAsStreamAsync();
                var image = Image.FromStream(stream);
                ConvertGifToJpg(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while downloading the file: {ex.Message}");
            }
        }

        private void btnSelectOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFolderPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void ConvertGifToJpg(string gifPath)
        {
            try
            {
                using (Image gifImg = Image.FromFile(gifPath))
                {
                    ConvertGifToJpg(gifImg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while converting the file: {ex.Message}");
            }
        }

        private void ConvertGifToJpg(Image gifImg)
        {
            FrameDimension dimension = new FrameDimension(gifImg.FrameDimensionsList[0]);
            int frameCount = gifImg.GetFrameCount(dimension);
            string outputPath = string.IsNullOrEmpty(txtOutputFolderPath.Text) ? Path.Combine(Directory.GetCurrentDirectory(), "output") : txtOutputFolderPath.Text;
            Directory.CreateDirectory(outputPath);  // Create the output directory if it doesn't exist yet
            for (int i = 0; i < frameCount; i++)
            {
                gifImg.SelectActiveFrame(dimension, i);
                gifImg.Save($"{outputPath}/frame{i}.jpg", ImageFormat.Jpeg);
            }

            MessageBox.Show("Conversion successful!");
        }
    }
}