//註解
//這是單行註解
/*這是
        雙行
            註解*/



//常見資料型態 
//字串 string
System.Console.WriteLine("我是一隻可愛白斬雞");

//字元 char
System.Console.WriteLine('a');

//整數 int
System.Console.WriteLine(100);

//浮點數 double
System.Console.WriteLine(160.5555);

//布林值 bool
System.Console.WriteLine(true);
System.Console.WriteLine(false);



//變數
string name = "錚錚";
System.Console.WriteLine(name+"今年27歲");
System.Console.WriteLine(name+"身高160.5");
System.Console.WriteLine(name+"很可愛");

name = "小白";
System.Console.WriteLine(name + "很可愛");



//字串常見的用法
//(1)  換行( /n )
System.Console.WriteLine("Hello \nMr.Right");
//(2) 在字串裡表達雙引號(\")
System.Console.WriteLine("Hello\" Mr.Right");
//(3) 字串相加 -> 連接在一起
System.Console.WriteLine("Hello" + "Mr.Right");
//(4) 字串的長度(.Length)
System.Console.WriteLine("Hello   ".Length);


//字串的方法
//(1) 字母轉成大寫 ( ToUpper() )
System.Console.WriteLine( "happ 依錚".ToUpper() );
//(2)字母轉成小寫( ToLower() )
System.Console.WriteLine( "HAPPY".ToLower());
//(3)字串是否含有特定的子字串( .Contains("子字串") )
System.Console.WriteLine( "Happy".Contains("yp") );
//(4)字串特定位置的值是什麼？( [索引] )
System.Console.WriteLine( "Happy"[0] );
//(5)以字元找索引位置( .IndexOf(' ') )
System.Console.WriteLine("Happy".IndexOf('p'));
System.Console.WriteLine("Happy".IndexOf('b')); //找不到給-1
System.Console.WriteLine("Happy time".IndexOf("time")); //如果給的是字串 找第一個字母
//(6)字串第Ｎ位以前刪掉 ( .Substring(N) )
System.Console.WriteLine("Happy".Substring(2));
System.Console.WriteLine("Happy".Substring(1, 2)); //字串第一位以前刪掉，往後留兩位 