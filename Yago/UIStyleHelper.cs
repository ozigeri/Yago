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

        public static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = AccentColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 10F);
            btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 15, 15));

            btn.MouseEnter += (s, e) => btn.BackColor = HoverAccentColor;
            btn.MouseLeave += (s, e) => btn.BackColor = AccentColor;
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
    }
}

