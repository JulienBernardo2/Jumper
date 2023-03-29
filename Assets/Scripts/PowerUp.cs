using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public ParticleSystem particleEffect;

    public void playParticle()
    {
        particleEffect.Play();
    }

    public void reactivateDoubleJump()
    {
        gameObject.SetActive(false);
        Invoke(nameof(Reactivate), 30);
    }

    private void Reactivate()
    {
        gameObject.SetActive(true);
    }
}
