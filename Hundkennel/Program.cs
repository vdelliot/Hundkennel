class Program
{
    static List<Dog> dogList = new List<Dog>();

    public static void Main(String[] args)
    {
        // Declares the KennelCompany class.
        KennelCompany KennelPrint = new KennelCompany();
        // Executes the varíable info function so that the information may be printed.
        // Declares the information for the dogs. 

        Dog Arcade = new Dog("Arcade", 500, 50, "Bloodhound", 6, 37, 60, "Female");
        Dog Caesar = new Dog("Caesar", 700, 35, "Pitbull", 4, 20, 53, "Male");
        Dog Archimedes = new Dog("Archimedes", 300, 100, "Borzoi", 8, 35, 85, "Male");
        Dog Joshua = new Dog("Joshua", 400, 70, "Doberman", 5, 41, 70, "Male");
        Dog Lanius = new Dog("Lanius", 1000, 10, "Bulldog", 4, 20, 40, "Female");

        dogList.Add(Arcade);
        dogList.Add(Caesar);
        dogList.Add(Archimedes);
        dogList.Add(Joshua);
        dogList.Add(Lanius);

        KennelPrint.KennelCompanyVariableInfo(dogList);


        //Dog DogPrint = new Dog();


        Console.WriteLine("Dog Information Below.");
        Console.WriteLine(dogList);
        // Prints the dog function for all of the separate dog classes.
        Arcade.PrintInfo();
        Caesar.PrintInfo();
        Archimedes.PrintInfo();
        Joshua.PrintInfo();
        Lanius.PrintInfo();
        Console.WriteLine("--------------------");
        // Executes the function RaceOrCrossing so that the user may be prompted to trigger the crossing or race event. 
        Program RaceOrCrossing = new Program();
        RaceOrCrossing.RaceOrCrossing();
        for (int i = 0; i < 100; i++)
        {
            try
            {
                KennelPrint.KennelCompanyVariableInfo(dogList);
                RaceOrCrossing.RaceOrCrossing();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
    class Dog
    // Declares variables to be used to apply information to the dog class.
    {
        string name;
        int hp;
        int stamina;
        string breed;
        int age;
        int weight;
        int height;
        string gender;
        int nrPuppies;


        public Dog(string name, int hp, int stamina, string breed, int age, int weight, int height, string gender, int nrPuppies = 0)
        {
            this.name = name;
            this.hp = hp;
            this.stamina = stamina;
            this.breed = breed;
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.gender = gender;
        }

        public void PrintInfo()
        // Actual breadtext for the information to be used in the different Dog classes. Function prints it. 
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("Stamina: " + stamina);
            Console.WriteLine("Breed: " + breed);
            Console.WriteLine("Age: " + age + " years old");
            Console.WriteLine("Weight: " + weight + " KG");
            Console.WriteLine("Height: " + height + " CM tall");
            Console.WriteLine("Gender: " + gender);
        }

        public int GetGender()
        {
            if (gender == "Female")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public string GetName()
        {
            return name;
        }

        public void addPuppy()
        {
            nrPuppies++;
        }

        public int GetNrPuppies()
        {
            return nrPuppies;
        }

    }
    class KennelCompany
    // Declares variables to be used to apply information to the KennelCompany class.
    {
        int dogAmount;
        string kennelName;
        int employeeAmount;
        string ceo;
        string kennelWelcome;
        int puppies;

        public void KennelCompanyVariableInfo(List<Dog> dogs)
        // Declares information for the kennel established in the Kennel class. Also declares WriteLine statements so that the information may be printed.

        {
            int dogAmount = dogs.Count;
            int puppies = 0;
            Console.WriteLine(kennelWelcome = "Welcome to Horizon Kennel Solutions.");
            Console.WriteLine("There are currently " + dogAmount + " dogs in this kennel.");
            for (int i = 0; i < dogs.Count; i++)
            {
                puppies += dogs[i].GetNrPuppies();
            }

            if (puppies == 1)
            {
                Console.WriteLine("There is currently 1 puppy in this kennel.");
            }
            else if (puppies > 1)
            {
                Console.WriteLine("There are currently " + puppies + " puppies in this kennel.");
            }
            else if (puppies < 1)
            {
                Console.WriteLine("There are currently no puppies in this kennel.");
            }
        }
    }
    public void RaceOrCrossing()
    // Declares information and prompts the user about the race or the crossing, triggers the race and crossing event through the 2 keywords.
    {
        Console.WriteLine("Do you wish to start a race with the five dogs, or cross two dogs? Write 'race' to race or 'cross' to cross two dogs.");
        string reply = Console.ReadLine();
        if (reply == "race")
        {
            KennelRace();
        }
        else if (reply == "cross")
        {
            DogCrossing();
        }
    }
    public void KennelRace()
    // The race event.
    {
        Console.WriteLine("Which course do you wish the dogs to race through? You have 3 options.");
        Console.WriteLine("********");
        Console.WriteLine("Star Track: 1km long, a strong test of endurance, as it is the lengthiest track.");
        Console.WriteLine("Forest Track: 600m long, a strong test of navigation ability, as the track is confusing.");
        Console.WriteLine("Mountain Track: 300m long, the shortest race, but the toughest one, requiring a lot of strength to climb.");
        Console.WriteLine("********");
        string startrack = "Star Track";
        string foresttrack = "Forest Track";
        string mountaintrack = "Mountain Track";

        // Prompts the user to start the race since the race is started through the RaceOrCrossing function instead of the KennelRace function which prompts upon reply from user within the RaceOrCrossing function.
        Console.WriteLine("Are you ready to start the race? Write 'yes' if you are ready.");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            // Generates a random number.
            Random rand = new Random();
            // Selects a random number from 1-5. 
            int winner = rand.Next(1, 5);

            Console.WriteLine("Race begins in...");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("GO!");

            int winningFormula1 = 6;

            // Different dogs win the race depending on the selected number deriving from the 'winner' variable.
            if (winner == 1)
            {
                Console.WriteLine("Arcade wins the race!");
            }
            else if (winner == 2)
            {
                Console.WriteLine("Archimedes wins the race!");
            }
            else if (winner == 3)
            {
                Console.WriteLine("Caesar wins the race!");
            }
            else if (winner == 4)
            {
                Console.WriteLine("Lanius wins the race!");
            }
            else if (winner == 5)
            {
                Console.WriteLine("Joshua wins the race!");
            }

        }
        else
        {
            Console.WriteLine("Oh well.");
        }
    }
    public void DogCrossing()
    // Function for dog crossing.
    {
        Console.WriteLine("Choose two dogs to cross.");
        Console.WriteLine("Choose a male dog. Choose either ");
        for (int i = 0; i < dogList.Count; i++)
        {
            if (dogList[i].GetGender() == 1)
            {
                Console.WriteLine(i + " -" + dogList[i].GetName());
            }
        }
        string maleDog = Console.ReadLine();
        int maleDogConverted = Convert.ToInt32(maleDog);
        Console.WriteLine("Choose a female dog. Choose either ");
        for (int i = 0; i < dogList.Count; i++)
        {
            if (dogList[i].GetGender() == 0)
            {
                Console.WriteLine(i + " -" + dogList[i].GetName());
            }
        }
        string femaleDog = Console.ReadLine();
        int femaleDogConverted = Convert.ToInt32(femaleDog);
        // The two string arrays ensure that two dogs of the same gender cannot be crossed. Also ensures that the dogs that are being crossed actually exist within the kennel. 


        if (maleDogConverted != 1 || maleDogConverted != 2 || maleDogConverted != 3)
        {
            Console.WriteLine("You have chosen " + dogList[maleDogConverted].GetName() + ".");
            if (femaleDogConverted != 0 || femaleDogConverted != 4)
            {
                Console.WriteLine("You have crossed " + dogList[femaleDogConverted].GetName() + " with " + dogList[maleDogConverted].GetName());
                Console.WriteLine(dogList[femaleDogConverted].GetName() + " has given birth to a new puppy. ");
                dogList[femaleDogConverted].addPuppy();
            }
            else
            {
                Console.WriteLine("Retry.");
            }
        }
        else
        {
            Console.WriteLine("Retry.");
        }
    }
}