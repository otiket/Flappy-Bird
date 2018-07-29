using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBird : MonoBehaviour {

    float v = 0;
    public float originalV = 0.2f;
    public float g = 0.005f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += new Vector3(0,v,0);
        v -= g;
        //マウスの左ボタン
        if (Input.GetMouseButton(0))
        {
            v = originalV;
        }
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        SceneManager.LoadScene("GameOver");
    }

    //画面外に出た場合
    void OnBecameInvisible()
    {
        SceneManager.LoadScene("GameOver");
    }
}
