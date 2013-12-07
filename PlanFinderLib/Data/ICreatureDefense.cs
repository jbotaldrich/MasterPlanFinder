using System;

namespace PlanFinderLib
{
	public interface ICreatureDefense
	{
		int AC{get;set;}
		int Touch{get;set;}
		int Flat_Footed{get;set;}
		int hp{get; set;}
		int Fortitude{get;set;}
		int Reflex{get;set;}
		int Willpower{get;set;}
		string DR{get;set;}
		string Immunity{get;set;}
		string Weaknesses{get;set;}
		
	}

}
