using UnityEngine;

public class ShyBehaviour : StateMachineBehaviour {
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.gameObject.GetComponent<ReactionBehaviour>().BeCoward();
    }

}
