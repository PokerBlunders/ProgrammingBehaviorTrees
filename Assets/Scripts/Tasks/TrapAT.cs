using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions 
{

	public class TrapAT : ActionTask 
    {

        public float trapTime = 2f;
        private float timeElapsed = 0f;

        public Animator animator;
        public BBParameter<GameObject> trap;

        protected override string OnInit()
        {
            return null;
        }


        protected override void OnExecute()
        {
            animator.SetBool("Trap", true);
        }

        protected override void OnUpdate()
        {
            timeElapsed += Time.deltaTime;

            if (timeElapsed > trapTime)
            {
                trap.value.SetActive(true);
                EndAction(true);
            }
        }

        protected override void OnStop()
        {
            timeElapsed = 0f;
        }

    }
}