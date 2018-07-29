using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MoveWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public GameObject newWall;


    // Update is called once per frame
    void Update () {
        transform.position += new Vector3(-0.1f, 0f, 0f);
        if (transform.position.x < -10)
        {
            float y = Random.Range(-1.4f, 1.4f);
            print(y);
            Instantiate(newWall, new Vector3(12f,y,0f), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
