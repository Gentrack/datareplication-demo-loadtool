﻿using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Gentrack.Tools.DataReplicationLoadTool.Providers;

namespace Gentrack.Tools.DataReplicationLoadTool.Consumers
{
    public interface IFullLoadFileConsumer
    {
        Task StartPolling(ConcurrentQueue<FileObject> fileQueue, CancellationToken cancelToken);
    }
}
