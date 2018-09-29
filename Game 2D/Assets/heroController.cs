using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroController : MonoBehaviour {

    public float moveX = 0f;


    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {

            transform.Translate(new Vector2(moveX, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-moveX, 0));

        }
	}
}
