using UnityEngine;
using System.Collections;
 
public class AnimHandler : MonoBehaviour
{
	public Animator anim1;
	public Animator anim2;

	// Use this for initialization
	void Start()
	{
		/*Animator anim = gameObject.GetComponent<Animator>();
		anim.Play("cubeanimation", -1, float.NegativeInfinity);*/
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
	
			// Reverse animation play
			Debug.Log("rewind");
			anim1.SetFloat("Direction", -1);
			anim1.Play("Our_Car_Scene_1", -1, float.NegativeInfinity);
			anim2.SetFloat("Direction", -1);
			anim2.Play("Intercepting_Van_Scene_1", -1, float.NegativeInfinity);
		}
	}
}
