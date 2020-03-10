using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Demodelegue
{
    public partial class CalculatriceForm : Form
    {
        public delegate int BinaryOp(int x, int y);
        BinaryOp b;

        // Pour réactualiser le code, ce projet pourrait être réécrit en WPF
        // Pas utile pour ce que l'on souhaite montrer ici, c'est à dire l'utilisation du délégué
        public CalculatriceForm()
        {
            InitializeComponent();
            NotificationLabel.Text = "";
            OperateurCB.SelectedIndex = (int)Operation.Plus;
            b = new BinaryOp(SimpleMath.Add);
        }
        
        private void OperateurCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(OperateurCB.SelectedIndex)
            {
                case (int)Operation.Plus: b = new BinaryOp(SimpleMath.Add); break;
                case (int)Operation.Moins: b = new BinaryOp(SimpleMath.Subtract); break;
                case (int)Operation.Fois: b = new BinaryOp(SimpleMath.Multiply); break;
                case (int)Operation.Divise: b = new BinaryOp(SimpleMath.Divide); break;
            }
        }

        private void CalculerButton_Click(object sender, EventArgs e)
        {
            try
            {
                NotificationLabel.Text = "";
                if (b != null)
                {
                    int nombre1 = Convert.ToInt32(Nombre1TB.Text);
                    int nombre2 = Convert.ToInt32(Nombre2TB.Text);
                    // Appel de la méthode associée au délégué
                    ResultatTB.Text = (b(nombre1, nombre2)).ToString();
                }
            }
            catch (Exception exc)
            {
                NotificationLabel.Text = exc.Message;
            }
        }
    }
}
