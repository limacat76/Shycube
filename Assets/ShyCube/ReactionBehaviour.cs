using UnityEngine;

public class ReactionBehaviour : MonoBehaviour {

    public Material Bold;

    public Material Shy;

    private Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>() as Animator;
	}
	
	// Update is called once per frame
	void Update () {
        GameObject danger = GameObject.FindGameObjectWithTag("Player");
        float dangerDistance = 
                Vector3.Distance(danger.GetComponent<Transform>().position, transform.position);
        animator.SetFloat("DangerDistance", dangerDistance);

        GameObject[] targets = GameObject.FindGameObjectsWithTag(tag);
    }

    public void BeBrave()
    {
        GetComponent<MeshRenderer>().material = Bold;
    }

    public void BeCoward()
    {
        GetComponent<MeshRenderer>().material = Shy;
    }
}
