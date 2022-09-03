using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Rigidbody2D rb2D;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) *Mathf.Rad2Deg;
        rb2D.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        MoveEnemy(movement);
    }

    void MoveEnemy(Vector2 direction)
    {

        rb2D.MovePosition((Vector2)  transform.position + (direction * speed * Time.deltaTime));
    }


}
