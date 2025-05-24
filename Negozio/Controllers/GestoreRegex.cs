using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Negozio.Controllers
{
    internal class GestoreRegex
    {
        public bool RegexMatch(string valore, string pattern)
        {
            Regex regex = new Regex(pattern);
            return (regex.IsMatch(valore));
        }
        public void RegexNome(Guna2TextBox txt)
        {
            string pattern = @"^[a-zA-Z ']{2,}$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
        public void RegexCognome(Guna2TextBox txt)
        {
            string pattern = @"^[a-zA-Z ']{2,}$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
        internal void RegexEmail(Guna2TextBox txt)
        {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.[a-zA-Z]{2,}$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
        internal void RegexUsername(Guna2TextBox txt)
        {
            string pattern = @"^[a-zA-Z0-9_]{4,20}$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
        internal void RegexPassword(Guna2TextBox txt)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
        internal void RegexIndirizzo(Guna2TextBox txt)
        {
            string pattern = @"^[A-Za-zÀ-ÿ\s'\.\-]+ \d+[A-Za-z]?(, [A-Za-zÀ-ÿ'\.\- ]+)?$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
        internal void RegexTipologia(Guna2TextBox txt)
        {
            string pattern = @"^[A-Za-zÀ-ÿ0-9,\'\-&\s]{2,}$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
        internal void RegexTelefono(Guna2TextBox txt)
        {
            string pattern = @"^\d{10}$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
        internal void RegexAzienda(Guna2TextBox txt)
        {
            string pattern = @"^[\p{L}\p{N}\p{P}\p{S} ]{2,}$";
            if (RegexMatch(txt.Text, pattern))
                txt.FillColor = Color.LightGreen;
            else if (txt.Text.Trim().Length == 0)
                txt.FillColor = Color.White;
            else
                txt.FillColor = Color.Red;
        }
    }
}
