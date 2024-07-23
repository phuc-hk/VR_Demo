using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class XRRigMovement : MonoBehaviour
{
    public CharacterController characterController;
    public XROrigin xrOrigin;

    private void Start()
    {
        if (characterController == null)
        {
            characterController = GetComponent<CharacterController>();
        }

        if (xrOrigin == null)
        {
            xrOrigin = GetComponent<XROrigin>();
        }
    }

    private void Update()
    {
        SyncCharacterControllerWithXROrigin();
    }

    private void SyncCharacterControllerWithXROrigin()
    {
        Vector3 targetPosition = xrOrigin.CameraInOriginSpacePos;
        targetPosition.y = xrOrigin.Origin.transform.position.y; // Keep the Y position consistent with the XR Origin's Y position
        characterController.Move(targetPosition - characterController.transform.position);
    }
}
