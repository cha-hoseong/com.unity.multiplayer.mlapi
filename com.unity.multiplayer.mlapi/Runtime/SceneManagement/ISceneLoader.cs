using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MLAPI.SceneManagement
{
    public interface ISceneLoader
    {
        IAsyncSceneOperation LoadSceneAsync(string sceneName, LoadSceneMode sceneMode, bool activateOnLoad = true);
        IAsyncSceneOperation UnloadSceneAsync(string sceneName);
    }
}
