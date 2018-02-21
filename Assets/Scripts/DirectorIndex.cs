using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Windows.Speech;

public class DirectorIndex : MonoBehaviour
{

    [SerializeField] private List<PlayableDirector> _directors;

    private int _currentDirector = 1;
    
    public PlayableDirector AdvanceDirector()
    {
        var nextDirector = _currentDirector == 0 ? 1 : 0;

        // Ensure we stop the previous director, which also includes destroying the playable object graph.
        _directors[_currentDirector].Stop();
        _currentDirector = nextDirector;

        return _directors[nextDirector];
    }



}
