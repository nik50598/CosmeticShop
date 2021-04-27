using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticShop
{
    public partial class Main : Form
    {

        public Model1 db = new Model1();
        public Product pr = new Product();

        int counter;

        public List<int> idList = new List<int>();

        List<PictureBox> mainImage = new List<PictureBox>();

        List<PictureBox> mainPanel = new List<PictureBox>();

        List<Label> name = new List<Label>();

        List<List<PictureBox>> checkList = new List<List<PictureBox>>();

        List<List<string>> allImageList = new List<List<string>>();

        public Main()
        {
            InitializeComponent();
            PanelCreation();
        }

        private void PanelCreation()
        {

            int stringNum = 0;
            int count = db.Product.Count();
            foreach (Product p in db.Product)
            {
                idList.Add(p.ID);
            }
            for (int f = 0; f < count; f++)
            {
                counter = 1;
                Product pr = db.Product.Find(idList[f]);

                List<string> imageList = new List<string>();
                foreach (ProductPhoto pp in db.ProductPhoto)
                {
                    if (pp.ProductID == idList[f])
                        imageList.Add(pp.PhotoPath);
                }
                allImageList.Add(imageList);
                counter += allImageList[f].Count;


                if (f / (3 * (stringNum + 1)) == 1)
                {
                    stringNum++;
                }
                PictureBox mainPn = new PictureBox()
                {
                    Size = new Size(200, 300),
                    Location = new Point(100 + (250 * (f - 3 * stringNum)), 50 + (Size.Height * stringNum / 5 * 3)),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };
                if (pr.IsActive == false)
                {
                    mainPn.BackColor = Color.LightGray;
                }

                mainPanel.Add(mainPn);
                panel2.Controls.Add(mainPanel[f]);


                Label text = new Label()
                {
                    Size = new Size(150, mainPanel[f].Height / 5),
                    Location = new Point(mainPanel[f].Location.X + ((mainPanel[f].Width - 150) / 2), (mainPanel[f].Location.Y + mainPanel[f].Height) - mainPanel[f].Height / 5 - 10),
                    Text = pr.Title,
                    BackColor = mainPanel[f].BackColor,
                    TextAlign = ContentAlignment.TopCenter,
                    Font = new Font("Tahoma", 9f, FontStyle.Regular)
                };
                name.Add(text);
                panel2.Controls.Add(name[f]);
                name[f].BringToFront();

                PictureBox mainImg = new PictureBox()
                {
                    Size = new Size(150, 200),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackgroundImage = Image.FromFile($@"..\..\{pr.MainImagePath}"),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(mainPanel[f].Location.X + ((mainPanel[f].Width - 150) / 2), mainPanel[f].Location.Y + 10)
                };
                mainImage.Add(mainImg);
                panel2.Controls.Add(mainImage[f]);
                mainImage[f].BringToFront();

                List<PictureBox> pb = new List<PictureBox>();
                for (int i = 0; i < counter; i++)
                {
                    PictureBox rdP = new PictureBox
                    {
                        Size = new Size(15, 15),
                        BackColor = Color.FromArgb(225, 228, 255),
                        Location = new Point((mainImage[f].Location.X + ((mainImage[f].Width - (30 * counter / 2)) / 2) + (30 * i) / 2), mainImage[f].Location.Y + mainImage[f].Height)
                    };
                    if (i == 0)
                        rdP.BackColor = Color.FromArgb(255, 74, 109);
                    pb.Add(rdP);
                    panel2.Controls.Add(pb[i]);
                    pb[i].BringToFront();
                }
                checkList.Add(pb);
            }
        

        }


        private void Add_button_Click(object sender, EventArgs e)
        {
            AddProductForm addProductFrm = new AddProductForm();
            addProductFrm.db = db;
            addProductFrm.Show();
            this.Hide();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Change_button_Click(object sender, EventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }
    }
}
