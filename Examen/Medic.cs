using System;
namespace Examen
{
    public class Medic : Person
    {
        private int EXP;

        public Medic(string name, int age, string nationality, int salary) : base(name, age, nationality, salary)
        {
        }

        public void GainEXP(int xp)
        {
            this.EXP += xp;
        }

        public void Evaluate(Player player)
        {
            return;
        }

        public void Heal(Player player)
        {
            return;
        }
    }
}
