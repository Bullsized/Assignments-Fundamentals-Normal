using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> participantAward = new Dictionary<string, HashSet<string>>();

            string[] participants = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var participant in participants)
            {
                if (!participantAward.ContainsKey(participant))
                {
                participantAward.Add(participant, new HashSet<string>());
                }
            }

            string[] songs = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            string particSongAward = Console.ReadLine();

            while (particSongAward != "dawn")
            {
                string[] awards = particSongAward
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToArray();

                string participantEntry = awards[0];
                string songEntry = awards[1];
                string awardEntry = awards[2];

                if (participantAward.ContainsKey(participantEntry) && songs.Contains(songEntry))
                {
                    participantAward[participantEntry].Add(awardEntry);
                }

                particSongAward = Console.ReadLine();
            }
            bool hasResult = false;

            foreach (var particip in participantAward.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (particip.Value.Count > 0)
                {
                    Console.WriteLine("{0}: {1} awards", particip.Key, particip.Value.Count);
                    foreach (var award in particip.Value)
                    {
                        Console.WriteLine("--{0}", award);
                    }
                    hasResult = true;
                }
            }

            if (hasResult == false)
            {
                Console.WriteLine("No awards");
            }




            //solution 2:
            //var participantsInput = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
            //var songsInput = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();

            //var result = new Dictionary<string, List<string>>();

            //var line = Console.ReadLine();
            //while (line != "dawn")
            //{
            //    var performance = line.Split(',').Select(p => p.Trim()).ToList();

            //    var participant = performance[0];
            //    var song = performance[1];
            //    var award = performance[2];

            //    if (participantsInput.Contains(participant) && songsInput.Contains(song))
            //    {
            //        if (!result.ContainsKey(participant))
            //        {
            //            result[participant] = new List<string>();
            //        }
            //        var awards = result[participant];
            //        if (!awards.Contains(award))
            //        {
            //            awards.Add(award);
            //        }
            //    }
            //    line = Console.ReadLine();
            //}
            //if (result.Any())
            //{
            //    foreach (var keyValuePair in result.OrderByDescending(p => p.Value.Count).ThenBy(n => n.Key))
            //    {
            //        if (keyValuePair.Key.Any())
            //        {
            //            var participant = keyValuePair.Key;
            //            var awards = keyValuePair.Value;
            //            Console.WriteLine($"{participant}: {awards.Count} awards");
            //            foreach (var award in awards.OrderBy(n => n))
            //            {
            //                Console.WriteLine($"--{award}");
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No awards");
            //}




            //solution 3:
            //string[] participants = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            //string[] avaliableSongs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            //Dictionary<string, List<string>> winners = new Dictionary<string, List<string>>();

            //string inputLine = Console.ReadLine();
            //while (inputLine != "dawn")
            //{
            //    string[] singerInfo = inputLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            //    string singer = singerInfo[0];
            //    string song = singerInfo[1];
            //    string award = singerInfo[2];

            //    if (!participants.Any(s => s == singer) || !avaliableSongs.Any(s => s == song))
            //    {
            //        inputLine = Console.ReadLine();

            //        continue;
            //    }

            //    if (!winners.ContainsKey(singer))
            //    {
            //        winners.Add(singer, new List<string>());
            //    }

            //    winners[singer].Add(award);

            //    inputLine = Console.ReadLine();
            //}

            //if (winners.Count == 0)
            //{
            //    Console.WriteLine("No awards");

            //    return;
            //}

            //foreach (KeyValuePair<string, List<string>> pair in winners
            //                                                    .OrderByDescending(a => a.Value.Distinct().ToList().Count)
            //                                                    .ThenBy(n => n.Key))
            //{
            //    List<string> awards = pair.Value.Distinct().ToList();

            //    Console.WriteLine($"{pair.Key}: {awards.Count} awards");
            //    foreach (string award in awards.OrderBy(n => n))
            //    {
            //        Console.WriteLine($"--{award}");
            //    }
            //}
        }
    }
}