using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Leaf.xNet;
using Fizzler;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System.Collections;


namespace ChanceBOT
{
    public partial class Form1 : Form
    {
        BOT test = new BOT();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            test.LoadProxy("PROXYS.txt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void doTemp()
        {
            ArrayList take = test.Load_HTML();
            label1.Text = take[0].ToString();
            label2.Text = take[1].ToString() + "°";
            label3.Text = take[2].ToString() + ", ощущается как " + take[3].ToString() + "°";
            label4.Text = take[4].ToString();
            label5.Text = take[5].ToString();
            label6.Text = take[6].ToString();

            var take_time_bottom_temp = take[7].ToString();
            var time_bottom_temp = take_time_bottom_temp.Split(',');

            var take_temp_bottom_temp = take[8].ToString();
            var temp_bottom_temp = take_temp_bottom_temp.Split(',');

            label7.Text = time_bottom_temp[0];
            label8.Text = time_bottom_temp[1];
            label9.Text = time_bottom_temp[2];
            label10.Text = time_bottom_temp[3];
            label11.Text = time_bottom_temp[4];
            label12.Text = time_bottom_temp[5];
            label13.Text = time_bottom_temp[6];
            label14.Text = time_bottom_temp[7];
            label15.Text = time_bottom_temp[8];
            label16.Text = time_bottom_temp[9];
            label17.Text = time_bottom_temp[10];
            label18.Text = time_bottom_temp[11];




            label30.Text = temp_bottom_temp[0];
            label29.Text = temp_bottom_temp[1];
            label28.Text = temp_bottom_temp[2];
            label27.Text = temp_bottom_temp[3];
            label26.Text = temp_bottom_temp[4];
            label25.Text = temp_bottom_temp[5];
            label24.Text = temp_bottom_temp[6];
            label23.Text = temp_bottom_temp[7];
            label22.Text = temp_bottom_temp[8];
            label21.Text = temp_bottom_temp[9];
            label20.Text = temp_bottom_temp[10];
            label19.Text = temp_bottom_temp[11];


            if (take[2].ToString() == "Пасмурно")
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
            }
            if (take[2].ToString() == "Ясно")
            {
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
                pictureBox8.Visible = false;
            }

            if (take[2].ToString() == "Малооблачно")
            {
                pictureBox8.Visible = true;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
            }
            if (take[2].ToString() == "Облачно с прояснениями")
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
            }
            if (take[2].ToString() == "Небольшой дождь")
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
            }
            if (take[2].ToString() == "Дождь")
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            

            string city = comboBox1.Text;
            if(city == "")
            {
                MessageBox.Show("ПОЖАЛУЙСТА, ВЫБЕРИТЕ ГОРОД");
            }
            else
            {
                if(city == "Екатеринбург")
                {
                   
                   var hah = test.ResponseByRequest("https://yandex.ru/pogoda/?lat=56.832199&lon=60.633178&utm_source=serp&utm_campaign=wizard&utm_medium=desktop&utm_content=wizard_desktop_main&utm_term=title");
                    doTemp();

                }
                if (city == "Москва")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/213?via=srp");

                    doTemp();
                }
                if (city == "Санкт-Петербург")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/2?utm_source=serp&utm_campaign=wizard&utm_medium=desktop&utm_content=wizard_desktop_main&utm_term=title");

                    doTemp();
                }

                if (city == "Казань")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/43");

                    doTemp();
                }

                if (city == "Нижний Новгород")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/?lat=56.32679749&lon=44.00651932");

                    doTemp();
                }

                if (city == "Калининград")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/22");

                    doTemp();
                }

                if (city == "Сочи")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/239");

                    doTemp();
                }

                if (city == "Суздаль")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/10671");

                    doTemp();
                }

                if (city == "Новосибирск")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/65");

                    doTemp();
                }

                if (city == "Ростов-на-Дону")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/?lat=47.22208023&lon=39.72035599");

                    doTemp();
                }

                if (city == "Волгоград")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/38");

                    doTemp();
                }

                if (city == "Архангельск")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/20");

                    doTemp();
                }

                if (city == "Пятигорск")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/11067");

                    doTemp();
                }

                if (city == "Красноярск")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/62");

                    doTemp();
                }

                if (city == "Псков")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/25");

                    doTemp();
                }

                if (city == "Ярославль")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/16");

                    doTemp();
                }

                if (city == "Самара")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/51");

                    doTemp();
                }

                if (city == "Воронеж")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/193");

                    doTemp();
                }

                if (city == "Владивосток")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/75");

                    doTemp();
                }

                if (city == "Владимир")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/192");

                    doTemp();
                }


                if (city == "Каменск-Уральский")
                {
                    var hah = test.ResponseByRequest("https://yandex.ru/pogoda/11164");

                    doTemp();
                }
            }
               
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
