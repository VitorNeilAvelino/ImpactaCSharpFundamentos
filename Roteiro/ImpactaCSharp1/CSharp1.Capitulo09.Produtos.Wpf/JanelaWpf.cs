using System.Windows;
using System.Windows.Media;

namespace Impacta.Apoio
{
    public static class JanelaWpf
    {
        public static void Limpar(DependencyObject painel)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(painel); i++)
            {
                System.Windows.Controls.TextBox txt = VisualTreeHelper.GetChild(painel, i) as System.Windows.Controls.TextBox;
                if (txt != null)
                {
                    txt.Text = string.Empty;
                }
            }
        }
    }
}