﻿using NzbDrone.Core.ThingiProvider;
using NzbDrone.Core.Tv;

namespace NzbDrone.Core.Notifications
{
    public interface INotification : IProvider
    {
        string Link { get; }

        void OnGrab(GrabMessage grabMessage);
        void OnDownload(DownloadMessage message);
        void OnRename(Series series);
        void OnEpisodeFileDelete(EpisodeDeleteMessage deleteMessage);
        void OnSeriesDelete(SeriesDeleteMessage deleteMessage);
        void OnHealthIssue(HealthCheck.HealthCheck healthCheck);
        void ProcessQueue();
        bool SupportsOnGrab { get; }
        bool SupportsOnDownload { get; }
        bool SupportsOnUpgrade { get; }
        bool SupportsOnRename { get; }
        bool SupportsOnSeriesDelete { get; }
        bool SupportsOnEpisodeFileDelete { get; }
        bool SupportsOnEpisodeFileDeleteForUpgrade { get; }
        bool SupportsOnHealthIssue { get; }
    }
}
