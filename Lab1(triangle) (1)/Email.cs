using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_triangle_
{
    public class Email
    {
        public string Message(bool db)
        {
            string MessageEmail;
            if (db == true)
            {
                MessageEmail = "Данные получены из базы данных";
            }
            else
            {
                MessageEmail = "Данные записаны в базу данных и просчитаны впервые";
            }
            return MessageEmail;
        }
    }
}
