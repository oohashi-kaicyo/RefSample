using System;

namespace RefSample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Hoge a = new Hoge();
			Hoge b = new Hoge();
             Fuga(a, b);
            swapAndEdit(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a.A, b.A);
        }
        public static void Fuga(Hoge a, Hoge b) {
            a.A = 100;
            b.A = 200;
        }
		public static void swapAndEdit(Hoge left, Hoge right)
		{
			var tmp = left;
			// 仮引数の値(格納されているアドレス)を変更しても，もともとの参照型変数が
			// 格納しているアドレスは不変
			left = right;
			right = tmp;
            // インスタンスに対する変更は反映される
			tmp.A *= 100;
		}
        public static void swapAndEdit(ref Hoge left, ref Hoge right) {
			var tmp = left;
			// 仮引数の値(格納されているアドレス)を変更すると，もともとの参照型変数が
			// 格納しているアドレスも変化
			left = right;
			right = tmp;
			// インスタンスに対する変更は反映される
			tmp.A *= 100;
        }
    }
    class Hoge
    {
        public int A {get; set;}
    }
	class Fuga
	{
		public int B { get; set; }
	}
}
