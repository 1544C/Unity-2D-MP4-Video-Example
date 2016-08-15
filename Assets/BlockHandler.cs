using UnityEngine;
using System.Collections;

public class BlockHandler : MonoBehaviour {

	public MovieHandler mPrMovieHandler;
	
	private GameManager mPrGameManager;


	void Start()
	{
		mPrGameManager = FindObjectOfType<GameManager>();
	}

	void OnCollisionEnter2D(Collision2D c2DCollider)
	{
		mPrMovieHandler.PlayMovie();
		mPrGameManager.mPrBoolIsEnding = true;
	}
}
