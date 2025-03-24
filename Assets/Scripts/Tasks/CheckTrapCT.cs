using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions 
{

	public class CheckTrapCT : ConditionTask 
	{
		public GameObject trap;

		protected override bool OnCheck() 
		{
			if (trap.activeInHierarchy)
			{
                return true;
            }

			return false;
		}
	}
}