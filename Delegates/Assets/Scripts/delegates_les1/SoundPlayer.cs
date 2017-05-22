using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class SoundPlayer : MonoBehaviour
{
	
	// we declareren een handtekening zonder parameters (mag ook met)
	public delegate void SoundCompletedEventHandler(); // events geven we qua benaming altijd de suffix EventHandler

	// we declareren de daadwerkelijke variabele die kan verwijzen naar methods
	public SoundCompletedEventHandler SoundCompleted;

	/*
	 * Waarom zijn delegates & events handig?
	 * - ze kunnen je helpen met het switchen tussen states
	 * - super handig voor herbruikbaarheid
	 * - ze helpen je met encapsulation. Je brengt meer een API aan in je code en daardoor wordt je code meer 'loosely coupled'
	 * */
	public void PlaySound(){
		StartCoroutine(WaitForCompletion());
	}

	IEnumerator WaitForCompletion() {
		yield return new WaitForSeconds(3.0f);
		SoundCompleted();
	}




}
