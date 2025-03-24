using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class EliminateAT : ActionTask 
	{
        public float killTime = 2f;
        private float timeElapsed = 0f;

		public Animator animator;

        protected override string OnInit() 
		{
			return null;
		}


		protected override void OnExecute() 
		{
			animator.SetBool("Eliminate", true);
		}

		protected override void OnUpdate() 
		{
            timeElapsed += Time.deltaTime;

            if (timeElapsed > killTime)
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