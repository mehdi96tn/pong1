using System.Collections;
//This is ball script
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    //This is the speed of the racket mouvement

    // Start is called before the first frame update



    public class Ball : MonoBehaviour
    {


        float gravity = 0f;
        // Update is called once per frame
        void Update()
        {
            gravity = Input.GetAxis("Vertical");
        }

        public float speed = 30;




        void Start()
        {

            // Initial Velocity
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

            void FixedUpdate()
            {
                //This is our GetAxisRaw input 
                float v = Input.GetAxisRaw("Vertical") * speed;
                //Just calling the Rigidbody2D component to change its Velocity value
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
            }


        }

}

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
  
  
    }





}
