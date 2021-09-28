using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MLAPI.SceneManagement
{
    internal class DefaultSceneLoader : ISceneLoader
    {
        public IAsyncSceneOperation LoadSceneAsync(string sceneName, LoadSceneMode sceneMode, bool activateOnLoad)
        {
            var operation = SceneManager.LoadSceneAsync(sceneName, sceneMode);
            operation.allowSceneActivation = activateOnLoad;
            return new AsyncSceneLoadingOperation(operation);
        }

        public IAsyncSceneOperation UnloadSceneAsync(string sceneName)
        {
            var operation = SceneManager.UnloadSceneAsync(sceneName);
            return new AsyncSceneUnloadingOperation(operation);
        }
    }
}
