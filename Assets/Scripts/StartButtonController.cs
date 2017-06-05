using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonController : MonoBehaviour {

    public GameObject upSprite;
    public GameObject downSprite;
    public float downTime = 0.1f;
    public GameState stateManager = null;
    private enum buttonstates {
        up = 0,
        down
    }

    private buttonstates currentState = buttonstates.up;

    private float nextStateTime = 0.0f;

    void Start() {
        upSprite.SetActive(true);
        downSprite.SetActive(false);
    }

    void OnMouseDown() {
        if(nextStateTime == 0.0f && currentState == StartButtonController.buttonstates.up)
        {
            nextStateTime = Time.time + downTime;
            upSprite.SetActive(false);
            downSprite.SetActive(true);
            currentState = StartButtonController.buttonstates.down;
        }
    }
	
	
	// Update is called once per frame
	void Update () {
        if (nextStateTime < Time.time) {
            nextStateTime = 0.0f;
            upSprite.SetActive(true);
            downSprite.SetActive(false);
            currentState = StartButtonController.buttonstates.up;
            stateManager.startGame();
        }

	}
}
