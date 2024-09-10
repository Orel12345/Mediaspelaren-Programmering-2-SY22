using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren_Programmering_2_SY22 {
	internal class Podcast : Media{
		public string creator;

		public Podcast(string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear, string inputCreator) : base(inputTitle, inputFilePath, inputDuration, inputPublicationYear) {
			creator = inputCreator;
		}

		public override void Play() {
            Console.WriteLine("Nu börjar " + creator + " att prata om ett ämne");
        }

		public override void Stop() {
            Console.WriteLine("Nu slutar " + creator + " att prata");
        }

		public override void PrintMediaInfo() {
            Console.WriteLine("Din valda podcast är " + FilePath + " har en titel: " + Title + " som skapades av " + creator + " och är " + Duration + " minuter lång.");
        }
	}
}
