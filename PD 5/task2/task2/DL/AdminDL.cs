using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class AdminDL
    {
        public static List<Admin> adminList = new List<Admin>();

        public static void AddAdmin(Admin admin)
        {
            adminList.Add(admin);
        }

        public static List<Admin> GetAdminList()
        {
            return adminList;
        }

        public static bool IsValidAdmin(string userName)
        {
            foreach (var admin in adminList)
            {
                if (admin.GetUsername() == userName)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckAdmin(string userName, string password)
        {
            foreach (var user in adminList)
            {
                if (user.GetUsername() == userName && user.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static string CheckRole(string userName)
        {
            string role = null;
            foreach (var user in adminList)
            {
                if (user.GetUsername() == userName)
                {
                    role = user.GetRole();
                }

            }
            return role;
        }

        public static Admin GetAdmin(string userName)
        {
            foreach (var user in adminList)
            {
                if (user.GetUsername() == userName)
                {
                    return user;
                }
            }
            return null;
        }

        public static void ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;

                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');

                    string username = splittedrecord[0];
                    string password = splittedrecord[1];

                    Admin admin = new Admin(username, password);
                    adminList.Add(admin);
                }
                f.Close();
            }
        }

        public static void WriteToFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (var admin in adminList)
            {
                f.WriteLine(admin.GetUsername() + "," + admin.GetPassword());
            }
            f.Flush();
            f.Close();
        }
    }
}
