using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputText;
    [SerializeField] private Canvas menuCanvas;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float borderRadius;
    [SerializeField] private int defaultBallCount;


    private void Start()
    {
        PauseGame();
    }

    public void OnButtonClick()
    {
        if (inputText != null) defaultBallCount = int.Parse(inputText.text);
        for (int i = 0; i < defaultBallCount; i++)
        {
            var randomPos = Random.insideUnitCircle * borderRadius;

            Vector3 pos = new Vector3(
                randomPos.x,
                Random.Range(5, 20),
                randomPos.y);
            SpawnObject(pos);
        }
        ResumeGame();
        menuCanvas.enabled = false;
    }

    private void SpawnObject(Vector3 coordinates)
    {
        Instantiate(ballPrefab, coordinates, Quaternion.identity);
    }

    private void PauseGame()
    {
        mainCamera.GetComponent<FreeFlyCamera>().enabled = false;
        Time.timeScale = 0;
    }

    private void ResumeGame()
    {
        mainCamera.GetComponent<FreeFlyCamera>().enabled = true;
        Time.timeScale = 1;
    }
    
}
