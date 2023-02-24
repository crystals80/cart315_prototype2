using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    void Start()
    {
        InvokeRepeating("ReduceTime", 1, 1);
    }
    void ReduceTime()
    {
        int currentTime = int.Parse(timeText.text) - 1;
        timeText.text = currentTime.ToString();
        if (currentTime == 0)
        {
            GetComponent<AudioSource>().Play();
            Invoke("Reload", 1.59f); // waits until sound is played to reload 
            Destroy(timeText);
        }
    }
    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
