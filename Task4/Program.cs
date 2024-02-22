using Task4;

var country1 = new Country("Tajikistan","Dushanbe",953645,"Tajik");
country1.SetCapital("Dushanbe");
country1.SetPopulation(9537645);
System.Console.WriteLine(country1.GetCapital());
System.Console.WriteLine($"Population: {country1.GetPopulation()}");
country1.SetOfficialLanguage("Tajik");
System.Console.WriteLine(country1.GetOfficialLanguage());