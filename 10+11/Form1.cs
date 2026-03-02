using _10_11.Memento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace _10_11
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap buf, copy_area;
        Point StartPoint, EndPoint, CurrentPoint;
        bool Draw, Copy;
        Pen pen = new Pen(Color.Black, 1);
        Brush brush = new SolidBrush(Color.White);
        History history = new History();
        int x = 0, y = 0, h = 140, w = 340;

        public Form1()
        {
            InitializeComponent();
            buf = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(buf);
            pictureBox1.Image = buf;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            cbPenStyle.SelectedIndex = 0;
            clearToolStripMenuItem_Click(this, new EventArgs());
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            tbLog.Text = string.Empty;
            Color temp = pBrushColor.BackColor;
            tbLog.AppendText($"Brush {temp.A} {temp.R} {temp.G} {temp.B}" + Environment.NewLine);
            temp = pPenColor.BackColor;
            tbLog.AppendText($"Pen {temp.A} {temp.R} {temp.G} {temp.B}" + Environment.NewLine);
            tbLog.AppendText($"PenWidth {hSB_PenWidth.Value}" + Environment.NewLine);
            tbLog.AppendText($"PenStyle {cbPenStyle.SelectedIndex}" + Environment.NewLine);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            history.SaveState(buf, tbLog.Text);
            StartPoint = e.Location;
            CurrentPoint = e.Location;
            Draw = true;

            if (SB_Pencil.Checked || SB_Rubber.Checked)
                Draw = true;
            else if (SB_ColorPick.Checked)
            {
                if (e.Button == MouseButtons.Left)
                    pPenColor.BackColor = buf.GetPixel(e.X, e.Y);
                else if (e.Button == MouseButtons.Right)
                    pBrushColor.BackColor = buf.GetPixel(e.X, e.Y);
            }
            else if(SB_Text.Checked)
            {
                textBox1.Visible = true;
                textBox1.Focus();
                textBox1.Left = e.X + pictureBox1.Left;
                textBox1.Top = e.Y + pictureBox1.Top;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            CurrentPoint = e.Location;

            if (Draw)
            {
                if (SB_Pencil.Checked)
                {
                    g.DrawLine(pen, StartPoint, e.Location);
                    StartPoint = e.Location;
                }
                else if (SB_Rubber.Checked)
                {
                    g.FillRectangle(Brushes.White, e.X, e.Y, pen.Width, pen.Width);
                }
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (SB_Copy.Checked)
            {
                EndPoint = e.Location;
            }
            if (!Draw) return;
            if (SB_Line.Checked)
            {
                g.DrawLine(pen, StartPoint, e.Location);
                tbLog.AppendText($"DrawLine {StartPoint.X} {StartPoint.Y} {e.X} {e.Y}" + Environment.NewLine);
            }
            else if (SB_Ellipse.Checked)
            {
                int x = Math.Min(StartPoint.X, e.X);
                int y = Math.Min(StartPoint.Y, e.Y);
                int w = Math.Abs(StartPoint.X - e.X);
                int h = Math.Abs(StartPoint.Y - e.Y);

                if (SB_FillColor.Checked)
                {
                    g.FillEllipse(brush, x, y, w, h);
                    tbLog.AppendText($"FillEllipse {x} {y} {w} {h}" + Environment.NewLine);
                }
                g.DrawEllipse(pen, x, y, w, h);
                tbLog.AppendText($"Ellipse {x} {y} {w} {h}" + Environment.NewLine);
            }

            Draw = false;
            pictureBox1.Invalidate();
        }

        private void hSB_PenWidht_Scroll(object sender, ScrollEventArgs e)
        {
            pen.Width = hSB_PenWidth.Value;
            lPWidth.Text = hSB_PenWidth.Value.ToString();
            tbLog.AppendText($"PenWidth {hSB_PenWidth.Value}" + Environment.NewLine);
        }

        private void pPenColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pPenColor.BackColor = colorDialog1.Color;
            }
        }

        private void pBrushColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBrushColor.BackColor = colorDialog1.Color;
            }
        }

        private void cbPenStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.DashStyle = (System.Drawing.Drawing2D.DashStyle)cbPenStyle.SelectedIndex;
            tbLog.AppendText($"PenStyle {cbPenStyle.SelectedIndex}" + Environment.NewLine);
        }

        private void pPenColor_Paint(object sender, PaintEventArgs e)
        {
            pen.Color = pPenColor.BackColor;
            Color temp = pPenColor.BackColor;
            tbLog.AppendText($"Pen {temp.A} {temp.R} {temp.G} {temp.B}" + Environment.NewLine);
        }

        private void pBrushColor_Paint(object sender, PaintEventArgs e)
        {
            brush = new SolidBrush(pBrushColor.BackColor);
            Color temp = pBrushColor.BackColor;
            tbLog.AppendText($"Brush {temp.A} {temp.R} {temp.G} {temp.B}" + Environment.NewLine);
        }

        private void sacToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                File.WriteAllLines(saveFileDialog1.FileName, tbLog.Lines);
        }

        private void loadVctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tbLog.Text = string.Empty;
                tbLog.Lines = File.ReadAllLines(openFileDialog1.FileName);
                foreach (string line in tbLog.Lines)
                {
                    string[] parts = line.Split(' ');
                    if (parts.Length == 0) continue;
                    string command = parts[0];
                    int[] args = parts.Skip(1).Select(int.Parse).ToArray();

                    switch (command)
                    {
                        case "DrawLine":
                            g.DrawLine(pen, args[0], args[1], args[2], args[3]);
                            break;

                        case "Rubber":
                            g.FillRectangle(Brushes.White, args[0], args[1], args[2], args[3]);
                            break;
                        case "Pen":
                            pen.Color = Color.FromArgb(args[0], args[1], args[2], args[3]);
                            break;

                        case "Brush":
                            brush = new SolidBrush(Color.FromArgb(args[0], args[1], args[2], args[3]));
                            break;

                        case "PenWidth":
                            pen.Width = args[0];
                            break;

                        case "PenStyle":
                            pen.DashStyle = (System.Drawing.Drawing2D.DashStyle)args[0];
                            break;

                        case "Ellipse":
                            g.DrawEllipse(pen, args[0], args[1], args[2], args[3]);
                            break;

                        case "FillEllipse":
                            g.FillEllipse(brush, args[0], args[1], args[2], args[3]);
                            break;

                        case "Paste":
                            g.DrawImage(copy_area, args[0], args[1]);
                            break;

                        case "CopyRect":
                            Rectangle copy = new Rectangle(args[0], args[1], args[2], args[3]);
                            copy_area = BitmapCopy.CopyArea(buf, copy);
                            break;

                        default:
                            break;
                    }
                }
            }   
        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Width = (int)(textBox1.Text.Length * textBox1.Font.Size + 30);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
        private void SB_Picture_Click(object sender, EventArgs e)
        {
            if (SB_Picture.Checked)
            {
                PrintImage(x, y, w, h);
                pictureBox1.Refresh();
            }
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w += 34;
            h += 14;
            SB_Picture_Click(sender, e);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Draw)
            {
                if (SB_Line.Checked)
                {
                    e.Graphics.DrawLine(pen, StartPoint, CurrentPoint);
                }
                else if (SB_Ellipse.Checked)
                {
                    int x = Math.Min(StartPoint.X, CurrentPoint.X);
                    int y = Math.Min(StartPoint.Y, CurrentPoint.Y);
                    int w = Math.Abs(StartPoint.X - CurrentPoint.X);
                    int h = Math.Abs(StartPoint.Y - CurrentPoint.Y);

                    if (SB_FillColor.Checked)
                        e.Graphics.FillEllipse(brush, x, y, w, h);

                    e.Graphics.DrawEllipse(pen, x, y, w, h);
                }
                else if (SB_Copy.Checked)
                {
                    using (Pen selectionPen = new Pen(Color.Gray))
                    {
                        selectionPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                        int x = Math.Min(StartPoint.X, CurrentPoint.X);
                        int y = Math.Min(StartPoint.Y, CurrentPoint.Y);
                        int w = Math.Abs(StartPoint.X - CurrentPoint.X);
                        int h = Math.Abs(StartPoint.Y - CurrentPoint.Y);

                        e.Graphics.DrawRectangle(selectionPen, x, y, w, h);
                    }
                }
            }
        }

        private void scaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            w -= 34;
            h -= 14;
            SB_Picture_Click(sender, e);
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);

            int width = Math.Abs(StartPoint.X - EndPoint.X);
            int height = Math.Abs(StartPoint.Y - EndPoint.Y);

            if (width > 0 && height > 0)
            {
                Rectangle copyRect = new Rectangle(x, y, width, height);
                copy_area = BitmapCopy.CopyArea(buf, copyRect);

                if (copy_area != null)
                {
                    Copy = true;
                    tbLog.AppendText($"CopyRect {x} {y} {width} {height}" + Environment.NewLine);
                }
            }
            else
            {
                Copy = false;
                MessageBox.Show("Виділіть область для копіювання!");
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageMemento memento = history.Undo();
            if (memento != null)
            {
                buf = new Bitmap(memento.State);
                g = Graphics.FromImage(buf);
                memento.State.Dispose();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                pictureBox1.Image = buf;
                tbLog.Text = memento.LogState;
                pictureBox1.Refresh();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Copy)
            {
                g.DrawImage(copy_area, StartPoint);
                tbLog.AppendText($"Paste {StartPoint.X} {StartPoint.Y}" + Environment.NewLine);
                pictureBox1.Refresh();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle copy = new Rectangle(StartPoint.X, StartPoint.Y, EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
            copy_area = BitmapCopy.CopyArea(buf, copy);
            if (copy_area != null)
            {
                Copy = true;
                tbLog.AppendText($"CopyRect {StartPoint.X} {StartPoint.Y} {EndPoint.X - StartPoint.X} {EndPoint.Y - StartPoint.Y}");
            }
            else
            {
                Copy = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                g.DrawString(textBox1.Text, textBox1.Font, brush, StartPoint);
                textBox1.Visible = false;
                textBox1.Text = string.Empty;
            }
        }
        public void PrintImage(int x, int y, int w, int h)
        {
            g.Clear(Color.White);
            float dx = w / 32.0f;
            float dy = h / 14.0f;

            // Big ellipse
            g.DrawEllipse(pen, x, y + 10 * dy, 30 * dx, 4 * dy);

            // Small ellipse
            g.DrawEllipse(pen, x + 11 * dx, y + 11.4f * dy, 7 * dx, 1.6f * dy);

            // Left big arc
            g.DrawArc(pen, x + 2 * dx, y - 1.6f * dy, 14.5f * dx, 9.4f * dy, 88, 123);
            // Left small arc
            g.DrawArc(pen, x + 5.8f * dx, y + 1.64f * dy, 6.36f * dx, 4.66f * dy, 90, 155);

            // Left small arc
            g.DrawArc(pen, x + 23.22f * dx, y + 1.7f * dy, 5.64f * dx, 4.75f * dy, -99, 191);
            // Left big arc
            g.DrawArc(pen, x + 17.1f * dx, y - 0.44f * dy, 14.62f * dx, 8.38f * dy, -50, 134);

            PointF[] points1 = new PointF[]
            {
            new PointF(x + 9.4f * dx, y + 7.8f * dy),
            new PointF(x + 13 * dx, y + 7.8f * dy),
            new PointF(x + 12 * dx, y + 2.4f * dy),
            new PointF(x + 9 * dx, y + 2.4f * dy),
            new PointF(x + 10 * dx, y + 6.4f * dy),
            new PointF(x + 8 * dx, y + 6.2f * dy)
            };
            g.DrawLines(pen, points1);

            PointF[] points2 = new PointF[]
            {
            new PointF(x + 8 * dx, y + 1.7f * dy),
            new PointF(x + 12.5f * dx, y + 1.7f * dy),
            new PointF(x + 15 * dx, y + 9 * dy),
            new PointF(x + 22 * dx, y + 1.7f * dy),
            new PointF(x + 26 * dx, y + 1.7f * dy)
            };

            g.DrawLines(pen, points2);

            PointF[] points3 = new PointF[]
            {
            new PointF(x + 26 * dx, y + 6.45f * dy),
            new PointF(x + 23.8f * dx, y + 6.45f * dy),
            new PointF(x + 24.7f * dx, y + 2.5f * dy),
            new PointF(x + 22 * dx, y + 2.5f * dy),
            new PointF(x + 20.4f * dx, y + 7.9f * dy),
            new PointF(x + 25.0f * dx, y + 7.9f * dy)
            };

            g.DrawLines(pen, points3);

            PointF[] points4 = new PointF[]
            {
            new PointF(x + 27.8f * dx, y),
            new PointF(x + 20.0f * dx, y),
            new PointF(x + 16.0f * dx, y + 5.0f * dy),
            new PointF(x + 14.2f * dx, y),
            new PointF(x + 3.9f * dx, y)
            };
            g.DrawLines(pen, points4);
            //g.DrawRectangle(pen,x, y, w, h);
        }
    }
}
