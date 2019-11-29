using ObserverDesignPattern.Observers;
using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            KyungraeWrestlingCareer kyungraeWrestling = new KyungraeWrestlingCareer();

            Chris chris = new Chris();
            Amanda amanda = new Amanda();
            Enrique enrique = new Enrique();
            Biniam biniam = new Biniam();
            Karina karina = new Karina();

            kyungraeWrestling.RegisterObserver(chris);
            kyungraeWrestling.RegisterObserver(amanda);
            kyungraeWrestling.RegisterObserver(enrique);
            kyungraeWrestling.RegisterObserver(biniam);
            kyungraeWrestling.RegisterObserver(karina);


            kyungraeWrestling.SendMatchResult();

            chris.Results.ForEach(x => Console.WriteLine(x.Score));
            amanda.Results.ForEach(x => Console.WriteLine(x.Score));
            enrique.Results.ForEach(x => Console.WriteLine(x.Score));
            biniam.Results.ForEach(x => Console.WriteLine(x.Score));
            karina.Results.ForEach(x => Console.WriteLine(x.Score));

        }
    }
}
