using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            playableDirector.gameObject.SetActive(true);
            playableDirector.Play();
        }
    }
}
