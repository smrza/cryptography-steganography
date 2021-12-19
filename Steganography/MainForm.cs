using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Steganography.Classes;

namespace Steganography
{
    public partial class MainForm : Form
    {
        Bitmap picture;
        int? size;
        string fileType;
        string input;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ExperimentalForm embeddedForm = new ExperimentalForm();
            embeddedForm.TopLevel = false;
            tabExperimental.Controls.Add(embeddedForm);
            embeddedForm.Show();
            this.ActiveControl = null;
        }

        private void ButtonLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            string path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

            openImage.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|JPG |*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|BMP|*.bmp|GIF|*.gif";
            openImage.Title = "Please select an image file.";
            openImage.FilterIndex = 1;
            openImage.CheckFileExists = true;
            openImage.CheckPathExists = true;
            openImage.InitialDirectory = path;

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture = new Bitmap(openImage.FileName);
                    size = picture.Width * picture.Height;
                    width.Text = $"WIDTH: {picture.Width.ToString()} pixels";
                    height.Text = $"HEIGHT: {picture.Height.ToString()} pixels";
                    fileType = Path.GetExtension(openImage.FileName);
                    extension.Text = $"FILE EXTENSION: {fileType}";
                    pictureSize.Text = $"FILE SIZE: {new FileInfo(openImage.FileName).Length.ToString()} bytes";
                    this.path.Text = $"DIRECTORY: {openImage.FileName}";
                    widthHeight.Text = $"NUMBER OF PIXELS: {Convert.ToString(size)}";
                    numberOfChars.Text = $"MAXIMUM CHARACTERS: {Convert.ToString((size - 8) / 8)} ({size / 8} with zero)";
                    pictureBox.Image = picture;
                    labelPictureInfo.Visible = true;
                    width.Visible = true;
                    height.Visible = true;
                    extension.Visible = true;
                    pictureSize.Visible = true;
                    this.path.Visible = true;
                    widthHeight.Visible = true;
                    numberOfChars.Visible = true;
                    labelPleaseOpenImage.Visible = false;
                    if (size < 8)
                    {
                        MessageBox.Show("Picture is way too small. Sorry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ButtonReset_Click(sender, e);
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect file chosen. Not an image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonSavePicture_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("No picture to save! Make sure you have a picture opened.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog saveImage = new SaveFileDialog();
                string path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

                saveImage.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|BMP|*.bmp|GIF|*.gif|All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
                saveImage.Title = "Please select a directory.";
                saveImage.FilterIndex = StaticMethods.ReturnFileExtensionFilter(fileType);
                saveImage.CheckPathExists = true;
                saveImage.InitialDirectory = path;

                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveImage.FileName);
                }
            }
        }

        private void ButtonCode_Click(object sender, EventArgs e)
        {
            input = richTextBoxInputOutput.Text;

            if (pictureBox.Image == null)
            {
                if(MessageBox.Show("No picture to work with! Would you like to load one?", "Open Picture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ButtonLoadPicture_Click(sender, e);
                }
            }
            else if (input == "")
            {
                MessageBox.Show("No text to code. Please, enter your input.", "Enter Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = richTextBoxInputOutput;
            }
            else
            {
                if (StaticMethods.IsZero(input) == true && StaticMethods.IsNeededToParse(input) == true)
                {
                    input = StaticMethods.RemoveZero(input);
                    input = StaticMethods.ReturnParsedInput(input);
                    if(MessageBox.Show("Your input contained 0 and character(s) which extended default ASCII value. These were removed. Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        richTextBoxInputOutput.Height = 151;
                        richTextBoxParsedInput.Visible = true;
                        richTextBoxParsedInput.Text = input;
                        CodeHelper();
                    }

                }
                else if(StaticMethods.IsNeededToParse(input) == true)
                {
                    input = StaticMethods.ReturnParsedInput(input);
                    if (MessageBox.Show("Some characters which extended default ASCII value were removed. Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        richTextBoxInputOutput.Height = 151;
                        richTextBoxParsedInput.Visible = true;
                        richTextBoxParsedInput.Text = input;
                        CodeHelper();
                    }
                }
                else if (StaticMethods.IsZero(input) == true)
                {
                    input = StaticMethods.RemoveZero(input);
                    if (MessageBox.Show("Your input contained 0. Unfortunately, you cannot use this character, for it is an escape sequence. Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        richTextBoxInputOutput.Height = 151;
                        richTextBoxParsedInput.Visible = true;
                        richTextBoxParsedInput.Text = input;
                        CodeHelper();
                    }
                }
                else
                {
                    if(richTextBoxParsedInput.Visible == true)
                    {
                        richTextBoxInputOutput.Height = 315;
                        richTextBoxParsedInput.Visible = false;
                    }
                    CodeHelper();
                }
            }
        }

        private void CodeHelper()
        {
            if (input.Length > ((size - 8) / 8))
            {
                if (MessageBox.Show($"Your input is longer than your picture can hold. Some characters will be removed. Would you like to continue? (Your input would fit into a picture with at least {input.Length * 8 + 8} pixels)", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Code();
                }
            }
            else Code();         
        }

        private void Code()
        {
            Color pixel;
            string bluePart;
            int finalValue;
            string zero = "00001100"; //reversed zero
            int tmpHelp = 0;
            BitArray toCode = Conversions.ConvertStringToBinaryByArrayReverse(input);

            try
            {
                for (int y = 0; y <= picture.Height - 1; y++)
                {                    
                    if (tmpHelp > 7)
                    {
                        break;
                    }
                    
                    for (int x = 0; x <= picture.Width - 1; x++)
                    {
                        if (picture.Width * y + x < size - 8 && picture.Width * y + x < toCode.Length)
                        {
                            pixel = picture.GetPixel(x, y);
                            bluePart = Conversions.ConverDecimalToBinaryString(pixel.B);
                            finalValue = Conversions.ConvertBinaryStringToDecimal(bluePart.Substring(0, 7) + StaticMethods.InsertLetter(toCode[picture.Width * y + x]));
                            picture.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, finalValue));
                        }
                        else
                        {
                            pixel = picture.GetPixel(x, y);
                            bluePart = Conversions.ConverDecimalToBinaryString(pixel.B);
                            finalValue = Conversions.ConvertBinaryStringToDecimal(bluePart.Substring(0, 7) + zero[tmpHelp]);
                            picture.SetPixel(x, y, Color.FromArgb(pixel.R, pixel.G, finalValue));
                            tmpHelp++;

                            if (tmpHelp > 7)
                            {
                                break;
                            }
                        }
                    }
                }
                MessageBox.Show("Picture coded! Well done.", "Yes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Something went wrong. Please try again.", "Aaargh matey!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ButtonDecode_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                if (MessageBox.Show("No picture to work with! Would you like to open one?", "Open Picture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ButtonLoadPicture_Click(sender, e);
                }
            }
            else
            {
                if (richTextBoxParsedInput.Visible == true)
                {
                    richTextBoxInputOutput.Height = 315;
                    richTextBoxParsedInput.Visible = false;
                }

                Color pixel;
                StringBuilder helper = new StringBuilder();

                try
                {
                    for (int y = 0; y <= picture.Height - 1; y++)
                    {
                        for (int x = 0; x <= picture.Width - 1; x++)
                        {
                            pixel = picture.GetPixel(x, y);
                            helper.Append(Conversions.ConverDecimalToBinaryString(pixel.B)[7]);
                        }
                    }

                    string toDecode = helper.ToString();

                    for (int i = 0; i <= toDecode.Length - 8; i += 8)
                    {
                        if (toDecode.Substring(i, 8) == "00001100")
                        {
                            toDecode = toDecode.Substring(0, i) + "00001100";
                            break;
                        }
                    }
                    richTextBoxInputOutput.Text = Conversions.ConvertReverseBinaryToString(toDecode);
                    MessageBox.Show("Picture decoded! Please, check input & output textbox.", "Aaargh matey!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabDefault)
            {
                richTextBoxInputOutput.Text = "";
                pictureBox.Image = null;
                richTextBoxParsedInput.Text = "";
                picture = null;
                size = null;
                fileType = null;
                input = null;
                width.Text = "WIDTH";
                height.Text = "HEIGHT";
                widthHeight.Text = "NUMBER OF PIXELS";
                pictureSize.Text = "FILE SIZE";
                extension.Text = "FILE EXTENSION";
                path.Text = "DIRECTORY";
                numberOfChars.Text = "MAXIMUM CHARACTERS";
                labelPictureInfo.Visible = false;
                width.Visible = false;
                height.Visible = false;
                extension.Visible = false;
                pictureSize.Visible = false;
                this.path.Visible = false;
                widthHeight.Visible = false;
                numberOfChars.Visible = false;
                labelPleaseOpenImage.Visible = true;
                if (richTextBoxParsedInput.Visible == true)
                {
                    richTextBoxInputOutput.Height = 315;
                    richTextBoxParsedInput.Visible = false;
                }
            }
            else if (tabControl.SelectedTab == tabExperimental)
            {
                tabExperimental.Controls.Clear();
                ExperimentalForm embeddedForm = new ExperimentalForm();
                embeddedForm.TopLevel = false;
                tabExperimental.Controls.Add(embeddedForm);
                embeddedForm.Show();
            }
            else if(tabControl.SelectedTab == tabListView)
            {
                listViewImagePixelInformation.Items.Clear();
                listViewInputInformation.Items.Clear();
                progressBar.Visible = false;
            }
        }

        private void GetInputAsciiBinaryListView(string input)
        {
            foreach (char item in input)
            {
                LetterAsciiBinaryList toList = new LetterAsciiBinaryList();
                toList.Letter = item;
                toList.Ascii = Convert.ToInt32(item);
                toList.Binary = Conversions.ConverDecimalToBinaryString(Convert.ToInt32(item));
                toList.BinaryReverse = StaticMethods.ReverseString(toList.Binary);

                listViewInputInformation.Items.Add(new ListViewItem(new string[] { Convert.ToString(toList.Letter), Convert.ToString(toList.Ascii), toList.Binary, toList.BinaryReverse }));
            }
        }

        private void GetImageInfoBinaryListView()
        {
            Color pixel;
            progressBar.Maximum = Convert.ToInt32(size);
            progressBar.Step = 1;
            progressBar.Value = 0;

            for (int y = 0; y <= picture.Height - 1; y++)
            {
                for (int x = 0; x <= picture.Width - 1; x++)
                {
                    pixel = picture.GetPixel(x, y);
                    ImagePixelBinaryInformation toList = new ImagePixelBinaryInformation();
                    toList.X = x;
                    toList.Y = y;
                    toList.RedValue = pixel.R;
                    toList.GreenValue = pixel.G;
                    toList.BlueValue = pixel.B;
                    toList.BinaryRed = Conversions.ConverDecimalToBinaryString(toList.RedValue);
                    toList.BinaryGreen = Conversions.ConverDecimalToBinaryString(toList.GreenValue);
                    toList.BinaryBlue = Conversions.ConverDecimalToBinaryString(toList.BlueValue);
                    toList.LeastSignificantBitBlue = toList.BinaryBlue[7];
                    listViewImagePixelInformation.Items.Add(new ListViewItem(new string[] { Convert.ToString(toList.X), Convert.ToString(toList.Y), Convert.ToString(toList.RedValue), Convert.ToString(toList.GreenValue), Convert.ToString(toList.BlueValue), toList.BinaryRed, toList.BinaryGreen, toList.BinaryBlue, Convert.ToString(toList.LeastSignificantBitBlue) }));
                    progressBar.Value = picture.Width * y + x;
                }
            }

            progressBar.Visible = false;
        }

        private void ButtonGetInputInformation_Click(object sender, EventArgs e)
        {
            if (richTextBoxInputOutput.Text == "")
            {
                MessageBox.Show("Please, enter your input and try again.", "Enter input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl.SelectedTab = tabDefault;
                this.ActiveControl = richTextBoxInputOutput;
            }
            else GetInputAsciiBinaryListView(richTextBoxInputOutput.Text);
        }

        private void ButtonGetImageInformation_Click(object sender, EventArgs e)
        {
            if (picture == null)
            {
                MessageBox.Show("Please, open a picture and try again.", "Open Picture", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.tabControl.SelectedTab = tabDefault;
                ButtonLoadPicture_Click(sender, e);
                if(picture != null)
                {
                    this.tabControl.SelectedTab = tabListView;
                    progressBar.Visible = true;
                    ButtonGetImageInformation_Click(sender, e);
                }
                else this.tabControl.SelectedTab = tabListView;
            }
            else if(size > 200)
            {
                if (MessageBox.Show($"Your picture contains {size} pixels, thus the action might take a while. Would you like to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    progressBar.Visible = true;
                    GetImageInfoBinaryListView();
                }
            }
            else
            {
                progressBar.Visible = true;
                GetImageInfoBinaryListView();
            }
        }
    }
}
