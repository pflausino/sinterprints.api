using sinterprints.api.Models;
using System;
using Xunit;

namespace sinterprints.Api.Test.Models.Test
{
	public class ArtFilesTest
	{
		[Fact]
		public void AttributesTest()
		{
			var artFiles = new ArtFiles
			{
				Id = 1,
				Name = "Arte da Selva",
				Company = "Unilever",
				FileType = "Corel",
				FileNumber = 102,
				Date = DateTime.Now
			};

			Assert.IsType<ArtFiles>(artFiles);
		}


	}
}
