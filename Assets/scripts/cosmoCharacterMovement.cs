using UnityEngine;
using System.Collections;

public class cosmoCharacterMovement : MonoBehaviour 
{	
	public float maxSpeed =15f;	
	Animator anim;
	Rigidbody2D body;
	GameObject spotlight;

	void Start () 
	{
		anim = GetComponent<Animator> ();
		body = GetComponent<Rigidbody2D> ();
		spotlight = GameObject.Find ("spotlight");
	}

	void FixedUpdate () 
	{
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");
		
		anim.SetFloat ("speedX", (moveX));
		anim.SetFloat ("speedY", (moveY));

		body.velocity = new Vector2 (moveX * maxSpeed, body.velocity.y);
		body.velocity = new Vector2 (body.velocity.x, moveY * maxSpeed);
	
		if (moveX > 0)
		{			
			Debug.Log ("høyre");
			spotlight.transform.rotation = Quaternion.Euler(0,90,0);
		}

		if (moveX < 0)
		{		
			Debug.Log ("venstre");
			spotlight.transform.rotation = Quaternion.Euler(0,-90,0);
		}

		if (moveY > 0)
		{
			spotlight.transform.rotation = Quaternion.Euler(-90,0,0);
			Debug.Log ("opp");
		}

		if (moveY < 0) 
		{
			spotlight.transform.rotation = Quaternion.Euler(90,0,0);
			Debug.Log ("ned");
		}

	}	
}
