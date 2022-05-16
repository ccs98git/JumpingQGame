using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyPlayer : MonoBehaviour
{
    Rigidbody2D boyRB;
    public float maxVel;
    bool turnBoy = true;
    SpriteRenderer boyRender;
    Animator boyAnim;
    // Start is called before the first frame update
    void Start()
    {
        boyRB = GetComponent<Rigidbody2D>();
        boyRender = GetComponent<SpriteRenderer>();
        boyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");

        if(move>0 && !turnBoy){
            turn();
        }else if(move<0 && turnBoy){
            turn();
        }

        boyRB.velocity = new Vector2(move*maxVel, boyRB.velocity.y);

        //running
        boyAnim.SetFloat("VelMovement",Mathf.Abs(move));
    }

    void turn(){
        turnBoy = !turnBoy;
        boyRender.flipX = !boyRender.flipX;
    }


}
