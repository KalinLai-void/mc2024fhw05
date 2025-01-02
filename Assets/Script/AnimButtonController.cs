using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimButtonController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void Dance(string animTriggerName)
    {
        _animator.SetTrigger(animTriggerName);
    }
}
