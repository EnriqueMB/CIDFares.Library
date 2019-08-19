using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIDFares.Library.Controls.CIDWait.Forms
{
    public partial class FrmWait : Form
    {
        public Func<Task> Proceso { get; set; }
        public AggregateException Exceptions { get; set; }

        public FrmWait(Func<Task> _Proceso, string _Mensaje)
        {
            InitializeComponent();
            lblMessage.Text = _Mensaje;
            Proceso = _Proceso;
            Exceptions = new AggregateException();
        }
  
        private async void FrmEspere_Load(object sender, EventArgs e)
        {
            await Proceso.Invoke();
            this.DialogResult = DialogResult.OK;
        }
    }
}