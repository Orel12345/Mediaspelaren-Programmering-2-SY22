using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren_Programmering_2_SY22 {
	internal class Song : Media {
		public string artist;

		public Song(string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear, string inputArtist) : base(inputTitle, inputFilePath, inputDuration, inputPublicationYear) {
			artist = inputArtist;
		}

		public override void Play() {
            Console.WriteLine("nu sjunger " + artist);
        }

		public override void Stop() {
            Console.WriteLine("Nu slutar " + artist + " att sjunga");
        }

		public override void PrintMediaInfo() {
            Console.WriteLine("Din valda låt är " + FilePath + " har en titel: " + Title + " som skapades av " + artist + " och är " + Duration + " minuter lång.");
        }
	}
}
