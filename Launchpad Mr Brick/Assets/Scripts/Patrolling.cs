using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{

    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
  
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
         
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        speed *= -1;
    }
}
