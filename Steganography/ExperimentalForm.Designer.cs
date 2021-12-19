namespace Steganography
{
    partial class ExperimentalForm
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
            this.pictureBoxDefault = new System.Windows.Forms.PictureBox();
            this.pictureBoxCodedDecoded = new System.Windows.Forms.PictureBox();
            this.buttonOpenDefault = new System.Windows.Forms.Button();
            this.buttonDecodeImageFromImage = new System.Windows.Forms.Button();
            this.buttonSaveDefaultImage = new System.Windows.Forms.Button();
            this.buttonSetGamma = new System.Windows.Forms.Button();
            this.buttonCodeImageIntoImage = new System.Windows.Forms.Button();
            this.pictureBoxToCode = new System.Windows.Forms.PictureBox();
            this.buttonCodeTextToWav = new System.Windows.Forms.Button();
            this.buttonCodePictureToWav = new System.Windows.Forms.Button();
            this.buttonDecodePictureFromWav = new System.Windows.Forms.Button();
            this.buttonSaveCodedDecodedImage = new System.Windows.Forms.Button();
            this.buttonSaveImageToBeCoded = new System.Windows.Forms.Button();
            this.buttonOpenCodedDecoded = new System.Windows.Forms.Button();
            this.buttonOpenToCode = new System.Windows.Forms.Button();
            this.buttonDecodeTextFromWav = new System.Windows.Forms.Button();
            this.richTextBoxInputOutput = new System.Windows.Forms.RichTextBox();
            this.buttonLeft1 = new System.Windows.Forms.Button();
            this.buttonLeft2 = new System.Windows.Forms.Button();
            this.buttonRight1 = new System.Windows.Forms.Button();
            this.buttonRight2 = new System.Windows.Forms.Button();
            this.buttonCodeTextToWavByte = new System.Windows.Forms.Button();
            this.buttonCodePictureToWavByte = new System.Windows.Forms.Button();
            this.buttonDecodeTextFromWavByte = new System.Windows.Forms.Button();
            this.buttonDecodePictureFromWavByte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodedDecoded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDefault
            // 
            this.pictureBoxDefault.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDefault.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxDefault.Name = "pictureBoxDefault";
            this.pictureBoxDefault.Size = new System.Drawing.Size(500, 413);
            this.pictureBoxDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDefault.TabIndex = 0;
            this.pictureBoxDefault.TabStop = false;
            // 
            // pictureBoxCodedDecoded
            // 
            this.pictureBoxCodedDecoded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCodedDecoded.Location = new System.Drawing.Point(574, 17);
            this.pictureBoxCodedDecoded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCodedDecoded.Name = "pictureBoxCodedDecoded";
            this.pictureBoxCodedDecoded.Size = new System.Drawing.Size(500, 413);
            this.pictureBoxCodedDecoded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCodedDecoded.TabIndex = 1;
            this.pictureBoxCodedDecoded.TabStop = false;
            // 
            // buttonOpenDefault
            // 
            this.buttonOpenDefault.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonOpenDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenDefault.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonOpenDefault.Location = new System.Drawing.Point(268, 443);
            this.buttonOpenDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenDefault.Name = "buttonOpenDefault";
            this.buttonOpenDefault.Size = new System.Drawing.Size(240, 46);
            this.buttonOpenDefault.TabIndex = 2;
            this.buttonOpenDefault.TabStop = false;
            this.buttonOpenDefault.Text = "OPEN IMAGE";
            this.buttonOpenDefault.UseVisualStyleBackColor = false;
            this.buttonOpenDefault.Click += new System.EventHandler(this.ButtonOpenDefault_Click);
            // 
            // buttonDecodeImageFromImage
            // 
            this.buttonDecodeImageFromImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonDecodeImageFromImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecodeImageFromImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecodeImageFromImage.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonDecodeImageFromImage.Location = new System.Drawing.Point(428, 498);
            this.buttonDecodeImageFromImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDecodeImageFromImage.Name = "buttonDecodeImageFromImage";
            this.buttonDecodeImageFromImage.Size = new System.Drawing.Size(240, 46);
            this.buttonDecodeImageFromImage.TabIndex = 3;
            this.buttonDecodeImageFromImage.TabStop = false;
            this.buttonDecodeImageFromImage.Text = "DECODE IMAGE";
            this.buttonDecodeImageFromImage.UseVisualStyleBackColor = false;
            this.buttonDecodeImageFromImage.Click += new System.EventHandler(this.ButtonDecodePictureFromPicture_Click);
            // 
            // buttonSaveDefaultImage
            // 
            this.buttonSaveDefaultImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSaveDefaultImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDefaultImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveDefaultImage.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonSaveDefaultImage.Location = new System.Drawing.Point(21, 443);
            this.buttonSaveDefaultImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveDefaultImage.Name = "buttonSaveDefaultImage";
            this.buttonSaveDefaultImage.Size = new System.Drawing.Size(240, 46);
            this.buttonSaveDefaultImage.TabIndex = 4;
            this.buttonSaveDefaultImage.TabStop = false;
            this.buttonSaveDefaultImage.Text = "SAVE IMAGE";
            this.buttonSaveDefaultImage.UseVisualStyleBackColor = false;
            this.buttonSaveDefaultImage.Click += new System.EventHandler(this.ButtonSaveDefaultImage_Click);
            // 
            // buttonSetGamma
            // 
            this.buttonSetGamma.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSetGamma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetGamma.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonSetGamma.Location = new System.Drawing.Point(706, 498);
            this.buttonSetGamma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSetGamma.Name = "buttonSetGamma";
            this.buttonSetGamma.Size = new System.Drawing.Size(240, 46);
            this.buttonSetGamma.TabIndex = 5;
            this.buttonSetGamma.TabStop = false;
            this.buttonSetGamma.Text = "SET GAMMA";
            this.buttonSetGamma.UseVisualStyleBackColor = false;
            this.buttonSetGamma.Click += new System.EventHandler(this.ButtonSetGammaOfDecodedPicture_Click);
            // 
            // buttonCodeImageIntoImage
            // 
            this.buttonCodeImageIntoImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonCodeImageIntoImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCodeImageIntoImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCodeImageIntoImage.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonCodeImageIntoImage.Location = new System.Drawing.Point(981, 498);
            this.buttonCodeImageIntoImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCodeImageIntoImage.Name = "buttonCodeImageIntoImage";
            this.buttonCodeImageIntoImage.Size = new System.Drawing.Size(240, 46);
            this.buttonCodeImageIntoImage.TabIndex = 6;
            this.buttonCodeImageIntoImage.TabStop = false;
            this.buttonCodeImageIntoImage.Text = "CODE IMAGE";
            this.buttonCodeImageIntoImage.UseVisualStyleBackColor = false;
            this.buttonCodeImageIntoImage.Click += new System.EventHandler(this.ButtonCodePictureIntoPicture_Click);
            // 
            // pictureBoxToCode
            // 
            this.pictureBoxToCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxToCode.Location = new System.Drawing.Point(1136, 17);
            this.pictureBoxToCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxToCode.Name = "pictureBoxToCode";
            this.pictureBoxToCode.Size = new System.Drawing.Size(500, 413);
            this.pictureBoxToCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxToCode.TabIndex = 7;
            this.pictureBoxToCode.TabStop = false;
            // 
            // buttonCodeTextToWav
            // 
            this.buttonCodeTextToWav.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonCodeTextToWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCodeTextToWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCodeTextToWav.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonCodeTextToWav.Location = new System.Drawing.Point(1122, 578);
            this.buttonCodeTextToWav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCodeTextToWav.Name = "buttonCodeTextToWav";
            this.buttonCodeTextToWav.Size = new System.Drawing.Size(406, 54);
            this.buttonCodeTextToWav.TabIndex = 9;
            this.buttonCodeTextToWav.TabStop = false;
            this.buttonCodeTextToWav.Text = "CODE TEXT TO .WAV";
            this.buttonCodeTextToWav.UseVisualStyleBackColor = false;
            this.buttonCodeTextToWav.Click += new System.EventHandler(this.ButtonCodeTextToWavBit_Click);
            // 
            // buttonCodePictureToWav
            // 
            this.buttonCodePictureToWav.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonCodePictureToWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCodePictureToWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCodePictureToWav.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonCodePictureToWav.Location = new System.Drawing.Point(1122, 642);
            this.buttonCodePictureToWav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCodePictureToWav.Name = "buttonCodePictureToWav";
            this.buttonCodePictureToWav.Size = new System.Drawing.Size(406, 54);
            this.buttonCodePictureToWav.TabIndex = 10;
            this.buttonCodePictureToWav.TabStop = false;
            this.buttonCodePictureToWav.Text = "CODE IMAGE TO .WAV";
            this.buttonCodePictureToWav.UseVisualStyleBackColor = false;
            this.buttonCodePictureToWav.Click += new System.EventHandler(this.ButtonCodePictureToWavBit_Click);
            // 
            // buttonDecodePictureFromWav
            // 
            this.buttonDecodePictureFromWav.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonDecodePictureFromWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecodePictureFromWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecodePictureFromWav.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonDecodePictureFromWav.Location = new System.Drawing.Point(1122, 768);
            this.buttonDecodePictureFromWav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDecodePictureFromWav.Name = "buttonDecodePictureFromWav";
            this.buttonDecodePictureFromWav.Size = new System.Drawing.Size(406, 54);
            this.buttonDecodePictureFromWav.TabIndex = 11;
            this.buttonDecodePictureFromWav.TabStop = false;
            this.buttonDecodePictureFromWav.Text = "DECODE IMAGE FROM .WAV";
            this.buttonDecodePictureFromWav.UseVisualStyleBackColor = false;
            this.buttonDecodePictureFromWav.Click += new System.EventHandler(this.ButtonDecodePictureFromWavBit_Click);
            // 
            // buttonSaveCodedDecodedImage
            // 
            this.buttonSaveCodedDecodedImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSaveCodedDecodedImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveCodedDecodedImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCodedDecodedImage.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonSaveCodedDecodedImage.Location = new System.Drawing.Point(585, 443);
            this.buttonSaveCodedDecodedImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveCodedDecodedImage.Name = "buttonSaveCodedDecodedImage";
            this.buttonSaveCodedDecodedImage.Size = new System.Drawing.Size(240, 46);
            this.buttonSaveCodedDecodedImage.TabIndex = 4;
            this.buttonSaveCodedDecodedImage.TabStop = false;
            this.buttonSaveCodedDecodedImage.Text = "SAVE IMAGE";
            this.buttonSaveCodedDecodedImage.UseVisualStyleBackColor = false;
            this.buttonSaveCodedDecodedImage.Click += new System.EventHandler(this.ButtonSaveCodedDecodedImage_Click);
            // 
            // buttonSaveImageToBeCoded
            // 
            this.buttonSaveImageToBeCoded.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSaveImageToBeCoded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveImageToBeCoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveImageToBeCoded.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonSaveImageToBeCoded.Location = new System.Drawing.Point(1140, 443);
            this.buttonSaveImageToBeCoded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveImageToBeCoded.Name = "buttonSaveImageToBeCoded";
            this.buttonSaveImageToBeCoded.Size = new System.Drawing.Size(240, 46);
            this.buttonSaveImageToBeCoded.TabIndex = 4;
            this.buttonSaveImageToBeCoded.TabStop = false;
            this.buttonSaveImageToBeCoded.Text = "SAVE IMAGE";
            this.buttonSaveImageToBeCoded.UseVisualStyleBackColor = false;
            this.buttonSaveImageToBeCoded.Click += new System.EventHandler(this.ButtonSaveImageToBeCoded_Click);
            // 
            // buttonOpenCodedDecoded
            // 
            this.buttonOpenCodedDecoded.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonOpenCodedDecoded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenCodedDecoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenCodedDecoded.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonOpenCodedDecoded.Location = new System.Drawing.Point(831, 443);
            this.buttonOpenCodedDecoded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenCodedDecoded.Name = "buttonOpenCodedDecoded";
            this.buttonOpenCodedDecoded.Size = new System.Drawing.Size(240, 46);
            this.buttonOpenCodedDecoded.TabIndex = 2;
            this.buttonOpenCodedDecoded.TabStop = false;
            this.buttonOpenCodedDecoded.Text = "OPEN IMAGE";
            this.buttonOpenCodedDecoded.UseVisualStyleBackColor = false;
            this.buttonOpenCodedDecoded.Click += new System.EventHandler(this.ButtonOpenCodedDecoded_Click);
            // 
            // buttonOpenToCode
            // 
            this.buttonOpenToCode.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonOpenToCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenToCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenToCode.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonOpenToCode.Location = new System.Drawing.Point(1386, 443);
            this.buttonOpenToCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenToCode.Name = "buttonOpenToCode";
            this.buttonOpenToCode.Size = new System.Drawing.Size(240, 46);
            this.buttonOpenToCode.TabIndex = 2;
            this.buttonOpenToCode.TabStop = false;
            this.buttonOpenToCode.Text = "OPEN IMAGE";
            this.buttonOpenToCode.UseVisualStyleBackColor = false;
            this.buttonOpenToCode.Click += new System.EventHandler(this.ButtonOpenToCode_Click);
            // 
            // buttonDecodeTextFromWav
            // 
            this.buttonDecodeTextFromWav.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonDecodeTextFromWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecodeTextFromWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecodeTextFromWav.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonDecodeTextFromWav.Location = new System.Drawing.Point(1122, 705);
            this.buttonDecodeTextFromWav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDecodeTextFromWav.Name = "buttonDecodeTextFromWav";
            this.buttonDecodeTextFromWav.Size = new System.Drawing.Size(406, 54);
            this.buttonDecodeTextFromWav.TabIndex = 11;
            this.buttonDecodeTextFromWav.TabStop = false;
            this.buttonDecodeTextFromWav.Text = "DECODE TEXT FROM .WAV";
            this.buttonDecodeTextFromWav.UseVisualStyleBackColor = false;
            this.buttonDecodeTextFromWav.Click += new System.EventHandler(this.ButtonDecodeTextFromWavBit_Click);
            // 
            // richTextBoxInputOutput
            // 
            this.richTextBoxInputOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInputOutput.Location = new System.Drawing.Point(22, 568);
            this.richTextBoxInputOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxInputOutput.Name = "richTextBoxInputOutput";
            this.richTextBoxInputOutput.Size = new System.Drawing.Size(1084, 261);
            this.richTextBoxInputOutput.TabIndex = 12;
            this.richTextBoxInputOutput.TabStop = false;
            this.richTextBoxInputOutput.Text = "IO";
            // 
            // buttonLeft1
            // 
            this.buttonLeft1.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeft1.BackgroundImage = global::Steganography.Properties.Resources.leftArrow;
            this.buttonLeft1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft1.Location = new System.Drawing.Point(518, 168);
            this.buttonLeft1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLeft1.Name = "buttonLeft1";
            this.buttonLeft1.Size = new System.Drawing.Size(60, 62);
            this.buttonLeft1.TabIndex = 13;
            this.buttonLeft1.TabStop = false;
            this.buttonLeft1.UseVisualStyleBackColor = false;
            this.buttonLeft1.Click += new System.EventHandler(this.ButtonLeft1_Click);
            // 
            // buttonLeft2
            // 
            this.buttonLeft2.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeft2.BackgroundImage = global::Steganography.Properties.Resources.leftArrow;
            this.buttonLeft2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft2.Location = new System.Drawing.Point(1077, 238);
            this.buttonLeft2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLeft2.Name = "buttonLeft2";
            this.buttonLeft2.Size = new System.Drawing.Size(60, 62);
            this.buttonLeft2.TabIndex = 13;
            this.buttonLeft2.TabStop = false;
            this.buttonLeft2.UseVisualStyleBackColor = false;
            this.buttonLeft2.Click += new System.EventHandler(this.ButtonLeft2_Click);
            // 
            // buttonRight1
            // 
            this.buttonRight1.BackColor = System.Drawing.Color.Transparent;
            this.buttonRight1.BackgroundImage = global::Steganography.Properties.Resources.rightArrow;
            this.buttonRight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight1.Location = new System.Drawing.Point(518, 238);
            this.buttonRight1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRight1.Name = "buttonRight1";
            this.buttonRight1.Size = new System.Drawing.Size(60, 62);
            this.buttonRight1.TabIndex = 13;
            this.buttonRight1.TabStop = false;
            this.buttonRight1.UseVisualStyleBackColor = false;
            this.buttonRight1.Click += new System.EventHandler(this.ButtonRight1_Click);
            // 
            // buttonRight2
            // 
            this.buttonRight2.BackColor = System.Drawing.Color.Transparent;
            this.buttonRight2.BackgroundImage = global::Steganography.Properties.Resources.rightArrow;
            this.buttonRight2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight2.Location = new System.Drawing.Point(1077, 168);
            this.buttonRight2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRight2.Name = "buttonRight2";
            this.buttonRight2.Size = new System.Drawing.Size(60, 62);
            this.buttonRight2.TabIndex = 13;
            this.buttonRight2.TabStop = false;
            this.buttonRight2.UseVisualStyleBackColor = false;
            this.buttonRight2.Click += new System.EventHandler(this.ButtonRight2_Click);
            // 
            // buttonCodeTextToWavByte
            // 
            this.buttonCodeTextToWavByte.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonCodeTextToWavByte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCodeTextToWavByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCodeTextToWavByte.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonCodeTextToWavByte.Location = new System.Drawing.Point(1538, 578);
            this.buttonCodeTextToWavByte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCodeTextToWavByte.Name = "buttonCodeTextToWavByte";
            this.buttonCodeTextToWavByte.Size = new System.Drawing.Size(98, 54);
            this.buttonCodeTextToWavByte.TabIndex = 14;
            this.buttonCodeTextToWavByte.TabStop = false;
            this.buttonCodeTextToWavByte.Text = "BYTE";
            this.buttonCodeTextToWavByte.UseVisualStyleBackColor = false;
            this.buttonCodeTextToWavByte.Click += new System.EventHandler(this.ButtonCodeTextToWav_Click);
            // 
            // buttonCodePictureToWavByte
            // 
            this.buttonCodePictureToWavByte.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonCodePictureToWavByte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCodePictureToWavByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCodePictureToWavByte.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonCodePictureToWavByte.Location = new System.Drawing.Point(1538, 642);
            this.buttonCodePictureToWavByte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCodePictureToWavByte.Name = "buttonCodePictureToWavByte";
            this.buttonCodePictureToWavByte.Size = new System.Drawing.Size(98, 54);
            this.buttonCodePictureToWavByte.TabIndex = 14;
            this.buttonCodePictureToWavByte.TabStop = false;
            this.buttonCodePictureToWavByte.Text = "BYTE";
            this.buttonCodePictureToWavByte.UseVisualStyleBackColor = false;
            this.buttonCodePictureToWavByte.Click += new System.EventHandler(this.ButtonCodePictureToWav_Click);
            // 
            // buttonDecodeTextFromWavByte
            // 
            this.buttonDecodeTextFromWavByte.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonDecodeTextFromWavByte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecodeTextFromWavByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecodeTextFromWavByte.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonDecodeTextFromWavByte.Location = new System.Drawing.Point(1538, 705);
            this.buttonDecodeTextFromWavByte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDecodeTextFromWavByte.Name = "buttonDecodeTextFromWavByte";
            this.buttonDecodeTextFromWavByte.Size = new System.Drawing.Size(98, 54);
            this.buttonDecodeTextFromWavByte.TabIndex = 14;
            this.buttonDecodeTextFromWavByte.TabStop = false;
            this.buttonDecodeTextFromWavByte.Text = "BYTE";
            this.buttonDecodeTextFromWavByte.UseVisualStyleBackColor = false;
            this.buttonDecodeTextFromWavByte.Click += new System.EventHandler(this.ButtonDecodeTextFromWav_Click);
            // 
            // buttonDecodePictureFromWavByte
            // 
            this.buttonDecodePictureFromWavByte.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonDecodePictureFromWavByte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecodePictureFromWavByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecodePictureFromWavByte.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonDecodePictureFromWavByte.Location = new System.Drawing.Point(1538, 768);
            this.buttonDecodePictureFromWavByte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDecodePictureFromWavByte.Name = "buttonDecodePictureFromWavByte";
            this.buttonDecodePictureFromWavByte.Size = new System.Drawing.Size(98, 54);
            this.buttonDecodePictureFromWavByte.TabIndex = 14;
            this.buttonDecodePictureFromWavByte.TabStop = false;
            this.buttonDecodePictureFromWavByte.Text = "BYTE";
            this.buttonDecodePictureFromWavByte.UseVisualStyleBackColor = false;
            this.buttonDecodePictureFromWavByte.Click += new System.EventHandler(this.ButtonDecodePictureFromWav_Click);
            // 
            // ExperimentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Steganography.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1653, 848);
            this.Controls.Add(this.buttonDecodePictureFromWavByte);
            this.Controls.Add(this.buttonDecodeTextFromWavByte);
            this.Controls.Add(this.buttonCodePictureToWavByte);
            this.Controls.Add(this.buttonCodeTextToWavByte);
            this.Controls.Add(this.buttonLeft2);
            this.Controls.Add(this.buttonRight2);
            this.Controls.Add(this.buttonRight1);
            this.Controls.Add(this.buttonLeft1);
            this.Controls.Add(this.richTextBoxInputOutput);
            this.Controls.Add(this.buttonDecodeTextFromWav);
            this.Controls.Add(this.buttonDecodePictureFromWav);
            this.Controls.Add(this.buttonCodePictureToWav);
            this.Controls.Add(this.buttonCodeTextToWav);
            this.Controls.Add(this.pictureBoxToCode);
            this.Controls.Add(this.buttonCodeImageIntoImage);
            this.Controls.Add(this.buttonSetGamma);
            this.Controls.Add(this.buttonSaveImageToBeCoded);
            this.Controls.Add(this.buttonSaveCodedDecodedImage);
            this.Controls.Add(this.buttonSaveDefaultImage);
            this.Controls.Add(this.buttonDecodeImageFromImage);
            this.Controls.Add(this.buttonOpenToCode);
            this.Controls.Add(this.buttonOpenCodedDecoded);
            this.Controls.Add(this.buttonOpenDefault);
            this.Controls.Add(this.pictureBoxCodedDecoded);
            this.Controls.Add(this.pictureBoxDefault);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExperimentalForm";
            this.Text = "Experimental";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodedDecoded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDefault;
        private System.Windows.Forms.PictureBox pictureBoxCodedDecoded;
        private System.Windows.Forms.Button buttonOpenDefault;
        private System.Windows.Forms.Button buttonDecodeImageFromImage;
        private System.Windows.Forms.Button buttonSaveDefaultImage;
        private System.Windows.Forms.Button buttonSetGamma;
        private System.Windows.Forms.Button buttonCodeImageIntoImage;
        private System.Windows.Forms.PictureBox pictureBoxToCode;
        private System.Windows.Forms.Button buttonCodeTextToWav;
        private System.Windows.Forms.Button buttonCodePictureToWav;
        private System.Windows.Forms.Button buttonDecodePictureFromWav;
        private System.Windows.Forms.Button buttonSaveCodedDecodedImage;
        private System.Windows.Forms.Button buttonSaveImageToBeCoded;
        private System.Windows.Forms.Button buttonOpenCodedDecoded;
        private System.Windows.Forms.Button buttonOpenToCode;
        private System.Windows.Forms.Button buttonDecodeTextFromWav;
        private System.Windows.Forms.RichTextBox richTextBoxInputOutput;
        private System.Windows.Forms.Button buttonLeft1;
        private System.Windows.Forms.Button buttonLeft2;
        private System.Windows.Forms.Button buttonRight1;
        private System.Windows.Forms.Button buttonRight2;
        private System.Windows.Forms.Button buttonCodeTextToWavByte;
        private System.Windows.Forms.Button buttonCodePictureToWavByte;
        private System.Windows.Forms.Button buttonDecodeTextFromWavByte;
        private System.Windows.Forms.Button buttonDecodePictureFromWavByte;
    }
}