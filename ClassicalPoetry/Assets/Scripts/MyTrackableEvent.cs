/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using UnityEngine.UI;



namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>

	public delegate void found();

    public class MyTrackableEvent : MonoBehaviour,
                                                ITrackableEventHandler
    {
        #region PRIVATE_MEMBER_VARIABLES
 
        private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }

			canvas.SetActive (false);
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS

		public GameObject cube;
		public GameObject canvas;

		public static found textAppear;
		public static found textLost;

        private void OnTrackingFound()
        {	
			canvas.SetActive (true);
//			canvas.transform.localPosition =new Vector3(0,0,100f);

			textAppear ();

//			canvas.transform.parent = this.transform;
//			canvas.transform.localPosition = Vector3.zero;
        }


        private void OnTrackingLost()
		{
//			GameObject screen = GameObject.Find ("ScreenDisplay");
//			cube.transform.parent = screen.transform;
//			cube.transform.localPosition =new Vector3(0,0,0.2f);

//			GameObject screen = GameObject.Find ("ScreenDisplay");
//			canvas.transform.parent = screen.transform;
//			canvas.transform.localPosition =new Vector3(0,0,100f);

			textLost ();
        }

        #endregion // PRIVATE_METHODS
    }
}
