using UnityEngine;
using System.Collections;

public class DisablePositionalTracking : MonoBehaviour {
  private Vector3 position;

  void Start () {
    position = Camera.main.transform.position;  
  }

  void Update () {
    Camera.main.transform.position = position;
  }
}
