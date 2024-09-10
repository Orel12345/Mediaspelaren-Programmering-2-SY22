using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren_Programmering_2_SY22 {
	internal class Movie : Media{
		public string director;

		public Movie(string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear, string inputDirector) : base(inputTitle, inputFilePath, inputDuration, inputPublicationYear) {
			director = inputDirector;
		}

		public override void Play() {
			Console.WriteLine("Nu börjar " + director + " göra film");
		}

		public override void Stop() {
			Console.WriteLine("Nu slutar " + director + " göra film");
		}

		public override void PrintMediaInfo() {
			Console.WriteLine("Din valda film är " + FilePath + " har en titel: " + Title + " som skapades av " + director + " och är " + Duration + " timmar lång.");
		}
	}
}
