using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 mousePosition;
    private Vector3 direction;
    private float moveSpeed = 40f;
    private bool initial = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) && !initial)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
   
            direction = (mousePosition - transform.position).normalized;
     
            rb.velocity = new Vector3(direction.x * moveSpeed, rb.velocity.y, 0f);
        }
  
    }

    private void OnMouseDown()
    {
        if (initial)
        {
            rb.AddForce(Vector3.up*10, ForceMode.Impulse);
            initial = false;
        }
    }
}





    /*
     * 
        private void FixedUpdate()
        {

                float moveHorizontal = Input.GetAxis("Horizontal");
                float moveVertical = Input.GetAxis("Vertical");

                Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

                rb.AddForce(movement * 10);

            /* Vector3 mousePos = Input.mousePosition;
             Vector3 wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, transform.position.y, transform.position.z));*/

    /*public void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, transform.position.y, transform.position.z));
        //transform.position = wantedPos;
        //float Vmove = Input.GetAxis("Vertical");
        //print(Hmove + " " + Vmove);
       // Vector3 ballPosition = new Vector3(wantedPos);
        rb.AddForce(wantedPos*50);
    }*/
   

