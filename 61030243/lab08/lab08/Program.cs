using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//ให้สร้างแฮชเทเบิล ที่บรรจุรหัสไปรษณีย์และชื่อจังหวัด  (ทำในระดับจังหวัดเท่านั้น) แล้วค้นหาจากรหัสไปรษณีย์ที่กำหนด

namespace lab08
{
    //7426
    class Program
    {
        static void Main(string[] args)
        {
            string sname = null;
            string sid = null;
            int id;

            Hashtable student = new Hashtable();


            StreamReader fname = null;
            StreamReader fid = null;

            try
            {
                fname = new StreamReader("./name.txt");//file form folder bin
                fid = new StreamReader("./id.txt");
                while (((sname = fname.ReadLine().ToString()) != ".") && ((sid = fid.ReadLine().ToString()) != "."))
                {
                        student.Add(sid, sname);
                        Console.WriteLine($"{sname} => {sid}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(  );
        insert:
            try
            {
                Console.Write("Enter Postcode : ");
                id = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                goto insert;
            }
            Console.WriteLine(  );
            foreach (DictionaryEntry dicstudent in student)
            {
                if (dicstudent.Key.Equals(id.ToString())) 
                    Console.WriteLine(dicstudent.Key + "    " + dicstudent.Value);
            }
            Console.ReadKey();
        }
    }
}
