using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.Controllers
{
    public class GestoreLoader
    {
        private Guna2CircleProgressBar loader;
        List<Control> controlliOriginali;
        public void MostraLoader(Control container)
        {
            controlliOriginali = new List<Control>(container.Controls.Cast<Control>());

            // Rimozione di tutti i controlli dal container (Form o UserControl)
            container.Controls.Clear();

            if (loader != null) return;

            // Creazione del loader
            loader = new Guna2CircleProgressBar
            {
                Size = new Size(150, 150),
                Location = new Point(
                    (container.ClientSize.Width - 150) / 2,
                    (container.ClientSize.Height - 150) / 2
                ),
                FillColor = Color.Black,
                ProgressColor = Color.Turquoise,
                ProgressColor2 = Color.DarkBlue,
                ProgressThickness = 10,
                BackColor = Color.Transparent,
                Animated = true,
                Name = "LoaderProgress",
                AnimationSpeed = 2,
                Value = 25
            };

            // Aggiunta loader al container (Form o UserControl)
            container.Controls.Add(loader);
            loader.BringToFront();
        }

        public void NascondiLoader(Control container)
        {
            if (loader == null) return;

            // Rimozione loader dal container
            loader.Parent.Controls.Remove(loader);
            loader.Dispose();
            loader = null;

            // Ripristino dei controlli originali
            foreach (var controllo in controlliOriginali)
            {
                container.Controls.Add(controllo);
            }
        }
    }


}
