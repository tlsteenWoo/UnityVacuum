//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using UnityEngine.Events;

namespace AssemblyCSharp
{
	[Serializable]
	public class SpecificUnityEvent
	{
		public GameObject target;
		public UnityEvent unityEvent;

		public SpecificUnityEvent ()
		{
		}

		public bool Invoke()
		{
			if (unityEvent != null) {
				Debug.Log(string.Format("SpecificUnityEvent: Specific event triggered for {0}.", target));
				unityEvent.Invoke ();
				return true;
			}
			return false;
		}
		public bool Invoke(GameObject match)
		{
			if(target == match)
			{
				return Invoke();
			}
			return false;
		}
	}
}
