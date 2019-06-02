using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;



namespace WindowsFormsApplication1
{
    public partial class SoloTest : UserControl
    {
        public SoloTest()
        {
            InitializeComponent();
        }

        SoloTestClass solo = new SoloTestClass();
        int sayac = 0;
        int gamesayac = 0;
        public int thirdovalX;
        public int thirdovalY;
        public int kalanpiyon=0;
        public string unvan;
        public bool oyunbitti = false;
        
        private void piyons_Click(object sender, EventArgs e)
        {
            OvalShape bilgi = (OvalShape)sender;
            otomaticbordercolor();
            
            if (sayac % 2 == 0)
            {
                solo.boolfirstclick = true;
                solo.boollastclick = false;
                
                solo.firstclick = bilgi.Name;
                solo.lastclick = "null";
               
                solo.FirstOval_click(bilgi);

            }
           
            else if (sayac % 2 == 1)
            {
                solo.boollastclick = true;
                solo.boolfirstclick = false;
                solo.lastclick = bilgi.Name;

                solo.LastOval_click(bilgi);

               
                thirdovalsender();
                solo.play();
                gameover();
                if (gamesayac == 0)
                {
                    
                    gamenowoverkalanpiyonsayisi();
                    DialogResult a = MessageBox.Show("Rütbe: " + unvan+"\nYeniden oynamak ister misiniz?","Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (a == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (a == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    
                 }
                else
                    gamesayac = 0;

                otomaticbordercolor();
            }
            sayac++;

        }

        public void thirdovalsender()
        {
            thirdovalX = solo.ThirdovalLEFT();
            thirdovalY = solo.ThirdovalTOP();

            if (thirdovalX == 300 && thirdovalY == 50)
                solo.ThirdOval_İnfo(piyon1);
            else if (thirdovalX == 400 && thirdovalY == 50)
                solo.ThirdOval_İnfo(piyon2);
            else if (thirdovalX == 500 && thirdovalY == 50)
                solo.ThirdOval_İnfo(piyon3);

            else if (thirdovalX == 300 && thirdovalY == 120)
                solo.ThirdOval_İnfo(piyon4);
            else if (thirdovalX == 400 && thirdovalY == 120)
                solo.ThirdOval_İnfo(piyon5);
            else if (thirdovalX == 500 && thirdovalY == 120)
                solo.ThirdOval_İnfo(piyon6);

            else if (thirdovalX == 100 && thirdovalY == 190)
                solo.ThirdOval_İnfo(piyon7);
            else if (thirdovalX == 200 && thirdovalY == 190)
                solo.ThirdOval_İnfo(piyon8);
            else if (thirdovalX == 300 && thirdovalY == 190)
                solo.ThirdOval_İnfo(piyon9);
            else if (thirdovalX == 400 && thirdovalY == 190)
                solo.ThirdOval_İnfo(piyon10);
            else if (thirdovalX == 500 && thirdovalY == 190)
                solo.ThirdOval_İnfo(piyon11);
            else if (thirdovalX == 600 && thirdovalY == 190)
                solo.ThirdOval_İnfo(piyon12);
            else if (thirdovalX == 700 && thirdovalY == 190)
                solo.ThirdOval_İnfo(piyon13);

            else if (thirdovalX == 100 && thirdovalY == 260)
                solo.ThirdOval_İnfo(piyon14);
            else if (thirdovalX == 200 && thirdovalY == 260)
                solo.ThirdOval_İnfo(piyon15);
            else if (thirdovalX == 300 && thirdovalY == 260)
                solo.ThirdOval_İnfo(piyon16);
            else if (thirdovalX == 400 && thirdovalY == 260)
                solo.ThirdOval_İnfo(piyon17);
            else if (thirdovalX == 500 && thirdovalY == 260)
                solo.ThirdOval_İnfo(piyon18);
            else if (thirdovalX == 600 && thirdovalY == 260)
                solo.ThirdOval_İnfo(piyon19);
            else if (thirdovalX == 700 && thirdovalY == 260)
                solo.ThirdOval_İnfo(piyon20);

            else if (thirdovalX == 100 && thirdovalY == 330)
                solo.ThirdOval_İnfo(piyon21);
            else if (thirdovalX == 200 && thirdovalY == 330)
                solo.ThirdOval_İnfo(piyon22);
            else if (thirdovalX == 300 && thirdovalY == 330)
                solo.ThirdOval_İnfo(piyon23);
            else if (thirdovalX == 400 && thirdovalY == 330)
                solo.ThirdOval_İnfo(piyon24);
            else if (thirdovalX == 500 && thirdovalY == 330)
                solo.ThirdOval_İnfo(piyon25);
            else if (thirdovalX == 600 && thirdovalY == 330)
                solo.ThirdOval_İnfo(piyon26);
            else if (thirdovalX == 700 && thirdovalY == 330)
                solo.ThirdOval_İnfo(piyon27);

            else if (thirdovalX == 300 && thirdovalY == 400)
                solo.ThirdOval_İnfo(piyon28);
            else if (thirdovalX == 400 && thirdovalY == 400)
                solo.ThirdOval_İnfo(piyon29);
            else if (thirdovalX == 500 && thirdovalY == 400)
                solo.ThirdOval_İnfo(piyon30);

            else if (thirdovalX == 300 && thirdovalY == 470)
                solo.ThirdOval_İnfo(piyon31);
            else if (thirdovalX == 400 && thirdovalY == 470)
                solo.ThirdOval_İnfo(piyon32);
            else if (thirdovalX == 500 && thirdovalY == 470)
                solo.ThirdOval_İnfo(piyon33);
    
        }
        public void gamenowoverkalanpiyonsayisi()
        {
            if (piyon1.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon2.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon3.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon4.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon5.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon6.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon7.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon8.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon9.BackColor == Color.PowderBlue)
                kalanpiyon++;

            if (piyon10.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon11.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon12.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon13.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon14.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon15.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon16.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon17.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon18.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon19.BackColor == Color.PowderBlue)
                kalanpiyon++;


            if (piyon20.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon21.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon22.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon23.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon24.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon25.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon26.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon27.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon28.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon29.BackColor == Color.PowderBlue)
                kalanpiyon++;

            if (piyon30.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon31.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon32.BackColor == Color.PowderBlue)
                kalanpiyon++;
            if (piyon33.BackColor == Color.PowderBlue)
                kalanpiyon++;

            if (kalanpiyon == 1)
                unvan = "Bilgin (200 Puan)";
            else if (kalanpiyon == 2)
                unvan = "Zeki (175 Puan)";
            else if (kalanpiyon == 3)
                unvan = "Kurnaz (150 Puan)";
            else if (kalanpiyon == 4)
                unvan = "Başarılı (125 Puan)";
            else if (kalanpiyon == 5)
                unvan = "Normal (100 Puan)";
            else if (kalanpiyon == 6)
                unvan = "Tecrübesiz (75 Puan)";
            else if (kalanpiyon == 7)
                unvan = "Aptal (50 Puan)";
            else if (kalanpiyon == 8)
                unvan = "Gerizekalı (25 Puan)";
            else 
                unvan = "Beyinsiz (0 Puan)";

            oyunbitti = true;
         
        }

        public void gameover()
        {
            gameoverto(piyon1, piyon2, piyon3);
            gameoverto(piyon1, piyon4, piyon9); // piyon 1

            gameoverto(piyon2, piyon5, piyon10); // piyon 2

            gameoverto(piyon3, piyon2, piyon1); 
            gameoverto(piyon3, piyon6, piyon11); // piyon 3

            gameoverto(piyon4, piyon5, piyon6);
            gameoverto(piyon4, piyon9, piyon16); // piyon 4

            gameoverto(piyon5, piyon10, piyon17); // piyon5

            gameoverto(piyon6, piyon5, piyon4);
            gameoverto(piyon6, piyon11, piyon18); // piyon 6

            gameoverto(piyon7, piyon8, piyon9); 
            gameoverto(piyon7, piyon14, piyon21); // piyon7

            gameoverto(piyon8, piyon9, piyon10);
            gameoverto(piyon8, piyon15, piyon22); // piyon8

            gameoverto(piyon9, piyon10, piyon11);
            gameoverto(piyon9, piyon8, piyon7);
            gameoverto(piyon9, piyon16, piyon23);
            gameoverto(piyon9, piyon4, piyon1); // piyon 9

            gameoverto(piyon10, piyon11, piyon12);
            gameoverto(piyon10, piyon9, piyon8);
            gameoverto(piyon10, piyon17, piyon24);
            gameoverto(piyon10, piyon5, piyon2);  // piyon 10

            gameoverto(piyon11, piyon12, piyon13);
            gameoverto(piyon11, piyon10, piyon9);
            gameoverto(piyon11, piyon18, piyon25);
            gameoverto(piyon11, piyon6, piyon3); // piyon 11

            gameoverto(piyon12, piyon11, piyon10);
            gameoverto(piyon12, piyon19, piyon26); // piyon 12

            gameoverto(piyon13, piyon12, piyon11);
            gameoverto(piyon13, piyon20, piyon27); // piyon 13

            gameoverto(piyon14, piyon15, piyon16); // piyon 14

            gameoverto(piyon15, piyon16, piyon17); // piyon 15

            gameoverto(piyon16, piyon17, piyon18);
            gameoverto(piyon16, piyon15, piyon14);
            gameoverto(piyon16, piyon23, piyon28);
            gameoverto(piyon16, piyon9, piyon4);  // piyon 16

            gameoverto(piyon17, piyon18, piyon19);
            gameoverto(piyon17, piyon16, piyon15);
            gameoverto(piyon17, piyon24, piyon29);
            gameoverto(piyon17, piyon10, piyon5); // piyon 17

            gameoverto(piyon18, piyon19, piyon20);
            gameoverto(piyon18, piyon17, piyon16);
            gameoverto(piyon18, piyon25, piyon30); 
            gameoverto(piyon18, piyon11, piyon6); // piyon 18

            gameoverto(piyon19, piyon18, piyon17); // piyon 19

            gameoverto(piyon20, piyon19, piyon18); // piyon 20

            gameoverto(piyon21, piyon22, piyon23);
            gameoverto(piyon21, piyon14, piyon7); // piyon 21

            gameoverto(piyon22, piyon23, piyon24);
            gameoverto(piyon22, piyon15, piyon8); // piyon 22

            gameoverto(piyon23, piyon24, piyon25);
            gameoverto(piyon23, piyon22, piyon21);
            gameoverto(piyon23, piyon28, piyon31);
            gameoverto(piyon23, piyon16, piyon9);  // piyon 23

            gameoverto(piyon24, piyon25, piyon26);
            gameoverto(piyon24, piyon23, piyon22);
            gameoverto(piyon24, piyon29, piyon32);
            gameoverto(piyon24, piyon17, piyon10); // piyon 24

            gameoverto(piyon25, piyon26, piyon27);
            gameoverto(piyon25, piyon24, piyon23);
            gameoverto(piyon25, piyon30, piyon33);
            gameoverto(piyon25, piyon18, piyon11); // piyon 25

            gameoverto(piyon26, piyon25, piyon24);
            gameoverto(piyon26, piyon19, piyon12); // piyon 26

            gameoverto(piyon27, piyon26, piyon25);
            gameoverto(piyon27, piyon20, piyon13); // piyon 27

            gameoverto(piyon28, piyon29, piyon30);
            gameoverto(piyon28, piyon23, piyon16); // piyon 28

            gameoverto(piyon29, piyon24, piyon17); // piyon 29

            gameoverto(piyon30, piyon29, piyon28);
            gameoverto(piyon30, piyon25, piyon18); // piyon 30

            gameoverto(piyon31, piyon32, piyon33);
            gameoverto(piyon31, piyon28, piyon23); // piyon 31

            gameoverto(piyon32, piyon29, piyon24); // piyon 32

            gameoverto(piyon33, piyon32, piyon31);
            gameoverto(piyon33, piyon30, piyon25); // piyon 33

         }

        private void gameoverto(OvalShape a, OvalShape b, OvalShape c)
        {
            if (a.BackColor == Color.PowderBlue && b.BackColor == Color.PowderBlue && c.BackColor == Color.White)
                gamesayac += 1;
        }

        public void otomaticbordercolor()
        {
            piyon1.BorderColor = System.Drawing.Color.Black;
            piyon2.BorderColor = System.Drawing.Color.Black;
            piyon3.BorderColor = System.Drawing.Color.Black;
            piyon4.BorderColor = System.Drawing.Color.Black;
            piyon5.BorderColor = System.Drawing.Color.Black;
            piyon6.BorderColor = System.Drawing.Color.Black;
            piyon7.BorderColor = System.Drawing.Color.Black;
            piyon8.BorderColor = System.Drawing.Color.Black;
            piyon9.BorderColor = System.Drawing.Color.Black;
            piyon10.BorderColor = System.Drawing.Color.Black;
            piyon11.BorderColor = System.Drawing.Color.Black;
            piyon12.BorderColor = System.Drawing.Color.Black;
            piyon13.BorderColor = System.Drawing.Color.Black;
            piyon14.BorderColor = System.Drawing.Color.Black;
            piyon15.BorderColor = System.Drawing.Color.Black;
            piyon16.BorderColor = System.Drawing.Color.Black;
            piyon17.BorderColor = System.Drawing.Color.Black;
            piyon18.BorderColor = System.Drawing.Color.Black;
            piyon19.BorderColor = System.Drawing.Color.Black;
            piyon20.BorderColor = System.Drawing.Color.Black;
            piyon21.BorderColor = System.Drawing.Color.Black;
            piyon22.BorderColor = System.Drawing.Color.Black;
            piyon23.BorderColor = System.Drawing.Color.Black;
            piyon24.BorderColor = System.Drawing.Color.Black;
            piyon25.BorderColor = System.Drawing.Color.Black;
            piyon26.BorderColor = System.Drawing.Color.Black;
            piyon27.BorderColor = System.Drawing.Color.Black;
            piyon28.BorderColor = System.Drawing.Color.Black;
            piyon29.BorderColor = System.Drawing.Color.Black;
            piyon30.BorderColor = System.Drawing.Color.Black;
            piyon31.BorderColor = System.Drawing.Color.Black;
            piyon32.BorderColor = System.Drawing.Color.Black;
            piyon33.BorderColor = System.Drawing.Color.Black;

        }

        private void SoloTest_Load(object sender, EventArgs e)
        {

        }
    }
}
