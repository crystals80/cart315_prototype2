using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickGoodPotion : MonoBehaviour
{
    public AudioClip pickupCoin;
    public TextMeshProUGUI Counter;

    void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(pickupCoin, transform.position);
        int score = int.Parse(Counter.text) + 1;
        Counter.text = score.ToString();
        Destroy(gameObject);
    }
}
