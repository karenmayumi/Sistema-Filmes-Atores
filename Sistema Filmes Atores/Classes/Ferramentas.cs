using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Filmes_Atores.Classes
{
    public static class Ferramentas
    {
        public static bool VerificarCamposPreenchidos(Control[] Campos)
        {
            return Campos.All(campo =>
                (campo is TextBox textBox && !string.IsNullOrEmpty(textBox.Text)) ||  
                (campo is NumericUpDown numericUpDown && numericUpDown.Value != 0) ||  
                (campo is Label label && (int.TryParse(label.Text, out _) || double.TryParse(label.Text, out _))));
        }
    }
}
