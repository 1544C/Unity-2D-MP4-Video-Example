using UnityEngine;
using System.Collections;

public class Flower : MonoBehaviour {

	public DraggableObject mPlDraggableObject;
	public Sprite mPlSurprisedFlower;

	public bool mPrBoolHadSprouted {get; set;}

	private float mPrFltSproutTime = 3f;
	private float mPrFltSproutCurrentTimer;
	private SpriteRenderer mPrSpriteRenderer;


	// Use this for initialization
	void Start () {
		mPrBoolHadSprouted = false;
		mPrFltSproutCurrentTimer = mPrFltSproutTime;
		mPrSpriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

		CountDownBeforeSprout();

		if(!mPrBoolHadSprouted &&
		   mPrFltSproutCurrentTimer <= 0)
		{
			StartCoroutine (Sprout());
		}

		if(mPrBoolHadSprouted &&
		   mPlDraggableObject.mPrBoolGotReleased)
		{
			mPrSpriteRenderer.sprite = mPlSurprisedFlower;
		}
	}

	private void CountDownBeforeSprout()
	{
		if(mPlDraggableObject.mPrBoolIsGrabbed)
		{
			mPrFltSproutCurrentTimer -= Time.deltaTime;
		}
		else
		{
			mPrFltSproutCurrentTimer = mPrFltSproutTime;
		}
	}

	IEnumerator Sprout()
	{
		Vector3 v3EndPosition;
		Vector3 moveTowards;
		
		v3EndPosition = transform.position + new Vector3 (0f,1f,0f);
		
		float sqrRemainingDistance = (transform.position - v3EndPosition).sqrMagnitude;
		while (sqrRemainingDistance > float.Epsilon) {
			moveTowards = Vector3.MoveTowards (transform.position, 
			                                   v3EndPosition,
			                                   Time.deltaTime);
			transform.position = moveTowards;
			sqrRemainingDistance = (transform.position - v3EndPosition).sqrMagnitude;
			yield return null;
		}

		mPrBoolHadSprouted = true;

	}
}
