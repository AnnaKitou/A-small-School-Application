using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.RepositoryService;
using yourname_individual_part_a.View.ViewTrainers;

namespace yourname_individual_part_a.Controllers
{
    class TrainerController
    {
        TrainerRepository trainerService = new TrainerRepository();
        public void ReadTrainers()
        {
            var trainers = trainerService.GetAll();
            ViewTrainer.PrintTrainers(trainers);
        }
        public void CreateTrainer()
        {
            string input = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to create a Trainer? Press 'Y' for Yes or 'N' for No, to go back to main menu.");
                input = Console.ReadLine().ToUpper();
                Console.ResetColor();
                if (input == "Y")
                {
                    var trainer = ViewTrainer.CreateTrainer();
                    trainerService.Create(trainer);
                }
                else if (input == "N")
                {
                    Console.WriteLine("You exited the Trainer's Creation");
                }
            } while (input != "N");
        }
    }
}
