using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    //https://blogs.msdn.microsoft.com/dawate/2009/06/23/intro-to-audio-programming-part-2-demystifying-the-wav-format/
    //https://cs.wikipedia.org/wiki/Steganografie
    //https://stackoverflow.com/questions/13039846/what-do-the-bytes-in-a-wav-file-represent
    public partial class ExperimentalForm : Form
    {
        Bitmap pictureDefault;
        Bitmap pictureCodedDecoded;
        Bitmap pictureToCode;
        SoundPlayer wav = new SoundPlayer();
        string buttonSave;
        string buttonLoad;
        Bitmap pictureToSave;
        string wavPath;
        string wavPathToSave;
        string input;

        public ExperimentalForm()
        {
            InitializeComponent();
        }

        private void ButtonOpenDefault_Click(object sender, EventArgs e)
        {
            buttonLoad = buttonOpenDefault.Name;
            LoadPicture();
        }

        private void ButtonOpenCodedDecoded_Click(object sender, EventArgs e)
        {
            buttonLoad = buttonOpenCodedDecoded.Name;
            LoadPicture();
        }

        private void ButtonOpenToCode_Click(object sender, EventArgs e)
        {
            buttonLoad = buttonOpenToCode.Name;
            LoadPicture();
        }

        private void LoadPicture()
        {
            OpenFileDialog openImage = new OpenFileDialog();
            string path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

            openImage.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|JPG |*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|BMP|*.bmp|GIF|*.gif";
            openImage.Title = "Please select an image file.";
            openImage.FilterIndex = 1;
            openImage.CheckFileExists = true;
            openImage.CheckPathExists = true;
            openImage.InitialDirectory = path;
            
            try
            {
                if (openImage.ShowDialog() == DialogResult.OK)
                {
                    if (buttonLoad == buttonOpenDefault.Name)
                    {
                        pictureDefault = new Bitmap(openImage.FileName);
                        pictureBoxDefault.Image = pictureDefault;
                    }
                    else if (buttonLoad == buttonOpenCodedDecoded.Name)
                    {
                        pictureCodedDecoded = new Bitmap(openImage.FileName);
                        pictureBoxCodedDecoded.Image = pictureCodedDecoded;
                    }
                    else if (buttonLoad == buttonOpenToCode.Name)
                    {
                        pictureToCode = new Bitmap(openImage.FileName);
                        pictureBoxToCode.Image = pictureToCode;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect file chosen. Not an image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDecodePictureFromPicture_Click(object sender, EventArgs e)
        {
            if(pictureCodedDecoded == null)
            {
                MessageBox.Show("No image to work with!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Color pixel;
                string blue;
                string red;
                string green;
                Bitmap tmp = new Bitmap(pictureCodedDecoded);

                for (int y = 0; y <= tmp.Height - 1; y++)
                {
                    for (int x = 0; x <= tmp.Width - 1; x++)
                    {
                        pixel = tmp.GetPixel(x, y);
                        blue = Conversions.ConverDecimalToBinaryString(pixel.B);
                        red = Conversions.ConverDecimalToBinaryString(pixel.R);
                        green = Conversions.ConverDecimalToBinaryString(pixel.G);
                        blue = $"000000{blue[6]}{blue[7]}";
                        red = $"000000{red[6]}{red[7]}";
                        green = $"000000{green[6]}{green[7]}";
                        pictureCodedDecoded.SetPixel(x, y, Color.FromArgb(Conversions.ConvertBinaryStringToDecimal(red), Conversions.ConvertBinaryStringToDecimal(green), Conversions.ConvertBinaryStringToDecimal(blue)));
                    }
                }
                pictureBoxCodedDecoded.Image = pictureCodedDecoded;
            }
        }

        private void ButtonSaveDefaultImage_Click(object sender, EventArgs e)
        {
            buttonSave = buttonSaveDefaultImage.Name;
            SwitchSavePicture();
        }

        private void ButtonSaveCodedDecodedImage_Click(object sender, EventArgs e)
        {
            buttonSave = buttonSaveCodedDecodedImage.Name;
            SwitchSavePicture();
        }

        private void ButtonSaveImageToBeCoded_Click(object sender, EventArgs e)
        {
            buttonSave = buttonSaveImageToBeCoded.Name;
            SwitchSavePicture();
        }

        private void SwitchSavePicture()
        {
            if (buttonSave != null)
            {
                switch (buttonSave)
                {
                    case "buttonSaveDefaultImage":
                        if(pictureDefault != null)
                        {
                            pictureToSave = pictureDefault;
                            SavePicture();
                        }
                        else MessageBox.Show("No picture to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "buttonSaveCodedDecodedImage":
                        if (pictureCodedDecoded != null)
                        {
                            pictureToSave = pictureCodedDecoded;
                            SavePicture();
                        }
                        else MessageBox.Show("No picture to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "buttonSaveImageToBeCoded":
                        if (pictureToCode != null)
                        {
                            pictureToSave = pictureToCode;
                            SavePicture();
                        }
                        else MessageBox.Show("No picture to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void SavePicture()
        {
            SaveFileDialog saveImage = new SaveFileDialog();
            string path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

            saveImage.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|BMP|*.bmp|GIF|*.gif|All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
            saveImage.Title = "Please select a directory.";
            saveImage.FilterIndex = 6;
            saveImage.CheckPathExists = true;
            saveImage.InitialDirectory = path;

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                pictureToSave.Save(saveImage.FileName);
            }
        }

        private void ButtonSetGammaOfDecodedPicture_Click(object sender, EventArgs e)
        {
            if(pictureCodedDecoded != null)
            {
                pictureBoxCodedDecoded.Image = SetGamma(pictureCodedDecoded, 7, 7, 7);
            }
            else MessageBox.Show("No decoded picture loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //courtesy of https://www.codeproject.com/Articles/33838/Image-Processing-using-C
        public Bitmap SetGamma(Bitmap bitmap, double red, double green, double blue)
        {
            Bitmap output = bitmap;

            Color pixel;
            byte[] redGamma = CreateGammaArray(red);
            byte[] greenGamma = CreateGammaArray(green);
            byte[] blueGamma = CreateGammaArray(blue);

            for (int y = 0; y <= output.Width - 1; y++)
            {
                for (int x = 0; x <= output.Height - 1; x++)
                {
                    pixel = output.GetPixel(y, x);
                    output.SetPixel(y, x, Color.FromArgb(redGamma[pixel.R], greenGamma[pixel.G], blueGamma[pixel.B]));
                }
            }
            return output;
        }
        private byte[] CreateGammaArray(double color)
        {
            byte[] gammaArray = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                gammaArray[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, 1.0 / color)) + 0.5));
            }

            return gammaArray;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void ButtonCodePictureIntoPicture_Click(object sender, EventArgs e)
        {
            if(pictureToCode == null || pictureDefault == null)
            {
                MessageBox.Show("Picture(s) missing! Load picture(s) to left/right box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(pictureToCode.Width != pictureDefault.Width || pictureToCode.Height != pictureDefault.Height)
                {
                    MessageBox.Show("Please, select pictures with the same dimensions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureCodedDecoded = new Bitmap(pictureDefault.Width, pictureDefault.Height);
                    Color pixel;
                    Color pixel2;
                    string blue;
                    string red;
                    string green;
                    string blue2;
                    string red2;
                    string green2;

                    for (int y = 0; y <= pictureToCode.Height - 1; y++)
                    {
                        for (int x = 0; x <= pictureToCode.Width - 1; x++)
                        {
                            pixel = pictureToCode.GetPixel(x, y);
                            pixel2 = pictureDefault.GetPixel(x, y);
                            blue = Conversions.ConverDecimalToBinaryString(pixel.B);
                            red = Conversions.ConverDecimalToBinaryString(pixel.R);
                            green = Conversions.ConverDecimalToBinaryString(pixel.G);
                            blue2 = Conversions.ConverDecimalToBinaryString(pixel2.B);
                            red2 = Conversions.ConverDecimalToBinaryString(pixel2.R);
                            green2 = Conversions.ConverDecimalToBinaryString(pixel2.G);
                            blue = $"{blue2[0]}{blue2[1]}{blue2[2]}{blue2[3]}{blue2[4]}{blue2[5]}{blue[0]}{blue[1]}";
                            red = $"{red2[0]}{red2[1]}{red2[2]}{red2[3]}{red2[4]}{red2[5]}{red[0]}{red[1]}";
                            green = $"{green2[0]}{green2[1]}{green2[2]}{green2[3]}{green2[4]}{green2[5]}{green[0]}{green[1]}";
                            pictureCodedDecoded.SetPixel(x, y, Color.FromArgb(Conversions.ConvertBinaryStringToDecimal(red), Conversions.ConvertBinaryStringToDecimal(green), Conversions.ConvertBinaryStringToDecimal(blue)));
                        }
                    }
                    pictureBoxCodedDecoded.Image = pictureCodedDecoded;
                }
            }
        }

        private void LoadWav()
        {
            OpenFileDialog openWav = new OpenFileDialog();
            string path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

            openWav.Filter = "WAV|*.wav";
            openWav.Title = "Please select a wav file.";
            openWav.FilterIndex = 1;
            openWav.CheckFileExists = true;
            openWav.CheckPathExists = true;
            openWav.InitialDirectory = path;

            try
            {
                if (openWav.ShowDialog() == DialogResult.OK)
                {
                    wavPath = openWav.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Incorrect file chosen. Not a .wav!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveWav()
        {
            SaveFileDialog saveWav = new SaveFileDialog();
            string path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

            saveWav.Filter = "WAV|*.wav";
            saveWav.Title = "Please select a directory.";
            saveWav.FilterIndex = 1;
            saveWav.CheckPathExists = true;
            saveWav.InitialDirectory = path;

            if (saveWav.ShowDialog() == DialogResult.OK)
            {
                wavPathToSave = saveWav.FileName;
            }
        }

        private void ButtonCodeTextToWav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select .wav file.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWav();
            if(wavPath != null)
            {
                if(richTextBoxInputOutput.Text != "")
                {
                    wav.Stop();
                    wav.SoundLocation = wavPath;
                    wav.Play();

                    byte[] arrayFile = ReadFile(wavPath);
                    input = StaticMethods.ReturnParsedInput(richTextBoxInputOutput.Text);
                    input = StaticMethods.RemoveZero(input);
                    byte[] arrayText = ReadText(input);
                    byte zero = 48;
                    int tmpLoopHelp = 0;
                    int tmpZeroHelp = 0;

                    for (int i = arrayFile.Length - 1; i > arrayFile.Length - arrayText.Length - 1; i--)
                    {
                        arrayFile[i] = arrayText[tmpLoopHelp];
                        tmpLoopHelp++;
                        tmpZeroHelp = i;
                    }
                    arrayFile[tmpZeroHelp - 1] = zero;

                    MessageBox.Show("Select directory to save your coded file.", "Select directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveWav();

                    try
                    {
                        using (FileStream fileStream = File.Create(wavPathToSave))
                        {
                            fileStream.Write(arrayFile, 0, arrayFile.Length);
                            fileStream.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Failed to write to the file. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("No text to code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No .wav file chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private byte[] ReadFile(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            int length = Convert.ToInt32(fileStream.Length);
            byte[] data = new byte[length];
            fileStream.Read(data, 0, length);
            fileStream.Close();
            return data;
        }

        private byte[] ReadPicture(Bitmap picture)
        {
            byte[] output = new byte[(picture.Width * picture.Height) * 3 + 2];
            Color pixel;
            int tmpHelp = 2;
            int Y = picture.Width;
            int X = picture.Height;

            if(picture == null)
            {
                MessageBox.Show("No loaded picture. Please open one in default picture box (left side).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                output[0] = Convert.ToByte(Y);
                output[1] = Convert.ToByte(X);

                for (int y = 0; y <= picture.Height - 1; y++)
                {
                    for (int x = 0; x <= picture.Width - 1; x++)
                    {
                        pixel = picture.GetPixel(x, y);
                        output[tmpHelp] = pixel.R;
                        tmpHelp++;
                        output[tmpHelp] = pixel.G;
                        tmpHelp++;
                        output[tmpHelp] = pixel.B;
                        tmpHelp++;
                    }
                }
            }
            return output;
        }
        
        private Bitmap WriteBitmap(byte[] input)
        {
            Bitmap picture = new Bitmap(Convert.ToInt32(input[input.Length - 1]), Convert.ToInt32(input[input.Length - 2]));
            int tmpHelp = input.Length - 3;

            for (int y = 0; y <= picture.Height - 1; y++)
            {
                for (int x = 0; x <= picture.Width - 1; x++)
                {
                    picture.SetPixel(x, y, Color.FromArgb(input[tmpHelp], input[tmpHelp - 1], input[tmpHelp - 2]));
                    tmpHelp -= 3;
                }
            }

            return picture;
        }

        private byte[] ReadText(string input)
        {
            return Encoding.ASCII.GetBytes(input);
        }

        private string WriteText(byte[] input)
        {
            StringBuilder output = new StringBuilder();

            for (int i = input.Length - 1; i > 0; i--)
            {
                if (input[i] == 48)
                {
                    break;
                }
                else
                {
                    output.Append(Convert.ToChar(input[i]));
                }
            }

            return output.ToString();
        }

        private void ButtonDecodeTextFromWav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select .wav file.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWav();
            if (wavPath != null)
            {
                wav.Stop();
                wav.SoundLocation = wavPath;
                wav.Play();

                byte[] arrayFile = ReadFile(wavPath);

                richTextBoxInputOutput.Text = WriteText(arrayFile);
            }
            else MessageBox.Show("No .wav file chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonCodePictureToWav_Click(object sender, EventArgs e)
        {
            if (pictureCodedDecoded != null)
            {
                MessageBox.Show("Select .wav file.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWav();

                if (wavPath != null)
                {
                    wav.Stop();
                    wav.SoundLocation = wavPath;
                    wav.Play();

                    byte[] arrayFile = ReadFile(wavPath);
                    byte[] arrayPicture = ReadPicture(pictureCodedDecoded);
                    int tmpLoopHelp = 0;

                    for (int i = arrayFile.Length - 1; i > arrayFile.Length - arrayPicture.Length - 1; i--)
                    {
                        arrayFile[i] = arrayPicture[tmpLoopHelp];
                        tmpLoopHelp++;
                    }

                    MessageBox.Show("Select directory to save your coded file.", "Select directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveWav();

                    try
                    {
                        using (FileStream fileStream = File.Create(wavPathToSave))
                        {
                            fileStream.Write(arrayFile, 0, arrayFile.Length);
                            fileStream.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Failed to write to the file. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("No .wav file chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No picture to code. Load a picture in the middle box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDecodePictureFromWav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select .wav file.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWav();
            if (wavPath != null)
            {
                wav.Stop();
                wav.SoundLocation = wavPath;
                wav.Play();

                byte[] arrayFile = ReadFile(wavPath);

                pictureBoxCodedDecoded.Image = WriteBitmap(arrayFile);
            }
            else MessageBox.Show("No .wav file chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonLeft1_Click(object sender, EventArgs e)
        {
            if (pictureBoxCodedDecoded.Image == null)
            {
                MessageBox.Show("No image to transfer. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBoxDefault.Image = pictureBoxCodedDecoded.Image;
                pictureDefault = pictureCodedDecoded;
            }
        }

        private void ButtonRight1_Click(object sender, EventArgs e)
        {
            if (pictureBoxDefault.Image == null)
            {
                MessageBox.Show("No image to transfer. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBoxCodedDecoded.Image = pictureBoxDefault.Image;
                pictureCodedDecoded = pictureDefault;
            }
        }

        private void ButtonLeft2_Click(object sender, EventArgs e)
        {
            if (pictureBoxToCode.Image == null)
            {
                MessageBox.Show("No image to transfer. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBoxCodedDecoded.Image = pictureBoxToCode.Image;
                pictureCodedDecoded = pictureToCode;
            }
        }

        private void ButtonRight2_Click(object sender, EventArgs e)
        {
            if (pictureBoxCodedDecoded.Image == null)
            {
                MessageBox.Show("No image to transfer. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pictureBoxToCode.Image = pictureBoxCodedDecoded.Image;
                pictureToCode = pictureCodedDecoded;
            }
        }

        private void ButtonCodeTextToWavBit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select .wav file.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWav();
            if (wavPath != null)
            {
                if (richTextBoxInputOutput.Text != "")
                {
                    wav.Stop();
                    wav.SoundLocation = wavPath;
                    wav.Play();

                    byte[] arrayFile = ReadFile(wavPath);
                    input = StaticMethods.ReturnParsedInput(richTextBoxInputOutput.Text);
                    input = StaticMethods.RemoveZero(input);
                    byte[] arrayText = ReadText(input);

                    string binaryStringText = string.Join("", arrayText.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
                    binaryStringText += "00110000";
                    string binaryStringFile = string.Join("", arrayFile.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));

                    int tmpLoopHelp = binaryStringFile.Length - 1;
                    StringBuilder helpStringBuilder = new StringBuilder();

                    for (int i = 0; i < binaryStringText.Length; i++)
                    {
                        helpStringBuilder.Append(binaryStringText[i]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 1]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 2]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 3]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 4]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 5]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 6]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 7]);
                        tmpLoopHelp -= 8;
                    }

                    string helpString = StaticMethods.ReverseString(helpStringBuilder.ToString());
                    string finalString = binaryStringFile.Substring(0, binaryStringFile.Length - helpStringBuilder.Length) + helpString;                  

                    int numberOfBytes = finalString.Length / 8;
                    byte[] finalArray = new byte[numberOfBytes];
                    for (int i = 0; i < numberOfBytes; ++i)
                    {
                        finalArray[i] = Convert.ToByte(finalString.Substring(i * 8, 8), 2);
                    }

                    MessageBox.Show("Select directory to save your coded file.", "Select directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveWav();

                    try
                    {
                        using (FileStream fileStream = File.Create(wavPathToSave))
                        {
                            fileStream.Write(finalArray, 0, finalArray.Length);
                            fileStream.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Failed to write to the file. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("No text to code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No .wav file chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDecodeTextFromWavBit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select .wav file.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWav();
            if (wavPath != null)
            {
                wav.Stop();
                wav.SoundLocation = wavPath;
                wav.Play();

                byte[] arrayFile = ReadFile(wavPath);
                string binaryString = string.Join("", arrayFile.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
                StringBuilder helpStringBuilder = new StringBuilder();

                for (int i = binaryString.Length - 1; i >= 0; i -= 8)
                {
                    helpStringBuilder.Append(binaryString[i]);
                }

                string helpString = helpStringBuilder.ToString();

                int numberOfBytes = helpString.Length / 8;
                byte[] finalArray = new byte[numberOfBytes];
                for (int i = 0; i < numberOfBytes; ++i)
                {
                    finalArray[i] = Convert.ToByte(helpString.Substring(i * 8, 8), 2);
                }

                richTextBoxInputOutput.Text = WriteTextBit(finalArray);
            }
            else MessageBox.Show("No .wav file chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonCodePictureToWavBit_Click(object sender, EventArgs e)
        {
            if (pictureCodedDecoded != null)
            {
                MessageBox.Show("Select .wav file.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWav();

                if (wavPath != null)
                {
                    wav.Stop();
                    wav.SoundLocation = wavPath;
                    wav.Play();

                    byte[] arrayFile = ReadFile(wavPath);
                    byte[] arrayPicture = ReadPicture(pictureCodedDecoded);

                    string binaryStringPicture = string.Join("", arrayPicture.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
                    string binaryStringFile = string.Join("", arrayFile.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));

                    int tmpLoopHelp = binaryStringFile.Length - 1;
                    StringBuilder helpStringBuilder = new StringBuilder();

                    for (int i = 0; i < binaryStringPicture.Length; i++)
                    {
                        helpStringBuilder.Append(binaryStringPicture[i]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 1]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 2]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 3]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 4]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 5]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 6]);
                        helpStringBuilder.Append(binaryStringFile[tmpLoopHelp - 7]);
                        tmpLoopHelp -= 8;
                    }

                    string helpString = StaticMethods.ReverseString(helpStringBuilder.ToString());
                    string finalString = binaryStringFile.Substring(0, binaryStringFile.Length - helpStringBuilder.Length) + helpString;

                    int numberOfBytes = finalString.Length / 8;
                    byte[] finalArray = new byte[numberOfBytes];
                    for (int i = 0; i < numberOfBytes; ++i)
                    {
                        finalArray[i] = Convert.ToByte(finalString.Substring(i * 8, 8), 2);
                    }

                    MessageBox.Show("Select directory to save your coded file.", "Select directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveWav();

                    try
                    {
                        using (FileStream fileStream = File.Create(wavPathToSave))
                        {
                            fileStream.Write(finalArray, 0, finalArray.Length);
                            fileStream.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Failed to write to the file. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("No .wav file chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("No picture to code. Load a picture in the middle box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonDecodePictureFromWavBit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select .wav file.", "Select file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWav();
            if (wavPath != null)
            {
                wav.Stop();
                wav.SoundLocation = wavPath;
                wav.Play();

                byte[] arrayFile = ReadFile(wavPath);

                string binaryString = string.Join("", arrayFile.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
                StringBuilder helpStringBuilder = new StringBuilder();

                for (int i = binaryString.Length - 1; i >= 0; i -= 8)
                {
                    helpStringBuilder.Append(binaryString[i]);
                }

                string helpString = helpStringBuilder.ToString();

                int numberOfBytes = helpString.Length / 8;
                byte[] finalArray = new byte[numberOfBytes];
                for (int i = 0; i < numberOfBytes; ++i)
                {
                    finalArray[i] = Convert.ToByte(helpString.Substring(i * 8, 8), 2);
                }

                pictureBoxCodedDecoded.Image = WriteBitmapBit(finalArray);
            }
            else MessageBox.Show("No .wav file chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string WriteTextBit(byte[] input)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 48)
                {
                    break;
                }
                else
                {
                    output.Append(Convert.ToChar(input[i]));
                }
            }

            return output.ToString();
        }

        private Bitmap WriteBitmapBit(byte[] input)
        {
            Bitmap picture = new Bitmap(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));
            int tmpHelp = 2;

            for (int y = 0; y <= picture.Height - 1; y++)
            {
                for (int x = 0; x <= picture.Width - 1; x++)
                {
                    picture.SetPixel(x, y, Color.FromArgb(input[tmpHelp], input[tmpHelp + 1], input[tmpHelp + 2]));
                    tmpHelp += 3;
                }
            }

            return picture;
        }
    }
}
