using System;
using System.Linq;

namespace MongoDogsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //  print out a count of the records to know we are connected.
            MongoDogDB db = new MongoDogDB();

            count_dogs(db);

            Console.WriteLine("-- Filter --");

            filter_FindBreeds(db, "Welsh Terrier");
            filter_FindBreeds(db, "Scooby Doo");

            Console.WriteLine("\n-- LinqBreed --");

            LinqBreed(db, "Welsh Terrier");
            LinqBreed(db, "Scooby Doo");

            //  This is my ending tag just so I know that I didn't abort.
            Console.WriteLine("\n-- Dogs of Zurich --");
        }

        private static void count_dogs(MongoDogDB db)
        {
            var recs = db.CallingAllDogs();
            int count = 0;
            foreach (var rec in recs)
            {
                count++;
            }

            Console.WriteLine($"\nRecords: {count}");
        }
        private static void filter_FindBreeds(MongoDogDB db, string input_breed)
        {
            Console.WriteLine(input_breed);

            var recs = db.filter_FindABreed(input_breed);

            if (recs.Count == 0)
            {
                Console.WriteLine($"  {input_breed} not found");
                return;
            }


            foreach (var rec in recs)
            {
                print_breed(rec);

            }
        }
        static void LinqBreed(MongoDogDB db, string input_breed)
        {



            var dogs = db.CallingAllDogs();

            var breed_q =
               (from dog in dogs
                where dog.Breed1 == input_breed
                select dog).ToList();

            if (breed_q.Count == 0)
            {
                Console.WriteLine($"  {input_breed} not found");
                return;
            }

            foreach (var b in breed_q)
                print_breed(b);


        }
        static void print_breed(DogModel b)
        {
            Console.WriteLine($"{b.OwnerID}, {b.Breed1}, {b.DogGender}, {b.DogColor}");

        }
    }
}
 
