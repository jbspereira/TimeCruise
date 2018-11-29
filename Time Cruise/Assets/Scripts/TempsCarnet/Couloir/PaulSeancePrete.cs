﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PaulSeancePrete : MonoBehaviour
{
    public DialogueTrigger Jean;
    public DialogueTrigger Pierre;
    public UnityEvent OnEnd;

    public void StartDialogue()
    {
        StartCoroutine(Dialogue());
    }

    public IEnumerator Dialogue()
    {
        Jean.SetSentence("Paul, je suis prêt pour notre séance.");
        yield return new WaitForSeconds(3);
        Jean.ResetSentence();

        Pierre.SetSentence("J’arrive.");
        yield return new WaitForSeconds(3);
        Pierre.ResetSentence();

        OnEnd.Invoke();
    }
}
