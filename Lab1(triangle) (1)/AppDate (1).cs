using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_triangle_
{
    public class AppDate
    {
        //public static string resultinput1 { get; set; }
        //public static string resultinput2 { get; set; }
        //public static string resultinput3 { get; set; }
        public static string resultType { get; set; }
        //public bool da{ get; set; }
        public Test_triangleEntities db = new Test_triangleEntities();
        public void AddDateTest(string st1, string st2, string st3,string type, string error_triangle)
        {
            //string a = "Save";
            //string b = "A kak po drugomu";
            Date_tiangle date_Tiangle = new Date_tiangle();
            date_Tiangle.input1 = st1;
            date_Tiangle.input2 = st2;
            date_Tiangle.input3 = st3;
            date_Tiangle.Type_triangle = type;
            date_Tiangle.Error = error_triangle;
            db.Date_tiangle.Add(date_Tiangle);
            db.SaveChanges();
            //return a;
        }
        public bool Proverka(string st1, string st2, string st3)
        {
            bool da = false;
            var DB = db.Date_tiangle.FirstOrDefault(u => u.input1 == st1 && u.input2 == st2 && u.input3 == st3 || u.input1 == st2 && u.input2 == st1 && u.input3 == st3 || u.input1 == st3 && u.input2 == st1 && u.input3 == st2 || u.input1 == st1 && u.input2 == st3 && u.input3 == st2 || u.input1 == st3 && u.input2 == st2 && u.input3 == st1 || u.input1 == st2 && u.input2 == st3 && u.input3 == st1);
            if (DB != null)
            {
                da = true;
                //FromDateBase(st1, st2, st3);
            }
            else
            {
                da = false;
            }

            return da;
        }
        public (string, int[], string ) FromDateBase(string st1, string st2, string st3)
        {
            string a = "Данные взяты из базы данных";
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            int x3 = 0;
            int y3 = 0;
            var DB = db.Date_tiangle.FirstOrDefault(u => u.input1 == st1 && u.input2 == st2 && u.input3 == st3 || u.input1 == st2 && u.input2 == st1 && u.input3 == st3 || u.input1 == st3 && u.input2 == st1 && u.input3 == st2 || u.input1 == st1 && u.input2 == st3 && u.input3 == st2 || u.input1 == st3 && u.input2 == st2 && u.input3 == st1 || u.input1 == st2 && u.input2 == st3 && u.input3 == st1);
            //resultinput1 = DB.input1;
            //resultinput2 = DB.input2;
            //resultinput3 = DB.input3;
            resultType = DB.Type_triangle;
            return (resultType, new int[] { x1, y1, x2, y2, x3, y3, },a);

        }

    }

}
