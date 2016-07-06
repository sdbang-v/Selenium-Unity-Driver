﻿//////////////////////////////////////////////////////////////////////////
/// @file	UniqueId.cs
///
/// @author Colin Nickerson
///
/// @brief	A unique attribute (GUID) that can be added to any component.
///
/// @note 	Copyright 2016 Hutch Games Ltd. All rights reserved.
//////////////////////////////////////////////////////////////////////////

/************************ EXTERNAL NAMESPACES ***************************/

using UnityEngine;																// Unity 			(ref http://docs.unity3d.com/Documentation/ScriptReference/index.html)

/************************ REQUIRED COMPONENTS ***************************/

/************************** THE SCRIPT CLASS ****************************/

//////////////////////////////////////////////////////////////////////////
/// @brief	UniqueIdentifierAttribute class.  
//////////////////////////////////////////////////////////////////////////
public class UniqueIdentifierAttribute : PropertyAttribute {}

//////////////////////////////////////////////////////////////////////////
/// @brief	UniqueId class.  Stores a guid for the component it is 
/// attached to.  This isn't editable.
//////////////////////////////////////////////////////////////////////////
public class UniqueId : MonoBehaviour
{
    /***************************** PUBLIC DATA ******************************/
    [UniqueIdentifier]
    public string m_sUniqueGuid;
}
