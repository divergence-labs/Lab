
using UnityEngine;
using Wikitude;

public class ObjectTrackingController : SampleController
{
    ///* Name of the object that should trigger the instructions animation when pressed. */
    //private const string InstructionMarkerObjectName = "marker";
    ///* Name of the object that should trigger the siren when pressed. */
    //private const string SirenMarkerObjectName = "marker_siren";
    ///* Animation trigger names. */
    //private const string PlayTriggerName = "Play Instructions";
    //private const string SirenTriggerName = "Play Siren";
    //private const string IdleTriggerName = "Play Idle";

    ///* Flags to keep track of which animations are currently playing. */
    //private bool _isInstructionsAnimationPlaying = false;
    //private bool _isSirenAnimationPlaying = false;

    //protected override void Start() {
    //    base.Start();
    //    QualitySettings.shadowDistance = 8.0f;
    //}

    public GameObject LobbyProjection;
    public GameObject IdeationRoomProjection;
    public GameObject VideoWallProjection;
    public GameObject TechRoomsProjection;
    public GameObject VRDeskProjection;
    public GameObject SmartCartProjection;
    public string recognizedObject = "";

    public void OnObjectRecognized(ObjectTarget recognizedTarget) {
        /* Because the augmentation is set as a drawable on the ObjectTrackable, every time a target is recognized,
         * the prefab is reinstantiated and the animations are not playing.
         */
        //_isInstructionsAnimationPlaying = false;
        //_isSirenAnimationPlaying = false;

        if (recognizedTarget.Name == "Lobby")
        {
            VRDeskProjection.SetActive(false);
            IdeationRoomProjection.SetActive(false);
            VideoWallProjection.SetActive(false);
            TechRoomsProjection.SetActive(false);
            SmartCartProjection.SetActive(false);
            LobbyProjection.SetActive(true);
        }

        else if(recognizedTarget.Name == "IdeationRoom")
        {
            VRDeskProjection.SetActive(false);
            LobbyProjection.SetActive(false);
            TechRoomsProjection.SetActive(false);
            VideoWallProjection.SetActive(false);
            SmartCartProjection.SetActive(false);
            IdeationRoomProjection.SetActive(true);
        }

        else if(recognizedTarget.Name == "VideoWall")
        {
            VRDeskProjection.SetActive(false);
            LobbyProjection.SetActive(false);
            IdeationRoomProjection.SetActive(false);
            TechRoomsProjection.SetActive(false);
            SmartCartProjection.SetActive(false);
            VideoWallProjection.SetActive(true);
        }

        else if(recognizedTarget.Name == "TechRooms")
        {
            VRDeskProjection.SetActive(false);
            LobbyProjection.SetActive(false);
            IdeationRoomProjection.SetActive(false);
            VideoWallProjection.SetActive(false);
            SmartCartProjection.SetActive(false);
            TechRoomsProjection.SetActive(true);
        }

        else if(recognizedTarget.Name == "VRArea")
        {
            LobbyProjection.SetActive(false);
            IdeationRoomProjection.SetActive(false);
            VideoWallProjection.SetActive(false);
            TechRoomsProjection.SetActive(false);
            SmartCartProjection.SetActive(false);
            VRDeskProjection.SetActive(true);
        }
        else if(recognizedTarget.Name == "SmartCart")
        {
            IdeationRoomProjection.SetActive(false);
            LobbyProjection.SetActive(false);
            VideoWallProjection.SetActive(false);
            TechRoomsProjection.SetActive(false);
            VRDeskProjection.SetActive(false);
            SmartCartProjection.SetActive(true);
        }
    }

    protected override void Update() {
       
    }

    public void OnObjectLost(ObjectTarget objectLost)
    {
        IdeationRoomProjection.SetActive(false);
        LobbyProjection.SetActive(false);
        VideoWallProjection.SetActive(false);
        TechRoomsProjection.SetActive(false);
        VRDeskProjection.SetActive(false);
        SmartCartProjection.SetActive(false);
    }

    
}
