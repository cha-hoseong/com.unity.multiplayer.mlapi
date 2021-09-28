using MLAPI.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AsyncAddressableSceneOperation : IAsyncSceneOperation
{
    private AsyncOperationHandle internalOperation;

    public event System.Action<IAsyncSceneOperation> completed;

    public float progress => internalOperation.IsValid() ? internalOperation.PercentComplete : 0.0f;
    public bool isDone => internalOperation.IsValid() ? internalOperation.IsDone : false;


    public AsyncAddressableSceneOperation(AsyncOperationHandle operation)
    {
        operation.Completed += op => { completed?.Invoke(this); };
        internalOperation = operation;
    }
}
