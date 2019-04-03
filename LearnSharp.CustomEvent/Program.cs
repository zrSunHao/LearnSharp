using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSharp.CustomEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            //Bridegroom bridegroom = new Bridegroom();

            ////实例化朋友对象
            //Friend friend1 = new Friend("张三");
            //Friend friend2 = new Friend("李四");
            //Friend friend3 = new Friend("王五");

            ////使用“+=”来订阅事件
            //bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend1.SendMessage);
            //bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend2.SendMessage);

            //bridegroom.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");
            //Console.WriteLine("-----------------");

            //bridegroom.MarryEvent -= new Bridegroom.MarryHandler(friend2.SendMessage);

            //bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend3.SendMessage);

            //bridegroom.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");

            #endregion


            #region 2

            //Bridegroom1 bridegroom1 = new Bridegroom1();

            ////实例化朋友对象
            //Friend1 friend1 = new Friend1("张三");
            //Friend1 friend2 = new Friend1("李四");
            //Friend1 friend3 = new Friend1("王五");

            ////使用“+=”来订阅事件
            //bridegroom1.MarryEvent += new EventHandler(friend1.SendMessage);
            //bridegroom1.MarryEvent += new EventHandler(friend2.SendMessage);

            //bridegroom1.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");
            //Console.WriteLine("-----------------");

            //bridegroom1.MarryEvent -= new EventHandler(friend2.SendMessage);

            //bridegroom1.MarryEvent += new EventHandler(friend3.SendMessage);

            //bridegroom1.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");

            #endregion


            #region 3

            Bridegroom2 bridegroom2 = new Bridegroom2();

            //实例化朋友对象
            Friend2 friend1 = new Friend2("张三");
            Friend2 friend2 = new Friend2("李四");
            Friend2 friend3 = new Friend2("王五");

            //使用“+=”来订阅事件
            bridegroom2.MarryEvent += new Bridegroom2.MarryHandler(friend1.SendMessage);
            bridegroom2.MarryEvent += new Bridegroom2.MarryHandler(friend2.SendMessage);

            bridegroom2.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");
            Console.WriteLine("-----------------");

            bridegroom2.MarryEvent -= new Bridegroom2.MarryHandler(friend2.SendMessage);

            bridegroom2.MarryEvent += new Bridegroom2.MarryHandler(friend3.SendMessage);

            bridegroom2.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");

            #endregion




            Console.Read();
        }


        
    }
}
