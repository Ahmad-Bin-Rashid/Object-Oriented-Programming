using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Set
    {
        private string name;
        private int repitition;
        private int weight;

        public Set(string name, int repitition, int weight)
        {
            this.name = name;
            this.repitition = repitition;
            this.weight = weight;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetRepitition()
        {
            return this.repitition;
        }

        public int GetWeight()
        {
            return this.weight;
        }


    }

    class Exercise
    {
        private string name;
        private List<Set> sets = new List<Set>();

        public Exercise(string name)
        {
            this.name = name;
        }

        public void AddSet(Set set)
        {
            sets.Add(set);
        }

        public string GetName()
        {
            return this.name;
        }

        public void PrintExercise()
        {
            Console.WriteLine($"Name: {this.name}\t");
            foreach (var s in sets)
            {
                Console.WriteLine($"Name: {s.GetName()}\t Repitition: {s.GetRepitition()}\t Weight: {s.GetWeight()}");
            }
        }
    }

    class WorkoutRoutine
    {
        private string name;
        private List<Exercise> exercises = new List<Exercise>();

        public WorkoutRoutine(string name)
        {
            this.name = name;
        }

        public void AddExercise(string name)
        {
            Exercise e = new Exercise(name);
            exercises.Add(e);
        }

        public void AddSetToExercise(string name, Set set)
        {
            foreach (var e in exercises)
            {
                if (e.GetName() == name)
                {
                    e.AddSet(set);
                }
            }
        }

        public void PrintWorkout()
        {
            Console.WriteLine($"Workout: {this.name}");
            foreach (var e in exercises)
            {
                e.PrintExercise();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Set s1 = new Set("Set-1", 5, 20);
            Set s2 = new Set("Set-2", 20, 10);
            Set s3 = new Set("Set-3", 10, 15);
            Set s4 = new Set("Set-4", 15, 5);
            Set s5 = new Set("Set-5", 25, 5);
            Set s6 = new Set("Set-6", 20, 15);
            Set s7 = new Set("Set-7", 15, 15);

            WorkoutRoutine w1 = new WorkoutRoutine("Routine-1");

            w1.AddExercise("Exercise-1");
            w1.AddSetToExercise("Exercise-1", s1);
            w1.AddSetToExercise("Exercise-1", s2);
            w1.AddSetToExercise("Exercise-1", s3);
            w1.AddSetToExercise("Exercise-1", s4);
            w1.AddSetToExercise("Exercise-1", s5);
            w1.AddExercise("Exercise-2");
            w1.AddSetToExercise("Exercise-2", s4);
            w1.AddSetToExercise("Exercise-2", s5);
            w1.AddSetToExercise("Exercise-2", s6);
            w1.AddSetToExercise("Exercise-2", s7);

            w1.PrintWorkout();
            Console.ReadKey();
        }
    }
}
