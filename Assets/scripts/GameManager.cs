using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public GameObject block;
    public float maxX;
    public Transform spawmPoint;
    public float spawmRate;

    bool gameStarted = false;

    public GameObject tapText;
    public TextMeshProUGUI scoreText;
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawming();
            gameStarted = true;
            tapText.SetActive(false);

        }
    }



    
    private void StartSpawming()
    {
        InvokeRepeating("SpawmBlock", 0.5f, spawmRate);
    }
    private void SpawmBlock()
    {
        Vector3 spawmPos = spawmPoint.position;
        spawmPos.x = Random.Range(-maxX, maxX);
        audioManager.PlaySFX(audioManager.roiClip);
        Instantiate(block, spawmPos, Quaternion.identity);

        score++;
        scoreText.text = score.ToString();
    }
}
