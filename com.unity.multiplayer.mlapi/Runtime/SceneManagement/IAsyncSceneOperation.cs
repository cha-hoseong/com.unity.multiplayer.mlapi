using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MLAPI.SceneManagement
{
    public interface IAsyncSceneOperation
    {
        float progress { get; }
        bool isDone { get; }

        event System.Action<IAsyncSceneOperation> completed;
    }
}
