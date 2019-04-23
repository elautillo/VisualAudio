﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSyncColor : AudioSyncer
{
    public Color[] beatColors;
	public Color restColor;

	private int m_randomIndx;
	private Renderer m_rend;


    private void Start()
	{
		m_rend = GetComponent<Renderer>();
	}

	public override void OnUpdate()
	{
		base.OnUpdate();

		if (m_isBeat) return;

		m_rend.material.color = Color.Lerp(m_rend.material.color, restColor, restSmoothTime * Time.deltaTime);
	}

	public override void OnBeat()
	{
		base.OnBeat();

		Color _c = RandomColor();

		StopCoroutine("MoveToColor");
		StartCoroutine("MoveToColor", _c);
	}

    private Color RandomColor()
	{
		if (beatColors == null || beatColors.Length == 0) return Color.white;
		m_randomIndx = Random.Range(0, beatColors.Length);
		return beatColors[m_randomIndx];
	}
    
	private IEnumerator MoveToColor(Color _target)
	{
		Color _curr = m_rend.material.color;
		Color _initial = _curr;
		float _timer = 0;
		
		while (_curr != _target)
		{
			_curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;

			m_rend.material.color = _curr;

			yield return null;
		}

		m_isBeat = false;
	}
}
