using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] float finishGameDaley = 2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", finishGameDaley);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
