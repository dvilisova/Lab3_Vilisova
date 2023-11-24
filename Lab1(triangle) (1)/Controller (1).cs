using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab1_triangle_.AppDate;


namespace Lab1_triangle_
{
    public class Controller
    {
        
        public (string, int[], string, string) ControllerTest(string st1, string st2, string st3)
        {
            //string Type_tr;
            //int[] vertsss;
            //string error;
            //string messagemail;
            //bool mail = false;

           var a = new AppDate().Proverka(st1, st2, st3);
            if (a == true)
            {
 
                (string A, int[] verts, string D) = new AppDate().FromDateBase(st1, st2, st3);
                string C = new Email().Message(a);

                //Type_tr = A;
                //vertsss = verts;
                //error = D;
                //string C = new Email.Message();
                // mail = true;

                return (A, verts, D,C);
               

            }
            else
            {
                string C = new Email().Message(a);

                (string Type_, int[] vertss, string error) = new TriangleType().Method(st1, st2, st3);
                
                new AppDate().AddDateTest(st1, st2, st3, Type_, error);

                //string Type_tr = Type_;
                //string error_tr = error;

                return (Type_, vertss, error,C);
            }


        }

    }
}
