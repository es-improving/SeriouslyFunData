using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriouslyFunData.Controllers
{
    public record Seleucid(string name, int StartReign, int endReign, string[] consorts) { }

    public class ApiController : Controller
    {
        private static readonly List<string> _jokes = new List<string>()
            {
                "Chuck Norris threw a grenade and killed 50 people, then it exploded.",
                "Chuck Norris counted to infinity. Twice.",
                "When Chuck Norris enters a room, he doesn't turn the lights on, he turns the dark off.",
                "Chuck Norris can strangle you with a cordless phone.",
                "Death once had a near-Chuck-Norris experience.",
                "Once a cobra bit Chuck Norris' leg. After five days of excruciating pain, the cobra died.",
                "Chuck Norris can do a wheelie on a unicycle.",
                "When Chuck Norris was in middle school, his English teacher assigned an essay: 'What is courage?' He received an A+ for turning in a blank page with only his name at the top.",
                "There is no theory of evolution, just a list of creatures Chuck Norris allows to live.",
                "Chuck Norris can kill two stones with one bird.",
                "Chuck Norris doesn't dial the wrong number, you pick up the wrong phone.",
                "Chuck Norris has a diary.It's called the Guinness Book of World Records.",
                "Chuck Norris's computer has no backspace button, Chuck Norris doesn't make mistakes.",
                "Chuck can set ants on fire with a magnifying glass.At night.",
                "Chuck Norris can hear sign language.",
                "Chuck Norris makes onions cry.",
                "Chuck Norris got Coronavirus.Now the Coronavirus is in isolation.",
                "Chuck Norris doesn't have good aim. His bullets just know better than to miss.",
                "Chuck Norris can cut a knife with butter.",
                "Chuck Norris doesnt wear a watch. He decides what time it is."
            };

        private static readonly List<Seleucid> _seleucids = new List<Seleucid>
        {
            new Seleucid("Seleucus I Nicator", 305, 281, new string[] { "Apama" }),
            new Seleucid("Antiochus I Soter", 281, 261, new string[] { "Stratonice of Syria" }),
            new Seleucid("Antiochus II Theos", 261, 246, new string[] { "Laodice I", "Berenice" }),
            new Seleucid("Seleucus II Callinicus", 246, 225, new string[] { "Laodice II" }),
            new Seleucid("Seleucus III Ceraunus", 225, 223, new string[] { }),
            new Seleucid("Antiochus III the Great", 223, 187, new string[] { "Laodice III", "Euboea of Chalcis" }),
            new Seleucid("Seleucus IV Philopator", 187, 175, new string[] { "Laodice IV" }),
            new Seleucid("Antiochus IV Epiphanes", 175, 163, new string[] { "Laodice IV" }),
            new Seleucid("Antiochus V Eupator", 163, 161, new string[] { }),
            new Seleucid("Demetrius I Soter", 161, 150, new string[] { "Apama", "Laodice V" }),
            new Seleucid("Alexander I Balas", 150, 145, new string[] { "Cleopatra Thea" } ),
            new Seleucid("Demetrius II Nicator", 145, 138, new string[] { "Cleopatra Thea" }),
            new Seleucid("Antiochus VI Dionysus", 145, 140, new string[] { }),
            new Seleucid("Diodotus Tryphon", 140, 138, new string[] { }),
            new Seleucid("Antiochus VII Sidetes", 138, 129, new string[] { "Cleopatra Thea" }),
            new Seleucid("Demetrius II Nicator", 129, 126, new string[] { "Cleopatra Thea" }),
            new Seleucid("Alexander II Zabinas", 129, 123, new string[] { }),
            new Seleucid("Cleopatra Thea", 126, 121, new string[] { }),
            new Seleucid("Seleucus V Philometor", 126, 125, new string[] { }),
            new Seleucid("Antiochus VIII Grypus", 125, 96, new string[] { "Tryphaena of Egypt", "Cleopatra Selene I of Egypt" }),
            new Seleucid("Antiochus IX Cyzicenus", 114, 96, new string[] { "Cleopatra IV of Egypt", "Cleopatra Selene I of Egypt" }),
            new Seleucid("Seleucus VI Epiphanes Nicator", 96, 95, new string[] { }),
            new Seleucid("Antiochus X Eusebes Philopator", 95, 92, new string[] { }),
            new Seleucid("Demetrius III Eucaerus", 95, 87, new string[] { }),
            new Seleucid("Antiochus XI Epiphanes Philadelphus", 95, 92, new string[] { }),
            new Seleucid("Philip I Philadelphus", 95, 84, new string[] { }),
            new Seleucid("Antiochus XII Dionysus", 87, 84, new string[] { }),
            new Seleucid("Tigranes I of Armenia", 83, 69, new string[] { }),
            new Seleucid("Seleucus VII Kybiosaktes", 83, 69, new string[] { } ),
            new Seleucid("Antiochus XIII Asiaticus", 69, 64, new string[] { }),
            new Seleucid("Philip II Philoromaeus", 65, 63, new string[] { })
        };


        public IActionResult GenerateARandomNumber()
        {
            return Content(new Random().Next(1000).ToString());
        }

        public IActionResult ChuckNorrisFact()
        {
            return Json(new
            {
                joke = _jokes[new Random().Next(0, _jokes.Count)]
            });
        }

        public IActionResult Seleucids()
        {
            return Json(new
            {
                seleucids = _seleucids
            });
        }
    }


}
