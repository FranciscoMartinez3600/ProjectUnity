using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int lifes = 3;
    public int currentlifes;
    public TMP_Text textlifes;

    // Start is called before the first frame update
    void Start()
    {
        currentlifes = lifes;
    }

    // Update is called once per frame
    void Update()
    {
        lifes = currentlifes;

        textlifes.text = " lifes: " + lifes.ToString();

        if(lifes <= 0) 
        {
            lifes = 3;
            SceneManager.LoadScene(0);
        }
    }
}
