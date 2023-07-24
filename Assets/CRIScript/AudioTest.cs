using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{

    private void Start()
    {
        CriAudioManager.Instance.PlaySE("CueSheet_0", "bomb", 1);
    }
}
