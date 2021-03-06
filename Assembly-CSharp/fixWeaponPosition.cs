using System;
using System.Collections;
using System.Diagnostics;
using TheForest.Utils;
using UnityEngine;

public class fixWeaponPosition : MonoBehaviour
{
	private FakeParent parentScript;

	private float timer;

	private void Awake()
	{
		this.parentScript = base.transform.GetComponent<FakeParent>();
	}

	private void OnEnable()
	{
		base.StartCoroutine("FixPosition");
	}

	private void OnDisable()
	{
		base.StopCoroutine("FixPosition");
	}

	[DebuggerHidden]
	private IEnumerator FixPosition()
	{
		fixWeaponPosition.<FixPosition>c__Iterator5D <FixPosition>c__Iterator5D = new fixWeaponPosition.<FixPosition>c__Iterator5D();
		<FixPosition>c__Iterator5D.<>f__this = this;
		return <FixPosition>c__Iterator5D;
	}
}
