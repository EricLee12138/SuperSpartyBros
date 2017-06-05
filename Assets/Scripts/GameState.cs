using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
    public GameObject titleContainer;
    
    public GameObject hudContainer;
  
    public static bool gameActive = false;


    // Use this for initialization

    public enum displayStates
    {
        titleScreen = 0,
        hudScreen
    }
    void Start()
    {
        changeDisplayState(displayStates.titleScreen);

    }

    public void changeDisplayState(displayStates newState)
    {
        hudContainer.SetActive(false);
        titleContainer.SetActive(false);
        switch (newState)
        {
            case displayStates.titleScreen:
                gameActive = false;
                titleContainer.SetActive(true);
                break;
            case displayStates.hudScreen:
                gameActive = true;
                hudContainer.SetActive(true);
                break;
        }

    }

    public void startGame()
    {
        changeDisplayState(displayStates.hudScreen);
    }
    
}
