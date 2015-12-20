using UnityEngine;
using System.Collections;

public class WelcomeTimeout : MonoBehaviour {
	public float timer = 15.0f;

	void Start () {
    Destroy (gameObject, timer);
	}
}
