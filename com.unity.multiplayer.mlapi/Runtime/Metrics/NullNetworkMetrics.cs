﻿using System.Collections.Generic;
using Unity.Multiplayer.NetworkProfiler.Models;

namespace MLAPI.Metrics
{
    public class NullNetworkMetrics : INetworkMetrics
    {
        public void TrackNetworkObject(NetworkObject networkObject)
        {
        }

        public void TrackNamedMessageSent(ulong receiverClientId, string messageName, ulong bytesCount)
        {
        }

        public void TrackNamedMessageSent(IReadOnlyCollection<ulong> receiverClientIds, string messageName, ulong bytesCount)
        {
        }

        public void TrackNamedMessageReceived(ulong senderClientId, string messageName, ulong bytesCount)
        {
        }

        public void TrackUnnamedMessageSent(ulong receiverClientId, ulong bytesCount)
        {
        }

        public void TrackUnnamedMessageSent(IReadOnlyCollection<ulong> receiverClientIds, ulong bytesCount)
        {
        }

        public void TrackUnnamedMessageReceived(ulong senderClientId, ulong bytesCount)
        {
        }

        public void TrackNetworkVariableDeltaSent(ulong receiverClientId, ulong networkObjectId, string gameObjectName, string variableName, ulong bytesCount)
        {
        }

        public void TrackNetworkVariableDeltaReceived(ulong senderClientId, ulong networkObjectId, string gameObjectName, string variableName, ulong bytesCount)
        {
        }

        public void TrackObjectSpawnSent(ulong receiverClientId, NetworkObjectIdentifier networkId, ulong bytesCount)
        {
        }

        public void TrackObjectSpawnReceived(ulong senderClientId, NetworkObjectIdentifier networkId, ulong bytesCount)
        {
        }

        public void TrackObjectDestroySent(ulong senderClientId, NetworkObjectIdentifier networkId, ulong bytesCount)
        {
        }

        public void TrackObjectDestroyReceived(ulong senderClientId, NetworkObjectIdentifier networkId, ulong bytesCount)
        {
        }

        public void DispatchFrame()
        {
        }
    }
}