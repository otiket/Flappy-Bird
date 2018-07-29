using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.05f, 0, 0);
    }
    void OnBecameInvisible()
    {
        // スプライトの幅を取得
        float width = GetComponent<SpriteRenderer>().bounds.size.x;
        // 幅ｘ個数分だけ右へ移動
        transform.position += Vector3.right * width * 1.98f;
    }
}
