using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject mPlGameOverScreen;

	public bool mPrBoolIsEnding {get;set;}
	public bool mPrBoolHasEnded {get;set;}

	private float mPrFltCurrentTimer = 6f;

	// Use this for initialization
	void Start () {
		mPrBoolIsEnding = false;
		mPrBoolHasEnded = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!mPrBoolHasEnded &&
		   mPrBoolIsEnding)
		{
			mPrFltCurrentTimer -= Time.deltaTime;
		}

		if(mPrFltCurrentTimer <= 0)
		{
			mPlGameOverScreen.SetActive(true);
			mPrBoolHasEnded = true;
		}
	}
}
