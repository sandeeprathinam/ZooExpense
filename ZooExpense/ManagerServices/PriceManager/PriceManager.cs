using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooExpense.ManagerServices.FileManager;
using ZooExpense.Models;

namespace ZooExpense.ManagerServices.PriceManager
{
    public class PriceManager: IPriceManager
    {
        private readonly IFileManager fileManager;
        


        public PriceManager(IFileManager fileManager)
        {
            this.fileManager = fileManager;
            
        }

        public ExpensesViewModel CalculateExpense(ExpensesViewModel expensesViewModel)
        {
            expensesViewModel.animals = fileManager.GetAnimals("Animals.csv", expensesViewModel.animals);
            expensesViewModel.prices = fileManager.GetPrices("price.txt", new Dictionary<string, double>());
            expensesViewModel.zoo = fileManager.FileReader(expensesViewModel.zoo, "Zoo.xml");
            if(expensesViewModel.zoo.Giraffes.Giraffe.Count()>0)
            {
                foreach (var item in expensesViewModel.zoo.Giraffes.Giraffe)
                {
                    expensesViewModel.zoo.Giraffes.Giraffe.FirstOrDefault(x => x.Name == item.Name).Price = CalculateInvidualExpense(item, "Giraffe", expensesViewModel.animals, expensesViewModel.prices);
                    expensesViewModel.price += expensesViewModel.zoo.Giraffes.Giraffe.FirstOrDefault(x => x.Name == item.Name).Price;
                }
               
            }
            if (expensesViewModel.zoo.Lions.Lion.Count() > 0)
            {
                foreach (var item in expensesViewModel.zoo.Lions.Lion)
                {
                    expensesViewModel.zoo.Lions.Lion.FirstOrDefault(x => x.Name == item.Name).Price = CalculateInvidualExpense(item, "Lion", expensesViewModel.animals, expensesViewModel.prices);
                    expensesViewModel.price += expensesViewModel.zoo.Lions.Lion.FirstOrDefault(x => x.Name == item.Name).Price;
                }
            }
            if (expensesViewModel.zoo.Zebras.Zebra.Count() > 0)
            {
                foreach (var item in expensesViewModel.zoo.Zebras.Zebra)
                {
                    expensesViewModel.zoo.Zebras.Zebra.FirstOrDefault(x => x.Name == item.Name).Price = CalculateInvidualExpense(item, "Zebra", expensesViewModel.animals, expensesViewModel.prices);
                    expensesViewModel.price += expensesViewModel.zoo.Zebras.Zebra.FirstOrDefault(x => x.Name == item.Name).Price;
                }
            }
            if (expensesViewModel.zoo.Tigers.Tiger.Count() > 0)
            {
                foreach (var item in expensesViewModel.zoo.Tigers.Tiger)
                {
                    expensesViewModel.zoo.Tigers.Tiger.FirstOrDefault(x => x.Name == item.Name).Price = CalculateInvidualExpense(item, "Tiger", expensesViewModel.animals, expensesViewModel.prices);
                    expensesViewModel.price += expensesViewModel.zoo.Tigers.Tiger.FirstOrDefault(x => x.Name == item.Name).Price;
                }
            }
            if (expensesViewModel.zoo.Piranhas.Piranha.Count() > 0)
            {
                foreach (var item in expensesViewModel.zoo.Piranhas.Piranha)
                {
                    expensesViewModel.zoo.Piranhas.Piranha.FirstOrDefault(x => x.Name == item.Name).Price = CalculateInvidualExpense(item, "Piranha", expensesViewModel.animals, expensesViewModel.prices);
                    expensesViewModel.price += expensesViewModel.zoo.Piranhas.Piranha.FirstOrDefault(x => x.Name == item.Name).Price;
                }
            }
            if (expensesViewModel.zoo.Wolves.Wolf.Count() > 0)
            {
                foreach (var item in expensesViewModel.zoo.Wolves.Wolf)
                {
                    expensesViewModel.zoo.Wolves.Wolf.FirstOrDefault(x => x.Name == item.Name).Price = CalculateInvidualExpense(item, "Wolf", expensesViewModel.animals, expensesViewModel.prices);
                    expensesViewModel.price += expensesViewModel.zoo.Wolves.Wolf.FirstOrDefault(x => x.Name == item.Name).Price;
                }
            }


            return expensesViewModel;
        }

        public double CalculateInvidualExpense(dynamic data,string animaltype,List<Animals> animals, Dictionary<string, double> Prices)
        {

            var animaldata = animals.FirstOrDefault(x => x.Type == animaltype);
            if (animaldata.FoodType == "both")
            {
                
                    var quantity = data.Kg * animaldata.Rate;
                    var meatquanity = (quantity * Convert.ToDouble(animaldata.SplitPercentage.Replace("%",string.Empty)))/100;
                    var fruirquantity = quantity - meatquanity;
                    return Math.Round(Prices["meat"]* meatquanity + Prices["fruit"] * fruirquantity,2);
                
            }
            else
            {
                
                    return Math.Round(data.Kg * animaldata.Rate * Prices[animaldata.FoodType.ToLower()],2);
                
            }
           
        }


    }
}
