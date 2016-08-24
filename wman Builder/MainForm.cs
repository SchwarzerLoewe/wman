using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using wman.Core;

namespace wman_Builder
{
    public partial class MainForm : RadForm
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (var radItem in packageContextMenu.Items)
            {
                radItem.Click += RadItem_Click;
            }
        }

        private void RadItem_Click(object sender, System.EventArgs e)
        {
            if (sender == newFuncContextItem)
            {
                var name = Microsoft.VisualBasic.Interaction.InputBox("Please name your func");

                var m = new Man();
                var it = new PageItem
                {
                    Name = "cout",
                    Description = "Write something to console",
                    Example = "std::cout << \"main function\" << std::endl;",
                    SeeAlso = "http://en.cppreference.com/w/cpp/io/cout"
                };

                it.Properties.Add("Namespace", "std");

                m.Items.Add(it);
                //m.Save("cpp.wman");
            }
        }

        private void openMenuItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var l = wman.Core.Man.Load(openFileDialog1.FileName);

                
            }
        }
    }
}