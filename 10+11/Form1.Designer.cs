namespace _10_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pTools = new System.Windows.Forms.Panel();
            this.SB_FillColor = new System.Windows.Forms.CheckBox();
            this.cbPenStyle = new System.Windows.Forms.ComboBox();
            this.lbBrushColor = new System.Windows.Forms.Label();
            this.lbPenColor = new System.Windows.Forms.Label();
            this.pBrushColor = new System.Windows.Forms.Panel();
            this.pPenColor = new System.Windows.Forms.Panel();
            this.lPWidth = new System.Windows.Forms.Label();
            this.hSB_PenWidth = new System.Windows.Forms.HScrollBar();
            this.SB_Picture = new System.Windows.Forms.RadioButton();
            this.SB_Copy = new System.Windows.Forms.RadioButton();
            this.SB_Text = new System.Windows.Forms.RadioButton();
            this.TextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SB_ColorPick = new System.Windows.Forms.RadioButton();
            this.SB_Rubber = new System.Windows.Forms.RadioButton();
            this.SB_Ellipse = new System.Windows.Forms.RadioButton();
            this.SB_Line = new System.Windows.Forms.RadioButton();
            this.SB_Pencil = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadVctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pTools.SuspendLayout();
            this.TextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pTools
            // 
            this.pTools.Controls.Add(this.SB_FillColor);
            this.pTools.Controls.Add(this.cbPenStyle);
            this.pTools.Controls.Add(this.lbBrushColor);
            this.pTools.Controls.Add(this.lbPenColor);
            this.pTools.Controls.Add(this.pBrushColor);
            this.pTools.Controls.Add(this.pPenColor);
            this.pTools.Controls.Add(this.lPWidth);
            this.pTools.Controls.Add(this.hSB_PenWidth);
            this.pTools.Controls.Add(this.SB_Picture);
            this.pTools.Controls.Add(this.SB_Copy);
            this.pTools.Controls.Add(this.SB_Text);
            this.pTools.Controls.Add(this.SB_ColorPick);
            this.pTools.Controls.Add(this.SB_Rubber);
            this.pTools.Controls.Add(this.SB_Ellipse);
            this.pTools.Controls.Add(this.SB_Line);
            this.pTools.Controls.Add(this.SB_Pencil);
            this.pTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.pTools.Location = new System.Drawing.Point(0, 24);
            this.pTools.Name = "pTools";
            this.pTools.Size = new System.Drawing.Size(1074, 60);
            this.pTools.TabIndex = 0;
            // 
            // SB_FillColor
            // 
            this.SB_FillColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_FillColor.AutoSize = true;
            this.SB_FillColor.Image = global::_10_11.Properties.Resources.Designcontest_Outline_Paint_32;
            this.SB_FillColor.Location = new System.Drawing.Point(232, 10);
            this.SB_FillColor.Name = "SB_FillColor";
            this.SB_FillColor.Size = new System.Drawing.Size(38, 38);
            this.SB_FillColor.TabIndex = 15;
            this.SB_FillColor.UseVisualStyleBackColor = true;
            // 
            // cbPenStyle
            // 
            this.cbPenStyle.FormattingEnabled = true;
            this.cbPenStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.cbPenStyle.Location = new System.Drawing.Point(853, 21);
            this.cbPenStyle.Name = "cbPenStyle";
            this.cbPenStyle.Size = new System.Drawing.Size(83, 21);
            this.cbPenStyle.TabIndex = 4;
            this.cbPenStyle.TabStop = false;
            this.cbPenStyle.SelectedIndexChanged += new System.EventHandler(this.cbPenStyle_SelectedIndexChanged);
            // 
            // lbBrushColor
            // 
            this.lbBrushColor.AutoSize = true;
            this.lbBrushColor.Location = new System.Drawing.Point(712, 43);
            this.lbBrushColor.Name = "lbBrushColor";
            this.lbBrushColor.Size = new System.Drawing.Size(33, 13);
            this.lbBrushColor.TabIndex = 14;
            this.lbBrushColor.Text = "bursh";
            // 
            // lbPenColor
            // 
            this.lbPenColor.AutoSize = true;
            this.lbPenColor.Location = new System.Drawing.Point(671, 42);
            this.lbPenColor.Name = "lbPenColor";
            this.lbPenColor.Size = new System.Drawing.Size(25, 13);
            this.lbPenColor.TabIndex = 13;
            this.lbPenColor.Text = "pen";
            // 
            // pBrushColor
            // 
            this.pBrushColor.BackColor = System.Drawing.Color.White;
            this.pBrushColor.Location = new System.Drawing.Point(709, 3);
            this.pBrushColor.Name = "pBrushColor";
            this.pBrushColor.Size = new System.Drawing.Size(38, 38);
            this.pBrushColor.TabIndex = 12;
            this.pBrushColor.Click += new System.EventHandler(this.pBrushColor_Click);
            this.pBrushColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pBrushColor_Paint);
            // 
            // pPenColor
            // 
            this.pPenColor.BackColor = System.Drawing.Color.Black;
            this.pPenColor.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pPenColor.Location = new System.Drawing.Point(665, 3);
            this.pPenColor.Name = "pPenColor";
            this.pPenColor.Size = new System.Drawing.Size(38, 38);
            this.pPenColor.TabIndex = 11;
            this.pPenColor.Click += new System.EventHandler(this.pPenColor_Click);
            this.pPenColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pPenColor_Paint);
            // 
            // lPWidth
            // 
            this.lPWidth.AutoSize = true;
            this.lPWidth.Location = new System.Drawing.Point(790, 10);
            this.lPWidth.Name = "lPWidth";
            this.lPWidth.Size = new System.Drawing.Size(13, 13);
            this.lPWidth.TabIndex = 10;
            this.lPWidth.Text = "1";
            // 
            // hSB_PenWidth
            // 
            this.hSB_PenWidth.LargeChange = 1;
            this.hSB_PenWidth.Location = new System.Drawing.Point(759, 25);
            this.hSB_PenWidth.Maximum = 20;
            this.hSB_PenWidth.Minimum = 1;
            this.hSB_PenWidth.Name = "hSB_PenWidth";
            this.hSB_PenWidth.Size = new System.Drawing.Size(80, 17);
            this.hSB_PenWidth.TabIndex = 3;
            this.hSB_PenWidth.Value = 1;
            this.hSB_PenWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSB_PenWidht_Scroll);
            // 
            // SB_Picture
            // 
            this.SB_Picture.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_Picture.Image = global::_10_11.Properties.Resources.Iconsmind_Outline_Photo_32;
            this.SB_Picture.Location = new System.Drawing.Point(364, 10);
            this.SB_Picture.Name = "SB_Picture";
            this.SB_Picture.Size = new System.Drawing.Size(38, 38);
            this.SB_Picture.TabIndex = 9;
            this.SB_Picture.TabStop = true;
            this.SB_Picture.UseVisualStyleBackColor = true;
            this.SB_Picture.Click += new System.EventHandler(this.SB_Picture_Click);
            // 
            // SB_Copy
            // 
            this.SB_Copy.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_Copy.Image = global::_10_11.Properties.Resources.Iconoir_Team_Iconoir_3d_rect_three_pts_32;
            this.SB_Copy.Location = new System.Drawing.Point(320, 10);
            this.SB_Copy.Name = "SB_Copy";
            this.SB_Copy.Size = new System.Drawing.Size(38, 38);
            this.SB_Copy.TabIndex = 8;
            this.SB_Copy.TabStop = true;
            this.SB_Copy.UseVisualStyleBackColor = true;
            // 
            // SB_Text
            // 
            this.SB_Text.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_Text.ContextMenuStrip = this.TextMenu;
            this.SB_Text.Image = global::_10_11.Properties.Resources.Picol_Picol_Text_32;
            this.SB_Text.Location = new System.Drawing.Point(276, 10);
            this.SB_Text.Name = "SB_Text";
            this.SB_Text.Size = new System.Drawing.Size(38, 38);
            this.SB_Text.TabIndex = 7;
            this.SB_Text.TabStop = true;
            this.SB_Text.UseVisualStyleBackColor = true;
            // 
            // TextMenu
            // 
            this.TextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem});
            this.TextMenu.Name = "TextMenu";
            this.TextMenu.Size = new System.Drawing.Size(100, 26);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.styleToolStripMenuItem.Text = "Style";
            this.styleToolStripMenuItem.Click += new System.EventHandler(this.styleToolStripMenuItem_Click);
            // 
            // SB_ColorPick
            // 
            this.SB_ColorPick.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_ColorPick.Image = global::_10_11.Properties.Resources.Designcontest_Outline_Eyedropper_32;
            this.SB_ColorPick.Location = new System.Drawing.Point(188, 10);
            this.SB_ColorPick.Name = "SB_ColorPick";
            this.SB_ColorPick.Size = new System.Drawing.Size(38, 38);
            this.SB_ColorPick.TabIndex = 5;
            this.SB_ColorPick.TabStop = true;
            this.SB_ColorPick.UseVisualStyleBackColor = true;
            // 
            // SB_Rubber
            // 
            this.SB_Rubber.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_Rubber.Image = global::_10_11.Properties.Resources.Designcontest_Outline_Eraser_32;
            this.SB_Rubber.Location = new System.Drawing.Point(144, 10);
            this.SB_Rubber.Name = "SB_Rubber";
            this.SB_Rubber.Size = new System.Drawing.Size(38, 38);
            this.SB_Rubber.TabIndex = 4;
            this.SB_Rubber.TabStop = true;
            this.SB_Rubber.UseVisualStyleBackColor = true;
            // 
            // SB_Ellipse
            // 
            this.SB_Ellipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_Ellipse.Image = global::_10_11.Properties.Resources.Ionic_Ionicons_Ellipse_outline_32;
            this.SB_Ellipse.Location = new System.Drawing.Point(100, 10);
            this.SB_Ellipse.Name = "SB_Ellipse";
            this.SB_Ellipse.Size = new System.Drawing.Size(38, 38);
            this.SB_Ellipse.TabIndex = 3;
            this.SB_Ellipse.TabStop = true;
            this.SB_Ellipse.UseVisualStyleBackColor = true;
            // 
            // SB_Line
            // 
            this.SB_Line.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_Line.Image = global::_10_11.Properties.Resources.Icons8_Ios7_Editing_Line_32;
            this.SB_Line.Location = new System.Drawing.Point(56, 10);
            this.SB_Line.Name = "SB_Line";
            this.SB_Line.Size = new System.Drawing.Size(38, 38);
            this.SB_Line.TabIndex = 2;
            this.SB_Line.TabStop = true;
            this.SB_Line.UseVisualStyleBackColor = true;
            // 
            // SB_Pencil
            // 
            this.SB_Pencil.Appearance = System.Windows.Forms.Appearance.Button;
            this.SB_Pencil.AutoSize = true;
            this.SB_Pencil.Image = global::_10_11.Properties.Resources.icons8_pencil_32;
            this.SB_Pencil.Location = new System.Drawing.Point(12, 10);
            this.SB_Pencil.Name = "SB_Pencil";
            this.SB_Pencil.Size = new System.Drawing.Size(38, 38);
            this.SB_Pencil.TabIndex = 1;
            this.SB_Pencil.TabStop = true;
            this.SB_Pencil.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.sacToolStripMenuItem,
            this.loadVctorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // sacToolStripMenuItem
            // 
            this.sacToolStripMenuItem.Name = "sacToolStripMenuItem";
            this.sacToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sacToolStripMenuItem.Text = "Save vector";
            this.sacToolStripMenuItem.Click += new System.EventHandler(this.sacToolStripMenuItem_Click);
            // 
            // loadVctorToolStripMenuItem
            // 
            this.loadVctorToolStripMenuItem.Name = "loadVctorToolStripMenuItem";
            this.loadVctorToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadVctorToolStripMenuItem.Text = "Load vector";
            this.loadVctorToolStripMenuItem.Click += new System.EventHandler(this.loadVctorToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleToolStripMenuItem,
            this.scaleToolStripMenuItem1,
            this.moveToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dToolStripMenuItem.Text = "Picture";
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.scaleToolStripMenuItem.Text = "Scale +";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem1
            // 
            this.scaleToolStripMenuItem1.Name = "scaleToolStripMenuItem1";
            this.scaleToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.scaleToolStripMenuItem1.Text = "Scale -";
            this.scaleToolStripMenuItem1.Click += new System.EventHandler(this.scaleToolStripMenuItem1_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.CheckOnClick = true;
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1074, 572);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbLog.Location = new System.Drawing.Point(941, 84);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(133, 572);
            this.tbLog.TabIndex = 3;
            this.tbLog.WordWrap = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 656);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pTools);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pTools.ResumeLayout(false);
            this.pTools.PerformLayout();
            this.TextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTools;
        private System.Windows.Forms.RadioButton SB_Pencil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton SB_Line;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.RadioButton SB_Picture;
        private System.Windows.Forms.RadioButton SB_Copy;
        private System.Windows.Forms.RadioButton SB_Text;
        private System.Windows.Forms.RadioButton SB_ColorPick;
        private System.Windows.Forms.RadioButton SB_Rubber;
        private System.Windows.Forms.RadioButton SB_Ellipse;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.HScrollBar hSB_PenWidth;
        private System.Windows.Forms.Label lPWidth;
        private System.Windows.Forms.Label lbBrushColor;
        private System.Windows.Forms.Label lbPenColor;
        private System.Windows.Forms.Panel pBrushColor;
        private System.Windows.Forms.Panel pPenColor;
        private System.Windows.Forms.ComboBox cbPenStyle;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadVctorToolStripMenuItem;
        private System.Windows.Forms.CheckBox SB_FillColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip TextMenu;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
    }
}

