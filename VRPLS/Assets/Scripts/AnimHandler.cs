using UnityEngine;
using System.Collections;
 
public class AnimHandler : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		Animator anim = gameObject.GetComponent<Animator>();
		anim.Play("cubeanimation", -1, float.NegativeInfinity);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			Animator anim = gameObject.GetComponent<Animator>();
			// Reverse animation play
			Debug.Log("rewind");
			anim.SetFloat("Direction", -1);
			anim.Play("Our_Car_Scene_1", -1, float.NegativeInfinity);
		}
	}
}
