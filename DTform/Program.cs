using System;

namespace DTform
{
    public static class getdt
    {
        public static string getByDate(int a, DateTime dt)
        {
            String res="";
            switch(a)
            {
                case 0: //MMddyy
                        res = dt.ToString("MM/dd/yy");
                        break;
                case 1: //MMddyyyy
                    res = dt.ToString("MM/dd/yyyy");
                    break;
                case 2: //ddMMyy
                    res = dt.ToString("dd/MM/yy");
                    break;
                case 3: //ddd_dd_MMM_yy
                    res = dt.ToString("ddd, dd MMM yy");
                    break;
                case 4: //dddd_dd_MMMM_yyyy
                    res = dt.ToString("dddd, dd MMMM yyyy");
                    break;
                default: break;
            }
            
            
            return res;
        }
        public static string getByTime(int a, DateTime dt)
        {
            String res1 = "";
            switch (a)
            {
                case 0: //HHmm
                    res1 = dt.ToString("HH:mm");
                    break;
                case 1: //HHmmss
                    res1 = dt.ToString("HH:mm:ss");
                    break;
                case 2: //HHmm_tt
                    res1 = dt.ToString("hh:mm tt");
                    break;
                case 3: //Hmmss
                    res1 = dt.ToString("H:mm:ss");
                    break;
                case 4: //hmm
                    res1 = dt.ToString("H:mm");
                    break;
                default: break;
            }


            return res1;
        }

        public static string getByDateAndTime(int a, DateTime dt)
        {
            String res2 = "";
            switch (a)
            {
                case 0: //MMddyy_HHmm
                    res2 = dt.ToString("MM/dd/yy HH: mm");
                    break;
                case 1: //MMddyy_HHmmss
                    res2 = dt.ToString("MM/dd/yy HH:mm:ss");
                    break;
                case 2: //MMddyyyy_hhmm_tt
                    res2 = dt.ToString("MM/dd/yyyy hh:mm tt");
                    break;
                case 3: //MMddyyyy_hhmm_t
                    res2 = dt.ToString("MM/dd/yyyy hh:mm t");
                    break;
                case 4: //dd_MMM_yyyy_hhmm_tt
                    res2 = dt.ToString("dd MMM yyyy hh:mm tt");
                    break;
                default: break;
            }


            return res2;
        }
    }
    public class Program
    {
        enum dt : int
        { 
            MMddyy = 0,
            MMddyyyy = 1,
            ddMMyy =2,
            ddd_dd_MMM_yy=3,
            dddd_dd_MMMM_yyyy=4
        };
        enum tm 
        {
            HHmm = 0,
            HHmmss =1,
            HHmm_tt = 2,
            Hmmss =3 ,
            hmm =4
        };
        enum dttm 
        {
            MMddyy_HHmm =0,
            MMddyy_HHmmss = 1,
            MMddyyyy_hhmm_tt =2,
            MMddyyyy_hhmm_t = 3,
            dd_MMM_yyyy_hhmm_tt=4,
        };
       
        static void Main(string[] args)
        {
            String date = getdt.getByDate((int)dt.MMddyy, DateTime.Now);
            String time = getdt.getByTime((int)tm.HHmmss, DateTime.Now);
            String dateandtime = getdt.getByDateAndTime((int)dttm.dd_MMM_yyyy_hhmm_tt, DateTime.Now);


            Console.WriteLine("only date format :"+ date);
            Console.WriteLine("only date format :"+time);
            Console.WriteLine("datetime format :"+dateandtime);

            Console.WriteLine("Completed!!!!!!");
        }
    }
}
