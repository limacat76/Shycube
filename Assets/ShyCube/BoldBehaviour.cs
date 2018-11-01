using UnityEngine;

public class BoldBehaviour : StateMachineBehaviour {

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        animator.gameObject.GetComponent<ReactionBehaviour>().BeBrave();

    }

}
