using System;
using System.Collections;
using System.Diagnostics;
using TheForest.Utils;
using UnityEngine;

public class playerEnterCaveAction : MonoBehaviour
{
	private AnimatorStateInfo layer0;

	private int enterCaveHash = Animator.StringToHash("enterCave");

	private bool ignoreLighting;

	private void Start()
	{
	}

	private void setLightingSwitch(bool b)
	{
		this.ignoreLighting = b;
	}

	private void enterCave(GameObject go)
	{
		base.StartCoroutine(this.doCave(go, true));
	}

	private void exitCave(GameObject go)
	{
		base.StartCoroutine(this.doCave(go, false));
	}

	[DebuggerHidden]
	public IEnumerator doCave(GameObject posGo, bool enter)
	{
		playerEnterCaveAction.<doCave>c__Iterator196 <doCave>c__Iterator = new playerEnterCaveAction.<doCave>c__Iterator196();
		<doCave>c__Iterator.posGo = posGo;
		<doCave>c__Iterator.enter = enter;
		<doCave>c__Iterator.<$>posGo = posGo;
		<doCave>c__Iterator.<$>enter = enter;
		<doCave>c__Iterator.<>f__this = this;
		return <doCave>c__Iterator;
	}

	private void resetCaveParams()
	{
		LocalPlayer.Animator.SetIntegerReflected("enterCaveInt", 0);
	}
}
