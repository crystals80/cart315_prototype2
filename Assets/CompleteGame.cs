using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteGame : MonoBehaviour
{
    //public GameObject complete;
    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
        Invoke("Restart", 2);
        //GameObject alert = Instantiate(complete, new Vector3(0.5f, 0.5f, 0), transform.rotation) as GameObject;
        Destroy(player.GetComponent<Rigidbody>());
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
