using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmMate1
{
    
    public partial class frmMainMenu : Form
    {
        // Fields daw tawag dito, alamin ko mamaya
        private Button currentButton;
        private int tempIndex;
        private Form activeForm;

        // Constructor ito
        public frmMainMenu()
        {
            InitializeComponent();
        }

        //Methods tawag dito // nasa loob ng Constructor
        private Color SelectThemeColor()
        {
            string color = "#9ACD32"; // Replace with the desired color code
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;                    
                }
            }
        }

        private void DisableButton() 
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton is Button btn) 
                {             
                    btn.BackColor = Color.FromArgb(107, 142, 35);
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                currentButton = null;
            }
        }

        private void OpenChildForm(Form childForm, object btnSender) 
        {
            if (activeForm != null) 
            { activeForm.Close(); }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktoPane.Controls.Add(childForm);
            this.panelDesktoPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHOME.Text = childForm.Text;
        }

        private void btnFacilities_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFacilities(), sender);
        }

        private void btnCrops_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmCrops(), sender);
        }

        private void btnLiveStocks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLiveStocks(), sender);
        }

        private void btnEqmtAndMchn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEquipmentAndMachineries(), sender);
        }

        private void btnInvtrAndSupp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmInventoryAndSupplies(), sender);
        }

        private void btnFncAndSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmFinanceAndSales(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender); // Disregard this for now
        }
    }
}
