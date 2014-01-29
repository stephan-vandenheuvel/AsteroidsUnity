using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

  private Vector3 velocity = Vector3.zero;
  public float maxSpeed;


  static Asteroid() {
    Random.seed = (int) (1000*Time.realtimeSinceStartup);
  }

	// Use this for initialization
	void Start () {
    this.velocity = new Vector3(Random.Range(-this.maxSpeed, this.maxSpeed), Random.Range(-this.maxSpeed, this.maxSpeed), 0.0f);
	}
	
	// Update is called once per frame
	void Update () {

    if (this.transform.position.x > 8.0f) {
      this.transform.position = new Vector3(-8.0f, this.transform.position.y, this.transform.position.z);
    }
    
    if (this.transform.position.x < -8.0f) {
      this.transform.position = new Vector3(8.0f, this.transform.position.y, this.transform.position.z);
    }
    
    if (this.transform.position.y > 8.0f) {
      this.transform.position = new Vector3(this.transform.position.x, -8.0f, this.transform.position.z);
    }
    
    if (this.transform.position.y < -8.0f) {
      this.transform.position = new Vector3(this.transform.position.x, 8.0f, this.transform.position.z);
    }


    this.transform.position += velocity*Time.deltaTime;
	}

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.GetComponent<Laser>() != null) {
      Destroy (this.gameObject);
      Destroy (collision.gameObject);
    }
  }


}
