using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    [SerializeField] private GameObject FPCamera;
    [SerializeField] private GameObject TPCamera;
    [SerializeField] private GameObject FPAimCamera;
    [SerializeField] private GameObject TPAimCamera;
    [SerializeField] private GameObject ScopeCamera;
    private GameObject PCamera;
    private GameObject AimCamera;

    // singleton
    void Start()
    {
        PCamera = TPCamera;
        AimCamera = TPAimCamera;
    }

    void Update()
    {
       Aim(); 
    }
    private void ChangePoV() 
    {
        if (Input.GetButtonDown("Camera") & PCamera == TPCamera)
        {
            PCamera = FPCamera;
        }
        if (Input.GetButtonDown("Camera") & PCamera == FPCamera)
        {
            PCamera = TPCamera;
        }
    }

    private void Aim() 
    {
        if (Input.GetButtonDown("Fire2"))
        {
            PCamera.SetActive(false);
            AimCamera.SetActive(true);
        }
        
        if (Input.GetButtonUp("Fire2"))
        {
            AimCamera.SetActive(false);
            PCamera.SetActive(true);
        }

        if (Input.GetButtonDown("Fire2"))//& sniperRifle equiped
        {
            PCamera.SetActive(false);
            ScopeCamera.SetActive(true);
        }
        
        if (Input.GetButtonUp("Fire2"))//& sniperRifle equiped
        {
            ScopeCamera.SetActive(false);
            PCamera.SetActive(true);
        }
    }
}
