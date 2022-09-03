using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed;
  
    public GameObject gameWonPanel;
    public GameObject gameLostPanel;
    public GameObject pausePanel;
    private bool isGameOver = false;

    void Update()
    {
        if(isGameOver == true)
        {
            return;
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
            isGameOver = true;
        }

       
      

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Door"))
        {
            Debug.Log("Level Completed!");
            gameWonPanel.SetActive(true);
            isGameOver = true;
        }

     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameLostPanel.SetActive(true);
            isGameOver = true;
        }
    }



    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        isGameOver = false;
    }
   
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

}
