using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource _music;

    private bool isPlaying = true;

    public void PlayerMusic()
    {
        isPlaying = _music.enabled = !isPlaying;
    }
}
