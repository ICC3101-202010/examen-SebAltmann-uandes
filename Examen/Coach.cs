using System;
namespace Examen
{
    public class Coach : Person
    {
        private int TacticPoints;

        public Coach(string name, int age, string nationality, int salary, int tacticpoints) : base(name, age, nationality, salary)
        {
            this.TacticPoints = tacticpoints;
        }

        public void ChangePlayer(Player pOut, Player pIn)
        {
            return;
        }
    }
}
