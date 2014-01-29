using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

  public float speedIncrement = 2.0f; 
  public float angleIncrement = 1.0f;
  public GameObject laserPrefab;
  private Vector3 velocity = Vector3.zero;


  // Use this for initialization
  void Start () {

  }


  // Update is called once per frame

  void Update () {
    if (Input.GetKey(KeyCode.LeftArrow)) {
      this.transform.Rotate(0.0f, -angleIncrement, 0.0f);
    }

    if (Input.GetKey(KeyCode.RightArrow)) {
      this.transform.Rotate(0.0f, angleIncrement, 0.0f);
    }

    if (Input.GetKey(KeyCode.UpArrow)) {
      velocity += this.transform.forward*speedIncrement;
    }

    if (Input.GetKeyDown (KeyCode.Space)) {
      GameObject laser = (GameObject) GameObject.Instantiate(this.laserPrefab);
      laser.SetActive(true);
      laser.transform.position = this.transform.position + this.transform.forward*0.5f;
      laser.transform.localEulerAngles = this.transform.localEulerAngles;

    }

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

    this.transform.position = this.transform.position + this.velocity*Time.deltaTime;
	}
}
