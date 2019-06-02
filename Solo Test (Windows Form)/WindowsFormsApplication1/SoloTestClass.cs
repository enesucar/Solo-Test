using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.PowerPacks;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApplication1
{
    class SoloTestClass
    {

     
        public string firstclick;
        public bool boolfirstclick;
        public OvalShape firstoval;
        public int firstovalleft;
        public int firstovaltop;

        public string lastclick;
        public bool boollastclick;
        public OvalShape lastoval;
        public int lastovalleft;
        public int lastovaltop;

        public OvalShape thirdoval;

        public SoloTestClass()
        {
            firstclick = "null";
            boolfirstclick = false;
            firstovalleft = 0;
            firstovaltop = 0;

            lastclick = "null";
            boollastclick = false;
            lastovalleft = 0;
            lastovaltop = 0;

            thirdoval = new OvalShape();
            thirdoval.BackColor = Color.PowderBlue;
            thirdoval.Left = 0;
            thirdoval.Top = 0;

            

        }

        public void FirstOval_click(OvalShape oval)
        {
            firstoval = oval;
            oval.BorderColor = Color.Green;
            firstovalleft = oval.Left;
            firstovaltop = oval.Top;
            
        }

        public void LastOval_click(OvalShape oval)
        {
            lastoval = oval;
            lastovalleft = oval.Left;
            lastovaltop = oval.Top;
        }

        public void play()
        {
            if (firstoval.BackColor == Color.PowderBlue && thirdoval.BackColor == Color.PowderBlue && lastoval.BackColor == Color.White)
            {
                firstoval.BackColor = Color.White;
                thirdoval.BackColor = Color.White;
                lastoval.BackColor = Color.PowderBlue;
            }
        }


        
        public int ThirdovalLEFT()
            {
                if (firstovalleft + 200 == lastovalleft && firstovaltop == lastovaltop)
                {return firstovalleft + 100;}
                
                else if (firstovalleft - 200 == lastovalleft  && firstovaltop == lastovaltop)
                {return firstovalleft - 100 ;}
               
                else if (firstovalleft == lastovalleft && firstovaltop + 140 == lastovaltop)
                {return firstovalleft;}

                else if (firstovalleft == lastovalleft && firstovaltop - 140 == lastovaltop)
                { return firstovalleft; }
                
             return 0;
           }


         public int ThirdovalTOP()
         {
             if (firstovalleft + 200 == lastovalleft && firstovaltop == lastovaltop)
             {  return firstovaltop;}

             else if (firstovalleft - 200 == lastovalleft && firstovaltop == lastovaltop)
             {return firstovaltop;}

             else if (firstovalleft == lastovalleft && firstovaltop + 140 == lastovaltop)
             {return firstovaltop + 70;}

             else if (firstovalleft == lastovalleft && firstovaltop - 140 == lastovaltop)
             {return firstovaltop - 70;}

             return 0;
         }

         public void ThirdOval_İnfo(OvalShape oval)
         {
             thirdoval = oval;
         }

      }
  }

