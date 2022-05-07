using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DarzaChecker
{
    public static class UI
    {
        public static void PrintTitle()
        {
            Console.WriteLine(@"                                                                                                                  
    ,o888888o.     8 888888888o.    `8.`8888.      ,8' d888888o.      d888888o.   8 8888888888 `8.`8888.      ,8' 
 . 8888     `88.   8 8888    `^888.  `8.`8888.    ,8'.`8888:' `88.  .`8888:' `88. 8 8888        `8.`8888.    ,8'  
,8 8888       `8b  8 8888        `88. `8.`8888.  ,8' 8.`8888.   Y8  8.`8888.   Y8 8 8888         `8.`8888.  ,8'   
88 8888        `8b 8 8888         `88  `8.`8888.,8'  `8.`8888.      `8.`8888.     8 8888          `8.`8888.,8'    
88 8888         88 8 8888          88   `8.`88888'    `8.`8888.      `8.`8888.    8 888888888888   `8.`88888'     
88 8888         88 8 8888          88    `8. 8888      `8.`8888.      `8.`8888.   8 8888            `8. 8888      
88 8888        ,8P 8 8888         ,88     `8 8888       `8.`8888.      `8.`8888.  8 8888             `8 8888      
`8 8888       ,8P  8 8888        ,88'      8 8888   8b   `8.`8888. 8b   `8.`8888. 8 8888              8 8888      
 ` 8888     ,88'   8 8888    ,o88P'        8 8888   `8b.  ;8.`8888 `8b.  ;8.`8888 8 8888              8 8888      
    `8888888P'     8 888888888P'           8 8888    `Y8888P ,88P'  `Y8888P ,88P' 8 888888888888      8 8888      

");
        }

        public static int QueryOption(string[] options)
        {
            for (int i = 1; i <= options.Length; i++)
            {
               
                Console.WriteLine($"[{i}] " + options[i - 1]);
            }
            Console.WriteLine();
            int option = Convert.ToInt32(Console.ReadLine());
            return option - 1;
        }
        public static void QueryProxy()
        {
            while (true)
            {
                Console.WriteLine("[Y/N] Use proxies?");


                if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
                {
                    Data.LoadProxies();
                    return;
                }
                else if (Console.ReadLine() == "n" || Console.ReadLine() == "N")
                {
                    return;

                }
            }
        }


    

    }
}
