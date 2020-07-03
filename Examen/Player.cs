using System;
namespace Examen
{
    public class Player : Person
    {
        private int AttackPoints;
        private int DefensePoints;
        private int Number;
        private bool Goalie;
        private bool Hurt;

        public Player(string name, int age, string nationality, int salary, int attackpoints, int defensepoints, int number, bool goalie, bool hurt): base(name, age, nationality, salary)
        {
            this.AttackPoints = attackpoints;
            this.DefensePoints = defensepoints;
            this.Number = number;
            this.Goalie = goalie;
            this.Hurt = hurt;
        }

        public bool IsGoalie()
        {
            return Goalie;
        }

        public bool IsHurt()
        {
            return Hurt;
        }
    }
}
