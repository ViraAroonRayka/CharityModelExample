using CharityModelExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CharityModelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Initializer initializer = new Initializer();
            Needee needee = initializer.fillNeedee();
            List<Skill> skills = initializer.fillSkills();
            List<Skill> cSharpSkills = skills.Where(s => s.Title.Contains("C#")).ToList();

            

            foreach(Skill s in cSharpSkills)
            {
                Console.WriteLine(s.Title +
                    " Skill Level: " + s.skillLevel.ToString() + " Has Certificate: "+ s.HasCertificate);
            }
            List<Needee> needees = initializer.fillNeedees();
            List<Needee> ManNeedees =  needees.Where(n => n.isWoman == false).ToList();

            foreach(Needee n in ManNeedees)
            {
                Console.WriteLine($"{n.FirstName} {n.LastName}, isWoman: {n.isWoman}, \nNational Code: {n.NationalCode}");
            }


        }
    }
}
