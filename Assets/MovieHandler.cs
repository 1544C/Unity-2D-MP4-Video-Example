using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]
public class MovieHandler : MonoBehaviour {

	public MovieTexture plMtMovie;
	private Renderer prMRenderer;
	private GameManager mPrGameManager;


	// Use this for initialization
	void Start () {
		mPrGameManager = FindObjectOfType<GameManager>();
		prMRenderer = gameObject.GetComponent<Renderer>();
	}

	void Update()
	{
		if(mPrGameManager.mPrBoolHasEnded)
		{
			plMtMovie.Stop();
			prMRenderer.enabled = false;
		}
	}
	public void PlayMovie()
	{
		prMRenderer.enabled = true;
		plMtMovie.Play();
	}
}
