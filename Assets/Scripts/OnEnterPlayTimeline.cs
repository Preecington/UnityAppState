﻿using UnityEngine;

namespace Halia
{
    public class OnEnterPlayTimeline : StateMachineBehaviour
    {
        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animator.GetComponentInParent<DirectorIndex>().AdvanceDirector().Play();
        }
    }
}
