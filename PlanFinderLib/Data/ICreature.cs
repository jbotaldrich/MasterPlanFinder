using System;

namespace PlanFinderLib
{
	public interface ICreature
	{

		Guid ID { get; set;}
		string Name{get; set}
		CreatureSize size{get; set;}
		CreatureOrigin Origin {get; set;}
		CreatureType Type {get; set;}
		string Keywords {get; set;}
		int Level {get; set;}
		CreatureOffense Offense{get; set;}
		CreatureDefense Defense{get; set;}
		CreatureStats Stats{get; set;}
		

	}
}

