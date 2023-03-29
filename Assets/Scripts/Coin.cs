using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ParticleSystem particleEffect;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.UpdateScore();
            Destroy(gameObject);

            particleEffect.Play();
        }
    }
}
