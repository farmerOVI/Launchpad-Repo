using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class UiHandler : MonoBehaviour
{
    public GameObject menuUI;
    public GameObject levels;
    private GameManager gameManager;
 
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }
       public void OnStart()
       {
        menuUI.gameObject.SetActive(false);
        levels.gameObject.SetActive(true);

       }

    public void LevelSelection(int level)
    {
        gameManager.levelNum = level;
        SceneManager.LoadScene(1);
    }

   


}
