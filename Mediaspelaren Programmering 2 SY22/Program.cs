using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren_Programmering_2_SY22 {
	internal class Program {
		static void Main(string[] args) {
			List<Media> media = new List<Media> {
				new Song("dibv", "ewooe", 3, 2024, "blurrrr"),
				new Podcast("bde", "hdew", 4, 2023, "booom"),
				new Movie("Belncewi", "iew", 2, 2022, "zoooom"),
				new Song("dibv", "ewooe", 3, 2024, "blurrrr"),
				new Podcast("bde", "hdew", 4, 2023, "booom"),
				new Movie("Belncewi", "iew", 2, 2022, "zoooom"),
				new Song("dibv", "ewooe", 3, 2024, "blurrrr"),
				new Podcast("bde", "hdew", 4, 2023, "booom"),
				new Movie("Belncewi", "iew", 2, 2022, "zoooom"),
				new Song("ewbfi", "fwehw", 1, 2021, "efofwi")
			};

			for (int i = 0; i < media.Count; i++) {
				media[i].PrintMediaInfo();
            }
        }
	}
}
