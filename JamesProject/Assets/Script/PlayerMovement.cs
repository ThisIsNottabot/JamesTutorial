using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Transform gc, gManTrans;
	GameManager gMan;

	public float jumpStrength;
	public float speed;

	bool grounded = true;
	bool facingLeft = false;

	bool wasPaused = false;
	Vector2 velBeforePause;
	float gravBeforePause;

	void Start ()
	{
		gMan = gManTrans.GetComponent<GameManager> ();
	}

	void Update () 
	{
		if(!gMan.gamePaused)
		{
			if(wasPaused)
			{
				rigidbody2D.velocity = velBeforePause;
				rigidbody2D.gravityScale = gravBeforePause;
				wasPaused = false;
			}

			DirCheck ();
			Movement ();
			GroundCheck ();
		}
		else if (!wasPaused)
		{
			wasPaused = true;
			velBeforePause = rigidbody2D.velocity;
			gravBeforePause = rigidbody2D.gravityScale;

			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.gravityScale = 0;
		}

	}

	void DirCheck()
	{
		if(Input.GetAxis ("Horizontal") > 0 && facingLeft)
		{
			facingLeft = false;
			transform.localScale = new Vector3( -transform.localScale.x, transform.localScale.y, transform.localScale.z );
		}
		else if(Input.GetAxis ("Horizontal") < 0 && !facingLeft)
		{
			facingLeft = true;
			transform.localScale = new Vector3( -transform.localScale.x, transform.localScale.y, transform.localScale.z );
		}
	}

	void GroundCheck()
	{
		grounded = Physics2D.Linecast (transform.position, gc.position, 1 << LayerMask.NameToLayer ("Ground"));
	}

	void Movement()
	{
		if(Input.GetAxis ("Horizontal") > 0)
		{
			rigidbody2D.AddForce( new Vector2( 1000 * speed * Time.deltaTime, 0 ));
		}
		else if(Input.GetAxis ("Horizontal") < 0)
		{
			rigidbody2D.AddForce( new Vector2( -1000 * speed * Time.deltaTime, 0 ));
		}
		
		if(Input.GetButtonDown("Jump") && grounded)
		{
			rigidbody2D.AddForce( new Vector2(0,jumpStrength) );
		}
	}


}
