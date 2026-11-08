using BitmapFontTextures.Controls;

namespace BitmapFontTextures;

partial class MainForm
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
    checkBoxAntialias = new System.Windows.Forms.CheckBox();
    label2 = new System.Windows.Forms.Label();
    label3 = new System.Windows.Forms.Label();
    labelSampleText = new System.Windows.Forms.Label();
    textBoxSampleText = new System.Windows.Forms.TextBox();
    labelZoom = new System.Windows.Forms.Label();
    numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
    labelSpacing = new System.Windows.Forms.Label();
    numericUpDownSpacing = new System.Windows.Forms.NumericUpDown();
    labelLineSpacing = new System.Windows.Forms.Label();
    numericUpDownLineSpacing = new System.Windows.Forms.NumericUpDown();
    labelPadding = new System.Windows.Forms.Label();
    numericUpDownPadding = new System.Windows.Forms.NumericUpDown();
    pixelPreview = new PixelPreview();
    Export = new System.Windows.Forms.Button();
    label5 = new System.Windows.Forms.Label();
    label6 = new System.Windows.Forms.Label();
    label7 = new System.Windows.Forms.Label();
    colorDialog = new System.Windows.Forms.ColorDialog();
    pictureBoxTextColor = new System.Windows.Forms.PictureBox();
    groupBox1 = new System.Windows.Forms.GroupBox();
    pictureBoxOutlineColor = new System.Windows.Forms.PictureBox();
    OutlineSize = new System.Windows.Forms.NumericUpDown();
    groupBox2 = new System.Windows.Forms.GroupBox();
    AlphaAmount = new System.Windows.Forms.NumericUpDown();
    label8 = new System.Windows.Forms.Label();
    pictureBoxShadowColor = new System.Windows.Forms.PictureBox();
    ShadowOffset = new System.Windows.Forms.NumericUpDown();
    TextFilesListBox = new System.Windows.Forms.ListBox();
    ChooseTextFilesButton = new System.Windows.Forms.Button();
    comboBoxFontSize = new System.Windows.Forms.ComboBox();
    comboBoxFontStyle = new System.Windows.Forms.ComboBox();
    comboBoxFontName = new System.Windows.Forms.ComboBox();
    checkBoxExportDefault = new System.Windows.Forms.CheckBox();
    buttonChooseFontFiles = new System.Windows.Forms.Button();
    label1 = new System.Windows.Forms.Label();
    labelAntialiased = new System.Windows.Forms.Label();
    ((System.ComponentModel.ISupportInitialize)numericUpDownZoom).BeginInit();
    ((System.ComponentModel.ISupportInitialize)numericUpDownSpacing).BeginInit();
    ((System.ComponentModel.ISupportInitialize)numericUpDownLineSpacing).BeginInit();
    ((System.ComponentModel.ISupportInitialize)numericUpDownPadding).BeginInit();
    ((System.ComponentModel.ISupportInitialize)pictureBoxTextColor).BeginInit();
    groupBox1.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)pictureBoxOutlineColor).BeginInit();
    ((System.ComponentModel.ISupportInitialize)OutlineSize).BeginInit();
    groupBox2.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)AlphaAmount).BeginInit();
    ((System.ComponentModel.ISupportInitialize)pictureBoxShadowColor).BeginInit();
    ((System.ComponentModel.ISupportInitialize)ShadowOffset).BeginInit();
    SuspendLayout();
    // 
    // checkBoxAntialias
    // 
    checkBoxAntialias.AutoSize = true;
    checkBoxAntialias.Location = new System.Drawing.Point(649, 62);
    checkBoxAntialias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    checkBoxAntialias.Name = "checkBoxAntialias";
    checkBoxAntialias.Size = new System.Drawing.Size(15, 14);
    checkBoxAntialias.TabIndex = 10;
    checkBoxAntialias.UseVisualStyleBackColor = true;
    checkBoxAntialias.CheckedChanged += Preview_Changed;
    // 
    // label2
    // 
    label2.AutoSize = true;
    label2.Location = new System.Drawing.Point(249, 15);
    label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    label2.Name = "label2";
    label2.Size = new System.Drawing.Size(58, 15);
    label2.TabIndex = 2;
    label2.Text = "Font s&tyle";
    // 
    // label3
    // 
    label3.AutoSize = true;
    label3.Location = new System.Drawing.Point(363, 15);
    label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    label3.Name = "label3";
    label3.Size = new System.Drawing.Size(50, 15);
    label3.TabIndex = 4;
    label3.Text = "&Size (px)";
    // 
    // labelSampleText
    // 
    labelSampleText.AutoSize = true;
    labelSampleText.Location = new System.Drawing.Point(13, 355);
    labelSampleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    labelSampleText.Name = "labelSampleText";
    labelSampleText.Size = new System.Drawing.Size(46, 15);
    labelSampleText.TabIndex = 12;
    labelSampleText.Text = "Sample";
    // 
    // textBoxSampleText
    // 
    textBoxSampleText.AcceptsReturn = true;
    textBoxSampleText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    textBoxSampleText.Location = new System.Drawing.Point(18, 374);
    textBoxSampleText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    textBoxSampleText.Multiline = true;
    textBoxSampleText.Name = "textBoxSampleText";
    textBoxSampleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
    textBoxSampleText.Size = new System.Drawing.Size(686, 54);
    textBoxSampleText.TabIndex = 13;
    textBoxSampleText.TextChanged += Preview_Changed;
    // 
    // labelZoom
    // 
    labelZoom.AutoSize = true;
    labelZoom.Location = new System.Drawing.Point(18, 435);
    labelZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    labelZoom.Name = "labelZoom";
    labelZoom.Size = new System.Drawing.Size(39, 15);
    labelZoom.TabIndex = 14;
    labelZoom.Text = "&Zoom";
    // 
    // numericUpDownZoom
    // 
    numericUpDownZoom.Location = new System.Drawing.Point(65, 432);
    numericUpDownZoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    numericUpDownZoom.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
    numericUpDownZoom.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
    numericUpDownZoom.Name = "numericUpDownZoom";
    numericUpDownZoom.Size = new System.Drawing.Size(61, 23);
    numericUpDownZoom.TabIndex = 15;
    numericUpDownZoom.Value = new decimal(new int[] { 4, 0, 0, 0 });
    numericUpDownZoom.ValueChanged += Zoom_ValueChanged;
    // 
    // labelSpacing
    // 
    labelSpacing.AutoSize = true;
    labelSpacing.Location = new System.Drawing.Point(140, 435);
    labelSpacing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    labelSpacing.Name = "labelSpacing";
    labelSpacing.Size = new System.Drawing.Size(49, 15);
    labelSpacing.TabIndex = 16;
    labelSpacing.Text = "S&pacing";
    // 
    // numericUpDownSpacing
    // 
    numericUpDownSpacing.DecimalPlaces = 1;
    numericUpDownSpacing.Location = new System.Drawing.Point(200, 432);
    numericUpDownSpacing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    numericUpDownSpacing.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
    numericUpDownSpacing.Minimum = new decimal(new int[] { 64, 0, 0, int.MinValue });
    numericUpDownSpacing.Name = "numericUpDownSpacing";
    numericUpDownSpacing.Size = new System.Drawing.Size(70, 23);
    numericUpDownSpacing.TabIndex = 17;
    numericUpDownSpacing.ValueChanged += Preview_Changed;
    // 
    // labelLineSpacing
    // 
    labelLineSpacing.AutoSize = true;
    labelLineSpacing.Location = new System.Drawing.Point(289, 435);
    labelLineSpacing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    labelLineSpacing.Name = "labelLineSpacing";
    labelLineSpacing.Size = new System.Drawing.Size(73, 15);
    labelLineSpacing.TabIndex = 18;
    labelLineSpacing.Text = "&Line spacing";
    // 
    // numericUpDownLineSpacing
    // 
    numericUpDownLineSpacing.Location = new System.Drawing.Point(376, 432);
    numericUpDownLineSpacing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    numericUpDownLineSpacing.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
    numericUpDownLineSpacing.Name = "numericUpDownLineSpacing";
    numericUpDownLineSpacing.Size = new System.Drawing.Size(70, 23);
    numericUpDownLineSpacing.TabIndex = 19;
    numericUpDownLineSpacing.ValueChanged += Preview_Changed;
    // 
    // labelPadding
    // 
    labelPadding.AutoSize = true;
    labelPadding.Location = new System.Drawing.Point(557, 37);
    labelPadding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    labelPadding.Name = "labelPadding";
    labelPadding.Size = new System.Drawing.Size(74, 15);
    labelPadding.TabIndex = 42;
    labelPadding.Text = "Pa&dding (px)";
    // 
    // numericUpDownPadding
    // 
    numericUpDownPadding.Location = new System.Drawing.Point(649, 34);
    numericUpDownPadding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    numericUpDownPadding.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
    numericUpDownPadding.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
    numericUpDownPadding.Name = "numericUpDownPadding";
    numericUpDownPadding.Size = new System.Drawing.Size(61, 23);
    numericUpDownPadding.TabIndex = 43;
    numericUpDownPadding.Value = new decimal(new int[] { 8, 0, 0, 0 });
    // 
    // pixelPreview
    // 
    pixelPreview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    pixelPreview.AutoScroll = true;
    pixelPreview.BackColor = System.Drawing.Color.Magenta;
    pixelPreview.GridColor = System.Drawing.Color.FromArgb(48, 0, 0, 0);
    pixelPreview.Location = new System.Drawing.Point(18, 460);
    pixelPreview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    pixelPreview.Name = "pixelPreview";
    pixelPreview.PixelBorderColor = System.Drawing.Color.FromArgb(48, 0, 0, 0);
    pixelPreview.Size = new System.Drawing.Size(685, 189);
    pixelPreview.TabIndex = 20;
    // 
    // Export
    // 
    Export.Location = new System.Drawing.Point(460, 235);
    Export.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    Export.Name = "Export";
    Export.Size = new System.Drawing.Size(88, 27);
    Export.TabIndex = 11;
    Export.Text = "&Export";
    Export.UseVisualStyleBackColor = true;
    Export.Click += ButtonExport_Click;
    // 
    // label5
    // 
    label5.AutoSize = true;
    label5.Location = new System.Drawing.Point(13, 15);
    label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    label5.Name = "label5";
    label5.Size = new System.Drawing.Size(31, 15);
    label5.TabIndex = 0;
    label5.Text = "&Font";
    // 
    // label6
    // 
    label6.AutoSize = true;
    label6.Location = new System.Drawing.Point(9, 49);
    label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    label6.Name = "label6";
    label6.Size = new System.Drawing.Size(27, 15);
    label6.TabIndex = 14;
    label6.Text = "Size";
    // 
    // label7
    // 
    label7.AutoSize = true;
    label7.Location = new System.Drawing.Point(8, 51);
    label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    label7.Name = "label7";
    label7.Size = new System.Drawing.Size(39, 15);
    label7.TabIndex = 15;
    label7.Text = "Offset";
    // 
    // pictureBoxTextColor
    // 
    pictureBoxTextColor.BackColor = System.Drawing.Color.White;
    pictureBoxTextColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
    pictureBoxTextColor.Location = new System.Drawing.Point(325, 200);
    pictureBoxTextColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    pictureBoxTextColor.Name = "pictureBoxTextColor";
    pictureBoxTextColor.Size = new System.Drawing.Size(94, 24);
    pictureBoxTextColor.TabIndex = 41;
    pictureBoxTextColor.TabStop = false;
    pictureBoxTextColor.Click += PictureBoxTextColor_Click;
    // 
    // groupBox1
    // 
    groupBox1.Controls.Add(label6);
    groupBox1.Controls.Add(pictureBoxOutlineColor);
    groupBox1.Controls.Add(OutlineSize);
    groupBox1.Location = new System.Drawing.Point(427, 15);
    groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    groupBox1.Name = "groupBox1";
    groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
    groupBox1.Size = new System.Drawing.Size(119, 75);
    groupBox1.TabIndex = 19;
    groupBox1.TabStop = false;
    groupBox1.Text = "Outline";
    // 
    // pictureBoxOutlineColor
    // 
    pictureBoxOutlineColor.BackColor = System.Drawing.Color.Black;
    pictureBoxOutlineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
    pictureBoxOutlineColor.Location = new System.Drawing.Point(9, 19);
    pictureBoxOutlineColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    pictureBoxOutlineColor.Name = "pictureBoxOutlineColor";
    pictureBoxOutlineColor.Size = new System.Drawing.Size(103, 24);
    pictureBoxOutlineColor.TabIndex = 18;
    pictureBoxOutlineColor.TabStop = false;
    pictureBoxOutlineColor.Click += PictureBoxOutlineColor_Click;
    // 
    // OutlineSize
    // 
    OutlineSize.Location = new System.Drawing.Point(50, 44);
    OutlineSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    OutlineSize.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
    OutlineSize.Name = "OutlineSize";
    OutlineSize.Size = new System.Drawing.Size(61, 23);
    OutlineSize.TabIndex = 13;
    OutlineSize.ValueChanged += Preview_Changed;
    // 
    // groupBox2
    // 
    groupBox2.Controls.Add(AlphaAmount);
    groupBox2.Controls.Add(label8);
    groupBox2.Controls.Add(pictureBoxShadowColor);
    groupBox2.Controls.Add(label7);
    groupBox2.Controls.Add(ShadowOffset);
    groupBox2.Location = new System.Drawing.Point(429, 94);
    groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    groupBox2.Name = "groupBox2";
    groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
    groupBox2.Size = new System.Drawing.Size(118, 131);
    groupBox2.TabIndex = 20;
    groupBox2.TabStop = false;
    groupBox2.Text = "Shadow";
    // 
    // AlphaAmount
    // 
    AlphaAmount.Location = new System.Drawing.Point(57, 75);
    AlphaAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    AlphaAmount.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
    AlphaAmount.Name = "AlphaAmount";
    AlphaAmount.Size = new System.Drawing.Size(52, 23);
    AlphaAmount.TabIndex = 21;
    AlphaAmount.Value = new decimal(new int[] { 128, 0, 0, 0 });
    AlphaAmount.ValueChanged += Preview_Changed;
    // 
    // label8
    // 
    label8.AutoSize = true;
    label8.Location = new System.Drawing.Point(8, 77);
    label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    label8.Name = "label8";
    label8.Size = new System.Drawing.Size(38, 15);
    label8.TabIndex = 20;
    label8.Text = "Alpha";
    // 
    // pictureBoxShadowColor
    // 
    pictureBoxShadowColor.BackColor = System.Drawing.Color.Gray;
    pictureBoxShadowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
    pictureBoxShadowColor.Location = new System.Drawing.Point(9, 19);
    pictureBoxShadowColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    pictureBoxShadowColor.Name = "pictureBoxShadowColor";
    pictureBoxShadowColor.Size = new System.Drawing.Size(101, 24);
    pictureBoxShadowColor.TabIndex = 19;
    pictureBoxShadowColor.TabStop = false;
    pictureBoxShadowColor.Click += PictureBoxShadowColor_Click;
    // 
    // ShadowOffset
    // 
    ShadowOffset.Location = new System.Drawing.Point(57, 48);
    ShadowOffset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    ShadowOffset.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
    ShadowOffset.Name = "ShadowOffset";
    ShadowOffset.Size = new System.Drawing.Size(52, 23);
    ShadowOffset.TabIndex = 16;
    ShadowOffset.ValueChanged += Preview_Changed;
    // 
    // TextFilesListBox
    // 
    TextFilesListBox.AllowDrop = true;
    TextFilesListBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
    TextFilesListBox.FormattingEnabled = true;
    TextFilesListBox.ItemHeight = 15;
    TextFilesListBox.Location = new System.Drawing.Point(18, 269);
    TextFilesListBox.Margin = new System.Windows.Forms.Padding(2);
    TextFilesListBox.Name = "TextFilesListBox";
    TextFilesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
    TextFilesListBox.Size = new System.Drawing.Size(685, 79);
    TextFilesListBox.TabIndex = 36;
    TextFilesListBox.TabStop = false;
    // 
    // ChooseTextFilesButton
    // 
    ChooseTextFilesButton.Location = new System.Drawing.Point(18, 235);
    ChooseTextFilesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    ChooseTextFilesButton.Name = "ChooseTextFilesButton";
    ChooseTextFilesButton.Size = new System.Drawing.Size(128, 27);
    ChooseTextFilesButton.TabIndex = 37;
    ChooseTextFilesButton.Text = "Choose Text Files";
    ChooseTextFilesButton.UseVisualStyleBackColor = true;
    ChooseTextFilesButton.Click += ButtonChooseTextFiles_Click;
    // 
    // comboBoxFontSize
    // 
    comboBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
    comboBoxFontSize.FormattingEnabled = true;
    comboBoxFontSize.Items.AddRange(new object[] { "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "18", "20", "24", "32", "40", "48", "64", "96" });
    comboBoxFontSize.Location = new System.Drawing.Point(363, 34);
    comboBoxFontSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    comboBoxFontSize.Name = "comboBoxFontSize";
    comboBoxFontSize.Size = new System.Drawing.Size(56, 172);
    comboBoxFontSize.TabIndex = 5;
    comboBoxFontSize.Text = "8";
    comboBoxFontSize.SelectedIndexChanged += FontSize_SelectedIndexChanged;
    comboBoxFontSize.TextUpdate += FontSize_TextUpdate;
    // 
    // comboBoxFontStyle
    // 
    comboBoxFontStyle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
    comboBoxFontStyle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
    comboBoxFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
    comboBoxFontStyle.FormattingEnabled = true;
    comboBoxFontStyle.Items.AddRange(new object[] { "Regular", "Italic", "Bold", "Bold, Italic" });
    comboBoxFontStyle.Location = new System.Drawing.Point(254, 34);
    comboBoxFontStyle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    comboBoxFontStyle.Name = "comboBoxFontStyle";
    comboBoxFontStyle.Size = new System.Drawing.Size(93, 172);
    comboBoxFontStyle.TabIndex = 3;
    comboBoxFontStyle.Text = "Regular";
    comboBoxFontStyle.SelectedIndexChanged += FontStyle_SelectedIndexChanged;
    // 
    // comboBoxFontName
    // 
    comboBoxFontName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
    comboBoxFontName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
    comboBoxFontName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
    comboBoxFontName.FormattingEnabled = true;
    comboBoxFontName.Location = new System.Drawing.Point(18, 34);
    comboBoxFontName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    comboBoxFontName.Name = "comboBoxFontName";
    comboBoxFontName.Size = new System.Drawing.Size(220, 165);
    comboBoxFontName.TabIndex = 1;
    comboBoxFontName.SelectedIndexChanged += FontName_SelectedIndexChanged;
    // 
    // checkBoxExportDefault
    // 
    checkBoxExportDefault.AutoSize = true;
    checkBoxExportDefault.Location = new System.Drawing.Point(153, 240);
    checkBoxExportDefault.Name = "checkBoxExportDefault";
    checkBoxExportDefault.Size = new System.Drawing.Size(156, 19);
    checkBoxExportDefault.TabIndex = 38;
    checkBoxExportDefault.Text = "Export Default ( 32 .. 126)";
    checkBoxExportDefault.UseVisualStyleBackColor = true;
    checkBoxExportDefault.CheckedChanged += CheckBoxExportDefault_CheckedChanged;
    // 
    // buttonChooseFontFiles
    // 
    buttonChooseFontFiles.Location = new System.Drawing.Point(18, 200);
    buttonChooseFontFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    buttonChooseFontFiles.Name = "buttonChooseFontFiles";
    buttonChooseFontFiles.Size = new System.Drawing.Size(220, 27);
    buttonChooseFontFiles.TabIndex = 39;
    buttonChooseFontFiles.Text = "Choose Font Files";
    buttonChooseFontFiles.UseVisualStyleBackColor = true;
    buttonChooseFontFiles.Click += ButtonChooseFontFiles_Click;
    // 
    // label1
    // 
    label1.AutoSize = true;
    label1.Location = new System.Drawing.Point(249, 206);
    label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    label1.Name = "label1";
    label1.Size = new System.Drawing.Size(36, 15);
    label1.TabIndex = 41;
    label1.Text = "Color";
    // 
    // labelAntialiased
    // 
    labelAntialiased.AutoSize = true;
    labelAntialiased.Location = new System.Drawing.Point(557, 61);
    labelAntialiased.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
    labelAntialiased.Name = "labelAntialiased";
    labelAntialiased.Size = new System.Drawing.Size(65, 15);
    labelAntialiased.TabIndex = 44;
    labelAntialiased.Text = "&Antialiased";
    // 
    // MainForm
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    ClientSize = new System.Drawing.Size(722, 661);
    Controls.Add(labelAntialiased);
    Controls.Add(pictureBoxTextColor);
    Controls.Add(label1);
    Controls.Add(buttonChooseFontFiles);
    Controls.Add(checkBoxExportDefault);
    Controls.Add(ChooseTextFilesButton);
    Controls.Add(TextFilesListBox);
    Controls.Add(groupBox2);
    Controls.Add(groupBox1);
    Controls.Add(Export);
    Controls.Add(pixelPreview);
    Controls.Add(numericUpDownPadding);
    Controls.Add(labelPadding);
    Controls.Add(numericUpDownLineSpacing);
    Controls.Add(labelLineSpacing);
    Controls.Add(numericUpDownSpacing);
    Controls.Add(labelSpacing);
    Controls.Add(numericUpDownZoom);
    Controls.Add(labelZoom);
    Controls.Add(textBoxSampleText);
    Controls.Add(labelSampleText);
    Controls.Add(label3);
    Controls.Add(label2);
    Controls.Add(label5);
    Controls.Add(checkBoxAntialias);
    Controls.Add(comboBoxFontSize);
    Controls.Add(comboBoxFontStyle);
    Controls.Add(comboBoxFontName);
    Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    Name = "MainForm";
    Text = "Bitmap Font Textures";
    FormClosing += MainForm_FormClosing;
    ((System.ComponentModel.ISupportInitialize)numericUpDownZoom).EndInit();
    ((System.ComponentModel.ISupportInitialize)numericUpDownSpacing).EndInit();
    ((System.ComponentModel.ISupportInitialize)numericUpDownLineSpacing).EndInit();
    ((System.ComponentModel.ISupportInitialize)numericUpDownPadding).EndInit();
    ((System.ComponentModel.ISupportInitialize)pictureBoxTextColor).EndInit();
    groupBox1.ResumeLayout(false);
    groupBox1.PerformLayout();
    ((System.ComponentModel.ISupportInitialize)pictureBoxOutlineColor).EndInit();
    ((System.ComponentModel.ISupportInitialize)OutlineSize).EndInit();
    groupBox2.ResumeLayout(false);
    groupBox2.PerformLayout();
    ((System.ComponentModel.ISupportInitialize)AlphaAmount).EndInit();
    ((System.ComponentModel.ISupportInitialize)pictureBoxShadowColor).EndInit();
    ((System.ComponentModel.ISupportInitialize)ShadowOffset).EndInit();
    ResumeLayout(false);
    PerformLayout();

  }

  #endregion

  private System.Windows.Forms.ComboBox comboBoxFontName;
  private System.Windows.Forms.ComboBox comboBoxFontStyle;
  private System.Windows.Forms.ComboBox comboBoxFontSize;
  private System.Windows.Forms.CheckBox checkBoxAntialias;
  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label labelSampleText;
  private System.Windows.Forms.TextBox textBoxSampleText;
  private System.Windows.Forms.Label labelZoom;
  private System.Windows.Forms.NumericUpDown numericUpDownZoom;
  private System.Windows.Forms.Label labelSpacing;
  private System.Windows.Forms.NumericUpDown numericUpDownSpacing;
  private System.Windows.Forms.Label labelLineSpacing;
  private System.Windows.Forms.NumericUpDown numericUpDownLineSpacing;
  private System.Windows.Forms.Label labelPadding;
  private System.Windows.Forms.NumericUpDown numericUpDownPadding;
  private PixelPreview pixelPreview;
  private System.Windows.Forms.Button Export;
  private System.Windows.Forms.Label label5;
  private System.Windows.Forms.NumericUpDown OutlineSize;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.NumericUpDown ShadowOffset;
  private System.Windows.Forms.ColorDialog colorDialog;
  private System.Windows.Forms.PictureBox pictureBoxOutlineColor;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.GroupBox groupBox2;
  private System.Windows.Forms.PictureBox pictureBoxShadowColor;
  private System.Windows.Forms.NumericUpDown AlphaAmount;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.ListBox TextFilesListBox;
  private System.Windows.Forms.Button ChooseTextFilesButton;
  private System.Windows.Forms.CheckBox checkBoxExportDefault;
  private System.Windows.Forms.Button buttonChooseFontFiles;
  private System.Windows.Forms.PictureBox pictureBoxTextColor;
  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.Label labelAntialiased;
}
