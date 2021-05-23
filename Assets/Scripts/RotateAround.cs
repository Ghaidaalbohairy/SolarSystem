using UnityEngine;

public class RotateAround : MonoBehaviour {


	public Transform target; 
	public int speed; 
	

	private void Start ()
	{
	
		if (target != null) return;
		target = gameObject.transform;
		Debug.Log ("RotateAround target not specified. Defaulting to parent GameObject");
	}


	private void Update () {
	
		transform.RotateAround(target.transform.position,target.transform.up,speed * Time.deltaTime);
	}
}
