using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DarzaChecker
{
    static class Data
    {
        public static List<string> ComboList = new List<string>();
        static List<Proxy> ProxyList = new List<Proxy>();

        public static int CPM = 0;

        public static int Checked = 0;

        public static List<string> Hits = new List<string>();



        static object LOCKER = new object();

        private static string OpenDialog()
        {
            string file;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select Combolist";
            fd.ShowDialog();
            file = fd.FileName;

            return file;
        }
        public static void LoadCombos()
        {
            string[] _ComboList = File.ReadAllLines(OpenDialog());

            foreach (string line in _ComboList)
            {
                ComboList.Add(line);
            }
        }

        public static void LoadProxies()
        {
            string[] _ProxyList = File.ReadAllLines(OpenDialog());


            foreach (string line in _ProxyList)
            {
                ProxyList.Add(new Proxy(line));
            }
        }
    }
}
