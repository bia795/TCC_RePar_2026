using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private bool isHovered = false;
    private bool isPressed = false;

    public RoundedButton()
    {
        // Garante que o botão redesenhe corretamente ao interagir com o mouse
        this.MouseEnter += (s, e) => { isHovered = true; this.Invalidate(); };
        this.MouseLeave += (s, e) => { isHovered = false; isPressed = false; this.Invalidate(); };
        this.MouseDown += (s, e) => { isPressed = true; this.Invalidate(); };
        this.MouseUp += (s, e) => { isPressed = false; this.Invalidate(); };
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        GraphicsPath graphicsPath = new GraphicsPath();
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

        int radius = 20; // Tamanho do arredondamento

        graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        graphicsPath.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
        graphicsPath.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
        graphicsPath.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
        graphicsPath.CloseFigure();

        this.Region = new Region(graphicsPath);

        // Define as variações de cores baseadas no RGB 119, 118, 166
        Color corNormal = Color.FromArgb(119, 118, 166);
        Color corHover = Color.FromArgb(139, 138, 186);  // Mais clara para o Hover
        Color corPressed = Color.FromArgb(99, 98, 146);   // Mais escura para o Clique

        // Escolhe a cor atual baseada no estado do mouse
        Color corAtual = corNormal;
        if (isPressed) corAtual = corPressed;
        else if (isHovered) corAtual = corHover;

        // Desenha o fundo do botão
        using (SolidBrush brush = new SolidBrush(corAtual))
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.FillPath(brush, graphicsPath);
        }

        // Desenha a borda acompanhando o estado
        using (Pen pen = new Pen(corAtual, 2))
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.DrawPath(pen, graphicsPath);
        }

        // Garante que o texto do botão apareça por cima do desenho personalizado
        TextRenderer.DrawText(
            pevent.Graphics,
            this.Text,
            this.Font,
            this.ClientRectangle,
            this.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );
    }
}
