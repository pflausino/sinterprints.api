using System;

namespace sinterprints.api.Models
{
	public class ArtFiles
	{
		public DateTime Data;

		public int Id { get; set; }
		public string Name { get; set; }
		public string Company { get; set; }
		public string FileType { get; set; }
		public int FileNumber { get; set; }
		public DateTime Date { get; set; }

	}
}
