using MLAPI.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class AddressableSceneLoader : ISceneLoader
{
    private AsyncOperationHandle mainScene;
    private Dictionary<string, AsyncOperationHandle> subScenes = new Dictionary<string, AsyncOperationHandle>();

    public IAsyncSceneOperation LoadSceneAsync(string sceneName, LoadSceneMode sceneMode, bool activateOnLoad)
    {
        var operation = Addressables.LoadSceneAsync(sceneName, sceneMode, activateOnLoad);
        switch (sceneMode)
        {
            case LoadSceneMode.Single:
                mainScene = operation;
                break;
            case LoadSceneMode.Additive:
                subScenes.Add(sceneName, operation);
                break;
        }
        return new AsyncAddressableSceneOperation(operation);
    }

    public IAsyncSceneOperation UnloadSceneAsync(string sceneName)
    {
        var found = subScenes.TryGetValue(sceneName, out var sceneHandle);
        if (!found) return default;
        var operation = Addressables.UnloadSceneAsync(sceneHandle);
        return new AsyncAddressableSceneOperation(operation);
    }
}
