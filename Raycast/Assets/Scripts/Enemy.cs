using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float distance;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, distance);

        if(hit.collider != null) {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            if(hit.collider.tag == "Player") {
                Destroy(hit.collider.gameObject);
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
        }    
    }
}
