using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());

            List<Team> solution = new List<Team>();

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                string[] firstInputLine = Console.ReadLine().Split('-').ToArray();
                string nameOfFounder = firstInputLine[0];
                string nameOfClub = firstInputLine[1];

                Team currentIdiot = new Team();
                currentIdiot.ClubName = nameOfClub;
                currentIdiot.Founder = nameOfFounder;
                currentIdiot.Users = new List<string>();

                if (cycle == 0)
                {
                    solution.Add(currentIdiot);
                    Console.WriteLine($"Team {nameOfClub} has been created by {nameOfFounder}!");
                }
                else
                {
                    foreach (var member in solution)
                    {
                        if (member.ClubName == nameOfClub)
                        {
                            Console.WriteLine("Team {0} was already created!", nameOfClub);
                            break;
                        }
                        else if (member.Founder == nameOfFounder)
                        {
                            Console.WriteLine("{0} cannot create another team!", nameOfFounder);
                            break;
                        }
                        else
                        {
                            solution.Add(currentIdiot);
                            Console.WriteLine($"Team {nameOfClub} has been created by {nameOfFounder}!");
                        }
                        break;
                    }
                }
            }


            string secondInputLine = Console.ReadLine();

            while (secondInputLine != "end of assignment")
            {
                string[] splitSecondInput = secondInputLine.Split(new char[] { '-', '>', },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                string nameOfMember = splitSecondInput[0];
                string nameOfClubToGetIn = splitSecondInput[1];

                bool isExistant = false;
                bool isInTeam = false;

                foreach (var team in solution)
                {
                    if (team.Users.Contains(nameOfMember) || team.Founder == nameOfMember)
                    {
                        isInTeam = true;
                    }
                }

                foreach (var team in solution)
                {
                    if (team.ClubName == nameOfClubToGetIn)
                    {
                        isExistant = true;
                    }

                    if (isExistant == true && isInTeam == false)
                    {
                        team.Users.Add(nameOfMember);
                        break;
                    }
                }

                if (isExistant == false)
                {
                    Console.WriteLine($"Team {nameOfClubToGetIn} does not exist!");
                }
                else if (isInTeam == true)
                {
                    Console.WriteLine($"Member {nameOfMember} cannot join team {nameOfClubToGetIn}!");
                }

                secondInputLine = Console.ReadLine();
            }

            foreach (var teams in solution.Where(x => x.Users.Count > 0)
                .OrderByDescending(x => x.Users.Count)
                .ThenBy(x => x.ClubName))
            {
                Console.WriteLine(teams.ClubName);
                Console.WriteLine("- " + teams.Founder);
                foreach (var userInTeam in teams.Users)
                {
                    Console.WriteLine("-- " + userInTeam);
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var disbandTeams in solution.Where(x => x.Users.Count == 0))
            {
                Console.WriteLine(disbandTeams.ClubName);
            }
        }
    }

    class Team
    {
        public string ClubName { get; set; }
        public string Founder { get; set; }
        public List<string> Users { get; set; }
    }
}