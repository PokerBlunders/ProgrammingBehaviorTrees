using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Reflection;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class MoveAT : ActionTask 
	{
		public Transform targetPoint;
		public NavMeshAgent guard;


        protected override string OnInit() 
		{
			return null;
		}

		protected override void OnExecute() 
		{
			guard.destination = targetPoint.position;
		}

		protected override void OnUpdate() 
		{
			if ((targetPoint.transform.position - guard.transform.position).sqrMagnitude < 0.25)
			{
                EndAction(true);
			}
		}

	}
}