namespace LearnSharp.BasicKnowledge.OperatorLoading
{
        /// <summary>
        /// Complex结构体属于一个自定义结构体
        /// </summary>
        public struct Complex
        {
            //复数的实数部分
            public int Real;

            //复数的虚数部分
            public int Imaginary;

            //带参数的构造函数，real表示实数，imaginary表示虚数
            public Complex(int real,int imaginary)
            {
                //初始化复数的实数和虚数
                this.Real = real;
                this.Imaginary = imaginary;
            }

            /// <summary>
            /// + 运算符重载方法
            /// </summary>
            /// <param name="complex1">第一个操作参数</param>
            /// <param name="complex2">第二个操作参数</param>
            /// <returns></returns>
            public static Complex operator +(Complex complex1, Complex complex2)
            {
                //值类型都有默认无参构造函数
                //通过无参构造函数进行初始化
                var result = new Complex();

                //对复数的实数和虚数赋值
                result.Real = complex1.Real + complex1.Real;
                result.Imaginary = complex2.Imaginary + complex2.Imaginary;

                //返回复数相加结构
                return result;
            }

            /// <summary>
            /// 重写ToString接口
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return string.Format("{0}+{1}i", Real, Imaginary);
            }
        }
    
}
