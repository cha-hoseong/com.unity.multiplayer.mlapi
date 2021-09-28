using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MLAPI.SceneManagement
{
    internal class AsyncSceneUnloadingOperation : IAsyncSceneOperation
    {
        private AsyncOperation internalOperation;

        public event System.Action<IAsyncSceneOperation> completed;

        public float progress => internalOperation?.progress ?? 0.0f;
        public bool isDone => internalOperation?.isDone ?? false;

        public AsyncSceneUnloadingOperation(AsyncOperation operation)
        {
            operation.completed += op => completed?.Invoke(this);
            internalOperation = operation;
        }
    }
}
