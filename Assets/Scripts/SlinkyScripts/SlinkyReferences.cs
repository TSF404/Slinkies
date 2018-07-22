using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlinkyReferences : MonoBehaviour
{

    /* 
     * [ THIS SCRIPT STORES THE SLINKY-LEVEL REFERENCES ]
     * It acts like a middle ground between the 
     * slinky-level scripts.
     */



    private SlinkyGenerator gen;
    private SlinkyData data;



    #region AccessibleMethods
    /////////////////////////////////////////
    ///////////     ACCESSIBLE METHODS     //
    /////////////////////////////////////////

    /// <summary>
    /// Initialise the references
    /// </summary>
    public void Initialise()
    {
        SetupReferences();
    }

    #endregion




    #region PrivateMethods
    //////////////////////////////////////
    ///////////     PRIVATE METHODS     //
    //////////////////////////////////////


    /// <summary>
    /// This function sets up the references
    /// </summary>
    void SetupReferences()
    {
        gen = GetComponent<SlinkyGenerator>();
        data = GetComponent<SlinkyData>();


    }

    #endregion
    

    #region HelperFunctions
    ///////////////////////////////////////
    ///////////     HELPER FUNCTIONS     //
    ///////////////////////////////////////


    #endregion




}
