using System.Collections;
using System.Windows.Forms;

namespace SystemDevelop.Model
{
    class Controller
    {
        public static Control[] GetAllControls(Control top)
        {
            ArrayList buf = new ArrayList();
            foreach (Control c in top.Controls)
            {
                if (c.GetType().ToString().Contains("UserControl")) buf.Add(c);
            }
            return (Control[])buf.ToArray(typeof(Control));
        }
    }
}
