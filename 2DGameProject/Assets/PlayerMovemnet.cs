using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemnet : MonoBehaviour {

    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horziontalMove = 0f;
	
	
	// Update is called once per frame
	void Update () {

        horziontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
	}

    void FixedUpdate()
    {

        //move our character

        controller.Move(horziontalMove * Time.fixedDeltaTime, false, false);
    }
}
