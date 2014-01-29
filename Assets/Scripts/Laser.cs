using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

  public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    this.transform.position = this.transform.position + this.transform.forward*speed*Time.deltaTime;

    if (this.transform.position.x > 8.0f) {
      Destroy(this.gameObject);
    }
    
    if (this.transform.position.x < -8.0f) {
      Destroy(this.gameObject);
    }
    
    if (this.transform.position.y > 8.0f) {
      Destroy(this.gameObject);
    }
    
    if (this.transform.position.y < -8.0f) {
      Destroy(this.gameObject);
    }


	}
}
