
public class RestartVideoTrackableEventHandler : DefaultTrackableEventHandler
{
    #region PROTECTED_METHODS

    protected override void OnTrackingLost()
    {
        mTrackableBehaviour.GetComponentInChildren<VideoController>().Stop();

        base.OnTrackingLost();
    }

	protected override void OnTrackingFound()
	{
		mTrackableBehaviour.GetComponentInChildren<VideoController>().Play();

		base.OnTrackingFound();
	}
    

    #endregion // PROTECTED_METHODS
}
