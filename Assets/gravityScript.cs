using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityScript : MonoBehaviour
{  //This is the speed of the racket mouvement
    public float speed = 30;
    float gravity = 0f;
    public int x = 0;
    Vector2 position;
    float r = 1.2f;
    string userName = "ada";
    bool win = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        win = true;
        Debug.Log("YOU M");
        Debug.Log(userName);
        Debug.Log(r);
        Debug.Log(x);
    }
    // Update is called once per frame
    void Update()
        
    {
        gravity = Input.GetAxis("Vertical");

        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
    }
    void FixedUpdate()
    {
        //This is our GetAxisRaw input 
        float v = Input.GetAxisRaw("Vertical") * speed;
        //Just calling the Rigidbody2D component to change its Velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
       
    }
  

}



