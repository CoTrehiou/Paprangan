using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class SoEvent : ScriptableObject
{
	private List<SoEventListener> listeners =
		new List<SoEventListener>();

	public void Raise()
	{
		for (int i = listeners.Count - 1; i >= 0; i--)
			listeners[i].OnEventRaised();
	}

	public void RegisterListener(SoEventListener listener)
	{ listeners.Add(listener); }

	public void UnregisterListener(SoEventListener listener)
	{ listeners.Remove(listener); }
}