using System.Collections.Generic;

namespace BlazingTrailsWebApp.Features.Home.Models 
{
	public class TrailModel {
		#region - ™PROPERTIES™ ☰☰☰☰☰☰☰☰☰☰
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public string Location { get; set; }
		public string Time { get; set; }
		public int Length { get; set; }
		public bool IsFavourite { get; set; }
		// public IEnumerable<RouteInstruction> Route { get; set; }
		#endregion ™☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰
	}

	// public class RouteInstruction {
	// 	#region - ™PROPERTIES™ ☰☰☰☰☰☰☰☰☰
	// 	public int Stage { get; set; }
	// 	public int Description { get; set; }
	// 	#endregion ™☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰☰
	// 	
	// }
}