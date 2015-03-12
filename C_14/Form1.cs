using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;


namespace C_14
{
    using Product;
    public partial class Form1 : Form
    {
        CProducts Cprod = new CProducts();
        static int local_iterator_for_butn1 = 0;
        bool check_next_button = false;
        public Form1()
        {
            InitializeComponent();
            Cprod.Take_from_file();
            btn_Information_Show.Enabled = false;
            pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\art_82519.jpg");
            //Thread thread = new Thread(new ThreadStart(Show));
            //thread.Start();
            //Thread.Sleep(1000);
            list_of_CProducts.Items.Add("Hello!");
        }

        //public static void Show()
        //{
        //    Form2 form1 = new Form2();
        //    form1.Show();
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            Cproducts_Name_Show.Text = Cprod.ls_prod[local_iterator_for_butn1].SName;
            Cproducts_Price_Show.Text = Cprod.ls_prod[local_iterator_for_butn1].Price.ToString();
            Cproducts_Fresh_Show.Text = Cprod.ls_prod[local_iterator_for_butn1].SFresch;

            btn_Information_Show.Enabled = false;
        }

        private void btn_Foto_Show_Click(object sender, EventArgs e)
        {
            //Form1.ActiveForm.Size = new Size(200,123);
            Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
            list_of_CProducts.Items.Clear();
            //pct_Box.Location = new Point(13, 13);
            //pct_Box.Size = new Size(100, 100);
            //pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\Завдання!.png");

            //changing and outputting current product
            #region if (btn_Foto_Show.Text == "Показати фотографію")
            if (btn_Foto_Show.Text == "Показати фотографію")
            {
                check_next_button = true;
                btn_Information_Show.Enabled = true;
                if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Fish")
                {
                    pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Fish.jpg");
                    list_menu();
                }
                else if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Meat")
                {
                    Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
                    pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Meat.jpg");
                    list_menu();
                }
                else if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Chicken")
                {
                    Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
                    pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Chicken.jpg");
                    list_menu();
                }
                btn_Foto_Show.Text = "Забрати фотографію";
                
            }
            else if (btn_Foto_Show.Text == "Забрати фотографію")
            {
                pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\art_82519.jpg");
                btn_Foto_Show.Text = "Показати фотографію";
                Cproducts_Name_Show.Text = "";
                Cproducts_Price_Show.Text = "";
                Cproducts_Fresh_Show.Text = "";
            } 
            #endregion
            
            //local_iterator_for_butn1++;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (check_next_button)
            {
                local_iterator_for_butn1++;
                //outputting the picture of current product 
                #region if(btn_Foto_Show.Text != "Забрати інформацію")

                if (btn_Foto_Show.Text != "Забрати інформацію")
                {
                    #region If_region
                    if (Cprod.lenght > local_iterator_for_butn1)
                    {

                        if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Fish")
                        {
                            Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
                            pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Fish.jpg");
                            list_menu();
                        }
                        else if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Meat")
                        {
                            Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
                            pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Meat.jpg");
                            list_menu();
                        }
                        else if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Chicken")
                        {
                            Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
                            pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Chicken.jpg");
                            list_menu();
                        }
                    }
                    else
                    {

                        local_iterator_for_butn1 = 0;
                        if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Fish")
                        {
                            Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
                            pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Fish.jpg");
                            list_menu();
                        }
                        else if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Meat")
                        {
                            Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
                            pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Meat.jpg");
                            list_menu();
                        }
                        else if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Chicken")
                        {
                            Form1.ActiveForm.Text = Cprod.ls_prod[local_iterator_for_butn1].SName.ToString();
                            pct_Box.Image = Image.FromFile(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\C_14\Chicken.jpg");
                            list_menu();
                        }
                    }
                    #endregion

                    //inputting the information of current product that is on the picture
                    if (Cproducts_Name_Show.Text != "")
                    {
                        Cproducts_Name_Show.Text = Cprod.ls_prod[local_iterator_for_butn1].SName;
                        Cproducts_Price_Show.Text = Cprod.ls_prod[local_iterator_for_butn1].Price.ToString();
                        Cproducts_Fresh_Show.Text = Cprod.ls_prod[local_iterator_for_butn1].SFresch;
                    }
                }
                #endregion
            }
        }

        private void list_of_CProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void list_menu()
        {
            if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Fish")
            {
                list_of_CProducts.Items.Clear();
                string fish = "1.Source the freshest fish available.";
                list_of_CProducts.Items.Add(fish);
                fish = "2.Know that it's okay to undercook most fish.";
                list_of_CProducts.Items.Add(fish);
                fish = "3.Know the three basic kinds of fish.";
                list_of_CProducts.Items.Add(fish);
                fish = "4.Experiment with marinades, but know that most fish taste wonderful with just salt and pepper.";
                list_of_CProducts.Items.Add(fish);
                
            }
            else if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Meat")
            {
                list_of_CProducts.Items.Clear();
                string fish = "1. Trim the beef brisket into manageable pieces.";
                list_of_CProducts.Items.Add(fish);
                fish = "2. Mix up the brine";
                list_of_CProducts.Items.Add(fish);
                fish = "3. Pour the brine over the meat.";
                list_of_CProducts.Items.Add(fish);
                fish = "4. Put the brisket into the fridge.";
                list_of_CProducts.Items.Add(fish);
                
            }
            else if (Cprod.ls_prod[local_iterator_for_butn1].SName == "Chicken")
            {
                list_of_CProducts.Items.Clear();
                string fish = "1.Store the chicken in the fridge or freezer immediately \nif you're not cooking it right away. ";
                list_of_CProducts.Items.Add(fish);
                fish = "2. Wash the chicken.";
                list_of_CProducts.Items.Add(fish);
                fish = "3. Dry the chicken.";
                list_of_CProducts.Items.Add(fish);
                fish = "4. Cook the chicken.";
                list_of_CProducts.Items.Add(fish);
                
            }
        }

        
        private void Change_SFresh_CProducts_Click(object sender, EventArgs e)
        {
            //changing Fresh
            if ((btn_Information_Show.Enabled == true) || (btn_Foto_Show.Text == "Забрати фотографію"))
            {
                string str = Convert.ToString(Cproducts_Fresh_Show.Text);
                Cprod.ls_prod[local_iterator_for_butn1].SFresch = str;
            }
        }

        private void Change_PriceCProducts_Click(object sender, EventArgs e)
        {
            if ((btn_Information_Show.Enabled == true) || (btn_Foto_Show.Text == "Забрати фотографію"))
            {
                string str = Cproducts_Price_Show.Text;
                try
                {
                    Cprod.ls_prod[local_iterator_for_butn1].Price = Convert.ToDecimal(str);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong parameters " + ex);
                }
            }
        }
    }
}



