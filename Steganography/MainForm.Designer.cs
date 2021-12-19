namespace Steganography
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.buttonSavePicture = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelPleaseOpenImage = new System.Windows.Forms.Label();
            this.labelPictureInfo = new System.Windows.Forms.Label();
            this.widthHeight = new System.Windows.Forms.Label();
            this.numberOfChars = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.pictureSize = new System.Windows.Forms.Label();
            this.extension = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDefault = new System.Windows.Forms.TabPage();
            this.labelInput = new System.Windows.Forms.Label();
            this.richTextBoxParsedInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxInputOutput = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabExperimental = new System.Windows.Forms.TabPage();
            this.tabListView = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonGetImageInformation = new System.Windows.Forms.Button();
            this.buttonGetInputInformation = new System.Windows.Forms.Button();
            this.listViewImagePixelInformation = new System.Windows.Forms.ListView();
            this.X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RedValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GreenValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BlueValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RedBinary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GreenBinary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BlueBinary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LSB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewInputInformation = new System.Windows.Forms.ListView();
            this.Character = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ASCII = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Binary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BinaryReverse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.toolTipInfoPicture = new System.Windows.Forms.ToolTip(this.components);
            this.panelInfo.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonLoadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadPicture.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonLoadPicture.Location = new System.Drawing.Point(57, 41);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(150, 50);
            this.buttonLoadPicture.TabIndex = 1;
            this.buttonLoadPicture.Text = "LOAD PICTURE";
            this.buttonLoadPicture.UseVisualStyleBackColor = false;
            this.buttonLoadPicture.Click += new System.EventHandler(this.ButtonLoadPicture_Click);
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSavePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePicture.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonSavePicture.Location = new System.Drawing.Point(295, 41);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(150, 50);
            this.buttonSavePicture.TabIndex = 2;
            this.buttonSavePicture.Text = "SAVE PICTURE";
            this.buttonSavePicture.UseVisualStyleBackColor = false;
            this.buttonSavePicture.Click += new System.EventHandler(this.ButtonSavePicture_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.labelPleaseOpenImage);
            this.panelInfo.Controls.Add(this.labelPictureInfo);
            this.panelInfo.Controls.Add(this.widthHeight);
            this.panelInfo.Controls.Add(this.numberOfChars);
            this.panelInfo.Controls.Add(this.path);
            this.panelInfo.Controls.Add(this.pictureSize);
            this.panelInfo.Controls.Add(this.extension);
            this.panelInfo.Controls.Add(this.height);
            this.panelInfo.Controls.Add(this.width);
            this.panelInfo.Location = new System.Drawing.Point(527, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(560, 205);
            this.panelInfo.TabIndex = 0;
            // 
            // labelPleaseOpenImage
            // 
            this.labelPleaseOpenImage.AutoSize = true;
            this.labelPleaseOpenImage.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelPleaseOpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPleaseOpenImage.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelPleaseOpenImage.Location = new System.Drawing.Point(62, 88);
            this.labelPleaseOpenImage.Name = "labelPleaseOpenImage";
            this.labelPleaseOpenImage.Size = new System.Drawing.Size(457, 24);
            this.labelPleaseOpenImage.TabIndex = 14;
            this.labelPleaseOpenImage.Text = "OPEN A PICTURE TO SHOW ITS PROPERTIES";
            // 
            // labelPictureInfo
            // 
            this.labelPictureInfo.AutoSize = true;
            this.labelPictureInfo.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelPictureInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPictureInfo.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelPictureInfo.Location = new System.Drawing.Point(175, 5);
            this.labelPictureInfo.Name = "labelPictureInfo";
            this.labelPictureInfo.Size = new System.Drawing.Size(224, 24);
            this.labelPictureInfo.TabIndex = 14;
            this.labelPictureInfo.Text = "IMAGE INFORMATION";
            this.labelPictureInfo.Visible = false;
            // 
            // widthHeight
            // 
            this.widthHeight.AutoSize = true;
            this.widthHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthHeight.ForeColor = System.Drawing.Color.SandyBrown;
            this.widthHeight.Location = new System.Drawing.Point(23, 71);
            this.widthHeight.Name = "widthHeight";
            this.widthHeight.Size = new System.Drawing.Size(157, 17);
            this.widthHeight.TabIndex = 3;
            this.widthHeight.Text = "NUMBER OF PIXELS";
            this.widthHeight.Visible = false;
            // 
            // numberOfChars
            // 
            this.numberOfChars.AutoSize = true;
            this.numberOfChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfChars.ForeColor = System.Drawing.Color.SandyBrown;
            this.numberOfChars.Location = new System.Drawing.Point(23, 163);
            this.numberOfChars.Name = "numberOfChars";
            this.numberOfChars.Size = new System.Drawing.Size(187, 17);
            this.numberOfChars.TabIndex = 1;
            this.numberOfChars.Text = "MAXIMUM CHARACTERS";
            this.numberOfChars.Visible = false;
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.ForeColor = System.Drawing.Color.SandyBrown;
            this.path.Location = new System.Drawing.Point(23, 134);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(97, 17);
            this.path.TabIndex = 0;
            this.path.Text = "DIRECTORY";
            this.path.Visible = false;
            // 
            // pictureSize
            // 
            this.pictureSize.AutoSize = true;
            this.pictureSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureSize.ForeColor = System.Drawing.Color.SandyBrown;
            this.pictureSize.Location = new System.Drawing.Point(343, 71);
            this.pictureSize.Name = "pictureSize";
            this.pictureSize.Size = new System.Drawing.Size(79, 17);
            this.pictureSize.TabIndex = 0;
            this.pictureSize.Text = "FILE SIZE";
            this.pictureSize.Visible = false;
            // 
            // extension
            // 
            this.extension.AutoSize = true;
            this.extension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extension.ForeColor = System.Drawing.Color.SandyBrown;
            this.extension.Location = new System.Drawing.Point(23, 102);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(133, 17);
            this.extension.TabIndex = 0;
            this.extension.Text = "FILE EXTENSION";
            this.extension.Visible = false;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.ForeColor = System.Drawing.Color.SandyBrown;
            this.height.Location = new System.Drawing.Point(343, 39);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(66, 17);
            this.height.TabIndex = 0;
            this.height.Text = "HEIGHT";
            this.height.Visible = false;
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.ForeColor = System.Drawing.Color.SandyBrown;
            this.width.Location = new System.Drawing.Point(23, 39);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(58, 17);
            this.width.TabIndex = 0;
            this.width.Text = "WIDTH";
            this.width.Visible = false;
            // 
            // buttonCode
            // 
            this.buttonCode.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonCode.Location = new System.Drawing.Point(57, 131);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(150, 50);
            this.buttonCode.TabIndex = 3;
            this.buttonCode.Text = "CODE";
            this.buttonCode.UseVisualStyleBackColor = false;
            this.buttonCode.Click += new System.EventHandler(this.ButtonCode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecode.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonDecode.Location = new System.Drawing.Point(295, 131);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(150, 50);
            this.buttonDecode.TabIndex = 4;
            this.buttonDecode.Text = "DECODE";
            this.buttonDecode.UseVisualStyleBackColor = false;
            this.buttonDecode.Click += new System.EventHandler(this.ButtonDecode_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDefault);
            this.tabControl.Controls.Add(this.tabExperimental);
            this.tabControl.Controls.Add(this.tabListView);
            this.tabControl.Location = new System.Drawing.Point(12, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1110, 577);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabDefault
            // 
            this.tabDefault.BackgroundImage = global::Steganography.Properties.Resources.background;
            this.tabDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDefault.Controls.Add(this.labelInput);
            this.tabDefault.Controls.Add(this.richTextBoxParsedInput);
            this.tabDefault.Controls.Add(this.richTextBoxInputOutput);
            this.tabDefault.Controls.Add(this.buttonLoadPicture);
            this.tabDefault.Controls.Add(this.panelInfo);
            this.tabDefault.Controls.Add(this.pictureBox);
            this.tabDefault.Controls.Add(this.buttonDecode);
            this.tabDefault.Controls.Add(this.buttonSavePicture);
            this.tabDefault.Controls.Add(this.buttonCode);
            this.tabDefault.Location = new System.Drawing.Point(4, 22);
            this.tabDefault.Name = "tabDefault";
            this.tabDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefault.Size = new System.Drawing.Size(1102, 551);
            this.tabDefault.TabIndex = 0;
            this.tabDefault.Text = "Default";
            this.tabDefault.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelInput.Location = new System.Drawing.Point(172, 207);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(153, 20);
            this.labelInput.TabIndex = 14;
            this.labelInput.Text = "INPUT && OUTPUT";
            // 
            // richTextBoxParsedInput
            // 
            this.richTextBoxParsedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxParsedInput.Location = new System.Drawing.Point(12, 394);
            this.richTextBoxParsedInput.Name = "richTextBoxParsedInput";
            this.richTextBoxParsedInput.Size = new System.Drawing.Size(500, 151);
            this.richTextBoxParsedInput.TabIndex = 13;
            this.richTextBoxParsedInput.Text = "";
            this.richTextBoxParsedInput.Visible = false;
            // 
            // richTextBoxInputOutput
            // 
            this.richTextBoxInputOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInputOutput.Location = new System.Drawing.Point(12, 230);
            this.richTextBoxInputOutput.Name = "richTextBoxInputOutput";
            this.richTextBoxInputOutput.Size = new System.Drawing.Size(500, 315);
            this.richTextBoxInputOutput.TabIndex = 5;
            this.richTextBoxInputOutput.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(527, 230);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(560, 315);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tabExperimental
            // 
            this.tabExperimental.Location = new System.Drawing.Point(4, 22);
            this.tabExperimental.Name = "tabExperimental";
            this.tabExperimental.Padding = new System.Windows.Forms.Padding(3);
            this.tabExperimental.Size = new System.Drawing.Size(1102, 551);
            this.tabExperimental.TabIndex = 1;
            this.tabExperimental.Text = "Experimental";
            this.tabExperimental.UseVisualStyleBackColor = true;
            // 
            // tabListView
            // 
            this.tabListView.BackgroundImage = global::Steganography.Properties.Resources.background;
            this.tabListView.Controls.Add(this.progressBar);
            this.tabListView.Controls.Add(this.buttonGetImageInformation);
            this.tabListView.Controls.Add(this.buttonGetInputInformation);
            this.tabListView.Controls.Add(this.listViewImagePixelInformation);
            this.tabListView.Controls.Add(this.listViewInputInformation);
            this.tabListView.Location = new System.Drawing.Point(4, 22);
            this.tabListView.Name = "tabListView";
            this.tabListView.Padding = new System.Windows.Forms.Padding(3);
            this.tabListView.Size = new System.Drawing.Size(1102, 551);
            this.tabListView.TabIndex = 2;
            this.tabListView.Text = "List Information";
            this.tabListView.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(576, 241);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(399, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // buttonGetImageInformation
            // 
            this.buttonGetImageInformation.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonGetImageInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetImageInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetImageInformation.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonGetImageInformation.Location = new System.Drawing.Point(676, 495);
            this.buttonGetImageInformation.Name = "buttonGetImageInformation";
            this.buttonGetImageInformation.Size = new System.Drawing.Size(150, 50);
            this.buttonGetImageInformation.TabIndex = 2;
            this.buttonGetImageInformation.Text = "GET IMAGE INFORMATION";
            this.buttonGetImageInformation.UseVisualStyleBackColor = false;
            this.buttonGetImageInformation.Click += new System.EventHandler(this.ButtonGetImageInformation_Click);
            // 
            // buttonGetInputInformation
            // 
            this.buttonGetInputInformation.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonGetInputInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetInputInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetInputInformation.ForeColor = System.Drawing.Color.SandyBrown;
            this.buttonGetInputInformation.Location = new System.Drawing.Point(131, 495);
            this.buttonGetInputInformation.Name = "buttonGetInputInformation";
            this.buttonGetInputInformation.Size = new System.Drawing.Size(150, 50);
            this.buttonGetInputInformation.TabIndex = 1;
            this.buttonGetInputInformation.Text = "GET INPUT INFORMATION";
            this.buttonGetInputInformation.UseVisualStyleBackColor = false;
            this.buttonGetInputInformation.Click += new System.EventHandler(this.ButtonGetInputInformation_Click);
            // 
            // listViewImagePixelInformation
            // 
            this.listViewImagePixelInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.X,
            this.Y,
            this.RedValue,
            this.GreenValue,
            this.BlueValue,
            this.RedBinary,
            this.GreenBinary,
            this.BlueBinary,
            this.LSB});
            this.listViewImagePixelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewImagePixelInformation.GridLines = true;
            this.listViewImagePixelInformation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewImagePixelInformation.HideSelection = false;
            this.listViewImagePixelInformation.Location = new System.Drawing.Point(437, 6);
            this.listViewImagePixelInformation.MultiSelect = false;
            this.listViewImagePixelInformation.Name = "listViewImagePixelInformation";
            this.listViewImagePixelInformation.Size = new System.Drawing.Size(659, 483);
            this.listViewImagePixelInformation.TabIndex = 0;
            this.listViewImagePixelInformation.UseCompatibleStateImageBehavior = false;
            this.listViewImagePixelInformation.View = System.Windows.Forms.View.Details;
            // 
            // X
            // 
            this.X.Text = "X";
            // 
            // Y
            // 
            this.Y.Text = "Y";
            // 
            // RedValue
            // 
            this.RedValue.Text = "Red";
            this.RedValue.Width = 44;
            // 
            // GreenValue
            // 
            this.GreenValue.Text = "Green";
            this.GreenValue.Width = 52;
            // 
            // BlueValue
            // 
            this.BlueValue.Text = "Blue";
            this.BlueValue.Width = 45;
            // 
            // RedBinary
            // 
            this.RedBinary.Text = "Red Binary";
            this.RedBinary.Width = 83;
            // 
            // GreenBinary
            // 
            this.GreenBinary.Text = "Green Binary";
            this.GreenBinary.Width = 89;
            // 
            // BlueBinary
            // 
            this.BlueBinary.Text = "Blue Binary";
            this.BlueBinary.Width = 75;
            // 
            // LSB
            // 
            this.LSB.Text = "Least Significat Bit Of Blue";
            this.LSB.Width = 137;
            // 
            // listViewInputInformation
            // 
            this.listViewInputInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Character,
            this.ASCII,
            this.Binary,
            this.BinaryReverse});
            this.listViewInputInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewInputInformation.GridLines = true;
            this.listViewInputInformation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewInputInformation.HideSelection = false;
            this.listViewInputInformation.Location = new System.Drawing.Point(6, 6);
            this.listViewInputInformation.MultiSelect = false;
            this.listViewInputInformation.Name = "listViewInputInformation";
            this.listViewInputInformation.Size = new System.Drawing.Size(399, 483);
            this.listViewInputInformation.TabIndex = 0;
            this.listViewInputInformation.UseCompatibleStateImageBehavior = false;
            this.listViewInputInformation.View = System.Windows.Forms.View.Details;
            // 
            // Character
            // 
            this.Character.Text = "Character";
            this.Character.Width = 74;
            // 
            // ASCII
            // 
            this.ASCII.Text = "ASCII";
            this.ASCII.Width = 85;
            // 
            // Binary
            // 
            this.Binary.Text = "Binary";
            this.Binary.Width = 89;
            // 
            // BinaryReverse
            // 
            this.BinaryReverse.Text = "Reverse Binary";
            this.BinaryReverse.Width = 146;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SandyBrown;
            this.button2.Location = new System.Drawing.Point(1047, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackgroundImage = global::Steganography.Properties.Resources.info;
            this.pictureBoxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxInfo.Location = new System.Drawing.Point(1006, 0);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxInfo.TabIndex = 14;
            this.pictureBoxInfo.TabStop = false;
            this.toolTipInfoPicture.SetToolTip(this.pictureBoxInfo, resources.GetString("pictureBoxInfo.ToolTip"));
            // 
            // toolTipInfoPicture
            // 
            this.toolTipInfoPicture.AutoPopDelay = 600000;
            this.toolTipInfoPicture.InitialDelay = 500;
            this.toolTipInfoPicture.IsBalloon = true;
            this.toolTipInfoPicture.ReshowDelay = 100;
            this.toolTipInfoPicture.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfoPicture.ToolTipTitle = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1134, 601);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabDefault.ResumeLayout(false);
            this.tabDefault.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Label pictureSize;
        private System.Windows.Forms.Label extension;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Label numberOfChars;
        private System.Windows.Forms.Label widthHeight;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDefault;
        private System.Windows.Forms.TabPage tabExperimental;
        private System.Windows.Forms.RichTextBox richTextBoxInputOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBoxParsedInput;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.ToolTip toolTipInfoPicture;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelPictureInfo;
        private System.Windows.Forms.TabPage tabListView;
        private System.Windows.Forms.ListView listViewInputInformation;
        private System.Windows.Forms.ColumnHeader Character;
        private System.Windows.Forms.ColumnHeader ASCII;
        private System.Windows.Forms.ColumnHeader Binary;
        private System.Windows.Forms.ColumnHeader BinaryReverse;
        private System.Windows.Forms.ListView listViewImagePixelInformation;
        private System.Windows.Forms.ColumnHeader X;
        private System.Windows.Forms.ColumnHeader Y;
        private System.Windows.Forms.ColumnHeader RedValue;
        private System.Windows.Forms.ColumnHeader GreenValue;
        private System.Windows.Forms.ColumnHeader BlueValue;
        private System.Windows.Forms.ColumnHeader RedBinary;
        private System.Windows.Forms.ColumnHeader GreenBinary;
        private System.Windows.Forms.ColumnHeader BlueBinary;
        private System.Windows.Forms.ColumnHeader LSB;
        private System.Windows.Forms.Button buttonGetImageInformation;
        private System.Windows.Forms.Button buttonGetInputInformation;
        private System.Windows.Forms.Label labelPleaseOpenImage;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

