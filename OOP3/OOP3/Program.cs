using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new();
            m1.MyProperty = 10;

            //MyClass m2 = null;
            //m2.MyProperty = 20;  // null refereance hatası verir

            // null olan yani nesnesi olmayan refereanslar herhangi bir memberı çağırıp islemeye çalıştıgımızda bu durumda 
            // null referans hatası verir

            #region Referanssız Nesne 

            // Garbage Collector : c# ın  özel bellek optimizasyonu için temizlenen bir araçtır
            // Garbage Collector ile referanssız nesneler imha edilir

            new MyClass(); // bu nesne heap e yerleştirilir bir daha da erişemeyiz 
                           // referanssız nesnedir  


            #endregion

            #region Object Inıtılazior

            MyClass m3 = new MyClass()
            {
                MyProperty = 10,
                MyProperty2 = 20,           // nesnenin defaultu bunlardır egersonradan m3.MyProperty deyip nesnenin değğeri
                MyProperty3 = 30            // değiştirilebilir
            };
            m3.MyProperty3 = 20;
            Console.WriteLine(m3.MyProperty3);

            #endregion


            #region Shallow Copy

            #region Ornek1 

            //ShallowCopy copy = new ShallowCopy();
            //ShallowCopy copy1 = copy;  // eğer bu deger turlu olsaydı deep copy olurdu ama referans oldugu ıcın shallow copy
            //ShallowCopy copy2 = copy1;  // ornegın copy.function = gelen degeri samet ise copy1.function() = samet olur 
            //ShallowCopy copy3 = new ShallowCopy();          //  copy2.function() = samet olur 
            //                                                // fakat copy3.funciton() = samet olmaz cunku diğer nesneler
            //                                                // biririni shallow copy etmil

            //ShallowCopy copy = null;   // Bu refereans bir şey işaretlemez
            //ShallowCopy copy1 = new ShallowCopy(); 
            //ShallowCopy copy2 = copy1;   // shallow copy yapılır
            //copy1 = copy2;                  // daha sonradan referansarın işaretlerdiği nesne değişebilir bu satır bunu gösterir.

            #endregion


            #endregion
            #region Deep Copy 

            ShallowCopy copy = new ShallowCopy();
            ShallowCopy copy2 = copy; // shallow copy
            ShallowCopy copy1 = copy.Clone(); // deep copy


            #endregion

        }
    }
    class MyClass
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }

     class ShallowCopy
    {

        public ShallowCopy Clone()
        {
            return (ShallowCopy)this.MemberwiseClone();
        }
    }
}
