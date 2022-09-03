using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject player;
    public GameObject enemy;
    public GameObject patrol;

    private void Awake()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        if(gameManager.levelNum == 1)
        {
            player.transform.position = new Vector3(-4, (float)-3.7, 0);
            enemy.transform.position = new Vector3(3, 2, 0);
            patrol.transform.position = new Vector3(-2, (float) 4.64, 0);
        }

        if (gameManager.levelNum == 2)
        {
            player.transform.position = new Vector3((float)6.23, (float)5.85, 0);
            enemy.transform.position = new Vector3((float)6.473, (float)-1.32, 0);
            patrol.transform.position = new Vector3((float)2.45, (float)5.21, 0);
        }
        if (gameManager.levelNum == 3)
        {
            player.transform.position = new Vector3((float)6.23, (float)0.88, 0);
            enemy.transform.position = new Vector3((float)1.04, (float)0.57, 0);
            patrol.transform.position = new Vector3((float)2.45, (float)5.21, 0);
        }
        if (gameManager.levelNum == 4)
        {
            player.transform.position = new Vector3((float)6.27, (float)-3.97, 0);
            enemy.transform.position = new Vector3((float)-3.83, (float)-3.92, 0);
            patrol.transform.position = new Vector3((float)-4.16, (float)3, 0);
        }
        if (gameManager.levelNum == 5)
        {
            player.transform.position = new Vector3((float)6.27, (float)6.15, 0);
            enemy.transform.position = new Vector3((float)-6.33, (float)-0.92, 0);
            patrol.transform.position = new Vector3((float)2.58, (float)4.19, 0);
        }








    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