namespace Product
{
    class CProducts
    {
        //All the variables that we have
        public string SName { get; set; }
        public decimal Price { get; set; }
        public string SFresch { get; set; }


        //static variable that content the length of List<CProducts>
        public int lenght = 0;

        //list to make a collection of CProducts class
        public List<CProducts> ls_prod = new List<CProducts>();


        //method that takes CProducts from file, and add to list<CProducts> ls_prod
        public void Take_from_file()
        {
            //creating new variable txt to take out all the parameters from file 
            StreamReader txt = new StreamReader(@"D:\Франка\2-й курс ПМа - 22\2-й семестр\Обчислювальна Парктика\C_14\C_14\List_of_Products.txt");
            

            //Creating classes of CPorducts readed from text file txt
            while (txt.ReadLine() != null)
            {
                CProducts cprod = new CProducts();
                cprod.SName = txt.ReadLine();
                cprod.Price = Convert.ToDecimal(txt.ReadLine());
                cprod.SFresch = txt.ReadLine();
                ls_prod.Add(cprod);
                lenght++;
            }
            //Closing our text file
            txt.Close();
        }     

        //method that allow us to change properties of CProducts class
        public void Modifi_the_features(string sName,decimal dPrice,string sFresch)
        {
            MessageBox.Show("You change name from " + SName + " to " + sName);
            SName = sName;
            MessageBox.Show("You change price from " + Price + " to " + dPrice);
            Price = dPrice;
            MessageBox.Show("You change fresh from " + SFresch + " to " + sFresch);
            SFresch = sFresch;
        }
    }
}