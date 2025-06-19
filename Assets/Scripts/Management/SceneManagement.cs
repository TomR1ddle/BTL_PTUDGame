using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static System.TimeZoneInfo;

public class SceneManagement : Singleton<SceneManagement>
{
    public string SceneTransitionName { get; private set; }
    public void SetTransitionName(string sceneTransitionName)
    {
        this.SceneTransitionName = sceneTransitionName;
    }
}