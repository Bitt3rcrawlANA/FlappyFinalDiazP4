using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour

{
    AudioSource source;
    Collider2D soundTrigger;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        source.Play();

        if (other.GetComponent<BirdCtrl>() != null)
        {
            GameCtrl.Instance.BirdScored();
        }   
    }
}
