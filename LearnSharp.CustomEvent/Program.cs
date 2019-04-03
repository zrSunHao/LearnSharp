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
            Bridegroom bridegroom = new Bridegroom();

            //实例化朋友对象
            Friend friend1 = new Friend("张三");
            Friend friend2 = new Friend("李四");
            Friend friend3 = new Friend("王五");

            //使用“+=”来订阅事件
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend1.SendMessage);
            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend2.SendMessage);

            bridegroom.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");
            Console.WriteLine("-----------------");

            bridegroom.MarryEvent -= new Bridegroom.MarryHandler(friend2.SendMessage);

            bridegroom.MarryEvent += new Bridegroom.MarryHandler(friend3.SendMessage);

            bridegroom.OnMarriageComing("朋友们，我结婚了，到时候准时参加婚礼！");
            Console.Read();
        }


        
    }
}
