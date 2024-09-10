using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren_Programmering_2_SY22 {
	internal class Media {
		private string title;
		private string filePath;
		private int duration;
		private int publicationYear;

		public int Duration {
			get {
				return duration;
			}

			set {
				if (value > 0) {
					duration = value;
				}
			}
		}

		public string Title {
			get {
				return title;
			}

			set {
				if (value != "") {
					title = value;
				}
			}
		}

		public string FilePath {
			get {
				return filePath;
			}

			set {
				if (value != "") {
					filePath = value;
				}
			}
		}

		public int PublicationYear {
			get {
				return publicationYear;
			}

			set {
				if (value >= 1900 && value <= 2024) {
					publicationYear = value;
				}
			}
		}

		public Media(string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear) {
			title = inputTitle;
			filePath = inputFilePath;
			duration = inputDuration;
			publicationYear = inputPublicationYear;
		}

		public virtual void Play() {
            Console.WriteLine("Nu spelas media");
        }

		public virtual void Stop() {
			Console.WriteLine("Nu pausas media");
		}

		public virtual void PrintMediaInfo() {
			Console.WriteLine("Din valda " + filePath + " har en titel: " + title + " som skapades " + publicationYear + " och är " + duration + " lång.");
        }
	}
}
