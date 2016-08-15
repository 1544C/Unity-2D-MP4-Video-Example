 using UnityEngine;
using System.Collections;

public class DraggableObject : MonoBehaviour {

	public Flower mPlFlower;

	public bool mPrBoolIsGrabbed {get; set;}
	public bool mPrBoolGotReleased {get; set;}

	private Rigidbody2D mPrRigidBody2D;


	// Use this for initialization
	void Start () {

		mPrRigidBody2D = gameObject.GetComponent<Rigidbody2D>();
		mPrBoolIsGrabbed = false;
		mPrBoolGotReleased = false;
	}

	void OnMouseDown()
	{
		if(!mPlFlower.mPrBoolHadSprouted)
		{
			mPrRigidBody2D.velocity = Vector2.zero;
			mPrRigidBody2D.gravityScale = 0f;
			mPrBoolGotReleased = false;
			mPrBoolIsGrabbed = true;

		}
	}

	void OnMouseUp()
	{
		mPrRigidBody2D.gravityScale = 1f;
		mPrBoolGotReleased = true;

	}
}
