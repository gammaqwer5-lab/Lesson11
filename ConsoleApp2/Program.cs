using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main()
        {
            DataTable table = new DataTable("Students");

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(int));
            table.Columns.Add("GroupName", typeof(string));

            table.Rows.Add(1, "Иван Иванов", 17, "A");
            table.Rows.Add(2, "Егор Смирнов", 18, "B");
            table.Rows.Add(3, "Александр Попов", 16, "C");
            table.Rows.Add(4, "Максим Кузнецов", 20, "A");
            table.Rows.Add(5, "Артем Соколов", 18, "B");

            int maxAge = 0;
            DataRow oldestRow = null;

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"{row["Id"],-3} {row["Name"],-20} {row["Age"],-4} {row["GroupName"],-5}");
            }

            foreach (DataRow row in table.Rows)
            {
                int currentAge = (int)row["Age"];
                if (currentAge > maxAge)
                {
                    maxAge = currentAge;
                    oldestRow = row;
                }
            }
            Console.WriteLine($"\n{oldestRow["Id"],-3} {oldestRow["Name"],-20} {oldestRow["Age"],-4} {oldestRow["GroupName"],-5}");
        }
    }
}