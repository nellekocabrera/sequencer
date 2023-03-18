using System;
using System.Collections.Generic;
using UnityEngine;

namespace Nico.Sequencing
{
    public abstract class Sequencer : MonoBehaviour
    {
        /// <summary>
        ///     Starts the sequence from the given sequence list.
        /// </summary>
        protected async void StartSequence( List< Sequence > sequenceList )
        {
            foreach( Sequence sequence in sequenceList )
            {
                sequence.InitializeSequence();
                await sequence.BeginSequence();
                sequence.ExitSequence();
            }

            OnSequenceComplete();
        }


        /// <summary>
        ///     This method will be called once the sequencer has finished;
        /// </summary>
        protected abstract void OnSequenceComplete();
    }
}