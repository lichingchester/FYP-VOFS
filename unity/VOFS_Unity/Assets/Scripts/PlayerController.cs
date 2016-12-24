using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    Debug.Log("Input W");
        //}

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * 3.0f * Time.deltaTime);
    }

    // use for before any physics calculation 
    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * 10.0f);
    }
}
