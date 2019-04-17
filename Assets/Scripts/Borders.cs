using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		
		if(other.CompareTag("SnakeHead"))
		{
				Application.LoadLevel(Application.loadedLevel);
		}

	}
}
