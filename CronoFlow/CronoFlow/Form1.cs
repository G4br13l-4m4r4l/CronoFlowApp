using FontAwesome.Sharp;
using System.Runtime.InteropServices;
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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/Gabriel/Desktop/WorkCode/ProjectsApart/portfolio/pomoApp/CronoFlowApp/CronoFlow/CronoFlow/Images/logo_img.png");
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(128, 128, 128);
                currentBtn.IconColor = Color.PaleGreen;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            titleChildForm.Text = "Home";
            iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.House;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
