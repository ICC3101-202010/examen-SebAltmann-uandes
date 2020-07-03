using System;

namespace Examen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Team NationalTestTeam = new Team("National", "National Test Team");
            Team LeagueTestTeam = new Team("League", "League Test Team");

            Coach C = new Coach("TestCoach", 45, "Chile", 15000000, 15);

            Medic M = new Medic("TestMedic", 35, "Chile", 7500000);

            Player P1 = new Player("PlayerOne", 18, "Chile", 5000000, 25, 15, 1, false, false);
            Player P2 = new Player("PlayerTwo", 19, "Chile", 5000000, 5, 35, 2, false, false);
            Player P3 = new Player("PlayerThree", 20, "Chile", 5000000, 25, 15, 3, false, false);
            Player P4 = new Player("PlayerFour", 21, "Chile", 5000000, 25, 15, 4, false, false);
            Player P5 = new Player("PlayerFive", 22, "Chile", 5000000, 25, 15, 5, false, false);
            Player P6 = new Player("PlayerSix", 23, "Chile", 5000000, 25, 15, 6, false, false);
            Player P7 = new Player("PlayerSeven", 24, "Chile", 5000000, 25, 15, 7, false, false);
            Player P8 = new Player("PlayerEight", 25, "Chile", 5000000, 25, 15, 8, false, false);
            Player P9 = new Player("PlayerNine", 26, "Chile", 5000000, 25, 15, 9, false, false);
            Player P10 = new Player("PlayerTen", 27, "Chile", 5000000, 25, 15, 10, false, false);
            Player P11 = new Player("PlayerEleven", 28, "Chile", 5000000, 25, 15, 11, false, false);
            Player P12 = new Player("PlayerTwelve TestGoalie", 29, "Chile", 5000000, 25, 99, 12, true, false);
            Player P13 = new Player("PlayerThirteen", 30, "USA", 5000000, 25, 15, 13, false, false);
            Player P14 = new Player("PlayerFourteen", 22, "Chile", 5000000, 25, 15, 14, false, false);
            Player P15 = new Player("PlayerFifteen", 21, "Chile", 5000000, 25, 15, 15, false, false);
            Player P16 = new Player("PlayerSixteen", 27, "Chile", 5000000, 25, 15, 16, false, false);

            NationalTestTeam.DisplayTeamMembers();
            LeagueTestTeam.DisplayTeamMembers();

            NationalTestTeam.SetTeamCoach(C);
            NationalTestTeam.DisplayTeamMembers();
            NationalTestTeam.SetTeamMedic(M);
            NationalTestTeam.DisplayTeamMembers();

            NationalTestTeam.AddTeamPlayer(P1);
            NationalTestTeam.AddTeamPlayer(P2);
            NationalTestTeam.AddTeamPlayer(P3);
            NationalTestTeam.AddTeamPlayer(P4);
            NationalTestTeam.AddTeamPlayer(P5);
            NationalTestTeam.AddTeamPlayer(P6);
            NationalTestTeam.AddTeamPlayer(P7);
            NationalTestTeam.AddTeamPlayer(P8);
            NationalTestTeam.AddTeamPlayer(P9);
            NationalTestTeam.AddTeamPlayer(P10);
            NationalTestTeam.AddTeamPlayer(P11);
            NationalTestTeam.AddTeamPlayer(P12);
            NationalTestTeam.AddTeamPlayer(P13);
            NationalTestTeam.AddTeamPlayer(P14);
            NationalTestTeam.AddTeamPlayer(P15);
            NationalTestTeam.AddTeamPlayer(P16);

            LeagueTestTeam.SetTeamCoach(C);
            LeagueTestTeam.DisplayTeamMembers();
            LeagueTestTeam.SetTeamMedic(M);
            LeagueTestTeam.DisplayTeamMembers();

            LeagueTestTeam.AddTeamPlayer(P1);
            LeagueTestTeam.AddTeamPlayer(P2);
            LeagueTestTeam.AddTeamPlayer(P3);
            LeagueTestTeam.AddTeamPlayer(P4);
            LeagueTestTeam.AddTeamPlayer(P5);
            LeagueTestTeam.AddTeamPlayer(P6);
            LeagueTestTeam.AddTeamPlayer(P7);
            LeagueTestTeam.AddTeamPlayer(P8);
            LeagueTestTeam.AddTeamPlayer(P9);
            LeagueTestTeam.AddTeamPlayer(P10);
            LeagueTestTeam.AddTeamPlayer(P11);
            LeagueTestTeam.AddTeamPlayer(P12);
            LeagueTestTeam.AddTeamPlayer(P13);
            LeagueTestTeam.AddTeamPlayer(P14);
            LeagueTestTeam.AddTeamPlayer(P15);
            LeagueTestTeam.AddTeamPlayer(P16);

            NationalTestTeam.DisplayTeamMembers();
            LeagueTestTeam.DisplayTeamMembers();
        }
    }
}
