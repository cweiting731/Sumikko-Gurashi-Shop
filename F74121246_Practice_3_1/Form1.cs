using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74121246_Practice_3_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 700);
            LoadFrontPage();
        }

        private void LoadFrontPage()
        {
            this.Controls.Clear();
            FrontPage frontPage = new FrontPage();
            frontPage.Dock = DockStyle.Fill;

            frontPage.OnOpenShopClicked += FrontPage_OpenShopClick;

            this.Controls.Add(frontPage);
        }

        private void FrontPage_OpenShopClick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            SignInPage signInPage = new SignInPage();
            signInPage.Dock = DockStyle.Fill;

            signInPage.OnChangeToMainPage += SignInPage_ChangeToMainPage;

            this.Controls.Add(signInPage);
        }

        private void SignInPage_ChangeToMainPage(object sender, EventArgs e)
        {
            this.Controls.Clear();
            MainPage mainPage = new MainPage();
            mainPage.Dock = DockStyle.Fill;
            this.Controls.Add(mainPage);
        }
    }
}
