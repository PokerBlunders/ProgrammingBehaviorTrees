using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Threading;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class WaitAT : ActionTask
	{
		public float waitTime = 2f;
		private float timeElapsed = 0f;

		protected override void OnExecute() 
		{
			
		}

		protected override void OnUpdate() 
		{
			timeElapsed += Time.deltaTime;
			
			if(timeElapsed > waitTime)
			{
                EndAction(true);
            }
        }

		protected override void OnStop() 
		{
			timeElapsed = 0f;
		}

	}
}