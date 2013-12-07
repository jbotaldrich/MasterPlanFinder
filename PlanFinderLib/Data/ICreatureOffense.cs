using System;

namespace PlanFinderLib
{

		public interface ICreatureOffense
	{
		int Speed {get; set;}
		Melee MeleeAttack{get; set;}
		Ranged RangedAttack{get; set;}
		int Space{get; set;}
		int Reach{get; set;}
		string SpecialAttack{get;set;}
		string SpellsPrepared{get;set;}
	}
}
