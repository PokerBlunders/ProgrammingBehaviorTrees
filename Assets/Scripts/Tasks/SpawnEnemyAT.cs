using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SpawnEnemyAT : ActionTask 
	{
		public GameObject enemy;

		protected override string OnInit() 
		{
			return null;
		}

		protected override void OnExecute() 
		{
			enemy.SetActive(true);
			EndAction(true);
		}

		protected override void OnUpdate() 
		{
			
		}

		protected override void OnStop() 
		{
			
		}

	}
}