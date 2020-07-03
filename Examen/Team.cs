using System;
using System.Collections.Generic;

namespace Examen
{
    public class Team
    {
        private string TeamType;
        private string TeamName;
        private string TeamNation;
        private Coach TeamCoach;
        private Medic TeamMedic;
        public List<Player> FieldPlayers = new List<Player>();
        public List<Player> TeamPlayers = new List<Player>();

        public Team(string teamtype, string teamname)
        {
            this.TeamType = teamtype;
            this.TeamName = teamname;
        }

        public void DisplayTeamMembers()
        {
            Console.WriteLine("Team " + TeamName + ":");
            if(TeamCoach != null)
            {
                Console.WriteLine("Team coach: " + TeamCoach.GetName());
            }
            else
            {
                Console.WriteLine("The team has no coach yet.");
            }
            if(TeamMedic != null)
            {
                Console.WriteLine("Team medic: " + TeamMedic.GetName());
            }
            else
            {
                Console.WriteLine("The team has no medic yet.");
            }
            if (TeamPlayers.Count != 0)
            {
                int i = 0;
                Console.WriteLine("This team has " + TeamPlayers.Count.ToString() + " players.");
                foreach(Player player in TeamPlayers)
                {
                    Console.WriteLine(i + " - " + player.GetName());
                    i++;
                }
            }
            else
            {
                Console.WriteLine("The team has no players yet.");
            }
        }

        public void AddTeamPlayer(Player player)
        {
            if(TeamType == "National")
            {
                if(TeamNation == null)
                {
                    TeamPlayers.Add(player);
                    TeamNation = player.GetNationality();
                    Console.WriteLine("Player added successfully.");
                }
                else
                {
                    if(player.GetNationality() == TeamNation)
                    {
                        TeamPlayers.Add(player);
                        Console.WriteLine("Player added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Player and team are not of the same nationality.");
                        return;
                    }
                }
            }
            else
            {
                TeamPlayers.Add(player);
                Console.WriteLine("Player added successfully.");
            }
        }

        public void SetTeamCoach(Coach coach)
        {
            if (TeamType == "National")
            {
                if (TeamNation == null)
                {
                    TeamCoach = coach;
                    TeamNation = coach.GetNationality();
                    Console.WriteLine("Coach set successfully.");
                }
                else
                {
                    if (coach.GetNationality() == TeamNation)
                    {
                        TeamCoach = coach;
                        Console.WriteLine("Coach set successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Coach and team are not of the same nationality.");
                        return;
                    }
                }
            }
            else
            {
                TeamCoach = coach;
                Console.WriteLine("Coach set successfully.");
            }
        }

        public void SetTeamMedic(Medic medic)
        {
            if (TeamType == "National")
            {
                if (TeamNation == null)
                {
                    TeamMedic = medic;
                    TeamNation = medic.GetNationality();
                    Console.WriteLine("Medic set successfully.");
                }
                else
                {
                    if (medic.GetNationality() == TeamNation)
                    {
                        TeamMedic = medic;
                        Console.WriteLine("Medic set successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Medic and team are not of the same nationality.");
                        return;
                    }
                }
            }
            else
            {
                TeamMedic = medic;
                Console.WriteLine("Medic set successfully.");
            }
        }
    }
}
