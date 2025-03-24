using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Reflection;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class MoveAT : ActionTask 
	{
		public BBParameter<Transform> targetPoint;
		public NavMeshAgent hunter;

		protected override void OnExecute() 
		{
            hunter.destination = targetPoint.value.position;
		}

		protected override void OnUpdate() 
		{
			if ((targetPoint.value.position - hunter.transform.position).sqrMagnitude < 0.25)
			{
                EndAction(true);
			}
		}

	}
}