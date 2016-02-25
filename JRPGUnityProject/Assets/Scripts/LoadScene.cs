﻿using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

    public string sceneLoadTileName;

    // Use this for initialization
	IEnumerator Start () {
        if (sceneLoadTileName == GameStateController.playerSpawnPoint)
        {
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = transform.position;
            PlayerMovementController pmc = 
                (PlayerMovementController) player.GetComponent("PlayerMovementController");
            pmc.LastMove = GameStateController.playerSpawnDirection;
			float fadeTime = GameObject.Find ("Player").GetComponent<Fading>().BeginFade(1);
			yield return new WaitForSeconds (fadeTime);
        }
    }

    // Update is called once per frame
    void Update () {
    
    }
}
