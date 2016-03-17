using UnityEngine;
using System.Collections;
using System;

namespace QuestSystem
{
    public class QuestIdentifier : IQuestIdentifier
    {

        private int id;
        private int chainQuestID;
        private int sourceID;


        public int ChainQuestID
        {
            get
            {
                return chainQuestID;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
        }

        public int SourceID
        {
            get
            {
                return sourceID;
            }
        }
    }
}
