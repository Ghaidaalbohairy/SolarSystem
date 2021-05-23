using UnityEngine;


public class ChangeLookAtTarget : MonoBehaviour {


	public GameObject target; 

	
	private void Start ()
	{

		if (target != null) return;

		target = gameObject;
		Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
	}


	private void OnMouseDown () {
		FollowAtTarget.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
	}
}
