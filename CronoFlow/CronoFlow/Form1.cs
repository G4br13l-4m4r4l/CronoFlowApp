using FontAwesome.Sharp;
using System.Windows.Forms;
namespace CronoFlow
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelSideMenu.Controls.Add(leftBorderBtn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarGifDeUrl();
        }
        private async void CarregarGifDeUrl()
        {
            //pictureBox1.Image = Image.FromFile(".\\Images\\tmnt.gif");
        }
        private void ActivateButton(object SendBtn, Color color)
        {
            if (SendBtn != null)
            {

                DisableBtn();
                //botão selecionado
                currentBtn = (IconButton)SendBtn;
                currentBtn.BackColor = color;
                currentBtn.ForeColor = Color.FromArgb(0, 255, 127);
                currentBtn.IconColor = Color.FromArgb(0, 255, 127);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //borda Btn
                leftBorderBtn.BackColor = Color.FromArgb(0, 255, 127);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Titulo
                iconCurrentChild.IconChar = currentBtn.IconChar;
                titleChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(128, 128, 128);
                currentBtn.ForeColor = Color.PaleGreen;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(64, 64, 64));
        }

        private void ProgressBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(64, 64, 64));
        }

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(64, 64, 64));
        }
    }
}
