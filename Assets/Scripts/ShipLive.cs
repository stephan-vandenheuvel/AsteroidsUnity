using UnityEngine;
using System.Collections;

public class ShipLive : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    if (Input.GetKey (KeyCode.LeftArrow)) {
      this.gameObject.transform.Rotate(0.0f, 1.0f, 0.0f);
    }
	
	}
}
