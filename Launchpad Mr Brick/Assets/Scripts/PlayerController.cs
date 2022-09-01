using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed;
    public float accel = 0.5f;
    public float maxSpeed = 15f;
    public GameObject gameWonPanel;
    public GameObject pausePanel;
    private bool isGameWon = false;

    void Update()
    {
        if(isGameWon == true)
        {
            return;
        }


        if(speed < maxSpeed)
        {
            speed += accel * Time.deltaTime;
        }

        if(Input.GetAxis("Horizontal") > 0)
        {
            rigidbody2D.velocity = new Vector2(speed, 0f);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            rigidbody2D.velocity = new Vector2(-speed, 0f);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rigidbody2D.velocity = new Vector2(0f, speed);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            rigidbody2D.velocity = new Vector2(0f, -speed);
        }

        if (Input.GetAxis("Vertical") == 0 && (Input.GetAxis("Horizontal") == 0))
        {
            rigidbody2D.velocity = new Vector2(0f, 0f);

        }

       if (Input.GetKey(KeyCode.Space))
        {
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            rigidbody2D.constraints = RigidbodyConstraints2D.None;
        }
       if (Input.GetKey(KeyCode.Escape))
        {
            pausePanel.SetActive(true);
            isGameWon = true;
        }

       
      

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("Level Completed!");
            gameWonPanel.SetActive(true);
            isGameWon = true;
        }
       
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        isGameWon = false;
    }
   
}
