using DP_Builder.Model;
using DP_Builder.Model.Builder;
using DP_Builder.Model.Concrete;
using DP_Builder.Model.Director;
using System;

namespace DP_Builder
{
    class Program
    {
        //http://cagataykiziltan.net/tasarim-kaliplari-design-patterns/1-creational-tasarim-kaliplari/builder-design-patttern/
//Builder Pattern aktörleri aşağıdaki gibidir.
//Builder: Product nesnesinin oluşturulması için gereken soyut arayüzü oluşturur.Interface ya da abstract class olabilir. Concrete builderlar için parent niteliğindedir.
//ConcreteBuilder: Builder arayüzünü kullanarak implemente edilen concrete builderlar, nesne tiplerini build eden concrete classlardır.Her bir concrete builder bir sunumu build eder.
//Product: Concrete builderlar tarafından üretilen clienta sunulan productır.
//Director : Kendisine parametre olarak verilen concreteBuilder nesnesi ile Builder arayüzü üzerinden clienta nesne oluşturan classtır.
        static void Main(string[] args)
        {
            IHouseBuilder iglooBuilder = new IglooHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(iglooBuilder);
            engineer.constructHouse();

            House house = engineer.getHouse();

            Console.WriteLine("Builder constructed: " + house);
            Console.ReadKey();
        }
    }
}
