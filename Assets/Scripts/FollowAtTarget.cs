using UnityEngine;


public class FollowAtTarget : MonoBehaviour {
	

	public static GameObject target; 


	private void Start ()
	{

		if (target != null) return;
		target = gameObject;
		Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");
	}
	

	private void Update () {
		if (target)
			transform.LookAt(target.transform);
	}
}
