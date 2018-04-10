using System.ComponentModel;
using System.Windows.Forms;

namespace AdminClient.Components
{
    public partial class RexaLabel : Label
    {
        public RexaLabel()
        {
            InitializeComponent();
        }

        public RexaLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
