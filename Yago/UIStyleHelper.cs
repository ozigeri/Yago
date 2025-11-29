using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yago
{
    public static class UIStyleHelpers
    {
        public enum ButtonType
        {
            Normal,
            OK,
            Delete
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        public static Color AccentColor = Color.FromArgb(66, 133, 244);
        public static Color HoverAccentColor = Color.FromArgb(90, 160, 255);

        public static void ApplyFormStyle(Form form)
        {
            form.Text = "Environment Builder";
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = true;
            form.MinimizeBox = true;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BackColor = Color.FromArgb(245, 245, 245);
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            form.Paint += (s, e) =>
            {
                using (GraphicsPath path = RoundedRect(new Rectangle(0, 0, form.Width - 1, form.Height - 1), 20))
                using (Pen pen = new Pen(Color.FromArgb(220, 220, 220)))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }
        public static void StyleButton(Button btn, ButtonType type = ButtonType.Normal)
        {
            Color baseColor;
            Color hoverColor;

            switch (type)
            {
                case ButtonType.OK:
                    baseColor = Color.FromArgb(68, 178, 110);
                    break;
                case ButtonType.Delete:
                    baseColor = Color.FromArgb(220, 53, 69);
                    break;
                case ButtonType.Normal:
                default:
                    baseColor = Color.FromArgb(47, 184, 202);
                    break;
            }

            hoverColor = ControlPaint.Light(baseColor);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = baseColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 10F);

            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 15, 15));

            btn.MouseEnter -= (s, e) => { };
            btn.MouseLeave -= (s, e) => { };

            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = baseColor;
        }

        public static void StyleComboBox(ComboBox combo)
        {
            combo.FlatStyle = FlatStyle.Flat;
            combo.BackColor = Color.White;
            combo.ForeColor = Color.Black;
            combo.Font = new Font("Segoe UI", 10F);

            Panel wrapper = new Panel
            {
                BackColor = Color.Black,
                Size = new Size(combo.Width + 2, combo.Height + 2),
                Location = new Point(combo.Left - 1, combo.Top - 1),
                Padding = new Padding(1),
            };

            combo.Parent.Controls.Add(wrapper);
            wrapper.BringToFront();
            combo.Parent.Controls.Remove(combo);
            combo.Location = new Point(1, 1);
            wrapper.Controls.Add(combo);
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
            txt.Font = new Font("Segoe UI", 10F);
            txt.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(Pens.Black, 0, 0, txt.Width - 1, txt.Height - 1);
            };
        }

        public static void StyleLabel(Label lbl)
        {
            lbl.Font = new Font("Segoe UI Semibold", 10F);
            lbl.ForeColor = Color.Black;
        }

        private static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static void ApplyRoundedGridButtonStyle(DataGridView grid, string columnName)
        {
            Color baseColor = Color.FromArgb(47, 184, 202);
            Color hoverColor = ControlPaint.Light(baseColor);

            int radius = 4;

            grid.CellPainting += (s, e) =>
            {
                if (e.ColumnIndex >= 0 &&
                    e.RowIndex >= 0 &&
                    grid.Columns[e.ColumnIndex].Name == columnName)
                {
                    e.Handled = true;
                    e.PaintBackground(e.ClipBounds, true);

                    bool hovered = grid[e.ColumnIndex, e.RowIndex].Selected;
                    Color fillColor = hovered ? hoverColor : baseColor;

                    Rectangle rect = e.CellBounds;
                    rect.Inflate(-2, -2);

                    using (GraphicsPath path = RoundedRect(rect, radius))
                    using (SolidBrush brush = new SolidBrush(fillColor))
                    using (StringFormat sf = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    })
                    {
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                        e.Graphics.FillPath(brush, path);

                        e.Graphics.DrawString(
                            grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(),
                            new Font("Segoe UI Semibold", 10F),
                            Brushes.White,
                            rect,
                            sf
                        );
                    }
                }
            };
        }
    }
}

