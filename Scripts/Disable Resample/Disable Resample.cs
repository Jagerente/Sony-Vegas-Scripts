using Sony.Vegas;

public class EntryPoint
{
    public void FromVegas(Vegas client)
    {
        foreach (Track track in client.Project.Tracks)
        {
            if (track.IsVideo())
            {
                foreach (var events in track.Events)
                {
                    ((VideoEvent)events).ResampleMode = VideoResampleMode.Disable;
                }
            }
        }
    }
}